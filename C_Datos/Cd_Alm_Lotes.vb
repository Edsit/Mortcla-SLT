Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Lotes
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoLote(ByVal obj As Ce_Alm_Lotes)
        obj.Vence = CDate(obj.Vence).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Lotes(Prod,Cum,Lab,Lote,Invima,Vence,Ini,Unitario,Serial,VUtil,Obs,Mes,Año,Entrada,Almacen)Values(@Prod,@Cum,@Lab,@Lote,@Invima,@Vence,@Ini,@Unitario,@Serial,@VUtil,@Obs,@Mes,@Año,@Entrada,@Almacen)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Prod", obj.Prod)
            cmd.Parameters.Add("@Cum", obj.Cum)
            cmd.Parameters.Add("@Lab", obj.Lab)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Invima", obj.Invima)
            cmd.Parameters.Add("@Vence", obj.Vence)
            cmd.Parameters.Add("@Ini", obj.Ini)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@Serial", obj.Serial)
            cmd.Parameters.Add("@VUtil", obj.VUtil)
            cmd.Parameters.Add("@Obs", obj.Obs)
            cmd.Parameters.Add("@Mes", obj.Mes)
            cmd.Parameters.Add("@Año", obj.Año)
            cmd.Parameters.Add("@Entrada", obj.Entrada)
            cmd.Parameters.Add("@Almacen", obj.Almacen)
            cmd.ExecuteNonQuery()
            ' MsgBox("El lote se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Lote")
        Catch ex As Exception
            MsgBox("NuevoLote - (Cd_Alm_Lotes): " & ex.Message)
        End Try
    End Sub

    Sub ModificarLote(ByVal obj As Ce_Alm_Lotes)
        obj.Vence = CDate(obj.Vence).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Lotes Set Cum=@Cum,Lab=@Lab,Lote=@Lote,Invima=@Invima,Vence=@Vence,Ini=@Ini,Unitario=@Unitario,Serial=@Serial,VUtil=@VUtil,Obs=@Obs Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cum", obj.Cum)
            cmd.Parameters.Add("@Lab", obj.Lab)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Invima", obj.Invima)
            cmd.Parameters.Add("@Vence", obj.Vence)
            cmd.Parameters.Add("@Ini", obj.Ini)
            cmd.Parameters.Add("@Unitario", obj.Unitario)
            cmd.Parameters.Add("@Serial", obj.Serial)
            cmd.Parameters.Add("@VUtil", obj.VUtil)
            cmd.Parameters.Add("@Obs", obj.Obs)
            cmd.ExecuteNonQuery()
            MsgBox("El lote se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Lote")
        Catch ex As Exception
            MsgBox("ModificarLote - (Cd_Alm_Lotes): " & ex.Message)
        End Try
    End Sub

    Sub ModificarCantIniLote(ByVal obj As Ce_Alm_Lotes)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Lotes Set Ini=@Ini Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Ini", obj.Ini)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox("ModificarLote - (Cd_Alm_Lotes): " & ex.Message)
        End Try
    End Sub

    Sub EliminarLote(ByVal obj As Ce_Alm_Lotes)
        obj.Vence = CDate(obj.Vence).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Lotes(Cum=@Cum,Lab=@Lab,Lote=@Lote,Invima=@Invima,Vence=@Vence,Ini=@Ini,Unitario0@Unitario,Serial=@Serial,VUtil=@VUtil,Obs=@Obs Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El lote se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Lote")
        Catch ex As Exception
            MsgBox("EliminarLote - (Cd_Alm_Lotes): " & ex.Message)
        End Try
    End Sub

    Function ListarLotesProd(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,L.Cum,La.Lab,L.Lote,L.Invima,L.Vence,L.Ini,L.Unitario,L.Serial,L.VUtil,L.Obs From ALm_Lotes L Left Join Laboratorios La On L.Lab=La.Cons Where L.Prod='" & obj.Prod & "' And Mes='" & obj.Mes & "' And Año='" & obj.Año & "' And Almacen='" & obj.Almacen & "'"
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

    Function ExisteLote(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Count(Cons) From Alm_Entradas Where Prod='" & obj.Prod & "' And Mes='" & obj.Mes & "' And Año='" & obj.Año & "'"
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

    Function ListarDatosLotes(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select * From Alm_Lotes Where Cons='" & obj.Cons & "'"
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

    Function ListarLotesMedKardex(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,L.Cum,La.Lab,L.Lote,L.Invima,L.Vence,L.Ini,L.Unitario,L.Ini*L.Unitario As TOTAL,L.Prod,L.Obs From Alm_Lotes L Left Join Laboratorios La On L.Lab=La.Cons Left Join Alm_Productos P On L.Prod=P.Cons Where (P.TipoProd='" & obj1.TipoProd & "') And (L.Mes='" & obj.Mes & "') And (L.Año='" & obj.Año & "') And (L.Almacen='" & obj.Almacen & "') ORDER BY P.TipoMed,P.Descripcion"
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

    Function ListarLotesMQKardex(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,P.Descripcion,P.Unidad,La.Lab,L.Lote,L.Invima,L.Vence,L.VUtil,P.Riesgo,L.Ini,L.Unitario,L.Ini*L.Unitario As TOTAL,L.Serial,L.Obs From Alm_Lotes L Left Join Laboratorios La On L.Lab=La.Cons Left Join Alm_Productos P On L.Prod=P.Cons Where (P.TipoProd='" & obj1.TipoProd & "') And (L.Mes='" & obj.Mes & "') And (L.Año='" & obj.Año & "') And (L.Almacen='" & obj.Almacen & "') ORDER BY P.Descripcion"
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

    Function ListarLotesMedKardexCierre(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,L.Prod,L.Cum,L.Lab,L.lote,L.Invima,L.Vence,L.Ini,L.Unitario,L.Ini*L.Unitario As Total,L.Obs,L.Entrada,L.Almacen From Alm_Lotes L Left Join Laboratorios La On L.Lab=La.Cons Left Join Alm_Productos P On L.Prod=P.Cons Where (P.TipoProd='" & obj1.TipoProd & "') And (L.Mes='" & obj.Mes & "') And (L.Año='" & obj.Año & "')"
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

    Function ListarLotesMQKardexCierre(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,L.Prod,L.Serial,L.Lab,L.Lote,L.Invima,L.Vence,L.VUtil,L.Ini,L.Unitario,L.Ini*L.Unitario,L.Obs,L.Entrada,L.Almacen From Alm_Lotes L Left Join Laboratorios La On L.Lab=La.Cons Left Join Alm_Productos P On L.Prod=P.Cons Where (P.TipoProd !='1') And (L.Mes='" & obj.Mes & "') And (L.Año='" & obj.Año & "')"
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

    Function LoadMedLotesVence(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select L.Cons,P.Descripcion ||' '|| P.Presentacion ||' '|| P.Concentracion,L.Lote,L.Vence,L.Invima,L.Ini,L.Unitario,L.Prod From Alm_Lotes L Left Join Alm_productos P On L.Prod=P.Cons Where (Mes='" & obj.Mes & "') And (Año='" & obj.Año & "')"
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

    Function VerLotesArreglar(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Cons,prod,Cum,Lab,Lote,Invima from alm_lotes Where Mes=" & obj.Mes & " and Año=" & obj.Año
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

    Function VerLotesBuenoArreglar(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select Cons,prod,Cum,Lab,Lote,Invima from alm_lotes Where prod=" & obj.Prod & " and Lote ='" & obj.Lote & "' and mes=3 and año=2020"
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

    Sub ActualziarLoteMalosAbril(ByVal obj As Ce_Alm_Lotes)

        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Lotes Set Cum=@Cum,Lab=@Lab,Lote=@Lote,Invima=@Invima Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@Cum", obj.Cum)
            cmd.Parameters.Add("@Lab", obj.Lab)
            cmd.Parameters.Add("@Lote", obj.Lote)
            cmd.Parameters.Add("@Invima", obj.Invima)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ActualziarLoteMalosAbril - (Cd_Alm_Lotes): " & ex.Message)
        End Try
    End Sub

    Function VerIniLote(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Sum(Ini) From Alm_Lotes Where Cons=" & obj.Cons
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

    Function ValorInicialCentroCostos(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT CC.CONS,CC.CCOSTO,SUM(L.INI*L.Unitario),L.Mes,L.año FROM ALM_LOTES L LEFT JOIN ALM_PRODUCTOS P ON L.Prod=P.Cons LEFT JOIN CCOSTOS CC ON P.CCostos=CC.CONS WHERE L.Año='" & obj.Año & "' AND L.Mes='" & obj.Mes & "'  GROUP BY CC.CONS,CC.CCosto,L.Mes,L.año"
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

    Function ValorEntradasCentroCostos(ByVal obj As Ce_Alm_Entradas, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT SUM(E.CANT*E.Unitario) FROM ALM_ENTRADAS E LEFT JOIN ALM_PRODUCTOS P ON E.Prod=p.CONS WHERE (P.CCostos=" & obj1.CCostos & ") AND (E.MES=" & obj.Mes & ") AND (E.Año=" & obj.Año & ")"
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

    Function ValorSalidasCentroCostos(ByVal obj As Ce_Alm_Salidas, obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT SUM(S.CANT*S.Unitario) FROM ALM_SALIDAS S LEFT JOIN ALM_PRODUCTOS P ON S.Prod=p.CONS WHERE (P.CCostos=" & obj1.CCostos & ") AND (S.MES=" & obj.Mes & ") AND (S.Año=" & obj.Año & ")"
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

    Function SeeLotes(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select L.Cons,L.Cum,La.Lab,L.Lote,L.Invima,L.Vence,L.Ini,L.Unitario,L.Serial,L.VUtil,L.Obs,L.Mes,L.Año,L.Entrada,L.Almacen from alm_lotes L Left Join Laboratorios La On L.Lab=La.Cons  where prod=" & obj.Prod & " order by L.mes,L.año,L.lote,L.cons DESC"
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

    Function SeeLotesRescate(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT * FROM ALM_LOTES WHERE Mes=" & obj.Mes & " AND Año=" & obj.Año & ""
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


    Function SeeLoteAnterior(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "select La.Lab,L.Cum,L.Invima,L.Vence,L.Serial,L.VUtil,L.Obs From alm_lotes L Left Join Laboratorios La On L.Lab=La.Cons where L.prod=" & obj.Prod & " and L.lab=" & obj.Lab & " and L.lote='" & obj.Lote & "'"
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

    Function SeeLoteRescate(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT L.CONS,L.Prod,P.Descripcion,P.Concentracion,L.LAB,L.INI,L.MES,L.AñO,L.Lote FROM ALM_LOTES L LEFT JOIN ALM_PRODUCTOS P ON L.PROD=P.CONS WHERE MES=" & obj.Mes & " AND año=" & obj.Año
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

    Function RescateLoteAnt(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT  CONS,INI FROM ALM_LOTES WHERE MES=" & obj.Mes & " AND AñO=" & obj.Año & " AND LAB=" & obj.Lab & " AND PROD=" & obj.Prod & " AND LOTE='" & obj.Lote & "'"
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


    Function ListarLotesNuevoCierre(ByVal obj As Ce_Alm_Lotes) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT * FROM ALM_LOTES WHERE MES=" & obj.Mes & " AND AñO=" & obj.Año
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

    Function ListarLotesInventMovimientos(ByVal obj As Ce_Alm_Lotes, ByVal obj1 As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "SELECT L.Cons,L.Prod,L.Cum,P.Descripcion,P.Concentracion,L.Lote,L.Ini,L.Unitario,L.ini*L.unitario as Total FROM ALM_LOTES L LEFT JOIN ALM_PRODUCTOS P ON L.PROD=P.CONS WHERE MES=" & obj.Mes & " AND AñO=" & obj.Año & " And Almacen=" & obj.Almacen & " And P.TipoProd=" & obj1.TipoProd & " Group By L.Prod,L.cons"
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
