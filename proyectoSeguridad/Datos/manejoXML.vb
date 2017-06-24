Imports System.IO
Imports System.Xml.Serialization
Public Class ManejoXml
	Shared _xmlSerializer As XmlSerializer : Shared _stringWriter As New StringWriter
	Public Shared Function Key(hora As String) As String
		Dim llave As String = "ftpseguro" & hora
		Return llave
	End Function
	'Public Shared Function SerialiazarXmlLogin(ByVal Usuario As String, ByVal contra As String, ByVal id As String, ByVal hash As String, ByVal opcion As String) As String
	'	Dim log As New Login(Usuario, contra, id, hash, opcion) : _xmlSerializer = New XmlSerializer(GetType(Login))
	'	Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : _stringWriter = New StringWriter
	'	_xmlSerializer.Serialize(_stringWriter, log, ns) : _stringWriter.Close()
	'	Return _stringWriter.ToString()
	'End Function
	Public Shared Function SerialiazarXml(ByVal usuario As String, ByVal nombre As String, ByVal archivo As String, ByVal hash As String, ByVal opcion As String) As String
		Dim xml As New XML(usuario, nombre, archivo, hash, opcion) : _xmlSerializer = New XmlSerializer(GetType(XML))
		Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : _stringWriter = New StringWriter
		_xmlSerializer.Serialize(_stringWriter, xml, ns) : _stringWriter.Close()
		Return _stringWriter.ToString()
	End Function
End Class
