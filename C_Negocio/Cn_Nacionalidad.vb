Imports C_Entidad
Imports C_Datos
Public Class Cn_Nacionalidad
    Dim objCd_N As New Cd_Nacionalidad

    Sub Nueva_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        objCd_N.Nueva_Nacionalidad(obj)
    End Sub

    Sub Modificar_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        objCd_N.Modificar_Nacionalidad(obj)
    End Sub

    Sub Eliminar_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        objCd_N.Eliminiar_Nacionalidad(obj)
    End Sub

    Function Listar_Nacionalidad() As DataSet
        Return objCd_N.Listar_Nacionalidad
    End Function

    Function Listar_NacionalidadActivas() As DataSet
        Return objCd_N.Listar_NacionalidadActivas
    End Function
End Class
