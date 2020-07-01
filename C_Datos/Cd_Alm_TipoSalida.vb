Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_TipoSalida
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoTipoSalida(ByVal obj As Ce_Alm_TipoSalida)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_TipoSalidas(Tipo,Estado)Values(@Tipo,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de salida se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Tipo Salida")
        Catch ex As Exception
            MsgBox("NuevoTipoSalida - (Cd_Alm_TipoSalida): " & ex.Message)
        End Try
    End Sub

    Sub ModificarTipoSaida(ByVal obj As Ce_Alm_TipoSalida)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_TipoSalidas Set Tipo=@Tipo,Estado=@Estado Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de salida se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Tipo Salida")
        Catch ex As Exception
            MsgBox("ModificarTipoSaida - (Cd_Alm_TipoSalida): " & ex.Message)
        End Try
    End Sub

    Sub EliminarTipoSalida(ByVal obj As Ce_Alm_TipoSalida)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_TipoSalidas Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de salida se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Tipo Salida")
        Catch ex As Exception
            MsgBox("EliminarTipoSalida - (Cd_Alm_TipoSalida): " & ex.Message)
        End Try
    End Sub

    Function ExisteTipoSalida(ByVal obj As Ce_Alm_TipoSalida) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_TipoSalidas Where Tipo='" & UCase(obj.Tipo) & "'"
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

    Function ListarTipoSalida() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Alm_TipoSalidas"
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

    Function ListarTipoSalidaActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO From Alm_TipoSalidas Where Estado=1 Order by Cons"
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
