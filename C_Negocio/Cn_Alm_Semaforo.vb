Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Semaforo
    Dim objCd_S As New Cd_Alm_Semaforo

    Sub MOdificarSemaforo(ByVal obj As Ce_Alm_Semaforo)
        objCd_S.ModificarSemaforo(obj)
    End Sub

    Function ListarSemaforo() As DataSet
        Return objCd_S.ListarSemaforo
    End Function
End Class
