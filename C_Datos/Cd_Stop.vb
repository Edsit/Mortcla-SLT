Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Stop
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoSalidaStop(ByVal obj As Ce_Alm_Stop)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Stop(Fecha,Mes,Año,Prod,Lote,Cant,Unitario,TProd,TipoSalida,Destino,Almacen,stop)Values(@Fecha,@Mes,@Año,@Prod,@Lote,@Cant,@Unitario,@TProd,@TipoSalida,@Destino,@Almacen,@stop)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Prod", obj.Prod)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@TProd", obj.TProd)
            cmd.Parameters.Add("@TipoSalida", obj.TipoSalida)
            cmd.Parameters.Add("@Destino", obj.Destino)
            cmd.Parameters.Add("@Almacen", obj.Almacen)
            cmd.Parameters.Add("@stop", obj.Stop1)
            cmd.ExecuteNonQuery()
            MsgBox("La salida al stop se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Salida a Stop")
        Catch ex As Exception
            MsgBox("NuevoSalidaStop - (Cd_Stop): " & ex.Message)
        End Try
    End Sub
End Class
