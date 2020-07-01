Imports C_Entidad
Imports C_Datos
Public Class Cn_Eps
    Dim objCd_E As New Cd_Eps

    Sub NuevoEps(ByVal obj As Ce_Eps)
        objCd_E.NuevoEps(obj)
    End Sub

    Sub ModificarEps(ByVal obj As Ce_Eps)
        objCd_E.ModificarEps(obj)
    End Sub

    Sub EliminarEps(ByVal obj As Ce_Eps)
        objCd_E.EliminarEps(obj)
    End Sub

    Function ListarEps() As DataSet
        Return objCd_E.ListarEps
    End Function

    Function ListarEpsActivo() As DataSet
        Return objCd_E.ListarEpsActivas
    End Function
End Class
