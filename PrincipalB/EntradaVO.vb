Public Class EntradaVO
    Private _cliente As String
    Private _nitCliente As String
    Private _dirCliente As String
    Private _fechaGeneracion As String
    Private _noRemision As String
    Private _subpartida As String
    Private _item As String
    Private _descripcionItem As String
    Private _tipoEmbalaje As String
    Private _cantidad As String
    Private _bultos As String
    Private _pesoBruto As String
    Private _pesoNeto As String
    Private _valorUnitario As String
    Private _valorTotal As String
    Private _placas As Array
    Private _subpartidas As List(Of String)
    Private _totalCantidad As String
    Private _totalBultos As String
    Private _totalPesoBruto As String
    Private _totalPesoNeto As String
    Private _totalValorUnitario As String
    Private _totalTotal As String
    Private _tasaDeCambio As String

    Public Sub New(cliente As String, nitCliente As String, dirCliente As String, fechaGeneracion As String, noRemision As String, subpartida As String, item As String, descripcionItem As String, tipoEmbalaje As String, cantidad As String, bultos As String, pesoBruto As String, pesoNeto As String, valorUnitario As String, valorTotal As String, placas As Array, subpartidas As List(Of String), totalCantidad As String, totalBultos As String, totalPesoBruto As String, totalPesoNeto As String, totalValorUnitario As String, totalTotal As String, tasaDeCambio As String)
        _cliente = cliente
        _nitCliente = nitCliente
        _dirCliente = dirCliente
        _fechaGeneracion = fechaGeneracion
        _noRemision = noRemision
        _subpartida = subpartida
        _item = item
        _descripcionItem = descripcionItem
        _tipoEmbalaje = tipoEmbalaje
        _cantidad = cantidad
        _bultos = bultos
        _pesoBruto = pesoBruto
        _pesoNeto = pesoNeto
        _valorUnitario = valorUnitario
        _valorTotal = valorTotal
        _placas = placas
        _subpartidas = subpartidas
        _totalCantidad = totalCantidad
        _totalBultos = totalBultos
        _totalPesoBruto = totalPesoBruto
        _totalPesoNeto = totalPesoNeto
        _totalValorUnitario = totalValorUnitario
        _totalTotal = totalTotal
        _tasaDeCambio = tasaDeCambio
    End Sub

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    Public Property NitCliente As String
        Get
            Return _nitCliente
        End Get
        Set(value As String)
            _nitCliente = value
        End Set
    End Property

    Public Property DirCliente As String
        Get
            Return _dirCliente
        End Get
        Set(value As String)
            _dirCliente = value
        End Set
    End Property

    Public Property FechaGeneracion As String
        Get
            Return _fechaGeneracion
        End Get
        Set(value As String)
            _fechaGeneracion = value
        End Set
    End Property

    Public Property NoRemision As String
        Get
            Return _noRemision
        End Get
        Set(value As String)
            _noRemision = value
        End Set
    End Property

    Public Property Subpartida As String
        Get
            Return _subpartida
        End Get
        Set(value As String)
            _subpartida = value
        End Set
    End Property

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

    Public Property TipoEmbalaje As String
        Get
            Return _tipoEmbalaje
        End Get
        Set(value As String)
            _tipoEmbalaje = value
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

    Public Property Placas As Array
        Get
            Return _placas
        End Get
        Set(value As Array)
            _placas = value
        End Set
    End Property

    Public Property Subpartidas As List(Of String)
        Get
            Return _subpartidas
        End Get
        Set(value As List(Of String))
            _subpartidas = value
        End Set
    End Property

    Public Property TotalCantidad As String
        Get
            Return _totalCantidad
        End Get
        Set(value As String)
            _totalCantidad = value
        End Set
    End Property

    Public Property TotalBultos As String
        Get
            Return _totalBultos
        End Get
        Set(value As String)
            _totalBultos = value
        End Set
    End Property

    Public Property TotalPesoBruto As String
        Get
            Return _totalPesoBruto
        End Get
        Set(value As String)
            _totalPesoBruto = value
        End Set
    End Property

    Public Property TotalPesoNeto As String
        Get
            Return _totalPesoNeto
        End Get
        Set(value As String)
            _totalPesoNeto = value
        End Set
    End Property

    Public Property TotalValorUnitario As String
        Get
            Return _totalValorUnitario
        End Get
        Set(value As String)
            _totalValorUnitario = value
        End Set
    End Property

    Public Property TotalTotal As String
        Get
            Return _totalTotal
        End Get
        Set(value As String)
            _totalTotal = value
        End Set
    End Property

    Public Property TasaDeCambio As String
        Get
            Return _tasaDeCambio
        End Get
        Set(value As String)
            _tasaDeCambio = value
        End Set
    End Property
End Class
