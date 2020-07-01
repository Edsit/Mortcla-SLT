Public Class Ce_AlmacenFunc
    Private _Cons As Integer
    Private _Almacen As Integer
    Private _Func As Integer
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Almacen As Integer
        Get
            Return _Almacen
        End Get
        Set(value As Integer)
            _Almacen = value
        End Set
    End Property

    Public Property Func As Integer
        Get
            Return _Func
        End Get
        Set(value As Integer)
            _Func = value
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
