Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_EditLotes
    Dim objCn_La As New Cn_Alm_Laboratorio
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub Frm_Alm_EditLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarLaboratoriosActivos()
        TbCons.Text = Frm_Alm_Entradas.TbCons.Text
        TbAtc.Text = Frm_Alm_Entradas.TbAtc.Text
        TbDescripcion.Text = Frm_Alm_Entradas.TbDescripcion.Text
        TbConcentracion.Text = Frm_Alm_Entradas.TbConcentracion.Text
        TbPresentacion.Text = Frm_Alm_Entradas.TbPresentacion.Text
        TbForma.Text = Frm_Alm_Entradas.TbForma.Text
        TbUnidad.Text = Frm_Alm_Entradas.TbUnidad.Text
        TbTipo.Text = Frm_Alm_Entradas.TbTipo.Text
        LbMes.Text = Val(Frm_Alm_Entradas.TbConsMes.Text.Trim)
        LbAño.Text = Val(Frm_Alm_Entradas.TbAño.Text)
        CbLab.Text = Laborat.Text.Trim
    End Sub
    Private Sub ListarLaboratoriosActivos()
        Dim ds As New DataSet
        CbLab.DataSource = Nothing
        CbLab.Items.Clear()
        Try
            ds = objCn_La.ListarLabActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbLab.DataSource = ds.Tables(0)
                CbLab.DisplayMember = "LABORATORIO"
                CbLab.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnLab_Click(sender As Object, e As EventArgs) Handles BtnLab.Click
        Frm_Alm_Laboratorios.ShowDialog()
        ListarLaboratoriosActivos()
    End Sub

    Private Sub BtnCrearLote_Click(sender As Object, e As EventArgs) Handles BtnCrearLote.Click
        If Val(CbLab.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un laboratorio valido", MsgBoxStyle.Critical)
            CbLab.Focus()
            Exit Sub
        End If
        If UCase(TbLote.Text.Trim) = "" Then
            MsgBox("Debe indicar el lote del producto", MsgBoxStyle.Critical)
            TbLote.Focus()
            Exit Sub
        End If
        If UCase(TbInvima.Text.Trim) = "" Then
            MsgBox("Debe indicar el Reg. Invima del producto", MsgBoxStyle.Critical)
            TbInvima.Focus()
            Exit Sub
        End If
        If UCase(TbCUM.Text.Trim) = "" Then
            MsgBox("Debe indicar el CUM del producto", MsgBoxStyle.Critical)
            TbCUM.Focus()
            Exit Sub
        End If
        If Trim(TbVence.Text) = "/" Then
            MsgBox("Debe indicar la fecha de vencimiento del producto", MsgBoxStyle.Critical)
            TbVence.Focus()
            Exit Sub
        End If
        If Trim(TbSerial.Text.Trim) = "" Then
            MsgBox("Debe indicar el serial del producto", MsgBoxStyle.Critical)
            TbSerial.Focus()
            Exit Sub
        End If
        If Trim(TbUtil.Text.Trim) = "" Then
            MsgBox("Debe indicar la vida util del producto", MsgBoxStyle.Critical)
            TbUtil.Focus()
            Exit Sub
        End If
        If Val(TbCant.Text.Trim) = 0 Then
            If MsgBox("¿Confirma que desea modificar el lote en cantidad cero (0)?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                TbCant.Focus()
                Exit Sub
            End If
        End If
        If Val(TbUnitario.Text.Trim) = 0 Then
            If MsgBox("¿Confirma que desea modificar el lote en valor unitario cero (0)?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                TbUnitario.Focus()
                Exit Sub
            End If
        End If
        If MsgBox("¿Confirma que desea modificar el lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_L.Cons = Val(LbCons.Text.Trim)
                objCe_L.Prod = Val(TbCons.Text.Trim)
                objCe_L.Lab = Val(CbLab.SelectedValue.ToString)
                objCe_L.Lote = UCase(TbLote.Text.Trim)
                objCe_L.Invima = UCase(TbInvima.Text.Trim)
                objCe_L.Cum = UCase(TbCUM.Text.Trim)
                objCe_L.Vence = CDate("01/" & TbVence.Text.Trim)
                objCe_L.Serial = UCase(TbSerial.Text.Trim)
                objCe_L.VUtil = UCase(TbUtil.Text.Trim)
                objCe_L.Ini = Val(TbCant.Text.Trim)
                objCe_L.Unitario = Val(TbUnitario.Text.Trim)
                objCe_L.Mes = Val(LbMes.Text.Trim)
                objCe_L.Año = Val(LbAño.Text.Trim)
                objCe_L.Obs = UCase(TbObs.Text.Trim)
                objCn_L.ModificarLote(objCe_L)
                MsgBox("El lote se ha modificado satisfactoriamente", MsgBoxStyle.DefaultButton1 = 0, "Editar Lote")
                Me.Dispose()
                Me.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class