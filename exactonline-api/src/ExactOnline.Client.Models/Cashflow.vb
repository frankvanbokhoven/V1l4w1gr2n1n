' Last generated on 2017-05-05 12:58:34Z

Namespace Cashflow

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Bank]
		'''<![CDATA[The name of the bank]]>
		Public Property [BankName] As String
		'''<![CDATA[The bank identification code of the bank]]>
		Public Property [BICCode] As String
		'''<![CDATA[The country in which the bank is based]]>
		Public Property [Country] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[The extended description of the bank]]>
		Public Property [Description] As String
		'''<![CDATA[The account format used by the bank]]>
		Public Property [Format] As String
		'''<![CDATA[The website of the bank]]>
		Public Property [HomePageAddress] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[The status of the bank. A = Active, P = Passive]]>
		Public Property [Status] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DirectDebitMandate]
		'''<![CDATA[Account to which the mandate belongs.]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Bank account to which the mandate belongs.]]>
		Public Property [BankAccount] As Guid?
		'''<![CDATA[Date that the mandate is cancelled. Used to check the validity of the mandate.]]>
		Public Property [CancellationDate] As DateTime?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Displays the description of the mandate.]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Indicates the first collection hasn't been sent/confirmed with this mandate.]]>
		Public Property [FirstSend] As Byte?
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
		'''<![CDATA[Depending on the payment type, a different bank file will be generated. 0 = One-off payment, 1 = Recurrent payment, 2 = AdHoc (UK only)]]>
		Public Property [PaymentType] As Int16?
		'''<![CDATA[Displays a reference number for the mandate. It is a unique reference number that you can assign to each mandate.]]>
		Public Property [Reference] As String
		'''<![CDATA[Date that the mandate is signed. The collection must take place after the signature date of the mandate. The date is used to check the validity of the mandate.]]>
		Public Property [SignatureDate] As DateTime?
		'''<![CDATA[Depending on the type, a different bank file will be generated. 0 = Core, 1 = B2B and 2 = bottomline (UK only)]]>
		Public Property [Type] As Int16?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Payment]
		'''<![CDATA[The supplier to which the payment has to be done.]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The bank account of the supplier, to which the payment has to be done.]]>
		Public Property [AccountBankAccountID] As Guid?
		'''<![CDATA[The bank account number of the supplier, to which the payment has to be done.]]>
		Public Property [AccountBankAccountNumber] As String
		'''<![CDATA[The code of the supplier to which the payment has to be done.]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Contact person copied from the purchase invoice linked to the related purchase entry. Used as prefered contact when sending reminders.]]>
		Public Property [AccountContact] As Guid?
		'''<![CDATA[Name of the contact person of the supplier.]]>
		Public Property [AccountContactName] As String
		'''<![CDATA[Name of the supplier.]]>
		Public Property [AccountName] As String
		'''<![CDATA[The amount in default currency (division currency). Payments are matched on this amount.]]>
		Public Property [AmountDC] As Double
		'''<![CDATA[The amount of the discount in the default currency.]]>
		Public Property [AmountDiscountDC] As Double
		'''<![CDATA[The amount of the discount. This is in the amount of the selected currency.]]>
		Public Property [AmountDiscountFC] As Double
		'''<![CDATA[The amount of the payment. This is in the amount of the selected currency.]]>
		Public Property [AmountFC] As Double
		'''<![CDATA[Own bank account from which the payment must be done.]]>
		Public Property [BankAccountID] As Guid?
		'''<![CDATA[Own bank account number from which the payment must be done.]]>
		Public Property [BankAccountNumber] As String
		'''<![CDATA[When processing payments, all payments with the same processing data are put in a batch. This field contains the code of that batch.]]>
		Public Property [CashflowTransactionBatchCode] As String
		'''<![CDATA[Creation date.]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of the creator.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The currency of the payment. This currency can only deviate from the division currency if the module Currency is in the license.]]>
		Public Property [Currency] As String
		'''<![CDATA[Extra description for the payment that may be included in the bank export file.]]>
		Public Property [Description] As String
		'''<![CDATA[Date before which the payment must be done to be eligible for discount.]]>
		Public Property [DiscountDueDate] As DateTime?
		'''<![CDATA[Division code.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Document that is created when processing payments.  The bank export file is attached to the document.]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document.]]>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document.]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Date before which the payment must be done.]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[Date since when the payment is no longer an outstanding item. This is the highest invoice date of all matched payments.]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Period since when the payment is no longer an outstanding item. This is the highest period of all matched payments.]]>
		Public Property [EndPeriod] As Int16?
		'''<![CDATA[Year (of period) since when the payment is no longer an outstanding item. This is the highest year of all matched payments. Used in combination with EndPeriod.]]>
		Public Property [EndYear] As Int16?
		'''<![CDATA[Processing date of the payment.]]>
		Public Property [EntryDate] As DateTime?
		'''<![CDATA[The unique identifier for a set of payments. A payment can be split so that one part is paid on a different date. In that case the two records get a different EntryID.]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the linked transaction.]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[G/L account of the payment. Must be of type 22 (Accounts payable).]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Identifier of the payment.]]>
		Public Property [ID] As Guid
		'''<![CDATA[Invoice date of the linked transaction.]]>
		Public Property [InvoiceDate] As DateTime?
		'''<![CDATA[Invoice number of the linked transaction.]]>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Boolean indicating whether the payment is part of a batch booking.]]>
		Public Property [IsBatchBooking] As Byte?
		'''<![CDATA[Journal of the linked transaction.]]>
		Public Property [Journal] As String
		'''<![CDATA[Description of the journal.]]>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Number assigned during the of processing payments. When payments are processed a bank export file is created. This file contains one or more batches that contain one or more payments. Each batch gets a sequence number that is stored for each payment in that batch.]]>
		Public Property [PaymentBatchNumber] As Int32?
		'''<![CDATA[Payment condition of the linked transaction.]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of the payment condition.]]>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Number of days between invoice date and due date.]]>
		Public Property [PaymentDays] As Int32?
		'''<![CDATA[Number of days between invoice date and due date of the discount.]]>
		Public Property [PaymentDaysDiscount] As Int32?
		'''<![CDATA[Payment discount percentage.]]>
		Public Property [PaymentDiscountPercentage] As Double?
		'''<![CDATA[Method of payment.<br> B = On credit (default)<br> I = Collection<br> K = Cash<br> V = Credit card.]]>
		Public Property [PaymentMethod] As String
		'''<![CDATA[Payment reference for the payment that may be included in the bank export file.]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Date and time since when the payment is selected to be paid.]]>
		Public Property [PaymentSelected] As DateTime?
		'''<![CDATA[User who selected the payment to be paid.]]>
		Public Property [PaymentSelector] As Guid?
		'''<![CDATA[Name of the payment selector.]]>
		Public Property [PaymentSelectorFullName] As String
		'''<![CDATA[Exchange rate from payment currency to division currency. AmountFC * RateFC = AmountDC.]]>
		Public Property [RateFC] As Double?
		'''<![CDATA[The source of the payment.<br> 1 = manual<br> 2 = reconcile<br> 3 = match<br> 4 = import<br> 5 = process]]>
		Public Property [Source] As Int32
		'''<![CDATA[The status of the payment.<br> 20 = open<br> 30 = selected - payment is selected to be paid<br> 40 = processed - payment has been done<br> 50 = matched - payment is matched with one or more other outstanding items or financial statement lines]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Total amount of the linked transaction in default currency (division currency).]]>
		Public Property [TransactionAmountDC] As Double
		'''<![CDATA[Total amount of the linked transaction in the selected currency.]]>
		Public Property [TransactionAmountFC] As Double
		'''<![CDATA[Due date of the linked transaction.]]>
		Public Property [TransactionDueDate] As DateTime?
		'''<![CDATA[Linked transaction. Use this as reference to PurchaseEntries.]]>
		Public Property [TransactionEntryID] As Guid?
		'''<![CDATA[Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.]]>
		Public Property [TransactionID] As Guid?
		'''<![CDATA[Indicates if the linked transaction is a reversal entry.]]>
		Public Property [TransactionIsReversal] As Boolean
		'''<![CDATA[Period of the linked transaction.]]>
		Public Property [TransactionReportingPeriod] As Int16?
		'''<![CDATA[Year of the linked transaction.]]>
		Public Property [TransactionReportingYear] As Int16?
		'''<![CDATA[Status of the linked transaction.]]>
		Public Property [TransactionStatus] As Int16?
		'''<![CDATA[Type of the linked transaction.]]>
		Public Property [TransactionType] As Int32?
		'''<![CDATA[Invoice number of the supplier. In case the payment belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PaymentCondition]
		'''<![CDATA[Code of the payment condition]]>
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
		'''<![CDATA[Default credit management scenario to be used for new payment terms]]>
		Public Property [CreditManagementScenario] As Guid?
		'''<![CDATA[Code of CreditManagementScenario]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreditManagementScenarioCode] As String
		'''<![CDATA[Description of CreditManagementScenario]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreditManagementScenarioDescription] As String
		'''<![CDATA[Description of the payment condition]]>
		Public Property [Description] As String
		'''<![CDATA[Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT]]>
		Public Property [DiscountCalculation] As String
		'''<![CDATA[Number of days to pay within, to have the right to take the discount]]>
		Public Property [DiscountPaymentDays] As Int32?
		'''<![CDATA[Discount percentage]]>
		Public Property [DiscountPercentage] As Double?
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
		'''<![CDATA[Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 => 31/03 PaymentDays = 15 => 15/04]]>
		Public Property [PaymentDays] As Int32?
		'''<![CDATA[Type of payment discount. Values: B = Settlement discount, K = Credit surcharge]]>
		Public Property [PaymentDiscountType] As String
		'''<![CDATA[Number of month endings to be included in the due date calculation]]>
		Public Property [PaymentEndOfMonths] As Int32?
		'''<![CDATA[Method of payment. Values: B = On credit, I = Collection, K = Cash]]>
		Public Property [PaymentMethod] As String
		'''<![CDATA[Percentage (stored as fraction) of total invoice amount]]>
		Public Property [Percentage] As Double?
		'''<![CDATA[Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount]]>
		Public Property [VATCalculation] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [PaymentID]
		'''<![CDATA[ID of the payment to be processed.]]>
		Public Property [ID] As Guid
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("ID")>
	Public Class [ProcessPayment]
		'''<![CDATA[This is a URL to get the documents that were created after the payments were successfully processed. These documents have to be sent to the bank in order to do the payments.]]>
		Public Property [BankExportDocumentsUrl] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Contains the error message if an error occurred during the processing of the payment(s).]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[Primary key.]]>
		Public Property [ID] As Guid
		'''<![CDATA[Use this field to pass a collection of GUIDs representing the IDs of the payments that have to be processed.]]>
		Public Property [PaymentIDs] As IEnumerable(Of Models.Cashflow.PaymentID)
		'''<![CDATA[Contains information if the payments were successfully processed.]]>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Receivable]
		'''<![CDATA[The customer from which the receivable will come.]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The bank account of the customer, from which the receivable will come.]]>
		Public Property [AccountBankAccountID] As Guid?
		'''<![CDATA[The bank account number of the customer, from which the receivable will come.]]>
		Public Property [AccountBankAccountNumber] As String
		'''<![CDATA[The code of the customer from which the receivable will come.]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Contact person copied from the purchase invoice linked to the related purchase entry.]]>
		Public Property [AccountContact] As Guid?
		'''<![CDATA[Name of the contact person of the customer.]]>
		Public Property [AccountContactName] As String
		'''<![CDATA[Name of the customer.]]>
		Public Property [AccountName] As String
		'''<![CDATA[The amount in default currency (division currency). Receivables are matched on this amount.]]>
		Public Property [AmountDC] As Double
		'''<![CDATA[The amount of the discount in the default currency.]]>
		Public Property [AmountDiscountDC] As Double
		'''<![CDATA[The amount of the discount. This is in the amount of the selected currency.]]>
		Public Property [AmountDiscountFC] As Double
		'''<![CDATA[The amount of the receivable. This is in the amount of the selected currency.]]>
		Public Property [AmountFC] As Double
		'''<![CDATA[Own bank account to which the receivable will be done.]]>
		Public Property [BankAccountID] As Guid?
		'''<![CDATA[Own bank account number to which the receivable will be done.]]>
		Public Property [BankAccountNumber] As String
		'''<![CDATA[When processing receivables, all receivable with the same processing data are put in a batch. This field contains the code of that batch.]]>
		Public Property [CashflowTransactionBatchCode] As String
		'''<![CDATA[Creation date.]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of the creator.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The currency of the receivable. This currency can only deviate from the division currency if the module Currency is in the license.]]>
		Public Property [Currency] As String
		'''<![CDATA[Description.]]>
		Public Property [Description] As String
		'''<![CDATA[Direct Debit Mandate used to collect the receivable.]]>
		Public Property [DirectDebitMandate] As Guid?
		'''<![CDATA[Description of the mandate.]]>
		Public Property [DirectDebitMandateDescription] As String
		'''<![CDATA[Payment type of the mandate.<br> 0 = One off payment<br> 1 = Recurrent payment.]]>
		Public Property [DirectDebitMandatePaymentType] As Int16?
		'''<![CDATA[Unique mandate reference.]]>
		Public Property [DirectDebitMandateReference] As String
		'''<![CDATA[Type of the mandate.<br> 0 = Core<br> 1 = Business-to-business.]]>
		Public Property [DirectDebitMandateType] As Int16?
		'''<![CDATA[Date before which the payment by the customer must be done to be eligible for discount.]]>
		Public Property [DiscountDueDate] As DateTime?
		'''<![CDATA[Division code.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Document that is created when processing collections.  The bank export file is attached to the document.]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document.]]>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document.]]>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Date before which the payment by the customer must be done.]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[Date since when the receivable is no longer an outstanding item. This is the highest invoice date of all matched receivables.]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Period since when the receivable is no longer an outstanding item. This is the highest period of all matched receivables.]]>
		Public Property [EndPeriod] As Int16?
		'''<![CDATA[The value of the tag 'EndToEndID' when generating a SEPA file.]]>
		Public Property [EndToEndID] As String
		'''<![CDATA[Year (of period) since when the receivable is no longer an outstanding item. This is the highest year of all matched receivables. Used in combination with EndPeriod.]]>
		Public Property [EndYear] As Int16?
		'''<![CDATA[Processing date of the receivable.]]>
		Public Property [EntryDate] As DateTime?
		'''<![CDATA[The unique identifier for a set of receivables. A receivable can be split so that one part is received on a different date. In that case the two records get a different EntryID.]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the linked transaction.]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[G/L account of the payment. Must be of type 20 (Accounts receivable).]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Identifier of the receivable.]]>
		Public Property [ID] As Guid
		'''<![CDATA[Invoice date of the linked transaction.]]>
		Public Property [InvoiceDate] As DateTime?
		'''<![CDATA[Invoice number of the linked transaction.]]>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Boolean indicating whether the receivable is part of a batch booking.]]>
		Public Property [IsBatchBooking] As Byte?
		'''<![CDATA[Boolean indicating whether the receivable was fully paid by the customer.]]>
		Public Property [IsFullyPaid] As Boolean
		'''<![CDATA[Journal of the linked transaction.]]>
		Public Property [Journal] As String
		'''<![CDATA[Description of the journal.]]>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last payment date.]]>
		Public Property [LastPaymentDate] As DateTime?
		'''<![CDATA[Last modified date.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Payment condition of the linked transaction.]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of the payment condition.]]>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Number of days between invoice date and due date.]]>
		Public Property [PaymentDays] As Int32?
		'''<![CDATA[Number of days between invoice date and due date of the discount.]]>
		Public Property [PaymentDaysDiscount] As Int32?
		'''<![CDATA[Payment discount percentage.]]>
		Public Property [PaymentDiscountPercentage] As Double?
		'''<![CDATA[PaymentInformationID tag from the SEPA xml file.]]>
		Public Property [PaymentInformationID] As String
		'''<![CDATA[Method of payment.<br> B = On credit (default)<br> I = Collection<br> K = Cash<br> V = Credit card]]>
		Public Property [PaymentMethod] As String
		'''<![CDATA[Payment reference for the receivable that may be included In the bank export file]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Exchange rate from receivable currency to division currency. AmountFC * RateFC = AmountDC.]]>
		Public Property [RateFC] As Double?
		'''<![CDATA[Number assigned during the processing of receivables.]]>
		Public Property [ReceivableBatchNumber] As Int32?
		'''<![CDATA[Date and time since when the receivable is selected to be collected.]]>
		Public Property [ReceivableSelected] As DateTime?
		'''<![CDATA[User who selected the receivable to be collected.]]>
		Public Property [ReceivableSelector] As Guid?
		'''<![CDATA[Name of the receivable selector.]]>
		Public Property [ReceivableSelectorFullName] As String
		'''<![CDATA[The source of the receivable.<br> 1 = manual<br> 2 = reconcile<br> 3 = match<br> 4 = import<br> 5 = process]]>
		Public Property [Source] As Int32
		'''<![CDATA[The status of the receivable.<br> 20 = open<br> 30 = selected - receivable is selected to be collected<br> 40 = processed - collection has been done<br> 50 = matched - receivable is matched with one or more other outstanding items or financial statement lines]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Total amount of the linked transaction in default currency (division currency).]]>
		Public Property [TransactionAmountDC] As Double
		'''<![CDATA[Total amount of the linked transaction in the selected currency.]]>
		Public Property [TransactionAmountFC] As Double
		'''<![CDATA[Due date of the linked transaction.]]>
		Public Property [TransactionDueDate] As DateTime?
		'''<![CDATA[Linked transaction. Use this as reference to SalesEntries.]]>
		Public Property [TransactionEntryID] As Guid?
		'''<![CDATA[Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.]]>
		Public Property [TransactionID] As Guid?
		'''<![CDATA[Indicates if the linked transaction is a reversal entry.]]>
		Public Property [TransactionIsReversal] As Boolean
		'''<![CDATA[Period of the linked transaction.]]>
		Public Property [TransactionReportingPeriod] As Int16?
		'''<![CDATA[Year of the linked transaction.]]>
		Public Property [TransactionReportingYear] As Int16?
		'''<![CDATA[Status of the linked transaction.]]>
		Public Property [TransactionStatus] As Int16?
		'''<![CDATA[Type of the linked transaction.]]>
		Public Property [TransactionType] As Int32?
		'''<![CDATA[Invoice number. In case the receivable belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.]]>
		Public Property [YourRef] As String
	End Class

End Namespace