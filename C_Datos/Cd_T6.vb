Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_T6
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_T6(ByVal obj As Ce_T6)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into T6(C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,C17,C18,C18,C19,C20,C21,C22,C23,C24,C25,C26,Sede)Values(@C0,@C1,@C2,@C3,@C4,@C5,@C6,@C7,@C8,@C9,@C10,@C11,@C12,@C13,@C14,@C15,@C16,@C17,@C18,@C19,@C20,@C21,@C22,@C23,@C24,@C25,@C26,@Sede)"
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
            cmd.Parameters.Add("@C13", obj.C13)
            cmd.Parameters.Add("@C14", obj.C14)
            cmd.Parameters.Add("@C15", obj.C15)
            cmd.Parameters.Add("@C16", obj.C16)
            cmd.Parameters.Add("@C17", obj.C17)
            cmd.Parameters.Add("@C18", obj.C18)
            cmd.Parameters.Add("@C19", obj.C19)
            cmd.Parameters.Add("@C20", obj.C20)
            cmd.Parameters.Add("@C21", obj.C21)
            cmd.Parameters.Add("@C22", obj.C22)
            cmd.Parameters.Add("@C23", obj.C23)
            cmd.Parameters.Add("@C24", obj.C24)
            cmd.Parameters.Add("@C25", obj.C25)
            cmd.Parameters.Add("@C26", obj.C26)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Nuevo_T6 (Cd_T6): " & obj.C2 & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub
End Class
