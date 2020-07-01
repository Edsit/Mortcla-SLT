Imports C_Entidad
Imports C_Negocio
Public Class FrmLogin
    Private FormularioActivo As Form = Nothing
    Dim Pwd As String = ""
    Dim objCe_F As New Ce_Funcionarios
    Dim objCn_F As New Cn_Funcionarios

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ValidarClave()
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbDoc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            LoadDatos()
            'TbClave.Focus()
        End If
    End Sub

    Private Sub LoadDatos()
        Dim ds As New DataSet
        ConsFunc = 0 : SedeFuncCons = 0 : DocuFunc = "" : NomFunc = ""
        Try
            objCe_F.Doc = TbDoc.Text
            ds = objCn_F.Login(objCe_F)
            If ds.Tables(0).Rows.Count = 1 Then
                ConsFunc = ds.Tables(0).Rows(0).Item(0)
                SedeFuncCons = ds.Tables(0).Rows(0).Item(1)
                NomFunc = ds.Tables(0).Rows(0).Item(3)
                DocuFunc = TbDoc.Text.Trim
                PerfilFunc = ds.Tables(0).Rows(0).Item(6)
                Pwd = ds.Tables(0).Rows(0).Item(7)
                LbCargo.Text = ds.Tables(0).Rows(0).Item(4)
                If ds.Tables(0).Rows(0).Item(5) = 1 Then
                    LbEstado.Text = "ACTIVO"
                Else
                    LbEstado.Text = "INACTIVO"
                End If
                LbFunc.Text = ds.Tables(0).Rows(0).Item(3)
                Sede = ds.Tables(0).Rows(0).Item(2)
                LbSede.Text = "ESE DEPARTAMENTAL MORENO Y CLAVIJO - " & Sede
                TbClave.Enabled = True
                TbClave.Focus()
            Else
                TbClave.Enabled = False
                MsgBox("Funcionario no registrado en el sistema", MsgBoxStyle.Critical, "Inicio de Sesión")
                TbDoc.Focus()
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbCargo.Text = ""
        LbEstado.Text = ""
        LbFunc.Text = ""
        LbSede.Text = ""
        TbClave.Enabled = False
    End Sub

    Private Sub TbClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ValidarClave()
        End If
    End Sub

    Private Sub ValidarClave()
        If TbClave.Text.Trim = "" Then
            MsgBox("ACCESO NEGADO", MsgBoxStyle.Critical, "Iniciar Sesión")
            TbClave.Text = ""
            TbDoc.Focus()
        Else
            Texto = TbClave.Text
            Cript()
            If Pwd = Texto Then
                Frm_Principal.LbSede.Text = LbSede.Text
                Frm_Principal.LbFuncionario.Text = LbFunc.Text & " | " & LbCargo.Text
                Accion = "INGRESO AL SISTEMA"
                RegistrarAuditoria()
                IniciarSesion()
                Frm_Bienvenida.ShowDialog()
                Me.Dispose()
                Me.Close()
            Else
                MsgBox("ACCESO NEGADO", MsgBoxStyle.Critical, "Iniciar Sesión")
                TbClave.Text = ""
            End If
        End If
    End Sub

    Private Sub CerrarSesión()
        FrmModulos.PanelModulo.Enabled = False
        FrmModulos.PanelModulos.Enabled = False
        FrmModulos.BtnSeguridad.Enabled = False
        FrmModulos.PanelContenedor.Enabled = False
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Dispose()
            FormularioActivo.Close()
        End If
        FrmModulos.BtnSesión.Text = "Iniciar Sesión"

    End Sub

    Private Sub IniciarSesion()
        Frm_Principal.PanelContenedor.Enabled = True
        Frm_Principal.PanelMenu.Enabled = True
        Frm_Principal.BtnSeguridad.Enabled = True
        Frm_Principal.BtnSesión.Text = "Cerrar Sesión"
    End Sub

    Private Sub TbDoc_OnValueChanged(sender As Object, e As EventArgs) Handles TbDoc.OnValueChanged

    End Sub
End Class