' Last generated on 2017-05-05 12:58:34Z

Namespace Inventory

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [BatchNumber]
		'''<![CDATA[Available quantity of this batch number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AvailableQuantity] As Double?
		'''<![CDATA[Human readable batch number]]>
		Public Property [BatchNumber] As String
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
		'''<![CDATA[Expiry date of effective period for batch number]]>
		Public Property [ExpiryDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Boolean value indicating whether or not the batch number is blocked]]>
		Public Property [IsBlocked] As Byte?
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
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
		'''<![CDATA[Remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[Total quantity available per location]]>
		Public Property [StorageLocations] As IEnumerable(Of Models.Inventory.BatchQuantitiesPerLocation)
		'''<![CDATA[Total quantity available per warehouse]]>
		Public Property [Warehouses] As IEnumerable(Of Models.Inventory.BatchQuantitiesPerWarehouse)
	End Class

	<SupportedActionsSDK(False, False, False, False)>
	<DataServiceKey("BatchNumberId")>
	Public Class [BatchQuantitiesPerLocation]
		Public Property [AvailableQuantity] As Double
		Public Property [BatchNumberId] As Guid
		Public Property [StorageLocation] As Guid?
		Public Property [StorageLocationCode] As String
		Public Property [StorageLocationDescription] As String
		Public Property [Warehouse] As Guid?
		Public Property [WarehouseCode] As String
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, False, False, False)>
	<DataServiceKey("BatchNumberId")>
	Public Class [BatchQuantitiesPerWarehouse]
		Public Property [AvailableQuantity] As Double
		Public Property [BatchNumberId] As Guid
		Public Property [Warehouse] As Guid?
		Public Property [WarehouseCode] As String
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ItemWarehous]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Quantity that is currently on stock, sales/purchase orders excluded]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CurrentStock] As Double?
		'''<![CDATA[This is a default storage location]]>
		Public Property [DefaultStorageLocation] As Guid?
		'''<![CDATA[Default storage location's code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationCode] As String
		'''<![CDATA[Default storage location's description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationDescription] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Item ID]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemIsFractionAllowedItem] As Boolean?
		'''<![CDATA[The standard unit code of this item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnit] As String
		'''<![CDATA[Description of item's unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnitDescription] As String
		'''<![CDATA[Maximum number of stock could enter warehouse]]>
		Public Property [MaximumStock] As Double?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[The quantity still open to be received based on i.e. purchase orders and assembly orders.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedStockIn] As Double?
		'''<![CDATA[The quantity still open to be delivered based on i.e. sales orders and assembly orders.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedStockOut] As Double?
		'''<![CDATA[URL of the stock planning details of this record]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningDetailsUrl] As String
		'''<![CDATA[The quantity of stock projected given all planned future stock changes]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectedStock] As Double?
		'''<![CDATA[Reorder point when stock depletes]]>
		Public Property [ReorderPoint] As Double?
		'''<![CDATA[The quantity in a back to back order process which is already received from the purchase order, but not yet delivered for the sales order.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReservedStock] As Double?
		'''<![CDATA[Safety stock]]>
		Public Property [SafetyStock] As Double?
		'''<![CDATA[URL pointing to details of which storage locations this ItemWarehouse's stock is located]]>
		Public Property [StorageLocationUrl] As String
		'''<![CDATA[Warehouse ID]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Item")>
	Public Class [ItemWarehousePlanningDetail]
		'''<![CDATA[ID of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid
		'''<![CDATA[Code of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Date which quantity in stock is planned to change]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedDate] As DateTime
		'''<![CDATA[Amount by which quantity in stock is planned to change]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlannedQuantity] As Double
		'''<![CDATA[Human readable description of the PlanningSource (translated to user's language) - Examples: Purchase Order, Sales Order, Shop Order, etc.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceDescription] As String
		'''<![CDATA[ID of the PlanningSource]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceID] As Guid?
		'''<![CDATA[Line number of the PlanningSource if the PlanningSourceType supports line numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceLineNumber] As Int32?
		'''<![CDATA[Human readable number of the PlanningSource - Examples: Shop order number '201600001' or Sales order number '2016020001']]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceNumber] As Int32?
		'''<![CDATA[REST API URL of this specific PlanningSource and PlanningSourceID (Assembly orders and warehouse transfers not supported over REST)]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningSourceUrl] As String
		'''<![CDATA[Type of the PlanningSource - 120=GoodsDelivery, 124=WarehouseTransferDelivery, 130=GoodsReceipt, 134=WarehouseTransferReceipt, 140=ShopOrderStockReceipt, 147=ShopOrderByProductReceipt, 150=ShopOrderRequirement, 160=AssemblyOrderReceipt, 165=AssemblyOrderIssue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningType] As Int32?
		'''<![CDATA[Human readable description of the PlanningSourceType (translated to user's language) - Examples: 'Shop order stock receipt' or 'Goods delivery']]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PlanningTypeDescription] As String
		'''<![CDATA[ID of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid
		'''<![CDATA[Code of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Item")>
	Public Class [ItemWarehouseStorageLocation]
		'''<![CDATA[Does the item allow partial quantities (1.75 meters)]]>
		Public Property [IsFractionAllowedItem] As Byte
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid
		'''<![CDATA[Code of the item of this stock quantity]]>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of the item of this stock quantity]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[Unit of the item]]>
		Public Property [ItemUnit] As String
		'''<![CDATA[Unit description of the item]]>
		Public Property [ItemUnitDescription] As String
		'''<![CDATA[Number of items in stock]]>
		Public Property [Stock] As Double?
		'''<![CDATA[Storage location of this stock]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of the storage location of this stock quantity]]>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of the storage location of this stock quantity]]>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[ID of Warehouse]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of the warehouse of this stock quantity]]>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of the warehouse of this stock quantity]]>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("StockCountID")>
	Public Class [ProcessStockCount]
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Contains the error message if an error occurred during the processing of the stock count.]]>
		Public Property [ErrorMessage] As String
		'''<![CDATA[Primary key]]>
		Public Property [StockCountID] As Guid
		'''<![CDATA[Contains information if the stock count was successfully processed.]]>
		Public Property [SuccessMessage] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [SerialNumber]
		'''<![CDATA[Availability of this serial number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Available] As Byte?
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
		'''<![CDATA[End date of effective period for serial number]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Boolean value indicating whether or not the serial number is blocked]]>
		Public Property [IsBlocked] As Byte?
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
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
		'''<![CDATA[Remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[Human readable serial number]]>
		Public Property [SerialNumber] As String
		'''<![CDATA[Start date of effective period for serial number]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[ID of storage location where serial number is available]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location where serial number is available]]>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location where serial number is available]]>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[ID of warehouse where serial number is available]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse where serial number is available]]>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse where serial number is available]]>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [StockBatchNumber]
		'''<![CDATA[Human readable batch number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BatchNumber] As String
		'''<![CDATA[Batch number ID]]>
		Public Property [BatchNumberID] As Guid?
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
		'''<![CDATA[ID representing a group of batch numbers being reserved for use in a subsequent stock transaction]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[End date of effective period for batch number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Boolean value indicating whether or not the batch number is blocked]]>
		Public Property [IsBlocked] As Byte?
		'''<![CDATA[Boolean value indicating if this batch number is being reserved]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsDraft] As Byte?
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
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
		'''<![CDATA[Quantity of this batch number entering or leaving inventory]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[ID of stock count entry]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockCountLine] As Guid?
		'''<![CDATA[ID of the stock transaction in which this batch number was used]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionID] As Guid?
		'''<![CDATA[Type of stock transaction associated with this batch number.<br><br>Available values:<br>10 = Opening balance<br>120 = Goods delivery<br>121 = Sales return<br>122 = Stock out (Drop shipment)<br>123 = Stock in (Drop shipment return)<br>124 = Warehouse transfer delivery<br>125 = Location Transfer Delivery<br>130 = Goods receipt<br>131 = Purchase return<br>132 = Stock in (Drop shipment)<br>133 = Stock out (Drop shipment return)<br>134 = Warehouse transfer receipt<br>135 = Location Transfer Receipt<br>140 = Shop order stock receipt<br>141 = Shop order stock reversal<br>147 = Shop order by-product receipt<br>148 = Shop order by-product reversal<br>150 = Requirement issue<br>151 = Requirement reversal<br>155 = Subcontract issue<br>156 = Subcontract return<br>160 = Receipt (Assembly)<br>161 = Return receipt (Disassembly)<br>165 = Issue (Assembly)<br>166 = Return issue (Disassembly)<br>180 = Stock revaluation<br>181 = Financial revaluation<br>195 = Stock count<br>196 = Adjust stock - out<br>197 = Adjust stock - in<br>]]>
		Public Property [StockTransactionType] As Int32?
		'''<![CDATA[Storage location which this batch number is entering or leaving]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of the storage location which this batch number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of the storage location which this batch number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Warehouse which this batch number is entering or leaving]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of the warehouse which this batch number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of the warehouse which this batch number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("StockCountID")>
	Public Class [StockCount]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the stock count]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Entry number of the stock transactions]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Offset GL account of inventory]]>
		Public Property [OffsetGLInventory] As Guid?
		'''<![CDATA[GLAccount code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetGLInventoryCode] As String
		'''<![CDATA[GLAccount description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OffsetGLInventoryDescription] As String
		'''<![CDATA[Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16?
		'''<![CDATA[Stock count status: 12-Draft, 21-Processed]]>
		Public Property [Status] As Int16?
		'''<![CDATA[Stock count date]]>
		Public Property [StockCountDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [StockCountID] As Guid
		'''<![CDATA[Collection of stock count lines]]>
		Public Property [StockCountLines] As IEnumerable(Of Models.Inventory.StockCountLine)
		'''<![CDATA[Human readable id of the stock count]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockCountNumber] As Int32?
		'''<![CDATA[Warehouse]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [StockCountLine]
		'''<![CDATA[The collection of batch numbers that belong to the items included in this stock count]]>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<![CDATA[Cost price of the item that is used to create the stock count]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPrice] As Double?
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
		'''<![CDATA[Reference to the item for which the stock is counted]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Current standard/actual item cost price]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCostPrice] As Double?
		'''<![CDATA[Description of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDivisable] As Boolean?
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
		'''<![CDATA[The difference between the current quantity in stock and the new quantity in stock. For example specify -1 for this field to correct the quantity if one item in stock is broken.]]>
		Public Property [QuantityDifference] As Double?
		'''<![CDATA[The current quantity available in stock]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityInStock] As Double?
		'''<![CDATA[The new quantity in stock. Use this field to correct the quantity when the items in stock are physically counted.]]>
		Public Property [QuantityNew] As Double?
		'''<![CDATA[The collection of serial numbers that belong to the items included in this stock count]]>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<![CDATA[Identifies the stock count. All the lines of a stock count have the same StockCountID]]>
		Public Property [StockCountID] As Guid?
		'''<![CDATA[Stock item's unit description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockKeepingUnit] As String
		'''<![CDATA[Storage location]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Storage location code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Storage location description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [StockSerialNumber]
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
		'''<![CDATA[ID representing a group of serial numbers being reserved for use in a subsequent stock transaction]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[End date of effective period for serial number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Boolean value indicating whether or not the serial number is blocked]]>
		Public Property [IsBlocked] As Byte?
		'''<![CDATA[Boolean value indicating if this serial number is being reserved]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsDraft] As Byte?
		'''<![CDATA[Item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
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
		'''<![CDATA[Remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[Human readable serial number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SerialNumber] As String
		'''<![CDATA[Serial number ID]]>
		Public Property [SerialNumberID] As Guid?
		'''<![CDATA[Start date of effective period for serial number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[ID of stock count entry]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockCountLine] As Guid?
		'''<![CDATA[ID of the stock transaction in which this serial number was used]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionID] As Guid?
		'''<![CDATA[Type of stock transaction associated with this serial number.<br><br>Available values:<br>10 = Opening balance<br>120 = Goods delivery<br>121 = Sales return<br>122 = Stock out (Drop shipment)<br>123 = Stock in (Drop shipment return)<br>124 = Warehouse transfer delivery<br>125 = Location Transfer Delivery<br>130 = Goods receipt<br>131 = Purchase return<br>132 = Stock in (Drop shipment)<br>133 = Stock out (Drop shipment return)<br>134 = Warehouse transfer receipt<br>135 = Location Transfer Receipt<br>140 = Shop order stock receipt<br>141 = Shop order stock reversal<br>147 = Shop order by-product receipt<br>148 = Shop order by-product reversal<br>150 = Requirement issue<br>151 = Requirement reversal<br>155 = Subcontract issue<br>156 = Subcontract return<br>160 = Receipt (Assembly)<br>161 = Return receipt (Disassembly)<br>165 = Issue (Assembly)<br>166 = Return issue (Disassembly)<br>180 = Stock revaluation<br>181 = Financial revaluation<br>195 = Stock count<br>196 = Adjust stock - out<br>197 = Adjust stock - in<br>]]>
		Public Property [StockTransactionType] As Int32?
		'''<![CDATA[Storage location which this serial number is entering or leaving]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of the storage location which this serial number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of the storage location which this serial number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Warehouse which this serial number is entering or leaving]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of the warehouse which this serial number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of the warehouse which this serial number is entering or leaving]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [StorageLocation]
		'''<![CDATA[Code of the storage location]]>
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
		'''<![CDATA[Description of the storage location]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the main storage location. There's always exactly one main storage location per warehouse]]>
		Public Property [Main] As Byte?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Warehouse ID]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Warehouse Code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Warehouse]
		'''<![CDATA[Code of the warehouse]]>
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
		'''<![CDATA[The default storage location of this warehouse. Warehouses can have a default storage location in packages Manufacturing Premium or Wholesale Premium]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocation] As Guid?
		'''<![CDATA[Default storage location's code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationCode] As String
		'''<![CDATA[Default storage location's description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DefaultStorageLocationDescription] As String
		'''<![CDATA[The description of the warehouse]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Email address]]>
		Public Property [EMail] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the main warehouse. There's always exactly one main warehouse per administration]]>
		Public Property [Main] As Byte
		'''<![CDATA[User reponsible for the warehouse]]>
		Public Property [ManagerUser] As Guid?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Indicates if this warehouse is using storage locations. The storage locations will not be removed when when this is deactivated]]>
		Public Property [UseStorageLocations] As Byte
	End Class

End Namespace