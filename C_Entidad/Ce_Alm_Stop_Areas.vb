Public Class Ce_Alm_Stop_Areas
    Private _Cons As Integer
    Private _Stop1 As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Stop1 As String
        Get
            Return _Stop1
        End Get
        Set(value As String)
            _Stop1 = value
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
