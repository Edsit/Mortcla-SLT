Imports C_Entidad
Imports C_Datos
Public Class Cn_SedesTel
    Dim objCd_ST As New Cd_SedesTel

    Sub NuevoSedeTel(ByVal obj As Ce_SedesTel)
        objCd_ST.NuevoSedeTel(obj)
    End Sub

    Sub ModificarSedeTel(ByVal obj As Ce_SedesTel)
        objCd_ST.ModificarSedeTel(obj)
    End Sub

    Sub EliminarSedeTel(ByVal obj As Ce_SedesTel)
        objCd_ST.EliminarSedeTel(obj)
    End Sub

    Function ListaSedesTel(ByVal obj As Ce_SedesTel) As DataSet
        Return objCd_ST.ListarSedesTel(obj)
    End Function

    Function ListarSedesTelActivas(ByVal obj As Ce_SedesTel) As DataSet
        Return objCd_ST.ListarSedesTelActivas(obj)
    End Function

    Function ExisteSede(ByVal obj As Ce_SedesTel) As DataSet
        Return objCd_ST.ExisteSedesTel(obj)
    End Function
End Class
