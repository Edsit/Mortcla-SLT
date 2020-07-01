Imports C_Entidad
Imports C_Datos
Public Class Cn_MesEstado
    Dim objCd_MesEsatdo As New Cd_MesEstado

    Function LoadMesActivo() As DataSet
        Return objCd_MesEsatdo.LoadMesActivo
    End Function

    Sub EditMesActivo(ByVal obj As Ce_MesEstado)
        objCd_MesEsatdo.EditMesActivo(obj)
    End Sub

    Sub NuevoMesActivo(ByVal obj As Ce_MesEstado)
        objCd_MesEsatdo.NuevoMesActivo(obj)
    End Sub
End Class
