<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImporterMain
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImporterMain))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbCredentials = New System.Windows.Forms.GroupBox()
        Me.txtApplicationKey = New System.Windows.Forms.TextBox()
        Me.lblApplicationKey = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.gbProxy = New System.Windows.Forms.GroupBox()
        Me.lblPasswordProxy = New System.Windows.Forms.Label()
        Me.txtPasswordProxy = New System.Windows.Forms.TextBox()
        Me.lblUserNameProxy = New System.Windows.Forms.Label()
        Me.txtUserNameProxy = New System.Windows.Forms.TextBox()
        Me.lblDomainProxy = New System.Windows.Forms.Label()
        Me.txtDomainProxy = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblProxyServer = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtProxyServer = New System.Windows.Forms.TextBox()
        Me.chkProxy = New System.Windows.Forms.CheckBox()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog()
        Me.TabImportExport = New System.Windows.Forms.TabControl()
        Me.TabSingle = New System.Windows.Forms.TabPage()
        Me.gbSingle = New System.Windows.Forms.GroupBox()
        Me.chkOpenAttachments = New System.Windows.Forms.CheckBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblTopic = New System.Windows.Forms.Label()
        Me.cmbTopic = New System.Windows.Forms.ComboBox()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.cmbDirection = New System.Windows.Forms.ComboBox()
        Me.gbParameters = New System.Windows.Forms.GroupBox()
        Me.TabMultiple = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtProcessedDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtErrorDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbMultiple = New System.Windows.Forms.GroupBox()
        Me.btnSelectDir = New System.Windows.Forms.Button()
        Me.txtUploadDir = New System.Windows.Forms.TextBox()
        Me.lblUploadDir = New System.Windows.Forms.Label()
        Me.dlgDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOauth = New System.Windows.Forms.Button()
        Me.gbCredentials.SuspendLayout()
        Me.gbProxy.SuspendLayout()
        Me.gbMain.SuspendLayout()
        Me.TabImportExport.SuspendLayout()
        Me.TabSingle.SuspendLayout()
        Me.gbSingle.SuspendLayout()
        Me.TabMultiple.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbMultiple.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Location = New System.Drawing.Point(532, 652)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 28)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(637, 652)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbCredentials
        '
        Me.gbCredentials.Controls.Add(Me.btnOauth)
        Me.gbCredentials.Controls.Add(Me.txtApplicationKey)
        Me.gbCredentials.Controls.Add(Me.lblApplicationKey)
        Me.gbCredentials.Controls.Add(Me.lblPassword)
        Me.gbCredentials.Controls.Add(Me.txtPassword)
        Me.gbCredentials.Controls.Add(Me.txtUserName)
        Me.gbCredentials.Controls.Add(Me.lblUserName)
        Me.gbCredentials.Location = New System.Drawing.Point(9, 9)
        Me.gbCredentials.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbCredentials.Name = "gbCredentials"
        Me.gbCredentials.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbCredentials.Size = New System.Drawing.Size(733, 134)
        Me.gbCredentials.TabIndex = 1
        Me.gbCredentials.TabStop = False
        Me.gbCredentials.Text = "Credentials"
        '
        'txtApplicationKey
        '
        Me.txtApplicationKey.Location = New System.Drawing.Point(259, 94)
        Me.txtApplicationKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApplicationKey.Name = "txtApplicationKey"
        Me.txtApplicationKey.Size = New System.Drawing.Size(283, 22)
        Me.txtApplicationKey.TabIndex = 7
        Me.txtApplicationKey.Visible = False
        '
        'lblApplicationKey
        '
        Me.lblApplicationKey.AutoSize = True
        Me.lblApplicationKey.Location = New System.Drawing.Point(27, 97)
        Me.lblApplicationKey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApplicationKey.Name = "lblApplicationKey"
        Me.lblApplicationKey.Size = New System.Drawing.Size(103, 17)
        Me.lblApplicationKey.TabIndex = 38
        Me.lblApplicationKey.Text = "Application key"
        Me.lblApplicationKey.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(27, 65)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 37
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(259, 62)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(283, 22)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(259, 28)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(283, 22)
        Me.txtUserName.TabIndex = 5
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(27, 32)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 17)
        Me.lblUserName.TabIndex = 36
        Me.lblUserName.Text = "User name"
        '
        'gbProxy
        '
        Me.gbProxy.Controls.Add(Me.lblPasswordProxy)
        Me.gbProxy.Controls.Add(Me.txtPasswordProxy)
        Me.gbProxy.Controls.Add(Me.lblUserNameProxy)
        Me.gbProxy.Controls.Add(Me.txtUserNameProxy)
        Me.gbProxy.Controls.Add(Me.lblDomainProxy)
        Me.gbProxy.Controls.Add(Me.txtDomainProxy)
        Me.gbProxy.Controls.Add(Me.lblPort)
        Me.gbProxy.Controls.Add(Me.lblProxyServer)
        Me.gbProxy.Controls.Add(Me.txtPort)
        Me.gbProxy.Controls.Add(Me.txtProxyServer)
        Me.gbProxy.Controls.Add(Me.chkProxy)
        Me.gbProxy.Location = New System.Drawing.Point(9, 523)
        Me.gbProxy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbProxy.Name = "gbProxy"
        Me.gbProxy.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbProxy.Size = New System.Drawing.Size(733, 126)
        Me.gbProxy.TabIndex = 2
        Me.gbProxy.TabStop = False
        Me.gbProxy.Text = "Proxy server"
        Me.gbProxy.Visible = False
        '
        'lblPasswordProxy
        '
        Me.lblPasswordProxy.AutoSize = True
        Me.lblPasswordProxy.Location = New System.Drawing.Point(424, 95)
        Me.lblPasswordProxy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswordProxy.Name = "lblPasswordProxy"
        Me.lblPasswordProxy.Size = New System.Drawing.Size(69, 17)
        Me.lblPasswordProxy.TabIndex = 34
        Me.lblPasswordProxy.Text = "Password"
        Me.lblPasswordProxy.Visible = False
        '
        'txtPasswordProxy
        '
        Me.txtPasswordProxy.Location = New System.Drawing.Point(564, 91)
        Me.txtPasswordProxy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPasswordProxy.Name = "txtPasswordProxy"
        Me.txtPasswordProxy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordProxy.Size = New System.Drawing.Size(111, 22)
        Me.txtPasswordProxy.TabIndex = 13
        Me.txtPasswordProxy.UseSystemPasswordChar = True
        Me.txtPasswordProxy.WordWrap = False
        '
        'lblUserNameProxy
        '
        Me.lblUserNameProxy.AutoSize = True
        Me.lblUserNameProxy.Location = New System.Drawing.Point(424, 64)
        Me.lblUserNameProxy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserNameProxy.Name = "lblUserNameProxy"
        Me.lblUserNameProxy.Size = New System.Drawing.Size(77, 17)
        Me.lblUserNameProxy.TabIndex = 33
        Me.lblUserNameProxy.Text = "User name"
        Me.lblUserNameProxy.Visible = False
        '
        'txtUserNameProxy
        '
        Me.txtUserNameProxy.Location = New System.Drawing.Point(564, 59)
        Me.txtUserNameProxy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserNameProxy.Name = "txtUserNameProxy"
        Me.txtUserNameProxy.Size = New System.Drawing.Size(111, 22)
        Me.txtUserNameProxy.TabIndex = 12
        Me.txtUserNameProxy.Visible = False
        '
        'lblDomainProxy
        '
        Me.lblDomainProxy.AutoSize = True
        Me.lblDomainProxy.Location = New System.Drawing.Point(424, 34)
        Me.lblDomainProxy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDomainProxy.Name = "lblDomainProxy"
        Me.lblDomainProxy.Size = New System.Drawing.Size(56, 17)
        Me.lblDomainProxy.TabIndex = 35
        Me.lblDomainProxy.Text = "Domain"
        Me.lblDomainProxy.Visible = False
        '
        'txtDomainProxy
        '
        Me.txtDomainProxy.Location = New System.Drawing.Point(564, 31)
        Me.txtDomainProxy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomainProxy.Name = "txtDomainProxy"
        Me.txtDomainProxy.Size = New System.Drawing.Size(111, 22)
        Me.txtDomainProxy.TabIndex = 11
        Me.txtDomainProxy.Visible = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(27, 97)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(34, 17)
        Me.lblPort.TabIndex = 37
        Me.lblPort.Text = "Port"
        Me.lblPort.Visible = False
        '
        'lblProxyServer
        '
        Me.lblProxyServer.AutoSize = True
        Me.lblProxyServer.Location = New System.Drawing.Point(27, 64)
        Me.lblProxyServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProxyServer.Name = "lblProxyServer"
        Me.lblProxyServer.Size = New System.Drawing.Size(87, 17)
        Me.lblProxyServer.TabIndex = 36
        Me.lblProxyServer.Text = "Proxy server"
        Me.lblProxyServer.Visible = False
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(259, 91)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(51, 22)
        Me.txtPort.TabIndex = 10
        Me.txtPort.Visible = False
        '
        'txtProxyServer
        '
        Me.txtProxyServer.Location = New System.Drawing.Point(259, 59)
        Me.txtProxyServer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProxyServer.Name = "txtProxyServer"
        Me.txtProxyServer.Size = New System.Drawing.Size(99, 22)
        Me.txtProxyServer.TabIndex = 9
        Me.txtProxyServer.Visible = False
        '
        'chkProxy
        '
        Me.chkProxy.AutoSize = True
        Me.chkProxy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkProxy.Location = New System.Drawing.Point(31, 31)
        Me.chkProxy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProxy.Name = "chkProxy"
        Me.chkProxy.Size = New System.Drawing.Size(137, 21)
        Me.chkProxy.TabIndex = 8
        Me.chkProxy.Text = "Use proxy server"
        Me.chkProxy.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkProxy.UseVisualStyleBackColor = True
        '
        'gbMain
        '
        Me.gbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbMain.Controls.Add(Me.lblURL)
        Me.gbMain.Controls.Add(Me.txtURL)
        Me.gbMain.Controls.Add(Me.btnRefresh)
        Me.gbMain.Controls.Add(Me.lblDivision)
        Me.gbMain.Controls.Add(Me.cmbDivision)
        Me.gbMain.Location = New System.Drawing.Point(9, 150)
        Me.gbMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMain.Size = New System.Drawing.Size(733, 92)
        Me.gbMain.TabIndex = 3
        Me.gbMain.TabStop = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(27, 28)
        Me.lblURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(36, 17)
        Me.lblURL.TabIndex = 18
        Me.lblURL.Text = "URL"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(259, 23)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(416, 22)
        Me.txtURL.TabIndex = 14
        Me.txtURL.Text = "https://start.exactonline.nl"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.Location = New System.Drawing.Point(684, 23)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(29, 27)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Location = New System.Drawing.Point(27, 60)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(97, 17)
        Me.lblDivision.TabIndex = 12
        Me.lblDivision.Text = "Administration"
        '
        'cmbDivision
        '
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(259, 55)
        Me.cmbDivision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(416, 24)
        Me.cmbDivision.TabIndex = 16
        '
        'dlgFile
        '
        Me.dlgFile.CheckFileExists = False
        Me.dlgFile.InitialDirectory = ".\"
        '
        'TabImportExport
        '
        Me.TabImportExport.Controls.Add(Me.TabSingle)
        Me.TabImportExport.Controls.Add(Me.TabMultiple)
        Me.TabImportExport.Location = New System.Drawing.Point(9, 250)
        Me.TabImportExport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabImportExport.Name = "TabImportExport"
        Me.TabImportExport.SelectedIndex = 0
        Me.TabImportExport.Size = New System.Drawing.Size(733, 266)
        Me.TabImportExport.TabIndex = 25
        '
        'TabSingle
        '
        Me.TabSingle.BackColor = System.Drawing.Color.Transparent
        Me.TabSingle.Controls.Add(Me.gbSingle)
        Me.TabSingle.Controls.Add(Me.gbParameters)
        Me.TabSingle.Location = New System.Drawing.Point(4, 25)
        Me.TabSingle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabSingle.Name = "TabSingle"
        Me.TabSingle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabSingle.Size = New System.Drawing.Size(725, 237)
        Me.TabSingle.TabIndex = 0
        Me.TabSingle.Text = "Single upload/download"
        '
        'gbSingle
        '
        Me.gbSingle.Controls.Add(Me.chkOpenAttachments)
        Me.gbSingle.Controls.Add(Me.btnSelectFile)
        Me.gbSingle.Controls.Add(Me.txtFile)
        Me.gbSingle.Controls.Add(Me.lblFile)
        Me.gbSingle.Controls.Add(Me.lblTopic)
        Me.gbSingle.Controls.Add(Me.cmbTopic)
        Me.gbSingle.Controls.Add(Me.lblDirection)
        Me.gbSingle.Controls.Add(Me.cmbDirection)
        Me.gbSingle.Location = New System.Drawing.Point(8, 7)
        Me.gbSingle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSingle.Name = "gbSingle"
        Me.gbSingle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSingle.Size = New System.Drawing.Size(707, 143)
        Me.gbSingle.TabIndex = 26
        Me.gbSingle.TabStop = False
        '
        'chkOpenAttachments
        '
        Me.chkOpenAttachments.AutoSize = True
        Me.chkOpenAttachments.Location = New System.Drawing.Point(244, 114)
        Me.chkOpenAttachments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkOpenAttachments.Name = "chkOpenAttachments"
        Me.chkOpenAttachments.Size = New System.Drawing.Size(323, 21)
        Me.chkOpenAttachments.TabIndex = 37
        Me.chkOpenAttachments.Text = "Save and open attachments after downloading"
        Me.chkOpenAttachments.UseVisualStyleBackColor = True
        '
        'btnSelectFile
        '
        Me.btnSelectFile.BackgroundImage = CType(resources.GetObject("btnSelectFile.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectFile.Location = New System.Drawing.Point(669, 80)
        Me.btnSelectFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(29, 27)
        Me.btnSelectFile.TabIndex = 36
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(244, 82)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(416, 22)
        Me.txtFile.TabIndex = 34
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(13, 91)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(30, 17)
        Me.lblFile.TabIndex = 35
        Me.lblFile.Text = "File"
        '
        'lblTopic
        '
        Me.lblTopic.AutoSize = True
        Me.lblTopic.Location = New System.Drawing.Point(13, 26)
        Me.lblTopic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopic.Name = "lblTopic"
        Me.lblTopic.Size = New System.Drawing.Size(43, 17)
        Me.lblTopic.TabIndex = 30
        Me.lblTopic.Text = "Topic"
        '
        'cmbTopic
        '
        Me.cmbTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTopic.FormattingEnabled = True
        Me.cmbTopic.Location = New System.Drawing.Point(245, 16)
        Me.cmbTopic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTopic.Name = "cmbTopic"
        Me.cmbTopic.Size = New System.Drawing.Size(416, 24)
        Me.cmbTopic.TabIndex = 32
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Location = New System.Drawing.Point(13, 59)
        Me.lblDirection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(64, 17)
        Me.lblDirection.TabIndex = 31
        Me.lblDirection.Text = "Direction"
        '
        'cmbDirection
        '
        Me.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirection.FormattingEnabled = True
        Me.cmbDirection.Location = New System.Drawing.Point(245, 49)
        Me.cmbDirection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDirection.Name = "cmbDirection"
        Me.cmbDirection.Size = New System.Drawing.Size(416, 24)
        Me.cmbDirection.TabIndex = 33
        '
        'gbParameters
        '
        Me.gbParameters.Location = New System.Drawing.Point(8, 158)
        Me.gbParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbParameters.Name = "gbParameters"
        Me.gbParameters.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbParameters.Size = New System.Drawing.Size(707, 68)
        Me.gbParameters.TabIndex = 27
        Me.gbParameters.TabStop = False
        Me.gbParameters.Text = "Parameters"
        '
        'TabMultiple
        '
        Me.TabMultiple.BackColor = System.Drawing.Color.Transparent
        Me.TabMultiple.Controls.Add(Me.GroupBox1)
        Me.TabMultiple.Controls.Add(Me.GroupBox2)
        Me.TabMultiple.Controls.Add(Me.gbMultiple)
        Me.TabMultiple.Location = New System.Drawing.Point(4, 25)
        Me.TabMultiple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabMultiple.Name = "TabMultiple"
        Me.TabMultiple.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabMultiple.Size = New System.Drawing.Size(725, 237)
        Me.TabMultiple.TabIndex = 1
        Me.TabMultiple.Text = "Multiple upload"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtProcessedDir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(717, 91)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(675, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtProcessedDir
        '
        Me.txtProcessedDir.Location = New System.Drawing.Point(249, 23)
        Me.txtProcessedDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProcessedDir.Name = "txtProcessedDir"
        Me.txtProcessedDir.Size = New System.Drawing.Size(416, 22)
        Me.txtProcessedDir.TabIndex = 6
        Me.txtProcessedDir.Text = "D:\VeluweGranen\ExactFiles\Processed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Processed"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtErrorDir)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(4, 164)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(717, 69)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(675, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtErrorDir
        '
        Me.txtErrorDir.Location = New System.Drawing.Point(249, 23)
        Me.txtErrorDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtErrorDir.Name = "txtErrorDir"
        Me.txtErrorDir.Size = New System.Drawing.Size(416, 22)
        Me.txtErrorDir.TabIndex = 6
        Me.txtErrorDir.Text = "D:\VeluweGranen\ExactFiles\Processed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Error directory"
        '
        'gbMultiple
        '
        Me.gbMultiple.Controls.Add(Me.btnSelectDir)
        Me.gbMultiple.Controls.Add(Me.txtUploadDir)
        Me.gbMultiple.Controls.Add(Me.lblUploadDir)
        Me.gbMultiple.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbMultiple.Location = New System.Drawing.Point(4, 4)
        Me.gbMultiple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMultiple.Name = "gbMultiple"
        Me.gbMultiple.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMultiple.Size = New System.Drawing.Size(717, 69)
        Me.gbMultiple.TabIndex = 3
        Me.gbMultiple.TabStop = False
        '
        'btnSelectDir
        '
        Me.btnSelectDir.BackgroundImage = CType(resources.GetObject("btnSelectDir.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectDir.Location = New System.Drawing.Point(675, 21)
        Me.btnSelectDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectDir.Name = "btnSelectDir"
        Me.btnSelectDir.Size = New System.Drawing.Size(29, 27)
        Me.btnSelectDir.TabIndex = 7
        Me.btnSelectDir.UseVisualStyleBackColor = True
        '
        'txtUploadDir
        '
        Me.txtUploadDir.Location = New System.Drawing.Point(249, 23)
        Me.txtUploadDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUploadDir.Name = "txtUploadDir"
        Me.txtUploadDir.Size = New System.Drawing.Size(416, 22)
        Me.txtUploadDir.TabIndex = 6
        '
        'lblUploadDir
        '
        Me.lblUploadDir.AutoSize = True
        Me.lblUploadDir.Location = New System.Drawing.Point(17, 32)
        Me.lblUploadDir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUploadDir.Name = "lblUploadDir"
        Me.lblUploadDir.Size = New System.Drawing.Size(112, 17)
        Me.lblUploadDir.TabIndex = 5
        Me.lblUploadDir.Text = "Upload directory"
        '
        'btnOauth
        '
        Me.btnOauth.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOauth.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOauth.Location = New System.Drawing.Point(576, 31)
        Me.btnOauth.Name = "btnOauth"
        Me.btnOauth.Size = New System.Drawing.Size(88, 61)
        Me.btnOauth.TabIndex = 39
        Me.btnOauth.Text = "Do Oauth"
        Me.btnOauth.UseVisualStyleBackColor = False
        '
        'frmImporterMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 732)
        Me.Controls.Add(Me.TabImportExport)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.gbProxy)
        Me.Controls.Add(Me.gbCredentials)
        Me.Controls.Add(Me.gbMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmImporterMain"
        Me.Text = "Exact Online import/export"
        Me.gbCredentials.ResumeLayout(False)
        Me.gbCredentials.PerformLayout()
        Me.gbProxy.ResumeLayout(False)
        Me.gbProxy.PerformLayout()
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.TabImportExport.ResumeLayout(False)
        Me.TabSingle.ResumeLayout(False)
        Me.gbSingle.ResumeLayout(False)
        Me.gbSingle.PerformLayout()
        Me.TabMultiple.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbMultiple.ResumeLayout(False)
        Me.gbMultiple.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gbCredentials As System.Windows.Forms.GroupBox
    Friend WithEvents gbProxy As System.Windows.Forms.GroupBox
    Friend WithEvents gbMain As System.Windows.Forms.GroupBox
    Friend WithEvents lblPasswordProxy As System.Windows.Forms.Label
    Friend WithEvents txtPasswordProxy As System.Windows.Forms.TextBox
    Friend WithEvents lblUserNameProxy As System.Windows.Forms.Label
    Friend WithEvents txtUserNameProxy As System.Windows.Forms.TextBox
    Friend WithEvents lblDomainProxy As System.Windows.Forms.Label
    Friend WithEvents txtDomainProxy As System.Windows.Forms.TextBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblProxyServer As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyServer As System.Windows.Forms.TextBox
    Friend WithEvents chkProxy As System.Windows.Forms.CheckBox
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents dlgFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtApplicationKey As System.Windows.Forms.TextBox
    Friend WithEvents lblApplicationKey As System.Windows.Forms.Label
    Friend WithEvents TabImportExport As System.Windows.Forms.TabControl
    Friend WithEvents TabSingle As System.Windows.Forms.TabPage
    Friend WithEvents gbParameters As System.Windows.Forms.GroupBox
    Friend WithEvents TabMultiple As System.Windows.Forms.TabPage
    Friend WithEvents dlgDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gbSingle As System.Windows.Forms.GroupBox
    Friend WithEvents chkOpenAttachments As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents lblTopic As System.Windows.Forms.Label
    Friend WithEvents cmbTopic As System.Windows.Forms.ComboBox
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents cmbDirection As System.Windows.Forms.ComboBox
    Friend WithEvents gbMultiple As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectDir As System.Windows.Forms.Button
    Friend WithEvents txtUploadDir As System.Windows.Forms.TextBox
    Friend WithEvents lblUploadDir As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtProcessedDir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtErrorDir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnOauth As Button
End Class
