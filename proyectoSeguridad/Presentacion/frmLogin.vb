Imports System
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Xml.Serialization

Public Class frmLogin
	Public Property Encrip As MD5_3DS = New MD5_3DS : Dim _texto As String : Dim _respuesta As String
	Dim _usuario As String : Dim _valor2 As String : Dim _valor3 As String : Dim _id As Integer : Dim _hash As String : Dim _ip As String
	Public WithEvents WinSockCliente As New Cliente : Private demo As Thread = Nothing : Dim Texto As String : Delegate Sub SetTextCallback(ByVal [text1] As String)
	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtPuerto.Focus()
		Dim localHostName As String = Dns.GetHostName
		Dim localIp As IPHostEntry = Dns.GetHostEntry(localHostName)
	End Sub
	Private Sub TxtPuerto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuerto.KeyPress, txtIP1.KeyPress, txtIP2.KeyPress, txtIP3.KeyPress, txtIP4.KeyPress
		If Asc(e.KeyChar) <> 8 Then
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
				e.Handled = True
			End If
		End If
	End Sub
	Private Sub txtIP1_TextChanged(sender As Object, e As EventArgs) Handles txtIP1.TextChanged, txtIP2.TextChanged, txtIP3.TextChanged, txtIP4.TextChanged
		'Dim tb As TextBox = CType(sender, TextBox)
		'Dim tb As TextBox = DirectCast(sender, TextBox)
		'If tb.Text.Length = tb.MaxLength Then
		'	If tb.SelectionStart = 4 Then
		'		SelectNextControl(tb, True, True, False, False)
		'	End If
		'End If
		Dim tb As TextBox = DirectCast(sender, TextBox)
		If tb.Text.Length = tb.MaxLength Then
			Select Case tb.Name
				Case "txtPuerto"
					txtIP1.Focus()
				Case "txtIP1"
					txtIP2.Focus()
				Case "txtIP2"
					txtIP3.Focus()
				Case "txtIP3"
					txtIP4.Focus()
				Case "txtIP4"
					txtUsuario.Focus()
			End Select
		End If
	End Sub
	Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		txtPuerto.Clear() : txtIP1.Clear() : txtIP2.Clear() : txtIP3.Clear() : txtIP4.Clear() : txtUsuario.Clear() : txtPassword.Clear()
	End Sub
	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
		'Dim encriptado As String = Encrip.EncryptString(XML.Login(txtUsuario.Text, txtPassword.Text, hash))
		'Dim desencriptado As String = Encrip.DecryptString(encriptado)
		_ip = txtIP1.Text & lblP1.Text & txtIP2.Text & lblP2.Text & txtIP3.Text & lblP3.Text & txtIP4.Text
		'If txtPuerto.Text <> "" Then
		'	txtPuerto.Enabled = False
		'	If txtIP1.Text <> "___" And txtIP2.Text <> "___" And txtIP3.Text <> "___" And txtIP4.Text <> "___" Then
		'		txtIP1.Enabled = False : txtIP2.Enabled = False : txtIP3.Enabled = False : txtIP4.Enabled = False
		WinSockCliente.IPDelHost = _ip : WinSockCliente.PuertoDelHost = txtPuerto.Text : WinSockCliente.Conectar()
		'MsgBox("Conexion exitosa IP: " & ip & " Puerto: " & txtPuerto.Text)
		'hash = Encrip.Md5Encryta(XML.cadena(txtUsuario.Text, "123"))
		'txtPuerto.Enabled = False
		Try
			Dim tiempo = TimeOfDay.Hour() & ":" & TimeOfDay.Minute()
			Using md5Hash As MD5 = MD5.Create()
				Dim unlock As String = Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo))
				WinSockCliente.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(txtUsuario.Text, Encrip.Md5Encryta(md5Hash, txtPassword.Text), "", unlock, "Login")))
				'rtxt1.Text = Encrip.EncryptString(ManejoXml.SerialiazarXml(txtUsuario.Text, Encrip.Md5Encryta(md5Hash, txtPassword.Text), 0, unlock, "Login"))
				'rtxt2.Text = ManejoXml.SerialiazarXml(txtUsuario.Text, Encrip.Md5Encryta(md5Hash, txtPassword.Text), 0, unlock, "Login")
				'rtxt1.Text = XML.SerialiazarXml(txtUsuario.Text, Encrip.Md5Encryta(md5Hash, txtPassword.Text), "Archivo")
				'DLogin(rtxt1.Text)
				'rtxt2.Text = DLogin(rtxt1.Text)	'rtxt1.Text = Encrip.Md5Encryta(md5Hash, txtPassword.Text)
			End Using
			'WinSockCliente.EnviarDatos(Encrip.EncryptString(XML.Login(txtUsuario.Text, txtPassword.Text, 1)))
			'rtxt1.Text = XML.Login(txtUsuario.Text, txtPassword.Text)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		' : Hide() : frmCliente.Show()
		'ElseIf txtIP1.Text = "___" And txtIP2.Text = "___" And txtIP3.Text = "___" And txtIP4.Text = "___" Then
		'MsgBox("Favor ingrese todos los espacios de la IP")
		'End If'Else
		'MsgBox("Favor ingrese el puerto a conectar")
		'End If
	End Sub
	Private Sub ThreadProcSafe()
		SetText(Texto)
	End Sub
	Private Sub SetText(ByVal [text1] As String)
		If rtxt1.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText)
			Invoke(d, New Object() {[text1]})
		Else
			rtxt1.Text = text1
			'rtxt2.Text = DLogin(Encrip.DecryptString(rtxt1.Text))
			'DLogin(Encrip.DecryptString(rtxt1.Text))
			'rtxt2.Text = Encrip.DecryptString(rtxt1.Text)
			'MsgBox(DLogin(Encrip.DecryptString(rtxt1.Text)))
			Dim tiempo = TimeOfDay.Hour().ToString() & ":" & TimeOfDay.Minute().ToString()
			'Dim unlock As String
			Using md5Hash As MD5 = MD5.Create()
				DLogin(Encrip.DecryptString(rtxt1.Text))
				'MsgBox(Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo)) & "          " & _valor3)
				If Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo)) = _hash Then
					If DLogin(Encrip.DecryptString(rtxt1.Text)) = "Login" Then
						Hide() : frmCliente.Show()
					ElseIf DLogin(Encrip.DecryptString(rtxt1.Text)) = "Bitacora" Then
						MsgBox("asdasd")
					Else
						MsgBox("Datos ingresados son incorrectos, intente de nuevo")
						btnLimpiar.PerformClick()
					End If
				Else
					MsgBox("Hash no es compatible")
					'rtxt2.Text = Encrip.EncryptString(text1)
				End If
			End Using
		End If
	End Sub
	Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos
		'txtMensaje.Text = txtMensaje.Text + datos
		Texto = datos
		demo = New Thread(New ThreadStart(AddressOf ThreadProcSafe))
		demo.Start()
		'MsgBox("El servidor envio el siguiente mensaje: " & datos)
	End Sub
	Private Sub WinSockCliente_ConexionTerminada() Handles WinSockCliente.ConexionTerminada
		'MsgBox("Finalizo la conexion")
		'Habilito la posibilidad de una reconexion 
		txtIP1.Enabled = True
		txtIP2.Enabled = True
		txtIP3.Enabled = True
		txtIP4.Enabled = True
		txtPuerto.Enabled = True

	End Sub
	Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		End
	End Sub
	Public Function DLogin(ByVal str As String)
		Dim serializer1 As New XmlSerializer(GetType(XML))
		Dim items1 As XML
		Using reader1 As New StringReader(str)
			items1 = CType(serializer1.Deserialize(reader1), XML)
		End Using
		_usuario = items1.Valor1 : _valor2 = items1.Valor2 : _id = items1.Valor3 : _hash = items1.Hash : _respuesta = items1.Funcion
		Return _respuesta
	End Function
End Class