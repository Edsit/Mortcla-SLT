Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Eps
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoEps(ByVal obj As Ce_Eps)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into EPS(Nit,Codigo,Nombre,Dir,Tel,Estado)Values(@Nit,@Codigo,@Nombre,@Dir,@Tel,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Nit", obj.Nit)
            cmd.Parameters.Add("@Codigo", obj.Codigo)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NuevoEps - (Cd_Eps): " & ex.Message)
        End Try
    End Sub

    Sub ModificarEps(ByVal obj As Ce_Eps)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update EPS Set Nit=@Nit,Codigo=@Codigo,Nombre=@Nombre,Dir=@Dir,Tel=@Tel,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Nit", obj.Nit)
            cmd.Parameters.Add("@Codigo", obj.Codigo)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificarEps - (Cd_Eps): " & ex.Message)
        End Try
    End Sub

    Sub EliminarEps(ByVal obj As Ce_Eps)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From EPS Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("EliminarEps - (Cd_Eps): " & ex.Message)
        End Try
    End Sub

    Function ListarEps() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons as CONS,Nit as NIT,Codigo as CODIGO,Nombre as NOMBRE,Dir as DIR,Tel as TEL,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO  From Eps Order By Nombre"
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

    Function ListarEpsActivas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons as CONS,Codigo || ' - ' || Nombre As EPS From Eps Where Estado=1 Order By Eps"
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
