' Last generated on 2017-05-05 12:58:34Z

Namespace FinancialTransaction

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("EntryID")>
	Public Class [BankEntry]
		'''<![CDATA[Collection of lines]]>
		Public Property [BankEntryLines] As IEnumerable(Of Models.FinancialTransaction.BankEntryLine)
		'''<![CDATA[Reference to document with bank statement]]>
		Public Property [BankStatementDocument] As Guid?
		'''<![CDATA[Document number of document with bank statement]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankStatementDocumentNumber] As Int32?
		'''<![CDATA[Subject of document with bank statement]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankStatementDocumentSubject] As String
		'''<![CDATA[Closing balance in the currency of the transaction]]>
		Public Property [ClosingBalanceFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Fiancial period]]>
		Public Property [FinancialPeriod] As Int16?
		'''<![CDATA[Fiancial year]]>
		Public Property [FinancialYear] As Int16?
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Opening balance in the currency of the transaction]]>
		Public Property [OpeningBalanceFC] As Double?
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [BankEntryLine]
		'''<![CDATA[Reference to Account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Vat amount in the currency of the transaction]]>
		Public Property [AmountVATFC] As Double?
		'''<![CDATA[Reference to an asset]]>
		Public Property [Asset] As Guid?
		'''<![CDATA[Code of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetCode] As String
		'''<![CDATA[Description of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<![CDATA[Reference to a cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Reference to a cost unit]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of CostUnit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		Public Property [Date] As DateTime?
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Reference to a document]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of Document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of Document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Reference to the header]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the header]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Exchange rate]]>
		Public Property [ExchangeRate] As Double?
		'''<![CDATA[General ledger account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to offset line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetID] As Guid?
		Public Property [OurRef] As Int32?
		'''<![CDATA[Reference to a project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Reference to vat code]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[Vat code percentage]]>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[Type of vat code]]>
		Public Property [VATType] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("EntryID")>
	Public Class [CashEntry]
		'''<![CDATA[Collection of lines]]>
		Public Property [CashEntryLines] As IEnumerable(Of Models.FinancialTransaction.CashEntryLine)
		'''<![CDATA[Closing balance in the currency of the transaction]]>
		Public Property [ClosingBalanceFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Fiancial period]]>
		Public Property [FinancialPeriod] As Int16?
		'''<![CDATA[Fiancial year]]>
		Public Property [FinancialYear] As Int16?
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Opening balance in the currency of the transaction]]>
		Public Property [OpeningBalanceFC] As Double?
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [CashEntryLine]
		'''<![CDATA[Reference to Account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Vat amount in the currency of the transaction]]>
		Public Property [AmountVATFC] As Double?
		'''<![CDATA[Reference to an asset]]>
		Public Property [Asset] As Guid?
		'''<![CDATA[Code of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetCode] As String
		'''<![CDATA[Description of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetDescription] As String
		'''<![CDATA[Reference to a cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Reference to a cost unit]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of CostUnit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		Public Property [Date] As DateTime?
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Reference to a document]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of Document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of Document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Reference to the header]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the header]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Exchange rate]]>
		Public Property [ExchangeRate] As Double?
		'''<![CDATA[General ledger account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to offset line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetID] As Guid?
		Public Property [OurRef] As Int32?
		'''<![CDATA[Reference to a project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Reference to vat code]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[Vat code percentage]]>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[Type of vat code]]>
		Public Property [VATType] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("EntryID")>
	Public Class [Transaction]
		'''<![CDATA[Closing balance in the currency of the transaction]]>
		Public Property [ClosingBalanceFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Document linked to the sales or purchase transaction.]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Primary key]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Description of the external link.]]>
		Public Property [ExternalLinkDescription] As String
		'''<![CDATA[External link in a sales or purchase transaction.]]>
		Public Property [ExternalLinkReference] As String
		'''<![CDATA[Financial period]]>
		Public Property [FinancialPeriod] As Int16?
		'''<![CDATA[Financial year]]>
		Public Property [FinancialYear] As Int16?
		'''<![CDATA[0 =  Financial entry without extra duty, 1 = Financial entry with extra duty]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsExtraDuty] As Boolean?
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Opening balance in the currency of the transaction]]>
		Public Property [OpeningBalanceFC] As Double?
		'''<![CDATA[Code of PaymentCondition]]>
		Public Property [PaymentConditionCode] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Collection of lines]]>
		Public Property [TransactionLines] As IEnumerable(Of Models.FinancialTransaction.TransactionLine)
		'''<![CDATA[The transaction type.</br><table class="enum"><tr><td>10 = Opening balance</td><td>142 = Issue to parent</td></tr><tr><td>20 = Sales entry</td><td>145 = Shop order time entry</td></tr><tr><td>21 = Sales credit note</td><td>146 = Shop order time entry reversal</td></tr><tr><td>30 = Purchase entry</td><td>147 = Shop order by-product receipt</td></tr><tr><td>31 = Purchase credit note</td><td>148 = Shop order by-product reversal</td></tr><tr><td>40 = Cash flow</td><td>150 = Requirement issue</td></tr><tr><td>50 = VAT return</td><td>151 = Requirement reversal</td></tr><tr><td>70 = Asset - Depreciation</td><td>152 = Returned from parent</td></tr><tr><td>71 = Asset - Investment</td><td>155 = Subcontract Issue</td></tr><tr><td>72 = Asset - Revaluation</td><td>156 = Subcontract reversal</td></tr><tr><td>73 = Asset - Transfer</td><td>158 = Shop order completed</td></tr><tr><td>74 = Asset - Split</td><td>162 = Finish assembly</td></tr><tr><td>75 = Asset - Discontinue</td><td>170 = Payroll</td></tr><tr><td>76 = Asset - Sales</td><td>180 = Stock revaluation</td></tr><tr><td>80 = Revaluation</td><td>181 = Financial revaluation</td></tr><tr><td>82 = Exchange rate difference</td><td>195 = Stock count</td></tr><tr><td>83 = Payment difference</td><td>290 = Correction entry</td></tr><tr><td>84 = Deferred revenue</td><td>310 = Period closing</td></tr><tr><td>85 = Tracking number:Revaluation</td><td>320 = Year end reflection</td></tr><tr><td>86 = Deferred cost</td><td>321 = Year end costing</td></tr><tr><td>87 = VAT on prepayment</td><td>322 = Year end profits to gross profit</td></tr><tr><td>90 = Other</td><td>323 = Year end costs to gross profit</td></tr><tr><td>120 = Delivery</td><td>324 = Year end tax</td></tr><tr><td>121 = Sales return</td><td>325 = Year end gross profit to net p/l</td></tr><tr><td>130 = Receipt</td><td>326 = Year end net p/l to balance sheet</td></tr><tr><td>131 = Purchase return</td><td>327 = Year end closing balance</td></tr><tr><td>140 = Shop order stock receipt</td><td>328 = Year start opening balance</td></tr><tr><td>141 = Shop order stock reversal</td><td>3000 = Budget</td></tr></table>]]>
		Public Property [Type] As Int32
		'''<![CDATA[The description of the transaction type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [TransactionLine]
		'''<![CDATA[Reference to account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of the Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of the Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Amount in the default currency of the company]]>
		Public Property [AmountDC] As Double
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double
		'''<![CDATA[Vat base amount in the currency of the transaction]]>
		Public Property [AmountVATBaseFC] As Double?
		'''<![CDATA[Vat amount in the currency of the transaction]]>
		Public Property [AmountVATFC] As Double?
		'''<![CDATA[Reference to asset]]>
		Public Property [Asset] As Guid?
		'''<![CDATA[Code of Asset]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetCode] As String
		'''<![CDATA[Description of Asset]]>
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
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency]]>
		Public Property [Currency] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Reference to document]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Date that payment should be done]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[Reference to header of the entry]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the header]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Exchange rate]]>
		Public Property [ExchangeRate] As Double?
		'''<![CDATA[Extra duty amount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExtraDutyAmountFC] As Double?
		'''<![CDATA[Extra duty percentage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExtraDutyPercentage] As Double?
		'''<![CDATA[Financial period]]>
		Public Property [FinancialPeriod] As Int16?
		'''<![CDATA[Financial year]]>
		Public Property [FinancialYear] As Int16?
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
		'''<![CDATA[Invoice number]]>
		Public Property [InvoiceNumber] As Int32?
		'''<![CDATA[Reference to item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[The journal code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalCode] As String
		'''<![CDATA[The journal description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Line type]]>
		Public Property [LineType] As Int16
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[OffsetID]]>
		Public Property [OffsetID] As Guid?
		'''<![CDATA[Order number]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[Discount amount when paid in time]]>
		Public Property [PaymentDiscountAmount] As Double?
		'''<![CDATA[Payment reference]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Reference to project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Serial number of item]]>
		Public Property [SerialNumber] As String
		'''<![CDATA[20 = Open, 50 = Processed]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Reference to subscription]]>
		Public Property [Subscription] As Guid?
		'''<![CDATA[Description of Subscription]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubscriptionDescription] As String
		'''<![CDATA[Tracking number of item]]>
		Public Property [TrackingNumber] As String
		'''<![CDATA[Tracking number description]]>
		Public Property [TrackingNumberDescription] As String
		'''<![CDATA[The transaction type.</br><table class="enum"><tr><td>10 = Opening balance</td><td>142 = Issue to parent</td></tr><tr><td>20 = Sales entry</td><td>145 = Shop order time entry</td></tr><tr><td>21 = Sales credit note</td><td>146 = Shop order time entry reversal</td></tr><tr><td>30 = Purchase entry</td><td>147 = Shop order by-product receipt</td></tr><tr><td>31 = Purchase credit note</td><td>148 = Shop order by-product reversal</td></tr><tr><td>40 = Cash flow</td><td>150 = Requirement issue</td></tr><tr><td>50 = VAT return</td><td>151 = Requirement reversal</td></tr><tr><td>70 = Asset - Depreciation</td><td>152 = Returned from parent</td></tr><tr><td>71 = Asset - Investment</td><td>155 = Subcontract Issue</td></tr><tr><td>72 = Asset - Revaluation</td><td>156 = Subcontract reversal</td></tr><tr><td>73 = Asset - Transfer</td><td>158 = Shop order completed</td></tr><tr><td>74 = Asset - Split</td><td>162 = Finish assembly</td></tr><tr><td>75 = Asset - Discontinue</td><td>170 = Payroll</td></tr><tr><td>76 = Asset - Sales</td><td>180 = Stock revaluation</td></tr><tr><td>80 = Revaluation</td><td>181 = Financial revaluation</td></tr><tr><td>82 = Exchange rate difference</td><td>195 = Stock count</td></tr><tr><td>83 = Payment difference</td><td>290 = Correction entry</td></tr><tr><td>84 = Deferred revenue</td><td>310 = Period closing</td></tr><tr><td>85 = Tracking number:Revaluation</td><td>320 = Year end reflection</td></tr><tr><td>86 = Deferred cost</td><td>321 = Year end costing</td></tr><tr><td>87 = VAT on prepayment</td><td>322 = Year end profits to gross profit</td></tr><tr><td>90 = Other</td><td>323 = Year end costs to gross profit</td></tr><tr><td>120 = Delivery</td><td>324 = Year end tax</td></tr><tr><td>121 = Sales return</td><td>325 = Year end gross profit to net p/l</td></tr><tr><td>130 = Receipt</td><td>326 = Year end net p/l to balance sheet</td></tr><tr><td>131 = Purchase return</td><td>327 = Year end closing balance</td></tr><tr><td>140 = Shop order stock receipt</td><td>328 = Year start opening balance</td></tr><tr><td>141 = Shop order stock reversal</td><td>3000 = Budget</td></tr></table>]]>
		Public Property [Type] As Int32
		'''<![CDATA[Vat code]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[Vat percentage]]>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[Vat type]]>
		Public Property [VATType] As String
		'''<![CDATA[Your reference (of customer)]]>
		Public Property [YourRef] As String
	End Class

End Namespace