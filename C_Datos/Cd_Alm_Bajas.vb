Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Bajas
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoBaja(ByVal obj As Ce_Alm_Baja)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Baja(Fecha,Lote,Cant,Unitario,Mes,Año)Values(@Fecha,@Lote,@Cant,@Unitario,@Mes,@Año)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoBaja - (Cd_Alm_Bajas): " & ex.Message)
        End Try
    End Sub

    Function GenerarActadeBaja(ByVal obj As Ce_Alm_Baja, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Descripcion || ' ' || P.Presentacion ||' '|| P.Concentracion,L.Lote,L.Vence,L.Invima,B.Cant,B.Unitario From Baja B Left Join Alm_Lotes L On B.Lote=L.Cons Left Join Alm_Productos P On L.Prod=P.Cons Where (B.Mes='" & obj.Mes & "') And (B.Año='" & obj.Año & "') And P.TipoProd='" & obj1.TipoProd & "'"
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
