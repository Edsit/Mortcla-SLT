Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_CT
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_CT(ByVal obj As Ce_Rips_CT)
        obj.Fec_Remi = CDate(obj.Fec_Remi).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_CT(Cod_Prest,Fec_Remi,Cod_Arch,Tot_Regis)Values(@Cod_Prest,@Fec_Remi,@Cod_Arch,@Tot_Regis)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Fec_Remi", obj.Fec_Remi)
            cmd.Parameters.Add("@Cod_Arch", obj.Cod_Arch)
            cmd.Parameters.Add("@Tot_Regis", obj.Tot_Regis)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub LimpiarCT()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_CT"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_CT() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,COD_PREST,FEC_REMI,COD_ARCH,TOT_REGIS FROM Rips_CT")
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

    Function Listar_Est_Gen_CT() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Id as CONS,Cod_Arch As ARCHIVO,Tot_Regis As REGISTRO From Rips_CT")
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
