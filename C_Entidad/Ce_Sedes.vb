Public Class Ce_Sedes
    Private _Cons As Integer
    Private _UsaPrefijo As String
    Private _Prefijo As String
    Private _Sede As String
    Private _CodHabilitacion As String
    Private _Nit As String
    Private _Estado As Integer
    Private _Sel As String

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property UsaPrefijo As String
        Get
            Return _UsaPrefijo
        End Get
        Set(value As String)
            _UsaPrefijo = value
        End Set
    End Property

    Public Property Prefijo As String
        Get
            Return _Prefijo
        End Get
        Set(value As String)
            _Prefijo = value
        End Set
    End Property

    Public Property Sede As String
        Get
            Return _Sede
        End Get
        Set(value As String)
            _Sede = value
        End Set
    End Property

    Public Property CodHabilitacion As String
        Get
            Return _CodHabilitacion
        End Get
        Set(value As String)
            _CodHabilitacion = value
        End Set
    End Property

    Public Property Nit As String
        Get
            Return _Nit
        End Get
        Set(value As String)
            _Nit = value
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

    Public Property Sel As String
        Get
            Return _Sel
        End Get
        Set(value As String)
            _Sel = value
        End Set
    End Property

End Class
