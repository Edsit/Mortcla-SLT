Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_MesEstado
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Function LoadMesActivo() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar()
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            da = New SQLiteDataAdapter("Select MesEstado.Mes,Meses.Mes,MesEstado.Año From MesEstado Left Join Meses On MesEstado.Mes=Meses.Cons Where Estado='ACTIVO'", cn)
            da.Fill(ds, "MesEstado")
            Return ds
        Catch ex As Exception
            MsgBox("MesActivo: " & ex.Message)
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Sub EditMesActivo(ByVal obj As Ce_MesEstado)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update MesEstado Set Estado='CERRADO' Where Mes=@Mes And Año=@Año"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.ExecuteNonQuery()
            '   MsgBox("El mes se ha cerrado satisfactoriamente, debe reiniciar el aplicativo para que surjan efecto los cambios", MsgBoxStyle.DefaultButton1 = 0)
        Catch ex As Exception
            MsgBox("EditMesActivo - (Cd_MesEstado): " & ex.Message)
        End Try
    End Sub

    Sub NuevoMesActivo(ByVal obj As Ce_MesEstado)
        Try
            Cn = objCd_C.Conectar
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim sel As String = "Insert Into MesEstado(Mes,Año,Estado)Values(@Mes,@Año,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, cn)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            '  MsgBox("El almacén se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Almacén")
        Catch ex As Exception
            MsgBox("NuevoMesActivo - (Cd_MesEstado): " & ex.Message)
        End Try
    End Sub
End Class
