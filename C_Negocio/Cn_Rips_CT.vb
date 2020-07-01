Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_CT
    Dim objCd_R As New Cd_Rips_CT

    Sub Nuevo_Rips_CT(ByVal obj As Ce_Rips_CT)
        objCd_R.Nuevo_Rips_CT(obj)
    End Sub

    Sub LimpiarCT()
        objCd_R.LimpiarCT()
    End Sub
    Function Listar_Rips_CT() As DataSet
        Return objCd_R.Listar_Rips_CT
    End Function

    Function Listar_Est_Gen_CT() As DataSet
        Return objCd_R.Listar_Est_Gen_CT
    End Function
End Class
