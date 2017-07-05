' Last generated on 2017-05-05 12:58:35Z

Namespace PurchaseEntry

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [PurchaseEntry]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Batch number]]>
		Public Property [BatchNumber] As Int32?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Reference to document]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Document number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Document subject]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Date when payment should be done]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[Entry date]]>
		Public Property [EntryDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Description of ExternalLink]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalLinkDescription] As String
		Public Property [ExternalLinkReference] As String
		'''<![CDATA[G account amount FC]]>
		Public Property [GAccountAmountFC] As Double?
		'''<![CDATA[Invoice number]]>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Journal]]>
		Public Property [Journal] As String
		'''<![CDATA[Description of Journal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Order number]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[Payment condition]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
		Public Property [PaymentReference] As String
		Public Property [ProcessNumber] As Int32?
		'''<![CDATA[Collection of lines]]>
		Public Property [PurchaseEntryLines] As IEnumerable(Of Models.PurchaseEntry.PurchaseEntryLine)
		'''<![CDATA[Currency exchange rate]]>
		Public Property [Rate] As Double?
		'''<![CDATA[Reporting period]]>
		Public Property [ReportingPeriod] As Int16?
		'''<![CDATA[Reporting year]]>
		Public Property [ReportingYear] As Int16?
		'''<![CDATA[Indicates that amounts are reversed]]>
		Public Property [Reversal] As Boolean?
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Reference to supplier (account)]]>
		Public Property [Supplier] As Guid?
		'''<![CDATA[Name of supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Vat Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[Vat Amount in the currency of the transaction]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[Your reference]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [PurchaseEntryLine]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Reference to asset]]>
		Public Property [Asset] As Guid?
		'''<![CDATA[Asset description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<![CDATA[Reference to cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Reference to cost unit]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of CostUnit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Reference to header of the purchase entry]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[General ledger account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Serial number]]>
		Public Property [SerialNumber] As String
		'''<![CDATA[Reference to subscription]]>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Description of Subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Reference to tracking number]]>
		Public Property [TrackingNumber] As Guid?
		'''<![CDATA[Description of TrackingNumber]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TrackingNumberDescription] As String
		'''<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<![CDATA[VAT amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[VAT base amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountDC] As Double?
		'''<![CDATA[VAT base amount in the currency of the transaction]]>
		Public Property [VATBaseAmountFC] As Double?
		'''<![CDATA[VAT code]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[VAT percentage]]>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[Withholding tax amount for spanish legislation]]>
		Public Property [WithholdingAmountDC] As Double?
		'''<![CDATA[Withholding tax key for spanish legislation]]>
		Public Property [WithholdingTax] As String
	End Class

End Namespace