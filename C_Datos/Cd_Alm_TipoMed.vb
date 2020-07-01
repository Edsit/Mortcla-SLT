Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_TipoMed
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoTipoMed(ByVal obj As Ce_Alm_TipoMed)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_TipoMed(Tipo,Estado)Values(@Tipo,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de medicamento se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Tipo Medicmento")
        Catch ex As Exception
            MsgBox("NuevoTipoMed - (Cd_Alm_TipoMed): " & ex.Message)
        End Try
    End Sub

    Sub ModificarTipoMed(ByVal obj As Ce_Alm_TipoMed)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_TipoMed Set Tipo=@Tipo,Estado=@Estado Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de medicamento se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Tipo Medicamento")
        Catch ex As Exception
            MsgBox("ModificarTipoMed - (Cd_Alm_TipoMed): " & ex.Message)
        End Try
    End Sub

    Sub EliminarTipoMed(ByVal obj As Ce_Alm_TipoMed)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_TipoMed Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de medicamento se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Tipo Medicamento")
        Catch ex As Exception
            MsgBox("EliminarTipoMed - (Cd_Alm_TipoMed): " & ex.Message)
        End Try
    End Sub

    Function ExisteTipoMed(ByVal obj As Ce_Alm_TipoMed) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_TipoMed Where Tipo='" & UCase(obj.Tipo) & "'"
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

    Function ListarTipoMed() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Alm_TipoMed"
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

    Function ListarTipoMedActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO From Alm_TipoMed Where Estado=1 Order by Cons"
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
