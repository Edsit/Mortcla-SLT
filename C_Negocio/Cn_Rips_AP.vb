Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_AP
    Dim objCd_R As New Cd_Rips_AP

    Sub Nuevo_Rips_AP(ByVal obj As Ce_Rips_AP)
        objCd_R.Nuevo_Rips_AP(obj)
    End Sub

    Sub LimpiarAP()
        objCd_R.LimpiarAP()
    End Sub
    Function Listar_Rips_AP() As DataSet
        Return objCd_R.Listar_Rips_AP
    End Function
End Class
