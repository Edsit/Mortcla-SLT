Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_SedesTel
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoSedeTel(ByVal obj As Ce_SedesTel)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into SedesTel(Sede,Tel,Estado)Values(@Sede,@Tel,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El teléfono de la sede se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Teléfono de Sede")
        Catch ex As Exception
            MsgBox("NuevoSedeTel - (Cd_SedesTel): " & ex.Message)
        End Try
    End Sub

    Sub ModificarSedeTel(ByVal obj As Ce_SedesTel)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update SedesTel Set Tel=@Tel,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Teléfono de la sede se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de Teléfono de Sede")
        Catch ex As Exception
            MsgBox("ModificarSedeTel - (Cd_SedesTel): " & ex.Message)
        End Try
    End Sub

    Sub EliminarSedeTel(ByVal obj As Ce_SedesTel)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From SedesTel Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El teléfono de la sede se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de teléfono de Sede")
        Catch ex As Exception
            MsgBox("EliminarSedeTel - (Cd_SedesTel): " & ex.Message)
        End Try
    End Sub

    Function ListarSedesTel(ByVal obj As Ce_SedesTel) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,Tel AS TELEFONO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From SedesTel Where Sede=" & obj.Sede & " Order by Cons")
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

    Function ListarSedesTelActivas(ByVal obj As Ce_SedesTel) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,Tel AS TELEFONO From SedesTel Where Estado=1 And Sede=" & obj.Sede & " Order by Cons")
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

    Function ExisteSedesTel(ByVal obj As Ce_SedesTel) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From SedesTel Where Tel='" & obj.Tel & "' And Sede='" & obj.Sede & "'"
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
