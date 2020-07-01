Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_CCosto
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoCCostos(ByVal obj As Ce_CCostos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into CCostos(CCosto,Estado)Values(@CCosto,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@CCosto", obj.CCosto)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El centro de costos se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Centro de Costos")
        Catch ex As Exception
            MsgBox("NuevoCCosto - (CCosto): " & ex.Message)
        End Try
    End Sub

    Sub ModificarCCosto(ByVal obj As Ce_CCostos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update CCostos Set CCosto=@CCosto,Estado=@Estado Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@CCosto", obj.CCosto)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El centro de costo se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Centro de Costos")
        Catch ex As Exception
            MsgBox("ModificarCCosto - (CCosto): " & ex.Message)
        End Try
    End Sub

    Sub EliminarCCosto(ByVal obj As Ce_CCostos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From CCostos Where COns=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El centro de costo se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar Centro de Costo")
        Catch ex As Exception
            MsgBox("EliminarCCosto - (CCosto): " & ex.Message)
        End Try
    End Sub

    Function ExisteTipoProd(ByVal obj As Ce_CCostos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From CCostos Where Tipo='" & UCase(obj.CCosto) & "'"
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

    Function ListarCCosto() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,CCosto As CCOSTO,CASE Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From CCostos"
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

    Function ListarCCostoActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons As CONS,CCosto As CCOSTO From CCostos Where Estado=1 Order by Cons"
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
