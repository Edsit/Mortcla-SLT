Public Class Ce_Auditoria
    Private _Cons As Integer
    Private _Fecha As String
    Private _Hora As String
    Private _Accion As String
    Private _Usuario As Integer

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

    Public Property Hora As String
        Get
            Return _Hora
        End Get
        Set(value As String)
            _Hora = value
        End Set
    End Property

    Public Property Accion As String
        Get
            Return _Accion
        End Get
        Set(value As String)
            _Accion = value
        End Set
    End Property

    Public Property Usuario As Integer
        Get
            Return _Usuario
        End Get
        Set(value As Integer)
            _Usuario = value
        End Set
    End Property
End Class
