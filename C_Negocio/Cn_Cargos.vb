Imports C_Entidad
Imports C_Datos
Public Class Cn_Cargos
    Dim objCd_C As New Cd_Cargos

    Sub NuevoCargo(ByVal obj As Ce_Cargos)
        objCd_C.NUevoCargo(obj)
    End Sub

    Sub ModificarCargo(ByVal obj As Ce_Cargos)
        objCd_C.ModificarCargo(obj)
    End Sub

    Sub EliminarCargo(ByVal obj As Ce_Cargos)
        objCd_C.EliminarCargo(obj)
    End Sub

    Function ListarCargos() As DataSet
        Return objCd_C.ListarCargos
    End Function

    Function ListarCargosActivos() As DataSet
        Return objCd_C.ListarCargosActivos
    End Function
End Class
