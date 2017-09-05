#define MyAppName "VG_ExactOnlineImporter"
#define MyAppVersion "1.2017.10.8"
#define MyAppPublisher "Yggdra Solutions"
#define MyAppURL "http://www.yggdra.nl"
#define MyAppExeName "VG_ExactOnlineImporter.exe"



[Setup]

AppID={{5D9C8110-DD98-4567-A8E5-9E2BCB0410B6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}

AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=SetupVG_ExactOnlineImporter
SetupIconFile=d:\VeluweGranen\VeluweGranen.ico
Compression=lzma/Max
SolidCompression=true
UserInfoPage=true
;myVariable := GetCommandLineParam('-myParam');
;VersionInfoVersion=MyAppVersion
VersionInfoCompany=Veluwe Granen
VersionInfoDescription=Veluwe Granen
VersionInfoTextVersion=Veluwe Granen
VersionInfoCopyright=Copyright 2017 Yggdra
VersionInfoProductName=ExactOnlineVeluweGranen
;VersionInfoProductVersion=MyAppVersion
OutputDir=D:\veluwegranen\Setup
SetupLogging=true
AlwaysRestart=No

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Files]
Source: "D:\VeluweGranen\Nieuw\debug\ExactOnlineImporter.exe"; DestDir: "{app}";  DestName: "VG_ExactOnlineImporter.exe"; Flags: ignoreversion
Source: "D:\VeluweGranen\Nieuw\debug\ExactOnlineImporter.exe.config"; DestDir: "{app}";  DestName: "VG_ExactOnlineImporter.exe.config"; Flags: ignoreversion
Source: "D:\VeluweGranen\Nieuw\debug\ExactOnlineImporter.xml"; DestDir: "{app}";  DestName: "VG_ExactOnlineImporter.xml"; Flags: ignoreversion

;Source: "d:\EnergySoftwareSolutions\ESSaver\Output\msmdvbanet.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "d:\EnergySoftwareSolutions\ESSaver\Output\sqlite3.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\EnergySoftwareSolutions\PushData\bin\Debug\PushData.ini"; DestDir: "{app}"; Flags: ignoreversion
[Icons]
;Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
;[Run]
;Filename: "{app}\dotnetfx35.exe"; Parameters: "/q /norestart"; Check: Is35Installed
;Filename: "{app}\XPUEESSaver.exe"; Parameters: "--install"
;Filename: net.exe; Parameters: "start XPUEESSaver"; Description: "Starting essaver service"

;dit creert een inifile genaamd 'pushdata.ini', die gevuld wordt door de custom parameter 'webserveraddress'
;[INI]
;Filename: {app}\PushData.ini; Section: GENERAL; Key: WebServiceURL; String: "{code:GetCommandlineParam}"

;Filename: "{app}\essaverpueenergy.exe"; Parameters: "--runservice"
;[UninstallRun]
;Filename: "{app}\XPUEESSaver.exe"; Parameters: "--uninstall"
[Run]
Filename:  schtasks.exe; Parameters:" /create /tn ""VeluweGranenExactOnline"" /tr {app}\ExactOnlineImporter.exe /sc HOURLY "


 
