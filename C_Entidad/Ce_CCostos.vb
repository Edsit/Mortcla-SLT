Public Class Ce_CCostos
    Private _Cons As Integer
    Private _CCosto As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property CCosto As String
        Get
            Return _CCosto
        End Get
        Set(value As String)
            _CCosto = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _Estado
        End Get
        Set(value As Integer)
            _Estado = value
        End Set
    End Property
End Class
