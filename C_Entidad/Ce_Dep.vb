Public Class Ce_Dep
    Private _Cons As Integer
    Private _Cod As String
    Private _Dep As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Cod As String
        Get
            Return _Cod
        End Get
        Set(value As String)
            _Cod = value
        End Set
    End Property

    Public Property Dep As String
        Get
            Return _Dep
        End Get
        Set(value As String)
            _Dep = value
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
