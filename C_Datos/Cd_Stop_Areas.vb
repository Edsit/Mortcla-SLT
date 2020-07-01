Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Stop_Areas
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoStop_Area(ByVal obj As Ce_Alm_Stop_Areas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Stop_Areas(stop,Estado)Values(@stop,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@stop", obj.Stop1)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El stop se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Stop")
        Catch ex As Exception
            MsgBox("NuevoStop_Area - (Cd_Stop_Areas): " & ex.Message)
        End Try
    End Sub

    Sub ModificarStop_Area(ByVal obj As Ce_Alm_Stop_Areas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Stop_Areas Set stop=@stop,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@stop", obj.Stop1)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El stop se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de Stop")
        Catch ex As Exception
            MsgBox("ModificarStop_Area - (Cd_Stop_Areas): " & ex.Message)
        End Try
    End Sub

    Function ExisteStop_Area(ByVal obj As Ce_Alm_Stop_Areas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_Stop_Areas Where Stop='" & UCase(obj.Stop1) & "'"
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

    Function ListarStopAreas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Stop As STOP,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Alm_Stop_Areas"
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

    Function ListarStopAreasActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Stop As STOP From Alm_Stop_Areas Where Estado=1"
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
