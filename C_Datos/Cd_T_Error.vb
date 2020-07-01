Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_T_Error
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoError(ByVal obj As Ce_T_Error)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into T_Error(Tipo,Fila,Col,Detalle)Values(@Tipo,@Fila,@Col,@Detalle)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Fila", obj.Fila)
            cmd.Parameters.Add("@Col", obj.Col)
            cmd.Parameters.Add("@Detalle", obj.Detalle)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    Function ListarErrores() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Tipo,Fila,Col,Detalle From T_Error"
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
