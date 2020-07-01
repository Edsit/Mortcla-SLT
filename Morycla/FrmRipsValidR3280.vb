Imports System.IO
Imports C_Entidad
Imports C_Negocio

Public Class FrmRipsValidR3280
    Dim Ruta As String = ""
    Dim Ruta1 As String
    Dim objCe_RCt As New Ce_Rips_CT
    Dim objCe_RAf As New Ce_Rips_AF
    Dim objCe_RAc As New Ce_Rips_AC
    Dim objCe_RAp As New Ce_Rips_AP
    Dim objCe_RAt As New Ce_Rips_AT
    Dim objCe_RAm As New Ce_Rips_AM
    Dim objCe_RUs As New Ce_Rips_US

    Dim objCn_RCt As New Cn_Rips_CT
    Dim objCn_RAf As New Cn_Rips_AF
    Dim objCn_RAc As New Cn_Rips_AC
    Dim objCn_RAp As New Cn_Rips_AP
    Dim objCn_RAt As New Cn_Rips_AT
    Dim objCn_RAm As New Cn_Rips_AM
    Dim objCn_RUs As New Cn_Rips_US

    Private Sub LeerRipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerRipsToolStripMenuItem.Click
        Dim ds As New DataSet
        Dim Archivo As String = ""
        objCn_RCt.LimpiarCT()
        objCn_RAf.LimpiarAF()
        objCn_RAc.LimpiarAC()
        objCn_RAp.LimpiarAP()
        'objCn_RAt.LimpiarAT()
        objCn_RAm.LimpiarAM()
        objCn_RUs.LimpiarUS()
        LeerCT()
        If Ruta <> "" Then
            ds = objCn_RCt.Listar_Rips_CT
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Ruta1 = Ruta & "\" & ds.Tables(0).Rows(i).Item(3) & ".txt"
                    Archivo = Mid(ds.Tables(0).Rows(i).Item(3), 1, 2)
                    Select Case Archivo
                        Case "AF"
                            LeerAF()
                        Case "AC"
                            LeerAC()
                        Case "AP"
                            LeerAP()
                        Case "AT"
                            LeerAT()
                        Case "AM"
                            LeerAM()
                        Case "US"
                            LeerUS()
                    End Select
                    i = i + 1
                Loop Until i = c
            End If
        End If
        MsgBox("Proceso Terminado", MsgBoxStyle.Information)
        My.Application.DoEvents()
        Listar_Est_Gen_CT()
    End Sub

    Sub LeerCT()
        On Error Resume Next
        Dim S0, S1, S2, S3
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        objOpen.ShowDialog()
        If (objOpen.FileName <> "") Then
            Ruta = IO.Path.GetDirectoryName(objOpen.FileName)
            Dim objReader As New StreamReader(objOpen.FileName)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                objCe_RCt.Cod_Prest = S0
                objCe_RCt.Fec_Remi = S1
                objCe_RCt.Cod_Arch = S2
                objCe_RCt.Tot_Regis = S3
                objCn_RCt.Nuevo_Rips_CT(objCe_RCt)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerAF()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = "" : S14 = "" : S15 = "" : S16 = "" : S17 = "" : S18 = "" : S19 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = div(11)
                S12 = div(12)
                S13 = div(13)
                S14 = div(14)
                S15 = div(15)
                S16 = div(16)
                S17 = div(17)
                S18 = div(18)
                S19 = div(19)
                objCe_RAf.Cod_Prest = S0
                objCe_RAf.Raz_Prest = S1
                objCe_RAf.Tipo_Ide_Prest = S2
                objCe_RAf.Num_Ide_prest = S3
                objCe_RAf.Num_Fact = S4
                objCe_RAf.Fec_Fact = S5
                objCe_RAf.Fec_Ini_Per = S6
                objCe_RAf.Fec_Fin_Per = S7
                objCe_RAf.Cod_Enti = S8
                objCe_RAf.Nom_Enti = S9
                objCe_RAf.Num_Contra = S10
                objCe_RAf.Pla_Benef = S11
                objCe_RAf.Num_Poliza = S12
                objCe_RAf.Val_Copago = S13
                objCe_RAf.Val_Comision = S14
                objCe_RAf.Val_Desc = S15
                objCe_RAf.Val_Neto = S16
                objCe_RAf.Cod_Año = S17
                objCe_RAf.Cod_Per = S18
                objCe_RAf.Cod_Hosp = S19
                objCn_RAf.Nuevo_Rips_AF(objCe_RAf)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerAC()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = "" : S14 = "" : S15 = "" : S16 = "" : S17 = "" : S18 = "" : S19 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = div(11)
                S12 = div(12)
                S13 = div(13)
                S14 = div(14)
                S15 = div(15)
                S16 = div(16)
                S17 = div(17)
                S18 = div(18)
                S19 = div(19)
                objCe_RAc.Num_Fact = S0
                objCe_RAc.Cod_Prest = S1
                objCe_RAc.Tipo_Ide_Usu = S2
                objCe_RAc.Num_Ide_Usu = S3
                objCe_RAc.Fec_Consulta = S4
                objCe_RAc.Autorizacion = S5
                objCe_RAc.Cod_Proc = S6
                objCe_RAc.Finalidad = S7
                objCe_RAc.Causa = S8
                objCe_RAc.Dx_Princ = S9
                objCe_RAc.Dx_Rel1 = S10
                objCe_RAc.Dx_Rel2 = S11
                objCe_RAc.Dx_Rel3 = S12
                objCe_RAc.Tipo_Dx_Pric = S13
                objCe_RAc.Val_Consulta = S14
                objCe_RAc.Val_Cuo_Mod = S15
                objCe_RAc.Val_Neto = S16
                objCe_RAc.Cod_Año = S17
                objCe_RAc.Cod_Per = S18
                objCe_RAc.Cod_Hosp = S19
                objCn_RAc.Nuevo_Rips_AC(objCe_RAc)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerAP()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = "" : S14 = "" : S15 = "" : S16 = "" : S17 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = div(11)
                S12 = div(12)
                S13 = div(13)
                S14 = div(14)
                S15 = Now.Year
                S16 = Now.Month
                S17 = "1"
                objCe_RAp.Num_Fact = S0
                objCe_RAp.Cod_Prest = S1
                objCe_RAp.Tipo_Ide_Usu = S2
                objCe_RAp.Num_Ide_Usu = S3
                objCe_RAp.Fec_Proc = S4
                objCe_RAp.Autorizacion = S5
                objCe_RAp.Cod_Proc = S6
                objCe_RAp.Ambito = S7
                objCe_RAp.Finalidad = S8
                objCe_RAp.Personal = S9
                objCe_RAp.Dx_Princ = S10
                objCe_RAp.Dx_Rel1 = S11
                objCe_RAp.Dx_Compl = S12
                objCe_RAp.FormaQx = S13
                objCe_RAp.Val_Neto = S14
                objCe_RAp.Cod_Año = S15
                objCe_RAp.Cod_Per = S16
                objCe_RAp.Cod_Hosp = S17
                objCn_RAp.Nuevo_Rips_AP(objCe_RAp)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerAT()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = Now.Year
                S12 = Now.Month
                S13 = 1

                objCe_RAt.Num_Fact = S0
                objCe_RAt.Cod_Prest = S1
                objCe_RAt.Tipo_Ide_Usu = S2
                objCe_RAt.Num_Ide_Usu = S3
                objCe_RAt.Autorizacion = S4
                objCe_RAt.TipoServ = S5
                objCe_RAt.CodServ = S6
                objCe_RAt.NomServ = S7
                objCe_RAt.Cant = S8
                objCe_RAt.ValUnit = S9
                objCe_RAt.ValTotal = S10
                objCe_RAt.Cod_Año = S11
                objCe_RAt.Cod_Per = S12
                objCe_RAt.Cod_Hosp = S13
                'objCn_RAt.Nuevo_Rips_AT(objCe_RAt)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerAM()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = "" : S14 = "" : S15 = "" : S16 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = div(11)
                S12 = div(12)
                S13 = div(13)
                S14 = Now.Year
                S15 = Now.Month
                S16 = 1

                objCe_RAm.Num_Fact = S0
                objCe_RAm.Cod_Prest = S1
                objCe_RAm.Tipo_Ide_Usu = S2
                objCe_RAm.Num_Ide_Usu = S3
                objCe_RAm.Autorizacion = S4
                objCe_RAm.Cod_Med = S5
                objCe_RAm.Tipo_Med = S6
                objCe_RAm.Nom_Gen = S7
                objCe_RAm.Forma = S8
                objCe_RAm.Concent = S9
                objCe_RAm.Unidad = S10
                objCe_RAm.Num_Dosis = S11
                objCe_RAm.Val_Unit = S12
                objCe_RAm.Val_Total = S13
                objCe_RAm.Cod_Año = S14
                objCe_RAm.Cod_Per = S15
                objCe_RAm.Cod_Hosp = S16
                objCn_RAm.Nuevo_Rips_AT(objCe_RAm)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Sub LeerUS()
        On Error Resume Next
        Dim S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16
        Dim contenido As String
        Dim objOpen As New OpenFileDialog
        ' objOpen.ShowDialog()
        If (Ruta1 <> "") Then
            Dim objReader As New StreamReader(Ruta1)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            For Each sLine In arrText
                S0 = "" : S1 = "" : S2 = "" : S3 = "" : S4 = "" : S5 = "" : S6 = "" : S7 = "" : S8 = "" : S9 = "" : S10 = "" : S11 = "" : S12 = "" : S13 = "" : S14 = "" : S15 = "" : S16 = ""
                Dim div As String() = sLine.Split(New Char() {","c})
                S0 = div(0)
                S1 = div(1)
                S2 = div(2)
                S3 = div(3)
                S4 = div(4)
                S5 = div(5)
                S6 = div(6)
                S7 = div(7)
                S8 = div(8)
                S9 = div(9)
                S10 = div(10)
                S11 = div(11)
                S12 = div(12)
                S13 = div(13)
                S14 = Now.Year
                S15 = Now.Month
                S16 = 1

                objCe_RUs.Tipo_Ide_Usu = S0
                objCe_RUs.Num_Ide_Usu = S1
                objCe_RUs.Cod_Enti = S2
                objCe_RUs.Tipo_Usu = S3
                objCe_RUs.Apellido1 = S4
                objCe_RUs.Apellido2 = S5
                objCe_RUs.Nombre1 = S6
                objCe_RUs.Nombre2 = S7
                objCe_RUs.Edad = S8
                objCe_RUs.Uni_Med_Edad = S9
                objCe_RUs.Sexo = S10
                objCe_RUs.Cod_Dep_Res = S11
                objCe_RUs.Cod_Mun_Res = S12
                objCe_RUs.Zona_Res = S13
                objCe_RUs.Cod_Año = S14
                objCe_RUs.Cod_Per = S15
                objCe_RUs.Cod_Hosp = S16
                objCn_RUs.Nuevo_Rips_US(objCe_RUs)
                My.Application.DoEvents()
            Next
        End If
    End Sub

    Private Sub FrmRipsValidR3280_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Listar_Est_Gen_CT()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_RCt.Listar_Est_Gen_CT
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            If ds.Tables(0).Rows.Count Then
                Dgv.DataSource = ds.Tables(0)
            End If
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class