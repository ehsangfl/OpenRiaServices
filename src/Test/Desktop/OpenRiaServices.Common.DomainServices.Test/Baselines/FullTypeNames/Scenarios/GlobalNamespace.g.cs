//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



/// <summary>
/// Enum GlobalNamespaceTest_Enum_NonShared
/// </summary>
public enum GlobalNamespaceTest_Enum_NonShared
{
    
    /// <summary>
    /// DefaultValue
    /// </summary>
    DefaultValue = 0,
    
    /// <summary>
    /// NonDefaultValue
    /// </summary>
    NonDefaultValue = 1,
}
namespace GlobalNamespaceTest
{
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'GlobalNamespaceTest_DomainService' DomainService.
    /// </summary>
    [global::GlobalNamespaceTest_Attribute(EnumProperty=global::GlobalNamespaceTest_Enum.NonDefaultValue)]
    public sealed partial class GlobalNamespaceTest_DomainContext : global::OpenRiaServices.Client.DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class.
        /// </summary>
        public GlobalNamespaceTest_DomainContext() : 
                this(new global::System.Uri("GlobalNamespaceTest-GlobalNamespaceTest_DomainService.svc", global::System.UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The GlobalNamespaceTest_DomainService service URI.</param>
        public GlobalNamespaceTest_DomainContext(global::System.Uri serviceUri) : 
                this(global::OpenRiaServices.Client.DomainContext.CreateDomainClient(typeof(global::GlobalNamespaceTest.GlobalNamespaceTest_DomainContext.IGlobalNamespaceTest_DomainServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public GlobalNamespaceTest_DomainContext(global::OpenRiaServices.Client.DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="GlobalNamespaceTest_Entity"/> entity instances that have been loaded into this <see cref="GlobalNamespaceTest_DomainContext"/> instance.
        /// </summary>
        public global::OpenRiaServices.Client.EntitySet<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity> GlobalNamespaceTest_Entities
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'GetEntities' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.EntityQuery<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity> GetEntitiesQuery()
        {
            this.ValidateMethod("GetEntitiesQuery", null);
            return base.CreateQuery<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity>("GetEntities", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'ReadEntities' query.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.EntityQuery<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity> ReadEntitiesQuery([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter)
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("ReadEntitiesQuery", parameters);
            return base.CreateQuery<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity>("ReadEntities", parameters, false, true);
        }
        
        /// <summary>
        /// Invokes the 'CustomUpdateEntity' method of the specified <see cref="GlobalNamespaceTest_Entity"/> entity.
        /// </summary>
        /// <param name="entity">The <see cref="GlobalNamespaceTest_Entity"/> entity instance.</param>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter for this action.</param>
        public void CustomUpdateEntity(global::GlobalNamespaceTest.GlobalNamespaceTest_Entity entity, global::GlobalNamespaceTest_Enum enumParameter)
        {
            entity.CustomUpdateEntity(enumParameter);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.InvokeOperation<global::GlobalNamespaceTest_Enum> InvokeReturn([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter, global::System.Action<global::OpenRiaServices.Client.InvokeOperation<global::GlobalNamespaceTest_Enum>> callback, object userState)
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeReturn", parameters);
            return this.InvokeOperation<global::GlobalNamespaceTest_Enum>("InvokeReturn", typeof(global::GlobalNamespaceTest_Enum), parameters, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.InvokeOperation<global::GlobalNamespaceTest_Enum> InvokeReturn([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter)
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeReturn", parameters);
            return this.InvokeOperation<global::GlobalNamespaceTest_Enum>("InvokeReturn", typeof(global::GlobalNamespaceTest_Enum), parameters, true, null, null);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::System.Threading.Tasks.Task<global::OpenRiaServices.Client.InvokeResult<global::GlobalNamespaceTest_Enum>> InvokeReturnAsync([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter, global::System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeReturn", parameters);
            return this.InvokeOperationAsync<global::GlobalNamespaceTest_Enum>("InvokeReturn", parameters, true, cancellationToken);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.InvokeOperation InvokeVoid([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter, global::System.Action<global::OpenRiaServices.Client.InvokeOperation> callback, object userState)
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeVoid", parameters);
            return this.InvokeOperation("InvokeVoid", typeof(void), parameters, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::OpenRiaServices.Client.InvokeOperation InvokeVoid([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter)
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeVoid", parameters);
            return this.InvokeOperation("InvokeVoid", typeof(void), parameters, true, null, null);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [global::GlobalNamespaceTest_Attribute()]
        public global::System.Threading.Tasks.Task<global::OpenRiaServices.Client.InvokeResult> InvokeVoidAsync([global::GlobalNamespaceTest_ValidationAttribute()] global::GlobalNamespaceTest_Enum enumParameter, global::System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            global::System.Collections.Generic.Dictionary<string, object> parameters = new global::System.Collections.Generic.Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeVoid", parameters);
            return this.InvokeOperationAsync("InvokeVoid", parameters, true, cancellationToken);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override global::OpenRiaServices.Client.EntityContainer CreateEntityContainer()
        {
            return new global::GlobalNamespaceTest.GlobalNamespaceTest_DomainContext.GlobalNamespaceTest_DomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'GlobalNamespaceTest_DomainService' DomainService.
        /// </summary>
        public interface IGlobalNamespaceTest_DomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetEntities' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [global::OpenRiaServices.Client.HasSideEffects(false)]
            global::System.IAsyncResult BeginGetEntities(global::System.AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetEntities' operation.</returns>
            global::OpenRiaServices.Client.QueryResult<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity> EndGetEntities(global::System.IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'InvokeReturn' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [global::OpenRiaServices.Client.HasSideEffects(true)]
            global::System.IAsyncResult BeginInvokeReturn(global::GlobalNamespaceTest_Enum enumParameter, global::System.AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginInvokeReturn'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginInvokeReturn'.</param>
            /// <returns>The 'GlobalNamespaceTest_Enum' returned from the 'InvokeReturn' operation.</returns>
            global::GlobalNamespaceTest_Enum EndInvokeReturn(global::System.IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'InvokeVoid' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [global::OpenRiaServices.Client.HasSideEffects(true)]
            global::System.IAsyncResult BeginInvokeVoid(global::GlobalNamespaceTest_Enum enumParameter, global::System.AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginInvokeVoid'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginInvokeVoid'.</param>
            void EndInvokeVoid(global::System.IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'ReadEntities' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [global::OpenRiaServices.Client.HasSideEffects(false)]
            global::System.IAsyncResult BeginReadEntities(global::GlobalNamespaceTest_Enum enumParameter, global::System.AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginReadEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginReadEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'ReadEntities' operation.</returns>
            global::OpenRiaServices.Client.QueryResult<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity> EndReadEntities(global::System.IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            global::System.IAsyncResult BeginSubmitChanges(global::System.Collections.Generic.IEnumerable<global::OpenRiaServices.Client.ChangeSetEntry> changeSet, global::System.AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            global::System.Collections.Generic.IEnumerable<global::OpenRiaServices.Client.ChangeSetEntry> EndSubmitChanges(global::System.IAsyncResult result);
        }
        
        internal sealed class GlobalNamespaceTest_DomainContextEntityContainer : global::OpenRiaServices.Client.EntityContainer
        {
            
            public GlobalNamespaceTest_DomainContextEntityContainer()
            {
                this.CreateEntitySet<global::GlobalNamespaceTest.GlobalNamespaceTest_Entity>(global::OpenRiaServices.Client.EntitySetOperations.All);
            }
        }
    }
    
    /// <summary>
    /// The 'GlobalNamespaceTest_Entity' entity class.
    /// </summary>
    [global::GlobalNamespaceTest_Attribute()]
    [global::GlobalNamespaceTest_ValidationAttribute()]
    [global::System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.datacontract.org/2004/07/GlobalNamespaceTest")]
    public sealed partial class GlobalNamespaceTest_Entity : global::OpenRiaServices.Client.Entity
    {
        
        private global::GlobalNamespaceTest_Enum _enumProperty;
        
        private global::GlobalNamespaceTest_Enum_NonShared _enumProperty_NonShared;
        
        private int _key;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEnumPropertyChanging(global::GlobalNamespaceTest_Enum value);
        partial void OnEnumPropertyChanged();
        partial void OnEnumProperty_NonSharedChanging(global::GlobalNamespaceTest_Enum_NonShared value);
        partial void OnEnumProperty_NonSharedChanged();
        partial void OnKeyChanging(int value);
        partial void OnKeyChanged();
        partial void OnCustomUpdateEntityInvoking(global::GlobalNamespaceTest_Enum enumParameter);
        partial void OnCustomUpdateEntityInvoked();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_Entity"/> class.
        /// </summary>
        public GlobalNamespaceTest_Entity()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EnumProperty' value.
        /// </summary>
        [global::GlobalNamespaceTest_ValidationAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::GlobalNamespaceTest_Enum EnumProperty
        {
            get
            {
                return this._enumProperty;
            }
            set
            {
                if ((this._enumProperty != value))
                {
                    this.OnEnumPropertyChanging(value);
                    this.RaiseDataMemberChanging("EnumProperty");
                    this.ValidateProperty("EnumProperty", value);
                    this._enumProperty = value;
                    this.RaiseDataMemberChanged("EnumProperty");
                    this.OnEnumPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EnumProperty_NonShared' value.
        /// </summary>
        [global::GlobalNamespaceTest_ValidationAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::GlobalNamespaceTest_Enum_NonShared EnumProperty_NonShared
        {
            get
            {
                return this._enumProperty_NonShared;
            }
            set
            {
                if ((this._enumProperty_NonShared != value))
                {
                    this.OnEnumProperty_NonSharedChanging(value);
                    this.RaiseDataMemberChanging("EnumProperty_NonShared");
                    this.ValidateProperty("EnumProperty_NonShared", value);
                    this._enumProperty_NonShared = value;
                    this.RaiseDataMemberChanged("EnumProperty_NonShared");
                    this.OnEnumProperty_NonSharedChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Key' value.
        /// </summary>
        [global::GlobalNamespaceTest_ValidationAttribute()]
        [global::System.ComponentModel.DataAnnotations.CustomValidationAttribute(typeof(global::GlobalNamespaceTest_Validation), "Validate")]
        [global::System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue=true)]
        [global::System.ComponentModel.DataAnnotations.KeyAttribute()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Key
        {
            get
            {
                return this._key;
            }
            set
            {
                if ((this._key != value))
                {
                    this.OnKeyChanging(value);
                    this.ValidateProperty("Key", value);
                    this._key = value;
                    this.RaisePropertyChanged("Key");
                    this.OnKeyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'CustomUpdateEntity' action has been invoked on this entity.
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateField=false)]
        public bool IsCustomUpdateEntityInvoked
        {
            get
            {
                return base.IsActionInvoked("CustomUpdateEntity");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'CustomUpdateEntity' method can be invoked on this entity.
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateField=false)]
        public bool CanCustomUpdateEntity
        {
            get
            {
                return base.CanInvokeAction("CustomUpdateEntity");
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._key;
        }
        
        /// <summary>
        /// Invokes the 'CustomUpdateEntity' action on this entity.
        /// </summary>
        /// <param name="enumParameter">The value to pass to the server method's 'enumParameter' parameter.</param>
        [global::GlobalNamespaceTest_Attribute()]
        [global::OpenRiaServices.Client.EntityAction("CustomUpdateEntity", AllowMultipleInvocations=false)]
        public void CustomUpdateEntity(global::GlobalNamespaceTest_Enum enumParameter)
        {
            this.OnCustomUpdateEntityInvoking(enumParameter);
            base.InvokeAction("CustomUpdateEntity", enumParameter);
            this.OnCustomUpdateEntityInvoked();
        }
    }
}
