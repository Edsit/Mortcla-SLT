Public Class Ce_Funcionarios
    Private _Cons As Integer
    Private _Sede As Integer
    Private _Tdoc As Integer
    Private _Doc As String
    Private _Nombre As String
    Private _Cargo As Integer
    Private _Estado As Integer
    Private _Dir As String
    Private _Tel As String
    Private _Pwd As String
    Private _Perfil As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Sede As Integer
        Get
            Return _Sede
        End Get
        Set(value As Integer)
            _Sede = value
        End Set
    End Property

    Public Property Tdoc As Integer
        Get
            Return _Tdoc
        End Get
        Set(value As Integer)
            _Tdoc = value
        End Set
    End Property

    Public Property Doc As String
        Get
            Return _Doc
        End Get
        Set(value As String)
            _Doc = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Cargo As Integer
        Get
            Return _Cargo
        End Get
        Set(value As Integer)
            _Cargo = value
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


    Public Property Dir As String
        Get
            Return _Dir
        End Get
        Set(value As String)
            _Dir = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _Tel
        End Get
        Set(value As String)
            _Tel = value
        End Set
    End Property

    Public Property Pwd As String
        Get
            Return _Pwd
        End Get
        Set(value As String)
            _Pwd = value
        End Set
    End Property

    Public Property Perfil As Integer
        Get
            Return _Perfil
        End Get
        Set(value As Integer)
            _Perfil = value
        End Set
    End Property
End Class
