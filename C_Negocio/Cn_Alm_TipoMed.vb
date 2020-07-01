Imports C_Datos
Imports C_Entidad
Public Class Cn_Alm_TipoMed
    Dim objCd_M As New Cd_Alm_TipoMed

    Sub NuevoTipoMed(ByVal obj As Ce_Alm_TipoMed)
        objCd_M.NuevoTipoMed(obj)
    End Sub

    Sub ModificarTipoMed(ByVal obj As Ce_Alm_TipoMed)
        objCd_M.ModificarTipoMed(obj)
    End Sub

    Sub EliminarTipoMed(ByVal obj As Ce_Alm_TipoMed)
        objCd_M.EliminarTipoMed(obj)
    End Sub

    Function ExisteTipoMed(ByVal obj As Ce_Alm_TipoMed) As DataSet
        Return objCd_M.ExisteTipoMed(obj)
    End Function

    Function ListarTipoMed() As DataSet
        Return objCd_M.ListarTipoMed()
    End Function

    Function ListarTipoMedActivos() As DataSet
        Return objCd_M.ListarTipoMedActivos()
    End Function
End Class
