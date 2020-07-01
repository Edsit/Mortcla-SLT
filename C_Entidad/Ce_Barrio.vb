Public Class Ce_Barrio
    Private _Cons As Integer
    Private _CodMun As Integer
    Private _Zona As String
    Private _Barrio As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property CodMun As Integer
        Get
            Return _CodMun
        End Get
        Set(value As Integer)
            _CodMun = value
        End Set
    End Property

    Public Property Zona As String
        Get
            Return _Zona
        End Get
        Set(value As String)
            _Zona = value
        End Set
    End Property

    Public Property Barrio As String
        Get
            Return _Barrio
        End Get
        Set(value As String)
            _Barrio = value
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
