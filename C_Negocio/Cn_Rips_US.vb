Imports C_Entidad
Imports C_Datos
Public Class Cn_Rips_US
    Dim objCd_R As New Cd_Rips_US

    Sub Nuevo_Rips_US(ByVal obj As Ce_Rips_US)
        objCd_R.Nuevo_Rips_US(obj)
    End Sub

    Sub LimpiarUS()
        objCd_R.LimpiarUS()
    End Sub
    Function Listar_Rips_US() As DataSet
        Return objCd_R.Listar_Rips_US
    End Function
End Class
