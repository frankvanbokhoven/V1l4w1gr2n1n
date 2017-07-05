' Last generated on 2017-05-05 12:58:35Z

Namespace Workflow

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [RequestAttachment]
		'''<![CDATA[The division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[To get the file in its original format (xml, jpg, pdf, etc.) append <b>&Download=1</b> to the url.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DownloadUrl] As String
		'''<![CDATA[Filename of the attachment]]>
		Public Property [FileName] As String
		'''<![CDATA[File size of the attachment]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Double
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[The request this attachment is linked to]]>
		Public Property [Request] As Guid?
	End Class

End Namespace