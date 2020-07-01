Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_AF
    Dim objCd_R As New Cd_Rips_AF

    Sub Nuevo_Rips_AF(ByVal obj As Ce_Rips_AF)
        objCd_R.Nuevo_Rips_AF(obj)
    End Sub

    Sub LimpiarAF()
        objCd_R.LimpiarAF()
    End Sub
    Function Listar_Rips_AF() As DataSet
        Return objCd_R.Listar_Rips_AF
    End Function
End Class
