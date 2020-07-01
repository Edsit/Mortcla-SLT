Public Class Ce_Mun
    Private _Cons As Integer
    Private _CodDep As Integer
    Private _Cod As String
    Private _Mun As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property CodDep As Integer
        Get
            Return _CodDep
        End Get
        Set(value As Integer)
            _CodDep = value
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

    Public Property Mun As String
        Get
            Return _Mun
        End Get
        Set(value As String)
            _Mun = value
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
