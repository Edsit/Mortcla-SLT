Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Tdoc
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Function ListarTdocActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Tipo || ' - ' || Detalle as Tipo From Tdoc Where Estado=1"
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
