Public Class Ce_Nacionalidad
    Private _Cons As Integer
    Private _Nacionalidad As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return _Nacionalidad
        End Get
        Set(value As String)
            _Nacionalidad = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
End Class
