Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Usuarios
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Usuario(ByVal obj As Ce_Usuarios)
        obj.FecNac = CDate(obj.FecNac).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Usuarios(Tdoc,Doc,Nombre1,Nombre2,Apellido1,Apellido2,FecNac,Dep,Mun,Zona,Barrio,Dir,Tel,EAPB,TipoEAPB,Genero,Nacionalidad,Estado)Values(@Tdoc,@Doc,@Nombre1,@Nombre2,@Apellido1,@Apellido2,@FecNac,@Dep,@Mun,@Zona,@Barrio,@Dir,@Tel,@EAPB,@TipoEAPB,@Genero,@Nacionalidad,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre1", obj.Nombre1)
            cmd.Parameters.Add("@Nombre2", obj.Nombre2)
            cmd.Parameters.Add("@Apellido1", obj.Apellido1)
            cmd.Parameters.Add("@Apellido2", obj.Apellido2)
            cmd.Parameters.Add("@FecNac", obj.FecNac)
            cmd.Parameters.Add("@Dep", obj.Dep)
            cmd.Parameters.Add("@Mun", obj.Mun)
            cmd.Parameters.Add("@Zona", obj.Zona)
            cmd.Parameters.Add("@Barrio", obj.Barrio)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@EAPB", obj.EAPB)
            cmd.Parameters.Add("@TipoEAPB", obj.TipoEAPB)
            cmd.Parameters.Add("@Genero", obj.Genero)
            cmd.Parameters.Add("@Nacionalidad", obj.Nacionalidad)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El usuario se ha registrado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Nuevo_Barrio (Cd_Usuarios): " & ex.Message)
        End Try
    End Sub

    Sub Modificar_Usuario(ByVal obj As Ce_Usuarios)
        obj.FecNac = CDate(obj.FecNac).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Usuarios Set Tdoc=@Tdoc,Doc=@Doc,Nombre1=@Nombre1,Nombre2=@Nombre2,Apellido1=@Apellido1,Apellido2=@Apellido2,FecNac=@FecNac,Dep=@Dep,Mun=@Mun,Zona=@Zona,Barrio=@Barrio,Dir=@Dir,Tel=@Tel,EAPB=@EAPB,TipoEAPB=@TipoEAPB,Genero=@Genero,Nacionalidad=@Nacionalidad,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre1", obj.Nombre1)
            cmd.Parameters.Add("@Nombre2", obj.Nombre2)
            cmd.Parameters.Add("@Apellido1", obj.Apellido1)
            cmd.Parameters.Add("@Apellido2", obj.Apellido2)
            cmd.Parameters.Add("@FecNac", obj.FecNac)
            cmd.Parameters.Add("@Dep", obj.Dep)
            cmd.Parameters.Add("@Mun", obj.Mun)
            cmd.Parameters.Add("@Zona", obj.Zona)
            cmd.Parameters.Add("@Barrio", obj.Barrio)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@EAPB", obj.EAPB)
            cmd.Parameters.Add("@TipoEAPB", obj.TipoEAPB)
            cmd.Parameters.Add("@Genero", obj.Genero)
            cmd.Parameters.Add("@Nacionalidad", obj.Nacionalidad)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El usuario se ha modificado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Modificar_Usuario (Cd_Usuarios): " & ex.Message)
        End Try
    End Sub

    Sub Eliminar_Usuario(ByVal obj As Ce_Usuarios)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Usuarios Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El usuario se ha eliminado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Eliminar_Usuario (Cd_Usuarios): " & ex.Message)
        End Try
    End Sub

    Function ExisteUsuario(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Usuarios Where Tdoc=" & obj.Tdoc & " and Doc='" & obj.Doc & "'"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function Ver_Usuario_Doc(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select U.Cons,Td.Tipo || ' - ' ||Td.Detalle As Tdoc,U.Doc,U.Nombre1,U.Nombre2,U.Apellido1,U.Apellido2,U.FecNac,D.Dep,M.Mun,U.Zona,B.Barrio,U.Dir,U.Tel,E.Codigo || ' - ' || E.Nombre as EPS,Tu.Tipo,G.Genero,N.Nacionalidad,CASE U.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From usuarios U Left Join Tdoc Td On U.Tdoc=Td.Cons Left Join Dep D On U.Dep=D.Cons Left Join Mun M On U.Mun=M.Cons Left join Barrios B On U.Barrio=B.Cons Left Join EPS E On U.EAPB=E.Cons Left Join TipoUsuario Tu On U.TipoEAPB=Tu.Cons Left Join Genero G On U.Genero=G.Cons Left Join Nacionalidad N On U.Nacionalidad=N.Cons Where U.Doc='" & obj.Doc & "'"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function Ver_Usuario_Cons(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select U.Cons,Td.Tipo || ' - ' ||Td.Detalle As Tdoc,U.Doc,U.Nombre1,U.Nombre2,U.Apellido1,U.Apellido2,U.FecNac,D.Dep,M.Mun,U.Zona,B.Barrio,U.Dir,U.Tel,E.Nombre,Tu.Tipo,G.Genero,N.Nacionalidad,CASE U.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From usuarios U Left Join Tdoc Td On U.Tdoc=Td.Cons Left Join Dep D On U.Dep=D.Cons Left Join Mun M On U.Mun=M.Cons Left join Barrios B On U.Barrio=B.Cons Left Join Eps E On U.EAPB=E.Cons Left Join TipoUsuario Tu On U.TipoEAPB=Tu.Cons Left Join Genero G On U.Genero=G.Cons Left Join Nacionalidad N On U.Nacionalidad=N.Cons Where U.Cons='" & obj.Cons & "'"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function Listar_Usuarios() As DataSet

    End Function

    Function Listar_UsuariosActivos() As DataSet

    End Function

    Function BuscarUsuarioDoc(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Cons As CONS,Doc As DOCUMENTO,Nombre1 AS 'PRIMER NOMBRE',Nombre2 AS 'SEGUNDO NOMBRE',Apellido1 AS 'PRIMER APELLIDO',Apellido2 AS 'SEGUNDO APELLIDO' From usuarios Where (Doc Like '%" & obj.Doc & "%') And (Estado=1)"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function BuscarUsuarioNombre(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Cons As CONS,Doc As DOCUMENTO,Nombre1 AS 'PRIMER NOMBRE',Nombre2 AS 'SEGUNDO NOMBRE',Apellido1 AS 'PRIMER APELLIDO',Apellido2 AS 'SEGUNDO APELLIDO' From usuarios Where (Nombre1 Like '%" & obj.Nombre1 & "%') Or (Nombre2 Like '%" & obj.Nombre2 & "%') And (Estado=1)"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function BuscarUsuarioApellido(ByVal obj As Ce_Usuarios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Cons As CONS,Doc As DOCUMENTO,Nombre1 AS 'PRIMER NOMBRE',Nombre2 AS 'SEGUNDO NOMBRE',Apellido1 AS 'PRIMER APELLIDO',Apellido2 AS 'SEGUNDO APELLIDO' From usuarios Where (Apellido1 Like '%" & obj.Apellido1 & "%') Or (Apellido2 Like '%" & obj.Apellido2 & "%') And (Estado=1)"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function
End Class
