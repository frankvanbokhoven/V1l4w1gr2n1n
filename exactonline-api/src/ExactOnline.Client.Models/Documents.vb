' Last generated on 2017-05-05 12:58:34Z

Namespace Documents

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Document]
		'''<![CDATA[ID of the related account of this document]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Body of this document]]>
		Public Property [Body] As String
		'''<![CDATA[ID of the category of this document]]>
		Public Property [Category] As Guid?
		'''<![CDATA[Description of Category]]>
		Public Property [CategoryDescription] As String
		'''<![CDATA[ID of the related contact of this document]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[Contact full name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Entry date of the incoming document]]>
		Public Property [DocumentDate] As DateTime?
		'''<![CDATA[The Id of document folder]]>
		Public Property [DocumentFolder] As Guid?
		'''<![CDATA[The Code of document folder]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderCode] As String
		'''<![CDATA[The Decsription of document folder]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentFolderDescription] As String
		'''<![CDATA[Url to view the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentViewUrl] As String
		'''<![CDATA[Reference to the financial transaction]]>
		Public Property [FinancialTransactionEntryID] As Guid?
		'''<![CDATA[Indicates that the document body is empty]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasEmptyBody] As Boolean
		'''<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[The language code of the document]]>
		Public Property [Language] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The opportunity linked to the document]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[The project linked to the document]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA['Our reference' of the transaction that belongs to this document]]>
		Public Property [SalesInvoiceNumber] As Int32?
		'''<![CDATA[Number of the sales order]]>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[Send method]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SendMethod] As Int32?
		'''<![CDATA[Number of the shop order]]>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[Subject of this document]]>
		Public Property [Subject] As String
		'''<![CDATA[ID of the type of this document]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentAttachment]
		'''<![CDATA[Contains the attachment]]>
		Public Property [Attachment] As Byte()
		'''<![CDATA[Reference to the Document]]>
		Public Property [Document] As Guid
		'''<![CDATA[Filename of the attachment]]>
		Public Property [FileName] As String
		'''<![CDATA[File size of the attachment]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Double
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Url of the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append <b>&Download=1</b> to the url.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Url] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentCategory]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[Document category description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentFolder]
		'''<![CDATA[Document folder code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Document folder description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Document folder parent folder ID]]>
		Public Property [ParentFolder] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentType]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[Document type description]]>
		Public Property [Description] As String
		'''<![CDATA[Indicates if documents of this type can be created]]>
		Public Property [DocumentIsCreatable] As Boolean
		'''<![CDATA[Indicates if documents of this type can be deleted]]>
		Public Property [DocumentIsDeletable] As Boolean
		'''<![CDATA[Indicates if documents of this type can be updated]]>
		Public Property [DocumentIsUpdatable] As Boolean
		'''<![CDATA[Indicates if documents of this type can be retrieved]]>
		Public Property [DocumentIsViewable] As Boolean
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int32
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[ID of the document type category]]>
		Public Property [TypeCategory] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentTypeCategory]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[Document category type description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int32
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DocumentTypeFolder]
		'''<![CDATA[Date created]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User id of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Folder to which document type is linked]]>
		Public Property [DocumentFolder] As Guid
		'''<![CDATA[Code of document type which is linked to folder]]>
		Public Property [DocumentType] As Int32
		Public Property [ID] As Guid
		'''<![CDATA[Date Modified]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User id of modifier]]>
		Public Property [Modifier] As Guid?
	End Class

End Namespace