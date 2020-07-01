Imports C_Entidad
Imports C_Datos
Public Class Cn_UsuariosEnfoques
    Dim objCd_E As New Cd_UsuarioEnfoque

    Sub Nuevo_UsuarioEnfoque(ByVal obj As Ce_UsuarioEnfoque)
        objCd_E.Nuevo_UsuarioEnfoque(obj)
    End Sub

    Sub Eliminar_UsuarioEnfoque(ByVal obj As Ce_UsuarioEnfoque)
        objCd_E.Eliminar_UsuarioEnfoque(obj)
    End Sub

    Function ListarUsuarioEnfoques(ByVal obj As Ce_UsuarioEnfoque) As DataSet
        Return objCd_E.ListarUsuarioEnfoques(obj)
    End Function
End Class
