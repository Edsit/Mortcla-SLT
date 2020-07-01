Public Class Ce_Alm_Lotes
    Private _Cons As Integer
    Private _Prod As Integer
    Private _Cum As String
    Private _Lab As Integer
    Private _Lote As String
    Private _Invima As String
    Private _Vence As String
    Private _ini As Integer
    Private _Unitario As Double
    Private _Mes As Integer
    Private _Año As Integer
    Private _Obs As String
    Private _Serial As String
    Private _VUtil As String
    Private _Entrada As Integer
    Private _Almacen As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Prod As Integer
        Get
            Return _Prod
        End Get
        Set(value As Integer)
            _Prod = value
        End Set
    End Property

    Public Property Cum As String
        Get
            Return _Cum
        End Get
        Set(value As String)
            _Cum = value
        End Set
    End Property

    Public Property Lab As Integer
        Get
            Return _Lab
        End Get
        Set(value As Integer)
            _Lab = value
        End Set
    End Property

    Public Property Lote As String
        Get
            Return _Lote
        End Get
        Set(value As String)
            _Lote = value
        End Set
    End Property

    Public Property Invima As String
        Get
            Return _Invima
        End Get
        Set(value As String)
            _Invima = value
        End Set
    End Property

    Public Property Vence As String
        Get
            Return _Vence
        End Get
        Set(value As String)
            _Vence = value
        End Set
    End Property

    Public Property Ini As Integer
        Get
            Return _ini
        End Get
        Set(value As Integer)
            _ini = value
        End Set
    End Property

    Public Property Unitario As Double
        Get
            Return _Unitario
        End Get
        Set(value As Double)
            _Unitario = value
        End Set
    End Property

    Public Property Mes As Integer
        Get
            Return _Mes
        End Get
        Set(value As Integer)
            _Mes = value
        End Set
    End Property

    Public Property Año As Integer
        Get
            Return _Año
        End Get
        Set(value As Integer)
            _Año = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return _Obs
        End Get
        Set(value As String)
            _Obs = value
        End Set
    End Property

    Public Property Serial As String
        Get
            Return _Serial
        End Get
        Set(value As String)
            _Serial = value
        End Set
    End Property

    Public Property VUtil As String
        Get
            Return _VUtil
        End Get
        Set(value As String)
            _VUtil = value
        End Set
    End Property

    Public Property Entrada As Integer
        Get
            Return _Entrada
        End Get
        Set(value As Integer)
            _Entrada = value
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
End Class
