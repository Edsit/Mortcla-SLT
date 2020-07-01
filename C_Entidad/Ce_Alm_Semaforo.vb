Public Class Ce_Alm_Semaforo
    Private _Rojo As Integer
    Private _Amarillo As Integer

    Public Property Rojo As Integer
        Get
            Return _Rojo
        End Get
        Set(value As Integer)
            _Rojo = value
        End Set
    End Property

    Public Property Amarillo As Integer
        Get
            Return _Amarillo
        End Get
        Set(value As Integer)
            _Amarillo = value
        End Set
    End Property
End Class
