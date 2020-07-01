Public Class Ce_Perfiles
    Private _Cons As Integer
    Private _Perfil As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Perfil As String
        Get
            Return _Perfil
        End Get
        Set(value As String)
            _Perfil = value
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
