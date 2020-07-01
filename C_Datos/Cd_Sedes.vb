Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Sedes
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoSede(ByVal obj As Ce_Sedes)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Sedes(UsaPrefijo,Prefijo,Sede,CodHabilitacion,Nit,Estado)Values(@UsaPrefijo,@Prefijo,@Sede,@CodHabilitacion,@Nit,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@UsaPrefijo", obj.UsaPrefijo)
            cmd.Parameters.Add("@Prefijo", obj.Prefijo)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@CodHabilitacion", obj.CodHabilitacion)
            cmd.Parameters.Add("@Nit", obj.Nit)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La Sede se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Nueva Sede")
        Catch ex As Exception
            MsgBox("NuevoSede - (Cd_Sedes): " & ex.Message)
        End Try
    End Sub

    Sub ModificarSede(ByVal obj As Ce_Sedes)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Sedes Set UsaPrefijo=@UsaPrefijo,Prefijo=@Prefijo,Sede=@Sede,CodHabilitacion=@CodHabilitacion,Nit=@Nit,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@UsaPrefijo", obj.UsaPrefijo)
            cmd.Parameters.Add("@Prefijo", obj.Prefijo)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@CodHabilitacion", obj.CodHabilitacion)
            cmd.Parameters.Add("@Nit", obj.Nit)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La Sede se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar Sede")
        Catch ex As Exception
            MsgBox("ModificarSede - (Cd_Sedes): " & ex.Message)
        Finally
        End Try
    End Sub

    Sub EliminarSede(ByVal obj As Ce_Sedes)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Sedes Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La Sede se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar Sede")
        Catch ex As Exception
            MsgBox("EliminarSede - (Cd_Sedes): " & ex.Message)
        Finally
        End Try
    End Sub

    Function ListarSedes() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,UsaPrefijo AS USA_PREFIJO,Prefijo AS PREFIJO,Sede AS SEDE,CodHabilitacion AS COD_HABILITACION,Nit AS NIT,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Sel As SEL From Sedes Order By Cons")
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

    Function ListarSedesActivas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = String.Format("Select Cons AS CONS,Sede AS SEDE From Sedes Where Estado='1' Order By Cons")
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

    Function ExisteSede(ByVal obj As Ce_Sedes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Sedes Where Prefijo='" & obj.Prefijo & "' OR Sede='" & obj.Sede & "'"
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

    Sub SedeSelNO()
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Sedes Set Sel='NO'"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SedeSelNO - (Cd_Sedes): " & ex.Message)
        Finally
        End Try
    End Sub

    Sub SedeSelSI(ByVal obj As Ce_Sedes)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Sedes Set Sel='SI' Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La Sede se ha Selecionado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0)
        Catch ex As Exception
            MsgBox("SedeSelSI - (Cd_Sedes): " & ex.Message)
        Finally
        End Try
    End Sub

    Function ListarSedesRotacion() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Sede From Sedes Where Sel='NO' And Estado='1'"
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
