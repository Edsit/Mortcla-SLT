Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Funcionarios
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoFuncionario(ByVal obj As Ce_Funcionarios)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Funcionarios(Cons,Sede,Tdoc,Doc,Nombre,Cargo,Estado,Dir,Tel,Pwd,Perfil)Values(@Cons,@Sede,@Tdoc,@Doc,@Nombre,@Cargo,@Estado,@Dir,@Tel,@Pwd,@Perfil)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Cargo", obj.Cargo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Pwd", obj.Pwd)
            cmd.Parameters.Add("@Perfil", obj.Perfil)
            cmd.ExecuteNonQuery()
            MsgBox("El Funcionario se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Funcionario")
        Catch ex As Exception
            MsgBox("NuevoFuncionario - (Cd_Funcionarios): " & ex.Message)
        End Try
    End Sub

    Sub ModificarFuncionario(ByVal obj As Ce_Funcionarios)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Funcionarios Set Tdoc=@Tdoc,Doc=@Doc,Nombre=@Nombre,Cargo=@Cargo,Estado=@Estado,Dir=@Dir,Tel=@Tel Where Cons=@Cons And Sede=@Sede"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Cargo", obj.Cargo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.ExecuteNonQuery()
            MsgBox("El Funcionario se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Funcionario")
        Catch ex As Exception
            MsgBox("ModificarFuncionario - (Cd_Funcionarios): " & ex.Message)
        End Try
    End Sub

    Sub CambiarPwd(ByVal obj As Ce_Funcionarios)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Funcionarios Set Pwd=@Pwd Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Pwd", obj.Pwd)
            cmd.ExecuteNonQuery()
            MsgBox("La contraseña se ha cambiado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Cambiar Contraseña")
        Catch ex As Exception
            MsgBox("CambiarPwd - (Cd_Funcionarios): " & ex.Message)
        End Try
    End Sub

    Sub EliminarFuncionario(ByVal obj As Ce_Funcionarios)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Funcionarios Where Cons=@Cons And Sede=@Sede"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.ExecuteNonQuery()
            MsgBox("El Funcionario se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Funcionario")
        Catch ex As Exception
            MsgBox("EliminarFuncionario - (Cd_Funcionarios): " & ex.Message)
        End Try
    End Sub

    Function VerFuncinarioDoc(ByVal obj As Ce_Funcionarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select F.Cons,S.Sede,Td.Tipo ||' - '|| Td.Detalle As TDoc,F.Doc,F.Nombre,C.Cargo,F.Dir,F.Tel,CASE F.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Funcionarios F Left Join Sedes S On F.Sede=S.Cons Left Join Tdoc Td On F.Tdoc=Td.Cons Left Join Cargos C On F.Cargo=C.Cons Where Doc='" & obj.Doc & "'"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function

    Function ExisteFuncinario(ByVal obj As Ce_Funcionarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Count(Cons) From Funcionarios Where Doc='" & obj.Doc & "'"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function

    Function Login(ByVal obj As Ce_Funcionarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select  F.Cons,S.Cons As ConSede,S.Sede,F.Nombre,C.Cargo,F.Estado,F.Perfil,F.Pwd From Funcionarios F Left Join Sedes S On F.Sede=S.Cons Left Join Cargos C On F.Cargo=C.Cons Where Doc='" & obj.Doc & "'"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function

    Function ListarFuncinarioSede(ByVal obj As Ce_Funcionarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Nombre from funcionarios where Sede='" & obj.Sede & "' And Estado=1"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function

    Function ListarFuncinariosActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Nombre from funcionarios where Estado='1'"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function

    Function ListarFuncinarios() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select F.Cons,S.Sede,Td.Tipo ||' - '|| Td.Detalle As TDoc,F.Doc,F.Nombre,C.Cargo,F.Dir,F.Tel,CASE F.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Funcionarios F Left Join Sedes S On F.Sede=S.Cons Left Join Tdoc Td On F.Tdoc=Td.Cons Left Join Cargos C On F.Cargo=C.Cons"
            da = New SQLiteDataAdapter(sel, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            ds.Dispose()
        End Try
    End Function
End Class
