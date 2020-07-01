Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Cargos
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NUevoCargo(ByVal obj As Ce_Cargos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Cargos(Cargo,Asistencial,Estado)Values(@Cargo,@Asistencial,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cargo", obj.Cargo)
            cmd.Parameters.Add("@Asistencial", obj.Asistencial)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El cargo se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Cargo")
        Catch ex As Exception
            MsgBox("NUevoCargo - (Cd_Cargos): " & ex.Message)
        End Try
    End Sub

    Sub ModificarCargo(ByVal obj As Ce_Cargos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Upadate Cargos Set Cargo=@Cargo,Asistencial=@Asistencial,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cargo", obj.Cargo)
            cmd.Parameters.Add("@Asistencial", obj.Asistencial)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El cargo se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar Cargo")
        Catch ex As Exception
            MsgBox("ModificarCargo - (Cd_Cargos): " & ex.Message)
        End Try
    End Sub

    Sub EliminarCargo(ByVal obj As Ce_Cargos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Cargos Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El cargo se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar Cargo")
        Catch ex As Exception
            MsgBox("EliminarCargo - (Cd_Cargos): " & ex.Message)
        End Try
    End Sub

    Function ListarCargos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Cargo,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Cargos Order by Cargo"
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

    Function ListarCargosActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Cargo From Cargos Where Estado=1"
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
