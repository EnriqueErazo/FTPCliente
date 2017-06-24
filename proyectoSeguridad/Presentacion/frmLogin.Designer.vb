<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.pnlLogin = New DevExpress.XtraEditors.PanelControl()
		Me.rtxt2 = New System.Windows.Forms.RichTextBox()
		Me.rtxt1 = New System.Windows.Forms.RichTextBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnIngresar = New System.Windows.Forms.Button()
		Me.lblPass = New DevExpress.XtraEditors.LabelControl()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.txtPuerto = New System.Windows.Forms.TextBox()
		Me.txtIP3 = New System.Windows.Forms.TextBox()
		Me.txtIP4 = New System.Windows.Forms.TextBox()
		Me.txtIP2 = New System.Windows.Forms.TextBox()
		Me.txtIP1 = New System.Windows.Forms.TextBox()
		Me.lblP1 = New DevExpress.XtraEditors.LabelControl()
		Me.lblP2 = New DevExpress.XtraEditors.LabelControl()
		Me.lblP3 = New DevExpress.XtraEditors.LabelControl()
		Me.lblIP = New DevExpress.XtraEditors.LabelControl()
		Me.lblPuerto = New DevExpress.XtraEditors.LabelControl()
		CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLogin.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlLogin
		'
		Me.pnlLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlLogin.Controls.Add(Me.rtxt2)
		Me.pnlLogin.Controls.Add(Me.rtxt1)
		Me.pnlLogin.Controls.Add(Me.btnLimpiar)
		Me.pnlLogin.Controls.Add(Me.btnIngresar)
		Me.pnlLogin.Controls.Add(Me.lblPass)
		Me.pnlLogin.Controls.Add(Me.txtPassword)
		Me.pnlLogin.Controls.Add(Me.lblUsuario)
		Me.pnlLogin.Controls.Add(Me.txtUsuario)
		Me.pnlLogin.Controls.Add(Me.txtPuerto)
		Me.pnlLogin.Controls.Add(Me.txtIP3)
		Me.pnlLogin.Controls.Add(Me.txtIP4)
		Me.pnlLogin.Controls.Add(Me.txtIP2)
		Me.pnlLogin.Controls.Add(Me.txtIP1)
		Me.pnlLogin.Controls.Add(Me.lblP1)
		Me.pnlLogin.Controls.Add(Me.lblP2)
		Me.pnlLogin.Controls.Add(Me.lblP3)
		Me.pnlLogin.Controls.Add(Me.lblIP)
		Me.pnlLogin.Controls.Add(Me.lblPuerto)
		Me.pnlLogin.Location = New System.Drawing.Point(12, 12)
		Me.pnlLogin.Name = "pnlLogin"
		Me.pnlLogin.Size = New System.Drawing.Size(677, 305)
		Me.pnlLogin.TabIndex = 1
		'
		'rtxt2
		'
		Me.rtxt2.Location = New System.Drawing.Point(349, 160)
		Me.rtxt2.Name = "rtxt2"
		Me.rtxt2.Size = New System.Drawing.Size(323, 149)
		Me.rtxt2.TabIndex = 19
		Me.rtxt2.Text = ""
		'
		'rtxt1
		'
		Me.rtxt1.Location = New System.Drawing.Point(349, 5)
		Me.rtxt1.Name = "rtxt1"
		Me.rtxt1.Size = New System.Drawing.Size(323, 149)
		Me.rtxt1.TabIndex = 18
		Me.rtxt1.Text = ""
		'
		'btnLimpiar
		'
		Me.btnLimpiar.Location = New System.Drawing.Point(162, 149)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(78, 23)
		Me.btnLimpiar.TabIndex = 15
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.UseVisualStyleBackColor = True
		'
		'btnIngresar
		'
		Me.btnIngresar.Location = New System.Drawing.Point(78, 149)
		Me.btnIngresar.Name = "btnIngresar"
		Me.btnIngresar.Size = New System.Drawing.Size(78, 23)
		Me.btnIngresar.TabIndex = 14
		Me.btnIngresar.Text = "Ingresar"
		Me.btnIngresar.UseVisualStyleBackColor = True
		'
		'lblPass
		'
		Me.lblPass.Location = New System.Drawing.Point(78, 125)
		Me.lblPass.Name = "lblPass"
		Me.lblPass.Size = New System.Drawing.Size(56, 13)
		Me.lblPass.TabIndex = 13
		Me.lblPass.Text = "Contraseña"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(140, 122)
		Me.txtPassword.MaxLength = 30
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(126)
		Me.txtPassword.Size = New System.Drawing.Size(100, 21)
		Me.txtPassword.TabIndex = 12
		Me.txtPassword.Text = "hola"
		'
		'lblUsuario
		'
		Me.lblUsuario.Location = New System.Drawing.Point(98, 98)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(36, 13)
		Me.lblUsuario.TabIndex = 11
		Me.lblUsuario.Text = "Usuario"
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(140, 95)
		Me.txtUsuario.MaxLength = 30
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(100, 21)
		Me.txtUsuario.TabIndex = 10
		Me.txtUsuario.Text = "cla"
		'
		'txtPuerto
		'
		Me.txtPuerto.Location = New System.Drawing.Point(210, 5)
		Me.txtPuerto.MaxLength = 5
		Me.txtPuerto.Name = "txtPuerto"
		Me.txtPuerto.Size = New System.Drawing.Size(100, 21)
		Me.txtPuerto.TabIndex = 1
		Me.txtPuerto.Text = "8050"
		'
		'txtIP3
		'
		Me.txtIP3.Location = New System.Drawing.Point(238, 32)
		Me.txtIP3.MaxLength = 3
		Me.txtIP3.Name = "txtIP3"
		Me.txtIP3.Size = New System.Drawing.Size(28, 21)
		Me.txtIP3.TabIndex = 7
		Me.txtIP3.Text = "0"
		'
		'txtIP4
		'
		Me.txtIP4.Location = New System.Drawing.Point(282, 32)
		Me.txtIP4.MaxLength = 3
		Me.txtIP4.Name = "txtIP4"
		Me.txtIP4.Size = New System.Drawing.Size(28, 21)
		Me.txtIP4.TabIndex = 9
		Me.txtIP4.Text = "1"
		'
		'txtIP2
		'
		Me.txtIP2.Location = New System.Drawing.Point(194, 32)
		Me.txtIP2.MaxLength = 3
		Me.txtIP2.Name = "txtIP2"
		Me.txtIP2.Size = New System.Drawing.Size(28, 21)
		Me.txtIP2.TabIndex = 5
		Me.txtIP2.Text = "0"
		'
		'txtIP1
		'
		Me.txtIP1.Location = New System.Drawing.Point(150, 32)
		Me.txtIP1.MaxLength = 3
		Me.txtIP1.Name = "txtIP1"
		Me.txtIP1.Size = New System.Drawing.Size(28, 21)
		Me.txtIP1.TabIndex = 3
		Me.txtIP1.Text = "127"
		'
		'lblP1
		'
		Me.lblP1.Location = New System.Drawing.Point(184, 35)
		Me.lblP1.Name = "lblP1"
		Me.lblP1.Size = New System.Drawing.Size(4, 13)
		Me.lblP1.TabIndex = 4
		Me.lblP1.Text = "."
		'
		'lblP2
		'
		Me.lblP2.Location = New System.Drawing.Point(228, 35)
		Me.lblP2.Name = "lblP2"
		Me.lblP2.Size = New System.Drawing.Size(4, 13)
		Me.lblP2.TabIndex = 6
		Me.lblP2.Text = "."
		'
		'lblP3
		'
		Me.lblP3.Location = New System.Drawing.Point(272, 35)
		Me.lblP3.Name = "lblP3"
		Me.lblP3.Size = New System.Drawing.Size(4, 13)
		Me.lblP3.TabIndex = 8
		Me.lblP3.Text = "."
		'
		'lblIP
		'
		Me.lblIP.Location = New System.Drawing.Point(84, 35)
		Me.lblIP.Name = "lblIP"
		Me.lblIP.Size = New System.Drawing.Size(60, 13)
		Me.lblIP.TabIndex = 2
		Me.lblIP.Text = "Direccion IP:"
		'
		'lblPuerto
		'
		Me.lblPuerto.Location = New System.Drawing.Point(165, 9)
		Me.lblPuerto.Name = "lblPuerto"
		Me.lblPuerto.Size = New System.Drawing.Size(39, 13)
		Me.lblPuerto.TabIndex = 0
		Me.lblPuerto.Text = "Puerto: "
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(701, 329)
		Me.Controls.Add(Me.pnlLogin)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLogin"
		Me.Text = "Login"
		CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLogin.ResumeLayout(False)
		Me.pnlLogin.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlLogin As DevExpress.XtraEditors.PanelControl
	Friend WithEvents lblIP As DevExpress.XtraEditors.LabelControl
	Friend WithEvents lblPuerto As DevExpress.XtraEditors.LabelControl
	Friend WithEvents lblP1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents lblP2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents lblP3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtIP3 As System.Windows.Forms.TextBox
	Friend WithEvents txtIP4 As System.Windows.Forms.TextBox
	Friend WithEvents txtIP2 As System.Windows.Forms.TextBox
	Friend WithEvents txtIP1 As System.Windows.Forms.TextBox
	Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
	Friend WithEvents btnLimpiar As System.Windows.Forms.Button
	Friend WithEvents btnIngresar As System.Windows.Forms.Button
	Friend WithEvents lblPass As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
	Friend WithEvents rtxt1 As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxt2 As System.Windows.Forms.RichTextBox
End Class
