Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_MedForma
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoMedForma(ByVal obj As Ce_Alm_MedForma)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_MedForma(Forma,Estado)Values(@Forma,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Forma", obj.Forma)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La forma se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Forma Medicamento")
        Catch ex As Exception
            MsgBox("NuevoMedForma - (Cd_Alm_MedForma): " & ex.Message)
        End Try
    End Sub

    Sub ModificarMedForma(ByVal obj As Ce_Alm_MedForma)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_MedForma Set Forma=@Forma,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Forma", obj.Forma)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La forma se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar Forma Medicamento")
        Catch ex As Exception
            MsgBox("ModificarMedForma - (Cd_Alm_MedForma): " & ex.Message)
        End Try
    End Sub

    Sub EliminarMedForma(ByVal obj As Ce_Alm_MedForma)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_MedForma Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La forma se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar Forma Medicamento")
        Catch ex As Exception
            MsgBox("EliminarMedForma - (Cd_Alm_MedForma): " & ex.Message)
        End Try
    End Sub

    Function ExisteMedForma(ByVal obj As Ce_Alm_MedForma) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_MedForma Where Forma='" & UCase(obj.Forma) & "'"
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

    Function ListarMedForma() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Forma As FORMA,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Alm_MedForma Order by Forma"
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

    Function ListarMedFormaActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Forma As FORMA From Alm_MedForma Order by Forma"
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
