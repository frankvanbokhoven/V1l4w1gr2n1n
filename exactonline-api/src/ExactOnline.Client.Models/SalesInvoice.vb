' Last generated on 2017-05-05 12:58:35Z

Namespace SalesInvoice

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [InvoiceSalesOrder]
		'''<![CDATA[Invoice creation mode- 0: Per customer 1: Per sales order]]>
		Public Property [CreateMode] As Int32?
		'''<![CDATA[Stock entries entry number.]]>
		Public Property [DeliveryNumber] As Int32?
		'''<![CDATA[Stock entries entry end date.]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Errors in the process.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Errors] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.]]>
		Public Property [InvoiceMode] As Int32?
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Number of invoices successfully created.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [NumberOfCreatedInvoices] As Int32?
		'''<![CDATA[Number of invoices failed to create.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [NumberOfFailedInvoices] As Int32?
		'''<![CDATA[Collection of Sales order IDs.]]>
		Public Property [SalesOrderIDs] As IEnumerable(Of Models.SalesInvoice.SalesOrderID)
		'''<![CDATA[Stock entries entry start date.]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.]]>
		Public Property [UserInvoiceDate] As DateTime?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Layout]
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
		Public Property [Division] As Int32?
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
		'''<![CDATA[Layout name]]>
		Public Property [Subject] As String
		'''<![CDATA[Type: 1=Layout, 2=E-mail text layout, 3=Word template]]>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("InvoiceID")>
	Public Class [PrintedSalesInvoice]
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Contains the id of the document that was created]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
		Public Property [DocumentCreationError] As String
		'''<![CDATA[Contains information if a document was succesfully created]]>
		Public Property [DocumentCreationSuccess] As String
		'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
		Public Property [DocumentLayout] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
		Public Property [EmailCreationError] As String
		'''<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
		Public Property [EmailCreationSuccess] As String
		'''<![CDATA[Based on this layout the email text is produced]]>
		Public Property [EmailLayout] As Guid?
		'''<![CDATA[Extra text that can be added to the printed document and email]]>
		Public Property [ExtraText] As String
		'''<![CDATA[Date of the invoice]]>
		Public Property [InvoiceDate] As DateTime?
		'''<![CDATA[Primary key, Reference to EntryID of SalesInvoice]]>
		Public Property [InvoiceID] As Guid
		'''<![CDATA[Contains the error message if an error occurred during the sending of a postbox message]]>
		Public Property [PostboxMessageCreationError] As String
		'''<![CDATA[Contains information if a postbox message was succesfully sent]]>
		Public Property [PostboxMessageCreationSuccess] As String
		'''<![CDATA[The postbox from where the message is sent]]>
		Public Property [PostboxSender] As Guid?
		'''<![CDATA[Reporting period]]>
		Public Property [ReportingPeriod] As Int32?
		'''<![CDATA[Reporting year]]>
		Public Property [ReportingYear] As Int32?
		'''<![CDATA[Set to True if an email containing the invoice should be sent to the invoice customer. This option overrules SendInvoiceToCustomerPostbox.]]>
		Public Property [SendEmailToCustomer] As Boolean?
		'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
		Public Property [SenderEmailAddress] As String
		'''<![CDATA[Set to True if a postbox message containing the invoice should be sent to the invoice customer]]>
		Public Property [SendInvoiceToCustomerPostbox] As Boolean?
		'''<![CDATA[Set to True if the output preference should be taken from the account. It will be either Document only, Email or Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.]]>
		Public Property [SendOutputBasedOnAccount] As Boolean?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("InvoiceID")>
	Public Class [SalesInvoice]
		'''<![CDATA[For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[For the header this is the sum of all lines, including VAT]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency for the invoice. Default this is the currency of the administration]]>
		Public Property [Currency] As String
		'''<![CDATA[Delivery account for invoice]]>
		Public Property [DeliverTo] As Guid?
		'''<![CDATA[Address of delivery as per invoice delivery account]]>
		Public Property [DeliverToAddress] As Guid?
		'''<![CDATA[Delivery account person for invoice]]>
		Public Property [DeliverToContactPerson] As Guid?
		'''<![CDATA[Name of delivery account's contact person as per invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToContactPersonFullName] As String
		'''<![CDATA[Name of the delivery account's customer as per invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToName] As String
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
		'''<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<![CDATA[Official date for the invoice. When the invoice is entered it's equal to the field 'EntryDate'. During the printing process the invoice date can be entered]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [InvoiceID] As Guid
		'''<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Reference to the Customer who will receive the invoice]]>
		Public Property [InvoiceTo] As Guid?
		'''<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<![CDATA[Name of the customer who will receive the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
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
		'''<![CDATA[Order date]]>
		Public Property [OrderDate] As DateTime?
		'''<![CDATA[Customer who ordered the invoice]]>
		Public Property [OrderedBy] As Guid?
		'''<![CDATA[Contact person of customer who ordered the invoice]]>
		Public Property [OrderedByContactPerson] As Guid?
		'''<![CDATA[Name of contact person of customer who ordered the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<![CDATA[Name of customer who ordered the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<![CDATA[Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[The payment condition used for due date and discount calculation]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Payment reference for sales invoice]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[Collection of lines]]>
		Public Property [SalesInvoiceLines] As IEnumerable(Of Models.SalesInvoice.SalesInvoiceLine)
		'''<![CDATA[Sales representative]]>
		Public Property [Salesperson] As Guid?
		'''<![CDATA[Name of sales representative]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalespersonFullName] As String
		'''<![CDATA[Starter Sales invoice status (for starter functionality)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StarterSalesInvoiceStatus] As Int16?
		'''<![CDATA[Description of StarterSalesInvoiceStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StarterSalesInvoiceStatusDescription] As String
		'''<![CDATA[The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can't be changed anymore. Processing is done via printing. Processed invoices can't be reopened]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Obsolete]]>
		Public Property [TaxSchedule] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<![CDATA[Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of the type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Total VAT amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[Total VAT amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[Withholding tax amount applied to sales invoice]]>
		Public Property [WithholdingTaxAmountFC] As Double?
		'''<![CDATA[Withholding tax base amount to calculate withholding amount]]>
		Public Property [WithholdingTaxBaseAmount] As Double?
		'''<![CDATA[Withholding tax percentage applied to sales invoice]]>
		Public Property [WithholdingTaxPercentage] As Double?
		'''<![CDATA[The invoice number of the customer]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesInvoiceLine]
		'''<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[For normal lines it's the amount excluding VAT]]>
		Public Property [AmountFC] As Double?
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
		'''<![CDATA[Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.]]>
		Public Property [DeliveryDate] As DateTime?
		'''<![CDATA[Description. Can be different for header and lines]]>
		Public Property [Description] As String
		'''<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Link to Employee originating from time and cost transactions]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Name of employee]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EmployeeFullName] As String
		'''<![CDATA[EndTime is used to store the last date of a period. EndTime is used in combination with StartTime]]>
		Public Property [EndTime] As DateTime?
		'''<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<![CDATA[Extra duty percentage]]>
		Public Property [ExtraDutyPercentage] As Double?
		'''<![CDATA[The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID]]>
		Public Property [InvoiceID] As Guid
		'''<![CDATA[Reference to the item that is sold in this sales invoice line]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates the sequence of the lines within one invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Net price of the sales invoice line]]>
		Public Property [NetPrice] As Double?
		'''<![CDATA[Extra notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Price list]]>
		Public Property [Pricelist] As Guid?
		'''<![CDATA[Description of Pricelist]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PricelistDescription] As String
		'''<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[WBS linked to the sales invoice]]>
		Public Property [ProjectWBS] As Guid?
		'''<![CDATA[Description of WBS]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectWBSDescription] As String
		'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Identifies the sales order this invoice line is based on]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<![CDATA[Identifies the sales order line this sales invoice line is based on]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLine] As Guid?
		'''<![CDATA[Then line number of the sales order line on which this invoice line is based on]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<![CDATA[The order number of the sales order on which this invoice line is based on]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[StartTime is used to store the first date of a period. StartTime is used in combination with EndTime]]>
		Public Property [StartTime] As DateTime?
		'''<![CDATA[When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Description of Subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Obsolete]]>
		Public Property [TaxSchedule] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<![CDATA[Code of Unit]]>
		Public Property [UnitCode] As String
		'''<![CDATA[Description of Unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Price per unit]]>
		Public Property [UnitPrice] As Double?
		'''<![CDATA[VAT amount in the default currency of the company]]>
		Public Property [VATAmountDC] As Double?
		'''<![CDATA[VAT amount in the currency of the transaction]]>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[The VAT code that is used when the invoice is registered]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
		Public Property [VATPercentage] As Double?
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [SalesOrderID]
		Public Property [ID] As Guid
	End Class

End Namespace