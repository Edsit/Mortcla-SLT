Public Class Ce_T_Error
    Private _Tipo As String
    Private _Fila As Integer
    Private _Col As Integer
    Private _Detalle As String

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Fila As Integer
        Get
            Return _Fila
        End Get
        Set(value As Integer)
            _Fila = value
        End Set
    End Property

    Public Property Col As Integer
        Get
            Return _Col
        End Get
        Set(value As Integer)
            _Col = value
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
End Class
