Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Nacionalidad
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub Nueva_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Insert Into Nacionalidad(Nacionalidad,Estado)Values(@Nacionalidad,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Nacionalidad", obj.Nacionalidad)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La nacionalidad se ha registrado")
        Catch ex As Exception
            MsgBox("Nueva_Nacionalidad (Cd_Nacionalidad): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub

    Sub Modificar_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Update Nacionalidad Set Nacionalidad=(@Nacionalidad,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Nacionalidad", obj.Nacionalidad)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La nacionalidad se ha modificado")
        Catch ex As Exception
            MsgBox("Modificar_Nacionalidad (Cd_Nacionalidad): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub

    Sub Eliminiar_Nacionalidad(ByVal obj As Ce_Nacionalidad)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Delete From Nacionalidad Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La nacionalidad se ha ELIMINADO")
        Catch ex As Exception
            MsgBox("Eliminiar_Nacionalidad (Cd_Nacionalidad): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub

    Function Listar_Nacionalidad() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Nacionalidad As NACIONALIDAD,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Nacionalidad Order By Nacionalidad"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_Nacionalidad (Cd_Nacionalidad): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

    Function Listar_NacionalidadActivas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Nacionalidad From Nacionalidad Order By Nacionalidad"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_NacionalidadActivas (Cd_Nacionalidad): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function
End Class
