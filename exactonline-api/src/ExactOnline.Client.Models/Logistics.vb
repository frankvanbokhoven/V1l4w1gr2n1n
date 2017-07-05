' Last generated on 2017-05-05 12:58:35Z

Namespace Logistics

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Item]
		'''<![CDATA[Barcode of the item (numeric string)]]>
		Public Property [Barcode] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 1]]>
		Public Property [Class_01] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 2]]>
		Public Property [Class_02] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 3]]>
		Public Property [Class_03] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 4]]>
		Public Property [Class_04] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 5]]>
		Public Property [Class_05] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 6]]>
		Public Property [Class_06] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 7]]>
		Public Property [Class_07] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 8]]>
		Public Property [Class_08] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 9]]>
		Public Property [Class_09] As String
		'''<![CDATA[Item class code referring to ItemClasses with ClassID 10]]>
		Public Property [Class_10] As String
		'''<![CDATA[Item code]]>
		Public Property [Code] As String
		'''<![CDATA[Copy remarks to sales lines]]>
		Public Property [CopyRemarks] As Byte
		'''<![CDATA[The currency of the current and proposed cost price]]>
		Public Property [CostPriceCurrency] As String
		'''<![CDATA[Proposed cost price]]>
		Public Property [CostPriceNew] As Double?
		'''<![CDATA[The current standard cost price]]>
		Public Property [CostPriceStandard] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the item]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Together with StartDate this determines if the item is active]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Extra description text, slightly longer than the regular description (255 instead of 60)]]>
		Public Property [ExtraDescription] As String
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
		'''<![CDATA[Free numeric field 1]]>
		Public Property [FreeNumberField_01] As Double?
		'''<![CDATA[Free numeric field 2]]>
		Public Property [FreeNumberField_02] As Double?
		'''<![CDATA[Free numeric field 3]]>
		Public Property [FreeNumberField_03] As Double?
		'''<![CDATA[Free numeric field 4]]>
		Public Property [FreeNumberField_04] As Double?
		'''<![CDATA[Free numeric field 5]]>
		Public Property [FreeNumberField_05] As Double?
		'''<![CDATA[Free numeric field 6]]>
		Public Property [FreeNumberField_06] As Double?
		'''<![CDATA[Free numeric field 7]]>
		Public Property [FreeNumberField_07] As Double?
		'''<![CDATA[Free numeric field 8]]>
		Public Property [FreeNumberField_08] As Double?
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
		'''<![CDATA[Free text field 6]]>
		Public Property [FreeTextField_06] As String
		'''<![CDATA[Free text field 7]]>
		Public Property [FreeTextField_07] As String
		'''<![CDATA[Free text field 8]]>
		Public Property [FreeTextField_08] As String
		'''<![CDATA[Free text field 9]]>
		Public Property [FreeTextField_09] As String
		'''<![CDATA[Free text field 10]]>
		Public Property [FreeTextField_10] As String
		'''<![CDATA[GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
		Public Property [GLCosts] As Guid?
		'''<![CDATA[Code of GL account for costs]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsCode] As String
		'''<![CDATA[Description of GLCosts]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsDescription] As String
		'''<![CDATA[GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
		Public Property [GLRevenue] As Guid?
		'''<![CDATA[Code of GLRevenue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueCode] As String
		'''<![CDATA[Description of GLRevenue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueDescription] As String
		'''<![CDATA[GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
		Public Property [GLStock] As Guid?
		'''<![CDATA[Code of GL account for stock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockCode] As String
		'''<![CDATA[Description of GLStock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockDescription] As String
		'''<![CDATA[Gross weight for international goods shipments]]>
		Public Property [GrossWeight] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if batches are used for this item]]>
		Public Property [IsBatchItem] As Byte
		'''<![CDATA[This property is obsolete. Use property 'IsBatchItem' instead.]]>
		Public Property [IsBatchNumberItem] As Byte
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
		Public Property [IsFractionAllowedItem] As Boolean?
		'''<![CDATA[Indicates that an Item is produced to Inventory, not purchased]]>
		Public Property [IsMakeItem] As Byte
		'''<![CDATA[Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package]]>
		Public Property [IsNewContract] As Byte
		'''<![CDATA[Is On demand Item]]>
		Public Property [IsOnDemandItem] As Byte
		'''<![CDATA[Indicates if the item is a package item. Can only be created in the hosting administration]]>
		Public Property [IsPackageItem] As Boolean?
		'''<![CDATA[Indicates if the item can be purchased]]>
		Public Property [IsPurchaseItem] As Boolean?
		'''<![CDATA[Indicated if the item is used in voucher functionality]]>
		Public Property [IsRegistrationCodeItem] As Byte
		'''<![CDATA[Indicates if the item can be sold]]>
		Public Property [IsSalesItem] As Boolean?
		'''<![CDATA[Indicates that serial numbers are used for this item]]>
		Public Property [IsSerialItem] As Boolean?
		'''<![CDATA[This property is obsolete. Use property 'IsSerialItem' instead.]]>
		Public Property [IsSerialNumberItem] As Boolean?
		'''<![CDATA[If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.]]>
		Public Property [IsStockItem] As Boolean?
		'''<![CDATA[Indicates if the item is provided by an outside supplier]]>
		Public Property [IsSubcontractedItem] As Boolean?
		'''<![CDATA[Indicates if tax needs to be calculated for this item]]>
		Public Property [IsTaxableItem] As Byte?
		'''<![CDATA[Indicates if the item is a time unit item (for example a labor hour item)]]>
		Public Property [IsTime] As Byte
		'''<![CDATA[Indicates if the item can be exported to a web shop]]>
		Public Property [IsWebshopItem] As Byte
		'''<![CDATA[GUID of Item group of the item]]>
		Public Property [ItemGroup] As Guid?
		'''<![CDATA[Code of ItemGroup]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemGroupCode] As String
		'''<![CDATA[Description of ItemGroup]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemGroupDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Net weight for international goods shipments]]>
		Public Property [NetWeight] As Double?
		'''<![CDATA[Net Weight unit for international goods shipment, only available in manufacturing packages]]>
		Public Property [NetWeightUnit] As String
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[File name of picture]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureName] As String
		'''<![CDATA[Url where thumbnail picture can be retrieved]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureThumbnailUrl] As String
		'''<![CDATA[Url where picture can be retrieved]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PictureUrl] As String
		'''<![CDATA[Code of SalesVat]]>
		Public Property [SalesVatCode] As String
		'''<![CDATA[Description of SalesVatCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesVatCodeDescription] As String
		'''<![CDATA[Search code of the item]]>
		Public Property [SearchCode] As String
		'''<![CDATA[Security level (0 - 100)]]>
		Public Property [SecurityLevel] As Int32?
		'''<![CDATA[Together with EndDate this determines if the item is active]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Quantity that is in stock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Stock] As Double?
		'''<![CDATA[The standard unit of this item]]>
		Public Property [Unit] As String
		'''<![CDATA[Description of Unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitType] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ItemGroup]
		'''<![CDATA[Code of the item group]]>
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
		'''<![CDATA[Description of the item group]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[GL account on which the costs of items of this group will be booked]]>
		Public Property [GLCosts] As Guid?
		'''<![CDATA[Code of GLCosts]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsCode] As String
		'''<![CDATA[Description of GLCosts]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLCostsDescription] As String
		'''<![CDATA[GL Purchase account for purchase invoicing according to (non-) perpetual inventory method]]>
		Public Property [GLPurchaseAccount] As Guid?
		'''<![CDATA[Code of GLPurchase]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchaseAccountCode] As String
		'''<![CDATA[Description of GLPurchaseAccount]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchaseAccountDescription] As String
		'''<![CDATA[GL account that will be used for the 'Standard cost price' valuation method to balance the difference between purchase price and cost price]]>
		Public Property [GLPurchasePriceDifference] As Guid?
		'''<![CDATA[Code of GLPurchasePriceDifference]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchasePriceDifferenceCode] As String
		'''<![CDATA[Description of GLPurchasePriceDifference]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLPurchasePriceDifferenceDescr] As String
		'''<![CDATA[GL account on which the revenue for items of this group will be booked]]>
		Public Property [GLRevenue] As Guid?
		'''<![CDATA[Code of GLRevenue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueCode] As String
		'''<![CDATA[Description of GLRevenue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLRevenueDescription] As String
		'''<![CDATA[GL account on which stock entries will be booked for items of this group]]>
		Public Property [GLStock] As Guid?
		'''<![CDATA[Code of GLStock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockCode] As String
		'''<![CDATA[Description of GLStock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockDescription] As String
		'''<![CDATA[GL stock variance account for perpetual inventory]]>
		Public Property [GLStockVariance] As Guid?
		'''<![CDATA[Code of GLStockVariance]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockVarianceCode] As String
		'''<![CDATA[Description of GLStockVariance]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLStockVarianceDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the default item group that will be assigned when a new item is created]]>
		Public Property [IsDefault] As Byte
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

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ItemVersion]
		'''<![CDATA[Batch Quantity of Item Version]]>
		Public Property [BatchQuantity] As Double?
		'''<![CDATA[Calculated Cost Price of Item Version]]>
		Public Property [CalculatedCostPrice] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the item version]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the default item version that will be assigned when a item is selected]]>
		Public Property [IsDefault] As Byte
		'''<![CDATA[Reference to Items table]]>
		Public Property [Item] As Guid
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Lead time of Item version]]>
		Public Property [LeadTime] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Line notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active & 40-Historic]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe]]>
		Public Property [Type] As Int16?
		'''<![CDATA[Description of Type]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TypeDescription] As String
		'''<![CDATA[Version Number]]>
		Public Property [VersionNumber] As Int32?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesItemPrice]
		'''<![CDATA[ID of the customer]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Name of the customer account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[The currency of the price]]>
		Public Property [Currency] As String
		'''<![CDATA[The default unit of the item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultItemUnit] As String
		'''<![CDATA[The description of the default item unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultItemUnitDescription] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Together with StartDate this determines whether the price is active]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item ID]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is 'gram' and the price unit is 'kilogram' then the value of this property is 1000.]]>
		Public Property [NumberOfItemsPerUnit] As Double?
		'''<![CDATA[The actual price of this sales item]]>
		Public Property [Price] As Double?
		'''<![CDATA[Minimum quantity to which the price is applicable]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Together with EndDate this determines whether the price is active]]>
		Public Property [StartDate] As DateTime
		'''<![CDATA[The unit code of the price]]>
		Public Property [Unit] As String
		'''<![CDATA[Description of the price unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [Unit]
		'''<![CDATA[Indicates whether a unit is in use]]>
		Public Property [Active] As Boolean?
		'''<![CDATA[Unique code for the unit]]>
		Public Property [Code] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates the main unit per division. Will be used when creating new item]]>
		Public Property [Main] As Byte?
		'''<![CDATA[If Type = 'T' (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second]]>
		Public Property [TimeUnit] As String
		'''<![CDATA[Type of unit. Type 'Time' is especially important for contracts.]]>
		Public Property [Type] As String
	End Class

End Namespace