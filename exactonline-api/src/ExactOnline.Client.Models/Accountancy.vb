' Last generated on 2017-05-05 12:58:34Z

Namespace Accountancy

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [AccountInvolvedAccount]
		'''<![CDATA[ID of account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Name of account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[ID of involved account]]>
		Public Property [InvolvedAccount] As Guid?
		'''<![CDATA[Description of relation type]]>
		Public Property [InvolvedAccountRelationTypeDescription] As String
		'''<![CDATA[TermId of description of relation type]]>
		Public Property [InvolvedAccountRelationTypeDescriptionTermId] As Int32?
		'''<![CDATA[ID of relation type]]>
		Public Property [InvolvedAccountRelationTypeId] As Int16?
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Use to record details of important information]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [AccountOwner]
		'''<![CDATA[ID of the account that is owned]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of the account that is owned]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of the account that is owned]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[ID of the account who owns specified account]]>
		Public Property [OwnerAccount] As Guid?
		'''<![CDATA[Code of the account who owns specified account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OwnerAccountCode] As String
		'''<![CDATA[Name of the account who owns specified account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OwnerAccountName] As String
		'''<![CDATA[Percentage of shares that is owned. 1 is 100%, 0.5 is 50%]]>
		Public Property [Shares] As Double?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [InvolvedUser]
		'''<![CDATA[ID of the account the user is involved with]]>
		Public Property [Account] As Guid?
		'''<![CDATA[City of the account]]>
		Public Property [AccountCity] As String
		'''<![CDATA[Code of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Supplier flag of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<![CDATA[Logo thumbnail url of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountLogoThumbnailUrl] As String
		'''<![CDATA[Name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Status of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountStatus] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[ID of the user role]]>
		Public Property [InvolvedUserRole] As Guid?
		'''<![CDATA[Description of the user role]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvolvedUserRoleDescription] As String
		'''<![CDATA[Main contact flag of the involved user]]>
		Public Property [IsMainContact] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Email of a person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PersonEmail] As String
		'''<![CDATA[Phone of a person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PersonPhone] As String
		'''<![CDATA[Phone extension of a person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PersonPhoneExtension] As String
		'''<![CDATA[Picture thumbnail url of a person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PersonPictureThumbnailUrl] As String
		'''<![CDATA[ID of the involved user]]>
		Public Property [User] As Guid?
		'''<![CDATA[User name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [InvolvedUserRole]
		'''<![CDATA[Code of the involved user role]]>
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
		'''<![CDATA[Description of role]]>
		Public Property [Description] As String
		'''<![CDATA[Description term code of role]]>
		Public Property [DescriptionTermID] As Int32?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
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
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SolutionLink]
		'''<![CDATA[ID of account to which solution is linked]]>
		Public Property [Account] As Guid
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Accountant main division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)]]>
		Public Property [ExternalSolutionCode] As Int32?
		'''<![CDATA[Name of the external solution]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalSolutionName] As String
		'''<![CDATA[Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)]]>
		Public Property [ExternalSolutionUrl] As String
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<![CDATA[Division code of linked internal solution (mandatory for Internal solution)]]>
		Public Property [InternalSolutionDivision] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the solution link]]>
		Public Property [Name] As String
		'''<![CDATA[Name of the custom external solution (mandatory for ExternalOther solution)]]>
		Public Property [OtherExternalSolutionName] As String
		'''<![CDATA[Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther]]>
		Public Property [SolutionType] As Int32
		'''<![CDATA[Link status: 0 - Active, 1 - Inactive, 2 -Archived]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TaskType]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Name of the task type]]>
		Public Property [Description] As String
		'''<![CDATA[Term ID of the task type]]>
		Public Property [DescriptionTermID] As Int32?
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
	End Class

End Namespace