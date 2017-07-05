' Last generated on 2017-05-05 12:58:35Z

Namespace Users

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("UserID")>
	Public Class [User]
		'''<![CDATA[Birth date]]>
		Public Property [BirthDate] As DateTime?
		'''<![CDATA[Birth name]]>
		Public Property [BirthName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Customer the user belongs to]]>
		Public Property [Customer] As Guid
		'''<![CDATA[Name of Customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerName] As String
		'''<![CDATA[Email address of the user]]>
		Public Property [Email] As String
		'''<![CDATA[Date after which the user login is disabled. NULL means no enddate]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[First name]]>
		Public Property [FirstName] As String
		'''<![CDATA[Full name of the user]]>
		Public Property [FullName] As String
		'''<![CDATA[Gender: M=Male, V=Female, O=Unknown]]>
		Public Property [Gender] As String
		'''<![CDATA[Initials]]>
		Public Property [Initials] As String
		'''<![CDATA[Language (culture) that is used in Exact Online]]>
		Public Property [Language] As String
		'''<![CDATA[The last time this user logged in]]>
		Public Property [LastLogin] As DateTime?
		'''<![CDATA[Last name]]>
		Public Property [LastName] As String
		'''<![CDATA[Middle name]]>
		Public Property [MiddleName] As String
		'''<![CDATA[Mobile phone]]>
		Public Property [Mobile] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Nationality]]>
		Public Property [Nationality] As String
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone number extension]]>
		Public Property [PhoneExtension] As String
		'''<![CDATA[Profile code]]>
		Public Property [ProfileCode] As String
		'''<![CDATA[Startdate after which the login is allowed. If the start date is NULL the login is allowed as well]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Start Division]]>
		Public Property [StartDivision] As Int32
		'''<![CDATA[Title]]>
		Public Property [Title] As String
		'''<![CDATA[Primary key]]>
		Public Property [UserID] As Guid
		'''<![CDATA[Login name of the user]]>
		Public Property [UserName] As String
		'''<![CDATA[Collection of user roles]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UserRoles] As IEnumerable(Of Models.Accountancy.InvolvedUserRole)
		'''<![CDATA[Collection of user roles per division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UserRolesPerDivision] As IEnumerable(Of Models.Users.UserRolesPerDivision)
		'''<![CDATA[Obsolete]]>
		Public Property [UserTypesList] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [UserRole]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
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
		'''<![CDATA[The role that the user is linked to]]>
		Public Property [Role] As Int32
		'''<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
		Public Property [RoleLevel] As Int32
		'''<![CDATA[Indicates the date when the role becomes active for the user]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[The user that is linked to the role]]>
		Public Property [UserID] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [UserRolesPerDivision]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[Indicates the date and time when te role becomes inactive for the user]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
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
		'''<![CDATA[The role that the user is linked to]]>
		Public Property [Role] As Int32
		'''<![CDATA[Rolelevel sets the level on which a role for a user is active. This can be: 1 = Database, 2 = Customer, 3 = Division, 100 = Transferred to accountant]]>
		Public Property [RoleLevel] As Int32
		'''<![CDATA[Indicates the date when the role becomes active for the user]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[The user that is linked to the role]]>
		Public Property [UserID] As Guid?
	End Class

End Namespace