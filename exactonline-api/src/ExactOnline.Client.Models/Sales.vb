' Last generated on 2017-05-05 12:58:35Z

Namespace Sales

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [PriceList]
		'''<![CDATA[Code to indicate the price list]]>
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
		'''<![CDATA[All prices in the price list are stored in this currency]]>
		Public Property [Currency] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Description of Division]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DivisionDescription] As String
		'''<![CDATA[Indicates the entity (Item, Item group, ..) on which this price list is based]]>
		Public Property [Entity] As Int16?
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
		'''<![CDATA[Explanation or extra information can be stored in the notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SalesPriceListDetail]
		'''<![CDATA[Customer account Id]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Customer account name]]>
		Public Property [AccountName] As String
		'''<![CDATA[Standard price]]>
		Public Property [BasePrice] As Guid?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency]]>
		Public Property [Currency] As String
		'''<![CDATA[Discount]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[End date]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Description of the item]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[ItemGroup]]>
		Public Property [ItemGroup] As Guid?
		'''<![CDATA[Default sales unit of the item]]>
		Public Property [ItemUnit] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[New price after discount]]>
		Public Property [NewPrice] As Double?
		'''<![CDATA[Number of the item per unit]]>
		Public Property [NumberOfItemsPerUnit] As Double?
		'''<![CDATA[Code of the PriceList]]>
		Public Property [PriceListCode] As String
		'''<![CDATA[Id of the PriceList]]>
		Public Property [PriceListId] As Guid?
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Start date]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[Unit]]>
		Public Property [Unit] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [ShippingMethod]
		'''<![CDATA[Active]]>
		Public Property [Active] As Boolean?
		'''<![CDATA[Code of the shipping method]]>
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
		'''<![CDATA[Description of shipping method]]>
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
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Shipping method rates URL]]>
		Public Property [ShippingRatesURL] As String
		'''<![CDATA[Tracking URL]]>
		Public Property [TrackingURL] As String
	End Class

End Namespace