Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Consecutivos
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub ActualizarConFunc(ByVal obj As Ce_Consecutivos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Consecutivos Set Funcionarios=@Func"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Func", obj.Func)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ActualizarConFunc - (Cd_Consecutivos): " & ex.Message)
        End Try
    End Sub

    Sub ActualizarConEntradas(ByVal obj As Ce_Consecutivos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Consecutivos Set Entradas=@Entradas"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Entradas", obj.Entradas)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ActualizarConEntradas - (Cd_Consecutivos): " & ex.Message)
        End Try
    End Sub

    Sub ActualizarConSalidas(ByVal obj As Ce_Consecutivos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Consecutivos Set Salidas=@Salidas"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Salidas", obj.Salidas)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ActualizarConSalidas - (Cd_Consecutivos): " & ex.Message)
        End Try
    End Sub

    Sub ActualizarConTraslados(ByVal obj As Ce_Consecutivos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Consecutivos Set Traslados=@Traslados"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Traslados", obj.Traslados)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ActualizarConTraslados - (Cd_Consecutivos): " & ex.Message)
        End Try
    End Sub


    Function VerConsFunc() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Funcionarios From Consecutivos"
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

    Function VerConsEntradas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Entradas From Consecutivos"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function VerConsSalidas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Salidas From Consecutivos"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Function VerConsTraslados() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Traslados From Consecutivos"
            da = New SQLiteDataAdapter(cmd, Cn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
        Finally
            ds.Dispose()
            da.Dispose()
        End Try
    End Function
End Class
