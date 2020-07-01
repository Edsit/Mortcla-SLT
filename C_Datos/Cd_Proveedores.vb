Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Proveedores
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoProveedor(ByVal obj As Ce_Proveedores)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Proveedores(Tdoc,Doc,Nombre,Dir,Tel,Estado)Values(@Tdoc,@Doc,@Nombre,@Dir,@Tel,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Proveedor se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Proveedor")
        Catch ex As Exception
            MsgBox("NuevoProveedor - (Cd_Proveedores): " & ex.Message)
        End Try
    End Sub

    Sub ModificarProveedor(ByVal obj As Ce_Proveedores)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Proveedores Set Tdoc=@Tdoc,Doc=@Doc,Nombre=@Nombre,Dir=@Dir,Tel=@Tel,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Tdoc", obj.Tdoc)
            cmd.Parameters.Add("@Doc", obj.Doc)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Dir", obj.Dir)
            cmd.Parameters.Add("@Tel", obj.Tel)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El Proveedor se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificacion de Proveedor")
        Catch ex As Exception
            MsgBox("NuevoProveedor - (Cd_Proveedores): " & ex.Message)
        End Try
    End Sub

    Sub EliminarProveedor(ByVal obj As Ce_Proveedores)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Proveedores Set Tdoc=@Tdoc,Doc=@Doc,Nombre=@Nombre,Dir=@Dir,Tel=@Tel,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El Proveedor se ha elimino satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminación de Proveedor")
        Catch ex As Exception
            MsgBox("EliminarProveedor - (Cd_Proveedores): " & ex.Message)
        End Try
    End Sub

    Function ListarProveedores() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Cons As CONS,Td.Tipo As TDOC,P.Doc As DOCUMENTO,P.Nombre As NOMBRE,P.Dir As DIRECCION,P.Tel As TELEFONO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Proveedores P Left Join Tdoc Td On P.Tdoc=Td.Cons"
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

    Function ListarProveedoresActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Cons As CONS,Td.Tipo As TDOC,P.Doc As DOCUMENTO,P.Nombre As NOMBRE,P.Dir As DIRECCION,P.Tel As TELEFONO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO From Proveedores P Left Join Tdoc Td On P.Tdoc=Td.Cons"
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

    Function ExisteProveedores(ByVal obj As Ce_Proveedores) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Proveedores Where Doc='" & UCase(obj.Doc) & "' OR Nombre='" & obj.Nombre & "'"
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
