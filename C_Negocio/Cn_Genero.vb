Imports C_Entidad
Imports C_Datos
Public Class Cn_Genero
    Dim objCd_G As New Cd_Genero

    Function ListarGenerosActivos() As DataSet
        Return objCd_G.ListarGeneroActivas
    End Function
End Class
