Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Bajas
    Dim objCd_B As New Cd_Alm_Bajas

    Sub NuevaBaja(ByVal obj As Ce_Alm_Baja)
        objCd_B.NuevoBaja(obj)
    End Sub

    Function GenerarActadeBaja(obj, obj1) As DataSet
        Return objCd_B.GenerarActadeBaja(obj, obj1)
    End Function
End Class
