Public Class Ce_Entradas
    Private _Cons As Integer
    Private _Fecha As String
    Private _Proveedor As Integer
    Private _Valor As Double
    Private _Pedido As Integer
    Private _Func As Integer
    Private _TProd As Integer
    Private _Almacen As Integer
    Private _Soporte As String

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Proveedor As Integer
        Get
            Return _Proveedor
        End Get
        Set(value As Integer)
            _Proveedor = value
        End Set
    End Property

    Public Property Valor As Double
        Get
            Return _Cons
        End Get
        Set(value As Double)
            _Valor = value
        End Set
    End Property

    Public Property Pedido As Integer
        Get
            Return _Pedido
        End Get
        Set(value As Integer)
            _Pedido = value
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

    Public Property TProd As Integer
        Get
            Return _TProd
        End Get
        Set(value As Integer)
            _TProd = value
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

    Public Property Soporte As String
        Get
            Return _Soporte
        End Get
        Set(value As String)
            _Soporte = value
        End Set
    End Property
End Class
