'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On



''' <summary>
''' Context for the RIA application.
''' </summary>
''' <remarks>
''' This context extends the base to make application services and types available
''' for consumption from code and xaml.
''' </remarks>
Partial Public NotInheritable Class WebContext
    Inherits Global.OpenRiaServices.Client.Authentication.WebContextBase
    
    #Region "Extensibility Method Definitions"

    ''' <summary>
    ''' This method is invoked from the constructor once initialization is complete and
    ''' can be used for further object setup.
    ''' </summary>
    Private Partial Sub OnCreated()
    End Sub

    #End Region
    
    
    ''' <summary>
    ''' Initializes a new instance of the WebContext class.
    ''' </summary>
    Public Sub New()
        MyBase.New
        Me.OnCreated
    End Sub
    
    ''' <summary>
    ''' Gets the context that is registered as a lifetime object with the current application.
    ''' </summary>
    ''' <exception cref="System.InvalidOperationException"> is thrown if there is no current application,
    ''' no contexts have been added, or more than one context has been added.
    ''' </exception>
    ''' <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
    Public Shadows Shared ReadOnly Property Current() As Global.RootNamespace.WebContext
        Get
            Return CType(Global.OpenRiaServices.Client.Authentication.WebContextBase.Current,Global.RootNamespace.WebContext)
        End Get
    End Property
    
    ''' <summary>
    ''' Gets a user representing the authenticated identity.
    ''' </summary>
    Public Shadows ReadOnly Property User() As Global.RootNamespace.TestNamespace.User1
        Get
            Return CType(MyBase.User,Global.RootNamespace.TestNamespace.User1)
        End Get
    End Property
End Class

