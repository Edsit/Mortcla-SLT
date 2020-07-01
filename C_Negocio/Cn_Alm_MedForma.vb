Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_MedForma
    Dim objCd_F As New Cd_Alm_MedForma

    Sub NuevoMedForma(ByVal obj As Ce_Alm_MedForma)
        objCd_F.NuevoMedForma(obj)
    End Sub

    Sub ModificarMedForma(ByVal obj As Ce_Alm_MedForma)
        objCd_F.ModificarMedForma(obj)
    End Sub

    Sub EliminarMedForma(ByVal obj As Ce_Alm_MedForma)
        objCd_F.EliminarMedForma(obj)
    End Sub

    Function ExisteMedForma(ByVal obj As Ce_Alm_MedForma) As DataSet
        Return objCd_F.ExisteMedForma(obj)
    End Function

    Function ListarMedForma() As DataSet
        Return objCd_F.ListarMedForma()
    End Function

    Function ListarMedFormaActivos() As DataSet
        Return objCd_F.ListarMedFormaActivos()
    End Function
End Class
