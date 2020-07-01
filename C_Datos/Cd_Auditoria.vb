Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Auditoria
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoAuditoria(ByVal obj As Ce_Auditoria)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Auditoria(Fecha,Hora,Accion,Usuario)Values(@Fecha,@Hora,@Accion,@Usuario)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Hora", obj.Hora)
            cmd.Parameters.Add("@Accion", obj.Accion)
            cmd.Parameters.Add("@Usuario", obj.Usuario)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoAuditoria - (Cd_Auditoria): " & ex.Message)
        End Try
    End Sub
End Class
