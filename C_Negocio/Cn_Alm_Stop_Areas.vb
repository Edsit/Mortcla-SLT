Imports C_Datos
Imports C_Entidad
Public Class Cn_Alm_Stop_Areas
    Dim objCd_S As New Cd_Stop_Areas

    Sub NuevoStopArea(ByVal obj As Ce_Alm_Stop_Areas)
        objCd_S.NuevoStop_Area(obj)
    End Sub

    Sub ModificarStopArea(ByVal obj As Ce_Alm_Stop_Areas)
        objCd_S.ModificarStop_Area(obj)
    End Sub

    Function ExisteStopArea(ByVal obj As Ce_Alm_Stop_Areas) As DataSet
        Return objCd_S.ExisteStop_Area(obj)
    End Function

    Function ListarStopArea() As DataSet
        Return objCd_S.ListarStopAreas
    End Function

    Function ListarStopAreaActivos() As DataSet
        Return objCd_S.ListarStopAreas
    End Function

End Class
