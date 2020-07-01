Imports C_Entidad
Imports C_Datos
Public Class Cn_Sedes
    Dim objCd_S As New Cd_Sedes

    Sub NuevoSede(ByVal obj As Ce_Sedes)
        objCd_S.NuevoSede(obj)
    End Sub

    Sub ModificarSede(ByVal obj As Ce_Sedes)
        objCd_S.ModificarSede(obj)
    End Sub

    Sub EliminarSede(ByVal obj As Ce_Sedes)
        objCd_S.EliminarSede(obj)
    End Sub

    Function LoadSedes() As DataSet
        Return objCd_S.ListarSedes()
    End Function

    Function LoadSedesActivas() As DataSet
        Return objCd_S.ListarSedesActivas()
    End Function

    Function ExisteSede(ByVal obj As Ce_Sedes) As DataSet
        Return objCd_S.ExisteSede(obj)
    End Function

    Sub SedeSelNO()
        objCd_S.SedeSelNO()
    End Sub

    Sub SedeSelSI(ByVal obj As Ce_Sedes)
        objCd_S.SedeSelSI(obj)
    End Sub

    Function ListarSedesRotacion()
        Return objCd_S.ListarSedesRotacion
    End Function
End Class
