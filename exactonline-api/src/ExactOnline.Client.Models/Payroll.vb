' Last generated on 2017-05-05 12:58:35Z

Namespace Payroll

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ActiveEmployment]
		'''<![CDATA[The average number of contract days that an employee works per week]]>
		Public Property [AverageDaysPerWeek] As Double?
		'''<![CDATA[The average number of contract hours that an employee works per week]]>
		Public Property [AverageHoursPerWeek] As Double?
		'''<![CDATA[Employment contract ID]]>
		Public Property [Contract] As Guid?
		'''<![CDATA[Document ID of the employment contract]]>
		Public Property [ContractDocument] As Guid?
		'''<![CDATA[End date of employment contract]]>
		Public Property [ContractEndDate] As DateTime?
		'''<![CDATA[Employment probation end date]]>
		Public Property [ContractProbationEndDate] As DateTime?
		'''<![CDATA[Employment probation period]]>
		Public Property [ContractProbationPeriod] As Int32?
		'''<![CDATA[Start date of employment contract]]>
		Public Property [ContractStartDate] As DateTime?
		'''<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
		Public Property [ContractType] As Int32?
		'''<![CDATA[Description of employment contract type]]>
		Public Property [ContractTypeDescription] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Department of employee]]>
		Public Property [Department] As Guid?
		'''<![CDATA[Department code of employee]]>
		Public Property [DepartmentCode] As String
		'''<![CDATA[Description of department]]>
		Public Property [DepartmentDescription] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee ID]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric number of Employee]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[Organization of employment]]>
		Public Property [EmploymentOrganization] As Guid?
		'''<![CDATA[End date of employment]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Numeric ID of the employment]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Hourly wage]]>
		Public Property [HourlyWage] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Internal rate for time & billing or professional service user]]>
		Public Property [InternalRate] As Double?
		'''<![CDATA[Job title of employee]]>
		Public Property [Jobtitle] As Guid?
		'''<![CDATA[Description of job title]]>
		Public Property [JobtitleDescription] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[ID of employment ended]]>
		Public Property [ReasonEnd] As Int32?
		'''<![CDATA[Reason of end of employment]]>
		Public Property [ReasonEndDescription] As String
		'''<![CDATA[Reason of ended flexible employment]]>
		Public Property [ReasonEndFlex] As Int32?
		'''<![CDATA[Other reason for end of employment]]>
		Public Property [ReasonEndFlexDescription] As String
		'''<![CDATA[Employment salary]]>
		Public Property [Salary] As Guid?
		'''<![CDATA[Work schedule]]>
		Public Property [Schedule] As Guid?
		'''<![CDATA[Average hours per week in a schedule.]]>
		Public Property [ScheduleAverageHours] As Double?
		'''<![CDATA[Work schedule code]]>
		Public Property [ScheduleCode] As String
		'''<![CDATA[Number of days of work per week]]>
		Public Property [ScheduleDays] As Double?
		'''<![CDATA[Description of work schedule]]>
		Public Property [ScheduleDescription] As String
		'''<![CDATA[Number of work hours per week.]]>
		Public Property [ScheduleHours] As Double?
		'''<![CDATA[Start date of employment]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
		Public Property [StartDateOrganization] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Employee]
		'''<![CDATA[Obsolete]]>
		Public Property [ActiveEmployment] As Byte?
		'''<![CDATA[Second address line]]>
		Public Property [AddressLine2] As String
		'''<![CDATA[Third address line]]>
		Public Property [AddressLine3] As String
		'''<![CDATA[Street of address]]>
		Public Property [AddressStreet] As String
		'''<![CDATA[Street number of address]]>
		Public Property [AddressStreetNumber] As String
		'''<![CDATA[Street number suffix of address]]>
		Public Property [AddressStreetNumberSuffix] As String
		'''<![CDATA[Birth date]]>
		Public Property [BirthDate] As DateTime?
		'''<![CDATA[Birth name]]>
		Public Property [BirthName] As String
		'''<![CDATA[Birth middle name]]>
		Public Property [BirthNamePrefix] As String
		'''<![CDATA[Birth place]]>
		Public Property [BirthPlace] As String
		'''<![CDATA[Email of the employee at the office]]>
		Public Property [BusinessEmail] As String
		'''<![CDATA[Fax number of the employee at the office]]>
		Public Property [BusinessFax] As String
		'''<![CDATA[Office mobile number of the employee]]>
		Public Property [BusinessMobile] As String
		'''<![CDATA[Phone number of the employee at the office]]>
		Public Property [BusinessPhone] As String
		'''<![CDATA[Phone extension of the employee at the office]]>
		Public Property [BusinessPhoneExtension] As String
		'''<![CDATA[Obsolete]]>
		Public Property [CASONumber] As String
		'''<![CDATA[City]]>
		Public Property [City] As String
		'''<![CDATA[Code of the employee]]>
		Public Property [Code] As String
		'''<![CDATA[Country code]]>
		Public Property [Country] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Customer ID]]>
		Public Property [Customer] As Guid?
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Email address]]>
		Public Property [Email] As String
		'''<![CDATA[Employee number]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[End date of the employee]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[First name of the employee]]>
		Public Property [FirstName] As String
		'''<![CDATA[Full name of the employee]]>
		Public Property [FullName] As String
		'''<![CDATA[Gender]]>
		Public Property [Gender] As String
		'''<![CDATA[Numeric ID of the employee]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Initials]]>
		Public Property [Initials] As String
		'''<![CDATA[IsActive]]>
		Public Property [IsActive] As Boolean
		'''<![CDATA[Language code]]>
		Public Property [Language] As String
		'''<![CDATA[Last name]]>
		Public Property [LastName] As String
		'''<![CDATA[Description of the location of the employee (where am I?)]]>
		Public Property [LocationDescription] As String
		'''<![CDATA[Direct manager of the employee]]>
		Public Property [Manager] As Guid?
		'''<![CDATA[Date of marriage]]>
		Public Property [MaritalDate] As DateTime?
		'''<![CDATA[Marital status]]>
		Public Property [MaritalStatus] As Int16?
		'''<![CDATA[Middle name]]>
		Public Property [MiddleName] As String
		'''<![CDATA[Mobile phone]]>
		Public Property [Mobile] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Municipality]]>
		Public Property [Municipality] As String
		Public Property [NameComposition] As Int16?
		'''<![CDATA[Nationality]]>
		Public Property [Nationality] As String
		'''<![CDATA[Nick name]]>
		Public Property [NickName] As String
		'''<![CDATA[Additional notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Name of partner]]>
		Public Property [PartnerName] As String
		'''<![CDATA[Middle name of partner]]>
		Public Property [PartnerNamePrefix] As String
		'''<![CDATA[Reference to the persons table in which the personal data of the employee is stored]]>
		Public Property [Person] As Guid?
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone number extension]]>
		Public Property [PhoneExtension] As String
		'''<![CDATA[Filename of picture]]>
		Public Property [PictureFileName] As String
		'''<![CDATA[Url of picture]]>
		Public Property [PictureUrl] As String
		'''<![CDATA[Postcode]]>
		Public Property [Postcode] As String
		'''<![CDATA[Private email address]]>
		Public Property [PrivateEmail] As String
		'''<![CDATA[Social security number]]>
		Public Property [SocialSecurityNumber] As String
		'''<![CDATA[Start date of the employee]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[State]]>
		Public Property [State] As String
		'''<![CDATA[Title]]>
		Public Property [Title] As String
		'''<![CDATA[User ID of employee]]>
		Public Property [User] As Guid?
		'''<![CDATA[Name of user]]>
		Public Property [UserFullName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Employment]
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee ID]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric number of Employee]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[End date of employment]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Numeric ID of the employment]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[ID of employment ended]]>
		Public Property [ReasonEnd] As Int32?
		'''<![CDATA[Reason of end of employment]]>
		Public Property [ReasonEndDescription] As String
		'''<![CDATA[Reason of ended flexible employment]]>
		Public Property [ReasonEndFlex] As Int32?
		'''<![CDATA[Other reason for end of employment]]>
		Public Property [ReasonEndFlexDescription] As String
		'''<![CDATA[Start date of employment]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
		Public Property [StartDateOrganization] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentContract]
		'''<![CDATA[Flexible employment contract phase]]>
		Public Property [ContractFlexPhase] As Int32?
		'''<![CDATA[Flexible employment contract phase description.]]>
		Public Property [ContractFlexPhaseDescription] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Document ID of the employment contract]]>
		Public Property [Document] As Guid?
		'''<![CDATA[ID of employee]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric ID of the employee]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker]]>
		Public Property [EmployeeType] As Int32?
		'''<![CDATA[Employee type description]]>
		Public Property [EmployeeTypeDescription] As String
		'''<![CDATA[Employment ID]]>
		Public Property [Employment] As Guid?
		'''<![CDATA[Numeric ID of the employment]]>
		Public Property [EmploymentHID] As Int32?
		'''<![CDATA[End date of employment contract]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes of employment contract]]>
		Public Property [Notes] As String
		'''<![CDATA[Employment probation end date]]>
		Public Property [ProbationEndDate] As DateTime?
		'''<![CDATA[Employment probation period]]>
		Public Property [ProbationPeriod] As Int32?
		'''<![CDATA[Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other]]>
		Public Property [ReasonContract] As Int32?
		'''<![CDATA[Employment contract reason description]]>
		Public Property [ReasonContractDescription] As String
		'''<![CDATA[Sequence number]]>
		Public Property [Sequence] As Int32?
		'''<![CDATA[Start date of employment contract]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of employment contract type]]>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentContractFlexPhas]
		'''<![CDATA[Flexible employment contract phase description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentEndReason]
		'''<![CDATA[Employment end reason description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentOrganization]
		'''<![CDATA[Cost center code]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of cost center]]>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Cost unit code]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of cost unit]]>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[ID of department]]>
		Public Property [Department] As Guid?
		'''<![CDATA[Department code]]>
		Public Property [DepartmentCode] As String
		'''<![CDATA[Department description for organization]]>
		Public Property [DepartmentDescription] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[ID of employee]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Numeric ID of the employee]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[Employement ID]]>
		Public Property [Employment] As Guid?
		'''<![CDATA[Numeric ID of the employment]]>
		Public Property [EmploymentHID] As Int32?
		'''<![CDATA[Organization end date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[ID of job title]]>
		Public Property [JobTitle] As Guid?
		'''<![CDATA[Job title code]]>
		Public Property [JobTitleCode] As String
		'''<![CDATA[Job title description]]>
		Public Property [JobTitleDescription] As String
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Explanation or extra information can be stored in the notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Organization start date]]>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [EmploymentSalary]
		'''<![CDATA[The average number of contract days that an employee works per week]]>
		Public Property [AverageDaysPerWeek] As Double?
		'''<![CDATA[The average number of contract hours that an employee works per week]]>
		Public Property [AverageHoursPerWeek] As Double?
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee ID]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Employee number]]>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[Employment]]>
		Public Property [Employment] As Guid?
		'''<![CDATA[Employment number]]>
		Public Property [EmploymentHID] As Int32?
		'''<![CDATA[Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)]]>
		Public Property [EmploymentSalaryType] As Int32?
		'''<![CDATA[Salary type description]]>
		Public Property [EmploymentSalaryTypeDescription] As String
		'''<![CDATA[Salary record end date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Salary when working fulltime]]>
		Public Property [FulltimeAmount] As Double?
		'''<![CDATA[Hourly wage]]>
		Public Property [HourlyWage] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Internal rate for time & billing or professional service user]]>
		Public Property [InternalRate] As Double?
		'''<![CDATA[Employee job level in context of a wage scale]]>
		Public Property [JobLevel] As Int32?
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Salary when working parttime]]>
		Public Property [ParttimeAmount] As Double?
		'''<![CDATA[Contract hours / Fulltime contract hours]]>
		Public Property [ParttimeFactor] As Double?
		'''<![CDATA[Employee wage scale]]>
		Public Property [Scale] As String
		'''<![CDATA[Employment schedule]]>
		Public Property [Schedule] As Guid?
		'''<![CDATA[Employment schedule code]]>
		Public Property [ScheduleCode] As String
		'''<![CDATA[Description of employment schedule]]>
		Public Property [ScheduleDescription] As String
		'''<![CDATA[Salary record start date]]>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TaxEmploymentEndFlexCode]
		'''<![CDATA[Code of flexible employment contract phase]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of flexible employment contract phase]]>
		Public Property [Description] As String
		'''<![CDATA[End date of flexible employment contract]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Start date of flexible employment contract phase]]>
		Public Property [StartDate] As DateTime?
	End Class

End Namespace