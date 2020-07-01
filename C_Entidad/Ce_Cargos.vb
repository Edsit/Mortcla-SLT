Public Class Ce_Cargos
    Private _Cons As Integer
    Private _Cargo As String
    Private _Asistencial As String
    Private _Estado As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(value As String)
            _Cargo = value
        End Set
    End Property

    Public Property Asistencial As String
        Get
            Return _Asistencial
        End Get
        Set(value As String)
            _Asistencial = value
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
