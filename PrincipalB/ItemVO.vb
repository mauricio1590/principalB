Public Class ItemVO
    Private _item As String
    Private _descripcionItem As String
    Private _cantidad As String
    Private _bultos As String
    Private _pesoBruto As String
    Private _pesoNeto As String
    Private _valorUnitario As String
    Private _valorTotal As String

    Public Sub New(item As String, descripcionItem As String, cantidad As String, bultos As String, pesoBruto As String, pesoNeto As String, valorUnitario As String, valorTotal As String)
        _item = item
        _descripcionItem = descripcionItem
        _cantidad = cantidad
        _bultos = bultos
        _pesoBruto = pesoBruto
        _pesoNeto = pesoNeto
        _valorUnitario = valorUnitario
        _valorTotal = valorTotal
    End Sub

    Public Property Item As String
        Get
            Return _item
        End Get
        Set(value As String)
            _item = value
        End Set
    End Property

    Public Property DescripcionItem As String
        Get
            Return _descripcionItem
        End Get
        Set(value As String)
            _descripcionItem = value
        End Set
    End Property

    Public Property Cantidad As String
        Get
            Return _cantidad
        End Get
        Set(value As String)
            _cantidad = value
        End Set
    End Property

    Public Property Bultos As String
        Get
            Return _bultos
        End Get
        Set(value As String)
            _bultos = value
        End Set
    End Property

    Public Property PesoBruto As String
        Get
            Return _pesoBruto
        End Get
        Set(value As String)
            _pesoBruto = value
        End Set
    End Property

    Public Property PesoNeto As String
        Get
            Return _pesoNeto
        End Get
        Set(value As String)
            _pesoNeto = value
        End Set
    End Property

    Public Property ValorUnitario As String
        Get
            Return _valorUnitario
        End Get
        Set(value As String)
            _valorUnitario = value
        End Set
    End Property

    Public Property ValorTotal As String
        Get
            Return _valorTotal
        End Get
        Set(value As String)
            _valorTotal = value
        End Set
    End Property
End Class
