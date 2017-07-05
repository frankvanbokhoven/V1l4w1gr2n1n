' Last generated on 2017-05-05 12:58:35Z

Namespace Mailbox

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DefaultMailbox]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Extra description of the mailbox]]>
		Public Property [Description] As String
		'''<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
		Public Property [ForDivision] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates whether this service is used for messages returned by the scanning service]]>
		Public Property [IsScanServiceMailbox] As Boolean
		'''<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
		Public Property [Mailbox] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Date that this mailbox became valid]]>
		Public Property [ValidFrom] As DateTime?
		'''<![CDATA[Date that this mailbox will not be valid anymore]]>
		Public Property [ValidTo] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Mailbox]
		'''<![CDATA[The account this mailbox belongs to. Can be empty if the owner of the mailbox isn't an Exact Online customer yet]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Extra description of the mailbox]]>
		Public Property [Description] As String
		'''<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
		Public Property [ForDivision] As Int32?
		'''<![CDATA[Description of ForDivision]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ForDivisionDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
		Public Property [Mailbox] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact]]>
		Public Property [Publish] As Byte
		'''<![CDATA[Type of mailbox. Exact / Government / Manual]]>
		Public Property [Type] As Int16?
		'''<![CDATA[Date that this mailbox became valid]]>
		Public Property [ValidFrom] As DateTime?
		'''<![CDATA[Date that this mailbox will not be valid anymore]]>
		Public Property [ValidTo] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessageAttachment]
		'''<![CDATA[For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url]]>
		Public Property [Attachment] As Byte()
		'''<![CDATA[File extension of attachment]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AttachmentFileExtension] As String
		'''<![CDATA[File name of attachment]]>
		Public Property [AttachmentFileName] As String
		'''<![CDATA[File size]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FileSize] As Int64
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to Mail message]]>
		Public Property [MailMessageID] As Guid
		'''<![CDATA[Reference to recipient account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<![CDATA[Reference to sender account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<![CDATA[Type of mail message attachment]]>
		Public Property [Type] As Int32
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[To get the file in its original format (xml, jpg, pdf, etc.) append <b>&Download=1</b> to the url.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Url] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessagesReceived]
		'''<![CDATA[Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [Bank] As Guid?
		'''<![CDATA[Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [BankAccount] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [ForDivision] As Int32?
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
		'''<![CDATA[Specifies the operation upon dealing with the mailmessage (Kirean scan service)]]>
		Public Property [Operation] As Int16?
		'''<![CDATA[Provides a link to another MailMessage (Kirean scan service)]]>
		Public Property [OriginalMessage] As Guid?
		'''<![CDATA[Subject of the OriginalMessage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalMessageSubject] As String
		'''<![CDATA[The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online]]>
		Public Property [PartnerKey] As Guid?
		'''<![CDATA[Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Reference to the account that is receiving this mailmessage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<![CDATA[Indiciates if the recipient deleted this message. If this is the case the recipient can't see it anymore and the sender can actually delete it]]>
		Public Property [RecipientDeleted] As Byte
		'''<![CDATA[Mailbox of recipient]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailbox] As String
		'''<![CDATA[Mailbox description of recipient]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailboxDescription] As String
		'''<![CDATA[Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox]]>
		Public Property [RecipientMailboxID] As Guid?
		'''<![CDATA[Status of the mail message, only the recipient can update this]]>
		Public Property [RecipientStatus] As Int16?
		'''<![CDATA[Description of RecipientStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientStatusDescription] As String
		'''<![CDATA[Reference to Account of Sender]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<![CDATA[Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)]]>
		Public Property [SenderDateSent] As DateTime?
		'''<![CDATA[Indicates if the sender deleted the message. This means the sender can't see it anymore and the recipient can actually delete it]]>
		Public Property [SenderDeleted] As Byte
		'''<![CDATA[IP address of the sender]]>
		Public Property [SenderIPAddress] As String
		'''<![CDATA[Mailbox of sender]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailbox] As String
		'''<![CDATA[Description of SenderMailbox]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailboxDescription] As String
		'''<![CDATA[Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items]]>
		Public Property [SenderMailboxID] As Guid?
		'''<![CDATA[Subject of the mail message]]>
		Public Property [Subject] As String
		'''<![CDATA[Provides a link between Exact Online and the banks]]>
		Public Property [SynchronizationCode] As String
		'''<![CDATA[Type of the mail message]]>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [MailMessagesSent]
		'''<![CDATA[Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [Bank] As Guid?
		'''<![CDATA[Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [BankAccount] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
		Public Property [ForDivision] As Int32?
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
		'''<![CDATA[Specifies the operation upon dealing with the mailmessage (Kirean scan service)]]>
		Public Property [Operation] As Int16?
		'''<![CDATA[Provides a link to another MailMessage (Kirean scan service)]]>
		Public Property [OriginalMessage] As Guid?
		'''<![CDATA[Subject of the OriginalMessage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalMessageSubject] As String
		'''<![CDATA[The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online]]>
		Public Property [PartnerKey] As Guid?
		'''<![CDATA[Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Reference to the account that is receiving this mailmessage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientAccount] As Guid?
		'''<![CDATA[Indiciates if the recipient deleted this message. If this is the case the recipient can't see it anymore and the sender can actually delete it]]>
		Public Property [RecipientDeleted] As Byte
		'''<![CDATA[Mailbox of recipient]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailbox] As String
		'''<![CDATA[Mailbox description of recipient]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientMailboxDescription] As String
		'''<![CDATA[Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox]]>
		Public Property [RecipientMailboxID] As Guid?
		'''<![CDATA[Status of the mail message, only the recipient can update this]]>
		Public Property [RecipientStatus] As Int16?
		'''<![CDATA[Description of RecipientStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RecipientStatusDescription] As String
		'''<![CDATA[Reference to Account of Sender]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderAccount] As Guid?
		'''<![CDATA[Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)]]>
		Public Property [SenderDateSent] As DateTime?
		'''<![CDATA[Indicates if the sender deleted the message. This means the sender can't see it anymore and the recipient can actually delete it]]>
		Public Property [SenderDeleted] As Byte
		'''<![CDATA[IP address of the sender]]>
		Public Property [SenderIPAddress] As String
		'''<![CDATA[Mailbox of sender]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailbox] As String
		'''<![CDATA[Description of SenderMailbox]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SenderMailboxDescription] As String
		'''<![CDATA[Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items]]>
		Public Property [SenderMailboxID] As Guid?
		'''<![CDATA[Subject of the mail message]]>
		Public Property [Subject] As String
		'''<![CDATA[Provides a link between Exact Online and the banks]]>
		Public Property [SynchronizationCode] As String
		'''<![CDATA[Type of the mail message]]>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PreferredMailbox]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Extra description of the mailbox]]>
		Public Property [Description] As String
		'''<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
		Public Property [ForDivision] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates whether this service is used for messages returned by the scanning service]]>
		Public Property [IsScanServiceMailbox] As Boolean
		'''<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
		Public Property [Mailbox] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Date that this mailbox became valid]]>
		Public Property [ValidFrom] As DateTime?
		'''<![CDATA[Date that this mailbox will not be valid anymore]]>
		Public Property [ValidTo] As DateTime?
	End Class

End Namespace