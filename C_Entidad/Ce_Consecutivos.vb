Public Class Ce_Consecutivos
    Private _Func As Integer
    Private _Entradas As String
    Private _Salidas As Integer
    Private _Traslados As Integer

    Public Property Func As Integer
        Get
            Return _Func
        End Get
        Set(value As Integer)
            _Func = value
        End Set
    End Property

    Public Property Entradas As Integer
        Get
            Return _Entradas
        End Get
        Set(value As Integer)
            _Entradas = value
        End Set
    End Property


    Public Property Salidas As Integer
        Get
            Return _Salidas
        End Get
        Set(value As Integer)
            _Salidas = value
        End Set
    End Property

    Public Property Traslados As Integer
        Get
            Return _Traslados
        End Get
        Set(value As Integer)
            _Traslados = value
        End Set
    End Property

End Class
