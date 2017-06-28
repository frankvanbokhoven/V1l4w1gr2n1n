Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Web
Imports System.Xml.Serialization
Imports System.Xml.XPath

Public Class HttpData

#Region "Globals"

	Private CookieContainer As New System.Net.CookieContainer
	Private Administrations As New Generic.List(Of AdministrationData)

#End Region

#Region "Enums"

	Public Enum Directions
		Export = 0
		Import = 1
	End Enum

	Private Enum MessageType
		[Error] = 0
		Warning
		Message
		Fatal
	End Enum

#End Region

#Region "Properties"

	Public ReadOnly DirectionOptions As String() = { _
	 "Export from Exact Online", _
	 "Import into Exact Online"}

	Private _Credentials As New CredentialData
	Public Property Credentials() As CredentialData
		Get
			Return _Credentials
		End Get
		Set(ByVal value As CredentialData)
			_Credentials = value
		End Set
	End Property

	Private _ProxyServer As New ProxyServerData
	Public Property ProxyServer() As ProxyServerData
		Get
			Return _ProxyServer
		End Get
		Set(ByVal value As ProxyServerData)
			_ProxyServer = value
		End Set
	End Property

	Private _CredentialsChanged As Boolean = False
	Public Property CredentialsChanged() As Boolean
		Get
			Return _CredentialsChanged
		End Get
		Set(ByVal value As Boolean)
			_CredentialsChanged = value
			If _CredentialsChanged Then
				_topicXML = Nothing
				_Topics.Clear()
			End If
		End Set
	End Property

#End Region

#Region "Topics and parameters properties"

	Private _topicXML As New EOLTopics
	Private ReadOnly Property TopicXML() As EOLTopics
		Get
			If _topicXML Is Nothing Then
				Dim xs As New XmlSerializer(GetType(EOLTopics))
                Dim sURL As String = CStr(IIf(Right(frmImporterMain.txtURL.Text, 1) <> "/", frmImporterMain.txtURL.Text & "/", frmImporterMain.txtURL.Text))

                If Len(sURL) > 0 AndAlso frmImporterMain.cmbDivision.SelectedValue IsNot Nothing Then
                    Try
                        If SetAdministration(sURL, CStr(frmImporterMain.cmbDivision.SelectedValue)) Then

                            'This aspx will return all available topics and their import/export parameters.
                            'It will also return possible values for combo boxes, checkbox lists and radio buttons.
                            Dim sURLTopics As String = sURL & "Docs/XMLTopicParameters.aspx"

                            Dim request As HttpWebRequest = _CreateWebRequest(Directions.Export, sURLTopics)
                            If Not IsNothing(request) Then
                                Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                                    Dim readStream As New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                                    _topicXML = DirectCast(xs.Deserialize(readStream), EOLTopics)
                                End Using
                            End If
                        End If
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End If
            End If
            Return _topicXML
        End Get
    End Property

    Private _Topics As New ArrayList
    Public ReadOnly Property Topics() As String()
        Get
            If _Topics.Count = 0 AndAlso TopicXML IsNot Nothing Then
                For Each t As Topic In TopicXML.Topics
                    _Topics.Add(t.Code)
                Next
            End If
            Return DirectCast(_Topics.ToArray(GetType(String)), String())
        End Get
    End Property

    Public ReadOnly Property ExportParameters(ByVal sTopic As String) As String()
        Get
            Dim Parameters As New ArrayList
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Export
                        Parameters.Add(p.name)
                    Next
                    Exit For
                End If
            Next
            Return DirectCast(Parameters.ToArray(GetType(String)), String())
        End Get
    End Property

    Public ReadOnly Property ImportParameters(ByVal sTopic As String) As String()
        Get
            Dim Parameters As New ArrayList
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Import
                        Parameters.Add(p.name)
                    Next
                    Exit For
                End If
            Next
            Return DirectCast(Parameters.ToArray(GetType(String)), String())
        End Get
    End Property

    Public ReadOnly Property ExportParameterValues(ByVal sTopic As String, ByVal sParameter As String) As List(Of ParameterValue)
        Get
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Export
                        If p.name.ToLower = sParameter.ToLower AndAlso p.ParameterValues IsNot Nothing _
                         AndAlso p.ParameterValues.multiselect = 0 Then
                            Return p.ParameterValues.Values
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property ExportParameterMultiSelectValues(ByVal sTopic As String, ByVal sParameter As String) As List(Of ParameterValue)
        Get
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Export
                        If p.name.ToLower = sParameter.ToLower AndAlso p.ParameterValues IsNot Nothing _
                         AndAlso p.ParameterValues.multiselect = 1 Then
                            Return p.ParameterValues.Values
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property ImportParameterValues(ByVal sTopic As String, ByVal sParameter As String) As List(Of ParameterValue)
        Get
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Import
                        If p.name.ToLower = sParameter.ToLower AndAlso p.ParameterValues IsNot Nothing _
                         AndAlso p.ParameterValues.multiselect = 0 Then
                            Return p.ParameterValues.Values
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property ImportParameterMultiSelectValues(ByVal sTopic As String, ByVal sParameter As String) As List(Of ParameterValue)
        Get
            For Each t As Topic In TopicXML.Topics
                If t.Code.ToLower = sTopic.ToLower Then
                    For Each p As Parameter In t.Parameters.Import
                        If p.name.ToLower = sParameter.ToLower AndAlso p.ParameterValues IsNot Nothing _
                         AndAlso p.ParameterValues.multiselect = 1 Then
                            Return p.ParameterValues.Values
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Get
    End Property

