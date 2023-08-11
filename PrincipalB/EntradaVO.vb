Public Class EntradaVO
    Private cliente As String
    Private nitCliente As String
    Private dirCliente As String
    Private fechaGeneracion As String
    Private noRemision As String
    Private subpartida As String
    Private tipoEmbalaje As String
    Private items As List(Of ItemVO)
    Private placas As List(Of String)
    Private subpartidas As List(Of String)
    Private totalCantidad As String
    Private totalBultos As String
    Private totalPesoBruto As String
    Private totalPesoNeto As String
    Private totalValorUnitario As String
    Private totalTotal As String
    Private tasaDeCambio As String

    Public Sub New(cliente As String, nitCliente As String, dirCliente As String, fechaGeneracion As String, noRemision As String, subpartida As String, tipoEmbalaje As String, items As List(Of ItemVO), placas As List(Of String), subpartidas As List(Of String), totalCantidad As String, totalBultos As String, totalPesoBruto As String, totalPesoNeto As String, totalValorUnitario As String, totalTotal As String, tasaDeCambio As String)
        Me.cliente = cliente
        Me.nitCliente = nitCliente
        Me.dirCliente = dirCliente
        Me.fechaGeneracion = fechaGeneracion
        Me.noRemision = noRemision
        Me.subpartida = subpartida
        Me.tipoEmbalaje = tipoEmbalaje
        Me.items = items
        Me.placas = placas
        Me.subpartidas = subpartidas
        Me.totalCantidad = totalCantidad
        Me.totalBultos = totalBultos
        Me.totalPesoBruto = totalPesoBruto
        Me.totalPesoNeto = totalPesoNeto
        Me.totalValorUnitario = totalValorUnitario
        Me.totalTotal = totalTotal
        Me.tasaDeCambio = tasaDeCambio
    End Sub

    Public Property Cliente1 As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property NitCliente1 As String
        Get
            Return nitCliente
        End Get
        Set(value As String)
            nitCliente = value
        End Set
    End Property

    Public Property DirCliente1 As String
        Get
            Return dirCliente
        End Get
        Set(value As String)
            dirCliente = value
        End Set
    End Property

    Public Property FechaGeneracion1 As String
        Get
            Return fechaGeneracion
        End Get
        Set(value As String)
            fechaGeneracion = value
        End Set
    End Property

    Public Property NoRemision1 As String
        Get
            Return noRemision
        End Get
        Set(value As String)
            noRemision = value
        End Set
    End Property

    Public Property Subpartida1 As String
        Get
            Return subpartida
        End Get
        Set(value As String)
            subpartida = value
        End Set
    End Property

    Public Property TipoEmbalaje1 As String
        Get
            Return tipoEmbalaje
        End Get
        Set(value As String)
            tipoEmbalaje = value
        End Set
    End Property

    Public Property Items1 As List(Of ItemVO)
        Get
            Return items
        End Get
        Set(value As List(Of ItemVO))
            items = value
        End Set
    End Property

    Public Property Placas1 As List(Of String)
        Get
            Return placas
        End Get
        Set(value As List(Of String))
            placas = value
        End Set
    End Property

    Public Property Subpartidas1 As List(Of String)
        Get
            Return subpartidas
        End Get
        Set(value As List(Of String))
            subpartidas = value
        End Set
    End Property

    Public Property TotalCantidad1 As String
        Get
            Return totalCantidad
        End Get
        Set(value As String)
            totalCantidad = value
        End Set
    End Property

    Public Property TotalBultos1 As String
        Get
            Return totalBultos
        End Get
        Set(value As String)
            totalBultos = value
        End Set
    End Property

    Public Property TotalPesoBruto1 As String
        Get
            Return totalPesoBruto
        End Get
        Set(value As String)
            totalPesoBruto = value
        End Set
    End Property

    Public Property TotalPesoNeto1 As String
        Get
            Return totalPesoNeto
        End Get
        Set(value As String)
            totalPesoNeto = value
        End Set
    End Property

    Public Property TotalValorUnitario1 As String
        Get
            Return totalValorUnitario
        End Get
        Set(value As String)
            totalValorUnitario = value
        End Set
    End Property

    Public Property TotalTotal1 As String
        Get
            Return totalTotal
        End Get
        Set(value As String)
            totalTotal = value
        End Set
    End Property

    Public Property TasaDeCambio1 As String
        Get
            Return tasaDeCambio
        End Get
        Set(value As String)
            tasaDeCambio = value
        End Set
    End Property
End Class
