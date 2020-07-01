Imports C_Datos
Imports C_Entidad
Public Class Cn_Alm_TipoProd
    Dim objCd_Tp As New Cd_Alm_TipoProd

    Sub NuevoTipoProd(ByVal obj As Ce_Alm_TipoProd)
        objCd_Tp.NuevoTipoProd(obj)
    End Sub

    Sub ModificarTipoProd(ByVal obj As Ce_Alm_TipoProd)
        objCd_Tp.ModificarTipoProd(obj)
    End Sub

    Sub EliminarTipoProd(ByVal obj As Ce_Alm_TipoProd)
        objCd_Tp.EliminarTipoProd(obj)
    End Sub

    Function ExisteTipoProd(ByVal obj As Ce_Alm_TipoProd) As DataSet
        Return objCd_Tp.ExisteTipoProd(obj)
    End Function

    Function ListarTipoProd() As DataSet
        Return objCd_Tp.ListarTipoProd()
    End Function

    Function ListarTipoProdActivos() As DataSet
        Return objCd_Tp.ListarTipoProdActivos()
    End Function

End Class
