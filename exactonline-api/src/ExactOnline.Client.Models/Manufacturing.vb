' Last generated on 2017-05-05 12:58:35Z

Namespace Manufacturing

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [ByProductReceipt]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date this by-product finish was created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Serial or batch numbers are reserved prior to a POST to ByProductReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[Indicates if this ByProductReceipt has a quantity eligible to be reversed via ByProductReversals]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<![CDATA[Boolean indicating if this by-product finish was the result of shop order backflushing]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<![CDATA[Does the ByProductReceipt's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the ByProductReceipt's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[ID of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Quantity of this by-product finish]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[ID of shop order, which produced the by-product]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[ID of the shop order material plan for this by-product]]>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<![CDATA[Number of shop order, which produced the by-product]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of stock transaction related to this by-product finish]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<![CDATA[ID of storage location finished to]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this by-product finish]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [ByProductReversal]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date of this reversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<![CDATA[Does the ByProductReversal's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the ByProductReversal's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of by-product item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Notes associated with this reversal]]>
		Public Property [Note] As String
		'''<![CDATA[ID of the original stock transaction, which was reversed]]>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<![CDATA[Quantity reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<![CDATA[ID of stock transaction related to this ByProductReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<![CDATA[Shop order being reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[ID of shop order material plan]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<![CDATA[Number of shop order being reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this ByProductReversal]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [MaterialIssue]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date this material issue was created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Serial or batch numbers are reserved prior to a POST to MaterialIssues. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[Indicates if this MaterialIssue has a quantity eligible to be reversed via MaterialReversals]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<![CDATA[Boolean indicating if this material issue was the result of shop order backflushing]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Byte?
		'''<![CDATA[Does the material issue's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the material issue's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Boolean indicating if this material issue was an issue to a parent shop order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsIssueFromChild] As Byte?
		'''<![CDATA[Does the material issue's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Notes logged with this material issue]]>
		Public Property [Note] As String
		'''<![CDATA[Quantity of this material issue]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[If this transaction was part of a SubOrderReceipt, this ID is the related ShopOrderReceipt.StockTransactionID.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RelatedStockTransaction] As Guid?
		'''<![CDATA[ID of shop order issued to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[ID of shop order material plan]]>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<![CDATA[Number of shop order issued to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of stock transaction related to this material issue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<![CDATA[ID of storage location issued from]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this material issue]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [MaterialReversal]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date this reversal was created]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBackflush] As Boolean
		'''<![CDATA[Does the issue reversal's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the material reversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the issue reversal's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of item issued]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Notes logged with this reversal]]>
		Public Property [Note] As String
		'''<![CDATA[ID of the original stock transaction, which was reversed]]>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<![CDATA[Quantity of this reversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<![CDATA[ID of stock transaction related to this material issue]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<![CDATA[ID of shop order reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[ID of shop order material plan]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderMaterialPlan] As Guid?
		'''<![CDATA[Number of shop order reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of storage location reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this reversal]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Operation]
		'''<![CDATA[Code of the operation]]>
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
		'''<![CDATA[Description of the operation]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Indicates if the operation has suppliers associated with it]]>
		Public Property [HasSuppliers] As Byte?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to Items table]]>
		Public Property [Item] As Guid?
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
		'''<![CDATA[Extra remarks]]>
		Public Property [Notes] As String
		'''<![CDATA[Search code for the operation]]>
		Public Property [Searchcode] As String
		'''<![CDATA[Status of the operation]]>
		Public Property [Status] As Int32?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [OperationResource]
		'''<![CDATA[Reference to Accounts]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Attended percentage]]>
		Public Property [AttendedPercentage] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Reference to Currencies]]>
		Public Property [Currency] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Efficiency percentage]]>
		Public Property [EfficiencyPercentage] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the primary operation of the workcenter]]>
		Public Property [IsPrimary] As Byte?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Reference to Operations]]>
		Public Property [Operation] As Guid?
		'''<![CDATA[Description of Operation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationDescription] As String
		'''<![CDATA[Lead days from purchase]]>
		Public Property [PurchaseLeadDays] As Int32?
		'''<![CDATA[Unit of purchased item from supplier]]>
		Public Property [PurchaseUnit] As String
		'''<![CDATA[VAT code used for purchased item from supplier]]>
		Public Property [PurchaseVATCode] As String
		'''<![CDATA[Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours]]>
		Public Property [Run] As Double?
		'''<![CDATA[Reference to OperationRunMethods]]>
		Public Property [RunMethod] As Int32?
		'''<![CDATA[Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours]]>
		Public Property [Setup] As Double?
		'''<![CDATA[Reference to TimeUnits]]>
		Public Property [SetupUnit] As String
		'''<![CDATA[Reference to RoutingStepTypes]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Reference to Workcenter]]>
		Public Property [Workcenter] As Guid?
		'''<![CDATA[Description of Workcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ProductionArea]
		'''<![CDATA[Code of the production area group]]>
		Public Property [Code] As String
		'''<![CDATA[Reference to Cost center]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Reference to Cost unit]]>
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
		'''<![CDATA[Description of the production area]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if this is the default production area. This will be used when creating a new production area]]>
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
		'''<![CDATA[Production area notes]]>
		Public Property [Notes] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrder]
		'''<![CDATA[URL to CAD Drawing Specified on Manufacturing Bill of Material]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CADDrawingURL] As String
		'''<![CDATA[The cost center linked to the shop order]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[The cost unit linked to the shop order]]>
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
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Date on which the shop order was placed]]>
		Public Property [EntryDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Does the material plan's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the material plan's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte
		'''<![CDATA[Indicator that Shop order is in planning]]>
		Public Property [IsInPlanning] As Byte
		'''<![CDATA[Indicator if the Shop order is on hold]]>
		Public Property [IsOnHold] As Byte
		'''<![CDATA[Indicator that the Shop order has been released to production]]>
		Public Property [IsReleased] As Byte
		'''<![CDATA[Does the material plan's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte
		'''<![CDATA[Reference to the item]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of the item created by this shop order]]>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of the item created by this shop order]]>
		Public Property [ItemDescription] As String
		'''<![CDATA[URL of the item created by this shop order]]>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Reference to ItemVersion]]>
		Public Property [ItemVersion] As Guid?
		'''<![CDATA[Description of Item Version]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemVersionDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes - only viewed internally]]>
		Public Property [Notes] As String
		'''<![CDATA[Planned end date of this shop order]]>
		Public Property [PlannedDate] As DateTime?
		'''<![CDATA[Planned quantity]]>
		Public Property [PlannedQuantity] As Double?
		'''<![CDATA[Planned start date of this shop order]]>
		Public Property [PlannedStartDate] As DateTime?
		'''<![CDATA[Produced quantity]]>
		Public Property [ProducedQuantity] As Double?
		'''<![CDATA[Production lead days]]>
		Public Property [ProductionLeadDays] As Int32
		'''<![CDATA[Reference to Project]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Quantity ready to ship]]>
		Public Property [ReadyToShipQuantity] As Double?
		'''<![CDATA[Number of sales orders linked to this shop order]]>
		Public Property [SalesOrderLineCount] As Int32
		'''<![CDATA[Collection of Sales order lines]]>
		Public Property [SalesOrderLines] As IEnumerable(Of Models.SalesOrder.SalesOrderLine)
		'''<![CDATA[Number of shop order by-product plans for this shop order]]>
		Public Property [ShopOrderByProductPlanCount] As Int32
		'''<![CDATA[Shop order main]]>
		Public Property [ShopOrderMain] As Guid?
		'''<![CDATA[Shop order main number]]>
		Public Property [ShopOrderMainNumber] As Int32?
		'''<![CDATA[Number of shop order material plans for this shop order]]>
		Public Property [ShopOrderMaterialPlanCount] As Int32
		'''<![CDATA[Collection of Shop order Material plans]]>
		Public Property [ShopOrderMaterialPlans] As IEnumerable(Of Models.Manufacturing.ShopOrderMaterialPlan)
		'''<![CDATA[Unique number to indentify the shop order]]>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[Unique number to indentify the shop order (as a string to allow OData filtering, e.g. $filter=substringof('123',ShopOrderNumberString) eq true]]>
		Public Property [ShopOrderNumberString] As String
		'''<![CDATA[Shop order parent]]>
		Public Property [ShopOrderParent] As Guid?
		'''<![CDATA[Shop order parent number]]>
		Public Property [ShopOrderParentNumber] As Int32?
		'''<![CDATA[Number of shop order routing step plans for this shop order]]>
		Public Property [ShopOrderRoutingStepPlanCount] As Int32
		'''<![CDATA[Collection of Shop order Routing step plans]]>
		Public Property [ShopOrderRoutingStepPlans] As IEnumerable(Of Models.Manufacturing.ShopOrderRoutingStepPlan)
		'''<![CDATA[Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed]]>
		Public Property [Status] As Int32?
		'''<![CDATA[The count of material lines of this shop order, which have been linked to a sub order]]>
		Public Property [SubShopOrderCount] As Int32
		'''<![CDATA[Overall status of the line: 9040 Regular]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Unit of the item created by this shop order]]>
		Public Property [Unit] As String
		'''<![CDATA[Unit description of the unit of the item created by this shop order]]>
		Public Property [UnitDescription] As String
		'''<![CDATA[Reference to the Warehouse associated with the Shop order]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Your reference (of the customer)]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrderMaterialPlan]
		'''<![CDATA[Indicates if this is a backflush step]]>
		Public Property [Backflush] As Byte?
		'''<![CDATA[Calculator type]]>
		Public Property [CalculatorType] As Int32?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the material]]>
		Public Property [Description] As String
		'''<![CDATA[Detail drawing reference]]>
		Public Property [DetailDrawing] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to Items table]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item Code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[URL of the material item's picture]]>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Line number]]>
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
		'''<![CDATA[Line notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Planned amount in the currency of the transaction]]>
		Public Property [PlannedAmountFC] As Double?
		'''<![CDATA[Date that the material is required.]]>
		Public Property [PlannedDate] As DateTime?
		'''<![CDATA[Planned price of the material]]>
		Public Property [PlannedPriceFC] As Double?
		'''<![CDATA[Intended quantity]]>
		Public Property [PlannedQuantity] As Double?
		'''<![CDATA[Intended quantity unit factor]]>
		Public Property [PlannedQuantityFactor] As Double?
		'''<![CDATA[Reference to ShopOrders table]]>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Line status]]>
		Public Property [Status] As Int32?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Type]]>
		Public Property [Type] As Int32?
		'''<![CDATA[Unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("StockTransactionId")>
	Public Class [ShopOrderReceipt]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date of this ShopOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Serial or batch numbers are reserved prior to a POST to ShopOrderReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[Indicates if this ShopOrderReceipt has a quantity eligible to be reversed via ShopOrderReversals]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<![CDATA[Does the shop order receipt's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the shop order receipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Boolean indicating if this ShopOrderReceipt was part of an SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsIssueToParent] As Boolean
		'''<![CDATA[Does the shop order receipt's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of shop order item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Parent shop order if this ShopOrderReceipt is part of a SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<![CDATA[Parent shop order number if this ShopOrderReceipt is part of a SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<![CDATA[Quantity of this ShopOrderReceipt]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[If this transaction was part of a SubOrderReceipt, this ID is the related MaterialIssue.StockTransactionID.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RelatedStockTransaction] As Guid?
		'''<![CDATA[Shop order finished]]>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Number of shop order finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of stock transaction of this ShopOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StockTransactionId] As Guid
		'''<![CDATA[ID of storage location finished to]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this ShopOrderReceipt]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of item finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of item finished]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse finished to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ReversalStockTransactionId")>
	Public Class [ShopOrderReversal]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Date of this reversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Does the ShopOrderReversal's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the ShopOrderReversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the ShopOrderReversal's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of shop order item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[Notes associated with this reversal]]>
		Public Property [Note] As String
		'''<![CDATA[ID of the original stock transaction, which was reversed]]>
		Public Property [OriginalStockTransactionId] As Guid?
		'''<![CDATA[Quantity reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<![CDATA[ID of stock transaction related to this ShopOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReversalStockTransactionId] As Guid
		'''<![CDATA[Shop order being reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Number of shop order being reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderNumber] As Int32?
		'''<![CDATA[ID of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Code of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Description of storage location reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Effective date of this ShopOrderReversal]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [ShopOrderRoutingStepPlan]
		'''<![CDATA[Reference to Account providing the Outsourced item]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Account number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountNumber] As String
		'''<![CDATA[Attended Percentage]]>
		Public Property [AttendedPercentage] As Double?
		'''<![CDATA[Indicates if this is a backflush step]]>
		Public Property [Backflush] As Byte?
		'''<![CDATA[Total cost / Shop order planned quantity]]>
		Public Property [CostPerItem] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the operation]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Efficiency Percentage]]>
		Public Property [EfficiencyPercentage] As Double?
		'''<![CDATA[Conversion factor type between Shop order Item and Subcontract purchase Unit]]>
		Public Property [FactorType] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Sequential order of the operation]]>
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
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to Operations]]>
		Public Property [Operation] As Guid?
		'''<![CDATA[Code of the routing step operation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationCode] As String
		'''<![CDATA[Description of the operation step]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OperationDescription] As String
		'''<![CDATA[Reference to OperationResources]]>
		Public Property [OperationResource] As Guid?
		'''<![CDATA[Planned end date]]>
		Public Property [PlannedEndDate] As DateTime?
		'''<![CDATA[Planned run hours]]>
		Public Property [PlannedRunHours] As Double?
		'''<![CDATA[Planned setup hours]]>
		Public Property [PlannedSetupHours] As Double?
		'''<![CDATA[Planned start date]]>
		Public Property [PlannedStartDate] As DateTime?
		'''<![CDATA[Setup hours + Run hours]]>
		Public Property [PlannedTotalHours] As Double?
		'''<![CDATA[Reference to Units]]>
		Public Property [PurchaseUnit] As String
		'''<![CDATA[Purchase Unit Factor]]>
		Public Property [PurchaseUnitFactor] As Double?
		'''<![CDATA[Purchase Unit Price in the currency of the transaction]]>
		Public Property [PurchaseUnitPriceFC] As Double?
		'''<![CDATA[Purchase unit quantity of the plan]]>
		Public Property [PurchaseUnitQuantity] As Double?
		'''<![CDATA[Reference to RoutingStepTypes]]>
		Public Property [RoutingStepType] As Int32?
		'''<![CDATA[Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours]]>
		Public Property [Run] As Double?
		'''<![CDATA[Reference to OperationMethod]]>
		Public Property [RunMethod] As Int32?
		'''<![CDATA[Description of RunMethod]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [RunMethodDescription] As String
		'''<![CDATA[Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours]]>
		Public Property [Setup] As Double?
		'''<![CDATA[Reference to TimeUnits]]>
		Public Property [SetupUnit] As String
		'''<![CDATA[Reference to Shop orders]]>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Reference to OperationStatus]]>
		Public Property [Status] As Int32?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Subcontracted lead days]]>
		Public Property [SubcontractedLeadDays] As Int32?
		'''<![CDATA[Collection of TimeTransactions]]>
		Public Property [TimeTransactions] As IEnumerable(Of Models.Manufacturing.TimeTransaction)
		'''<![CDATA[Total cost of the routing line]]>
		Public Property [TotalCostDC] As Double?
		'''<![CDATA[Reference to Workcenters]]>
		Public Property [Workcenter] As Guid?
		'''<![CDATA[Workcenter code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterCode] As String
		'''<![CDATA[Workcenter description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WorkcenterDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ShopOrderReceiptStockTransactionId")>
	Public Class [SubOrderReceipt]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Creation date of this SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Serial or batch numbers are reserved prior to a POST to SubOrderReceipt. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.]]>
		Public Property [DraftStockTransactionID] As Guid?
		'''<![CDATA[Indicates if this SubOrderReceipt has a quantity eligible to be reversed via SubOrderReversals]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [HasReversibleQuantity] As Boolean
		'''<![CDATA[Does the SubOrderReceipt's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the SubOrderReceipt's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item of this SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of this SubOrderReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of this SubOrderReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of shop order item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[MaterialIssue.StockTransactionId related to this SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [MaterialIssueStockTransactionId] As Guid?
		'''<![CDATA[Shop order issued to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<![CDATA[Shop order material plan issued to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderMaterialPlan] As Guid?
		'''<![CDATA[Number of shop order issued to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<![CDATA[Quantity of this SubOrderReceipt]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderReceiptStockTransactionId] As Guid
		'''<![CDATA[Shop order issued from]]>
		Public Property [SubShopOrder] As Guid?
		'''<![CDATA[Number of shop order issued from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrderNumber] As Int32?
		'''<![CDATA[Effective date of this SubOrderReceipt]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of this SubOrderReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of this SubOrderReceipt's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse SubOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("MaterialReversalStockTransactionId")>
	Public Class [SubOrderReversal]
		'''<![CDATA[ID of creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedBy] As Guid?
		'''<![CDATA[Name of the creating user]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedByFullName] As String
		'''<![CDATA[Creation date of this SubOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatedDate] As DateTime?
		'''<![CDATA[Does the SubOrderReversal's item use batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsBatch] As Byte?
		'''<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsFractionAllowedItem] As Byte?
		'''<![CDATA[Does the SubOrderReversal's item use serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [IsSerial] As Byte?
		'''<![CDATA[Item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item reversed]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Picture url of shop order item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemPictureUrl] As String
		'''<![CDATA[MaterialReversal.StockTransactionId related to this SubOrderReversal's MaterialReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [MaterialReversalStockTransactionId] As Guid
		'''<![CDATA[Notes logged with this reversal]]>
		Public Property [Note] As String
		'''<![CDATA[MaterialIssue.StockTransactionId related to this SubOrderReceipt's original MaterialIssue]]>
		Public Property [OriginalMaterialIssueStockTransactionId] As Guid?
		'''<![CDATA[ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt's original ShopOrderReceipt]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OriginalShopOrderReceiptStockTransactionId] As Guid?
		'''<![CDATA[Shop order reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrder] As Guid?
		'''<![CDATA[Number of shop order reversed from]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ParentShopOrderNumber] As Int32?
		'''<![CDATA[Quantity of this SubOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<![CDATA[ShopOrderReversal.StockTransactionId related to this SubOrderReversal's ShopOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShopOrderReversalStockTransactionId] As Guid?
		'''<![CDATA[Shop order reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrder] As Guid?
		'''<![CDATA[Number of shop order reversed to]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SubShopOrderNumber] As Int32?
		'''<![CDATA[Effective date of this SubOrderReversal]]>
		Public Property [TransactionDate] As DateTime?
		'''<![CDATA[Unit of measurement abbreviation of this SubOrderReversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Unit of measurement of this SubOrderReversal's item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[ID of warehouse of this SubOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of warehouse of this SubOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of warehouse of this SubOrderReversal]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [TimeTransaction]
		'''<![CDATA[Manufacturing time type: Setup = 10, Run = 20]]>
		Public Property [Activity] As Int32?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Date]]>
		Public Property [Date] As DateTime?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Employee linked to the transaction]]>
		Public Property [Employee] As Guid?
		'''<![CDATA[Machine hours]]>
		Public Property [Hours] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Is the operation finished?]]>
		Public Property [IsOperationFinished] As Byte?
		'''<![CDATA[Labor Hours on the operation]]>
		Public Property [LaborHours] As Double?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes linked to the time transaction]]>
		Public Property [Notes] As String
		'''<![CDATA[Percentage of the operation that is complete]]>
		Public Property [PercentComplete] As Double?
		'''<![CDATA[Quantity]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[Routing step linked to the transaction]]>
		Public Property [RoutingStepPlan] As Guid?
		'''<![CDATA[Shop order linked to the transaction]]>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Status of the transaction: Draft = 1, Rejected = 2, Submitted = 10, Final = 20]]>
		Public Property [Status] As Int32?
		'''<![CDATA[Timed time transaction linked to the transaction]]>
		Public Property [TimedTimeTransaction] As Guid?
		'''<![CDATA[Workcenter linked to the transaction]]>
		Public Property [WorkCenter] As Guid?
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [Workcenter]
		'''<![CDATA[Code of the work center]]>
		Public Property [Code] As String
		'''<![CDATA[Reference to CostCenters]]>
		Public Property [Costcenter] As String
		'''<![CDATA[Description of Costcenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostcenterDescription] As String
		'''<![CDATA[Reference to CostUnits]]>
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
		'''<![CDATA[Description of the work center]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[General burden rate]]>
		Public Property [GeneralBurdenRate] As Double?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if labor burden is calculated as a percentage or amount]]>
		Public Property [IsLaborBurdenPercent] As Byte
		'''<![CDATA[Labor burden rate]]>
		Public Property [LaborBurdenRate] As Double?
		'''<![CDATA[Machine burden rate]]>
		Public Property [MachineBurdenRate] As Double?
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
		Public Property [Notes] As String
		'''<![CDATA[Area to which the work center belongs.]]>
		Public Property [ProductionArea] As Guid?
		'''<![CDATA[Run labor rate]]>
		Public Property [RunLaborRate] As Double?
		'''<![CDATA[Search code of the work center]]>
		Public Property [SearchCode] As String
		'''<![CDATA[Setup labor rate]]>
		Public Property [SetupLaborRate] As Double?
		'''<![CDATA[Reference to WorkcenterStatus]]>
		Public Property [Status] As Int32?
		'''<![CDATA[Reference to WorkcenterTypes]]>
		Public Property [Type] As Int32?
	End Class

End Namespace