' Last generated on 2017-05-05 12:58:34Z

Namespace CRM

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [AcceptQuotation]
		'''<![CDATA[0 = No action (Default), 1 = create sales order, 2 = create sales invoice, 3 = create project.]]>
		Public Property [Action] As Int32
		'''<![CDATA[Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.]]>
		Public Property [CreateProjectWBS] As Boolean?
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[Contains the error message if an error occurred during the acception of the quotation.]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[The journal in which the sales invoice will be booked. Mandatory for Action = 2.]]>
		Public Property [InvoiceJournal] As Int32
		'''<![CDATA[The budget type of the project that will be created. Default = 0.]]>
		Public Property [ProjectBudgetType] As Int32?
		'''<![CDATA[The code of the project that will be created. Mandatory for Action = 3.]]>
		Public Property [ProjectCode] As String
		'''<![CDATA[The description of the project that will be created. Mandatory for Action = 3.]]>
		Public Property [ProjectDescription] As String
		'''<![CDATA[The invoicing date of the project. Mandatory for ProjectInvoicingAction = 2.]]>
		Public Property [ProjectInvoiceDate] As DateTime?
		'''<![CDATA[The project invoicing action. 0 = None (Default), 1 = Create invoice terms, 2 = As quoted.]]>
		Public Property [ProjectInvoicingAction] As Int32?
		'''<![CDATA[The prepaid type. Mandatory for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.]]>
		Public Property [ProjectPrepaindTypes] As Int32?
		'''<![CDATA[PriceAgreement.]]>
		Public Property [ProjectPriceAgreement] As Double?
		'''<![CDATA[Contains information if the project was successfully created.]]>
		Public Property [ProjectSuccess] As String
		'''<![CDATA[The type of the project that will be created. 2 = Fixed price (Default), 3 = Time and Material, 4 = Non billable, 5 = Prepaid.]]>
		Public Property [ProjectType] As Int32?
		'''<![CDATA[Identifier of the quotation.]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Reason why the quotation was accepted.]]>
		Public Property [ReasonCode] As Guid?
		'''<![CDATA[Contains information if the sales invoice was successfully created.]]>
		Public Property [SalesInvoiceSuccess] As String
		'''<![CDATA[Contains information if the sales order was successfully created.]]>
		Public Property [SalesOrderSuccess] As String
		'''<![CDATA[Contains information if the quotation was successfully accepted.]]>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Account]
		'''<![CDATA[Reference to the accountant of the customer. Conditions: The referred accountant must have value > 0 in the field IsAccountant]]>
		Public Property [Accountant] As Guid?
		'''<![CDATA[ID of the account manager]]>
		Public Property [AccountManager] As Guid?
		'''<![CDATA[Name of the account manager]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountManagerFullName] As String
		'''<![CDATA[Number of the account manager  ]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountManagerHID] As Int32?
		'''<![CDATA[Reference to Activity sector of the account]]>
		Public Property [ActivitySector] As Guid?
		'''<![CDATA[Reference to Activity sub-sector of the account]]>
		Public Property [ActivitySubSector] As Guid?
		'''<![CDATA[Visit address first line]]>
		Public Property [AddressLine1] As String
		'''<![CDATA[Visit address second line]]>
		Public Property [AddressLine2] As String
		'''<![CDATA[Visit address third line]]>
		Public Property [AddressLine3] As String
		'''<![CDATA[Collection of Bank accounts]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankAccounts] As IEnumerable(Of Models.CRM.BankAccount)
		'''<![CDATA[Indicates if the account is blocked]]>
		Public Property [Blocked] As Boolean?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BRIN] As Guid?
		'''<![CDATA[Reference to the business type of the account]]>
		Public Property [BusinessType] As Guid?
		'''<![CDATA[Indicates the default for the possibility to drop ship when an item is linked to a supplier]]>
		Public Property [CanDropShip] As Boolean?
		'''<![CDATA[Chamber of commerce number]]>
		Public Property [ChamberOfCommerce] As String
		'''<![CDATA[Visit address City]]>
		Public Property [City] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Classification] As String
		'''<![CDATA[Account classification 1]]>
		Public Property [Classification1] As Guid?
		'''<![CDATA[Account classification 2]]>
		Public Property [Classification2] As Guid?
		'''<![CDATA[Account classification 3]]>
		Public Property [Classification3] As Guid?
		'''<![CDATA[Account classification 4]]>
		Public Property [Classification4] As Guid?
		'''<![CDATA[Account classification 5]]>
		Public Property [Classification5] As Guid?
		'''<![CDATA[Account classification 6]]>
		Public Property [Classification6] As Guid?
		'''<![CDATA[Account classification 7]]>
		Public Property [Classification7] As Guid?
		'''<![CDATA[Account classification 8]]>
		Public Property [Classification8] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ClassificationDescription] As String
		'''<![CDATA[Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces]]>
		Public Property [Code] As String
		'''<![CDATA[Code under which your own company is known at the account]]>
		Public Property [CodeAtSupplier] As String
		'''<![CDATA[Reference to Company size of the account]]>
		Public Property [CompanySize] As Guid?
		'''<![CDATA[Consolidation scenario (Time & Billing). Values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project, 5 = Project + WBS + Item, 6 = Project + WBS + Item + Employee. Item means in this case including Unit and Price, these also have to be the same to consolidate]]>
		Public Property [ConsolidationScenario] As Byte?
		'''<![CDATA[Date of the latest control of account data with external web service]]>
		Public Property [ControlledDate] As DateTime?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Costcenter] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPaid] As Byte
		'''<![CDATA[Country code]]>
		Public Property [Country] As String
		'''<![CDATA[Country name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit]]>
		Public Property [CreditLinePurchase] As Double?
		'''<![CDATA[Maximum amount of credit for sales. If no value has been defined, there is no credit limit]]>
		Public Property [CreditLineSales] As Double?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Currency] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CustomerSince] As DateTime?
		'''<![CDATA[DATEV creditor code for Germany legislation]]>
		Public Property [DatevCreditorCode] As String
		'''<![CDATA[DATEV debtor code for Germany legislation]]>
		Public Property [DatevDebtorCode] As String
		'''<![CDATA[Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055]]>
		Public Property [DiscountPurchase] As Double?
		'''<![CDATA[Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055]]>
		Public Property [DiscountSales] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Document] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DunsNumber] As String
		'''<![CDATA[E-Mail address of the account]]>
		Public Property [Email] As String
		'''<![CDATA[Determines in combination with the start date if the account is active. If the current date is > end date the account is inactive]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[RegistrationDate]]>
		Public Property [EstablishedDate] As DateTime?
		'''<![CDATA[Fax number]]>
		Public Property [Fax] As String
		'''<![CDATA[Default (corporate) GL offset account for purchase (cost)]]>
		Public Property [GLAccountPurchase] As Guid?
		'''<![CDATA[Default (corporate) GL offset account for sales (revenue)]]>
		Public Property [GLAccountSales] As Guid?
		'''<![CDATA[Default GL account for Accounts Payable]]>
		Public Property [GLAP] As Guid?
		'''<![CDATA[Default GL account for Accounts Receivable]]>
		Public Property [GLAR] As Guid?
		'''<![CDATA[Indicates whether a customer has withholding tax on sales]]>
		Public Property [HasWithholdingTaxSales] As Boolean?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Suppressed warning message when there is duplication on the DATEV code]]>
		Public Property [IgnoreDatevWarningMessage] As Boolean
		'''<![CDATA[Intrastat Area]]>
		Public Property [IntraStatArea] As String
		'''<![CDATA[Intrastat delivery method]]>
		Public Property [IntraStatDeliveryTerm] As String
		'''<![CDATA[System for Intrastat]]>
		Public Property [IntraStatSystem] As String
		'''<![CDATA[Transaction type A for Intrastat]]>
		Public Property [IntraStatTransactionA] As String
		'''<![CDATA[Transaction type B for Intrastat]]>
		Public Property [IntraStatTransactionB] As String
		'''<![CDATA[Transport method for Intrastat]]>
		Public Property [IntraStatTransportMethod] As String
		'''<![CDATA[ID of account to be invoiced instead of this account]]>
		Public Property [InvoiceAccount] As Guid?
		'''<![CDATA[Code of InvoiceAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountCode] As String
		'''<![CDATA[Name of InvoiceAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountName] As String
		'''<![CDATA[Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed]]>
		Public Property [InvoiceAttachmentType] As Int32?
		'''<![CDATA[Method of sending for sales invoices. Values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)]]>
		Public Property [InvoicingMethod] As Int32?
		'''<![CDATA[Indicates whether the account is an accountant. Values: 0 = No accountant, 1 = True, but accountant doesn't want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants]]>
		Public Property [IsAccountant] As Byte
		'''<![CDATA[Indicates whether the accounti is an agency]]>
		Public Property [IsAgency] As Byte
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBank] As Boolean?
		'''<![CDATA[Indicates whether the account is a competitor]]>
		Public Property [IsCompetitor] As Byte
		'''<![CDATA[Indicates whether a customer is eligible for extra duty]]>
		Public Property [IsExtraDuty] As Boolean?
		'''<![CDATA[Indicates if the account is excluded from mailing marketing information]]>
		Public Property [IsMailing] As Byte
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMember] As Boolean?
		'''<![CDATA[Indicates whether the account is a pilot account]]>
		Public Property [IsPilot] As Boolean?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsPurchase] As Boolean?
		'''<![CDATA[Indicates whether the account is a reseller]]>
		Public Property [IsReseller] As Boolean?
		'''<![CDATA[Indicates whether the account is allowed for sales]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSales] As Boolean?
		'''<![CDATA[Indicates whether the account is a supplier]]>
		Public Property [IsSupplier] As Boolean?
		'''<![CDATA[Language code]]>
		Public Property [Language] As String
		'''<![CDATA[Language description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LanguageDescription] As String
		'''<![CDATA[Latitude (used by Google maps)]]>
		Public Property [Latitude] As Double?
		'''<![CDATA[Reference to Lead source of an account]]>
		Public Property [LeadSource] As Guid?
		'''<![CDATA[Bytes of the logo image]]>
		Public Property [Logo] As Byte()
		'''<![CDATA[The file name (without path, but with extension) of the image]]>
		Public Property [LogoFileName] As String
		'''<![CDATA[Thumbnail url of the logo]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LogoThumbnailUrl] As String
		'''<![CDATA[Url to retrieve the logo]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LogoUrl] As String
		'''<![CDATA[Longitude (used by Google maps)]]>
		Public Property [Longitude] As Double?
		'''<![CDATA[Reference to main contact person]]>
		Public Property [MainContact] As Guid?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Account name]]>
		Public Property [Name] As String
		'''<![CDATA[ID of the parent account]]>
		Public Property [Parent] As Guid?
		'''<![CDATA[Indicates the loan repayment plan for UK legislation]]>
		Public Property [PayAsYouEarn] As String
		'''<![CDATA[Code of default payment condition for purchase]]>
		Public Property [PaymentConditionPurchase] As String
		'''<![CDATA[Description of PaymentConditionPurchase]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionPurchaseDescription] As String
		'''<![CDATA[Code of default payment condition for sales]]>
		Public Property [PaymentConditionSales] As String
		'''<![CDATA[Description of PaymentConditionSales]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionSalesDescription] As String
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone number extention]]>
		Public Property [PhoneExtension] As String
		'''<![CDATA[Visit address postcode]]>
		Public Property [Postcode] As String
		'''<![CDATA[Default sales price list for account]]>
		Public Property [PriceList] As Guid?
		'''<![CDATA[Currency of purchase]]>
		Public Property [PurchaseCurrency] As String
		'''<![CDATA[Description of PurchaseCurrency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseCurrencyDescription] As String
		'''<![CDATA[Indicates number of days required to receive a purchase. Acts as a default]]>
		Public Property [PurchaseLeadDays] As Int32?
		'''<![CDATA[Default VAT code used for purchase entries]]>
		Public Property [PurchaseVATCode] As String
		'''<![CDATA[Description of PurchaseVATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseVATCodeDescription] As String
		'''<![CDATA[Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax]]>
		Public Property [RecepientOfCommissions] As Boolean?
		'''<![CDATA[Remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[ID of the reseller account. Conditions: the target account must have the property IsReseller turned on]]>
		Public Property [Reseller] As Guid?
		'''<![CDATA[Code of Reseller]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerCode] As String
		'''<![CDATA[Name of Reseller]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ResellerName] As String
		'''<![CDATA[Fiscal number for NL legislation]]>
		Public Property [RSIN] As String
		'''<![CDATA[Currency of Sales used for Time & Billing]]>
		Public Property [SalesCurrency] As String
		'''<![CDATA[Description of SalesCurrency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesCurrencyDescription] As String
		'''<![CDATA[Obsolete]]>
		Public Property [SalesTaxSchedule] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTaxScheduleCode] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTaxScheduleDescription] As String
		'''<![CDATA[Default VAT code for a sales entry]]>
		Public Property [SalesVATCode] As String
		'''<![CDATA[Description of SalesVATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesVATCodeDescription] As String
		'''<![CDATA[Search code]]>
		Public Property [SearchCode] As String
		'''<![CDATA[Security level (0 - 100)]]>
		Public Property [SecurityLevel] As Int32?
		'''<![CDATA[Separate invoice per project (Time & Billing)]]>
		Public Property [SeparateInvPerProject] As Byte
		'''<![CDATA[Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line]]>
		Public Property [SeparateInvPerSubscription] As Byte
		'''<![CDATA[Indicates the number of days it takes to send goods to the customer. Acts as a default]]>
		Public Property [ShippingLeadDays] As Int32?
		'''<![CDATA[Default shipping method]]>
		Public Property [ShippingMethod] As Guid?
		'''<![CDATA[Indicates in combination with the end date if the account is active]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[State/Province code]]>
		Public Property [State] As String
		'''<![CDATA[Name of State]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StateName] As String
		'''<![CDATA[If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer]]>
		Public Property [Status] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusSince] As DateTime?
		'''<![CDATA[Trade name can be registered and shown with the client (for all legislations)]]>
		Public Property [TradeName] As String
		'''<![CDATA[Account type: Values: A = Relation, D = Division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As String
		'''<![CDATA[Unique taxpayer reference for UK legislation]]>
		Public Property [UniqueTaxpayerReference] As String
		'''<![CDATA[Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium]]>
		Public Property [VATLiability] As String
		'''<![CDATA[The number under which the account is known at the Value Added Tax collection agency]]>
		Public Property [VATNumber] As String
		'''<![CDATA[Website of the account]]>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClass]
		'''<![CDATA[Classification code]]>
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
		'''<![CDATA[Description]]>
		Public Property [Description] As String
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
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClassification]
		'''<![CDATA[Reference to Account classification name]]>
		Public Property [AccountClassificationName] As Guid?
		'''<![CDATA[Description of AccountClassificationName]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountClassificationNameDescription] As String
		'''<![CDATA[Account classification code]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
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
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountClassificationName]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
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
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Sequence number]]>
		Public Property [SequenceNumber] As Int32
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Address]
		'''<![CDATA[Account linked to the address]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Indicates if the account is a supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<![CDATA[Name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[First address line]]>
		Public Property [AddressLine1] As String
		'''<![CDATA[Second address line]]>
		Public Property [AddressLine2] As String
		'''<![CDATA[Third address line]]>
		Public Property [AddressLine3] As String
		'''<![CDATA[City]]>
		Public Property [City] As String
		'''<![CDATA[Contact linked to Address]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[Contact name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ContactName] As String
		'''<![CDATA[Country code]]>
		Public Property [Country] As String
		'''<![CDATA[Country name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CountryName] As String
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
		'''<![CDATA[Fax number]]>
		Public Property [Fax] As String
		'''<![CDATA[Free boolean field 1]]>
		Public Property [FreeBoolField_01] As Boolean?
		'''<![CDATA[Free boolean field 2]]>
		Public Property [FreeBoolField_02] As Boolean?
		'''<![CDATA[Free boolean field 3]]>
		Public Property [FreeBoolField_03] As Boolean?
		'''<![CDATA[Free boolean field 4]]>
		Public Property [FreeBoolField_04] As Boolean?
		'''<![CDATA[Free boolean field 5]]>
		Public Property [FreeBoolField_05] As Boolean?
		'''<![CDATA[Free date field 1]]>
		Public Property [FreeDateField_01] As DateTime?
		'''<![CDATA[Free date field 2]]>
		Public Property [FreeDateField_02] As DateTime?
		'''<![CDATA[Free date field 3]]>
		Public Property [FreeDateField_03] As DateTime?
		'''<![CDATA[Free date field 4]]>
		Public Property [FreeDateField_04] As DateTime?
		'''<![CDATA[Free date field 5]]>
		Public Property [FreeDateField_05] As DateTime?
		'''<![CDATA[Free number field 1]]>
		Public Property [FreeNumberField_01] As Double?
		'''<![CDATA[Free number field 2]]>
		Public Property [FreeNumberField_02] As Double?
		'''<![CDATA[Free number field 3]]>
		Public Property [FreeNumberField_03] As Double?
		'''<![CDATA[Free number field 4]]>
		Public Property [FreeNumberField_04] As Double?
		'''<![CDATA[Free number field 5]]>
		Public Property [FreeNumberField_05] As Double?
		'''<![CDATA[Free text field 1]]>
		Public Property [FreeTextField_01] As String
		'''<![CDATA[Free text field 2]]>
		Public Property [FreeTextField_02] As String
		'''<![CDATA[Free text field 3]]>
		Public Property [FreeTextField_03] As String
		'''<![CDATA[Free text field 4]]>
		Public Property [FreeTextField_04] As String
		'''<![CDATA[Free text field 5]]>
		Public Property [FreeTextField_05] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Mailbox]]>
		Public Property [Mailbox] As String
		'''<![CDATA[Indicates if the address is the main address for this type]]>
		Public Property [Main] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office]]>
		Public Property [NicNumber] As String
		'''<![CDATA[Notes for an address]]>
		Public Property [Notes] As String
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone extension]]>
		Public Property [PhoneExtension] As String
		'''<![CDATA[Postcode]]>
		Public Property [Postcode] As String
		'''<![CDATA[State]]>
		Public Property [State] As String
		'''<![CDATA[Name of the State]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StateDescription] As String
		'''<![CDATA[The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4]]>
		Public Property [Type] As Int16?
		'''<![CDATA[The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of the warehoude]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of the warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AddressState]
		'''<![CDATA[Country code]]>
		Public Property [Country] As String
		'''<![CDATA[Description of state prefixed with the code]]>
		Public Property [DisplayValue] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Latitude]]>
		Public Property [Latitude] As Double?
		'''<![CDATA[Longitude]]>
		Public Property [Longitude] As Double?
		'''<![CDATA[State name]]>
		Public Property [Name] As String
		'''<![CDATA[State code]]>
		Public Property [State] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [BankAccount]
		'''<![CDATA[Account (customer, supplier) to which the bank account belongs]]>
		Public Property [Account] As Guid?
		'''<![CDATA[The name of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Bank] As Guid?
		'''<![CDATA[The bank account number]]>
		Public Property [BankAccount] As String
		'''<![CDATA[Name of the holder of the bank account, as known by the bank]]>
		Public Property [BankAccountHolderName] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankDescription] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BankName] As String
		'''<![CDATA[BIC code of the bank where the bank account is held]]>
		Public Property [BICCode] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the bank account]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Format that belongs to the bank account number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Format] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IBAN] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if the bank account is the main bank account]]>
		Public Property [Main] As Boolean?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[ID of the Payment service account. Used when Type is 'P' (Payment service)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentServiceAccount] As Guid?
		'''<![CDATA[The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it's only possible to create 'Account' type bank accounts.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As String
		'''<![CDATA[Description of the Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Contact]
		'''<![CDATA[The account to which the contact belongs]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Indicates if account is a customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsCustomer] As Boolean
		'''<![CDATA[Indicates if account is a supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<![CDATA[Reference to the main contact of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountMainContact] As Guid?
		'''<![CDATA[Name of the account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Second address line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressLine2] As String
		'''<![CDATA[Street name of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreet] As String
		'''<![CDATA[Street number of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumber] As String
		'''<![CDATA[Street number suffix of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumberSuffix] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AllowMailing] As Int32?
		'''<![CDATA[Birth date]]>
		Public Property [BirthDate] As DateTime?
		'''<![CDATA[Obsolete. Please don't use this field anymore as it may overwrite LastName.]]>
		Public Property [BirthName] As String
		'''<![CDATA[Obsolete. Please don't use this field anymore as it may overwrite MiddleName.]]>
		Public Property [BirthNamePrefix] As String
		'''<![CDATA[Birth place]]>
		Public Property [BirthPlace] As String
		'''<![CDATA[Email address of the contact]]>
		Public Property [BusinessEmail] As String
		'''<![CDATA[Fax of the contact]]>
		Public Property [BusinessFax] As String
		'''<![CDATA[Mobile of the contact]]>
		Public Property [BusinessMobile] As String
		'''<![CDATA[Phone of the contact]]>
		Public Property [BusinessPhone] As String
		'''<![CDATA[Phone extension of the contact]]>
		Public Property [BusinessPhoneExtension] As String
		'''<![CDATA[City]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [City] As String
		'''<![CDATA[Code of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Code] As String
		'''<![CDATA[Country code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
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
		'''<![CDATA[Email address of the contact]]>
		Public Property [Email] As String
		'''<![CDATA[End date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
		Public Property [FirstName] As String
		'''<![CDATA[Full name (First name Middle name Last name)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FullName] As String
		'''<![CDATA[Gender]]>
		Public Property [Gender] As String
		'''<![CDATA[Contact ID]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Identification date]]>
		Public Property [IdentificationDate] As DateTime?
		'''<![CDATA[Reference to the identification document of the contact]]>
		Public Property [IdentificationDocument] As Guid?
		'''<![CDATA[Reference to the user responsible for identification]]>
		Public Property [IdentificationUser] As Guid?
		'''<![CDATA[Initials]]>
		Public Property [Initials] As String
		'''<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
		Public Property [IsMailingExcluded] As Boolean?
		'''<![CDATA[Indicates if this is the main contact of the linked account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMainContact] As Boolean?
		'''<![CDATA[Jobtitle of the contact]]>
		Public Property [JobTitleDescription] As String
		'''<![CDATA[Language code]]>
		Public Property [Language] As String
		'''<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
		Public Property [LastName] As String
		'''<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
		Public Property [MarketingNotes] As String
		'''<![CDATA[Middle name]]>
		Public Property [MiddleName] As String
		'''<![CDATA[Business phone of the contact]]>
		Public Property [Mobile] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Nationality]]>
		Public Property [Nationality] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Last name of partner]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerName] As String
		'''<![CDATA[Middlename of partner]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerNamePrefix] As String
		'''<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
		Public Property [Person] As Guid?
		'''<![CDATA[Phone of the contact]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone extension of the contact]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PhoneExtension] As String
		'''<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
		Public Property [Picture] As Byte()
		'''<![CDATA[Filename of the picture]]>
		Public Property [PictureName] As String
		'''<![CDATA[Url to retrieve the picture thumbnail]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<![CDATA[Url to retrieve the picture]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<![CDATA[Postcode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Postcode] As String
		'''<![CDATA[Social security number]]>
		Public Property [SocialSecurityNumber] As String
		'''<![CDATA[Start date]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[State]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [State] As String
		'''<![CDATA[Title]]>
		Public Property [Title] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Document]
		'''<![CDATA[ID of the related account of this document]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Attachments linked to the document. Binaries are not sent in the response.]]>
		Public Property [Attachments] As IEnumerable(Of Models.CRM.DocumentsAttachment)
		'''<![CDATA[Body of this document]]>
		Public Property [Body] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of creator]]>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[Entry date of the incoming document]]>
		Public Property [DocumentDate] As DateTime?
		'''<![CDATA[Id of document folder]]>
		Public Property [DocumentFolder] As Guid?
		'''<![CDATA[Url to view the document]]>
		Public Property [DocumentViewUrl] As String
		'''<![CDATA[Indicates that the document body is empty]]>
		Public Property [HasEmptyBody] As Boolean
		'''<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
		Public Property [HID] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of modifier]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[The opportunity linked to the document]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[Purchase invoice number.]]>
		Public Property [PurchaseInvoiceNumber] As Int32?
		'''<![CDATA[Purchase order number.]]>
		Public Property [PurchaseOrderNumber] As Int32?
		'''<![CDATA['Our reference' of the transaction that belongs to this document]]>
		Public Property [SalesInvoiceNumber] As Int32?
		'''<![CDATA[Number of the sales order]]>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[Send Method]]>
		Public Property [SendMethod] As Int32?
		Public Property [Share] As Int32
		'''<![CDATA[Subject of this document]]>
		Public Property [Subject] As String
		'''<![CDATA[The document type]]>
		Public Property [Type] As Int32
		'''<![CDATA[Translated description of the document type. $filter and $orderby are not supported for this property.]]>
		Public Property [TypeDescription] As String
		'''<![CDATA[Translation id of the document type description]]>
		Public Property [TypeDescriptionTermId] As Int32
		'''<![CDATA[English description of the document type]]>
		Public Property [UntermedTypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [DocumentsAttachment]
		'''<![CDATA[Filename of the attachment]]>
		Public Property [AttachmentFileName] As String
		'''<![CDATA[File size of the attachment]]>
		Public Property [AttachmentFileSize] As Double
		'''<![CDATA[Url for downloading the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append <b>&Download=1</b> to the url.]]>
		Public Property [AttachmentUrl] As String
		Public Property [CanShowInWebView] As Boolean
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Opportunity]
		'''<![CDATA[Lead to which the opportunity applies]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Indicates the date before/on the NextAction is supposed to be done]]>
		Public Property [ActionDate] As DateTime?
		'''<![CDATA[Amount in the default currency of the company. AmountDC = AmountFC * RateFC]]>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Reference to the campaign opportunity is related to]]>
		Public Property [Campaign] As Guid?
		'''<![CDATA[Description of Campaign]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CampaignDescription] As String
		'''<![CDATA[The date when the opportunity is expected to be closed]]>
		Public Property [CloseDate] As DateTime?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[The source of the lead/opportunity]]>
		Public Property [LeadSource] As Guid?
		'''<![CDATA[Description of LeadSource]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LeadSourceDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Name of the opportunity]]>
		Public Property [Name] As String
		'''<![CDATA[Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate]]>
		Public Property [NextAction] As String
		'''<![CDATA[Notes of the opportunity]]>
		Public Property [Notes] As String
		'''<![CDATA[The stage of the opportunity. This is a list defined by the user]]>
		Public Property [OpportunityStage] As Guid?
		'''<![CDATA[Description of OpportunityStage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStageDescription] As String
		'''<![CDATA[Status: 1=Open, 2=Closed won, 3=Closed lost]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityStatus] As Int32?
		'''<![CDATA[The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)]]>
		Public Property [Owner] As Guid?
		'''<![CDATA[Name of Owner]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OwnerFullName] As String
		'''<![CDATA[The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage]]>
		Public Property [Probability] As Double?
		'''<![CDATA[Reference to project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Code of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Exchange rate from original to division currency]]>
		Public Property [RateFC] As Double?
		'''<![CDATA[Indicates the reason why the opportunity was lost.]]>
		Public Property [ReasonCode] As Guid?
		'''<![CDATA[Description of ReasonCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReasonCodeDescription] As String
		'''<![CDATA[Reference to Sales type]]>
		Public Property [SalesType] As Guid?
		'''<![CDATA[Description of SalesType]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesTypeDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [OpportunityContact]
		'''<![CDATA[The account to which the contact belongs]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Indicates if account is a customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsCustomer] As Boolean
		'''<![CDATA[Indicates if account is a supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountIsSupplier] As Boolean?
		'''<![CDATA[Reference to the main contact of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountMainContact] As Guid?
		'''<![CDATA[Name of the account]]>
		Public Property [AccountName] As String
		'''<![CDATA[Second address line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressLine2] As String
		'''<![CDATA[Street name of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreet] As String
		'''<![CDATA[Street number of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumber] As String
		'''<![CDATA[Street number suffix of the address]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AddressStreetNumberSuffix] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AllowMailing] As Int32?
		'''<![CDATA[Birth date]]>
		Public Property [BirthDate] As DateTime?
		'''<![CDATA[Obsolete. Please don't use this field anymore as it may overwrite LastName.]]>
		Public Property [BirthName] As String
		'''<![CDATA[Obsolete. Please don't use this field anymore as it may overwrite MiddleName.]]>
		Public Property [BirthNamePrefix] As String
		'''<![CDATA[Birth place]]>
		Public Property [BirthPlace] As String
		'''<![CDATA[Email address of the contact]]>
		Public Property [BusinessEmail] As String
		'''<![CDATA[Fax of the contact]]>
		Public Property [BusinessFax] As String
		'''<![CDATA[Mobile of the contact]]>
		Public Property [BusinessMobile] As String
		'''<![CDATA[Phone of the contact]]>
		Public Property [BusinessPhone] As String
		'''<![CDATA[Phone extension of the contact]]>
		Public Property [BusinessPhoneExtension] As String
		'''<![CDATA[City]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [City] As String
		'''<![CDATA[Code of the account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Code] As String
		'''<![CDATA[Contact person that is linked to the opportunity]]>
		Public Property [Contact] As Guid?
		'''<![CDATA[Country code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
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
		'''<![CDATA[Email address of the contact]]>
		Public Property [Email] As String
		'''<![CDATA[End date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
		Public Property [FirstName] As String
		'''<![CDATA[Full name (First name Middle name Last name)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [FullName] As String
		'''<![CDATA[Gender]]>
		Public Property [Gender] As String
		'''<![CDATA[Contact ID]]>
		Public Property [HID] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Identification date]]>
		Public Property [IdentificationDate] As DateTime?
		'''<![CDATA[Reference to the identification document of the contact]]>
		Public Property [IdentificationDocument] As Guid?
		'''<![CDATA[Reference to the user responsible for identification]]>
		Public Property [IdentificationUser] As Guid?
		'''<![CDATA[Initials]]>
		Public Property [Initials] As String
		'''<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
		Public Property [IsMailingExcluded] As Boolean?
		'''<![CDATA[Indicates if this is the main contact of the linked account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsMainContact] As Boolean?
		'''<![CDATA[Jobtitle of the contact]]>
		Public Property [JobTitleDescription] As String
		'''<![CDATA[Language code]]>
		Public Property [Language] As String
		'''<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
		Public Property [LastName] As String
		'''<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
		Public Property [MarketingNotes] As String
		'''<![CDATA[Middle name]]>
		Public Property [MiddleName] As String
		'''<![CDATA[Business phone of the contact]]>
		Public Property [Mobile] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Nationality]]>
		Public Property [Nationality] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Opportunity that is linked to the contact person]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[Last name of partner]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerName] As String
		'''<![CDATA[Middlename of partner]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PartnerNamePrefix] As String
		'''<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
		Public Property [Person] As Guid?
		'''<![CDATA[Phone of the contact]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone extension of the contact]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PhoneExtension] As String
		'''<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
		Public Property [Picture] As Byte()
		'''<![CDATA[Filename of the picture]]>
		Public Property [PictureName] As String
		'''<![CDATA[Url to retrieve the picture thumbnail]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<![CDATA[Url to retrieve the picture]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<![CDATA[Postcode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Postcode] As String
		'''<![CDATA[Social security number]]>
		Public Property [SocialSecurityNumber] As String
		'''<![CDATA[Start date]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[State]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [State] As String
		'''<![CDATA[Title]]>
		Public Property [Title] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [PrintQuotation]
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32
		'''<![CDATA[Contains the id of the document that was created]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
		Public Property [DocumentCreationError] As String
		'''<![CDATA[Contains information if a document was successfully created]]>
		Public Property [DocumentCreationSuccess] As String
		'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.]]>
		Public Property [DocumentLayout] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the Email]]>
		Public Property [EmailCreationError] As String
		'''<![CDATA[Based on this layout the email text is produced. In case it is not specified, the default layout is used.]]>
		Public Property [EmailLayout] As Guid?
		'''<![CDATA[Extra text that can be added to the printed document and email]]>
		Public Property [ExtraText] As String
		'''<![CDATA[Date of the quotation printed]]>
		Public Property [QuotationDate] As DateTime
		'''<![CDATA[Identifier of the quotation]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Set to True if an email containing the quotation should be sent to the customer]]>
		Public Property [SendEmailToCustomer] As Boolean
		'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
		Public Property [SenderEmailAddress] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("QuotationID")>
	Public Class [Quotation]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<![CDATA[Amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<![CDATA[Date on which the customer accepted or rejected the quotation version]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CloseDate] As DateTime?
		'''<![CDATA[Date on which you expect to close/win the deal]]>
		Public Property [ClosingDate] As DateTime?
		'''<![CDATA[Date and time on which the quotation was created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The currency of the quotation]]>
		Public Property [Currency] As String
		'''<![CDATA[The account where the items should delivered]]>
		Public Property [DeliveryAccount] As Guid?
		'''<![CDATA[The code of the delivery account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountCode] As String
		'''<![CDATA[The contact person of the delivery account]]>
		Public Property [DeliveryAccountContact] As Guid?
		'''<![CDATA[Full name of the delivery account contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountContactFullName] As String
		'''<![CDATA[The name of the delivery account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountName] As String
		'''<![CDATA[The id of the delivery address]]>
		Public Property [DeliveryAddress] As Guid?
		'''<![CDATA[The description of the quotation]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Document linked to the quotation]]>
		Public Property [Document] As Guid?
		'''<![CDATA[The subject of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Date after which the quotation is no longer valid]]>
		Public Property [DueDate] As DateTime?
		'''<![CDATA[The account to which the invoice is sent]]>
		Public Property [InvoiceAccount] As Guid?
		'''<![CDATA[The code of the invoice account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountCode] As String
		'''<![CDATA[The contact person of the invoice account]]>
		Public Property [InvoiceAccountContact] As Guid?
		'''<![CDATA[Full name of the invoice account contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountContactFullName] As String
		'''<![CDATA[The name of the invoice account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceAccountName] As String
		'''<![CDATA[Date and time on which the quotation was last modified]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Opportunity linked to the quotation]]>
		Public Property [Opportunity] As Guid?
		'''<![CDATA[The name of the opportunity]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OpportunityName] As String
		'''<![CDATA[The account that requested the quotation]]>
		Public Property [OrderAccount] As Guid?
		'''<![CDATA[The code of the order account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountCode] As String
		'''<![CDATA[The contact person of the order account]]>
		Public Property [OrderAccountContact] As Guid?
		'''<![CDATA[Full name of the order account contact person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountContactFullName] As String
		'''<![CDATA[The name of the order account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderAccountName] As String
		'''<![CDATA[The project linked to the quotation]]>
		Public Property [Project] As Guid?
		'''<![CDATA[The code of the project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[The description of the project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted]]>
		Public Property [QuotationDate] As DateTime?
		'''<![CDATA[Identifier of the quotation]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[The collection of quotation lines]]>
		Public Property [QuotationLines] As IEnumerable(Of Models.CRM.QuotationLine)
		'''<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
		Public Property [QuotationNumber] As Int32
		'''<![CDATA[Extra text that can be added to the quotation]]>
		Public Property [Remarks] As String
		'''<![CDATA[The user that is responsible for the quotation version]]>
		Public Property [SalesPerson] As Guid?
		'''<![CDATA[Full name of the sales person]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesPersonFullName] As String
		'''<![CDATA[The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[The description of the status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Total VAT amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[Number indicating the different reviews which are made for the quotation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32
		'''<![CDATA[The number by which this quotation is identified by the order account]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [QuotationLine]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double
		'''<![CDATA[Amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double
		'''<![CDATA[By default this contains the item description]]>
		Public Property [Description] As String
		'''<![CDATA[Discount given on the default price. This is stored as a fraction. ie 5.5% is stored as .055]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to the item that is sold in this quotation line]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Description of the item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates the sequence of the lines within one quotation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<![CDATA[Net price of the quotation line]]>
		Public Property [NetPrice] As Double?
		'''<![CDATA[Extra notes]]>
		Public Property [Notes] As String
		'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Identifies the quotation. All the lines of a quotation have the same QuotationID]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuotationNumber] As Int32
		'''<![CDATA[Code of the item unit]]>
		Public Property [UnitCode] As String
		'''<![CDATA[Description of the item unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Price per item unit]]>
		Public Property [UnitPrice] As Double?
		'''<![CDATA[VAT amount of the line in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmountFC] As Double?
		'''<![CDATA[The VAT code that is used when the quotation is invoiced]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of the VAT code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<![CDATA[The VAT percentage of the VAT code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[Number indicating the different reviews which are made for the quotation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VersionNumber] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ReasonCode]
		'''<![CDATA[Indicates if the reason code is active.]]>
		Public Property [Active] As Byte?
		'''<![CDATA[Code of the reason.]]>
		Public Property [Code] As String
		'''<![CDATA[Creation date.]]>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator.]]>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the reason code.]]>
		Public Property [Description] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key.]]>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date.]]>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier.]]>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier.]]>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra notes.]]>
		Public Property [Notes] As String
		'''<![CDATA[Type of the reason code.]]>
		Public Property [Type] As Int16?
		'''<![CDATA[Description of the type of the reason code.]]>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [RejectQuotation]
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[Contains the error message if an error occurred during the rejection of the quotation.]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[Identifier of the quotation.]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Reason why the quotation was rejected.]]>
		Public Property [ReasonCode] As Guid?
		'''<![CDATA[Contains information if the quotation was successfully rejected.]]>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [ReopenQuotation]
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[Contains the error message if an error occurred during the reopening of the quotation.]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[Identifier of the quotation.]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Contains information if the quotation was successfully reopened.]]>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("QuotationID")>
	Public Class [ReviewQuotation]
		'''<![CDATA[Indicates if the item prices should be copied from the original quotation or the default item prices should be used.]]>
		Public Property [CopyItemPrices] As Boolean?
		'''<![CDATA[The description of the new quotation.]]>
		Public Property [Description] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[The document linked to the new quotation.]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the reviewing of the quotation.]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[Identifier of the newly created quotation.]]>
		Public Property [NewQuotationID] As Guid?
		'''<![CDATA[The account who made the order.]]>
		Public Property [OrderAccount] As Guid?
		'''<![CDATA[The contact person of the account who made the order.]]>
		Public Property [OrderAccountContact] As Guid?
		'''<![CDATA[The paymentcondition linked to the new quotation.]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[The date of the new quotation.]]>
		Public Property [QuotationDate] As DateTime?
		'''<![CDATA[Identifier of the quotation.]]>
		Public Property [QuotationID] As Guid
		'''<![CDATA[Contains information if the quotation was successfully reviewed.]]>
		Public Property [SuccessMessage] As String
	End Class

End Namespace