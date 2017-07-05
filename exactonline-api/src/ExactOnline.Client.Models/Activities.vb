' Last generated on 2017-05-05 12:58:34Z

Namespace Activities

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [CommunicationNote]
		'''<![CDATA[The account that is related to the communication note]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Attachments linked to the communication note]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<![CDATA[The campaign linked to the communication note]]>
		Public Property [Campaign] As Guid?
		'''<![CDATA[Description of the campaign]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<![CDATA[The contact person that is related to the communication note]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[The name of the contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[The division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The document that is linked to the communication note]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The human readable key]]>
		Public Property [HID] As Int32?
		'''<![CDATA[The Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The notes of the communication note]]>
		Public Property [Notes] As String
		'''<![CDATA[The opportunity linked to the communication note]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[The name of the opportunity]]>
		Public Property [OpportunityName] As String
		'''<![CDATA[Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed ]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[A short description of the communication note]]>
		Public Property [Subject] As String
		'''<![CDATA[The user that the communication note is assigned to]]>
		Public Property [User] As Guid?
		'''<![CDATA[The user name]]>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Complaint]
		'''<![CDATA[The account that is related to the complaint]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[The user that the complaint is assigned to]]>
		Public Property [AssignedTo] As Guid?
		'''<![CDATA[The user name]]>
		Public Property [AssignedToFullName] As String
		'''<![CDATA[Attachments linked to the complaint]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<![CDATA[A short description of the complaint]]>
		Public Property [Complaint] As String
		'''<![CDATA[The contact person that is related to the complaint]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[The name of the contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The document that is linked to the complaint]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The human readable key]]>
		Public Property [HID] As Int32?
		'''<![CDATA[The Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The date indicating by when the next action has to be taken]]>
		Public Property [NextAction] As DateTime?
		'''<![CDATA[The notes of the complaint]]>
		Public Property [Notes] As String
		'''<![CDATA[The date the complaint was received]]>
		Public Property [ReceiptDate] As DateTime?
		'''<![CDATA[Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed ]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Event]
		'''<![CDATA[The account that is related to the event]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Attachments linked to the event]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<![CDATA[The campaign linked to the event]]>
		Public Property [Campaign] As Guid?
		'''<![CDATA[Description of the campaign]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<![CDATA[The contact person that is related to the event]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[The name of the contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The description]]>
		Public Property [Description] As String
		'''<![CDATA[The division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The document that is linked to the event]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The end date and time]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[The human readable key]]>
		Public Property [HID] As Int32?
		'''<![CDATA[The Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The notes of the event]]>
		Public Property [Notes] As String
		'''<![CDATA[The opportunity linked to the event]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[The name of the opportunity]]>
		Public Property [OpportunityName] As String
		'''<![CDATA[The project linked to the event]]>
		Public Property [Project] As Guid?
		'''<![CDATA[The description of the project]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[The start date and time]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed ]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[The user that has the event]]>
		Public Property [User] As Guid?
		'''<![CDATA[The user name]]>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ServiceRequest]
		'''<![CDATA[The account that is related to the service request]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[The user that the service request is assigned to]]>
		Public Property [AssignedTo] As Guid?
		'''<![CDATA[The user name]]>
		Public Property [AssignedToFullName] As String
		'''<![CDATA[Attachments linked to the service request]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<![CDATA[The contact person that is related to the service request]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[The name of the contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The description]]>
		Public Property [Description] As String
		'''<![CDATA[The division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The document that is linked to the service request]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The human readable key]]>
		Public Property [HID] As Int32?
		'''<![CDATA[The Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The date indicating by when the next action has to be taken]]>
		Public Property [NextAction] As DateTime?
		'''<![CDATA[The notes of the service request]]>
		Public Property [Notes] As String
		'''<![CDATA[The date the service request was received]]>
		Public Property [ReceiptDate] As DateTime?
		'''<![CDATA[Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed ]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Task]
		'''<![CDATA[The account that is related to the task]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[The end date by which the task has to be realized]]>
		Public Property [ActionDate] As DateTime?
		'''<![CDATA[Attachments linked to the task]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Attachments] As IEnumerable(Of Models.Workflow.RequestAttachment)
		'''<![CDATA[The contact person that is related to the task]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[The name of the contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactFullName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Custom type of the task. If both TaskType and CustomTaskType are specified then TaskType is preferred. This value is write-only.]]>
		Public Property [CustomTaskType] As Guid?
		'''<![CDATA[The description of the task]]>
		Public Property [Description] As String
		'''<![CDATA[The division of the task]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The document that is linked to the task]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The human readable key]]>
		Public Property [HID] As Int32?
		'''<![CDATA[The Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The notes of the task]]>
		Public Property [Notes] As String
		'''<![CDATA[The opportunity linked to the task]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[The name of the opportunity]]>
		Public Property [OpportunityName] As String
		'''<![CDATA[The project linked to the task]]>
		Public Property [Project] As Guid?
		'''<![CDATA[The description of the project]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Status: 0 = Void, 5 = Rejected, 10 = Draft, 20 = Open, 30 = Approved, 40 = Realized, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[The type of the task. This value is write-only.0 = Other (default), 1 = Call, 2 = Request for information, 3 = Investigate, 4 = Correspondence, 5 = Create an appointment, 6 = Create a quotation]]>
		Public Property [TaskType] As Int32?
		'''<![CDATA[The description of the type of the task]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaskTypeDescription] As String
		'''<![CDATA[The user that has to realize the task]]>
		Public Property [User] As Guid?
		'''<![CDATA[The user name]]>
		Public Property [UserFullName] As String
	End Class

End Namespace