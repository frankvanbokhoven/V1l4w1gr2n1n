' Last generated on 2017-05-05 12:58:35Z

Namespace Project

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [CostTransaction]
		'''<![CDATA[Account linked to the transaction]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[This property is obsolete. Use property 'AmountFC' instead.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Amount of the transaction in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Attachment linked to the transaction (not mandatory)]]>
		Public Property [Attachment] As Guid?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency of the amount]]>
		Public Property [Currency] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Description of Division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<![CDATA[Employee linked to the transaction]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Entrynumber]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Errortext, used for the backgroundjobs]]>
		Public Property [ErrorText] As String
		'''<![CDATA[Reference to ProjectWBS (work breakdown structure)]]>
		Public Property [Expense] As Guid?
		'''<![CDATA[Description of ProjectWBS]]>
		Public Property [ExpenseDescription] As String
		'''<![CDATA[Status of the transaction]]>
		Public Property [HourStatus] As Int16?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactionsItems of other types are linked to costtransactions]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes linked to the transaction (not mandatory)]]>
		Public Property [Notes] As String
		'''<![CDATA[This property is obsolete. Use property 'PriceFC' instead.]]>
		Public Property [Price] As Double?
		'''<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
		Public Property [PriceFC] As Double?
		'''<![CDATA[Project linked to the transaction]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Project account linked to the transaction (not mandatory)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccount] As Guid?
		'''<![CDATA[Project account code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountCode] As String
		'''<![CDATA[Project account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountName] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity of the transaction]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Subscription linked to the transaction]]>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Account linked to the subscription]]>
		Public Property [SubscriptionAccount] As Guid?
		'''<![CDATA[Subscription account code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountCode] As String
		'''<![CDATA[Subscription account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountName] As String
		'''<![CDATA[Description of the subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Subscription number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32?
		'''<![CDATA[Type of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ItemId")>
	Public Class [HourCostType]
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ItemId] As Guid
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [InvoiceTerm]
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[WBS's deliverable linked to invoice term]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Deliverable] As String
		'''<![CDATA[Description of invoice term]]>
		Public Property [Description] As String
		'''<![CDATA[Division number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Invoice date]]>
		Public Property [InvoiceDate] As DateTime?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Percentage of amount per project's budgeted amount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Percentage] As Double?
		'''<![CDATA[Reference to project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Reference to VATCode]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[VATCode percentage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATPercentage] As Double?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Project]
		'''<![CDATA[The account for this project]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Contact person of Account]]>
		Public Property [AccountContact] As Guid?
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Is additional invoice is allowed for project]]>
		Public Property [AllowAdditionalInvoicing] As Boolean?
		'''<![CDATA[Block time and cost entries]]>
		Public Property [BlockEntry] As Boolean?
		'''<![CDATA[Block rebilling]]>
		Public Property [BlockRebilling] As Boolean?
		'''<![CDATA[Budgeted amount of sales in the default currency of the company]]>
		Public Property [BudgetedAmount] As Double?
		'''<![CDATA[Budgeted amount of costs in the default currency of the company]]>
		Public Property [BudgetedCosts] As Double?
		'''<![CDATA[Collection of budgeted hours]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetedHoursPerHourType] As IEnumerable(Of Models.Project.ProjectHourBudget)
		'''<![CDATA[Budgeted amount of revenue in the default currency of the company]]>
		Public Property [BudgetedRevenue] As Double?
		'''<![CDATA[Budget type]]>
		Public Property [BudgetType] As Int16?
		'''<![CDATA[Budget type description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetTypeDescription] As String
		'''<![CDATA[Used only for PSA to link a project classification to the project]]>
		Public Property [Classification] As Guid?
		'''<![CDATA[Description of Classification]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<![CDATA[Code]]>
		Public Property [Code] As String
		'''<![CDATA[Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostsAmountFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Used only for PSA to store the customer's PO number]]>
		Public Property [CustomerPOnumber] As String
		'''<![CDATA[Description of the project]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Name of Division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionName] As String
		'''<![CDATA[End date of the project. In combination with the start date the status is determined]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting]]>
		Public Property [FixedPriceItem] As Guid?
		'''<![CDATA[Description of FixedPriceItem]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FixedPriceItemDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Is invoice as quoted]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAsQuoted] As Boolean
		'''<![CDATA[Collection of invoice terms]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceTerms] As IEnumerable(Of Models.Project.InvoiceTerm)
		'''<![CDATA[Responsible person for this project]]>
		Public Property [Manager] As Guid?
		'''<![CDATA[Name of Manager]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ManagerFullname] As String
		'''<![CDATA[Purchase markup percentage]]>
		Public Property [MarkupPercentage] As Double?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[For additional information about projects]]>
		Public Property [Notes] As String
		'''<![CDATA[Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting]]>
		Public Property [PrepaidItem] As Guid?
		'''<![CDATA[Description of PrepaidItem]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrepaidItemDescription] As String
		'''<![CDATA[PrepaidType: 1-Retainer, 2-Hour type bundle]]>
		Public Property [PrepaidType] As Int16?
		'''<![CDATA[Description of PrepaidType]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrepaidTypeDescription] As String
		'''<![CDATA[Collection of employee restrictions]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionEmployees] As IEnumerable(Of Models.Project.ProjectRestrictionEmployee)
		'''<![CDATA[Collection of item restrictions]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionItems] As IEnumerable(Of Models.Project.ProjectRestrictionItem)
		'''<![CDATA[Collection of rebilling restrictions]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectRestrictionRebillings] As IEnumerable(Of Models.Project.ProjectRestrictionRebilling)
		'''<![CDATA[Budgeted time. Total number of hours estimated for the fixed price project]]>
		Public Property [SalesTimeQuantity] As Double?
		'''<![CDATA[Source quotation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SourceQuotation] As Guid?
		'''<![CDATA[Start date of a project. In combination with the end date the status is determined]]>
		Public Property [StartDate] As DateTime?
		Public Property [TimeQuantityToAlert] As Double?
		'''<![CDATA[Reference to ProjectTypes]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Using billing milestones]]>
		Public Property [UseBillingMilestones] As Boolean?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ProjectBudgetType]
		'''<![CDATA[Description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int16
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectHourBudget]
		'''<![CDATA[Number of hours]]>
		Public Property [Budget] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Hour type of budget]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Reference to project]]>
		Public Property [Project] As Guid
		'''<![CDATA[Code of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectPlanning]
		'''<![CDATA[Account linked to the project planning]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BGTStatus] As Int16?
		'''<![CDATA[Status of the external calendar, 0 = No error, 1 = Credentials error, 2 = Technical error, 3 = Both credentials & technical errors, 4 = In progress]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CommunicationErrorStatus] As Int16?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of project planning]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee linked to the project planning]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Code of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeCode] As String
		'''<![CDATA[Numeric ID of the employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[End date of the project planning]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Hours of the project planning]]>
		Public Property [Hours] As Double?
		'''<![CDATA[The type of hour for the project planning, item with 'Time' type]]>
		Public Property [HourType] As Guid?
		'''<![CDATA[Code of the hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeCode] As String
		'''<![CDATA[Description of the hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates whether the project planning is separated from the recurring planning]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBrokenRecurrence] As Boolean?
		'''<![CDATA[Date modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Modifier user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Modifier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[For additional information about project planning]]>
		Public Property [Notes] As String
		'''<![CDATA[Indicates whether the entries can have over allocated planning hours]]>
		Public Property [OverAllocate] As Boolean?
		'''<![CDATA[Project linked to the planning]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Recurring planning linked to the project planning]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectPlanningRecurring] As Guid?
		'''<![CDATA[WBS linked to the project planning]]>
		Public Property [ProjectWBS] As Guid?
		'''<![CDATA[Description of WBS]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<![CDATA[Start date of the project planning]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Status of the project planning, 1 = Reserved, 2 = Planned]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Type of the project planning, it will always is 4 (employee)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectPlanningRecurring]
		'''<![CDATA[Account linked to the recurring planning]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BGTStatus] As Int16?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Indicates whether the recurring planning is day of the month or weekday of the month]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DayOrThe] As Int32?
		'''<![CDATA[Description of recurring planning]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee linked to the recurring planning]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Code of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeCode] As String
		'''<![CDATA[Numeric ID of the employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[End date of the recurring planning]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Indicates whether the recurring planning is end on end date or end after number of times]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDateOrAfter] As Int32?
		'''<![CDATA[End time for the recurring planning to be active]]>
		Public Property [EndTime] As DateTime?
		'''<![CDATA[Number of hours for the recurring planning]]>
		Public Property [Hours] As Double?
		'''<![CDATA[Hour type of the recurring planning, item with 'Time' type]]>
		Public Property [HourType] As Guid?
		'''<![CDATA[Code of the hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeCode] As String
		'''<![CDATA[Description of the hour type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HourTypeDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Date modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Modifier user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Modifier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Day of the monthly recurring]]>
		Public Property [MonthPatternDay] As Byte?
		'''<![CDATA[Ordinal number of week day for the monthly recurring planning, 1 = first, 2 = second, 3 = third, 4 = fourth, 31 = last]]>
		Public Property [MonthPatternOrdinalDay] As Byte?
		'''<![CDATA[Ordinal week day of the monthly recurring planning, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday, 7 = Sunday]]>
		Public Property [MonthPatternOrdinalWeek] As Byte?
		'''<![CDATA[For additional information about recurring planning]]>
		Public Property [Notes] As String
		'''<![CDATA[Number of times the planning recurs]]>
		Public Property [NumberOfRecurrences] As Byte?
		'''<![CDATA[Indicates whether the entries can have over allocated planning hours]]>
		Public Property [OverAllocate] As Boolean?
		'''<![CDATA[Number of planning times for weekly or monthly recurring planning]]>
		Public Property [PatternFrequency] As Byte?
		'''<![CDATA[Project linked to the recurring planning]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Type of the recurring planning, 1 = weekly, 2 = monthly]]>
		Public Property [ProjectPlanningRecurringType] As Byte?
		'''<![CDATA[WBS linked to the recurring planning]]>
		Public Property [ProjectWBS] As Guid?
		'''<![CDATA[Description of WBS]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<![CDATA[Start date of the recurring planning]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Start time for the recurring planning to be active]]>
		Public Property [StartTime] As DateTime?
		'''<![CDATA[Status of the project planning, 1 = Reserved, 2 = Planned]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Week day for the weekly recurring planning]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WeekPatternDay] As Byte?
		'''<![CDATA[Create planning on Friday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternFriday] As Boolean?
		'''<![CDATA[Create planning on Monday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternMonday] As Boolean?
		'''<![CDATA[Create planning on Saturday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternSaturday] As Boolean?
		'''<![CDATA[Create planning on Sunday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternSunday] As Boolean?
		'''<![CDATA[Create planning on Thursday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternThursday] As Boolean?
		'''<![CDATA[Create planning on Tuesday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternTuesday] As Boolean?
		'''<![CDATA[Create planning on Wednesday, apply to weekly pattern recurring planning only]]>
		Public Property [WeekPatternWednesday] As Boolean?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionEmployee]
		'''<![CDATA[Date created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Creator user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Creator name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee linked to the restriction]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Readable ID of the employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Date modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Modifier user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Modifier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Project linked to the restriction]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Project code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Project description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionItem]
		'''<![CDATA[Date created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Creator user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Creator name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item linked to the restriction]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of the item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates if the item is a time unit item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemIsTime] As Byte?
		'''<![CDATA[Date modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Modifier user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Modifier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Project linked to the restriction]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Project code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Project description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProjectRestrictionRebilling]
		'''<![CDATA[Cost type reference]]>
		Public Property [CostTypeRebill] As Guid?
		'''<![CDATA[Cost type code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostTypeRebillCode] As String
		'''<![CDATA[Cost type description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostTypeRebillDescription] As String
		'''<![CDATA[Date created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Creator user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Creator name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Date modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Modifier user ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Modifier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Project linked to the restriction]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Project code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Project description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [RecentCost]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Reference to Account]]>
		Public Property [AccountId] As Guid?
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Amount approved]]>
		Public Property [AmountApproved] As Double
		'''<![CDATA[Amount draft]]>
		Public Property [AmountDraft] As Double
		'''<![CDATA[Amount rejected]]>
		Public Property [AmountRejected] As Double
		'''<![CDATA[Amount submitted]]>
		Public Property [AmountSubmitted] As Double
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime
		'''<![CDATA[Entry ID]]>
		Public Property [EntryId] As Guid?
		'''<![CDATA[Reference to Expense]]>
		Public Property [Expense] As Guid?
		'''<![CDATA[Description of Expense]]>
		Public Property [ExpenseDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [Id] As Int32
		'''<![CDATA[Code of Item]]>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[Reference to Item]]>
		Public Property [ItemId] As Guid?
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Code of Project]]>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Reference to Project]]>
		Public Property [ProjectId] As Guid?
		'''<![CDATA[Quantity approved]]>
		Public Property [QuantityApproved] As Double
		'''<![CDATA[Quantity draft]]>
		Public Property [QuantityDraft] As Double
		'''<![CDATA[Quantity rejected]]>
		Public Property [QuantityRejected] As Double
		'''<![CDATA[Quantity submitted]]>
		Public Property [QuantitySubmitted] As Double
		'''<![CDATA[Week number]]>
		Public Property [WeekNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Id")>
	Public Class [RecentHour]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Reference to Account]]>
		Public Property [AccountId] As Guid?
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Reference to Activity]]>
		Public Property [Activity] As Guid?
		'''<![CDATA[Description of Activity]]>
		Public Property [ActivityDescription] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime
		'''<![CDATA[Entry ID]]>
		Public Property [EntryId] As Guid?
		'''<![CDATA[Hours approved]]>
		Public Property [HoursApproved] As Double
		'''<![CDATA[Billable hours approved]]>
		Public Property [HoursApprovedBillable] As Double
		'''<![CDATA[Hours draft]]>
		Public Property [HoursDraft] As Double
		'''<![CDATA[Billable hours draft]]>
		Public Property [HoursDraftBillable] As Double
		'''<![CDATA[Hours rejected]]>
		Public Property [HoursRejected] As Double
		'''<![CDATA[Billable hours rejected]]>
		Public Property [HoursRejectedBillable] As Double
		'''<![CDATA[Hours submitted]]>
		Public Property [HoursSubmitted] As Double
		'''<![CDATA[Billable hours submitted]]>
		Public Property [HoursSubmittedBillable] As Double
		'''<![CDATA[Primary key]]>
		Public Property [Id] As Int32
		'''<![CDATA[Code of Item]]>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[Reference to Item]]>
		Public Property [ItemId] As Guid?
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Code of Project]]>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Reference to Project]]>
		Public Property [ProjectId] As Guid?
		'''<![CDATA[Week number]]>
		Public Property [WeekNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingAccountDetail]
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Name]]>
		Public Property [Name] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingActivitiesAndExpens]
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Description of Parent]]>
		Public Property [ParentDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [TimeAndBillingEntryAccount]
		'''<![CDATA[Primary key]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of account]]>
		Public Property [AccountName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ProjectId")>
	Public Class [TimeAndBillingEntryProject]
		'''<![CDATA[Code]]>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ProjectId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [TimeAndBillingEntryRecentAccount]
		'''<![CDATA[Primary key]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Date last used]]>
		Public Property [DateLastUsed] As DateTime
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingEntryRecentActivitiesAndExpens]
		'''<![CDATA[Date last used]]>
		Public Property [DateLastUsed] As DateTime
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Description of Parent]]>
		Public Property [ParentDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ItemId")>
	Public Class [TimeAndBillingEntryRecentHourCostType]
		'''<![CDATA[Date last used]]>
		Public Property [DateLastUsed] As DateTime
		'''<![CDATA[Description of item]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ItemId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ProjectId")>
	Public Class [TimeAndBillingEntryRecentProject]
		'''<![CDATA[Date last used]]>
		Public Property [DateLastUsed] As DateTime
		'''<![CDATA[Code of project]]>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of project]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ProjectId] As Guid
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingItemDetail]
		'''<![CDATA[Item code]]>
		Public Property [Code] As String
		'''<![CDATA[Description of the item code]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if fractions are allowed for quantities of this item]]>
		Public Property [IsFractionAllowedItem] As Boolean
		'''<![CDATA[Indicates if the item can be sold]]>
		Public Property [IsSalesItem] As Boolean
		'''<![CDATA[Sales currency code]]>
		Public Property [SalesCurrency] As String
		'''<![CDATA[Sales price]]>
		Public Property [SalesPrice] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TimeAndBillingProjectDetail]
		'''<![CDATA[The account for this project]]>
		Public Property [Account] As Guid?
		Public Property [AccountName] As String
		'''<![CDATA[Code of project]]>
		Public Property [Code] As String
		'''<![CDATA[Description of the project]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to ProjectTypes]]>
		Public Property [Type] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeCorrection]
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
		'''<![CDATA[Id]]>
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
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to the time entry that this corrects for]]>
		Public Property [OriginalEntryId] As Guid?
		'''<![CDATA[Quantity has to be negative value. E.g.: If original quantity is 10 and the correct quantity is 4, this quantity is -6]]>
		Public Property [Quantity] As Double?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeTransaction]
		'''<![CDATA[Account linked to the transaction]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Reference to ProjectWBS (work breakdown structure)]]>
		Public Property [Activity] As Guid?
		'''<![CDATA[Description of ProjectWBS]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ActivityDescription] As String
		'''<![CDATA[This property is obsolete. Use property 'AmountFC' instead.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Amount in the currency of the transaction of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Attachment linked to the transaction]]>
		Public Property [Attachment] As Guid?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency of the amount]]>
		Public Property [Currency] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Description of Division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<![CDATA[Employee linked to the transaction]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[End time of the transaction]]>
		Public Property [EndTime] As DateTime?
		'''<![CDATA[Entrynumber]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Errortext, used for the backgroundjobs]]>
		Public Property [ErrorText] As String
		'''<![CDATA[Status of the transaction]]>
		Public Property [HourStatus] As Int16?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactions. Items of other types are linked to cost transactions]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[True if you can use decimals for item quantity]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes linked to the transaction]]>
		Public Property [Notes] As String
		'''<![CDATA[This property is obsolete. Use property 'PriceFC' instead.]]>
		Public Property [Price] As Double?
		'''<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
		Public Property [PriceFC] As Double?
		'''<![CDATA[Project linked to the transaction]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Reference to project account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccount] As Guid?
		'''<![CDATA[Project account code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountCode] As String
		'''<![CDATA[Project account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectAccountName] As String
		'''<![CDATA[Code of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity of the transaction]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Start time of the transaction]]>
		Public Property [StartTime] As DateTime?
		'''<![CDATA[Subscription linked to the transaction]]>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Account linked to the subscription]]>
		Public Property [SubscriptionAccount] As Guid?
		'''<![CDATA[Subscription account code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountCode] As String
		'''<![CDATA[Subscription account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionAccountName] As String
		'''<![CDATA[Description of the subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Subscription number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32?
		'''<![CDATA[Type of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int16?
	End Class

End Namespace