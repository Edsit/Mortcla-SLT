Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_AC
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_AC(ByVal obj As Ce_Rips_AC)
        obj.Fec_Consulta = CDate(obj.Fec_Consulta).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_AC(Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Fec_Consulta,Autorizacion,Cod_Proc,FInalidad,Causa,Dx_Princ,Dx_Rel1,Dx_Rel2,Dx_Rel3,Tipo_Dx_Pric,Val_Consulta,Val_Cuo_Mod,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp)Values(@Num_Fact,@Cod_Prest,@Tipo_Ide_Usu,@Num_Ide_Usu,@Fec_Consulta,@Autorizacion,@Cod_Proc,@FInalidad,@Causa,@Dx_Princ,@Dx_Rel1,@Dx_Rel2,@Dx_Rel3,@Tipo_Dx_Pric,@Val_Consulta,@Val_Cuo_Mod,@Val_Neto,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Num_Fact", obj.Num_Fact)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Tipo_Ide_Usu", obj.Tipo_Ide_Usu)
            cmd.Parameters.Add("@Num_Ide_Usu", obj.Num_Ide_Usu)
            cmd.Parameters.Add("@Fec_Consulta", obj.Fec_Consulta)
            cmd.Parameters.Add("@Autorizacion", obj.Autorizacion)
            cmd.Parameters.Add("@Cod_Proc", obj.Cod_Proc)
            cmd.Parameters.Add("@FInalidad", obj.Finalidad)
            cmd.Parameters.Add("@Causa", obj.Causa)
            cmd.Parameters.Add("@Dx_Princ", obj.Dx_Princ)
            cmd.Parameters.Add("@Dx_Rel1", obj.Dx_Rel1)
            cmd.Parameters.Add("@Dx_Rel2", obj.Dx_Rel2)
            cmd.Parameters.Add("@Dx_Rel3", obj.Dx_Rel3)
            cmd.Parameters.Add("@Tipo_Dx_Pric", obj.Tipo_Dx_Pric)
            cmd.Parameters.Add("@Val_Consulta", obj.Val_Consulta)
            cmd.Parameters.Add("@Val_Cuo_Mod", obj.Val_Cuo_Mod)
            cmd.Parameters.Add("@Val_Neto", obj.Val_Neto)
            cmd.Parameters.Add("@Cod_Año", obj.Cod_Año)
            cmd.Parameters.Add("@Cod_Per", obj.Cod_Per)
            cmd.Parameters.Add("@Cod_Hosp", obj.Cod_Hosp)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub LimpiarAC()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_AC"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_AC() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Fec_Consulta,Autorizacion,Cod_Proc,FInalidad,Causa,Dx_Princ,Dx_Rel1,Dx_Rel2,Dx_Rel3,Tipo_Dx_Pric,Val_Consulta,Val_Cuo_Mod,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp")
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function
End Class
