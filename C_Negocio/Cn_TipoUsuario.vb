Imports C_Datos
Imports C_Entidad
Public Class Cn_TipoUsuario
    Dim objCd_Tu As New Cd_TipoUsuario

    Function ListarTupoUsuarioActivos() As DataSet
        Return objCd_Tu.ListarTUsuariosActivos
    End Function
End Class
