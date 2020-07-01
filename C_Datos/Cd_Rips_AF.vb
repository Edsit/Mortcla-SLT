Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_AF
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_AF(ByVal obj As Ce_Rips_AF)
        obj.Fec_Fact = CDate(obj.Fec_Fact).ToString("yyyy-MM-dd")
        obj.Fec_Ini_Per = CDate(obj.Fec_Ini_Per).ToString("yyyy-MM-dd")
        obj.Fec_Fin_Per = CDate(obj.Fec_Fin_Per).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_AF(Cod_Prest,Raz_Prest,Tipo_Ide_Prest,Num_Ide_prest,Num_Fact,Fec_Fact,Fec_Ini_Per,Fec_Fin_Per,Cod_Enti,Nom_Enti,Num_Contra,Pla_Benef,Num_Poliza,Val_Copago,Val_Comision,Val_Desc,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp)Values(@Cod_Prest,@Raz_Prest,@Tipo_Ide_Prest,@Num_Ide_prest,@Num_Fact,@Fec_Fact,@Fec_Ini_Per,@Fec_Fin_Per,@Cod_Enti,@Nom_Enti,@Num_Contra,@Pla_Benef,@Num_Poliza,@Val_Copago,@Val_Comision,@Val_Desc,@Val_Neto,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Raz_Prest", obj.Raz_Prest)
            cmd.Parameters.Add("@Tipo_Ide_Prest", obj.Tipo_Ide_Prest)
            cmd.Parameters.Add("@Num_Ide_prest", obj.Num_Ide_prest)
            cmd.Parameters.Add("@Num_Fact", obj.Num_Fact)
            cmd.Parameters.Add("@Fec_Fact", obj.Fec_Fact)
            cmd.Parameters.Add("@Fec_Ini_Per", obj.Fec_Ini_Per)
            cmd.Parameters.Add("@Fec_Fin_Per", obj.Fec_Fin_Per)
            cmd.Parameters.Add("@Cod_Enti", obj.Cod_Enti)
            cmd.Parameters.Add("@Nom_Enti", obj.Nom_Enti)
            cmd.Parameters.Add("@Num_Contra", obj.Num_Contra)
            cmd.Parameters.Add("@Pla_Benef", obj.Pla_Benef)
            cmd.Parameters.Add("@Num_Poliza", obj.Num_Poliza)
            cmd.Parameters.Add("@Val_Copago", obj.Val_Copago)
            cmd.Parameters.Add("@Val_Comision", obj.Val_Comision)
            cmd.Parameters.Add("@Val_Desc", obj.Val_Desc)
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

    Sub LimpiarAF()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_AF"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_AF() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Cod_Prest,Raz_Prest,Tipo_Ide_Prest,Num_Ide_prest,Num_Fact,Fec_Fact,Fec_Ini_Per,Fec_Fin_Per,Cod_Enti,Nom_Enti,Num_Contra,Pla_Benef,Num_Poliza,Val_Copago,Val_Comision,Val_Desc,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp FROM Rips_CT")
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
