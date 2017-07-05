' Last generated on 2017-05-05 12:58:35Z

Namespace SalesEntry

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("EntryID")>
	Public Class [SalesEntry]
		'''<![CDATA[Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)]]>
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
		'''<![CDATA[Currency for the invoice. By default this is the currency of the administration]]>
		Public Property [Currency] As String
		'''<![CDATA[Reference to customer (account)]]>
		Public Property [Customer] As Guid?
		'''<![CDATA[Name of customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerName] As String
		'''<![CDATA[Description. Can be different for header and lines]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Document that is manually linked to the invoice]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[The date when the invoice is entered]]>
		Public Property [EntryDate] As DateTime?
		'''<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Description of ExternalLink]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalLinkDescription] As String
		'''<![CDATA[Reference of ExternalLink]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExternalLinkReference] As String
		'''<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Indicates whether the invoice has extra duty]]>
		Public Property [IsExtraDuty] As Boolean?
		'''<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
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
		'''<![CDATA[Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[The payment condition used for due date and discount calculation]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
		Public Property [PaymentReference] As String
		Public Property [ProcessNumber] As Int32?
		'''<![CDATA[Foreign currency rate]]>
		Public Property [Rate] As Double?
		'''<![CDATA[The period of the transaction lines. The period should exist in the period date table]]>
		Public Property [ReportingPeriod] As Int16?
		'''<![CDATA[The financial year to which the entry belongs. The financial year should exist in the period date table]]>
		Public Property [ReportingYear] As Int16?
		'''<![CDATA[Indicates if amounts are reversed]]>
		Public Property [Reversal] As Boolean?
		'''<![CDATA[Collection of lines]]>
		Public Property [SalesEntryLines] As IEnumerable(Of Models.SalesEntry.SalesEntryLine)
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Vat amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[Vat amount in the currency of the transaction]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[The invoice number of the customer]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesEntryLine]
		'''<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[For normal lines it's the amount excluding VAT]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Reference to Asset]]>
		Public Property [Asset] As Guid?
		'''<![CDATA[Description of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<![CDATA[Reference to Cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Reference to Cost unit]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of CostUnit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Description. Can be different for header and lines]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<![CDATA[Extra duty percentage for the item]]>
		Public Property [ExtraDutyPercentage] As Double?
		'''<![CDATA[The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates the sequence of the lines within one entry]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Extra notes]]>
		Public Property [Notes] As String
		'''<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Serial number]]>
		Public Property [SerialNumber] As String
		'''<![CDATA[When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Description of Subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Obsolete]]>
		Public Property [TaxSchedule] As Guid?
		'''<![CDATA[Reference to TrackingNumber]]>
		Public Property [TrackingNumber] As Guid?
		'''<![CDATA[Description of TrackingNumber]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TrackingNumberDescription] As String
		'''<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<![CDATA[VAT amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. ]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC]]>
		Public Property [VATBaseAmountDC] As Double?
		'''<![CDATA[The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It's an internal value]]>
		Public Property [VATBaseAmountFC] As Double?
		'''<![CDATA[The VAT code used when the invoice was registered]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace