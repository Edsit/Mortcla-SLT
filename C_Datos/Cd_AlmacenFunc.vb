Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_AlmacenFunc
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoAlmacenFunc(ByVal obj As Ce_AlmacenFunc)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into AlmacenFunc(Almacen,Func,Estado)Values(@Almacen,@Func,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Almacen", obj.Almacen)
            cmd.Parameters.Add("@Func", obj.Func)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El almacen ha sido autorizado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Autorizacion de Almacén")
        Catch ex As Exception
            MsgBox("NuevoAlmacenFunc - (Cd_AlmacenFunc): " & ex.Message)
        End Try
    End Sub

    Sub EditarAlmacenFunc(ByVal obj As Ce_AlmacenFunc)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update AlmacenFunc Set Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("La autorización ha sido modificada", MsgBoxStyle.DefaultButton1 = 0, "Autorizacion de Almacén")
        Catch ex As Exception
            MsgBox("EditarAlmacenFunc - (Cd_AlmacenFunc): " & ex.Message)
        End Try
    End Sub

    Function ListarFuncionariosAlmacen(ByVal obj As Ce_AlmacenFunc) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select AF.Cons As CONS,F.Nombre AS FUNCIONARIO,CASE AF.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From AlmacenFunc AF Left Join Funcionarios F On AF.Func=F.Cons Where AF.Almacen='" & obj.Almacen & "'"
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
