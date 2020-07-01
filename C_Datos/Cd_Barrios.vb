Imports Finisar.SQLite
Imports C_Entidad
Public Class Cd_Barrios
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Barrio(ByVal obj As Ce_Barrio)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Barrios(CodMun,Zona,Barrio,Estado)Values(@CodMun,@Zona,@Barrio,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodMun", obj.CodMun)
            cmd.Parameters.Add("@Zona", obj.Zona)
            cmd.Parameters.Add("@Barrio", obj.Barrio)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El barrio y/o vereda se ha registrado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Nuevo_Barrio (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Modificar_Barrio(ByVal obj As Ce_Barrio)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Barrios Set Zona=@Zona,Barrio=@Barrio,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Zona", obj.Zona)
            cmd.Parameters.Add("@Barrio", obj.Barrio)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El barrio y/o vereda se ha modificado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Modificar_Barrio (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Eliminar_Barrio(ByVal obj As Ce_Barrio)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Barrios Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El barrio y/o vereda se ha eliminado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Eliminar_Barrio (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function ListarBarrios(ByVal obj As Ce_Barrio) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Barrio As BARRIO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Barrios Where CodMun=@CodMun And Zona=@Zona Order By Barrio"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodMun", obj.CodMun)
            cmd.Parameters.Add("@Zona", obj.Zona)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("ListarBarrios (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Function

    Function ListarBarriosActivos(ByVal obj As Ce_Barrio) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Barrio As BARRIO From Barrios Where CodMun=@CodMun And Zona=@Zona And Estado=1 Order By Barrio"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodMun", obj.CodMun)
            cmd.Parameters.Add("@Zona", obj.Zona)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("ListarBarriosActivos (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Function

    Function Ver_Cons_Barrio(ByVal obj As Ce_Barrio) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons From Barrios Where Barrio=@Barrio"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Barrio", obj.Barrio)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Ver_Cons_Barrio (Cd_Barrios): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function
End Class
