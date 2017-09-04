#define MyAppName "Exact OAuth Importer"
#define MyAppVersion "4.2017.09.04"
#define MyAppPublisher "Yggdra Solutions"
#define MyAppURL "http://www.yggdra.nl"
#define MyAppExeName "ExactonlineOAuthImporter.exe"
#define MyManagerApp "ExactonlineOAuthImporter.exe"

[Setup]
;PrivilegesRequired=admin  /fvb 27 07 2013: quicksleep heeft geen admin rechten nodig..
AppID={{F1652D74-9F41-4118-A244-D47373CC4F82}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=SetupOAuthImporter
OutputDir=C:\VeluweGranen\GitSources\exactonline-api
SetupIconFile=C:\VeluweGranen\GitSources\exactonline-api\OAuthUploader\Veluwegranen.ico
Compression=lzma/Max
SolidCompression=true
UserInfoPage=true

VersionInfoCompany=Yggdra Solutions
VersionInfoDescription=ExactOAuthImporteer
VersionInfoTextVersion=Exact OAuthImporter
VersionInfoCopyright=Copyright 2017 Yggdra Solutions
VersionInfoProductName=ExactOAuthImporter
;;;;;;;;;;;#include "C:\Program Files (x86)\InnoTools\Downloader\it_download.iss'


[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
;Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
;Name: "hp"; Description: "Install Delta toolbar"
;Name: "ds"; Description: "Make Delta my default search engine"
;Name: "dt"; Description: "Make Delta my default homepage and new tab"
 Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.Core.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.Core.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.InfoCard.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.InfoCard.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.InfoCard.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.InfoCard.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.Common.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.Consumer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.Consumer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.ServiceProvider.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.ServiceProvider.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.AuthorizationServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.AuthorizationServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.Client.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.Client.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.Client.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.Client.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.ClientAuthorization.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.ClientAuthorization.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.ResourceServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.ResourceServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OAuth2.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.Provider.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.Provider.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.Provider.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.Provider.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.RelyingParty.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.RelyingParty.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.RelyingParty.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.RelyingParty.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenId.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenIdInfoCard.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenIdInfoCard.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenIdOAuth.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\DotNetOpenAuth.OpenIdOAuth.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Exact.ini"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactOnline.Client.OAuth.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactOnline.Client.OAuth.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\ExactonlineOAuthImporter.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Microsoft.Win32.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Mono.Math.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Mono.Math.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Org.Mentalis.Security.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\Org.Mentalis.Security.Cryptography.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\SendGrid.CSharp.HTTP.Client.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\SendGrid.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Diagnostics.DiagnosticSource.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Net.Http.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Net.Http.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Net.Http.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Net.Http.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Net.Http.Primitives.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Security.Cryptography.Algorithms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Security.Cryptography.Encoding.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Security.Cryptography.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "ExactonlineOAuthImporter\bin\Debug\System.Security.Cryptography.X509Certificates.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: {group}\ExactOauthImporter; Filename: {app}\{#MyAppExeName}; 
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commonstartup}\{#MyAppExeName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: nowait postinstall skipifsilent

