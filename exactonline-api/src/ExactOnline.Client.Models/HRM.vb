' Last generated on 2017-05-05 12:58:34Z

Namespace HRM

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AbsenceRegistration]
		'''<![CDATA[Collection of absence registration transactions]]>
		Public Property [AbsenceRegistrationTransactions] As IEnumerable(Of Models.HRM.AbsenceRegistrationTransaction)
		'''<![CDATA[Absence cause, only supported for the Netherland legislation]]>
		Public Property [Cause] As Int16?
		'''<![CDATA[Code for the absence cause, only supported for the Netherland legislation]]>
		Public Property [CauseCode] As String
		'''<![CDATA[Description for the absence cause, only supported for the Netherland legislation]]>
		Public Property [CauseDescription] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[Employee linked to the absence]]>
		Public Property [Employee] As Guid
		'''<![CDATA[Employee full name]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric ID of the employee]]>
		Public Property [EmployeeHID] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Absence kind, only supported for the Netherland legislation]]>
		Public Property [Kind] As Int16?
		'''<![CDATA[Code for the absence kind, only supported for the Netherland legislation]]>
		Public Property [KindCode] As String
		'''<![CDATA[Description for the absence kind, only supported for the Netherland legislation]]>
		Public Property [KindDescription] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra information for absence]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AbsenceRegistrationTransaction]
		'''<![CDATA[Reference key to Absence Registration]]>
		Public Property [AbsenceRegistration] As Guid
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[End time on the last day of absence stored as DateTime, and the date should be ignored]]>
		Public Property [EndTime] As DateTime?
		'''<![CDATA[Expected end date of absence]]>
		Public Property [ExpectedEndDate] As DateTime?
		'''<![CDATA[Total number of absence hours]]>
		Public Property [Hours] As Double
		'''<![CDATA[Hours of absence on the first day]]>
		Public Property [HoursFirstDay] As Double?
		'''<![CDATA[Hours of absence on the last day]]>
		Public Property [HoursLastDay] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra information for absence]]>
		Public Property [Notes] As String
		'''<![CDATA[Notification moment of absence]]>
		Public Property [NotificationMoment] As DateTime
		'''<![CDATA[Percentage disablement]]>
		Public Property [PercentageDisablement] As Double
		'''<![CDATA[Start date of absence]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[Start time on the first day of absence stored as DateTime, and the date should be ignored]]>
		Public Property [StartTime] As DateTime?
		'''<![CDATA[Status of absence, 0 = Open, 1 = Recovered]]>
		Public Property [Status] As Int16
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Costcenter]
		'''<![CDATA[Indicates if the cost center is active: 0 = inactive 1 = active]]>
		Public Property [Active] As Boolean?
		'''<![CDATA[Code (user-defined ID)]]>
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
		'''<![CDATA[Description (text)]]>
		Public Property [Description] As String
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
	Public Class [Costunit]
		'''<![CDATA[Code (user-defined)]]>
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
		'''<![CDATA[Description (text)]]>
		Public Property [Description] As String
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

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Department]
		'''<![CDATA[Department Code]]>
		Public Property [Code] As String
		'''<![CDATA[Cost center Code]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Cost center description]]>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Department description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Explanation or extra information can be stored in the notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Code")>
	Public Class [Division]
		'''<![CDATA[Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed]]>
		Public Property [BlockingStatus] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [Code] As Int32
		'''<![CDATA[Country of the division. Is used for determination of legislation]]>
		Public Property [Country] As String
		'''<![CDATA[Description of Country]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryDescription] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Default currency of the division]]>
		Public Property [Currency] As String
		'''<![CDATA[Description of Currency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrencyDescription] As String
		'''<![CDATA[Owner account of the division]]>
		Public Property [Customer] As Guid?
		'''<![CDATA[Owner account code of the division]]>
		Public Property [CustomerCode] As String
		'''<![CDATA[Owner account name of the division]]>
		Public Property [CustomerName] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Number that customers give to the division]]>
		Public Property [HID] As Int64?
		'''<![CDATA[True for the main (hosting) division]]>
		Public Property [Main] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Siret Number of the division (France)]]>
		Public Property [SiretNumber] As String
		'''<![CDATA[Date on which the division becomes active]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Regular administrations will have status 0.  Currently, the only other possibility is 'archived' (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Number of your local tax authority (Germany)]]>
		Public Property [TaxOfficeNumber] As String
		'''<![CDATA[Local tax reference number (Germany)]]>
		Public Property [TaxReferenceNumber] As String
		'''<![CDATA[VAT number]]>
		Public Property [VATNumber] As String
		'''<![CDATA[Customer value, hyperlink to external website]]>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [JobGroup]
		'''<![CDATA[Job group code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Job group description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Explanation or extra information can be stored in the notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [JobTitle]
		'''<![CDATA[Job title code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Job title description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference job code]]>
		Public Property [JobCode] As String
		'''<![CDATA[Group this job title belongs to]]>
		Public Property [JobGroup] As Guid?
		'''<![CDATA[Job group code]]>
		Public Property [JobGroupCode] As String
		'''<![CDATA[Job group description]]>
		Public Property [JobGroupDescription] As String
		'''<![CDATA[Job title represents job level from]]>
		Public Property [JobLevelFrom] As Int32?
		'''<![CDATA[Job title represents job level to]]>
		Public Property [JobLevelTo] As Int32?
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Explanation or extra information can be stored in the notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [LeaveRegistration]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of leave]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee linked to the leave]]>
		Public Property [Employee] As Guid
		'''<![CDATA[Employee full name]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric ID of the employee]]>
		Public Property [EmployeeHID] As Int32
		'''<![CDATA[End date of leave]]>
		Public Property [EndDate] As DateTime
		'''<![CDATA[End time on the last day of leave stored as DateTime, and the date should be ignored]]>
		Public Property [EndTime] As DateTime?
		'''<![CDATA[Total number of leave hours]]>
		Public Property [Hours] As Double
		'''<![CDATA[Hours of leave on the first day]]>
		Public Property [HoursFirstDay] As Double?
		'''<![CDATA[Hours of leave on the last day]]>
		Public Property [HoursLastDay] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Type of leave]]>
		Public Property [LeaveType] As Guid
		'''<![CDATA[Code for type of leave]]>
		Public Property [LeaveTypeCode] As String
		'''<![CDATA[Description for type of leave]]>
		Public Property [LeaveTypeDescription] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra information for leave]]>
		Public Property [Notes] As String
		'''<![CDATA[Start date of leave]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[Start time on the first day of leave stored as DateTime, and the date should be ignored]]>
		Public Property [StartTime] As DateTime?
		'''<![CDATA[Status of leave, 1 = Submitted, 2 = Approved, 3 = Rejected]]>
		Public Property [Status] As Int16
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Schedule]
		'''<![CDATA[Obsolete]]>
		Public Property [Active] As Byte?
		'''<![CDATA[Average hours per week in a schedule]]>
		Public Property [AverageHours] As Double?
		'''<![CDATA[Schedule code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Average days per week in the schedule]]>
		Public Property [Days] As Double?
		'''<![CDATA[Description of the schedule]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Employment ID for schedule]]>
		Public Property [Employment] As Guid?
		'''<![CDATA[Employment number]]>
		Public Property [EmploymentHID] As Int32?
		'''<![CDATA[End date of the schedule]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Number of hours per week in a CLA for which the schedule is built]]>
		Public Property [Hours] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Number of hours which are built up each week for later leave]]>
		Public Property [LeaveHoursCompensation] As Double?
		'''<![CDATA[Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No]]>
		Public Property [Main] As Byte?
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Part-time factor for payroll calculation. Value between 0 and 1]]>
		Public Property [PaymentParttimeFactor] As Double?
		'''<![CDATA[Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day]]>
		Public Property [ScheduleType] As Int32?
		'''<![CDATA[Description of the schedule type]]>
		Public Property [ScheduleTypeDescription] As String
		'''<![CDATA[Week in the schedule which is used to start with. By default the number will be 1.]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Week to start the schedule from for an employee]]>
		Public Property [StartWeek] As Int32?
	End Class

End Namespace