Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_T2
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_T2(ByVal obj As Ce_T2)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into T2(C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12)Values(@C0,@C1,@C2,@C3,@C4,@C5,@C6,@C7,@C8,@C9,@C10,@C11,@C12,@Sede)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@C0", obj.C0)
            cmd.Parameters.Add("@C1", obj.C1)
            cmd.Parameters.Add("@C2", obj.C2)
            cmd.Parameters.Add("@C3", obj.C3)
            cmd.Parameters.Add("@C4", obj.C4)
            cmd.Parameters.Add("@C5", obj.C5)
            cmd.Parameters.Add("@C6", obj.C6)
            cmd.Parameters.Add("@C7", obj.C7)
            cmd.Parameters.Add("@C8", obj.C8)
            cmd.Parameters.Add("@C9", obj.C9)
            cmd.Parameters.Add("@C10", obj.C10)
            cmd.Parameters.Add("@C11", obj.C11)
            cmd.Parameters.Add("@C12", obj.C12)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Nuevo_T2 (Cd_T2): " & obj.C2 & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub
End Class
