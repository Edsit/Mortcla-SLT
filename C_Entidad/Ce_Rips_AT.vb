Public Class Ce_Rips_AT
    Private _Id As Integer
    Private _Num_Fact As String
    Private _Cod_Prest As String
    Private _Tipo_Ide_Usu As String
    Private _Num_Ide_Usu As String
    Private _Autorizacion As String
    Private _TipoServ As Integer
    Private _CodServ As String
    Private _NomServ As String
    Private _Cant As Integer
    Private _ValUnit As Double
    Private _ValTotal As Double
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

    Public Property TipoServ As Integer
        Get
            Return _TipoServ
        End Get
        Set(value As Integer)
            _TipoServ = value
        End Set
    End Property

    Public Property CodServ As String
        Get
            Return _CodServ
        End Get
        Set(value As String)
            _CodServ = value
        End Set
    End Property

    Public Property NomServ As String
        Get
            Return _NomServ
        End Get
        Set(value As String)
            _NomServ = value
        End Set
    End Property

    Public Property Cant As Integer
        Get
            Return _Cant
        End Get
        Set(value As Integer)
            _Cant = value
        End Set
    End Property

    Public Property ValUnit As Double
        Get
            Return _ValUnit
        End Get
        Set(value As Double)
            _ValUnit = value
        End Set
    End Property

    Public Property ValTotal As Double
        Get
            Return _ValTotal
        End Get
        Set(value As Double)
            _ValTotal = value
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
