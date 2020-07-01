Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_AT
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_AT(ByVal obj As Ce_Rips_AT)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_AT(Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Autorizacion,Tipo_Serv,Cod_Serv,Nom_Serv,Cant,Val_Unit,Val_Total,Cod_Año,Cod_Per,Cod_Hosp)Values(@Num_Fact,@Cod_Prest,@Tipo_Ide_Usu,@Num_Ide_Usu,@Autorizacion,@Tipo_Serv,@Cod_Serv,@Nom_Serv,@Cant,@Val_Unit,@Val_Total,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Num_Fact", obj.Num_Fact)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Tipo_Ide_Usu", obj.Tipo_Ide_Usu)
            cmd.Parameters.Add("@Autorizacion", obj.Autorizacion)
            cmd.Parameters.Add("@Tipo_Serv", obj.TipoServ)
            cmd.Parameters.Add("@Cod_Serv", obj.CodServ)
            cmd.Parameters.Add("@Nom_Serv", obj.NomServ)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Val_Unit", obj.ValUnit)
            cmd.Parameters.Add("@Val_Total", obj.ValTotal)
            cmd.Parameters.Add("@Cod_Año", obj.Cod_Año)
            cmd.Parameters.Add("@Cod_Per", obj.Cod_Per)
            cmd.Parameters.Add("@Cod_Hosp", obj.Cod_Hosp)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub LimpiarAT()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_AT"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_AT() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Autorizacion,Tipo_Serv,Cod_Serv,Nom_Serv,Cant,Val_Unit,Val_Total,Cod_Año,Cod_Per,Cod_Hosp From Rips_AT")
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
