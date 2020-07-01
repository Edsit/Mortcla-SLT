Public Class Ce_Alm_Laboratorios
    Private _Cons As Integer
    Private _Lab As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Lab As String
        Get
            Return _Lab
        End Get
        Set(value As String)
            _Lab = value
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
