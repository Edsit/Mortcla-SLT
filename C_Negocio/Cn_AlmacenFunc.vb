Imports C_Entidad
Imports C_Datos
Public Class Cn_AlmacenFunc
    Dim objCd_AF As New Cd_AlmacenFunc

    Sub NuevoAlmacenFunc(ByVal obj As Ce_AlmacenFunc)
        objCd_AF.NuevoAlmacenFunc(obj)
    End Sub

    Sub ModificarAlmacenFunc(ByVal obj As Ce_AlmacenFunc)
        objCd_AF.EditarAlmacenFunc(obj)
    End Sub

    Function ListarAlmacenFunc(ByVal obj As Ce_AlmacenFunc) As DataSet
        Return objCd_AF.ListarFuncionariosAlmacen(obj)
    End Function

End Class
