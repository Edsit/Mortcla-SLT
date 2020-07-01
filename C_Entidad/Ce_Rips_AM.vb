Public Class Ce_Rips_AM
    Private _Id As Integer
    Private _Num_Fact As String
    Private _Cod_Prest As String
    Private _Tipo_Ide_Usu As String
    Private _Num_Ide_Usu As String
    Private _Autorizacion As String
    Private _Cod_Med As String
    Private _Tipo_Med As Integer
    Private _Nom_Gen As String
    Private _Forma As String
    Private _Concent As String
    Private _Unidad As String
    Private _Num_Dosis As Integer
    Private _Val_Unit As Double
    Private _Val_Total As Double
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

    Public Property Autorizacion As String
        Get
            Return _Autorizacion
        End Get
        Set(value As String)
            _Autorizacion = value
        End Set
    End Property

    Public Property Cod_Med As String
        Get
            Return _Cod_Med
        End Get
        Set(value As String)
            _Cod_Med = value
        End Set
    End Property

    Public Property Tipo_Med As Integer
        Get
            Return _Tipo_Med
        End Get
        Set(value As Integer)
            _Tipo_Med = value
        End Set
    End Property

    Public Property Nom_Gen As String
        Get
            Return _Nom_Gen
        End Get
        Set(value As String)
            _Nom_Gen = value
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

    Public Property Concent As String
        Get
            Return _Concent
        End Get
        Set(value As String)
            _Concent = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Num_Dosis As Integer
        Get
            Return _Num_Dosis
        End Get
        Set(value As Integer)
            _Num_Dosis = value
        End Set
    End Property

    Public Property Val_Unit As Double
        Get
            Return _Val_Unit
        End Get
        Set(value As Double)
            _Val_Unit = value
        End Set
    End Property

    Public Property Val_Total As Double
        Get
            Return _Val_Total
        End Get
        Set(value As Double)
            _Val_Total = value
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
