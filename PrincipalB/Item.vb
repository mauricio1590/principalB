Public Class Item
    Private _item As String
    Private _descripcion As String
    Private _cantidad As Double
    Private _bultos As Double
    Private _pesoBruto As Double
    Private _pesoNeto As Double
    Private _valorUnitario As Double
    Private _valorTotal As Double

    Public Sub New(item As String, descripcion As String, cantidad As Double, bultos As Double, pesoBruto As Double, pesoNeto As Double, valorUnitario As Double, valorTotal As Double)
        _item = item
        _descripcion = descripcion
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Bultos As Double
        Get
            Return _bultos
        End Get
        Set(value As Double)
            _bultos = value
        End Set
    End Property

    Public Property PesoBruto As Double
        Get
            Return _pesoBruto
        End Get
        Set(value As Double)
            _pesoBruto = value
        End Set
    End Property

    Public Property PesoNeto As Double
        Get
            Return _pesoNeto
        End Get
        Set(value As Double)
            _pesoNeto = value
        End Set
    End Property

    Public Property ValorUnitario As Double
        Get
            Return _valorUnitario
        End Get
        Set(value As Double)
            _valorUnitario = value
        End Set
    End Property

    Public Property ValorTotal As Double
        Get
            Return _valorTotal
        End Get
        Set(value As Double)
            _valorTotal = value
        End Set
    End Property
End Class
