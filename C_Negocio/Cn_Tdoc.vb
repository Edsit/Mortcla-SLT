Imports C_Entidad
Imports C_Datos
Public Class Cn_Tdoc
    Dim objCd_T As New Cd_Tdoc

    Function ListarTdocActivos() As DataSet
        Return objCd_T.ListarTdocActivos()
    End Function
End Class
