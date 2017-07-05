' Last generated on 2017-05-05 12:58:35Z

Namespace Subscription

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [Subscription]
		'''<![CDATA[Indicates if subscription is blocked for time cost entry]]>
		Public Property [BlockEntry] As Boolean?
		'''<![CDATA[Date of cancellation]]>
		Public Property [CancellationDate] As DateTime?
		'''<![CDATA[Reference to Classification]]>
		Public Property [Classification] As Guid?
		'''<![CDATA[Code of Classification]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationCode] As String
		'''<![CDATA[Description of Classification]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Purchase order number of customer]]>
		Public Property [CustomerPONumber] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[End date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Invoice Day]]>
		Public Property [InvoiceDay] As Byte?
		'''<![CDATA[Invoice date]]>
		Public Property [InvoicedTo] As DateTime?
		'''<![CDATA[Reference to invoice account]]>
		Public Property [InvoiceTo] As Guid?
		'''<![CDATA[Reference to contact person of invoice account]]>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<![CDATA[Name of contact person of invoice account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<![CDATA[Name of invoice account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
		'''<![CDATA[Invoicing start date]]>
		Public Property [InvoicingStartDate] As DateTime?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Number]]>
		Public Property [Number] As Int32
		'''<![CDATA[Reference to order account]]>
		Public Property [OrderedBy] As Guid?
		'''<![CDATA[Reference of contact person of order account]]>
		Public Property [OrderedByContactPerson] As Guid?
		'''<![CDATA[Name of contact person of order account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<![CDATA[Name of order account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<![CDATA[Payment condition]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Indicates if subscription is printed]]>
		Public Property [Printed] As Boolean
		'''<![CDATA[Reference to reason cancelled]]>
		Public Property [ReasonCancelled] As Guid?
		'''<![CDATA[Code of ReasonCancelled]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCancelledCode] As String
		'''<![CDATA[Description of ReasonCancelled]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCancelledDescription] As String
		'''<![CDATA[Start date]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[Collection of subscription lines]]>
		Public Property [SubscriptionLines] As IEnumerable(Of Models.Subscription.SubscriptionLine)
		'''<![CDATA[Collection of restriction employees]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionRestrictionEmployees] As IEnumerable(Of Models.Subscription.SubscriptionRestrictionEmployee)
		'''<![CDATA[Collection of restriction items]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionRestrictionItems] As IEnumerable(Of Models.Subscription.SubscriptionRestrictionItem)
		'''<![CDATA[Reference to subscription type]]>
		Public Property [SubscriptionType] As Guid
		'''<![CDATA[Code of SubscriptionType]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionTypeCode] As String
		'''<![CDATA[Description of SubscriptionType]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionTypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionLine]
		'''<![CDATA[Amount in the default currency of the company]]>
		Public Property [AmountDC] As Double
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double
		'''<![CDATA[Cost center]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Cost unit]]>
		Public Property [Costunit] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Discount percentage]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Entry ID]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[From date]]>
		Public Property [FromDate] As DateTime
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to Item]]>
		Public Property [Item] As Guid
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Line number]]>
		Public Property [LineNumber] As Int32
		'''<![CDATA[Reference to LineType]]>
		Public Property [LineType] As Int16?
		'''<![CDATA[Description of LineType]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineTypeDescription] As String
		'''<![CDATA[Net price in the currency of the transaction]]>
		Public Property [NetPrice] As Double
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double
		'''<![CDATA[To date]]>
		Public Property [ToDate] As DateTime?
		'''<![CDATA[Unit code]]>
		Public Property [UnitCode] As String
		'''<![CDATA[Description of Unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Unit price in the currency of the transaction (price * unit factor)]]>
		Public Property [UnitPrice] As Double
		'''<![CDATA[Vat Amount in the currency of the transaction]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[VATCode]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionLineType]
		'''<![CDATA[Description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Description] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Int16
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionReasonCode]
		'''<![CDATA[Indicates if the reason code is active]]>
		Public Property [Active] As Boolean
		'''<![CDATA[Subscription reason code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Remarks]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionRestrictionEmployee]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Employee linked to the restriction]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[Readable ID of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeHID] As Int32?
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
		'''<![CDATA[Reference to subscription]]>
		Public Property [Subscription] As Guid
		'''<![CDATA[Description of subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Number of subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionRestrictionItem]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item linked to the restriction]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Reference to subscription]]>
		Public Property [Subscription] As Guid
		'''<![CDATA[Description of subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Number of subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SubscriptionType]
		'''<![CDATA[Code]]>
		Public Property [Code] As String
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
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
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
	End Class

End Namespace