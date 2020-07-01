Imports C_Entidad
Imports C_Datos
Public Class Cn_Stop
    Dim objCd_S As New Cd_Stop

    Sub NuevaSalidaStop(ByVal obj As Ce_Alm_Stop)
        objCd_S.NuevoSalidaStop(obj)
    End Sub
End Class
