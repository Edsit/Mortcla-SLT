Imports C_Entidad
Imports C_Datos
Public Class Cn_Mun
    Dim objCd_M As New Cd_Mun

    Sub NuevoMun(ByVal obj As Ce_Mun)
        objCd_M.Nuevo_Mun(obj)
    End Sub

    Sub ModificarMun(ByVal obj As Ce_Mun)
        objCd_M.Editar_Mun(obj)
    End Sub

    Sub EliminarMun(ByVal obj As Ce_Mun)
        objCd_M.Eliminar_Mun(obj)
    End Sub

    Function ListarMun(ByVal obj As Ce_Mun) As DataSet
        Return objCd_M.Listar_Mun(obj)
    End Function

    Function ListarMunActivos(ByVal obj As Ce_Mun) As DataSet
        Return objCd_M.Listar_Mun_Activos(obj)
    End Function

    Function Ver_Cons_Mun(ByVal obj As Ce_Mun) As DataSet
        Return objCd_M.Ver_Cons_Mun(obj)
    End Function
End Class
