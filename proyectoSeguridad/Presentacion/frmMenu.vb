Imports System
Imports System.IO
Imports System.Threading
Imports System.Xml.Serialization

Public Class frmCliente
	Dim WithEvents WinSockCliente As New Cliente : Private _demo As Thread = Nothing : Dim _texto As String : Dim _valor1 As String : Dim _valor2 As String
	Dim _valor3 As String : Dim _respuesta As String : Private Delegate Sub SetTextCallback(ByVal [text1] As String)
	Public Property Encrip As MD5_3DS = New MD5_3DS
	Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbControl.Minimized = True
	End Sub
	Private Sub btnSubidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubidos.ItemClick
		dgvSubidos.Enabled = True
		dgvDisponibles.Enabled = False
	End Sub
	Private Sub btnDisponibles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDisponibles.ItemClick
		dgvSubidos.Enabled = False
		dgvDisponibles.Enabled = True
	End Sub
	Private Sub rbControl_Click(sender As Object, e As EventArgs) Handles rbControl.Click
		rbControl.Minimized = False
		If rbControl.SelectedPage.Text = "Archivos" Then
			pnlArchivos.Visible = True
			pnlBitacora.Visible = False
		ElseIf rbControl.SelectedPage.Text = "Bitacora" Then
			pnlBitacora.Visible = True
			pnlArchivos.Visible = False
		ElseIf rbControl.SelectedPage.Text = "Contactos" Then
			pnlBitacora.Visible = False
			pnlArchivos.Visible = False
		ElseIf rbControl.SelectedPage.Text = "Comunicacion" Then
			pnlBitacora.Visible = False
			pnlArchivos.Visible = False
		ElseIf rbControl.SelectedPage.Text = "Salir" Then
			pnlBitacora.Visible = False
			pnlArchivos.Visible = False
		End If
	End Sub
	Private Sub btnSubir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubir.ItemClick
		Try
			Dim selector As New OpenFileDialog()
			If selector.ShowDialog() = Windows.Forms.DialogResult.OK Then
				Dim datos As String = selector.FileName
				Dim detalle As New FileInfo(datos)
				lblBajar.Caption = "Ruta descarga: " : lblSubir.Caption = "Ruta carga: " & selector.FileName
				_valor1 = frmLogin.txtUsuario.Text
				_valor2 = detalle.Name
				_valor3 = codifica(selector.FileName)
				frmLogin.WinSockCliente.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "Archivo")))
				'rtxt1.Text = Encrip.EncryptString(XML.SerialiazarXml(usuario, valor2, funcion))
				'rtxt2.Text = XML.SerialiazarXml(usuario, valor2, funcion)
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message & vbCr & "Intente de Nuevo")
		End Try
	End Sub
	Private Sub btnDescargar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDescargar.ItemClick
		Try
			Dim selector As New FolderBrowserDialog()
			If selector.ShowDialog = Windows.Forms.DialogResult.OK Then
				lblSubir.Caption = "Ruta carga: " : lblBajar.Caption = "Ruta descarga: " & selector.SelectedPath
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub btnGenerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerar.ItemClick
		'Using md5Hash As MD5 = MD5.Create()
		'WinSockCliente.EnviarDatos(Encrip.EncryptString(XML.Login(lbl1.Text, Encrip.Md5Encryta(md5Hash, lbl2.Text), 2)))
		'End Using
	End Sub
	Private Sub frmCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		End
	End Sub
	Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
		End
	End Sub
	Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick

	End Sub
	Private Sub ThreadProcSafe()
		SetText(_texto)
	End Sub
	Private Sub SetText(ByVal [text1] As String)

		' InvokeRequired required compares the thread ID of the
		' calling thread to the thread ID of the creating thread.
		' If these threads are different, it returns true.
		If rtxt1.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText)
			Invoke(d, New Object() {[text1]})
		Else
			rtxt1.Text = text1
			'DLogin(Encrip.DecryptString(rtxt1.Text))
			'If _respuesta = 1 Then
			'	Hide() : frmCliente.Show()
			'Else
			'	MsgBox("Datos ingresados son incorrectos, intente de nuevo")
			'	btnLimpiar.PerformClick()
			'End If
			'rtxt2.Text = Encrip.EncryptString(text1)
		End If
	End Sub
	Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos
		'txtMensaje.Text = txtMensaje.Text + datos
		_texto = datos : _demo = New Thread(New ThreadStart(AddressOf ThreadProcSafe)) : _demo.Start()
		'MsgBox("El servidor envio el siguiente mensaje: " & datos)
	End Sub
	Private Sub WinSockCliente_ConexionTerminada() Handles WinSockCliente.ConexionTerminada
		'MsgBox("Finalizo la conexion")
		frmLogin.txtIP1.Enabled = True : frmLogin.txtIP2.Enabled = True : frmLogin.txtIP3.Enabled = True : frmLogin.txtIP4.Enabled = True : frmLogin.txtPuerto.Enabled = True
		frmLogin.txtIP1.Clear() : frmLogin.txtIP2.Clear() : frmLogin.txtIP3.Clear() : frmLogin.txtIP4.Clear() : frmLogin.txtPuerto.Clear()
	End Sub
	Function codifica(ByVal srcFile As String)
		Try
			Dim value As String = Convert.ToBase64String(My.Computer.FileSystem.ReadAllBytes(srcFile)) : Return value
		Catch ex As Exception
			MsgBox(ex.Message) : Return Nothing
		End Try
	End Function
	Public Function Deserializar(ByVal str As String)
		Dim serializer1 As New XmlSerializer(GetType(XML))
		Dim items1 As XML
		Using reader1 As New StringReader(str)
			items1 = CType(serializer1.Deserialize(reader1), XML)
		End Using
		_valor1 = items1.valor1 : _valor2 = items1.valor2 : _valor3 = items1.valor3 : _respuesta = items1.Funcion
		Return _respuesta
	End Function
End Class