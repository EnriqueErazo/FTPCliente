Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System

Public Class MD5_3DS
	Private _tripleDes As New TripleDESCryptoServiceProvider
	Private m_bKey(), m_bIV() As Byte
	Public Sub New()
		Dim strCrypt, strIV As String

		strCrypt = "q5AsCA64SeY+SpoJ24ERrg=="
		strIV = "VaOHJOI2J/c="
		m_bKey = Convert.FromBase64String(strCrypt)
		m_bIV = Convert.FromBase64String(strIV)
	End Sub
	Public Function EncryptString(ByVal strPlainText As String) As String

		Dim tDESProvider As New TripleDESCryptoServiceProvider
		'Dim tDes2 As New TripleDES
		Dim cryptStream As CryptoStream
		Dim iCryptoEncryptor As ICryptoTransform
		Dim memStream As New MemoryStream()
		Dim bPlainText As Byte()
		Dim strTempEncrypt As String

		tDESProvider.KeySize = 128

		iCryptoEncryptor = tDESProvider.CreateEncryptor(m_bKey, m_bIV)
		cryptStream = New CryptoStream(memStream, iCryptoEncryptor, CryptoStreamMode.Write)
		bPlainText = System.Text.Encoding.UTF8.GetBytes(strPlainText)
		cryptStream.Write(bPlainText, 0, bPlainText.Length)
		cryptStream.FlushFinalBlock()
		Dim tmp(CType(memStream.Length - 1, System.Int32)) As Byte
		memStream.Position = 0
		memStream.Read(tmp, 0, CType(memStream.Length, System.Int32))
		memStream.Close()
		cryptStream.Close()
		strTempEncrypt = Convert.ToBase64String(tmp)
		Return strTempEncrypt
		'retorna el String encriptado

	End Function
	Public Function DecryptString(ByVal strCipherText As String) As String
		Dim strTempDecrypt As String
		Dim memstream2 As New MemoryStream
		Dim iCryptoDecryptor As ICryptoTransform
		Dim tDESProviderd As New TripleDESCryptoServiceProvider
		Dim cryptdStream As CryptoStream
		Dim bCipher As Byte()

		bCipher = Convert.FromBase64String(strCipherText)
		tDESProviderd.KeySize = 128
		iCryptoDecryptor = tDESProviderd.CreateDecryptor(m_bKey, m_bIV)
		cryptdStream = New CryptoStream(memstream2, iCryptoDecryptor, CryptoStreamMode.Write)
		cryptdStream.Write(bCipher, 0, bCipher.Length)
		cryptdStream.FlushFinalBlock()
		memstream2.Position = 0

		Dim temp2(CType(memstream2.Length - 1, Int32)) As Byte

		memstream2.Read(temp2, 0, temp2.Length)
		memstream2.Close()
		cryptdStream.Close()

		strTempDecrypt = System.Text.Encoding.UTF8.GetString(temp2)
		Return strTempDecrypt
	End Function
	Function Md5Encryta(ByVal md5Hash As MD5, ByVal input As String) As String
		' Convert the input string to a byte array and compute the hash.
		Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
		' Create a new Stringbuilder to collect the bytes
		' and create a string.
		Dim sBuilder As New StringBuilder()
		' Loop through each byte of the hashed data 
		' and format each one as a hexadecimal string.
		Dim i As Integer
		For i = 0 To data.Length - 1
			sBuilder.Append(data(i).ToString("x2"))
		Next i
		' Return the hexadecimal string.
		Return sBuilder.ToString()
	End Function
End Class
