Public Class Ce_RFecha
    Private _Desde As String
    Private _Hasta As String

    Public Property Desde As String
        Get
            Return _Desde
        End Get
        Set(value As String)
            _Desde = value
        End Set
    End Property

    Public Property Hasta As String
        Get
            Return _Hasta
        End Get
        Set(value As String)
            _Hasta = value
        End Set
    End Property
End Class
