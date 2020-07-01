Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_AP
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_AP(ByVal obj As Ce_Rips_AP)
        obj.Fec_Proc = CDate(obj.Fec_Proc).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_AP(Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Fec_Proc,Autorizacion,Cod_Proc,Ambito,FInalidad,Personal,Dx_Princ,Dx_Rel,Complic,Forma_QX,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp)Values(@Num_Fact,@Cod_Prest,@Tipo_Ide_Usu,@Num_Ide_Usu,@Fec_Proc,@Autorizacion,@Cod_Proc,@Ambito,@FInalidad,@Personal,@Dx_Princ,@Dx_Rel,@Complic,@Forma_QX,@Val_Neto,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Num_Fact", obj.Num_Fact)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Tipo_Ide_Usu", obj.Tipo_Ide_Usu)
            cmd.Parameters.Add("@Num_Ide_Usu", obj.Num_Ide_Usu)
            cmd.Parameters.Add("@Fec_Proc", obj.Fec_Proc)
            cmd.Parameters.Add("@Autorizacion", obj.Autorizacion)
            cmd.Parameters.Add("@Cod_Proc", obj.Cod_Proc)
            cmd.Parameters.Add("@FInalidad", obj.Finalidad)
            cmd.Parameters.Add("@Ambito", obj.Ambito)
            cmd.Parameters.Add("@Personal", obj.Personal)
            cmd.Parameters.Add("@Dx_Princ", obj.Dx_Princ)
            cmd.Parameters.Add("@Dx_Rel", obj.Dx_Rel1)
            cmd.Parameters.Add("@Complic", obj.Dx_Compl)
            cmd.Parameters.Add("@Forma_QX", obj.FormaQx)
            cmd.Parameters.Add("@Val_Neto", obj.Val_Neto)
            cmd.Parameters.Add("@Cod_Año", obj.Cod_Año)
            cmd.Parameters.Add("@Cod_Per", obj.Cod_Per)
            cmd.Parameters.Add("@Cod_Hosp", obj.Cod_Hosp)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub LimpiarAP()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_AP"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_AP() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Fec_Proc,Autorizacion,Cod_Proc,Ambito,FInalidad,Dx_Princ,Dx_Rel1,Complic,FOrma_Qx,Val_Neto,Cod_Año,Cod_Per,Cod_Hosp From Rips_AP")
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
