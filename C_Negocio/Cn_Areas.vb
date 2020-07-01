Imports C_Entidad
Imports C_Datos
Public Class Cn_Areas
    Dim objCd_A As New Cd_Areas

    Sub NuevArea(ByVal obj As Ce_Areas)
        objCd_A.NuevArea(obj)
    End Sub

    Sub EditarArea(ByVal obj As Ce_Areas)
        objCd_A.EditarArea(obj)
    End Sub

    Sub EliminarArea(ByVal obj As Ce_Areas)
        objCd_A.EliminarArea(obj)
    End Sub

    Function ListarAreas() As DataSet
        Return objCd_A.ListarAreas
    End Function

    Function ListarAreasActivas() As DataSet
        Return objCd_A.ListarAreasActivas
    End Function
End Class
