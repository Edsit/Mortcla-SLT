Imports C_Datos
Imports C_Entidad
Public Class Cn_Traslados
    Dim objCd_T As New Cd_Traslados

    Sub NuevoTraslado(ByVal obj As Ce_Traslados)
        objCd_T.NuevoTraslado(obj)
    End Sub

    Function ListarTraslados() As DataSet
        Return objCd_T.ListarTraslaodos
    End Function

    Function ListarTrasladosTProd(ByVal obj As Ce_Traslados) As DataSet
        Return objCd_T.ListarTraslaodosTProd(obj)
    End Function
End Class
