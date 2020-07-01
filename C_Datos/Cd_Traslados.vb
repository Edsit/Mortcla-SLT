Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Traslados
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoTraslado(ByVal obj As Ce_Traslados)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Traslados(Cons,Fecha,Alm_Origen,Alm_Destino,Obs,TipoProd,Estado)Values(@Cons,@Fecha,@Alm_Origen,@Alm_Destino,@Obs,@TipoProd,'REGISTRADO')"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Alm_Origen", obj.Alm_Origen)
            cmd.Parameters.Add("@Alm_Destino", obj.Alm_Destino)
            cmd.Parameters.Add("@Obs", obj.Obs)
            cmd.Parameters.Add("@TipoProd", obj.TipoProd)
            cmd.ExecuteNonQuery()
            MsgBox("El traslado se ha registrado satisfactoriamente, ahora ingrese los productos a trasladar", MsgBoxStyle.DefaultButton1 = 0, "Registro de Traslado")
        Catch ex As Exception
            MsgBox("NuevoTraslado - (Cd_Traslados): " & ex.Message)
        End Try
    End Sub

    Function ListarTraslaodos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT T.CONS AS CONS,T.FECHA AS FECHA,A.Nombre AS ORIGEN,AL.Nombre AS DESTINO,TP.Tipo AS TIPO,T.OBS AS ONSERVACION,T.ESTADO AS ESTADO FROM TRASLADOS T LEFT JOIN ALMACENES A ON T.ALM_ORIGEN=A.CONS LEFT JOIN ALMACENES AL ON T.ALM_DESTINO=AL.CONS LEFT JOIN ALM_TIPOPROD TP ON T.TIPOPROD=TP.CONS ORDER BY FECHA"
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

    Function ListarTraslaodosTProd(ByVal obj As Ce_Traslados) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT T.CONS AS CONS,T.FECHA AS FECHA,A.Nombre AS ORIGEN,AL.Nombre AS DESTINO,TP.Tipo AS TIPO,T.OBS AS ONSERVACION,T.ESTADO AS ESTADO FROM TRASLADOS T LEFT JOIN ALMACENES A ON T.ALM_ORIGEN=A.CONS LEFT JOIN ALMACENES AL ON T.ALM_DESTINO=AL.CONS LEFT JOIN ALM_TIPOPROD TP ON T.TIPOPROD=TP.CONS WHERE TP.CONS=" & obj.TipoProd & " ORDER BY FECHA"
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
