Imports C_Entidad
Imports C_Datos
Public Class Cn_Enfoques
    Dim objCd_E As New Cd_Enfoque

    Sub Nuevo_Enfoque(ByVal obj As Ce_Enfoque)
        objCd_E.Nuevo_Enfoque(obj)
    End Sub

    Sub Modificar_Enfoque(ByVal obj As Ce_Enfoque)
        objCd_E.Modificar_Enfoque(obj)
    End Sub

    Sub Eliminar_Enfoque(ByVal obj As Ce_Enfoque)
        objCd_E.Eliminar_Enfoque(obj)
    End Sub

    Function ListarEnfoques() As DataSet
        Return objCd_E.ListarEnfoques
    End Function

    Function ListarEnfoquesActivos() As DataSet
        Return objCd_E.ListarEnfoquesActivos
    End Function

End Class
