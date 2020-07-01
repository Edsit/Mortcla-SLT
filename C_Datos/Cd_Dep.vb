Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Dep
    Dim objCd_C As New Cd_Con
    Dim da As SQLiteDataAdapter
    Dim Cn As New SQLiteConnection

    Sub Nuevo_Dep(ByVal obj As Ce_Dep)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Insert Into Dep(Cod,Dep,Estado)Values(@Cod,@Dep,@Estado)"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cod", obj.Cod)
            cmd.Parameters.Add("@Dep", obj.Dep)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El departamento se ha registrado")
        Catch ex As Exception
            MsgBox("Nuevo_Dep (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Editar_Dep(ByVal obj As Ce_Dep)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Update Dep Set Cod=@Cod,Dep=@Dep,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cod", obj.Cod)
            cmd.Parameters.Add("@Dep", obj.Dep)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El departamento se ha actualizado")
        Catch ex As Exception
            MsgBox("Editar_Dep (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Sub Eliminar_Dep(ByVal obj As Ce_Dep)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

            Dim sel As String = "Delete From Dep Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El departamento se ha eliminado")
        Catch ex As Exception
            MsgBox("Eliminar_Dep (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Sub

    Function Listar_Dep() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons As CONS,Cod As CODIGO,Dep As DEPARTAMENTO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Dep Order By Dep"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_Dep (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

    Function Listar_Dep_Activos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Cons,Cod || ' - ' || Dep As Dep From Dep Where Estado='1' Order By Dep"
            Dim cmd As New SQLiteCommand(sel, Cn)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Listar_Dep_Activos (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function

    Function Ver_Dep_Id(ByVal obj As Ce_Dep) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Select Dep From Dep Where Cons=@Cons"
            Dim cmd As New SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            da = New SQLiteDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("Ver_Dep_Id (Cd_Dep): " & ex.Message)
        Finally
            da.Dispose()
            Cn.Dispose()
            Cn.Close()
        End Try
    End Function
End Class
