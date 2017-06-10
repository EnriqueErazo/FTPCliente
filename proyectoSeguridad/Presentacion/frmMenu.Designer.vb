<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.rbmContacto = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.rbmBitacora = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.rpgBitacora = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.btnGenerar = New DevExpress.XtraBars.BarButtonItem()
		Me.rbmArchivos = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.rpgArchivos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.btnSubidos = New DevExpress.XtraBars.BarButtonItem()
		Me.btnDisponibles = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSubir = New DevExpress.XtraBars.BarButtonItem()
		Me.btnDescargar = New DevExpress.XtraBars.BarButtonItem()
		Me.lblSubir = New DevExpress.XtraBars.BarStaticItem()
		Me.lblBajar = New DevExpress.XtraBars.BarStaticItem()
		Me.rbControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSalir = New DevExpress.XtraBars.BarButtonItem()
		Me.rbmComs = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.btnSalida = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.rpgSalir = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
		Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
		Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
		Me.pnlArchivos = New DevExpress.XtraEditors.PanelControl()
		Me.dgvDisponibles = New System.Windows.Forms.DataGridView()
		Me.dgvSubidos = New System.Windows.Forms.DataGridView()
		Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
		Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
		Me.pnlBitacora = New DevExpress.XtraEditors.PanelControl()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.rtxt1 = New System.Windows.Forms.RichTextBox()
		Me.rtxt2 = New System.Windows.Forms.RichTextBox()
		Me.lbl1 = New System.Windows.Forms.Label()
		Me.lbl2 = New System.Windows.Forms.Label()
		CType(Me.rbControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pnlArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlArchivos.SuspendLayout()
		CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvSubidos, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pnlBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlBitacora.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "Archivos"
		'
		'rbmContacto
		'
		Me.rbmContacto.Name = "rbmContacto"
		Me.rbmContacto.Text = "Contactos"
		'
		'rbmBitacora
		'
		Me.rbmBitacora.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgBitacora})
		Me.rbmBitacora.Name = "rbmBitacora"
		Me.rbmBitacora.Text = "Bitacora"
		'
		'rpgBitacora
		'
		Me.rpgBitacora.ItemLinks.Add(Me.btnGenerar)
		Me.rpgBitacora.Name = "rpgBitacora"
		Me.rpgBitacora.Text = "Opciones de bitacora"
		'
		'btnGenerar
		'
		Me.btnGenerar.Caption = "Generar Bitacora"
		Me.btnGenerar.Glyph = CType(resources.GetObject("btnGenerar.Glyph"), System.Drawing.Image)
		Me.btnGenerar.Id = 1
		Me.btnGenerar.LargeGlyph = CType(resources.GetObject("btnGenerar.LargeGlyph"), System.Drawing.Image)
		Me.btnGenerar.Name = "btnGenerar"
		'
		'rbmArchivos
		'
		Me.rbmArchivos.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgArchivos})
		Me.rbmArchivos.Name = "rbmArchivos"
		Me.rbmArchivos.Text = "Archivos"
		'
		'rpgArchivos
		'
		Me.rpgArchivos.ItemLinks.Add(Me.btnSubidos)
		Me.rpgArchivos.ItemLinks.Add(Me.btnDisponibles)
		Me.rpgArchivos.ItemLinks.Add(Me.btnSubir)
		Me.rpgArchivos.ItemLinks.Add(Me.btnDescargar)
		Me.rpgArchivos.ItemLinks.Add(Me.lblSubir)
		Me.rpgArchivos.ItemLinks.Add(Me.lblBajar)
		Me.rpgArchivos.Name = "rpgArchivos"
		Me.rpgArchivos.Text = "Opciones de archivos"
		'
		'btnSubidos
		'
		Me.btnSubidos.Caption = "Archivos subidos"
		Me.btnSubidos.Glyph = CType(resources.GetObject("btnSubidos.Glyph"), System.Drawing.Image)
		Me.btnSubidos.Id = 10
		Me.btnSubidos.LargeGlyph = CType(resources.GetObject("btnSubidos.LargeGlyph"), System.Drawing.Image)
		Me.btnSubidos.Name = "btnSubidos"
		'
		'btnDisponibles
		'
		Me.btnDisponibles.Caption = "Archivos disponibles"
		Me.btnDisponibles.Glyph = CType(resources.GetObject("btnDisponibles.Glyph"), System.Drawing.Image)
		Me.btnDisponibles.Id = 11
		Me.btnDisponibles.LargeGlyph = CType(resources.GetObject("btnDisponibles.LargeGlyph"), System.Drawing.Image)
		Me.btnDisponibles.Name = "btnDisponibles"
		'
		'btnSubir
		'
		Me.btnSubir.Caption = "Subir archivos"
		Me.btnSubir.Glyph = CType(resources.GetObject("btnSubir.Glyph"), System.Drawing.Image)
		Me.btnSubir.Id = 12
		Me.btnSubir.LargeGlyph = CType(resources.GetObject("btnSubir.LargeGlyph"), System.Drawing.Image)
		Me.btnSubir.Name = "btnSubir"
		'
		'btnDescargar
		'
		Me.btnDescargar.Caption = "Descargar archivos"
		Me.btnDescargar.Glyph = CType(resources.GetObject("btnDescargar.Glyph"), System.Drawing.Image)
		Me.btnDescargar.Id = 13
		Me.btnDescargar.LargeGlyph = CType(resources.GetObject("btnDescargar.LargeGlyph"), System.Drawing.Image)
		Me.btnDescargar.Name = "btnDescargar"
		'
		'lblSubir
		'
		Me.lblSubir.Caption = "Ruta carga: "
		Me.lblSubir.Id = 21
		Me.lblSubir.Name = "lblSubir"
		Me.lblSubir.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'lblBajar
		'
		Me.lblBajar.Caption = "Ruta descarga:"
		Me.lblBajar.Id = 22
		Me.lblBajar.Name = "lblBajar"
		Me.lblBajar.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'rbControl
		'
		Me.rbControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbControl.Dock = System.Windows.Forms.DockStyle.None
		Me.rbControl.ExpandCollapseItem.Id = 0
		Me.rbControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbControl.ExpandCollapseItem, Me.btnSubidos, Me.btnDisponibles, Me.btnSubir, Me.btnDescargar, Me.lblSubir, Me.lblBajar, Me.btnGenerar, Me.btnCerrar, Me.btnSalir})
		Me.rbControl.Location = New System.Drawing.Point(0, 0)
		Me.rbControl.MaxItemId = 4
		Me.rbControl.Name = "rbControl"
		Me.rbControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbmArchivos, Me.rbmBitacora, Me.rbmContacto, Me.rbmComs, Me.btnSalida})
		Me.rbControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
		Me.rbControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[True]
		Me.rbControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
		Me.rbControl.Size = New System.Drawing.Size(682, 142)
		'
		'btnCerrar
		'
		Me.btnCerrar.Caption = "Cerrar Session"
		Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
		Me.btnCerrar.Id = 2
		Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
		Me.btnCerrar.Name = "btnCerrar"
		'
		'btnSalir
		'
		Me.btnSalir.Caption = "Salir"
		Me.btnSalir.Glyph = CType(resources.GetObject("btnSalir.Glyph"), System.Drawing.Image)
		Me.btnSalir.Id = 3
		Me.btnSalir.LargeGlyph = CType(resources.GetObject("btnSalir.LargeGlyph"), System.Drawing.Image)
		Me.btnSalir.Name = "btnSalir"
		'
		'rbmComs
		'
		Me.rbmComs.Name = "rbmComs"
		Me.rbmComs.Text = "Comunicacion"
		'
		'btnSalida
		'
		Me.btnSalida.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgSalir})
		Me.btnSalida.Name = "btnSalida"
		Me.btnSalida.Text = "Salida"
		'
		'rpgSalir
		'
		Me.rpgSalir.ItemLinks.Add(Me.btnCerrar)
		Me.rpgSalir.ItemLinks.Add(Me.btnSalir)
		Me.rpgSalir.Name = "rpgSalir"
		Me.rpgSalir.Text = "Salida"
		'
		'RepositoryItemRichTextEdit1
		'
		Me.RepositoryItemRichTextEdit1.MaxHeight = 500
		Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
		Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
		'
		'RepositoryItemMemoEdit1
		'
		Me.RepositoryItemMemoEdit1.LinesCount = 3
		Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
		'
		'RepositoryItemMemoEdit2
		'
		Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
		'
		'pnlArchivos
		'
		Me.pnlArchivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlArchivos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pnlArchivos.Controls.Add(Me.dgvDisponibles)
		Me.pnlArchivos.Controls.Add(Me.dgvSubidos)
		Me.pnlArchivos.Location = New System.Drawing.Point(12, 148)
		Me.pnlArchivos.Name = "pnlArchivos"
		Me.pnlArchivos.Size = New System.Drawing.Size(657, 536)
		Me.pnlArchivos.TabIndex = 1
		Me.pnlArchivos.Visible = False
		'
		'dgvDisponibles
		'
		Me.dgvDisponibles.AccessibleName = ""
		Me.dgvDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvDisponibles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
		Me.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDisponibles.Enabled = False
		Me.dgvDisponibles.GridColor = System.Drawing.Color.White
		Me.dgvDisponibles.Location = New System.Drawing.Point(6, 269)
		Me.dgvDisponibles.Name = "dgvDisponibles"
		Me.dgvDisponibles.Size = New System.Drawing.Size(646, 262)
		Me.dgvDisponibles.TabIndex = 3
		Me.dgvDisponibles.Tag = ""
		'
		'dgvSubidos
		'
		Me.dgvSubidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvSubidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSubidos.Enabled = False
		Me.dgvSubidos.Location = New System.Drawing.Point(6, 6)
		Me.dgvSubidos.Name = "dgvSubidos"
		Me.dgvSubidos.Size = New System.Drawing.Size(646, 257)
		Me.dgvSubidos.TabIndex = 0
		'
		'BarButtonItem3
		'
		Me.BarButtonItem3.Caption = "Subir archivo"
		Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
		Me.BarButtonItem3.Id = 8
		Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
		Me.BarButtonItem3.Name = "BarButtonItem3"
		'
		'BarEditItem1
		'
		Me.BarEditItem1.Edit = Me.RepositoryItemRichTextEdit1
		Me.BarEditItem1.EditHeight = 80
		Me.BarEditItem1.Id = 16
		Me.BarEditItem1.Name = "BarEditItem1"
		Me.BarEditItem1.Width = 200
		'
		'pnlBitacora
		'
		Me.pnlBitacora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlBitacora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pnlBitacora.Controls.Add(Me.DataGridView2)
		Me.pnlBitacora.Location = New System.Drawing.Point(12, 148)
		Me.pnlBitacora.Name = "pnlBitacora"
		Me.pnlBitacora.Size = New System.Drawing.Size(657, 536)
		Me.pnlBitacora.TabIndex = 4
		Me.pnlBitacora.Visible = False
		'
		'DataGridView2
		'
		Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Enabled = False
		Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(646, 525)
		Me.DataGridView2.TabIndex = 0
		'
		'rtxt1
		'
		Me.rtxt1.Location = New System.Drawing.Point(338, 77)
		Me.rtxt1.Name = "rtxt1"
		Me.rtxt1.Size = New System.Drawing.Size(161, 65)
		Me.rtxt1.TabIndex = 6
		Me.rtxt1.Text = ""
		'
		'rtxt2
		'
		Me.rtxt2.Location = New System.Drawing.Point(505, 77)
		Me.rtxt2.Name = "rtxt2"
		Me.rtxt2.Size = New System.Drawing.Size(164, 65)
		Me.rtxt2.TabIndex = 7
		Me.rtxt2.Text = ""
		'
		'lbl1
		'
		Me.lbl1.AutoSize = True
		Me.lbl1.Location = New System.Drawing.Point(335, 61)
		Me.lbl1.Name = "lbl1"
		Me.lbl1.Size = New System.Drawing.Size(39, 13)
		Me.lbl1.TabIndex = 8
		Me.lbl1.Text = "Label1"
		'
		'lbl2
		'
		Me.lbl2.AutoSize = True
		Me.lbl2.Location = New System.Drawing.Point(502, 61)
		Me.lbl2.Name = "lbl2"
		Me.lbl2.Size = New System.Drawing.Size(39, 13)
		Me.lbl2.TabIndex = 9
		Me.lbl2.Text = "Label2"
		'
		'frmCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(681, 696)
		Me.Controls.Add(Me.lbl2)
		Me.Controls.Add(Me.lbl1)
		Me.Controls.Add(Me.rtxt2)
		Me.Controls.Add(Me.rtxt1)
		Me.Controls.Add(Me.pnlArchivos)
		Me.Controls.Add(Me.rbControl)
		Me.Controls.Add(Me.pnlBitacora)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(697, 726)
		Me.Name = "frmCliente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Cliente"
		CType(Me.rbControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pnlArchivos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlArchivos.ResumeLayout(False)
		CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvSubidos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pnlBitacora, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlBitacora.ResumeLayout(False)
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rbmContacto As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rbmBitacora As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rbmArchivos As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rpgArchivos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents rbControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents pnlArchivos As DevExpress.XtraEditors.PanelControl
	Friend WithEvents btnSubidos As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnDisponibles As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSubir As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnDescargar As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents dgvSubidos As System.Windows.Forms.DataGridView
	Friend WithEvents dgvDisponibles As System.Windows.Forms.DataGridView
	Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
	Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
	Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
	Friend WithEvents lblSubir As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents lblBajar As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
	Friend WithEvents pnlBitacora As DevExpress.XtraEditors.PanelControl
	Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
	Friend WithEvents rpgBitacora As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents btnGenerar As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents rbmComs As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSalida As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rpgSalir As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents rtxt1 As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxt2 As System.Windows.Forms.RichTextBox
	Friend WithEvents lbl1 As System.Windows.Forms.Label
	Friend WithEvents lbl2 As System.Windows.Forms.Label

End Class
