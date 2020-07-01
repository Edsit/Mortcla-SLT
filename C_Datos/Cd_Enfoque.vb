Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Enfoque
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Enfoque(ByVal obj As Ce_Enfoque)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Enfoque(Enfoque,Estado)Values(@Enfoque,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Enfoque", obj.Enfoque)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El enfoque se ha registrado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Nuevo_Enfoque (Cd_Enfoque): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Modificar_Enfoque(ByVal obj As Ce_Enfoque)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Enfoque Set Enfoque=@Enfoque,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Enfoque", obj.Enfoque)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El enfoque se ha Modificado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Modificar_Enfoque (Cd_Enfoque): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Eliminar_Enfoque(ByVal obj As Ce_Enfoque)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Enfoque Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El enfoque se ha Eliminado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Eliminar_Enfoque (Cd_Enfoque): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function ListarEnfoques() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Enfoque As ENFOQUE,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Enfoque Order By Enfoque"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("ListarBarrios (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Function

    Function ListarEnfoquesActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Enfoque As ENFOQUE From Enfoque Where Estado=1 Order By Enfoque"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("ListarBarrios (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Function

End Class
