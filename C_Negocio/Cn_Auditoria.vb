Imports C_Entidad
Imports C_Datos
Public Class Cn_Auditoria
    Dim objCd_A As New Cd_Auditoria

    Sub NuevoAuditoria(ByVal obj As Ce_Auditoria)
        objCd_A.NuevoAuditoria(obj)
    End Sub
End Class
