Public Class Ce_Traslados
    Private _Cons As Integer
    Private _Fecha As String
    Private _Alm_Origen As Integer
    Private _Alm_Destino As Integer
    Private _Obs As String
    Private _TipoProd As Integer
    Private _Estado As String

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Alm_Origen As Integer
        Get
            Return _Alm_Origen
        End Get
        Set(value As Integer)
            _Alm_Origen = value
        End Set
    End Property
    Public Property Alm_Destino As Integer
        Get
            Return _Alm_Destino
        End Get
        Set(value As Integer)
            _Alm_Destino = value
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

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return _Obs
        End Get
        Set(value As String)
            _Obs = value
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
