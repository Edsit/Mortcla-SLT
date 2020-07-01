Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Entradas
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoEntrada(ByVal obj As Ce_Alm_Entradas)
        obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Entradas(Fecha,Mes,Año,Prod,Lote,Cant,Unitario,TProd,Entrada,Almacen,Aprovechamiento)Values(@Fecha,@Mes,@Año,@Prod,@Lote,@Cant,@Unitario,@TProd,@Entrada,@Almacen,@Aprovechamiento)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Fecha", obj.Fecha)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Prod", obj.Prod)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@TProd", obj.TProd)
            cmd.Parameters.Add("@Entrada", obj.Entrada)
            cmd.Parameters.Add("@Almacen", obj.Almacen)
            cmd.Parameters.Add("@Aprovechamiento", obj.Aprovechamiento)
            cmd.ExecuteNonQuery()
            MsgBox("La entrada se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Entrada")
        Catch ex As Exception
            MsgBox("NuevoEntrada - (Cd_Alm_Entradas): " & ex.Message)
        End Try
    End Sub

    Sub AjustarEntrada(ByVal obj As Ce_Alm_Entradas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Entradas Set Cant=@Cant,Unitario=@Unitario Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cant", obj.Cant)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.ExecuteNonQuery()
            MsgBox("La entrada se ha ajustado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Ajsute de Entrada")
        Catch ex As Exception
            MsgBox("AjustarEntrada - (Cd_Alm_Entradas): " & ex.Message)
        End Try
    End Sub

    Sub EliminarEntrada(ByVal obj As Ce_Alm_Entradas)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_Entradas Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("La entrada se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Entrada")
        Catch ex As Exception
            MsgBox("EliminarEntrada - (Cd_Alm_Entradas): " & ex.Message)
        End Try
    End Sub

    Function ListarEntradas(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select sum(cant)as Cant,unitario,cons,fecha From Alm_Entradas Where Lote=" & obj.Lote
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

    Function ListarEntradasCons(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Descripcion As DESCRIPCION,P.Presentacion As PRESENTACION,P.Concentracion As CONCENTRACION,La.Lab As LABORATORIO,L.Invima As INVIMA,L.Lote As LOTE,L.Vence As VENCIMIENTO,P.Temperatura As TEMPERATURA,sum(E.Cant) As CANTIDAD,E.Unitario As UNITARIO From Alm_Entradas E Left Join Alm_Productos P On E.Prod=P.Cons Left Join Alm_Lotes L On E.Lote=L.Cons Left Join Laboratorios La on L.Lab=La.Cons WHERE E.Entrada='" & obj.Entrada & "' Group By P.Descripcion,P.Presentacion,P.Concentracion,La.Lab,L.Invima,L.Lote,L.Vence,P.Temperatura"
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

    Function ContarEntradas(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Sum(Cant) from alm_entradas where (lote=" & obj.Lote & ") And (mes=" & obj.Mes & ") And (Año=" & obj.Año & ")"
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

    Function LsitarEntradasAjustes(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select E.Cons As CONS,E.Fecha As FECHA,L.Cons As 'CONS LOTE',L.Lote As LOTE,E.Entrada As ENTRADA,E.Cant As CANTIDAD,E.Unitario As UNITARIO From Alm_Entradas E Left Join Alm_Lotes L On E.Lote=L.Cons Where (E.Mes=" & obj.Mes & ") And (E.Año=" & obj.Año & ")And (E.TProd=" & obj.TProd & ") And(E.prod=" & obj.Prod & ")And (E.Almacen=" & obj.Almacen & ") Order By E.Fecha"
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

    Function VerSumEntradasLote(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Sum(Cant) From Alm_Entradas Where Lote=" & obj.Lote
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

    Function EntradasRescate(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT CANT FROM ALM_ENTRADAS Where Lote=" & obj.Lote & " and Mes=" & obj.Mes & " And Año=" & obj.Año
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

    Function ListarEntradaNuevoCierre(ByVal obj As Ce_Alm_Entradas) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT * FROM ALM_ENTRADAS WHERE LOTE=" & obj.Lote
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
