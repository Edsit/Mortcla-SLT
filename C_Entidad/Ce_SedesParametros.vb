Public Class Ce_SedesParametros
    Private _Sede As Integer
    Private _Regente As Integer
    Private _Director As Integer
    Private _Almacenista As Integer
    Private _Dep As Integer
    Private _Mun As Integer

    Public Property Sede As Integer
        Get
            Return _Sede
        End Get
        Set(value As Integer)
            _Sede = value
        End Set
    End Property

    Public Property Regente As Integer
        Get
            Return _Regente
        End Get
        Set(value As Integer)
            _Regente = value
        End Set
    End Property

    Public Property Director As Integer
        Get
            Return _Director
        End Get
        Set(value As Integer)
            _Director = value
        End Set
    End Property

    Public Property Almacenista As Integer
        Get
            Return _Almacenista
        End Get
        Set(value As Integer)
            _Almacenista = value
        End Set
    End Property

    Public Property Dep As Integer
        Get
            Return _Dep
        End Get
        Set(value As Integer)
            _Dep = value
        End Set
    End Property

    Public Property Mun As Integer
        Get
            Return _Mun
        End Get
        Set(value As Integer)
            _Mun = value
        End Set
    End Property
End Class
