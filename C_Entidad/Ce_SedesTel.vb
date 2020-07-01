Public Class Ce_SedesTel
    Private _Cons As Integer
    Private _Sede As Integer
    Private _Tel As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Sede As Integer
        Get
            Return _Sede
        End Get
        Set(value As Integer)
            _Sede = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _Tel
        End Get
        Set(value As String)
            _Tel = value
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
