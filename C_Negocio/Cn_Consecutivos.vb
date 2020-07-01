Imports C_Entidad
Imports C_Datos
Public Class Cn_Consecutivos
    Dim objCd_C As New Cd_Consecutivos

    Sub ActualizarConsFunc(ByVal obj As Ce_Consecutivos)
        objCd_C.ActualizarConFunc(obj)
    End Sub

    Sub ActualizarConsEntradas(ByVal obj As Ce_Consecutivos)
        objCd_C.ActualizarConEntradas(obj)
    End Sub

    Sub ActualizarConsSalidas(ByVal obj As Ce_Consecutivos)
        objCd_C.ActualizarConSalidas(obj)
    End Sub

    Sub ActualizarConsTraslados(ByVal obj As Ce_Consecutivos)
        objCd_C.ActualizarConTraslados(obj)
    End Sub

    Function VerConsFunc() As DataSet
        Return objCd_C.VerConsFunc()
    End Function

    Function VerConsEntradas() As DataSet
        Return objCd_C.VerConsEntradas()
    End Function

    Function VerConsSalidas() As DataSet
        Return objCd_C.VerConsSalidas()
    End Function

    Function VerConsTraslados() As DataSet
        Return objCd_C.VerConsTraslados()
    End Function

End Class
