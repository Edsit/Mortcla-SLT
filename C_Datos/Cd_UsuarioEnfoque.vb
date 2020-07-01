Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_UsuarioEnfoque
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_UsuarioEnfoque(ByVal obj As Ce_UsuarioEnfoque)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into UsuarioEnfoque(Usuario,Enfoque)Values(@Usuario,@Enfoque)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Usuario", obj.Usuario)
            cmd.Parameters.Add("@Enfoque", obj.Enfoque)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Nuevo_UsuarioEnfoque (Cd_UsuarioEnfoque): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Eliminar_UsuarioEnfoque(ByVal obj As Ce_UsuarioEnfoque)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From UsuarioEnfoque Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El enfoque ha sido eliminado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Eliminar_UsuarioEnfoque (Cd_UsuarioEnfoque): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function ListarUsuarioEnfoques(ByVal obj As Ce_UsuarioEnfoque) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select UE.Cons,E.Cons,E.Enfoque From UsuarioEnfoque UE Left Join Enfoque E On UE.Enfoque=E.Cons Where UE.Usuario=" & obj.Usuario
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
