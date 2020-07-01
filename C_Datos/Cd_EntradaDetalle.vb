Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_EntradaDetalle
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoEntradaDetalle(ByVal obj As Ce_EntradasDetalle)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into EntradaDetalle(Fecha,Mes,Año,Prod,Lote,Cant,Unitario,TProd,Entrada)Values(@Fecha,@Mes,@Año,@Prod,@Lote,@Cant,@Unitario,@TProd,@Entrada)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Prod", obj.Prod)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@TProd", obj.TProd)
            cmd.Parameters.Add("@Entrada", obj.Entrada)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoEntradaDetalle - (Cd_EntradaDetalle): " & ex.Message)
        End Try
    End Sub
End Class
