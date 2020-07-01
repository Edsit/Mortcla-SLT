Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_AM
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_AM(ByVal obj As Ce_Rips_AM)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_AM(Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Autorizacion,Cod_Med,Tipo_Med,Nom_Gen,Forma,Concent,Unidad,Num_Dosis,Val_Unit,Val_Total,Cod_Año,Cod_Per,Cod_Hosp)Values(@Num_Fact,@Cod_Prest,@Tipo_Ide_Usu,@Num_Ide_Usu,@Autorizacion,@Cod_Med,@Tipo_Med,@Nom_Gen,@Forma,@Concent,@Unidad,@Num_Dosis,@Val_Unit,@Val_Total,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Num_Fact", obj.Num_Fact)
            cmd.Parameters.Add("@Cod_Prest", obj.Cod_Prest)
            cmd.Parameters.Add("@Tipo_Ide_Usu", obj.Tipo_Ide_Usu)
            cmd.Parameters.Add("@Num_Ide_Usu", obj.Num_Ide_Usu)
            cmd.Parameters.Add("@Autorizacion", obj.Autorizacion)
            cmd.Parameters.Add("@Cod_Med", obj.Cod_Med)
            cmd.Parameters.Add("@Tipo_Med", obj.Tipo_Med)
            cmd.Parameters.Add("@Nom_Gen", obj.Nom_Gen)
            cmd.Parameters.Add("@Forma", obj.Forma)
            cmd.Parameters.Add("@Concent", obj.Concent)
            cmd.Parameters.Add("@Unidad", obj.Unidad)
            cmd.Parameters.Add("@Num_Dosis", obj.Num_Dosis)
            cmd.Parameters.Add("@Val_Unit", obj.Val_Unit)
            cmd.Parameters.Add("@Val_Total", obj.Val_Total)
            cmd.Parameters.Add("@Cod_Año", obj.Cod_Año)
            cmd.Parameters.Add("@Cod_Per", obj.Cod_Per)
            cmd.Parameters.Add("@Cod_Hosp", obj.Cod_Hosp)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Nuevo_Rips_AM: " & ex.Message)
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub LimpiarAM()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_AM"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_AM() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Num_Fact,Cod_Prest,Tipo_Ide_Usu,Num_Ide_Usu,Autorizacion,Cod_Med,Tipo_Med,Nom_Gen,Forma,Concent,Unidad,Num_Dosis,Val_Unit,Val_Total,Cod_Año,Cod_Per,Cod_Hosp From Rips_AM")
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
