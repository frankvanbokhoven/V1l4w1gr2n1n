Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Xml.XPath
Imports System.Configuration
Imports System.Threading.Thread
'Imports log4net
Imports System.Net.Mail
Imports SendGridWrapper.SendGridWrapper
Imports ExactOnline.Client.OAuth.OAuthClient
Imports ExactOAuth
Imports ExactOAuth.OAuthClient





Public Class frmImporterMain

    'Here is the once-per-class call to initialize the log object
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)


    Public Const Title As String = "Exact Online import/export"
    Private http As New HttpData
    Private RunSilent As Boolean
    Public lblParameters() As Label
    Public txtParameters() As TextBox
    Public cmbParameters() As ComboBox
    Public clbParameters() As CheckedListBox

    'configs tbv mail
    Public mailto As String
    Public mailcc As String
    Public mailfrom As String
    Public mailsubject As String
    Public smtpHost As String
    Public mailusername As String
    Public mailpassword As String

#Region "Events"
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Load het form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ServicePointManager.Expect100Continue = False
        ServicePointManager.ServerCertificateValidationCallback = AddressOf http.RemoteCertificateValidationCallback
        '    log4net.Config.XmlConfigurator.Configure()
        For Each s As String In http.DirectionOptions
            cmbDirection.Items.Add(s)
        Next
        cmbDirection.SelectedIndex = HttpData.Directions.Export


        GetVersionInfo()
        txtFile.Text = http.GetDefaultExportFile(CStr(cmbTopic.SelectedItem))
        txtUploadDir.Text = Path.GetFullPath(".\")
        Try


            txtFile.Text = http.GetDefaultExportFile(CStr(cmbTopic.SelectedItem))
            txtUploadDir.Text = Path.GetFullPath(".\")
            txtUploadDir.Text = ConfigurationManager.AppSettings("XMLDirectoryToBeProcessed").ToString
            txtProcessedDir.Text = ConfigurationManager.AppSettings("XMLDirectoryProcessed")
            txtErrorDir.Text = ConfigurationManager.AppSettings("XMLDirectoryError")
            txtUserName.Text = ConfigurationManager.AppSettings("UserName")
            txtPassword.Text = ConfigurationManager.AppSettings("Password")
            '       txtApplicationKey.Text = ConfigurationManager.AppSettings("ApplicationKey")
            txtURL.Text = ConfigurationManager.AppSettings("ExactOnlineUrl")
            Dim division As String = ConfigurationManager.AppSettings("AdministrationDescription")
            Dim divisionValue As String = ConfigurationManager.AppSettings("Administration")
            RunSilent = ConfigurationManager.AppSettings("RunAutomatic").ToLower = "true" ' draai de app op de achtergrond als RunAutomatic op true staat

            '      ConfigurationManager.AppSettings("mailto")
            'tbv mail
            mailto = ConfigurationManager.AppSettings("mailto")
            mailcc = ConfigurationManager.AppSettings("mailcc")
            mailfrom = ConfigurationManager.AppSettings("mailfrom")
            mailsubject = ConfigurationManager.AppSettings("mailsubject")
            smtpHost = ConfigurationManager.AppSettings("smtphost")
            mailusername = ConfigurationManager.AppSettings("mailusername")
            mailpassword = ConfigurationManager.AppSettings("mailpassword")
            TabImportExport.SelectedTab = TabMultiple

            'hierzelfde als in refresh
            InitAdministrations()

        Catch ex As Exception
            '  Dim errstr As String = ex.Message
            '      log.Error(ex.Message)
            '   SendMail(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        InitAdministrations()
    End Sub
    Private Sub InitAdministrations()
        http.CredentialsChanged = True  'to get a fresh list of administrations
        RetrieveAdministrations()
        FillTopics()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        StartImport()
    End Sub

    Private Sub StartImport()
        If Len(txtURL.Text) = 0 Then
            '   MsgBox("Please fill in the URL, for example https://start.exactonline.nl.", , Title)
        Else
            If cmbDivision.Items.Count = 0 Then
                RetrieveAdministrations()
                FillTopics()
                ShowParameters()

                '   MsgBox("First select an administration.", , Title)
            Else
                If Len(cmbDivision.SelectedValue) = 0 Then
                    '      MsgBox("First select an administration.", , Title)
                Else
                    If TabImportExport.SelectedTab.Name = TabSingle.Name Then
                        If Len(cmbTopic.SelectedItem) = 0 Then
                            '          MsgBox("Mandatory: topic.", , Title)
                        Else
                            If cmbDirection.SelectedIndex = HttpData.Directions.Import AndAlso Len(txtFile.Text) = 0 Then
                                '             MsgBox("Mandatory: file to be uploaded.", , Title)
                            Else
                                '  // ProcessSingle()
                            End If
                        End If
                    ElseIf TabImportExport.SelectedTab.Name = TabMultiple.Name Then
                        If Len(txtUploadDir.Text) = 0 Then
                            '    MsgBox("Mandatory: directory containing the files to be uploaded.", , Title)
                        Else
                            ProcessMultiple()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub chkProxy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProxy.CheckedChanged
        If chkProxy.Checked Then
            gbProxy.Height = 109
            gbMain.Top = gbMain.Top + 59
            TabImportExport.Top = TabImportExport.Top + 59
            btnStart.Top = btnStart.Top + 59
            btnCancel.Top = btnCancel.Top + 59
            Me.Height = Me.Height + 79

            lblProxyServer.Visible = True
            txtProxyServer.Visible = True
            lblDomainProxy.Visible = True
            txtDomainProxy.Visible = True
            lblPort.Visible = True
            txtPort.Visible = True
            lblUserNameProxy.Visible = True
            txtUserNameProxy.Visible = True
            lblPasswordProxy.Visible = True
            txtPasswordProxy.Visible = True
        Else
            gbProxy.Height = 50
            gbMain.Top = gbMain.Top - 39
            TabImportExport.Top = TabImportExport.Top - 59
            btnStart.Top = btnStart.Top - 59
            btnCancel.Top = btnCancel.Top - 59
            Me.Height = Me.Height - 79

            lblProxyServer.Visible = False
            txtProxyServer.Visible = False
            lblDomainProxy.Visible = False
            txtDomainProxy.Visible = False
            lblPort.Visible = False
            txtPort.Visible = False
            lblUserNameProxy.Visible = False
            txtUserNameProxy.Visible = False
            lblPasswordProxy.Visible = False
            txtPasswordProxy.Visible = False
        End If
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtProxyServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProxyServer.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtDomainProxy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDomainProxy.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtUserNameProxy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserNameProxy.TextChanged
        http.CredentialsChanged = True
    End Sub

    Private Sub txtPasswordProxy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordProxy.TextChanged
        http.CredentialsChanged = True
    End Sub
#End Region

#Region "Private functions"
    'Set credentials for the web request
    Private Sub SetCredentials()
        http.Credentials.Domain = "" 'Not used
        http.Credentials.UserName = txtUserName.Text
        http.Credentials.Password = txtPassword.Text

        http.ProxyServer.UseProxy = chkProxy.Checked
        http.ProxyServer.Server = txtProxyServer.Text
        http.ProxyServer.Port = txtPort.Text
        http.ProxyServer.Credentials.Domain = txtDomainProxy.Text
        http.ProxyServer.Credentials.UserName = txtUserNameProxy.Text
        http.ProxyServer.Credentials.Password = txtPasswordProxy.Text
    End Sub

    'Fill admininistration combobox
    Private Sub RetrieveAdministrations()
        Me.Cursor = Cursors.WaitCursor
        SetCredentials()
        Try
            http.GetAdministrations(txtURL.Text, cmbDivision)
        Catch ex As Exception
            MsgBox(ex.Message, , Title)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FillTopics()
        cmbTopic.Items.Clear()
        Try
            For Each s As String In http.Topics
                cmbTopic.Items.Add(s)
            Next
            If cmbTopic.Items.Count > 0 Then cmbTopic.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, , Title)
        End Try
    End Sub



    'Main process for uploading multiple files
    Private Sub ProcessMultiple()
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        Dim receiveStream As Stream
        Dim readStream As StreamReader
        Dim sSummary As String = ""
        Dim sMessages As String = ""
        Dim bSomethingToUpload As Boolean = False

        If Not Directory.Exists(txtUploadDir.Text) Then
            MsgBox("Directory doesn't exist.", , Title)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim filename As String

        Try

            SetCredentials()
            Dim sUploadDirectory As String = txtUploadDir.Text
            If Microsoft.VisualBasic.Right(sUploadDirectory, 1) <> "\" Then sUploadDirectory = sUploadDirectory & "\"
            Dim filecounter As Integer = 0 'deze is nodig, om bij te houden hoe veel files er per minuut geupload worden
            Dim somethingprocessed As Boolean = False
            For Each sFile As String In Directory.GetFiles(sUploadDirectory, "*.xml")
                Try
                    somethingprocessed = True
                    If (filecounter Mod 20 = 0) And (filecounter > 0) Then
                        Sleep(60000)
                    End If
                    filecounter += 1
                    filename = sFile
                    Dim xml As New XPathDocument(sFile)
                    Dim nav As XPathNavigator = xml.CreateNavigator()
                    Dim Topic As XPathNavigator = nav.SelectSingleNode("eExact/*")
                    Dim sTopic As String = ""
                    Dim sMessage As String = ""
                    Dim bErrorsFound As Boolean

                    If Not IsNothing(Topic) Then
                        sTopic = Topic.Name
                        Dim applicationkey As String = ConfigurationManager.AppSettings("ApplicationKey")
                        If Len(sTopic) > 0 AndAlso Array.IndexOf(http.Topics, sTopic) >= 0 Then
                            bSomethingToUpload = True
                            'maak hier het webrequest en verzend het.
                            request = http.CreateWebRequest(HttpData.Directions.Import, txtURL.Text,
                             CStr(cmbDivision.SelectedValue), sTopic, sFile, applicationkey)

                            If Not IsNothing(request) Then
                                response = CType(request.GetResponse(), HttpWebResponse)
                                receiveStream = response.GetResponseStream()

                                sSummary = sSummary & Microsoft.VisualBasic.Left(sFile & Space(100), 100)
                                bErrorsFound = http.GetMessages(receiveStream, sMessage)
                                If bErrorsFound Then
                                    sSummary = sSummary & " Errors" & vbNewLine
                                Else
                                    sSummary = sSummary & " OK" & vbNewLine
                                End If

                                sMessages = sMessages & "Details " & sFile & ":" &
                                 vbNewLine & sMessage & vbNewLine & vbNewLine
                                'als er een melding wordt teruggemeld vanuit exact, mail hem dan, zodat ernaar gehandeld kan worden
                                If (sMessage.ToLower().Contains("error")) Or (sMessage.ToLower().Contains("warning")) Or (sMessage.ToLower().Contains("problem")) Then
                                    SendMail(mailto, "Veluwegranen", "File: " & sFile, sMessage, mailfrom)
                                    System.Threading.Thread.Sleep(3000)
                                End If
                            End If
                        Else
                            sSummary = sSummary & Microsoft.VisualBasic.Left(sFile & Space(100), 100) & " No xml topic found" & vbNewLine
                        End If
                    End If
                    '' if the http status is something else than 'OK' OR the message contains the word error then move the file to the error directory
                    If (response.StatusDescription.ToUpper() <> "OK") Or (sMessage.ToLower().Contains("error")) Then
                        ' move the file to the processed directory
                        File.Move(sFile, Path.Combine(txtErrorDir.Text, Path.GetFileName(sFile)))
                    Else
                        ' move the file to the processed directory
                        File.Move(sFile, Path.Combine(txtProcessedDir.Text, Path.GetFileName(sFile)))
                    End If
                Catch ex As Exception
                    '  MsgBox("Error in method ProcessMultiple: " & ex.Message, , Title)
                    File.Move(filename, Path.Combine(txtErrorDir.Text, Path.GetFileName(filename)))
                    SendMail(mailto, "Veluwegranen", "Process file fout: " & Path.GetFileName(filename), "Exact Online Import error at processing XML Import file" & ex.Message, mailfrom)
                    System.Threading.Thread.Sleep(3000)
                End Try
            Next
            '' alleen als er  wat geprocessed is, hoeft er een mail gestuurd te worden.
            If (somethingprocessed = True) Then
                SendMail(mailto, "VeluweGranen", "Process summary " & DateTime.Now.ToString("dd/MMM/yyyy hh:mm"), "These files have been processed on " &
              DateTime.Now.ToString("dd/MMM/yyyy hh:mm") & Environment.NewLine & Environment.NewLine & sSummary, mailfrom)
            End If
            ''   System.Threading.Thread.Sleep(3000)
        Catch ex As Exception
            SendMail(mailto, "Veluwegranen", "This run encountered a problem.", "Exact Online Import problem" & ex.Message, mailfrom)
            System.Threading.Thread.Sleep(3000)
        End Try

        Me.Cursor = Cursors.Default
        If bSomethingToUpload Then 'alleen als runsilent false is, mag het dialog getoond worden
            dlgMessages.txtMessages.Text = sSummary & vbNewLine & vbNewLine & sMessages
            If Not RunSilent Then
                dlgMessages.ShowDialog()
            End If
        Else
            '  MsgBox("No xml files found which can be uploaded.", , Title)
        End If

        If Not IsNothing(request) Then request.Abort()
        If Not IsNothing(readStream) Then readStream.Close()
        If Not IsNothing(receiveStream) Then receiveStream.Close()
        If Not IsNothing(response) Then response.Close()

    End Sub

    ''' <summary>
    ''' Toon de versieinformatie
    ''' </summary>
    ''' <returns></returns>
    Private Function GetVersionInfo() As String

        Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location)
        Dim version As String = fvi.FileVersion

        Dim assemblyVersion As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
        Me.Text = String.Format("Exact online import/export: {0} / {1}", assemblyVersion, version)

        Return Me.Text
    End Function

    Private Sub ShowParameters()
        If cmbTopic.SelectedItem Is Nothing Then Return

        Try
            Dim i As Integer

            gbParameters.Height = 55
            btnStart.Top = 484
            btnCancel.Top = 484
            TabImportExport.Height = 216
            Me.Height = 536

            Dim Params() As String
            If cmbDirection.SelectedIndex = HttpData.Directions.Export Then
                Params = http.ExportParameters(CStr(cmbTopic.SelectedItem))
            ElseIf cmbDirection.SelectedIndex = HttpData.Directions.Import Then
                Params = http.ImportParameters(CStr(cmbTopic.SelectedItem))
            End If

            If Not IsNothing(txtParameters) Then
                For i = 0 To UBound(txtParameters)
                    lblParameters(i).Visible = False
                    txtParameters(i).Visible = False
                    txtParameters(i).Text = ""
                Next
            End If

            If Not IsNothing(cmbParameters) Then
                For i = 0 To UBound(cmbParameters)
                    cmbParameters(i).Visible = False
                    cmbParameters(i).DataSource = Nothing
                    cmbParameters(i).Items.Clear()
                Next
            End If

            If Not IsNothing(clbParameters) Then
                For i = 0 To UBound(clbParameters)
                    clbParameters(i).Visible = False
                    clbParameters(i).DataSource = Nothing
                    clbParameters(i).Items.Clear()
                Next
            End If

            If Not IsNothing(Params) Then
                ReDim lblParameters(UBound(Params))
                ReDim txtParameters(UBound(Params))
                ReDim cmbParameters(UBound(Params))
                ReDim clbParameters(UBound(Params))

                Dim iShiftSize As Integer = 0

                For i = 0 To UBound(Params)
                    Dim values As List(Of HttpData.ParameterValue)
                    Dim multivalues As List(Of HttpData.ParameterValue)

                    If cmbDirection.SelectedIndex = HttpData.Directions.Export Then
                        values = http.ExportParameterValues(CStr(cmbTopic.SelectedItem), Params(i))
                        multivalues = http.ExportParameterMultiSelectValues(CStr(cmbTopic.SelectedItem), Params(i))
                    ElseIf cmbDirection.SelectedIndex = HttpData.Directions.Import Then
                        values = http.ImportParameterValues(CStr(cmbTopic.SelectedItem), Params(i))
                        multivalues = http.ImportParameterMultiSelectValues(CStr(cmbTopic.SelectedItem), Params(i))
                    End If

                    lblParameters(i) = New Label
                    txtParameters(i) = New TextBox

                    cmbParameters(i) = New ComboBox
                    cmbParameters(i).DropDownStyle = ComboBoxStyle.DropDownList

                    clbParameters(i) = New CheckedListBox
                    clbParameters(i).CheckOnClick = True
                    clbParameters(i).MultiColumn = True
                    clbParameters(i).ColumnWidth = 150

                    lblParameters(i).Parent = gbParameters
                    txtParameters(i).Parent = gbParameters
                    cmbParameters(i).Parent = gbParameters
                    clbParameters(i).Parent = gbParameters

                    lblParameters(i).Left = 10
                    lblParameters(i).Width = 165
                    txtParameters(i).Left = 184
                    txtParameters(i).Width = 313
                    cmbParameters(i).Left = 184
                    cmbParameters(i).Width = 313
                    clbParameters(i).Left = 184
                    clbParameters(i).Width = 313
                    clbParameters(i).Height = 52

                    lblParameters(i).Text = Params(i)
                    lblParameters(i).Visible = True
                    If values IsNot Nothing AndAlso values.Count > 0 Then
                        txtParameters(i).Visible = False
                        clbParameters(i).Visible = False

                        cmbParameters(i).DataSource = values
                        cmbParameters(i).DisplayMember = "description"
                        cmbParameters(i).ValueMember = "value"
                        cmbParameters(i).Visible = True
                    ElseIf multivalues IsNot Nothing AndAlso multivalues.Count > 0 Then
                        txtParameters(i).Visible = False
                        cmbParameters(i).Visible = False

                        clbParameters(i).DataSource = multivalues
                        clbParameters(i).DisplayMember = "description"
                        clbParameters(i).ValueMember = "value"
                        clbParameters(i).Visible = True
                    Else
                        cmbParameters(i).Visible = False
                        clbParameters(i).Visible = False

                        txtParameters(i).Visible = True
                    End If

                    If i > 0 Then
                        iShiftSize += 24
                        Dim iExtraShift As Integer = 0
                        If clbParameters(i - 1).Visible Then
                            iExtraShift = clbParameters(i - 1).Height - 20
                            iShiftSize += iExtraShift
                        End If
                        lblParameters(i).Top = lblParameters(i - 1).Top + 24 + iExtraShift
                        txtParameters(i).Top = txtParameters(i - 1).Top + 24 + iExtraShift
                        cmbParameters(i).Top = cmbParameters(i - 1).Top + 24 + iExtraShift
                        clbParameters(i).Top = clbParameters(i - 1).Top + 24 + iExtraShift
                        txtParameters(i).TabIndex = txtParameters(i - 1).TabIndex + 1
                        cmbParameters(i).TabIndex = cmbParameters(i - 1).TabIndex + 1
                        clbParameters(i).TabIndex = clbParameters(i - 1).TabIndex + 1

                        If txtParameters(i).Visible Then
                            btnStart.TabIndex = txtParameters(i).TabIndex + 1
                        ElseIf cmbParameters(i).Visible Then
                            btnStart.TabIndex = cmbParameters(i).TabIndex + 1
                        ElseIf clbParameters(i).Visible Then
                            btnStart.TabIndex = clbParameters(i).TabIndex + 1
                        End If

                        btnCancel.TabIndex = btnStart.TabIndex + 1
                    Else
                        lblParameters(i).Top = 20
                        txtParameters(i).Top = 20
                        cmbParameters(i).Top = 20
                        clbParameters(i).Top = 20
                        txtParameters(i).TabIndex = btnSelectFile.TabIndex + 1
                        cmbParameters(i).TabIndex = btnSelectFile.TabIndex + 1
                        clbParameters(i).TabIndex = btnSelectFile.TabIndex + 1
                    End If
                Next
                gbParameters.Height += iShiftSize
                btnStart.Top += iShiftSize
                btnCancel.Top += iShiftSize
                TabImportExport.Height += iShiftSize
                Me.Height += iShiftSize + 30
            End If
        Catch ex As Exception
            SendMail(mailto, "Veluwegranen", "Error met exactonline importer", "Exact Online Import error at processing XML Import file. Something is wrond with parameters" & ex.Message, "mailfrom")
        End Try
    End Sub

