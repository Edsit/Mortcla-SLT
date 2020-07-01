Public Class Ce_MesEstado
    Private _Mes As Integer
    Private _Año As Integer
    Private _Estado As String

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
