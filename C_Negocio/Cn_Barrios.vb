Imports C_Datos
Imports C_Entidad
Public Class Cn_Barrios
    Dim objCd_B As New Cd_Barrios

    Sub Nuevo_Barrio(ByVal obj As Ce_Barrio)
        objCd_B.Nuevo_Barrio(obj)
    End Sub

    Sub Modificar_Barrio(ByVal obj As Ce_Barrio)
        objCd_B.Modificar_Barrio(obj)
    End Sub

    Sub Eliminiar_Barrio(ByVal obj As Ce_Barrio)
        objCd_B.Eliminar_Barrio(obj)
    End Sub

    Function Listar_Barrios(ByVal obj As Ce_Barrio) As DataSet
        Return objCd_B.ListarBarrios(obj)
    End Function

    Function Listar_Barrios_Activos(ByVal obj As Ce_Barrio) As DataSet
        Return objCd_B.ListarBarriosActivos(obj)
    End Function

    Function Ver_Cons_Barrio(ByVal obj As Ce_Barrio) As DataSet
        Return objCd_B.Ver_Cons_Barrio(obj)
    End Function
End Class
