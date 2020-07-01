Public Class Ce_Alm_Salidas
    Private _Cons As Integer
    Private _Fecha As String
    Private _Mes As Integer
    Private _Año As Integer
    Private _Prod As Integer
    Private _Lote As Integer
    Private _Cant As Integer
    Private _Unitario As Double
    Private _TProd As Integer
    Private _TipoSalida As Integer
    Private _Destino As Integer
    Private _Almacen As Integer
    Private _Area As Integer
    Private _Traslado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Mes As Integer
        Get
            Return _Mes
        End Get
        Set(value As Integer)
            _Mes = value
        End Set
    End Property

    Public Property Año As Integer
        Get
            Return _Año
        End Get
        Set(value As Integer)
            _Año = value
        End Set
    End Property

    Public Property Prod As Integer
        Get
            Return _Prod
        End Get
        Set(value As Integer)
            _Prod = value
        End Set
    End Property

    Public Property Lote As Integer
        Get
            Return _Lote
        End Get
        Set(value As Integer)
            _Lote = value
        End Set
    End Property

    Public Property Cant As Integer
        Get
            Return _Cant
        End Get
        Set(value As Integer)
            _Cant = value
        End Set
    End Property

    Public Property Unitario As Double
        Get
            Return _Unitario
        End Get
        Set(value As Double)
            _Unitario = value
        End Set
    End Property

    Public Property TProd As Integer
        Get
            Return _TProd
        End Get
        Set(value As Integer)
            _TProd = value
        End Set
    End Property

    Public Property TipoSalida As Integer
        Get
            Return _TipoSalida
        End Get
        Set(value As Integer)
            _TipoSalida = value
        End Set
    End Property

    Public Property Destino As Integer
        Get
            Return _Destino
        End Get
        Set(value As Integer)
            _Destino = value
        End Set
    End Property

    Public Property Almacen As Integer
        Get
            Return _Almacen
        End Get
        Set(value As Integer)
            _Almacen = value
        End Set
    End Property

    Public Property Area As Integer
        Get
            Return _Area
        End Get
        Set(value As Integer)
            _Area = value
        End Set
    End Property

    Public Property Traslado As Integer
        Get
            Return _Traslado
        End Get
        Set(value As Integer)
            _Traslado = value
        End Set
    End Property

End Class
