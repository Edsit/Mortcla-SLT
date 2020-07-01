Imports C_Entidad
Imports C_Datos
Public Class Cn_Usuarios
    Dim objCd_U As New Cd_Usuarios

    Sub Nuevo_Usuario(ByVal obj As Ce_Usuarios)
        objCd_U.Nuevo_Usuario(obj)
    End Sub

    Sub Modificar_Usuario(ByVal obj As Ce_Usuarios)
        objCd_U.Modificar_Usuario(obj)
    End Sub

    Sub Eliminar_Usuario(ByVal obj As Ce_Usuarios)
        objCd_U.Eliminar_Usuario(obj)
    End Sub

    Function VerUsuarioDoc(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.Ver_Usuario_Doc(obj)
    End Function

    Function VerUsuarioCons(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.Ver_Usuario_Cons(obj)
    End Function

    Function Listar_Usuarios() As DataSet
        Return objCd_U.Listar_Usuarios
    End Function

    Function Listar_UsuariosActivos() As DataSet
        Return objCd_U.Listar_UsuariosActivos
    End Function

    Function ExisteUsuario(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.ExisteUsuario(obj)
    End Function

    Function BuscarUsuarioDoc(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.BuscarUsuarioDoc(obj)
    End Function

    Function BuscarUsuarioNombre(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.BuscarUsuarioNombre(obj)
    End Function

    Function BuscarUsuarioApellido(ByVal obj As Ce_Usuarios) As DataSet
        Return objCd_U.BuscarUsuarioApellido(obj)
    End Function
End Class
