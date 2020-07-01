Public Class Ce_Almacenes
    Private _Cons As Integer
    Private _Sede As Integer
    Private _Nombre As String
    Private _Responsable As Integer
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

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Responsable As Integer
        Get
            Return _Responsable
        End Get
        Set(value As Integer)
            _Responsable = value
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
