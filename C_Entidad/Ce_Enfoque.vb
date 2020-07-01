Public Class Ce_Enfoque
    Private _Cons As Integer
    Private _Enfoque As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Enfoque As String
        Get
            Return _Enfoque
        End Get
        Set(value As String)
            _Enfoque = value
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
