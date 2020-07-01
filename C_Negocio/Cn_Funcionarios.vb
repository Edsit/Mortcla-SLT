Imports C_Entidad
Imports C_Datos
Public Class Cn_Funcionarios
    Dim objCd_F As New Cd_Funcionarios

    Sub NuevoFuncionarios(ByVal obj As Ce_Funcionarios)
        objCd_F.NuevoFuncionario(obj)
    End Sub

    Sub MOdificarFuncionarios(ByVal obj As Ce_Funcionarios)
        objCd_F.ModificarFuncionario(obj)
    End Sub

    Sub CambiarPwd(ByVal obj As Ce_Funcionarios)
        objCd_F.CambiarPwd(obj)
    End Sub

    Sub EliminarFuncionarios(ByVal obj As Ce_Funcionarios)
        objCd_F.EliminarFuncionario(obj)
    End Sub

    Function VerFuncionarioDoc(ByVal obj As Ce_Funcionarios) As DataSet
        Return objCd_F.VerFuncinarioDoc(obj)
    End Function

    Function ExisteFuncionario(ByVal obj As Ce_Funcionarios) As DataSet
        Return objCd_F.ExisteFuncinario(obj)
    End Function

    Function Login(ByVal obj As Ce_Funcionarios) As DataSet
        Return objCd_F.Login(obj)
    End Function

    Function ListarFuncinarioSede(ByVal obj As Ce_Funcionarios) As DataSet
        Return objCd_F.ListarFuncinarioSede(obj)
    End Function

    Function ListarFuncinariosActivos() As DataSet
        Return objCd_F.ListarFuncinariosActivos
    End Function

    Function ListarFuncinarios() As DataSet
        Return objCd_F.ListarFuncinarios
    End Function
End Class
