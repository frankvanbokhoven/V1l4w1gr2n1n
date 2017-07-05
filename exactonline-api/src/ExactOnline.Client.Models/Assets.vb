' Last generated on 2017-05-05 12:58:34Z

Namespace Assets

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Asset]
		'''<![CDATA[Indicates if an asset was already depreciated before registering it in Exact Online]]>
		Public Property [AlreadyDepreciated] As Byte
		'''<![CDATA[In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset]]>
		Public Property [AssetFrom] As Guid?
		'''<![CDATA[Description of AssetFrom]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetFromDescription] As String
		'''<![CDATA[Asset group identifies GLAccounts to be used for Asset transactions]]>
		Public Property [AssetGroup] As Guid?
		'''<![CDATA[Code of the asset group]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetGroupCode] As String
		'''<![CDATA[Description of the asset group]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AssetGroupDescription] As String
		'''<![CDATA[The catalogue value of the asset]]>
		Public Property [CatalogueValue] As Double?
		'''<![CDATA[Code of the asset]]>
		Public Property [Code] As String
		'''<![CDATA[Assets can be linked to a cost center]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Assets can be linked to a cost unit]]>
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
		'''<![CDATA[Used for Belgium legislation. Used to produce the official 'Investment deduction' report]]>
		Public Property [DeductionPercentage] As Double?
		'''<![CDATA[Amount that is already depreciated when adding an existing asset. Can only be filled when 'Alreadydepreciated' is on]]>
		Public Property [DepreciatedAmount] As Double?
		'''<![CDATA[Number of periods that already have been depreciated for the asset. Can only be filled when 'Alreadydepreciated' is on]]>
		Public Property [DepreciatedPeriods] As Int32?
		'''<![CDATA[StartDate of depreciating. Can only be filled when 'Alreadydepreciated' is on]]>
		Public Property [DepreciatedStartDate] As DateTime?
		'''<![CDATA[This is the description of the Asset]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Asset EndDate is filled when asset is Sold or Inactive]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Engine emission of the asset, needed to calculate the co² report]]>
		Public Property [EngineEmission] As Int16?
		'''<![CDATA[Engine type of the asset, Needed to generate a co² report]]>
		Public Property [EngineType] As Int16?
		'''<![CDATA[Links to the gltransactions.id. GL transaction line based on which the asset is created]]>
		Public Property [GLTransactionLine] As Guid?
		'''<![CDATA[Description of GLTransactionLine]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLTransactionLineDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Supplier of the asset]]>
		Public Property [InvestmentAccount] As Guid?
		'''<![CDATA[Code of InvestmentAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentAccountCode] As String
		'''<![CDATA[Name of InvestmentAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentAccountName] As String
		'''<![CDATA[Investment amount in the default currency of the company]]>
		Public Property [InvestmentAmountDC] As Double?
		'''<![CDATA[Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status 'Not used' after sources have been cleaned]]>
		Public Property [InvestmentAmountFC] As Double?
		'''<![CDATA[Indicates the currency of the investment amount]]>
		Public Property [InvestmentCurrency] As String
		'''<![CDATA[Description of InvestmentCurrency]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvestmentCurrencyDescription] As String
		'''<![CDATA[Refers to the original date when the asset was bought]]>
		Public Property [InvestmentDate] As DateTime?
		'''<![CDATA[Belgian functionality, to determine how a local legal report regarding investment deduction must be created]]>
		Public Property [InvestmentDeduction] As Int16?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Extra remarks for the asset]]>
		Public Property [Notes] As String
		'''<![CDATA[Parent asset]]>
		Public Property [Parent] As Guid?
		'''<![CDATA[Code of Parent]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentCode] As String
		'''<![CDATA[Description of Parent]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentDescription] As String
		'''<![CDATA[Image for an asset]]>
		Public Property [Picture] As Byte()
		'''<![CDATA[Filename of the image]]>
		Public Property [PictureFileName] As String
		'''<![CDATA[First method of depreciation. Currently, it is the only one used]]>
		Public Property [PrimaryMethod] As Guid?
		'''<![CDATA[Code of PrimaryMethod]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrimaryMethodCode] As String
		'''<![CDATA[Description of PrimaryMethod]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PrimaryMethodDescription] As String
		'''<![CDATA[Indicates the residual value of the asset at the end of the depreciation]]>
		Public Property [ResidualValue] As Double?
		'''<![CDATA[Asset Depreciation StartDate]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Identifies the status of the Asset. (see AssetStatus table to see the possibilities)]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Reference to Transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TransactionEntryID] As Guid?
		'''<![CDATA[Entry number of transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TransactionEntryNo] As Int32?
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AssetGroup]
		'''<![CDATA[Code of the asset group]]>
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
		'''<![CDATA[Default depreciation method of the assets in this asset group]]>
		Public Property [DepreciationMethod] As Guid?
		'''<![CDATA[Code of the depreciation method]]>
		Public Property [DepreciationMethodCode] As String
		'''<![CDATA[Description of the depreciation method]]>
		Public Property [DepreciationMethodDescription] As String
		'''<![CDATA[Description of the asset group]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[GLAccount for the assets]]>
		Public Property [GLAccountAssets] As Guid?
		'''<![CDATA[Code of the GLAccount for the assets]]>
		Public Property [GLAccountAssetsCode] As String
		'''<![CDATA[Description of the GLAccount for the assets]]>
		Public Property [GLAccountAssetsDescription] As String
		'''<![CDATA[GLAccount for depreciation (Balance sheet)]]>
		Public Property [GLAccountDepreciationBS] As Guid?
		'''<![CDATA[Code of the GLAccount for depreciation (Balance sheet)]]>
		Public Property [GLAccountDepreciationBSCode] As String
		'''<![CDATA[Description of the GLAccount for depreciation (Balance sheet)]]>
		Public Property [GLAccountDepreciationBSDescription] As String
		'''<![CDATA[GLAccount for depreciation (Profit & Loss)]]>
		Public Property [GLAccountDepreciationPL] As Guid?
		'''<![CDATA[Code of the GLAccount for depreciation (Profit & Loss)]]>
		Public Property [GLAccountDepreciationPLCode] As String
		'''<![CDATA[Description of the GLAccount for depreciation (Profit & Loss)]]>
		Public Property [GLAccountDepreciationPLDescription] As String
		'''<![CDATA[GLAccount for revaluation (Balance sheet)]]>
		Public Property [GLAccountRevaluationBS] As Guid?
		'''<![CDATA[Code of the GLAccount for revaluation (Balance sheet)]]>
		Public Property [GLAccountRevaluationBSCode] As String
		'''<![CDATA[Description of the GLAccount for revaluation (Balance sheet)]]>
		Public Property [GLAccountRevaluationBSDescription] As String
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
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [DepreciationMethod]
		'''<![CDATA[When the method is fixed amount, this is the periodic depreciation amount]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Code of the depreciation method]]>
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
		'''<![CDATA[Describes the periodic interval]]>
		Public Property [DepreciationInterval] As String
		'''<![CDATA[Description of the method]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates the maximum value when using depreciation type degressive to linear]]>
		Public Property [MaxPercentage] As Double?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Degressive percentage for methods: 10 - Degressive to linear, 11 - Degressive (fixed perc. of book value), 12 - Degressive to linear (Belgium & Luxembourg only). And interest percentage for method: 40 - Normal annuity method. On import: Can not be modified if depreciation method is already linked to an asset. For Belgium & Luxembourg the degressive percentage is calculated as double of the linear percentage]]>
		Public Property [Percentage] As Double?
		'''<![CDATA[Linear percentage for methods: 10 - Degressive to linear, 3 - Linear depreciation (Belgium & Luxembourg only), 12 - Degressive to linear (Belgium & Luxembourg only). On import: Can not be modified if depreciation method is already linked to an asset]]>
		Public Property [Percentage2] As Double?
		'''<![CDATA[The total number of periods for the depreciation method. Used in combination with depreciation interval: only used when interval is periodic]]>
		Public Property [Periods] As Int16?
		'''<![CDATA[The actual type of deprecation, such as lineair or degressive. The periodic amounts are based on this type, in combination with other fields, such as the interval and the periods]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Determines the total number of years for the depreciation method. Used in combination with depreciation interval: only used when interval is yearly]]>
		Public Property [Years] As Int16?
	End Class

End Namespace