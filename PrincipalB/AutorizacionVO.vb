Public Class AutorizacionVO
    Private Fecha As String
    Private Cliente As String
    Private UsuOperador As String
    Private Placa As String
    Private FormularioIngreso As String
    Private NRemision As String
    Private Peso As String
    Private Descripcion As String

    Public Sub New(fecha As String, cliente As String, usuOperador As String, placa As String, formularioIngreso As String, nRemision As String, peso As String, descripcion As String)
        Me.Fecha1 = fecha
        Me.Cliente1 = cliente
        Me.UsuOperador1 = usuOperador
        Me.Placa1 = placa
        Me.FormularioIngreso1 = formularioIngreso
        Me.NRemision1 = nRemision
        Me.Peso1 = peso
        Me.Descripcion1 = descripcion
    End Sub

    Public Property Fecha1 As String
        Get
            Return Fecha
        End Get
        Set(value As String)
            Fecha = value
        End Set
    End Property

    Public Property Cliente1 As String
        Get
            Return Cliente
        End Get
        Set(value As String)
            Cliente = value
        End Set
    End Property

    Public Property UsuOperador1 As String
        Get
            Return UsuOperador
        End Get
        Set(value As String)
            UsuOperador = value
        End Set
    End Property

    Public Property Placa1 As String
        Get
            Return Placa
        End Get
        Set(value As String)
            Placa = value
        End Set
    End Property

    Public Property FormularioIngreso1 As String
        Get
            Return FormularioIngreso
        End Get
        Set(value As String)
            FormularioIngreso = value
        End Set
    End Property

    Public Property NRemision1 As String
        Get
            Return NRemision
        End Get
        Set(value As String)
            NRemision = value
        End Set
    End Property

    Public Property Peso1 As String
        Get
            Return Peso
        End Get
        Set(value As String)
            Peso = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
End Class