Namespace TestNamespace
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'AuthenticationService1' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class AuthenticationService1
        Inherits Global.OpenRiaServices.Client.Authentication.AuthenticationDomainContextBase
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New Global.System.Uri("RootNamespace-TestNamespace-AuthenticationService1.svc", Global.System.UriKind.Relative))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The AuthenticationService1 service URI.</param>
        Public Sub New(ByVal serviceUri As Global.System.Uri)
            Me.New(Global.OpenRiaServices.Client.DomainContext.CreateDomainClient(GetType(Global.RootNamespace.TestNamespace.AuthenticationService1.IAuthenticationService1Contract), serviceUri, false))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As Global.OpenRiaServices.Client.DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="User1"/> entity instances that have been loaded into this <see cref="AuthenticationService1"/> instance.
        ''' </summary>
        Public ReadOnly Property User1s() As Global.OpenRiaServices.Client.EntitySet(Of Global.RootNamespace.TestNamespace.User1)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.RootNamespace.TestNamespace.User1)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'GetUser' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function GetUserQuery() As Global.OpenRiaServices.Client.EntityQuery(Of Global.RootNamespace.TestNamespace.User1)
            Me.ValidateMethod("GetUserQuery", Nothing)
            Return MyBase.CreateQuery(Of Global.RootNamespace.TestNamespace.User1)("GetUser", Nothing, false, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Login' query.
        ''' </summary>
        ''' <param name="userName">The value for the 'userName' parameter of the query.</param>
        ''' <param name="password">The value for the 'password' parameter of the query.</param>
        ''' <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        ''' <param name="customData">The value for the 'customData' parameter of the query.</param>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function LoginQuery(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String) As Global.OpenRiaServices.Client.EntityQuery(Of Global.RootNamespace.TestNamespace.User1)
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("userName", userName)
            parameters.Add("password", password)
            parameters.Add("isPersistent", isPersistent)
            parameters.Add("customData", customData)
            Me.ValidateMethod("LoginQuery", parameters)
            Return MyBase.CreateQuery(Of Global.RootNamespace.TestNamespace.User1)("Login", parameters, true, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Logout' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function LogoutQuery() As Global.OpenRiaServices.Client.EntityQuery(Of Global.RootNamespace.TestNamespace.User1)
            Me.ValidateMethod("LogoutQuery", Nothing)
            Return MyBase.CreateQuery(Of Global.RootNamespace.TestNamespace.User1)("Logout", Nothing, true, false)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As Global.OpenRiaServices.Client.EntityContainer
            Return New Global.RootNamespace.TestNamespace.AuthenticationService1.AuthenticationService1EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'AuthenticationService1' DomainService.
        ''' </summary>
        Public Interface IAuthenticationService1Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetUser' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false)>  _
            Function BeginGetUser(ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetUser'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            Function EndGetUser(ByVal result As Global.System.IAsyncResult) As Global.OpenRiaServices.Client.QueryResult(Of Global.RootNamespace.TestNamespace.User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Login' operation.
            ''' </summary>
            ''' <param name="userName">The value for the 'userName' parameter of this action.</param>
            ''' <param name="password">The value for the 'password' parameter of this action.</param>
            ''' <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            ''' <param name="customData">The value for the 'customData' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(true)>  _
            Function BeginLogin(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String, ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogin'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            Function EndLogin(ByVal result As Global.System.IAsyncResult) As Global.OpenRiaServices.Client.QueryResult(Of Global.RootNamespace.TestNamespace.User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Logout' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(true)>  _
            Function BeginLogout(ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogout'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            Function EndLogout(ByVal result As Global.System.IAsyncResult) As Global.OpenRiaServices.Client.QueryResult(Of Global.RootNamespace.TestNamespace.User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'SubmitChanges' operation.
            ''' </summary>
            ''' <param name="changeSet">The change-set to submit.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            Function BeginSubmitChanges(ByVal changeSet As Global.System.Collections.Generic.IEnumerable(Of Global.OpenRiaServices.Client.ChangeSetEntry), ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            ''' <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            Function EndSubmitChanges(ByVal result As Global.System.IAsyncResult) As Global.System.Collections.Generic.IEnumerable(Of Global.OpenRiaServices.Client.ChangeSetEntry)
        End Interface
        
        Friend NotInheritable Class AuthenticationService1EntityContainer
            Inherits Global.OpenRiaServices.Client.EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of Global.RootNamespace.TestNamespace.User1)(Global.OpenRiaServices.Client.EntitySetOperations.Edit)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'User1' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/RootNamespace.TestNamespace")>  _
    Partial Public NotInheritable Class User1
        Inherits Global.OpenRiaServices.Client.Entity
        Implements Global.System.Security.Principal.IIdentity, Global.System.Security.Principal.IPrincipal
        
        Private _name As String = String.Empty
        
        Private _roles As Global.System.Collections.Generic.IEnumerable(Of String)
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnNameChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnNameChanged()
        End Sub
        Private Partial Sub OnRolesChanging(ByVal value As Global.System.Collections.Generic.IEnumerable(Of String))
        End Sub
        Private Partial Sub OnRolesChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="User1"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Name' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                If (String.Equals(Me._name, value) = false) Then
                    Me.OnNameChanging(value)
                    Me.ValidateProperty("Name", value)
                    Me._name = value
                    Me.RaisePropertyChanged("Name")
                    Me.OnNameChanged
                    Me.RaisePropertyChanged("IsAuthenticated")
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'Roles' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Roles() As Global.System.Collections.Generic.IEnumerable(Of String)
            Get
                Return Me._roles
            End Get
            Set
                If (Object.Equals(Me._roles, value) = false) Then
                    Me.OnRolesChanging(value)
                    Me.ValidateProperty("Roles", value)
                    Me._roles = value
                    Me.RaisePropertyChanged("Roles")
                    Me.OnRolesChanged
                End If
            End Set
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_AuthenticationType() As String Implements Global.System.Security.Principal.IIdentity.AuthenticationType
            Get
                Return String.Empty
            End Get
        End Property
        
        '''<summary>
        '''Gets a value indicating whether the identity is authenticated.
        '''</summary>
        '''<remarks>
        '''This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        '''</remarks>
        Public ReadOnly Property IsAuthenticated() As Boolean Implements Global.System.Security.Principal.IIdentity.IsAuthenticated
            Get
                Return (true <> String.IsNullOrEmpty(Me.Name))
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_Name() As String Implements Global.System.Security.Principal.IIdentity.Name
            Get
                Return Me.Name
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IPrincipal_Identity() As Global.System.Security.Principal.IIdentity Implements Global.System.Security.Principal.IPrincipal.Identity
            Get
                Return Me
            End Get
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._name
        End Function
        
        '''<summary>
        '''Return whether the principal is in the role.
        '''</summary>
        '''<remarks>
        '''Returns whether the specified role is contained in the roles.
        '''This implementation is case sensitive.
        '''</remarks>
        '''<param name="role">The name of the role for which to check membership.</param>
        '''<returns>Whether the principal is in the role.</returns>
        Public Function IsInRole(ByVal role As String) As Boolean Implements Global.System.Security.Principal.IPrincipal.IsInRole
            If (Me.Roles Is Nothing) Then
                Return false
            End If
            Return Global.System.Linq.Enumerable.Contains(Me.Roles, role)
        End Function
    End Class
End Namespace
