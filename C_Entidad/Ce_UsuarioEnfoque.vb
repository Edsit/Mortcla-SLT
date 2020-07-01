Public Class Ce_UsuarioEnfoque
    Private _Cons As Integer
    Private _Usuario As Integer
    Private _Enfoque As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Usuario As Integer
        Get
            Return _Usuario
        End Get
        Set(value As Integer)
            _Usuario = value
        End Set
    End Property

    Public Property Enfoque As Integer
        Get
            Return _Enfoque
        End Get
        Set(value As Integer)
            _Enfoque = value
        End Set
    End Property

End Class
