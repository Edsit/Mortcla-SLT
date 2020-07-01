Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Perfiles
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoPerfil(ByVal obj As Ce_Perfiles)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Perfiles(Perfil,Estado)Values(@Perfil,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Perfil", obj.Perfil)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El perfil se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Perfil")
        Catch ex As Exception
            MsgBox("NuevoPerfil - (Cd_Perfiles): " & ex.Message)
        End Try
    End Sub

    Sub ModificarPerfil(ByVal obj As Ce_Perfiles)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Perfiles Set Perfil=@Perfil,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Perfil", obj.Perfil)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El perfil se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de Perfil")
        Catch ex As Exception
            MsgBox("ModificarPerfil - (Cd_Perfiles): " & ex.Message)
        End Try
    End Sub

    Sub EliminarPerfil(ByVal obj As Ce_Perfiles)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Perfiles Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El perfil se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminación de Perfil")
        Catch ex As Exception
            MsgBox("EliminarPerfil - (Cd_Perfiles): " & ex.Message)
        End Try
    End Sub

    Function ListarPerfiles() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Perfil,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Perfiles"
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

    Function ListarPerfilesActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Perfil From Perfiles Where Estado='1'"
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
