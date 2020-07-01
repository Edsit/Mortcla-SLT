Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Almacenes
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoAlmacen(ByVal obj As Ce_Almacenes)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Almacenes(Sede,Nombre,Responsable,Estado)Values(@Sede,@Nombre,@Responsable,@Estado)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Sede", obj.Sede)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Responsable", obj.Responsable)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El almacén se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Almacén")
        Catch ex As Exception
            MsgBox("NuevoAlmacen - (Cd_Almacenes): " & ex.Message)
        End Try
    End Sub

    Sub ModificarAlmacen(ByVal obj As Ce_Almacenes)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Almacenes Set Nombre=@Nombre,Responsable=@Responsable,Estado=@Estado Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Nombre", obj.Nombre)
            cmd.Parameters.Add("@Responsable", obj.Responsable)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.ExecuteNonQuery()
            MsgBox("El almacén se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Midificar de Almacén")
        Catch ex As Exception
            MsgBox("ModificarAlmacen - (Cd_Almacenes): " & ex.Message)
        End Try
    End Sub

    Sub EliminarAlmacen(ByVal obj As Ce_Almacenes)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Almacenes Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El almacén se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Almacén")
        Catch ex As Exception
            MsgBox("EliminarAlmacen - (Cd_Almacenes): " & ex.Message)
        End Try
    End Sub

    Function ListarAlmacenes() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select A.Cons As CONS,S.Sede As SEDE,A.Nombre As ALMACEN,F.Nombre As RESPONSABLE,CASE A.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO from Almacenes A Left Join Sedes S On A.Sede=S.Cons Left Join Funcionarios F On A.Responsable=F.Cons  Order by A.Sede"
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

    Function ListarAlmacenesActivos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select A.Cons As CONS,S.Sede As SEDE,A.Nombre As ALMACEN,F.Nombre As RESPONSABLE,CASE A.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO from Almacenes A Left Join Sedes S On A.Sede=S.Cons Left Join Funcionarios F On A.Responsable=F.Cons Where A.Estado=1  Order by A.Sede"
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

    Function ListarAlmacenesActivosFunc(ByVal obj As Ce_AlmacenFunc) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select A.Cons,A.Nombre From Almacenes A Left Join AlmacenFunc AF On A.Cons=AF.Almacen Where A.Estado='1' And AF.Func='" & obj.Func & "'"
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

    Function ExisteAlmacene(ByVal obj As Ce_Almacenes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Almacenes Where Nombre='" & UCase(obj.Nombre) & "'"
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

    Function ListarAlmacenesRotacion(ByVal obj As Ce_Almacenes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Cons,Nombre From Almacenes Where Estado=1 And Sede='" & obj.Sede & "' Order By Nombre"
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

    Function VerResponsable(ByVal obj As Ce_Almacenes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select F.Nombre,C.Cargo from almacenes A Left Join Funcionarios F On A.Responsable=F.Cons Left Join Cargos C On F.Cargo=C.Cons Where A.Cons=" & Val(obj.Cons)
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

    Function VerDatosTraslado(ByVal obj As Ce_Almacenes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT S.Sede,F.Nombre,C.Cargo FROM Almacenes A LEFT JOIN Funcionarios F ON A.RESPONSABLE=F.CONS LEFT JOIN Sedes S ON A.SEDE=S.CONS LEFT JOIN Cargos C ON F.CARGO=C.CONS WHERE A.CONS=" & obj.Cons
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

    Function ListarAlmacenesActivosSede(ByVal obj As Ce_Almacenes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select A.Cons As CONS,S.Sede As SEDE,A.Nombre As ALMACEN,F.Nombre As RESPONSABLE,CASE A.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO from Almacenes A Left Join Sedes S On A.Sede=S.Cons Left Join Funcionarios F On A.Responsable=F.Cons Where A.Estado=1 And S.Cons=" & obj.Sede & " Order by A.Sede"
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
