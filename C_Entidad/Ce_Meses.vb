Public Class Ce_Meses
    Private _Cons As Integer
    Private _Mes As String

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Mes As String
        Get
            Return _Mes
        End Get
        Set(value As String)
            _Mes = value
        End Set
    End Property
End Class
