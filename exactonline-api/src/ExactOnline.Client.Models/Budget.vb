' Last generated on 2017-05-05 12:58:34Z

Namespace Budget

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Budget]
		'''<![CDATA[Budget amount (always in the default currency of the company)]]>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Budget scenario]]>
		Public Property [BudgetScenario] As Guid?
		'''<![CDATA[Code of BudgetScenario]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetScenarioCode] As String
		'''<![CDATA[Description of BudgetScenario]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BudgetScenarioDescription] As String
		'''<![CDATA[Used for cost center-specific budgets - NULL otherwise]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Used for cost unit-specific budgets - NULL otherwise]]>
		Public Property [Costunit] As String
		'''<![CDATA[Description of Costunit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostunitDescription] As String
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
		'''<![CDATA[G/L account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Numerical ID. Never displayed to the user, but it may have its use for performance reasons]]>
		Public Property [HID] As Int64?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Used for item-specific budgets - NULL otherwise]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
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
		'''<![CDATA[Period (combined with financial year)]]>
		Public Property [ReportingPeriod] As Int16?
		'''<![CDATA[Financial year]]>
		Public Property [ReportingYear] As Int16?
	End Class

End Namespace