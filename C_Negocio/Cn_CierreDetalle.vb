Imports C_Datos
Imports C_Entidad
Public Class Cn_CierreDetalle
    Dim objCd_Cd As New Cd_Cierre_Detalle

    Sub NuevoCierreDetalle(ByVal obj As Ce_Cierre_Detalle)
        objCd_Cd.NuevoCierreDetalle(obj)
    End Sub

    Sub ModificarCierreDetalle(ByVal obj As Ce_Cierre_Detalle)
        objCd_Cd.ModifcarCierreDetalle(obj)
    End Sub

    Function ListarCierreDetalle(ByVal obj As Ce_Cierre_Detalle)
        Return objCd_Cd.ListarCierreDetalle(obj)
    End Function
End Class
