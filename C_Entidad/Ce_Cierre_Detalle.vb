Public Class Ce_Cierre_Detalle
    Private _Cons As Integer
    Private _TipoProd As Integer
    Private _Mes As Integer
    Private _Año As Integer
    Private _Estado As String

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property TipoProd As Integer
        Get
            Return _TipoProd
        End Get
        Set(value As Integer)
            _TipoProd = value
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

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
End Class
