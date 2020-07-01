Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Rips_US
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Rips_US(ByVal obj As Ce_Rips_US)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Rips_US(Tipo_Ide_Usu,Num_Ide_Usu,Cod_Enti,Tipo_Usu,Apellido1,Apellido2,Nombre1,Nombre2,Edad,Uni_Med_Edad,Sexo,Cod_Dep_Res,Cod_Mun_Res,Zona_Res,Cod_Año,Cod_Per,Cod_Hosp)Values(@Tipo_Ide_Usu,@Num_Ide_Usu,@Cod_Enti,@Tipo_Usu,@Apellido1,@Apellido2,@Nombre1,@Nombre2,@Edad,@Uni_Med_Edad,@Sexo,@Cod_Dep_Res,@Cod_Mun_Res,@Zona_Res,@Cod_Año,@Cod_Per,@Cod_Hosp)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tipo_Ide_Usu", obj.Tipo_Ide_Usu)
            cmd.Parameters.Add("@Num_Ide_Usu", obj.Num_Ide_Usu)
            cmd.Parameters.Add("@Cod_Enti", obj.Cod_Enti)
            cmd.Parameters.Add("@Tipo_Usu", obj.Tipo_Usu)
            cmd.Parameters.Add("@Apellido1", obj.Apellido1)
            cmd.Parameters.Add("@Apellido2", obj.Apellido2)
            cmd.Parameters.Add("@Nombre1", obj.Nombre1)
            cmd.Parameters.Add("@Nombre2", obj.Nombre2)
            cmd.Parameters.Add("@Edad", obj.Edad)
            cmd.Parameters.Add("@Uni_Med_Edad", obj.Uni_Med_Edad)
            cmd.Parameters.Add("@Sexo", obj.Sexo)
            cmd.Parameters.Add("@Cod_Dep_Res", obj.Cod_Dep_Res)
            cmd.Parameters.Add("@Cod_Mun_Res", obj.Cod_Mun_Res)
            cmd.Parameters.Add("@Zona_Res", obj.Zona_Res)
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

    Sub LimpiarUS()
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Rips_US"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Rips_US() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("SELECT ID,Tipo_Ide_Usu,Num_Ide_Usu,Cod_Enti,Tipo_Usu,Apellido1,Apellido2,Nombre1,Nombre2,Edad,Uni_Med_Edad,Sexo,Cod_Dep_Res,Cod_Mun_Res,Zona_Res,Cod_Año,Cod_Per,Cod_Hosp From Rips_US")
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
