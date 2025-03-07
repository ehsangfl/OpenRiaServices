﻿using Microsoft.AspNetCore.Http;
using OpenRiaServices.Hosting.Wcf;
using OpenRiaServices.Server;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

#nullable disable

namespace OpenRiaServices.Hosting.AspNetCore.Operations
{
    class SubmitOperationInvoker : OperationInvoker
    {
        private readonly DataContractSerializer _parameterSerializer;

        public override string OperationName => "SubmitChanges";
        public override bool HasSideEffects => true;

        public SubmitOperationInvoker(DomainOperationEntry operation, SerializationHelper serializationHelper, OpenRiaServicesOptions options)
                : base(operation, DomainOperationType.Submit, serializationHelper, serializationHelper.GetSerializer(typeof(IEnumerable<ChangeSetEntry>)), options)
        {
            _parameterSerializer = serializationHelper.GetSerializer(typeof(IEnumerable<ChangeSetEntry>));
        }

        public override async Task Invoke(HttpContext context)
        {
            try
            {
                DomainService domainService = CreateDomainService(context);
                // Assert post ?

                if (context.Request.ContentType != "application/msbin1")
                {
                    context.Response.StatusCode = StatusCodes.Status415UnsupportedMediaType;
                    return;
                }

                var (_, inputs) = await ReadParametersFromBodyAsync(context);
                var changeSetEntries = (IEnumerable<ChangeSetEntry>)inputs[0];

                IEnumerable<ChangeSetEntry> result;
                try
                {
                    result = await ChangeSetProcessor.ProcessAsync(domainService, changeSetEntries);
                }
                catch (Exception ex) when (!ex.IsFatal())
                {
                    await WriteError(context, ex, domainService);
                    return;
                }

                // Set HTTP StatusCode on failed requests
                foreach (var change in result)
                {
                    if (change.HasError)
                    {
                        if (change.HasConflict)
                            context.Response.StatusCode = StatusCodes.Status409Conflict;
                        else
                            context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;

                        break;
                    }
                }

                await WriteResponse(context, result);
            }
            catch (OperationCanceledException) when (context.RequestAborted.IsCancellationRequested)
            {
                //Swallow OperationCanceledException and do nothing
            }
        }

        protected override object[] ReadParameters(System.Xml.XmlDictionaryReader reader)
        {
            reader.ReadStartElement("SubmitChanges");
            if (!reader.IsStartElement("changeSet"))
            {
                throw new BadHttpRequestException("missing changeSet");
            }

            var changeSet = _parameterSerializer.ReadObject(reader, verifyObjectName: false);
            reader.ReadEndElement();
            return new object[] { changeSet };
        }
    }
}
