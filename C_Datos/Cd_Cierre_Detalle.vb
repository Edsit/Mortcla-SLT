Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Cierre_Detalle
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoCierreDetalle(ByVal obj As Ce_Cierre_Detalle)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Cierre_Detalle(TipoProd,Mes,Año,Estado)Values(@TipoProd,@Mes,@Año,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@TipoProd", obj.TipoProd)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoCierreDetalle - (Cd_Cierre_Detalle): " & ex.Message)
        End Try
    End Sub

    Sub ModifcarCierreDetalle(ByVal obj As Ce_Cierre_Detalle)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Cierre_Detalle Set Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@TipoProd", obj.TipoProd)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoCierreDetalle - (Cd_Cierre_Detalle): " & ex.Message)
        End Try
    End Sub


    Function ListarCierreDetalle(ByVal obj As Ce_Cierre_Detalle) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cd.Cons,Tp.Tipo,cd.mes,cd.año,cd.estado From Cierre_Detalle Cd Left Join Alm_TipoProd Tp On Cd.TipoProd=Tp.Cons where mes=" & obj.Mes & " and año=" & obj.Año
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
