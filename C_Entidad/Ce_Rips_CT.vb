Public Class Ce_Rips_CT
    Private _Cod_Prest As String
    Private _Fec_Remi As String
    Private _Cod_Arch As String
    Private _Tot_Regis As Integer

    Public Property Cod_Prest As String
        Get
            Return _Cod_Prest
        End Get
        Set(value As String)
            _Cod_Prest = value
        End Set
    End Property

    Public Property Fec_Remi As String
        Get
            Return _Fec_Remi
        End Get
        Set(value As String)
            _Fec_Remi = value
        End Set
    End Property

    Public Property Cod_Arch As String
        Get
            Return _Cod_Arch
        End Get
        Set(value As String)
            _Cod_Arch = value
        End Set
    End Property

    Public Property Tot_Regis As Integer
        Get
            Return _Tot_Regis
        End Get
        Set(value As Integer)
            _Tot_Regis = value
        End Set
    End Property
End Class
