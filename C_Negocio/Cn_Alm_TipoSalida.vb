Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_TipoSalida
    Dim objCd_Tp As New Cd_Alm_TipoSalida

    Sub NuevoTipoSalida(ByVal obj As Ce_Alm_TipoSalida)
        objCd_Tp.NuevoTipoSalida(obj)
    End Sub

    Sub ModificarTipoSalida(ByVal obj As Ce_Alm_TipoSalida)
        objCd_Tp.ModificarTipoSaida(obj)
    End Sub

    Sub EliminarTipoSalida(ByVal obj As Ce_Alm_TipoSalida)
        objCd_Tp.EliminarTipoSalida(obj)
    End Sub

    Function ExisteTipoSalida(ByVal obj As Ce_Alm_TipoSalida) As DataSet
        Return objCd_Tp.ExisteTipoSalida(obj)
    End Function

    Function ListarTipoSalida() As DataSet
        Return objCd_Tp.ListarTipoSalida()
    End Function

    Function ListarTipoSalidaActivos() As DataSet
        Return objCd_Tp.ListarTipoSalidaActivos()
    End Function
End Class
