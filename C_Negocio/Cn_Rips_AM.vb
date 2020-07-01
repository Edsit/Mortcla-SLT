Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_AM
    Dim objCd_R As New Cd_Rips_AM

    Sub Nuevo_Rips_AT(ByVal obj As Ce_Rips_AM)
        objCd_R.Nuevo_Rips_AM(obj)
    End Sub

    Sub LimpiarAM()
        objCd_R.LimpiarAM()
    End Sub
    Function Listar_Rips_AM() As DataSet
        Return objCd_R.Listar_Rips_AM
    End Function
End Class
