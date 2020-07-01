Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_SedesDir
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoSedeDir(ByVal obj As Ce_SedesDir)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into SedesDir(Sede,Dir,Estado)Values(@Sede,@Dir,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La dirección de la sede se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de dirección de Sede")
        Catch ex As Exception
            MsgBox("NuevoSedeDir - (Cd_SedesDir): " & ex.Message)
        End Try
    End Sub

    Sub ModificarSedeDir(ByVal obj As Ce_SedesDir)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update SedesDir Set Dir=@Dir,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La dirección de la sede se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de dirección de Sede")
        Catch ex As Exception
            MsgBox("ModificarSedeDir - (Cd_SedesDir): " & ex.Message)
        End Try
    End Sub

    Sub EliminarSedeDir(ByVal obj As Ce_SedesDir)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From SedesDir Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La dirección de la sede se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificación de dirección de Sede")
        Catch ex As Exception
            MsgBox("ModificarSedeDir - (Cd_SedesDir): " & ex.Message)
        End Try
    End Sub

    Function ListarSedesDir(ByVal obj As Ce_SedesDir) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,Dir AS DIRECCION,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From SedesDir Where Sede=" & obj.Sede & " Order by Cons")
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

    Function ListarSedesDirActivas(ByVal obj As Ce_SedesDir) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,Dir AS DIRECCION From SedesDir Where Estado=1 And Sede=" & obj.Sede & " Order by Cons")
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

    Function ExisteSedesDir(ByVal obj As Ce_SedesDir) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From SedesDir Where Dir='" & obj.Dir & "' And Sede='" & obj.Sede & "'"
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
