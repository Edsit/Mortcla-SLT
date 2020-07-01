Public Class Ce_Alm_Productos
    Private _Cons As Integer
    Private _ATC As String
    Private _Descripcion As String
    Private _Concentracion As String
    Private _Presentacion As String
    Private _Forma As Integer
    Private _Undiad As String
    Private _Temperatura As String
    Private _Minimo As Integer
    Private _Riesgo As String
    Private _TipoProd As Integer
    Private _TipoMed As Integer
    Private _Estado As Integer
    Private _CCostos As Integer

    Public Property Cons As Integer
        Get
            Return _Cons
        End Get
        Set(value As Integer)
            _Cons = value
        End Set
    End Property

    Public Property ATC As String
        Get
            Return _ATC
        End Get
        Set(value As String)
            _ATC = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Concentracion As String
        Get
            Return _Concentracion
        End Get
        Set(value As String)
            _Concentracion = value
        End Set
    End Property

    Public Property Presentacion As String
        Get
            Return _Presentacion
        End Get
        Set(value As String)
            _Presentacion = value
        End Set
    End Property

    Public Property Forma As Integer
        Get
            Return _Forma
        End Get
        Set(value As Integer)
            _Forma = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Undiad
        End Get
        Set(value As String)
            _Undiad = value
        End Set
    End Property

    Public Property Temperatura As String
        Get
            Return _Temperatura
        End Get
        Set(value As String)
            _Temperatura = value
        End Set
    End Property

    Public Property Minimo As Integer
        Get
            Return _Minimo
        End Get
        Set(value As Integer)
            _Minimo = value
        End Set
    End Property

    Public Property Riesgo As String
        Get
            Return _Riesgo
        End Get
        Set(value As String)
            _Riesgo = value
        End Set
    End Property

    Public Property TipoProd As Integer
        Get
            Return _TipoProd
        End Get
        Set(value As Integer)
            _TipoProd = value
        End Set
    End Property

    Public Property TipoMed As Integer
        Get
            Return _TipoMed
        End Get
        Set(value As Integer)
            _TipoMed = value
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

    Public Property CCostos As Integer
        Get
            Return _CCostos
        End Get
        Set(value As Integer)
            _CCostos = value
        End Set
    End Property

End Class
