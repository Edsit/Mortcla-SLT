Imports C_Entidad
Imports C_Datos
Public Class Cn_CCostos
    Dim objCd_C As New Cd_CCosto

    Sub NuevoCCosto(ByVal obj As Ce_CCostos)
        objCd_C.NuevoCCostos(obj)
    End Sub

    Sub ModificarCCosto(ByVal obj As Ce_CCostos)
        objCd_C.ModificarCCosto(obj)
    End Sub

    Sub EliminarCCosto(ByVal obj As Ce_CCostos)
        objCd_C.EliminarCCosto(obj)
    End Sub

    Function ExisteCCosto(ByVal obj As Ce_CCostos) As DataSet
        Return objCd_C.ExisteTipoProd(obj)
    End Function

    Function ListarCCosto() As DataSet
        Return objCd_C.ListarCCosto
    End Function

    Function ListarCCostoActivo() As DataSet
        Return objCd_C.ListarCCostoActivos
    End Function

End Class
