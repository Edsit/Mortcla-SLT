Public Class Ce_Rips_AP
    Private _Id As Integer
    Private _Num_Fact As String
    Private _Cod_Prest As String
    Private _Tipo_Ide_Usu As String
    Private _Num_Ide_Usu As String
    Private _Fec_Proc As String
    Private _Autorizacion As String
    Private _Cod_Proc As String
    Private _Ambito As Integer
    Private _Finalidad As String
    Private _Personal As String
    Private _Dx_Princ As String
    Private _Dx_Rel1 As String
    Private _Dx_Compl As String
    Private _FormaQx As Integer
    Private _Val_Neto As Double
    Private _Cod_Año As Integer
    Private _Cod_Per As String
    Private _Cod_Hosp As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
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

    Public Property Cod_Prest As String
        Get
            Return _Cod_Prest
        End Get
        Set(value As String)
            _Cod_Prest = value
        End Set
    End Property

    Public Property Tipo_Ide_Usu As String
        Get
            Return _Tipo_Ide_Usu
        End Get
        Set(value As String)
            _Tipo_Ide_Usu = value
        End Set
    End Property

    Public Property Num_Ide_Usu As String
        Get
            Return _Num_Ide_Usu
        End Get
        Set(value As String)
            _Num_Ide_Usu = value
        End Set
    End Property

    Public Property Fec_Proc As String
        Get
            Return _Fec_Proc
        End Get
        Set(value As String)
            _Fec_Proc = value
        End Set
    End Property

    Public Property Autorizacion As String
        Get
            Return _Autorizacion
        End Get
        Set(value As String)
            _Autorizacion = value
        End Set
    End Property

    Public Property Cod_Proc As String
        Get
            Return _Cod_Proc
        End Get
        Set(value As String)
            _Cod_Proc = value
        End Set
    End Property

    Public Property Finalidad As String
        Get
            Return _Finalidad
        End Get
        Set(value As String)
            _Finalidad = value
        End Set
    End Property

    Public Property Ambito As Integer
        Get
            Return _Ambito
        End Get
        Set(value As Integer)
            _Ambito = value
        End Set
    End Property

    Public Property Dx_Princ As String
        Get
            Return _Dx_Princ
        End Get
        Set(value As String)
            _Dx_Princ = value
        End Set
    End Property

    Public Property Dx_Rel1 As String
        Get
            Return _Dx_Rel1
        End Get
        Set(value As String)
            _Dx_Rel1 = value
        End Set
    End Property

    Public Property Dx_Compl As String
        Get
            Return _Dx_Compl
        End Get
        Set(value As String)
            _Dx_Compl = value
        End Set
    End Property

    Public Property Personal As String
        Get
            Return _Personal
        End Get
        Set(value As String)
            _Personal = value
        End Set
    End Property

    Public Property FormaQx As Integer
        Get
            Return _FormaQx
        End Get
        Set(value As Integer)
            _FormaQx = value
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

    Public Property Cod_Per As String
        Get
            Return _Cod_Per
        End Get
        Set(value As String)
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
