//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDomainServices.TypeNameConflictResolution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'BaseTypeConflicts' DomainService.
    /// </summary>
    public sealed partial class BaseTypeConflicts : OpenRiaServices.Client.DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTypeConflicts"/> class.
        /// </summary>
        public BaseTypeConflicts() : 
                this(new Uri("TestDomainServices-TypeNameConflictResolution-BaseTypeConflicts.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTypeConflicts"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The BaseTypeConflicts service URI.</param>
        public BaseTypeConflicts(Uri serviceUri) : 
                this(OpenRiaServices.Client.DomainContext.CreateDomainClient(typeof(IBaseTypeConflictsContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTypeConflicts"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public BaseTypeConflicts(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="DomainContext"/> entity instances that have been loaded into this <see cref="BaseTypeConflicts"/> instance.
        /// </summary>
        public EntitySet<DomainContext> DomainContexts
        {
            get
            {
                return base.EntityContainer.GetEntitySet<DomainContext>();
            }
        }
        
        /// <summary>
        /// Gets the set of <see cref="Entity"/> entity instances that have been loaded into this <see cref="BaseTypeConflicts"/> instance.
        /// </summary>
        public EntitySet<Entity> Entities
        {
            get
            {
                return base.EntityContainer.GetEntitySet<Entity>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="DomainContext"/> entity instances using the 'GetDataContexts' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="DomainContext"/> entity instances.</returns>
        public EntityQuery<DomainContext> GetDataContextsQuery()
        {
            this.ValidateMethod("GetDataContextsQuery", null);
            return base.CreateQuery<DomainContext>("GetDataContexts", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="Entity"/> entity instances using the 'GetEntities' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="Entity"/> entity instances.</returns>
        public EntityQuery<Entity> GetEntitiesQuery()
        {
            this.ValidateMethod("GetEntitiesQuery", null);
            return base.CreateQuery<Entity>("GetEntities", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new BaseTypeConflictsEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'BaseTypeConflicts' DomainService.
        /// </summary>
        public interface IBaseTypeConflictsContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetDataContexts' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetDataContexts(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetDataContexts'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetDataContexts'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetDataContexts' operation.</returns>
            QueryResult<DomainContext> EndGetDataContexts(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetEntities' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetEntities(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetEntities' operation.</returns>
            QueryResult<Entity> EndGetEntities(IAsyncResult result);
        }
        
        internal sealed class BaseTypeConflictsEntityContainer : EntityContainer
        {
            
            public BaseTypeConflictsEntityContainer()
            {
                this.CreateEntitySet<DomainContext>(EntitySetOperations.None);
                this.CreateEntitySet<Entity>(EntitySetOperations.None);
            }
        }
    }
    
    /// <summary>
    /// The 'DomainContext' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion")]
    public sealed partial class DomainContext : OpenRiaServices.Client.Entity
    {
        
        private int _dataContextID;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnDataContextIDChanging(int value);
        partial void OnDataContextIDChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainContext"/> class.
        /// </summary>
        public DomainContext()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'DataContextID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int DataContextID
        {
            get
            {
                return this._dataContextID;
            }
            set
            {
                if ((this._dataContextID != value))
                {
                    this.OnDataContextIDChanging(value);
                    this.ValidateProperty("DataContextID", value);
                    this._dataContextID = value;
                    this.RaisePropertyChanged("DataContextID");
                    this.OnDataContextIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._dataContextID;
        }
    }
    
    /// <summary>
    /// The 'Entity' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion")]
    public sealed partial class Entity : OpenRiaServices.Client.Entity
    {
        
        private string _name;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        public Entity()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Name' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnNameChanging(value);
                    this.ValidateProperty("Name", value);
                    this._name = value;
                    this.RaisePropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._name;
        }
    }
}
namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    using TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'DomainServiceScenario1' DomainService.
    /// </summary>
    public sealed partial class DomainServiceScenario1 : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario1"/> class.
        /// </summary>
        public DomainServiceScenario1() : 
                this(new Uri("TestDomainServices-TypeNameConflictResolution-ExternalConflicts-DomainServiceScen" +
                            "ario1.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario1"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The DomainServiceScenario1 service URI.</param>
        public DomainServiceScenario1(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IDomainServiceScenario1Contract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario1"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public DomainServiceScenario1(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="MockEntity1"/> entity instances that have been loaded into this <see cref="DomainServiceScenario1"/> instance.
        /// </summary>
        public EntitySet<MockEntity1> MockEntity1s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<MockEntity1>();
            }
        }
        
        /// <summary>
        /// Gets the set of <see cref="MockEntity2"/> entity instances that have been loaded into this <see cref="DomainServiceScenario1"/> instance.
        /// </summary>
        public EntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2> MockEntity2s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="MockEntity1"/> entity instances using the 'GetTEntity1' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity1"/> entity instances.</returns>
        public EntityQuery<MockEntity1> GetTEntity1Query()
        {
            this.ValidateMethod("GetTEntity1Query", null);
            return base.CreateQuery<MockEntity1>("GetTEntity1", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="MockEntity2"/> entity instances using the 'GetTEntity2' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity2"/> entity instances.</returns>
        public EntityQuery<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2> GetTEntity2Query()
        {
            this.ValidateMethod("GetTEntity2Query", null);
            return base.CreateQuery<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2>("GetTEntity2", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new DomainServiceScenario1EntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'DomainServiceScenario1' DomainService.
        /// </summary>
        public interface IDomainServiceScenario1Contract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetTEntity1' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetTEntity1(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTEntity1'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTEntity1'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetTEntity1' operation.</returns>
            QueryResult<MockEntity1> EndGetTEntity1(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetTEntity2' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetTEntity2(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTEntity2'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTEntity2'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetTEntity2' operation.</returns>
            QueryResult<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2> EndGetTEntity2(IAsyncResult result);
        }
        
        internal sealed class DomainServiceScenario1EntityContainer : EntityContainer
        {
            
            public DomainServiceScenario1EntityContainer()
            {
                this.CreateEntitySet<MockEntity1>(EntitySetOperations.None);
                this.CreateEntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2>(EntitySetOperations.None);
            }
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'DomainServiceScenario2' DomainService.
    /// </summary>
    public sealed partial class DomainServiceScenario2 : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario2"/> class.
        /// </summary>
        public DomainServiceScenario2() : 
                this(new Uri("TestDomainServices-TypeNameConflictResolution-ExternalConflicts-DomainServiceScen" +
                            "ario2.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario2"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The DomainServiceScenario2 service URI.</param>
        public DomainServiceScenario2(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IDomainServiceScenario2Contract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainServiceScenario2"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public DomainServiceScenario2(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="MockEntity1"/> entity instances that have been loaded into this <see cref="DomainServiceScenario2"/> instance.
        /// </summary>
        public EntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1> MockEntity1s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1>();
            }
        }
        
        /// <summary>
        /// Gets the set of <see cref="MockEntity2"/> entity instances that have been loaded into this <see cref="DomainServiceScenario2"/> instance.
        /// </summary>
        public EntitySet<MockEntity2> MockEntity2s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<MockEntity2>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="MockEntity1"/> entity instances using the 'GetTEntity1' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity1"/> entity instances.</returns>
        public EntityQuery<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1> GetTEntity1Query()
        {
            this.ValidateMethod("GetTEntity1Query", null);
            return base.CreateQuery<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1>("GetTEntity1", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="MockEntity2"/> entity instances using the 'GetTEntity2' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity2"/> entity instances.</returns>
        public EntityQuery<MockEntity2> GetTEntity2Query()
        {
            this.ValidateMethod("GetTEntity2Query", null);
            return base.CreateQuery<MockEntity2>("GetTEntity2", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new DomainServiceScenario2EntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'DomainServiceScenario2' DomainService.
        /// </summary>
        public interface IDomainServiceScenario2Contract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetTEntity1' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetTEntity1(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTEntity1'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTEntity1'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetTEntity1' operation.</returns>
            QueryResult<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1> EndGetTEntity1(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetTEntity2' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetTEntity2(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTEntity2'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTEntity2'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetTEntity2' operation.</returns>
            QueryResult<MockEntity2> EndGetTEntity2(IAsyncResult result);
        }
        
        internal sealed class DomainServiceScenario2EntityContainer : EntityContainer
        {
            
            public DomainServiceScenario2EntityContainer()
            {
                this.CreateEntitySet<MockEntity2>(EntitySetOperations.None);
                this.CreateEntitySet<TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1>(EntitySetOperations.None);
            }
        }
    }
}
namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The 'MockEntity1' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion.ExternalConflicts.Namespace1")]
    public sealed partial class MockEntity1 : Entity
    {
        
        private int _entityID;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEntityIDChanging(int value);
        partial void OnEntityIDChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MockEntity1"/> class.
        /// </summary>
        public MockEntity1()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EntityID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EntityID
        {
            get
            {
                return this._entityID;
            }
            set
            {
                if ((this._entityID != value))
                {
                    this.OnEntityIDChanging(value);
                    this.ValidateProperty("EntityID", value);
                    this._entityID = value;
                    this.RaisePropertyChanged("EntityID");
                    this.OnEntityIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._entityID;
        }
    }
    
    /// <summary>
    /// The 'MockEntity2' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion.ExternalConflicts.Namespace1")]
    public sealed partial class MockEntity2 : Entity
    {
        
        private int _entityID;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEntityIDChanging(int value);
        partial void OnEntityIDChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MockEntity2"/> class.
        /// </summary>
        public MockEntity2()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EntityID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EntityID
        {
            get
            {
                return this._entityID;
            }
            set
            {
                if ((this._entityID != value))
                {
                    this.OnEntityIDChanging(value);
                    this.ValidateProperty("EntityID", value);
                    this._entityID = value;
                    this.RaisePropertyChanged("EntityID");
                    this.OnEntityIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._entityID;
        }
    }
}
namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The 'MockEntity1' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion.ExternalConflicts.Namespace2")]
    public sealed partial class MockEntity1 : Entity
    {
        
        private int _entityID;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEntityIDChanging(int value);
        partial void OnEntityIDChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MockEntity1"/> class.
        /// </summary>
        public MockEntity1()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EntityID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EntityID
        {
            get
            {
                return this._entityID;
            }
            set
            {
                if ((this._entityID != value))
                {
                    this.OnEntityIDChanging(value);
                    this.ValidateProperty("EntityID", value);
                    this._entityID = value;
                    this.RaisePropertyChanged("EntityID");
                    this.OnEntityIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._entityID;
        }
    }
    
    /// <summary>
    /// The 'MockEntity2' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu" +
        "tion.ExternalConflicts.Namespace2")]
    public sealed partial class MockEntity2 : Entity
    {
        
        private int _entityID;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEntityIDChanging(int value);
        partial void OnEntityIDChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MockEntity2"/> class.
        /// </summary>
        public MockEntity2()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EntityID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EntityID
        {
            get
            {
                return this._entityID;
            }
            set
            {
                if ((this._entityID != value))
                {
                    this.OnEntityIDChanging(value);
                    this.ValidateProperty("EntityID", value);
                    this._entityID = value;
                    this.RaisePropertyChanged("EntityID");
                    this.OnEntityIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._entityID;
        }
    }
}
