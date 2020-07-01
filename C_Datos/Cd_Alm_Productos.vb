Imports C_Entidad
Imports Finisar.SQLite
Public Class Cd_Alm_Productos
    Dim objCd_C As New Cd_Con
    Public da As SQLiteDataAdapter
    Public Cn As New SQLiteConnection

    Sub NuevoProducto(ByVal obj As Ce_Alm_Productos)
        'obj.Fecha = CDate(obj.Fecha).ToString("yyyy-MM-dd")
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Insert Into Alm_Productos(ATC,Descripcion,Concentracion,Presentacion,Forma,Unidad,TipoMed,Temperatura,Minimo,Riesgo,TipoProd,Estado,CCostos)Values(@ATC,@Descripcion,@Concentracion,@Presentacion,@Forma,@Unidad,@TipoMed,@Temperatura,@Minimo,@Riesgo,@TipoProd,@Estado,@CCostos)"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@ATC", obj.ATC)
            cmd.Parameters.Add("@Descripcion", obj.Descripcion)
            cmd.Parameters.Add("@Concentracion", obj.Concentracion)
            cmd.Parameters.Add("@Presentacion", obj.Presentacion)
            cmd.Parameters.Add("@Forma", obj.Forma)
            cmd.Parameters.Add("@Unidad", obj.Unidad)
            cmd.Parameters.Add("@TipoMed", obj.TipoMed)
            cmd.Parameters.Add("@Temperatura", obj.Temperatura)
            cmd.Parameters.Add("@Minimo", obj.Minimo)
            cmd.Parameters.Add("@Riesgo", obj.Riesgo)
            cmd.Parameters.Add("@TipoProd", obj.TipoProd)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.Parameters.Add("@CCostos", obj.CCostos)
            cmd.ExecuteNonQuery()
            MsgBox("El Producto se ha registrado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Registro de Producto")
        Catch ex As Exception
            MsgBox("NuevoFuncionario - (Cd_Alm_Productos): " & ex.Message)
        End Try
    End Sub

    Sub ModificarProducto(ByVal obj As Ce_Alm_Productos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Update Alm_Productos Set ATC=@ATC,Descripcion=@Descripcion,Concentracion=@Concentracion,Presentacion=@Presentacion,Forma=@Forma,Unidad=@Unidad,TipoMed=@TipoMed,Temperatura=@Temperatura,Minimo=@Minimo,Riesgo=@Riesgo,TipoProd=@TipoProd,Estado=@Estado,CCostos=@CCostos Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.Parameters.Add("@ATC", obj.ATC)
            cmd.Parameters.Add("@Descripcion", obj.Descripcion)
            cmd.Parameters.Add("@Concentracion", obj.Concentracion)
            cmd.Parameters.Add("@Presentacion", obj.Presentacion)
            cmd.Parameters.Add("@Forma", obj.Forma)
            cmd.Parameters.Add("@Unidad", obj.Unidad)
            cmd.Parameters.Add("@TipoMed", obj.TipoMed)
            cmd.Parameters.Add("@Temperatura", obj.Temperatura)
            cmd.Parameters.Add("@Minimo", obj.Minimo)
            cmd.Parameters.Add("@Riesgo", obj.Riesgo)
            cmd.Parameters.Add("@TipoProd", obj.TipoProd)
            cmd.Parameters.Add("@Estado", obj.Estado)
            cmd.Parameters.Add("@CCostos", obj.CCostos)
            cmd.ExecuteNonQuery()
            MsgBox("El Producto se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Modificar de Producto")
        Catch ex As Exception
            MsgBox("ModificarProducto - (Cd_Alm_Productos): " & ex.Message)
        End Try
    End Sub

    Sub EliminarProducto(ByVal obj As Ce_Alm_Productos)
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim sel As String = "Delete From Alm_Productos Where Cons=@Cons"
            Dim cmd As New Finisar.SQLite.SQLiteCommand(sel, Cn)
            cmd.Parameters.Add("@Cons", obj.Cons)
            cmd.ExecuteNonQuery()
            MsgBox("El Producto se ha eliminado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Eliminar de Producto")
        Catch ex As Exception
            MsgBox("EliminarProducto - (Cd_Alm_Productos): " & ex.Message)
        End Try
    End Sub

    Function LitarTodosProductos() As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Cons As CONS,Tp.Tipo As TIPO_PROD,P.ATC As ATC,P.Descripcion As DESCRIPCION,P.Concentracion As CONCENTRACION,P.Presentacion As PRESENTACION,F.Forma As FORMA_FARMACEUTICA,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,P.Riesgo As RIESGO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoProd Tp On P.TipoProd=Tp.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons Left Join Ccostos Co On P.CCostos=Co.Cons"
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

    Function LitarTipoProductos(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Dim cmd As String = ""
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            If obj.TipoProd = 1 Then
                cmd = "Select P.Cons As CONS,P.ATC As ATC,P.Descripcion As DESCRIPCION,P.Concentracion As CONCENTRACION,P.Presentacion As PRESENTACION,F.Forma As FORMA_FARMACEUTICA,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons  Left Join Ccostos Co On P.CCostos=Co.Cons Where P.TipoProd=1"
            Else
                cmd = "Select P.Cons As CONS,P.Descripcion As DESCRIPCION,P.Presentacion,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,P.Riesgo As RIESGO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoProd Tp On P.TipoProd=Tp.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons  Left Join Ccostos Co On P.CCostos=Co.Cons Where P.TipoProd='" & Val(obj.TipoProd) & "'"
            End If
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

    Function FiltrarTodosProductosDescrip(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Cons As CONS,Tp.Tipo As TIPO_PROD,P.ATC As ATC,P.Descripcion As DESCRIPCION,P.Concentracion As CONCENTRACION,P.Presentacion As PRESENTACION,F.Forma As FORMA_FARMACEUTICA,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,P.Riesgo As RIESGO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoProd Tp On P.TipoProd=Tp.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons Left Join Ccostos Co On P.CCostos=Co.Cons  Where  P.Descripcion Like '%" & obj.Descripcion & "%'"
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

    Function FiltrarTipoProductosDescrip(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Dim cmd As String = ""
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            If obj.TipoProd = 1 Then
                cmd = "Select P.Cons As CONS,P.ATC As ATC,P.Descripcion As DESCRIPCION,P.Concentracion As CONCENTRACION,P.Presentacion As PRESENTACION,F.Forma As FORMA_FARMACEUTICA,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons Left Join Ccostos Co On P.CCostos=Co.Cons Where P.TipoProd=1 And  P.Descripcion Like '%" & obj.Descripcion & "%'"
            Else
                cmd = "Select P.Cons As CONS,P.Descripcion As DESCRIPCION,P.Presentacion,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,P.Riesgo As RIESGO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoProd Tp On P.TipoProd=Tp.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons Left Join Ccostos Co On P.CCostos=Co.Cons Where P.TipoProd='" & Val(obj.TipoProd) & "' And  P.Descripcion Like '%" & obj.Descripcion & "%'"
            End If
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

    Function LitarProductosCons(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select P.Cons As CONS,Tp.Tipo,P.ATC AS ATC,P.Descripcion As DESCRIPCION,P.Concentracion As CONCENTRACION,P.Presentacion As PRESENTACION,F.Forma,P.Unidad As UNIDAD_MEDIDA,P.Temperatura As TEMPERATURA,P.Minimo As MINIMO,P.Riesgo As RIESGO,Tm.Tipo As TIPO,CASE P.Estado WHEN '1' THEN 'ACTIVO' ELSE 'INACTIVO' END ESTADO,Co.CCosto As COSTO From Alm_Productos P Left Join Alm_MedForma F On P.Forma=F.Cons Left Join Alm_TipoProd Tp On P.TipoProd=Tp.Cons Left Join Alm_TipoMed Tm On P.TipoMed=Tm.Cons Left Join Ccostos Co On P.CCostos=Co.Cons Where P.Cons='" & obj.Cons & "'"
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

    Function LitarProductosSimilar(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Descripcion ||' '|| Concentracion || ' ' || Presentacion As PRODUCTO From Alm_Productos Where TipoProd='" & obj.TipoProd & "' And Descripcion Like '%" & obj.Descripcion & "%'"
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

    Function LoadDatosProd(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Atc,Descripcion,Concentracion,Presentacion,Alm_MedForma.Forma,Unidad,Alm_TipoProd.Tipo  From Alm_Productos Left Join Alm_MedForma On Alm_Productos.Forma=Alm_MedForma.Cons Left Join Alm_TipoProd On Alm_Productos.TipoProd=Alm_TipoProd.Cons Where Alm_Productos.Cons='" & obj.Cons & "'"
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

    Function LoadDatosProdMedKardex(ByVal obj As Ce_Alm_Productos) As DataSet
        Dim ds As New DataSet
        Try
            Cn = objCd_C.Conectar
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
            Dim cmd As String = "Select Atc,Descripcion,Concentracion,Presentacion,Alm_MedForma.Forma,Unidad,Alm_TipoMed.Tipo  From Alm_Productos Left Join Alm_MedForma On Alm_Productos.Forma=Alm_MedForma.Cons Left Join Alm_TipoMed On Alm_Productos.TipoMed=Alm_TipoMed.Cons Where Alm_Productos.Cons='" & obj.Cons & "'"
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
