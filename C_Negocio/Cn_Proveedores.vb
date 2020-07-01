Imports C_Entidad
Imports C_Datos
Public Class Cn_Proveedores
    Dim objCd_P As New Cd_Proveedores

    Sub NuevoProveedor(ByVal obj As Ce_Proveedores)
        objCd_P.NuevoProveedor(obj)
    End Sub

    Sub ModificarProveedor(ByVal obj As Ce_Proveedores)
        objCd_P.ModificarProveedor(obj)
    End Sub

    Sub EliminarProveedor(ByVal obj As Ce_Proveedores)
        objCd_P.EliminarProveedor(obj)
    End Sub

    Function ListarProveedores() As DataSet
        Return objCd_P.ListarProveedores
    End Function

    Function ListarProveedoresActivos() As DataSet
        Return objCd_P.ListarProveedoresActivos
    End Function

    Function ExisteProveedor(ByVal obj As Ce_Proveedores) As DataSet
        Return objCd_P.ExisteProveedores(obj)
    End Function

End Class
