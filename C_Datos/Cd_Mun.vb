Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Mun
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Mun(ByVal obj As Ce_Mun)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Mun(CodDep,Cod,Mun,Estado)Values(@CodDep,@Cod,@Mun,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodDep", obj.CodDep)
            cmd.Parameters.Add("@Cod", obj.Cod)
            cmd.Parameters.Add("@Mun", obj.Mun)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Municipio se ha registrado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Nuevo_Mun (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Editar_Mun(ByVal obj As Ce_Mun)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Mun Set Cod=@Cod,Mun=@Mun,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cod", obj.Cod)
            cmd.Parameters.Add("@Mun", obj.Mun)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Municipio se ha modificado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Editar_Mun (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Eliminar_Mun(ByVal obj As Ce_Mun)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Mun Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El Municipio se ha eliminado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Eliminar_Mun (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Mun(ByVal obj As Ce_Mun) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Cod,Mun,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Mun Where CodDep=@CodDep Order By Mun"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodDep", obj.CodDep)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_Mun (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Function

    Function Listar_Mun_Activos(ByVal obj As Ce_Mun) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Cod || ' - ' || Mun As Mun From Mun Where CodDep=@CodDep And Estado='1' Order By Mun"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CodDep", obj.CodDep)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_Mun_Activos (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

    Function Ver_Mun_Id(ByVal obj As Ce_Mun) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Mun From Mun Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Ver_Mun_Id (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

    Function Ver_Cons_Mun(ByVal obj As Ce_Mun) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons From Mun where Mun=@Mun"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Mun", obj.Mun)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Ver_Cons_Mun (Cd_Mun): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

End Class
