' Last generated on 2017-05-05 12:58:34Z

Namespace GeneralJournalEntry

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("EntryID")>
	Public Class [GeneralJournalEntry]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Exchange rate]]>
		Public Property [ExchangeRate] As Double?
		'''<![CDATA[Financial period]]>
		Public Property [FinancialPeriod] As Int16?
		'''<![CDATA[Financial year]]>
		Public Property [FinancialYear] As Int16?
		'''<![CDATA[Collection of lines]]>
		Public Property [GeneralJournalEntryLines] As IEnumerable(Of Models.GeneralJournalEntry.GeneralJournalEntryLine)
		'''<![CDATA[Code of Journal]]>
		Public Property [JournalCode] As String
		'''<![CDATA[Description of Journal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [JournalDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[Indicates that amounts are reversed]]>
		Public Property [Reversal] As Boolean?
		'''<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Type: 10 = Opening balance, 90 = Other]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GeneralJournalEntryLine]
		'''<![CDATA[Reference to account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Amount in the default currency of the company, If an 'Including' VAT code is used this amount includes the VAT amount.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction. If an 'Including' VAT code is used this amount includes the VAT amount.]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Vat amount in the default currency of the company.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountVATDC] As Double?
		'''<![CDATA[Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.]]>
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
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Entry date]]>
		Public Property [Date] As DateTime?
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
		'''<![CDATA[Reference to header of the entry]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Entry number of the header]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
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
		Public Property [OffsetID] As Guid?
		'''<![CDATA[Our ref of general journal entry]]>
		Public Property [OurRef] As Int32?
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
		'''<![CDATA[VAT base amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountDC] As Double?
		'''<![CDATA[VAT base amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATBaseAmountFC] As Double?
		'''<![CDATA[VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[Vat percentage]]>
		Public Property [VATPercentage] As Double?
		'''<![CDATA[The VAT type determines what the values are in relation to VAT returns. The following values are supported:<br>A Sales VAT to pay,<br>D Credit note extra duty to claim,<br>I Purchase basis,<br>M Credit note purchase non-deductible,<br>N Purchase non-deductible,<br>O Purchase VAT to claim,<br>P Purchase VAT to pay,<br>Q Credit note purchase VAT to claim,<br>R Extra duty to pay,<br>S No VAT,<br>V Sales basis,<br>W Credit note purchase basis,<br>X Credit note sales basis,<br>Y Credit note purchase VAT to pay,<br>Z Credit note sales VAT to claim]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATType] As String
	End Class

End Namespace