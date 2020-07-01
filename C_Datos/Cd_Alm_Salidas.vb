Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Salidas
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoSalida(ByVal obj As Ce_Alm_Salidas)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Salidas(Fecha,Mes,Año,Prod,Lote,Cant,Unitario,TProd,TipoSalida,Destino,Almacen,Area,Traslado)Values(@Fecha,@Mes,@Año,@Prod,@Lote,@Cant,@Unitario,@TProd,@TipoSalida,@Destino,@Almacen,@Area,@Traslado)"
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
            cmd.Parameters.Add("@Area", obj.Area)
            cmd.Parameters.Add("@Traslado", obj.Traslado)
            cmd.ExecuteNonQuery()
            MsgBox("La salida se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Salida")
        Catch ex As Exception
            MsgBox("NuevoSalida - (Cd_Alm_Salidas): " & ex.Message)
        End Try
    End Sub

    Sub AjustarSalida(ByVal obj As Ce_Alm_Salidas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Salidas Set Cant=@Cant,Unitario=@Unitario Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.ExecuteNonQuery()
            MsgBox("La salida se ha ajustado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Ajustar de Salida")
        Catch ex As Exception
            MsgBox("AjustarSalida - (Cd_Alm_Salidas): " & ex.Message)
        End Try
    End Sub

    Sub EliminarSalida(ByVal obj As Ce_Alm_Salidas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_Salidas Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La salida se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Salida")
        Catch ex As Exception
            MsgBox("EliminarSalida - (Cd_Alm_Salidas): " & ex.Message)
        End Try
    End Sub

    Function ListarSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select sum(cant)as Cant,unitario From Alm_Salidas Where Lote='" & obj.Lote & "'"
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


    Function EgresosMesActivo(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Prod,Lote,SUM(Cant),Unitario from Alm_Salidas Where (Mes='" & obj.Mes & "') And (Año='" & obj.Año & "') And (TProd='" & obj.TProd & "') group by Lote,Prod,Unitario"
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

    Function EgresosFecha(ByVal obj As Ce_Alm_Salidas, obj1 As Ce_RFecha) As DataSet
        obj1.Desde = CDate(obj1.Desde).ToString("yyyy-MM-dd")
        obj1.Hasta = CDate(obj1.Hasta).ToString("yyyy-MM-dd")
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Prod,Lote,SUM(Cant),Unitario from Alm_Salidas Where (TProd='" & obj.TProd & "')And (Fecha Between '" & obj1.Desde & "' And '" & obj1.Hasta & "') group by Lote,Prod,Unitario"
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

    Function ContarSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Sum(Cant) from alm_Salidas where (lote=" & obj.Lote & ") And (mes=" & obj.Mes & ") And (Año=" & obj.Año & ")"
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

    Function LsitarSalidasAjustes(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select S.Cons,S.Fecha,L.Cons,L.Lote,S.Cant,S.Unitario From Alm_Salidas S Left Join Alm_Lotes L On S.Lote=L.Cons Where (S.Mes=" & obj.Mes & ") And (S.Año=" & obj.Año & ")And (S.TProd=" & obj.TProd & ") And(S.prod=" & obj.Prod & ")And (S.Almacen=" & obj.Almacen & ") Order By S.Fecha"
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

    Function VerSumaSalidas(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Sum(Cant) From Alm_Salidas Where Lote=" & obj.Lote
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

    Function SalidasRescate(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT CANT FROM ALM_SALIDAS Where Lote=" & obj.Lote & " and Mes=" & obj.Mes & " And Año=" & obj.Año
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

    Function EgresosPorTipoSalida(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select S.Prod,S.Lote,SUM(S.Cant),S.Unitario from Alm_Salidas S Where (S.Mes='" & obj.Mes & "') And (S.Año='" & obj.Año & "') And (S.TProd='" & obj.TProd & "') And (S.TipoSalida=" & obj.TipoSalida & ") group by S.Lote,S.Prod,S.Unitario"
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

    Function EgresosPorArea(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select S.Prod,S.Lote,SUM(S.Cant),S.Unitario,ts.Tipo from Alm_Salidas S Left Join Alm_TipoSalidas Ts On s.TipoSalida =Ts.cons Where (S.Mes='" & obj.Mes & "') And (S.Año='" & obj.Año & "') And (S.TProd='" & obj.TProd & "') And (S.Area=" & obj.Area & ") group by S.Lote,S.Prod,S.Unitario,Ts.Tipo"
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

    Function ListarSalidasTraslaodo(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT P.CONS,P.Descripcion,P.Concentracion,P.Presentacion,L.Cum,L.Lab AS CONSLAB,LA.Lab,L.Lote,L.Invima,L.VENCE,S.Cant,S.UNITARIO,L.Serial,L.VUtil,L.OBS FROM ALM_SALIDAS S LEFT JOIN ALM_LOTES L ON S.LOTE=L.CONS LEFT JOIN ALM_PRODUCTOS P ON L.PROD=P.CONS LEFT JOIN LABORATORIOS LA ON L.LAB=LA.CONS WHERE S.TRASLADO=" & obj.Traslado
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

    Function ListarSalidasNuevoCierre(ByVal obj As Ce_Alm_Salidas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT * FROM ALM_SALIDAS WHERE LOTE=" & obj.Lote
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
