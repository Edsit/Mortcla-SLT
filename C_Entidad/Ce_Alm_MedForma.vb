Public Class Ce_Alm_MedForma
    Private _Cons As Integer
    Private _Forma As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Forma As String
        Get
            Return _Forma
        End Get
        Set(value As String)
            _Forma = value
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
