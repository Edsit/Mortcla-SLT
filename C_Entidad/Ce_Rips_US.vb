Public Class Ce_Rips_US
    Private _Tipo_Ide_Usu As String
    Private _Num_Ide_Usu As String
    Private _Cod_Enti As String
    Private _Tipo_Usu As Integer
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _Nombre1 As String
    Private _Nombre2 As String
    Private _Edad As Integer
    Private _Uni_Med_Edad As Integer
    Private _Sexo As String
    Private _Cod_Dep_Res As String
    Private _Cod_Mun_Res As String
    Private _Zona_Res As String
    Private _Cod_Año As Integer
    Private _Cod_Per As Integer
    Private _Cod_Hosp As Integer

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

    Public Property Cod_Enti As String
        Get
            Return _Cod_Enti
        End Get
        Set(value As String)
            _Cod_Enti = value
        End Set
    End Property

    Public Property Tipo_Usu As Integer
        Get
            Return _Tipo_Usu
        End Get
        Set(value As Integer)
            _Tipo_Usu = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return _Apellido1
        End Get
        Set(value As String)
            _Apellido1 = value
        End Set
    End Property

    Public Property Apellido2 As String
        Get
            Return _Apellido2
        End Get
        Set(value As String)
            _Apellido2 = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return _Nombre1
        End Get
        Set(value As String)
            _Nombre1 = value
        End Set
    End Property

    Public Property Nombre2 As String
        Get
            Return _Nombre2
        End Get
        Set(value As String)
            _Nombre2 = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _Edad
        End Get
        Set(value As Integer)
            _Edad = value
        End Set
    End Property

    Public Property Uni_Med_Edad As Integer
        Get
            Return _Uni_Med_Edad
        End Get
        Set(value As Integer)
            _Uni_Med_Edad = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(value As String)
            _Sexo = value
        End Set
    End Property

    Public Property Cod_Dep_Res As String
        Get
            Return _Cod_Dep_Res
        End Get
        Set(value As String)
            _Cod_Dep_Res = value
        End Set
    End Property

    Public Property Cod_Mun_Res As String
        Get
            Return _Cod_Mun_Res
        End Get
        Set(value As String)
            _Cod_Mun_Res = value
        End Set
    End Property

    Public Property Zona_Res As String
        Get
            Return _Zona_Res
        End Get
        Set(value As String)
            _Zona_Res = value
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
