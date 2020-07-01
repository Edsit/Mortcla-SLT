Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Entradas
    Dim objCd_E As New Cd_Alm_Entradas

    Sub NuevoEntrada(ByVal obj As Ce_Alm_Entradas)
        objCd_E.NuevoEntrada(obj)
    End Sub

    Sub AjustarEntrada(ByVal obj As Ce_Alm_Entradas)
        objCd_E.AjustarEntrada(obj)
    End Sub

    Sub EliminarEntrada(ByVal obj As Ce_Alm_Entradas)
        objCd_E.EliminarEntrada(obj)
    End Sub

    Function ListarEntradas(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.ListarEntradas(obj)
    End Function

    Function ListarEntradasCons(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.ListarEntradasCons(obj)
    End Function

    Function ContarEntradas(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.ContarEntradas(obj)
    End Function

    Function LsitarEntradasAjustes(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.LsitarEntradasAjustes(obj)
    End Function

    Function VerSumEntradasLote(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.VerSumEntradasLote(obj)
    End Function

    Function Entradasrescate(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.EntradasRescate(obj)
    End Function

    Function ListarEntradaNuevoCierre(ByVal obj As Ce_Alm_Entradas) As DataSet
        Return objCd_E.ListarEntradaNuevoCierre(obj)
    End Function

End Class