#End Region

    Private Sub cmbTopic_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTopic.SelectedIndexChanged
        If cmbTopic.SelectedItem IsNot Nothing Then
            If cmbDirection.SelectedIndex = HttpData.Directions.Export Then
                txtFile.Text = http.GetDefaultExportFile(CStr(cmbTopic.SelectedItem))
            End If
            ShowParameters()
        End If
    End Sub

    Private Sub cmbDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDirection.SelectedIndexChanged
        If cmbDirection.SelectedIndex = HttpData.Directions.Export Then
            txtFile.Text = http.GetDefaultExportFile(CStr(cmbTopic.SelectedItem))
        End If
        ShowParameters()
    End Sub

    Private Sub btnSelectFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectFile.Click
        If dlgFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtFile.Text = dlgFile.FileName
        End If
    End Sub

    Private Sub btnSelectDir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectDir.Click
        If dlgDir.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtUploadDir.Text = dlgDir.SelectedPath
        End If
    End Sub

    Private Sub txtUploadDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUploadDir.TextChanged
        If Directory.Exists(txtUploadDir.Text) Then
            dlgDir.SelectedPath = txtUploadDir.Text
        End If
    End Sub

    Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile.TextChanged
        If Len(txtFile.Text) > 0 Then
            Dim sDir As String
            If StrComp(Microsoft.VisualBasic.Right(txtFile.Text, 4), ".xml", CompareMethod.Text) = 0 Then
                sDir = Path.GetDirectoryName(txtFile.Text)
            Else
                sDir = txtFile.Text
            End If
            If Directory.Exists(sDir) Then
                dlgFile.InitialDirectory = sDir
            End If
        End If
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If cmbDivision.SelectedValue IsNot Nothing Then
            http.RefreshParameterValues()
            ShowParameters()
        End If
    End Sub

    Private Sub frmDemo_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover

    End Sub

    Private Sub frmDemo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ''    dit programma kan ook geheel automatisch lopen, dat kan alleen als 'runautomatic' op true staat en alle benodigde parameters zijn ingevuld
        If (ConfigurationManager.AppSettings("RunAutomatic").ToLower = "true") Then
            RunSilent = True
            If (txtUploadDir.Text.Length > 0 And txtProcessedDir.Text.Length > 0 And txtErrorDir.Text.Length > 0 And txtUserName.Text.Length > 0 And txtPassword.Text.Length > 0 And txtURL.Text.Length > 0) Then
                TabImportExport.SelectedTab = TabMultiple
                Try
                    StartImport()
                Catch ex As Exception

                Finally
                    Application.Exit() 'na een sucesvolle run, sluit de applicatie
                End Try

            End If
        Else
            RunSilent = False
        End If
    End Sub

    ''' <summary>
    ''' Invoke the oauth login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOauth_Click(sender As Object, e As EventArgs) Handles btnOauth.Click

        Dim dr As DotNetOpenAuth.OAuth2.AuthorizationServerDescription
        dr = New DotNetOpenAuth.OAuth2.AuthorizationServerDescription

        Dim asd As DotNetOpenAuth.OAuth2.AuthorizationServerDescription
        asd.AuthorizationEndpoint = New Uri("https://start.exactonline.nl/api/oauth2/auth")
        asd.TokenEndpoint = New Uri("https://start.exactonline.nl/oauth2/token")

        Dim oc As OAuthClient = New OAuthClient(asd, "{cb715f5d-fe30-4595-81ff-c00b414a73e2", "dtsaOssnJJhY", New Uri("http://www.veluwegranen.nl"))

        '  Dim ur As Uri = New Uri("test/fds")
        '   Dim loginfrm As ExactOnline.Client.OAuth.OAuthClient = New ExactOnline.Client.OAuth.OAuthClient(dr, "id", "secret", ur)
        '  Dim state As DotNetOpenAuth.OAuth2.IAuthorizationState
        ' //   loginfrm.Authorize(state, "secret")





    End Sub



End Class

