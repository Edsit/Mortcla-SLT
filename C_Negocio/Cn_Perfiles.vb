Imports C_Entidad
Imports C_Datos
Public Class Cn_Perfiles
    Dim objCd_P As New Cd_Perfiles

    Sub NuevoPerfil(ByVal obj As Ce_Perfiles)
        objCd_P.NuevoPerfil(obj)
    End Sub

    Sub ModificarPerfil(ByVal obj As Ce_Perfiles)
        objCd_P.ModificarPerfil(obj)
    End Sub

    Sub EliminarPerfil(ByVal obj As Ce_Perfiles)
        objCd_P.EliminarPerfil(obj)
    End Sub

    Function ListarPerfiles() As DataSet
        Return objCd_P.ListarPerfiles
    End Function

    Function ListarPerfilesActivos() As DataSet
        Return objCd_P.ListarPerfilesActivos
    End Function

End Class
