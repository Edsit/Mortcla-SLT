Public Class Ce_Genero
    Private _Cons As Integer
    Private _Genero As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _Genero
        End Get
        Set(value As String)
            _Genero = value
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
