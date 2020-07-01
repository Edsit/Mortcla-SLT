Public Class Ce_Rips_AF
    Private _Id As Integer
    Private _Cod_Prest As String
    Private _Raz_Prest As String
    Private _Tipo_Ide_Prest As String
    Private _Num_Ide_prest As String
    Private _Num_Fact As String
    Private _Fec_Fact As String
    Private _Fec_Ini_Per As String
    Private _Fec_Fin_Per As String
    Private _Cod_Enti As String
    Private _Nom_Enti As String
    Private _Num_Contra As String
    Private _Pla_Benef As String
    Private _Num_Poliza As String
    Private _Val_Copago As Double
    Private _Val_Comision As Double
    Private _Val_Desc As Double
    Private _Val_Neto As Double
    Private _Cod_Año As Integer
    Private _Cod_Per As Integer
    Private _Cod_Hosp As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Cod_Prest As String
        Get
            Return _Cod_Prest
        End Get
        Set(value As String)
            _Cod_Prest = value
        End Set
    End Property

    Public Property Raz_Prest As String
        Get
            Return _Raz_Prest
        End Get
        Set(value As String)
            _Raz_Prest = value
        End Set
    End Property

    Public Property Tipo_Ide_Prest As String
        Get
            Return _Tipo_Ide_Prest
        End Get
        Set(value As String)
            _Tipo_Ide_Prest = value
        End Set
    End Property

    Public Property Num_Ide_prest As String
        Get
            Return _Num_Ide_prest
        End Get
        Set(value As String)
            _Num_Ide_prest = value
        End Set
    End Property

    Public Property Num_Fact As String
        Get
            Return _Num_Fact
        End Get
        Set(value As String)
            _Num_Fact = value
        End Set
    End Property

    Public Property Fec_Fact As String
        Get
            Return _Fec_Fact
        End Get
        Set(value As String)
            _Fec_Fact = value
        End Set
    End Property

    Public Property Fec_Ini_Per As String
        Get
            Return _Fec_Ini_Per
        End Get
        Set(value As String)
            _Fec_Ini_Per = value
        End Set
    End Property

    Public Property Fec_Fin_Per As String
        Get
            Return _Fec_Fin_Per
        End Get
        Set(value As String)
            _Fec_Fin_Per = value
        End Set
    End Property

    Public Property Cod_Enti As String
        Get
            Return _Fec_Fin_Per
        End Get
        Set(value As String)
            _Cod_Enti = value
        End Set
    End Property

    Public Property Nom_Enti As String
        Get
            Return _Nom_Enti
        End Get
        Set(value As String)
            _Nom_Enti = value
        End Set
    End Property

    Public Property Num_Contra As String
        Get
            Return _Num_Contra
        End Get
        Set(value As String)
            _Num_Contra = value
        End Set
    End Property

    Public Property Pla_Benef As String
        Get
            Return _Pla_Benef
        End Get
        Set(value As String)
            _Pla_Benef = value
        End Set
    End Property

    Public Property Num_Poliza As String
        Get
            Return _Num_Poliza
        End Get
        Set(value As String)
            _Num_Poliza = value
        End Set
    End Property

    Public Property Val_Copago As Double
        Get
            Return _Val_Copago
        End Get
        Set(value As Double)
            _Val_Copago = value
        End Set
    End Property

    Public Property Val_Comision As Double
        Get
            Return _Val_Comision
        End Get
        Set(value As Double)
            _Val_Comision = value
        End Set
    End Property

    Public Property Val_Desc As Double
        Get
            Return _Val_Desc
        End Get
        Set(value As Double)
            _Val_Desc = value
        End Set
    End Property

    Public Property Val_Neto As Double
        Get
            Return _Val_Neto
        End Get
        Set(value As Double)
            _Val_Neto = value
        End Set
    End Property

    Public Property Cod_Año As Integer
        Get
            Return _Cod_Año
        End Get
        Set(value As Integer)
            _Cod_Año = value
        End Set
    End Property

    Public Property Cod_Per As Integer
        Get
            Return _Cod_Per
        End Get
        Set(value As Integer)
            _Cod_Per = value
        End Set
    End Property

    Public Property Cod_Hosp As Integer
        Get
            Return _Cod_Hosp
        End Get
        Set(value As Integer)
            _Cod_Hosp = value
        End Set
    End Property
End Class
