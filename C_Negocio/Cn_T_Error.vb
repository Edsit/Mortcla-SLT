Imports C_Entidad
Imports C_Datos
Public Class Cn_T_Error
    Dim objCd_Te As New Cd_T_Error

    Sub NuevoError(ByVal obj As Ce_T_Error)
        objCd_Te.NuevoError(obj)
    End Sub

    Function ListarErrores() As DataSet
        Return objCd_Te.ListarErrores
    End Function
End Class
