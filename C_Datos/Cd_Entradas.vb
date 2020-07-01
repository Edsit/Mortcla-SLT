Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Entradas
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevaEntrada(ByVal obj As Ce_Entradas)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Entradas(Cons,Fecha,Proveedor,Pedido,Func,TProd,Almacen,Soporte)Values(@Cons,@Fecha,@Proveedor,@Pedido,@Func,@TProd,@Almacen,@Soporte)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Proveedor", obj.Proveedor)
            cmd.Parameters.Add("@Pedido", obj.Pedido)
            cmd.Parameters.Add("@Func", obj.Func)
            cmd.Parameters.Add("@TProd", obj.TProd)
            cmd.Parameters.Add("@Almacen", obj.Almacen)
            cmd.Parameters.Add("@Soporte", obj.Soporte)
            cmd.ExecuteNonQuery()
            MsgBox("La Entrada se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Entrada")
        Catch ex As Exception
            MsgBox("NuevaEntrada - (Cd_Entradas): " & ex.Message)
        End Try
    End Sub

    Function ListarEntradas() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select E.Cons As CONS,E.Fecha As FECHA,Pr.Nombre As PROVEEDOR,Tp.Tipo As TIPO,F.Nombre As FUNCIONARIOS,A.Nombre As ALMACEN,E.Soporte As SOPORTE,E.Pedido As PEDIDO From Entradas E Left Join Proveedores Pr On E.Proveedor=Pr.Cons Left Join Alm_TipoProd Tp On E.TProd=Tp.Cons Left Join Funcionarios F On E.Func=F.Cons Left Join Almacenes A On E.Almacen=A.Cons"
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

    Function ListarEntradasTipo(ByVal obj As Ce_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select E.Cons As CONS,E.Fecha As FECHA,Pr.Nombre As PROVEEDOR,Tp.Tipo As TIPO,F.Nombre As FUNCIONARIOS,A.Nombre As ALMACEN,E.Soporte As SOPORTE,E.Pedido As PEDIDO From Entradas E Left Join Proveedores Pr On E.Proveedor=Pr.Cons Left Join Alm_TipoProd Tp On E.TProd=Tp.Cons Left Join Funcionarios F On E.Func=F.Cons Left Join Almacenes A On E.Almacen=A.Cons Where E.TProd='" & Val(obj.TProd) & "'"
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

    Function ListarEntradasTodosFecha(obj1 As Ce_RFecha) As DataSet
        Dim ds As New DataSet
        obj1.Desde = CDate(obj1.Desde).ToString("yyyy-MM-dd")
        obj1.Hasta = CDate(obj1.Hasta).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select E.Cons As CONS,E.Fecha As FECHA,Pr.Nombre As PROVEEDOR,Tp.Tipo As TIPO,F.Nombre As FUNCIONARIOS,A.Nombre As ALMACEN,E.Soporte As SOPORTE,E.Pedido As PEDIDO From Entradas E Left Join Proveedores Pr On E.Proveedor=Pr.Cons Left Join Alm_TipoProd Tp On E.TProd=Tp.Cons Left Join Funcionarios F On E.Func=F.Cons Left Join Almacenes A On E.Almacen=A.Cons Where E.Fecha Between '" & obj1.Desde & "' And '" & obj1.Hasta & "'"
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

    Function ListarEntradasTipoFecha(ByVal obj As Ce_Entradas, obj1 As Ce_RFecha) As DataSet
        Dim ds As New DataSet
        obj1.Desde = CDate(obj1.Desde).ToString("yyyy-MM-dd")
        obj1.Hasta = CDate(obj1.Hasta).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select E.Cons As CONS,E.Fecha As FECHA,Pr.Nombre As PROVEEDOR,Tp.Tipo As TIPO,F.Nombre As FUNCIONARIOS,A.Nombre As ALMACEN,E.Soporte As SOPORTE,E.Pedido As PEDIDO From Entradas E Left Join Proveedores Pr On E.Proveedor=Pr.Cons Left Join Alm_TipoProd Tp On E.TProd=Tp.Cons Left Join Funcionarios F On E.Func=F.Cons Left Join Almacenes A On E.Almacen=A.Cons Where (E.TProd='" & Val(obj.TProd) & "') And (E.Fecha Between '" & obj1.Desde & "' And '" & obj1.Hasta & "')"
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

    Function EntradasSedeAdmin(ByVal obj As Ce_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT E.CONS AS CONS,E.FECHA AS FECHA,PR.NOMBRE AS PROVEEDOR,F.Nombre AS FUNCIONARIO,TP.TIPO AS 'TIPO PRODUCTO',E.SOPORTE AS SOPORTE FROM ENTRADAS E LEFT JOIN PROVEEDORES PR ON E.PROVEEDOR=PR.CONS LEFT JOIN FUNCIONARIOS F ON E.FUNC=F.CONS LEFT JOIN ALM_TIPOPROD TP ON E.TPROD=TP.CONS where Almacen=" & obj.Almacen
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
