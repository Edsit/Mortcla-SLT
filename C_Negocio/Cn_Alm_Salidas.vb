Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Salidas
    Dim objCd_S As New Cd_Alm_Salidas

    Sub NuevaSalida(ByVal obj As Ce_Alm_Salidas)
        objCd_S.NuevoSalida(obj)
    End Sub

    Sub AjustarSalida(ByVal obj As Ce_Alm_Salidas)
        objCd_S.AjustarSalida(obj)
    End Sub

    Sub EliminarSalida(ByVal obj As Ce_Alm_Salidas)
        objCd_S.EliminarSalida(obj)
    End Sub

    Function ListarSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.ListarSalidas(obj)
    End Function

    Function EgresosMesActivo(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.EgresosMesActivo(obj)
    End Function

    Function EgresosFecha(ByVal obj As Ce_Alm_Salidas, obj1 As Ce_RFecha) As DataSet
        Return objCd_S.EgresosFecha(obj, obj1)
    End Function

    Function ContarSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.ContarSalidas(obj)
    End Function

    Function LsitarsALIDASAjustes(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.LsitarSalidasAjustes(obj)
    End Function

    Function VerSumaSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.VerSumaSalidas(obj)
    End Function

    Function SalidasRescate(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.SalidasRescate(obj)
    End Function

    Function EgresosPorTipoSalida(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.EgresosPorTipoSalida(obj)
    End Function

    Function EgresosPorArea(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.EgresosPorArea(obj)
    End Function

    Function ListarSalidasTraslado(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.ListarSalidasTraslaodo(obj)
    End Function

    Function ListarSalidasNuevoCierre(ByVal obj As Ce_Alm_Salidas) As DataSet
        Return objCd_S.ListarSalidasNuevoCierre(obj)
    End Function
End Class