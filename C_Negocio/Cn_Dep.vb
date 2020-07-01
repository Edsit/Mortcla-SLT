Imports C_Entidad
Imports C_Datos
Public Class Cn_Dep
    Dim objCd_D As New Cd_Dep

    Sub Nuevo_Dep(ByVal obj As Ce_Dep)
        objCd_D.Nuevo_Dep(obj)
    End Sub

    Sub Editar_Dep(ByVal obj As Ce_Dep)
        objCd_D.Editar_Dep(obj)
    End Sub

    Sub Eliminar_Dep(ByVal obj As Ce_Dep)
        objCd_D.Eliminar_Dep(obj)
    End Sub

    Function Listar_Dep()
        Return objCd_D.Listar_Dep
    End Function

    Function Listar_Dep_Activos()
        Return objCd_D.Listar_Dep_Activos
    End Function

    Function Ver_Dep_Cons(ByVal obj As Ce_Dep)
        Return objCd_D.Ver_Dep_Id(obj)
    End Function
End Class
