﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.269
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ServiceReference1
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="clsBE_Usuario", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class clsBE_Usuario
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private IDField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UsuarioField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ClaveField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ApellidoField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NombreField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private EmailField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private TelefonoField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private PerfilField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property ID() As Integer
            Get
                Return Me.IDField
            End Get
            Set
                If (Me.IDField.Equals(value) <> true) Then
                    Me.IDField = value
                    Me.RaisePropertyChanged("ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property Usuario() As String
            Get
                Return Me.UsuarioField
            End Get
            Set
                If (Object.ReferenceEquals(Me.UsuarioField, value) <> true) Then
                    Me.UsuarioField = value
                    Me.RaisePropertyChanged("Usuario")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public Property Clave() As String
            Get
                Return Me.ClaveField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ClaveField, value) <> true) Then
                    Me.ClaveField = value
                    Me.RaisePropertyChanged("Clave")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public Property Apellido() As String
            Get
                Return Me.ApellidoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ApellidoField, value) <> true) Then
                    Me.ApellidoField = value
                    Me.RaisePropertyChanged("Apellido")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public Property Nombre() As String
            Get
                Return Me.NombreField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NombreField, value) <> true) Then
                    Me.NombreField = value
                    Me.RaisePropertyChanged("Nombre")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public Property Email() As String
            Get
                Return Me.EmailField
            End Get
            Set
                If (Object.ReferenceEquals(Me.EmailField, value) <> true) Then
                    Me.EmailField = value
                    Me.RaisePropertyChanged("Email")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public Property Telefono() As String
            Get
                Return Me.TelefonoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.TelefonoField, value) <> true) Then
                    Me.TelefonoField = value
                    Me.RaisePropertyChanged("Telefono")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public Property Perfil() As String
            Get
                Return Me.PerfilField
            End Get
            Set
                If (Object.ReferenceEquals(Me.PerfilField, value) <> true) Then
                    Me.PerfilField = value
                    Me.RaisePropertyChanged("Perfil")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.Service1Soap")>  _
    Public Interface Service1Soap
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorld(ByVal request As ServiceReference1.HelloWorldRequest) As ServiceReference1.HelloWorldResponse
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usuario del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValidarUsuario", ReplyAction:="*")>  _
        Function ValidarUsuario(ByVal request As ServiceReference1.ValidarUsuarioRequest) As ServiceReference1.ValidarUsuarioResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorld", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.HelloWorldRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorldResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.HelloWorldResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.HelloWorldResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HelloWorldResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public HelloWorldResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal HelloWorldResult As String)
            MyBase.New
            Me.HelloWorldResult = HelloWorldResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ValidarUsuarioRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ValidarUsuario", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.ValidarUsuarioRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.ValidarUsuarioRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ValidarUsuarioRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public usuario As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public password As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal usuario As String, ByVal password As String)
            MyBase.New
            Me.usuario = usuario
            Me.password = password
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ValidarUsuarioResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ValidarUsuarioResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.ValidarUsuarioResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.ValidarUsuarioResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ValidarUsuarioResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ValidarUsuarioResult As ServiceReference1.clsBE_Usuario
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ValidarUsuarioResult As ServiceReference1.clsBE_Usuario)
            MyBase.New
            Me.ValidarUsuarioResult = ValidarUsuarioResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface Service1SoapChannel
        Inherits ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.Service1Soap)
        Implements ServiceReference1.Service1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_Service1Soap_HelloWorld(ByVal request As ServiceReference1.HelloWorldRequest) As ServiceReference1.HelloWorldResponse Implements ServiceReference1.Service1Soap.HelloWorld
            Return MyBase.Channel.HelloWorld(request)
        End Function
        
        Public Function HelloWorld() As String
            Dim inValue As ServiceReference1.HelloWorldRequest = New ServiceReference1.HelloWorldRequest()
            inValue.Body = New ServiceReference1.HelloWorldRequestBody()
            Dim retVal As ServiceReference1.HelloWorldResponse = CType(Me,ServiceReference1.Service1Soap).HelloWorld(inValue)
            Return retVal.Body.HelloWorldResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_Service1Soap_ValidarUsuario(ByVal request As ServiceReference1.ValidarUsuarioRequest) As ServiceReference1.ValidarUsuarioResponse Implements ServiceReference1.Service1Soap.ValidarUsuario
            Return MyBase.Channel.ValidarUsuario(request)
        End Function
        
        Public Function ValidarUsuario(ByVal usuario As String, ByVal password As String) As ServiceReference1.clsBE_Usuario
            Dim inValue As ServiceReference1.ValidarUsuarioRequest = New ServiceReference1.ValidarUsuarioRequest()
            inValue.Body = New ServiceReference1.ValidarUsuarioRequestBody()
            inValue.Body.usuario = usuario
            inValue.Body.password = password
            Dim retVal As ServiceReference1.ValidarUsuarioResponse = CType(Me,ServiceReference1.Service1Soap).ValidarUsuario(inValue)
            Return retVal.Body.ValidarUsuarioResult
        End Function
    End Class
End Namespace