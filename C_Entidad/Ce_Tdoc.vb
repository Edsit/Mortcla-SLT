Public Class Ce_Tdoc
    Private _Cons As Integer
    Private _Tipo As String
    Private _Detalle As String
    Private _Estado As Integer
    Private _Longitud As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
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

    Public Property Longitud As Integer
        Get
            Return _Longitud
        End Get
        Set(value As Integer)
            _Longitud = value
        End Set
    End Property
End Class