#End Region

#Region "Public methods"
    'This is needed to not return an error when the https certificate is not valid.
    'Put the following in the form_load:
    'ServicePointManager.Expect100Continue = False
    'ServicePointManager.ServerCertificateValidationCallback = AddressOf <httpData object>.RemoteCertificateValidationCallback

    Public Function RemoteCertificateValidationCallback( _
      ByVal sender As Object, ByVal certificate As X509Certificate, _
      ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean

        Return True

    End Function

    Public Function CreateWebRequest(ByVal Direction As Directions, ByVal txtURL As String, ByVal sDivision As String, _
      ByVal sTopic As String, Optional ByVal sUploadFile As String = "", Optional ByVal applicationKey As String = "", Optional ByVal sTimeStamp As String = "") As HttpWebRequest
        Dim sBaseURL As String = CStr(IIf(Right(txtURL, 1) <> "/", txtURL & "/", txtURL))
        Dim request As HttpWebRequest
        Dim Params() As String

        'IMPORTANT:
        'First set the division to the selected division
        If SetAdministration(txtURL, sDivision) Then

            Dim sProcessURL As String
            sBaseURL = CStr(IIf(Right(txtURL, 1) <> "/", txtURL & "/", txtURL))
            Select Case Direction
                Case Directions.Import
                    sProcessURL = sBaseURL & "Docs/XMLUpload.aspx"
                Case Directions.Export
                    sProcessURL = sBaseURL & "Docs/XMLDownload.aspx"
            End Select
            sProcessURL = sProcessURL & "?Topic=" & sTopic
            sProcessURL = sProcessURL & "&ApplicationKey=" & applicationKey

            If Direction = Directions.Export Then
                sProcessURL = sProcessURL & "&output=1"
                Params = ExportParameters(sTopic)
                If Not IsNothing(Params) Then
                    For i As Integer = 0 To UBound(Params)
                        If Len(frmImporterMain.txtParameters(i).Text) > 0 Then
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(frmImporterMain.txtParameters(i).Text)
                        ElseIf Len(frmImporterMain.cmbParameters(i).SelectedValue) > 0 Then
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(CStr(frmImporterMain.cmbParameters(i).SelectedValue))
                        ElseIf frmImporterMain.clbParameters(i).CheckedItems.Count > 0 Then
                            Dim values As String = ""
                            Dim clb As CheckedListBox = frmImporterMain.clbParameters(i)
                            For Each pv As ParameterValue In clb.CheckedItems()
                                values &= pv.value & ","
                            Next
                            If Len(values) > 0 Then values = Left(values, Len(values) - 1)
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(values)
                        End If
                    Next
                End If
                If Len(sTimeStamp) > 0 Then
                    sProcessURL = sProcessURL & "&TSPaging=" & sTimeStamp
                End If
            Else
                Params = ImportParameters(sTopic)
                If Not IsNothing(Params) Then
                    For i As Integer = 0 To UBound(Params)
                        If Len(frmImporterMain.txtParameters(i).Text) > 0 Then
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(frmImporterMain.txtParameters(i).Text)
                        ElseIf Len(frmImporterMain.cmbParameters(i).SelectedValue) > 0 Then
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(CStr(frmImporterMain.cmbParameters(i).SelectedValue))
                        ElseIf frmImporterMain.clbParameters(i).CheckedItems.Count > 0 Then
                            Dim values As String = ""
                            Dim clb As CheckedListBox = frmImporterMain.clbParameters(i)
                            For Each pv As ParameterValue In clb.CheckedItems()
                                values &= pv.value & ","
                            Next
                            If Len(values) > 0 Then values = Left(values, Len(values) - 1)
                            sProcessURL = sProcessURL & "&" & Params(i) & "=" & HttpUtility.UrlEncode(values)
                        End If
                    Next
                End If
            End If

            request = _CreateWebRequest(Direction, sProcessURL, sUploadFile)
        End If

        Return request
    End Function

    'Log in and retrieve the list of available administrations
    Public Sub GetAdministrations(ByVal txtURL As String, ByRef cmbDivision As ComboBox)
        Dim sURL As String = CStr(IIf(Right(txtURL, 1) <> "/", txtURL & "/", txtURL))

        cmbDivision.DataSource = Nothing
        cmbDivision.Items.Clear()
        Administrations.Clear()


        If Len(txtURL) > 0 Then

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            Dim receiveStream As Stream
            Dim readStream As StreamReader
            Dim xml As XPathDocument

            Try
                'Logging in can be done in two ways:
                ' - query string parameters in the url: "UserName" and "Password" -- OBSOLETE --
                ' - form data: "_UserName_" and "_Password_"

                'NOTE:
                'Logging in by specifying user name and password in the url will not be supported anymore in the near future.
                'For backwards compatibility temporarily still supported.

                Dim bLoginWithFormData As Boolean = True

                Dim sURLDivisions As String = sURL & "Docs/XMLDivisions.aspx"
                If bLoginWithFormData Then
                    'Login with form data.
                    'An extra POST request is needed for this.
                    If Not _Login(sURLDivisions, _
                       "_UserName_=" & HttpUtility.UrlEncode(Credentials.UserName) & _
                       "&_Password_=" & HttpUtility.UrlEncode(Credentials.Password)) Then
                        Throw New Exception("Access denied.")
                    End If
                Else
                    'Obsolete method: login with query string parameters.
                    'This can be done at the same time when retrieving the administrations.
                    sURLDivisions = sURLDivisions & _
                     "?UserName=" & HttpUtility.UrlEncode(Credentials.UserName) & _
                     "&Password=" & HttpUtility.UrlEncode(Credentials.Password)
                End If


                request = _CreateWebRequest(Directions.Export, sURLDivisions)
                If Not IsNothing(request) Then
                    response = CType(request.GetResponse(), HttpWebResponse)
                    receiveStream = response.GetResponseStream()
                    readStream = New StreamReader(receiveStream, Encoding.UTF8)

                    xml = New XPathDocument(readStream)
                    Dim nav As XPathNavigator = xml.CreateNavigator()
                    Dim Admins As XPathNodeIterator = nav.Select("/Administrations/Administration")
                    Dim iCurrentAdmin As Integer = -1

                    If Not IsNothing(Admins) AndAlso Admins.Count > 0 Then

                        Dim iCount As Integer = 0

                        While Admins.MoveNext
                            nav = Admins.Current

                            Administrations.Add(New AdministrationData( _
                             CLng(nav.GetAttribute("Code", String.Empty)), _
                             CLng(nav.GetAttribute("HID", String.Empty)), _
                             CStr(nav.Evaluate("string(Description)"))))

                            'Automatically select the last used division by this user
                            If StrComp(CStr(nav.GetAttribute("Current", String.Empty)), "True", CompareMethod.Text) = 0 Then
                                iCurrentAdmin = iCount
                            End If

                            iCount += 1
                        End While

                    End If
                    cmbDivision.DataSource = Administrations
                    cmbDivision.DisplayMember = "LongDescription"
                    cmbDivision.ValueMember = "Code"
                    If iCurrentAdmin <> -1 Then
                        cmbDivision.SelectedIndex = iCurrentAdmin
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            If Not IsNothing(request) Then request.Abort()
            If Not IsNothing(readStream) Then readStream.Close()
            If Not IsNothing(receiveStream) Then receiveStream.Close()
            If Not IsNothing(response) Then response.Close()
        End If
    End Sub

    Public Function GetMessages(ByVal stream As Stream, ByRef sMessages As String) As Boolean
        Dim xml As New XPathDocument(stream)
        Dim nav As XPathNavigator = xml.CreateNavigator()
        Dim Messages As XPathNodeIterator = nav.Select("/eExact/Messages/Message")
        Dim sType As String
        Dim bErrorsFound As Boolean = False

        If Messages.Count > 0 Then
            While Messages.MoveNext()
                nav = Messages.Current
                sType = nav.GetAttribute("type", String.Empty)

                Dim sTopicNode As String = CStr(nav.Evaluate("string(Topic/@node)"))
                Dim sKey As String = CStr(nav.Evaluate("string(Topic/Data/@key)"))
                If Len(sKey) = 0 Then
                    sKey = CStr(nav.Evaluate("string(Topic/Data/@keyAlt)"))
                End If

                Select Case CInt(sType)
                    Case MessageType.Message    '2
                        'Successful
                    Case MessageType.Warning    '1
                        sMessages = sMessages & "Warning: "
                    Case Else                   'MessageType.Error (0) Or MessageType.Fatal (3)
                        sMessages = sMessages & "Error: "
                        bErrorsFound = True
                End Select

                If Len(sTopicNode & sKey) > 0 Then
                    sMessages = sMessages & _
                     sTopicNode & " " & sKey & ": " & _
                     CStr(nav.Evaluate("string(Description)")) & vbNewLine
                Else
                    sMessages = sMessages & _
                     CStr(nav.Evaluate("string(Description)")) & vbNewLine
                End If
            End While
        End If

        Return bErrorsFound
    End Function

    Public Function GetTimeStamp(ByVal stream As Stream) As String
        Dim xml As New XPathDocument(stream)
        Dim nav As XPathNavigator = xml.CreateNavigator()
        Return CStr(nav.Evaluate("string(/eExact/Topics/Topic/@ts_d)"))
    End Function

    Public Function GetResultCount(ByVal stream As Stream) As Integer
        Dim xml As New XPathDocument(stream)
        Dim nav As XPathNavigator = xml.CreateNavigator()
        Dim sCount As String = CStr(nav.Evaluate("string(/eExact/Topics/Topic/@count)"))
        If Len(sCount) > 0 Then
            Return CInt(sCount)
        Else
            Return 0
        End If
    End Function

    Public Function GetPageSize(ByVal stream As Stream) As Integer
        Dim xml As New XPathDocument(stream)
        Dim nav As XPathNavigator = xml.CreateNavigator()
        Dim sPageSize As String = CStr(nav.Evaluate("string(/eExact/Topics/Topic/@pagesize)"))
        If Len(sPageSize) > 0 Then
            Return CInt(sPageSize)
        Else
            Return 0
        End If
    End Function

    Public Sub SaveAttachments(ByVal sTopic As String, ByVal stream As Stream)
        Dim xml As New XPathDocument(stream)
        Dim nav As XPathNavigator = xml.CreateNavigator()
        Dim nodes As XPathNodeIterator
        Dim nodesExtra As XPathNodeIterator

        Select Case sTopic.ToLower
            Case "accounts"
                nodes = nav.Select("/eExact/Accounts/Account/Image")
                nodesExtra = nav.Select("/eExact/Accounts/Account/Contact/Image")
            Case "invoices"
                nodes = nav.Select("/eExact/Invoices/Invoice/Document/Attachments/Attachment")
            Case "documents", "layouts"
                nodes = nav.Select("/eExact/Documents/Document/Attachments/Attachment")
                nodesExtra = nav.Select("/eExact/Documents/Document/Images/Image")
            Case "items"
                nodes = nav.Select("/eExact/Items/Item/Image")
        End Select

        WalkAttachmentNodes(nodes, nav)
        WalkAttachmentNodes(nodesExtra, nav)
    End Sub

    Private Sub WalkAttachmentNodes(ByVal nodes As XPathNodeIterator, ByRef nav As XPathNavigator)
        If Not IsNothing(nodes) Then
            While nodes.MoveNext()
                nav = nodes.Current()
                Dim sName As String = CStr(nav.Evaluate("string(Name)"))
                If Len(sName) > 0 Then
                    Dim navBinData As XPathNavigator = nav.SelectSingleNode("BinaryData")
                    If Not (navBinData Is Nothing) Then
                        Dim sFile As String = Path.GetFileName(sName)
                        Dim b() As Byte = Convert.FromBase64String(navBinData.InnerXml)
                        If Len(sFile) > 0 AndAlso Not (b Is Nothing) Then
                            If Not File.Exists(sFile) OrElse _
                             MsgBox("File '" & sFile & "' already exists, overwrite?", MsgBoxStyle.YesNoCancel, frmImporterMain.Title) = MsgBoxResult.Yes Then
                                File.WriteAllBytes(sFile, b)

                                System.Diagnostics.Process.Start(sFile)
                            End If
                        End If
                    End If
                End If
            End While
        End If
    End Sub

    Public Function GetDefaultExportFile(ByVal sTopic As String) As String
        Dim di As New DirectoryInfo(".\")
        If Right(di.FullName, 1) = "\" Then
            Return di.FullName & sTopic & ".XML"
        Else
            Return di.FullName & "\" & sTopic & ".XML"
        End If
    End Function

    Public Sub RefreshParameterValues()
        'The topics itself are not dependent on the administration, but the list values are.
        'So a refresh of the parameter values is needed.
        _topicXML = Nothing
    End Sub

#End Region

#Region "Private methods"

	Private Function _Login(ByVal sURL As String, ByVal sFormData As String) As Boolean
		Dim request As HttpWebRequest = CType(WebRequest.Create(sURL), HttpWebRequest)

		If CredentialsChanged Then
			'The credentials are being cached. 
			'So if they have been changed a new cookie container should be created.
			CookieContainer = New System.Net.CookieContainer
			CredentialsChanged = False
		End If

		request.CookieContainer = CookieContainer

		If ProxyServer.UseProxy Then
			If Len(ProxyServer.Port) > 0 Then
				request.Proxy = New WebProxy(ProxyServer.Server, CInt(ProxyServer.Port))
			Else
				request.Proxy = New WebProxy(ProxyServer.Server)
			End If
			If Len(ProxyServer.Credentials.Domain) > 0 Then
				request.Proxy.Credentials = New System.Net.NetworkCredential( _
				 ProxyServer.Credentials.UserName, ProxyServer.Credentials.Password, ProxyServer.Credentials.Domain)
			Else
				request.Proxy.Credentials = New System.Net.NetworkCredential( _
				 ProxyServer.Credentials.UserName, ProxyServer.Credentials.Password)
			End If
		End If

		Dim bFormData As Byte() = Encoding.UTF8.GetBytes(sFormData)

		request.ContentType = "application/x-www-form-urlencoded"
		request.Method = "POST"
		request.AllowWriteStreamBuffering = True

		Dim reqStream As Stream = request.GetRequestStream()
		reqStream.Write(bFormData, 0, bFormData.Length)
		reqStream.Close()

		Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
			If response.StatusCode = HttpStatusCode.OK AndAlso _
			 StrComp(response.ResponseUri.AbsoluteUri, sURL, CompareMethod.Text) = 0 Then
				'Also check if not redirected to another page
				Return True
			Else
				Return False
			End If
		End Using

	End Function

	Private Function SetAdministration(ByVal txtURL As String, ByVal sDivision As String) As Boolean
		Dim sBaseURL As String = CStr(IIf(Right(txtURL, 1) <> "/", txtURL & "/", txtURL))
		Dim sSwitchDivisionPart As String = "Docs/ClearSession.aspx?Division=" & sDivision & "&Remember=3"
		Dim sSwitchDivisionURL As String
		Dim request As HttpWebRequest
		Dim response As HttpWebResponse
		Dim statusOK As Boolean = False
		Dim succeeded As Boolean = False

		sSwitchDivisionURL = sBaseURL & sSwitchDivisionPart
		'The Remember parameter with a value '3' is needed to be able to switch divisions without affecting the last used division,
		'and to do nothing when the division has been switched already to the correct one.
		request = _CreateWebRequest(Directions.Export, sSwitchDivisionURL, , True)
		response = CType(request.GetResponse(), HttpWebResponse)

		If response IsNot Nothing AndAlso response.StatusCode = HttpStatusCode.OK Then
			statusOK = True
		End If

		If request IsNot Nothing Then request.Abort()
		If response IsNot Nothing Then response.Close()

		If statusOK Then
			'Check if the administration has been set successfully.
			request = _CreateWebRequest(Directions.Export, sBaseURL & "Docs/XMLDivisions.aspx")
			response = DirectCast(request.GetResponse(), HttpWebResponse)
			If response IsNot Nothing Then
				Dim xml As New XPathDocument(response.GetResponseStream())
				Dim nav As XPathNavigator = xml.CreateNavigator()
				Dim current As XPathNavigator = nav.SelectSingleNode("/Administrations/Administration[@Current=""True""]")
				If current IsNot Nothing Then
					If StrComp(CStr(current.GetAttribute("Code", String.Empty)), sDivision, CompareMethod.Text) = 0 Then
						succeeded = True
					Else
						Throw New Exception("Invalid administration.")
					End If
				End If
				response.Close()
			End If
			request.Abort()
		End If

		Return succeeded
	End Function

	Private Function _CreateWebRequest(ByVal Direction As Directions, ByVal sURL As String, _
	 Optional ByVal sUploadFile As String = "", Optional ByVal bIgnoreResponseXML As Boolean = False) As HttpWebRequest

		Dim request As HttpWebRequest = CType(WebRequest.Create(sURL), HttpWebRequest)

		If CredentialsChanged Then
			'The credentials are being cached. 
			'So if they have been changed a new cookie container should be created.
			CookieContainer = New System.Net.CookieContainer
			CredentialsChanged = False
		End If

		request.CookieContainer = CookieContainer

		If ProxyServer.UseProxy Then
			If Len(ProxyServer.Port) > 0 Then
				request.Proxy = New WebProxy(ProxyServer.Server, CInt(ProxyServer.Port))
			Else
				request.Proxy = New WebProxy(ProxyServer.Server)
			End If
			If Len(ProxyServer.Credentials.Domain) > 0 Then
				request.Proxy.Credentials = New System.Net.NetworkCredential( _
				 ProxyServer.Credentials.UserName, ProxyServer.Credentials.Password, ProxyServer.Credentials.Domain)
			Else
				request.Proxy.Credentials = New System.Net.NetworkCredential( _
				 ProxyServer.Credentials.UserName, ProxyServer.Credentials.Password)
			End If
		End If

		If Direction = Directions.Import Then
			request.Method = "POST"
			request.AllowWriteStreamBuffering = True

			'Retrieve request stream 
			Dim reqStream As Stream = request.GetRequestStream()

			'Open the local file
			Dim rdr As FileStream = New FileStream(sUploadFile, FileMode.Open)

			'Allocate byte buffer to hold file contents
			Dim inData(4096) As Byte

			'loop through the local file reading each data block
			'and writing to the request stream buffer
			Dim bytesRead As Integer = rdr.Read(inData, 0, inData.Length)
			While bytesRead > 0
				reqStream.Write(inData, 0, bytesRead)
				bytesRead = rdr.Read(inData, 0, inData.Length)
			End While

			rdr.Close()
			reqStream.Close()
		Else
			request.Method = "GET"
		End If

		Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
		If response.StatusCode <> HttpStatusCode.OK Then
			Throw New Exception(response.StatusDescription)
			response.Close()
			Return Nothing
		Else
			If bIgnoreResponseXML Or response.ContentType = "text/xml" Then
				Return request
			Else
				Dim r As New StreamReader(response.GetResponseStream)
				Dim sHtml As String = r.ReadToEnd()
				response.Close()
				Throw New Exception(GetErrorFromHTML(sHtml))

				Return Nothing
			End If
		End If

	End Function

	Private Function GetErrorFromHTML(ByVal shtml As String) As String
		Dim sErrorCode As String = ""

		Dim iPos As Integer = InStr(shtml, "id=""mode""", CompareMethod.Text)
		If iPos > 0 Then
			iPos = InStr(iPos, shtml, "value=""", CompareMethod.Text)
			If iPos > 0 Then
				sErrorCode = Mid(shtml, iPos + 7, InStr(iPos + 7, shtml, """", CompareMethod.Text) - iPos - 7)
			End If
		End If

		Select Case sErrorCode
			Case "0"
				Return "You have insufficient rights to perform this operation."
			Case "8"
				Return "Page requested too many times, please retry in a few moments."
			Case Else
				Return "Response is not xml. " & vbNewLine & _
				 "You might have insufficient rights to perform this operation." & vbNewLine & vbNewLine & shtml
		End Select

	End Function
#End Region

#Region "AdministrationData"

	Private Class AdministrationData
		Private _Code As Long
		Private _HID As Long
		Private _Description As String

		Public Sub New(ByVal Code As Long, ByVal HID As Long, ByVal Description As String)
			_Code = Code
			_HID = HID
			_Description = Description
		End Sub

		Public ReadOnly Property Code() As Long
			Get
				Return _Code
			End Get
		End Property

		Public ReadOnly Property HID() As Long
			Get
				Return _HID
			End Get
		End Property

		Public ReadOnly Property LongDescription() As String
			Get
				Return Right("000000" & _HID, 6) & " - " & _Description
			End Get
		End Property

		Public ReadOnly Property Description() As String
			Get
				Return _Description
			End Get
		End Property

		Public Overrides Function ToString() As String
			Return _Code & " - " & _HID & " - " & _Description
		End Function

	End Class

#End Region

#Region "Credential data"

	Public Class CredentialData
		Public Domain As String
		Public UserName As String
		Public Password As String
	End Class

#End Region

#Region "Proxy server data"

	Public Class ProxyServerData
		Public UseProxy As Boolean = False
		Public Server As String
		Public Port As String
		Public Credentials As New CredentialData
	End Class

#End Region

#Region "Topic / parameter class"

	<XmlRoot("eExact")> _
	  Public Class EOLTopics
		<XmlArray("Topics")> _
		<XmlArrayItem("Topic", GetType(Topic))> _
		Public Topics As New List(Of Topic)
	End Class

	Public Class Topic
		Public Sub New()
		End Sub

		Public Sub New(ByVal code As String)
			Me.Code = code
		End Sub

		<XmlAttribute("code")> _
		Public Code As String

		<XmlElement("Parameters")> _
		Public Parameters As New Parameters
	End Class

	Public Class Parameters
		Public Sub New()
		End Sub

		<XmlArray("Export")> _
		<XmlArrayItem("Parameter", GetType(Parameter))> _
		Public Export As List(Of Parameter)

		<XmlArray("Import")> _
		<XmlArrayItem("Parameter", GetType(Parameter))> _
		Public Import As List(Of Parameter)
	End Class

	Public Class Parameter
		Public Sub New()
		End Sub

		Public Sub New(ByVal name As String, ByVal description As String, ByVal type As String)
			Me.name = name
			Me.description = description
			Me.type = type
		End Sub

		<XmlAttribute("name")> _
		Public name As String

		<XmlAttribute("description")> _
		Public description As String

		<XmlAttribute("type")> _
		Public type As String

		<XmlElement("ParameterValues")> _
		Public ParameterValues As ParameterValuesElement
	End Class

	Public Class ParameterValuesElement
		Public Sub New()
		End Sub

		<XmlAttribute("multiselect")> _
		Public multiselect As Integer = 0

		<XmlElement("ParameterValue")> _
		Public Values As New List(Of ParameterValue)
	End Class

	Public Class ParameterValue
		Public Sub New()
		End Sub

		Public Sub New(ByVal value As String, ByVal description As String)
			Me.value = value
			Me.description = description
		End Sub

		Private _value As String
		<XmlAttribute("value")> _
		Public Property value() As String
			Get
				Return _value
			End Get
			Set(ByVal value As String)
				_value = value
			End Set
		End Property

		Private _description As String
		<XmlAttribute("description")> _
		Public Property description() As String
			Get
				Return _description
			End Get
			Set(ByVal value As String)
				_description = value
			End Set
		End Property
	End Class

#End Region

End Class
