' Last generated on 2017-05-05 12:58:34Z

Namespace Financial

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AgeGroup")>
	Public Class [AgingOverview]
		'''<![CDATA[Primary key]]>
		Public Property [AgeGroup] As Int32
		'''<![CDATA[Description of AgeGroup]]>
		Public Property [AgeGroupDescription] As String
		'''<![CDATA[Amount payable]]>
		Public Property [AmountPayable] As Double
		'''<![CDATA[Amount receivable]]>
		Public Property [AmountReceivable] As Double
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [AgingPayablesList]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Primary key]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Age group 1]]>
		Public Property [AgeGroup1] As Int32
		'''<![CDATA[Amount of age group 1]]>
		Public Property [AgeGroup1Amount] As Double
		'''<![CDATA[Description of AgeGroup1]]>
		Public Property [AgeGroup1Description] As String
		'''<![CDATA[Age group 2]]>
		Public Property [AgeGroup2] As Int32
		'''<![CDATA[Amount of age group 2]]>
		Public Property [AgeGroup2Amount] As Double
		'''<![CDATA[Description of AgeGroup2]]>
		Public Property [AgeGroup2Description] As String
		'''<![CDATA[Age group 3]]>
		Public Property [AgeGroup3] As Int32
		'''<![CDATA[Amount of age group 3]]>
		Public Property [AgeGroup3Amount] As Double
		'''<![CDATA[Description of AgeGroup3]]>
		Public Property [AgeGroup3Description] As String
		'''<![CDATA[Age group 4]]>
		Public Property [AgeGroup4] As Int32
		'''<![CDATA[Amount of age group 4]]>
		Public Property [AgeGroup4Amount] As Double
		'''<![CDATA[Description of AgeGroup4]]>
		Public Property [AgeGroup4Description] As String
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Total amount of all age groups]]>
		Public Property [TotalAmount] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("AccountId")>
	Public Class [AgingReceivablesList]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Primary key]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Age group 1]]>
		Public Property [AgeGroup1] As Int32
		'''<![CDATA[Amount of age group 1]]>
		Public Property [AgeGroup1Amount] As Double
		'''<![CDATA[Description of AgeGroup1]]>
		Public Property [AgeGroup1Description] As String
		'''<![CDATA[Age group 2]]>
		Public Property [AgeGroup2] As Int32
		'''<![CDATA[Amount of age group 2]]>
		Public Property [AgeGroup2Amount] As Double
		'''<![CDATA[Description of AgeGroup2]]>
		Public Property [AgeGroup2Description] As String
		'''<![CDATA[Age group 3]]>
		Public Property [AgeGroup3] As Int32
		'''<![CDATA[Amount of age group 3]]>
		Public Property [AgeGroup3Amount] As Double
		'''<![CDATA[Description of AgeGroup3]]>
		Public Property [AgeGroup3Description] As String
		'''<![CDATA[Age group 4]]>
		Public Property [AgeGroup4] As Int32
		'''<![CDATA[Amount of age group 4]]>
		Public Property [AgeGroup4Amount] As Double
		'''<![CDATA[Description of AgeGroup4]]>
		Public Property [AgeGroup4Description] As String
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Total amount of all age groups]]>
		Public Property [TotalAmount] As Double
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ExchangeRate]
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
		'''<![CDATA[The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY]]>
		Public Property [Rate] As Double?
		'''<![CDATA[The foreign currency]]>
		Public Property [SourceCurrency] As String
		'''<![CDATA[Description of SourceCurrency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SourceCurrencyDescription] As String
		'''<![CDATA[The date as of which the rate is valid. The rate is valid until a next rate is defined]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[The default currency of the division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TargetCurrency] As String
		'''<![CDATA[Description of TargetCurrency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TargetCurrencyDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [FinancialPeriod]
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
		'''<![CDATA[The end date of the period]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[The financial period. Usually the period is a month or quarter with period 1 starting on the first of January.]]>
		Public Property [FinPeriod] As Int16?
		'''<![CDATA[The financial year. The financial year and calendar year are not always aligned.]]>
		Public Property [FinYear] As Int16?
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
		'''<![CDATA[The start date of a period. A start date should always succeed a previous end date. Except for the first year/period combination]]>
		Public Property [StartDate] As DateTime?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [GLAccount]
		'''<![CDATA[AssimilatedVATBox (France)]]>
		Public Property [AssimilatedVATBox] As Int16?
		'''<![CDATA[The following values are supported: D (Debit) C (Credit)]]>
		Public Property [BalanceSide] As String
		'''<![CDATA[The following values are supported: B (Balance Sheet) W (Profit & Loss)]]>
		Public Property [BalanceType] As String
		'''<![CDATA[Indentify the kind of rewarding for the G/L account. This is used in the official document for the fiscal fiches Belcotax]]>
		Public Property [BelcotaxType] As Int32?
		'''<![CDATA[Unique Code of the G/L account]]>
		Public Property [Code] As String
		'''<![CDATA[Indicate if this G/L account should be shown as compressed without the details in the CRW report of G/L history]]>
		Public Property [Compress] As Boolean?
		'''<![CDATA[Cost Center linked to the G/L account]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Cost Unit linked to the G/L account]]>
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
		'''<![CDATA[Name of the G/L account]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[General ledger transactions on this G/L account should not appear on the VAT listing]]>
		Public Property [ExcludeVATListing] As Byte
		'''<![CDATA[Expenses on this G/L account can not be used to reduce the incomes]]>
		Public Property [ExpenseNonDeductiblePercentage] As Double?
		'''<![CDATA[Primary Key]]>
		Public Property [ID] As Guid
		'''<![CDATA[When blocked you can't use this general ledger account anymore for new entries]]>
		Public Property [IsBlocked] As Boolean?
		'''<![CDATA[Allow entries on this general ledger account to be matched via the G/L account card]]>
		Public Property [Matching] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[If a private use percentage is defined, you need to specify the G/L account used for the re-invoice of the private use to the owner of the company]]>
		Public Property [PrivateGLAccount] As Guid?
		'''<![CDATA[Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs]]>
		Public Property [PrivatePercentage] As Double?
		'''<![CDATA[Used in the export of yearly report]]>
		Public Property [ReportingCode] As String
		'''<![CDATA[Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done]]>
		Public Property [RevalueCurrency] As Boolean?
		'''<![CDATA[Search Code]]>
		Public Property [SearchCode] As String
		'''<![CDATA[The type of the G/L account. Supported values are:<br>10 = Cash<br>12 = Bank<br>14 = Credit card<br>16 = Payment services<br>20 = Accounts receivable<br>21 = Prepayment accounts receivable<br>22 = Accounts payable<br>24 = VAT<br>25 = Employees payable<br>26 = Prepaid expenses<br>27 = Accrued expenses<br>29 = Income taxes payable<br>30 = Fixed assets<br>32 = Other assets<br>35 = Accumulated depreciation<br>40 = Inventory<br>50 = Capital stock<br>52 = Retained earnings<br>55 = Long term debt<br>60 = Current portion of debt<br>90 = General<br>100 = Tax payable<br>110 = Revenue<br>111 = Cost of goods<br>120 = Other costs<br>121 = Sales, general administrative expenses<br>122 = Depreciation costs<br>123 = Research and development<br>125 = Employee costs<br>126 = Employment costs<br>130 = Exceptional costs<br>140 = Exceptional income<br>150 = Income taxes<br>160 = Interest income<br>300 = Year end reflection<br>301 = Indirect year end costing<br>302 = Direct year end costing<br>]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
		Public Property [UseCostcenter] As Byte?
		'''<![CDATA[Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
		Public Property [UseCostunit] As Byte?
		'''<![CDATA[VAT Code linked to the G/L account]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VAT]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<![CDATA[Specify the kind of purchase this G/L account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go]]>
		Public Property [VATGLAccountType] As String
		'''<![CDATA[If you use a percentage of non deductible VAT, you can specify another G/L account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.]]>
		Public Property [VATNonDeductibleGLAccount] As Guid?
		'''<![CDATA[If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices]]>
		Public Property [VATNonDeductiblePercentage] As Double?
		'''<![CDATA[The following values are supported: I (Invoice) C (Cash) (France)]]>
		Public Property [VATSystem] As String
		'''<![CDATA[Indicates the costing account for year end calculations]]>
		Public Property [YearEndCostGLAccount] As Guid?
		'''<![CDATA[Indicates the reflection account that is used by year end application]]>
		Public Property [YearEndReflectionGLAccount] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLClassification]
		'''<![CDATA[Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents]]>
		Public Property [Abstract] As Boolean?
		'''<![CDATA[Only used for amount concepts: in that case either 'debit' or 'credit']]>
		Public Property [Balance] As String
		'''<![CDATA[The Code is unique]]>
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
		'''<![CDATA[Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table]]>
		Public Property [Description] As String
		'''<![CDATA[Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Obsolete]]>
		Public Property [IsTupleSubElement] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The Name is unique in the namespace]]>
		Public Property [Name] As String
		'''<![CDATA[Determines whether usage of the element is mandatory in an instance document]]>
		Public Property [Nillable] As Boolean?
		'''<![CDATA[Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.]]>
		Public Property [Parent] As Guid?
		'''<![CDATA[Only used for item concepts: either 'instant' or 'duration'. 'instant' is used for balance types of concepts, 'duration' is used for P&L types of concepts]]>
		Public Property [PeriodType] As String
		'''<![CDATA[Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item]]>
		Public Property [SubstitutionGroup] As String
		'''<![CDATA[Namespace of the element]]>
		Public Property [TaxonomyNamespace] As Guid?
		'''<![CDATA[Description of TaxonomyNamespace]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxonomyNamespaceDescription] As String
		'''<![CDATA[Type of the element]]>
		Public Property [Type] As Guid?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLScheme]
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
		'''<![CDATA[Description text]]>
		Public Property [Description] As String
		'''<![CDATA[Division is optional for this table. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Only used for reporting schemes = division specific taxonomynamespaces. In this case, main = 1 denotes the main or default reporting scheme]]>
		Public Property [Main] As Byte
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[URI, which is the unique identifier of the namespace]]>
		Public Property [TargetNamespace] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GLTransactionType]
		Public Property [Description] As String
		Public Property [DescriptionSuffix] As String
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Journal]
		'''<![CDATA[Indicates if the journal allows variable currency]]>
		Public Property [AllowVariableCurrency] As Boolean?
		'''<![CDATA[Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed]]>
		Public Property [AllowVariableExchangeRate] As Boolean?
		'''<![CDATA[Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals]]>
		Public Property [AllowVAT] As Boolean?
		'''<![CDATA[Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines]]>
		Public Property [AutoSave] As Boolean?
		'''<![CDATA[Reference to bank account]]>
		Public Property [Bank] As Guid?
		'''<![CDATA[BIC code of the bank where the bank account is held]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountBICCode] As String
		'''<![CDATA[Country of bank account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountCountry] As String
		'''<![CDATA[Description of BankAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountDescription] As String
		'''<![CDATA[IBAN of the bank account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountIBAN] As String
		'''<![CDATA[Reference to the Bank Account linked to the Journal]]>
		Public Property [BankAccountID] As Guid?
		'''<![CDATA[Bank account number. Is mandatory for Journals that have Type = Bank]]>
		Public Property [BankAccountIncludingMask] As String
		'''<![CDATA[Obsolete. Whether or not use SEPA for the bank account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountUseSEPA] As Boolean?
		'''<![CDATA[Obsolete. Whether or not use SEPA direct debit for the bank account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccountUseSepaDirectDebit] As Boolean?
		'''<![CDATA[Name of bank account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankName] As String
		'''<![CDATA[Primary key]]>
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
		'''<![CDATA[Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used]]>
		Public Property [Currency] As String
		'''<![CDATA[Description of Currency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrencyDescription] As String
		'''<![CDATA[Name of the Journal]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Suspense general ledger account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[Code of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountCode] As String
		'''<![CDATA[Description of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Type of GLAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLAccountType] As Int32?
		'''<![CDATA[Primary Key]]>
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
		'''<![CDATA[General ledger account for payment in transit]]>
		Public Property [PaymentInTransitAccount] As Guid?
		'''<![CDATA[Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account]]>
		Public Property [PaymentServiceAccountIdentifier] As String
		'''<![CDATA[Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)]]>
		Public Property [PaymentServiceProvider] As Int32?
		'''<![CDATA[Name of the Payment service provider]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentServiceProviderName] As String
		'''<![CDATA[Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)]]>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Year,Period,Journal")>
	Public Class [JournalStatusList]
		'''<![CDATA[Reference to Journal]]>
		Public Property [Journal] As String
		'''<![CDATA[Description of Journal]]>
		Public Property [JournalDescription] As String
		'''<![CDATA[Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal]]>
		Public Property [JournalType] As Int32
		'''<![CDATA[Description of JournalType]]>
		Public Property [JournalTypeDescription] As String
		'''<![CDATA[Financial period]]>
		Public Property [Period] As Int32
		'''<![CDATA[Journal status for this year and period 0=open, 1=closed]]>
		Public Property [Status] As Int32
		'''<![CDATA[Description of Status]]>
		Public Property [StatusDescription] As String
		'''<![CDATA[Financial year]]>
		Public Property [Year] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("CurrencyCode")>
	Public Class [OutstandingInvoicesOverview]
		'''<![CDATA[Primary key]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Total invoice amount to be paid]]>
		Public Property [OutstandingPayableInvoiceAmount] As Double
		'''<![CDATA[Number of invoices to be paid]]>
		Public Property [OutstandingPayableInvoiceCount] As Double
		'''<![CDATA[Total invoice amount to be received]]>
		Public Property [OutstandingReceivableInvoiceAmount] As Double
		'''<![CDATA[Number of invoices to be received]]>
		Public Property [OutstandingReceivableInvoiceCount] As Double
		'''<![CDATA[Total payable invoice amount that is overdue]]>
		Public Property [OverduePayableInvoiceAmount] As Double
		'''<![CDATA[Number of payable invoices that are overdue]]>
		Public Property [OverduePayableInvoiceCount] As Double
		'''<![CDATA[Total receivable invoice amount that is overdue]]>
		Public Property [OverdueReceivableInvoiceAmount] As Double
		'''<![CDATA[Number of receivable invoices that are overdue]]>
		Public Property [OverdueReceivableInvoiceCount] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("HID")>
	Public Class [PayablesList]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Reference to the account]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Amount]]>
		Public Property [Amount] As Double
		'''<![CDATA[Amount in transit]]>
		Public Property [AmountInTransit] As Double
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Date the invoice should be paid]]>
		Public Property [DueDate] As DateTime
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32
		'''<![CDATA[Primary key, human readable ID]]>
		Public Property [HID] As Int64
		'''<![CDATA[Obsolete]]>
		Public Property [Id] As Guid
		'''<![CDATA[Invoice date]]>
		Public Property [InvoiceDate] As DateTime
		'''<![CDATA[Invoice number]]>
		Public Property [InvoiceNumber] As Int32
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		Public Property [JournalDescription] As String
		'''<![CDATA[Your reference]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("CurrentYear")>
	Public Class [ProfitLossOverview]
		'''<![CDATA[Costs in current period]]>
		Public Property [CostsCurrentPeriod] As Double
		'''<![CDATA[Costs in current year]]>
		Public Property [CostsCurrentYear] As Double
		'''<![CDATA[Costs in previous year]]>
		Public Property [CostsPreviousYear] As Double
		'''<![CDATA[Costs in period of previous year]]>
		Public Property [CostsPreviousYearPeriod] As Double
		'''<![CDATA[Currency code]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Current period]]>
		Public Property [CurrentPeriod] As Int32
		'''<![CDATA[Primary key, Current year]]>
		Public Property [CurrentYear] As Int32
		'''<![CDATA[Previous year]]>
		Public Property [PreviousYear] As Int32
		'''<![CDATA[Period in previous year]]>
		Public Property [PreviousYearPeriod] As Int32
		'''<![CDATA[Results of current period]]>
		Public Property [ResultCurrentPeriod] As Double
		Public Property [ResultCurrentYear] As Double
		Public Property [ResultPreviousYear] As Double
		'''<![CDATA[Results of period in previous year]]>
		Public Property [ResultPreviousYearPeriod] As Double
		'''<![CDATA[Revenue in current period]]>
		Public Property [RevenueCurrentPeriod] As Double
		'''<![CDATA[Revenue in current year]]>
		Public Property [RevenueCurrentYear] As Double
		'''<![CDATA[Revenue in previous year]]>
		Public Property [RevenuePreviousYear] As Double
		'''<![CDATA[Revenue in period of previous year]]>
		Public Property [RevenuePreviousYearPeriod] As Double
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("HID")>
	Public Class [ReceivablesList]
		'''<![CDATA[Code of Account]]>
		Public Property [AccountCode] As String
		'''<![CDATA[Reference to the account]]>
		Public Property [AccountId] As Guid
		'''<![CDATA[Name of Account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Amount]]>
		Public Property [Amount] As Double
		'''<![CDATA[Amount in transit]]>
		Public Property [AmountInTransit] As Double
		'''<![CDATA[Code of Currency]]>
		Public Property [CurrencyCode] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Date the invoice should be paid]]>
		Public Property [DueDate] As DateTime
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32
		'''<![CDATA[Primary key, human readable ID]]>
		Public Property [HID] As Int64
		'''<![CDATA[Obsolete]]>
		Public Property [Id] As Guid
		'''<![CDATA[Invoice date]]>
		Public Property [InvoiceDate] As DateTime
		'''<![CDATA[Invoice number]]>
		Public Property [InvoiceNumber] As Int32
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		Public Property [JournalDescription] As String
		'''<![CDATA[Your reference]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ReportingBalance]
		'''<![CDATA[The sum of the amounts of all transactions in the grouping.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[The sum of the amounts of all credit transactions in the grouping.]]>
		Public Property [AmountCredit] As Double?
		'''<![CDATA[The sum of the amounts of all debit transactions in the grouping.]]>
		Public Property [AmountDebit] As Double?
		'''<![CDATA[Balance type of the G/L account: B = Balance Sheet, W = Profit & Loss.]]>
		Public Property [BalanceType] As String
		'''<![CDATA[The code of the cost center.]]>
		Public Property [CostCenterCode] As String
		'''<![CDATA[The description of the cost center.]]>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[The code of the cost unit.]]>
		Public Property [CostUnitCode] As String
		'''<![CDATA[The description of the cost unit.]]>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[The number of transactions in the grouping.]]>
		Public Property [Count] As Int32?
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[G/L account]]>
		Public Property [GLAccount] As Guid?
		'''<![CDATA[The code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[The description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[Record ID]]>
		Public Property [ID] As Int64
		'''<![CDATA[The reporting period of the transactions in the grouping.]]>
		Public Property [ReportingPeriod] As Int32?
		'''<![CDATA[The reporting year of the transactions in the grouping.]]>
		Public Property [ReportingYear] As Int32?
		'''<![CDATA[Status: 20 = Open, 50 = Processed. To get 'after entry' results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.]]>
		Public Property [Status] As Int32?
		'''<![CDATA[The type of the transactions in the grouping.]]>
		Public Property [Type] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("DocumentID")>
	Public Class [Return]
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[Currency]]>
		Public Property [Currency] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Primary key, document ID]]>
		Public Property [DocumentID] As Guid
		'''<![CDATA[Url to view the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentViewUrl] As String
		'''<![CDATA[Due date]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[Frequency]]>
		Public Property [Frequency] As String
		'''<![CDATA[Payroll declaration type]]>
		Public Property [PayrollDeclarationType] As String
		'''<![CDATA[Period]]>
		Public Property [Period] As Int32
		'''<![CDATA[Description of Period]]>
		Public Property [PeriodDescription] As String
		'''<![CDATA[Reference to request]]>
		Public Property [Request] As Guid?
		'''<![CDATA[Status]]>
		Public Property [Status] As Int32
		'''<![CDATA[Type]]>
		Public Property [Type] As Int32
		'''<![CDATA[Year]]>
		Public Property [Year] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Year,Period")>
	Public Class [RevenueList]
		'''<![CDATA[Total amount in the default currency of the company]]>
		Public Property [Amount] As Double
		'''<![CDATA[Reporting period]]>
		Public Property [Period] As Int32
		'''<![CDATA[Reporting year]]>
		Public Property [Year] As Int32
	End Class

End Namespace