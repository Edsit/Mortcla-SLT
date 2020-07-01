Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmActaBaja
    Dim objCe_B As New Ce_Alm_Baja
    Dim objCn_B As New Cn_Alm_Bajas
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_P As New Ce_Alm_Productos

    Private Sub ListarTipoProd()
        Dim ds As New DataSet
        CbTProd.DataSource = Nothing
        CbTProd.Items.Clear()
        Try
            ds = objCn_Tp.ListarTipoProdActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTProd.DataSource = ds.Tables(0)
                CbTProd.DisplayMember = "Tipo"
                CbTProd.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Sub LoadConsMes()
        If CbMes.Text.Trim = "ENERO" Then
            TbConsMes.Text = "01"
        ElseIf CbMes.Text.Trim = "FEBRERO" Then
            TbConsMes.Text = "02"
        ElseIf CbMes.Text.Trim = "MARZO" Then
            TbConsMes.Text = "03"
        ElseIf CbMes.Text.Trim = "ABRIL" Then
            TbConsMes.Text = "04"
        ElseIf CbMes.Text.Trim = "MAYO" Then
            TbConsMes.Text = "05"
        ElseIf CbMes.Text.Trim = "JUNIO" Then
            TbConsMes.Text = "06"
        ElseIf CbMes.Text.Trim = "JULIO" Then
            TbConsMes.Text = "07"
        ElseIf CbMes.Text.Trim = "AGOSTO" Then
            TbConsMes.Text = "08"
        ElseIf CbMes.Text.Trim = "SEPTIEMBRE" Then
            TbConsMes.Text = "09"
        ElseIf CbMes.Text.Trim = "OCTUBRE" Then
            TbConsMes.Text = "10"
        ElseIf CbMes.Text.Trim = "NOVIEMBRE" Then
            TbConsMes.Text = "11"
        ElseIf CbMes.Text.Trim = "DICIEMBRE" Then
            TbConsMes.Text = "12"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmActaBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTipoProd()
    End Sub

    Private Sub CbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMes.SelectedIndexChanged
        LoadConsMes()
    End Sub

    Private Sub CbMes_Click(sender As Object, e As EventArgs) Handles CbMes.Click
        LoadConsMes()
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        If Val(TbConsMes.Text) < 1 Then
            MsgBox("Debe escoger un mes valido", MsgBoxStyle.Critical)
            CbMes.Focus()
            Exit Sub
        End If
        If Val(TbAño.Text) < 2018 Then
            MsgBox("Debe ingresar un año valido", MsgBoxStyle.Critical)
            TbAño.Focus()
            Exit Sub
        End If
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        Try
            objCe_B.Mes = Val(TbConsMes.Text)
            objCe_B.Año = Val(TbAño.Text)
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_B.GenerarActadeBaja(objCe_B, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = i + 1
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(3, i).Value = Format(ds.Tables(0).Rows(i).Item(2), "MMM/yyyy")
                    Dgv.Item(4, i).Value = ds.Tables(0).Rows(i).Item(3)
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv.Item(6, i).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(5))
                    Dgv.Item(7, i).Value = Val(Dgv.Item(5, i).Value) * CDbl(Dgv.Item(6, i).Value)
                    Dgv.Item(7, i).Value = FormatCurrency(Dgv.Item(7, i).Value)
                    i = i + 1
                Loop Until i = c
            End If
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim c = Dgv.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\ActadeBaja.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("formato")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 12
                Dim Tot As Double = 0
                Do

                    .Cells(f, 1) = Dgv.Item(0, i).Value
                    .Cells(f, 2) = Dgv.Item(1, i).Value
                    .Cells(f, 3) = Dgv.Item(2, i).Value
                    .Cells(f, 4) = Dgv.Item(3, i).Value
                    .Cells(f, 5) = Dgv.Item(4, i).Value
                    .Cells(f, 6) = Dgv.Item(5, i).Value
                    .Cells(f, 7) = CDbl(Dgv.Item(6, i).Value)
                    .Cells(f, 8) = CDbl(Dgv.Item(7, i).Value)
                    Tot = Tot + CDbl(Dgv.Item(5, i).Value) * CDbl(Dgv.Item(6, i).Value)
                    f = f + 1
                    i = i + 1
                Loop Until i = c

                .Range(.Cells(f, 1), .Cells(f, 7)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 1) = "TOTAL"
                .Cells(f, 8) = Tot

                f = f + 1
                .Cells(f, 2) = "FIRMA RESPONSABLE BAJA"
                .Range(.Cells(f, 1), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 1) = "NOMBRE: " '& AuxFarmacia
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                .Cells(f, 1) = "PROCESO/SUBPROCESO:"
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                f = f + 1
                .Cells(f, 1) = "CEDULA: " '& DocAuxFarmacia
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                .Cells(f, 1) = "FECHA: "
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                f = f + 1
                .Cells(f, 1) = "FIRMA:"
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False


                .Cells(f, 1) = "HORA:"
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False
                m_Excel.Rows(f).RowHeight = 40

                f = f + 1
                .Cells(f, 1) = "FIRMA APROBACION BAJA"
                .Range(.Cells(f, 1), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 1) = "NOMBRE: " '& Director
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False


                .Cells(f, 1) = "PROCESO/SUBPROCESO:"
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                f = f + 1
                .Cells(f, 1) = "FIRMA:"
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False


                .Cells(f, 1) = "CC:"
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False
                m_Excel.Rows(f).RowHeight = 40



                f = f + 1
                .Cells(f, 1) = "REVISADO REGENTE DE FARMACIA"
                .Range(.Cells(f, 1), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 1) = "NOMBRE: " ' & Regente
                .Range(.Cells(f, 1), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False


                .Cells(f, 1) = "FIRMA:"
                .Range(.Cells(f, 5), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = False

                .Range(.Cells(12, 1), .Cells(f, 8)).Borders.LineStyle = 1

                .Range("A7").Value = "FECHA: " & Now.Date
                .Range("D7").Value = "Municipio: " ' & Mun
                .Range("A8").Value = "SEDE: " & FrmModulos.LbSede.Text

            End With
        End If
    End Sub
End Class