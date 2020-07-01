Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Semaforo
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub ModificarSemaforo(ByVal obj As Ce_Alm_Semaforo)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Semaforo(Rojo,Amarillo)Values(@Rojo,@Amarillo)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Rojo", obj.Rojo)
            cmd.Parameters.Add("@Amarillo", obj.Amarillo)
            cmd.ExecuteNonQuery()
            MsgBox("El semaforo se ha actualizado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Semaforo")
        Catch ex As Exception
            MsgBox("ModificarSemaforo - (Cd_Alm_Semaforo): " & ex.Message)
        End Try
    End Sub

    Function ListarSemaforo() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Rojo,Amarillo From Alm_Semaforo"
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
