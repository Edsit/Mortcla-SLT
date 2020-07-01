Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Laboratorios
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoLab(ByVal obj As Ce_Alm_Laboratorios)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Laboratorios(Lab,Estado)Values(@Lab,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Lab", obj.Lab)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Laboratorio se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Laboratorio")
        Catch ex As Exception
            MsgBox("NuevoLab - (Cd_Alm_Laboratorios): " & ex.Message)
        End Try
    End Sub

    Sub ModificarLab(ByVal obj As Ce_Alm_Laboratorios)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Laboratorios Set Lab=@Lab,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Lab", obj.Lab)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Laboratorio se ha modificar satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Laboratorio")
        Catch ex As Exception
            MsgBox("ModificarLab - (Cd_Alm_Laboratorios): " & ex.Message)
        End Try
    End Sub

    Sub EliminarLab(ByVal obj As Ce_Alm_Laboratorios)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Laboratorios Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El Laboratorio se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Laboratorio")
        Catch ex As Exception
            MsgBox("EliminarLab - (Cd_Alm_Laboratorios): " & ex.Message)
        End Try
    End Sub

    Function ListarLab() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS, Lab As LABORATORIO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Laboratorios ORDER BY Lab"
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

    Function ListarLabActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS, Lab As LABORATORIO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Laboratorios Where Estado='1'  ORDER BY Lab"
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

    Function ExisteLab(ByVal obj As Ce_Alm_Laboratorios) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Laboratorios Where Lab='" & obj.Lab & "'"
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
