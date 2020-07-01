Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_AC
    Dim objCd_R As New Cd_Rips_AC

    Sub Nuevo_Rips_AC(ByVal obj As Ce_Rips_AC)
        objCd_R.Nuevo_Rips_AC(obj)
    End Sub

    Sub LimpiarAC()
        objCd_R.LimpiarAC()
    End Sub
    Function Listar_Rips_AC() As DataSet
        Return objCd_R.Listar_Rips_AC
    End Function
End Class
