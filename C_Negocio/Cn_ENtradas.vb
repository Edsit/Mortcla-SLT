Imports C_Entidad
Imports C_Datos
Public Class Cn_ENtradas
    Dim objCd_E As New Cd_Entradas

    Sub NuevaEntrada(ByVal obj As Ce_Entradas)
        objCd_E.NuevaEntrada(obj)
    End Sub

    Function ListarEntradas() As DataSet
        Return objCd_E.ListarEntradas()
    End Function

    Function ListarEntradasTipo(ByVal obj As Ce_Entradas) As DataSet
        Return objCd_E.ListarEntradasTipo(obj)
    End Function

    Function ListarEntradasTodosFecha(ByVal obj1 As Ce_RFecha) As DataSet
        Return objCd_E.ListarEntradasTodosFecha(obj1)
    End Function

    Function ListarEntradasTipoFecha(ByVal obj As Ce_Entradas, obj1 As Ce_RFecha) As DataSet
        Return objCd_E.ListarEntradasTipoFecha(obj, obj1)
    End Function

    Function EntradasSedeAdmin(ByVal obj As Ce_Entradas) As DataSet
        Return objCd_E.EntradasSedeAdmin(obj)
    End Function
End Class
