Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Laboratorio
    Dim objCd_L As New Cd_Alm_Laboratorios

    Sub NuevoLab(ByVal obj As Ce_Alm_Laboratorios)
        objCd_L.NuevoLab(obj)
    End Sub

    Sub ModificarLab(ByVal obj As Ce_Alm_Laboratorios)
        objCd_L.ModificarLab(obj)
    End Sub

    Sub EliminarLab(ByVal obj As Ce_Alm_Laboratorios)
        objCd_L.EliminarLab(obj)
    End Sub

    Function ListarLab() As DataSet
        Return objCd_L.ListarLab
    End Function

    Function ListarLabActivos() As DataSet
        Return objCd_L.ListarLabActivos
    End Function

    Function ExisteLab(ByVal obj As Ce_Alm_Laboratorios) As DataSet
        Return objCd_L.ExisteLab(obj)
    End Function
End Class
