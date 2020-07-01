Imports C_Entidad
Imports C_Datos
Public Class Cn_SedesDir
    Dim objCd_SD As New Cd_SedesDir

    Sub NuevoSedeDir(ByVal obj As Ce_SedesDir)
        objCd_SD.NuevoSedeDir(obj)
    End Sub

    Sub ModificarSedeDir(ByVal obj As Ce_SedesDir)
        objCd_SD.ModificarSedeDir(obj)
    End Sub

    Sub EliminarSedeDir(ByVal obj As Ce_SedesDir)
        objCd_SD.EliminarSedeDir(obj)
    End Sub

    Function ListaSedesDir(ByVal obj As Ce_SedesDir) As DataSet
        Return objCd_SD.ListarSedesDir(obj)
    End Function

    Function ListarSedesDirActivas(ByVal obj As Ce_SedesDir) As DataSet
        Return objCd_SD.ListarSedesDirActivas(obj)
    End Function

    Function ExisteSede(ByVal obj As Ce_SedesDir) As DataSet
        Return objCd_SD.ExisteSedesDir(obj)
    End Function
End Class
