Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_TipoProd
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoTipoProd(ByVal obj As Ce_Alm_TipoProd)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_TipoProd(Tipo,Estado)Values(@Tipo,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de producto se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Tipo Producto")
        Catch ex As Exception
            MsgBox("NuevoTipoProd - (Cd_Alm_TipoProd): " & ex.Message)
        End Try
    End Sub

    Sub ModificarTipoProd(ByVal obj As Ce_Alm_TipoProd)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_TipoProd Set Tipo=@Tipo,Estado=@Estado Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tipo", obj.Tipo)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de producto se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Tipo Producto")
        Catch ex As Exception
            MsgBox("ModificarTipoProd - (Cd_Alm_TipoProd): " & ex.Message)
        End Try
    End Sub

    Sub EliminarTipoProd(ByVal obj As Ce_Alm_TipoProd)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_TipoProd Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El tipo de producto se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Tipo Producto")
        Catch ex As Exception
            MsgBox("EliminarTipoProd - (Cd_Alm_TipoProd): " & ex.Message)
        End Try
    End Sub

    Function ExisteTipoProd(ByVal obj As Ce_Alm_TipoProd) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_TipoProd Where Tipo='" & UCase(obj.Tipo) & "'"
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

    Function ListarTipoProd() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Alm_TipoProd"
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

    Function ListarTipoProdActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,Tipo As TIPO From Alm_TipoProd Where Estado=1 Order by Cons"
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
