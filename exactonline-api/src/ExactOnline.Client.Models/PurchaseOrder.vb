' Last generated on 2017-05-05 12:58:35Z

Namespace PurchaseOrder

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsReceipt]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the goods receipt]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[Document that is linked to the goods receipt]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Document subject]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Entry number of the resulting stock entry]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Collection of receipt lines]]>
		Public Property [GoodsReceiptLines] As IEnumerable(Of Models.PurchaseOrder.GoodsReceiptLine)
		'''<![CDATA[Primary key]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ID] As Guid
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Date of the goods receipt]]>
		Public Property [ReceiptDate] As DateTime?
		'''<![CDATA[Receipt number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceiptNumber] As Int32?
		'''<![CDATA[Receipt note]]>
		Public Property [Remarks] As String
		'''<![CDATA[Account ID of the supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Supplier] As Guid?
		'''<![CDATA[Supplier code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierCode] As String
		'''<![CDATA[ID of the contact person at the supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierContact] As Guid?
		'''<![CDATA[Name of the contact person at the supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierContactFullName] As String
		'''<![CDATA[Supplier name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<![CDATA[Warehouse ID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Warehouse code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of the warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<![CDATA[The purchase invoice number provided by the supplier]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsReceiptLine]
		'''<![CDATA[Collection of batch numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Goods receipt line description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32
		'''<![CDATA[All the lines of a goods receipt have the same GoodsReceiptID]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GoodsReceiptID] As Guid?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[ID of the received item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of the received item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Item description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Unit code of the purchase]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemUnitCode] As String
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32
		'''<![CDATA[ID of the storage location in the warehouse where the item is received]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Location] As Guid?
		'''<![CDATA[Code of the storage location in the warehouse where the item is received]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LocationCode] As String
		'''<![CDATA[Description of the storage location in the warehouse where the item is received]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LocationDescription] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime
		'''<![CDATA[User ID of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of the last modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Project] As Guid?
		'''<![CDATA[Project code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Project description]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Reference to purchase order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderID] As Guid
		'''<![CDATA[ID of the purchase order line that is received]]>
		Public Property [PurchaseOrderLineID] As Guid?
		'''<![CDATA[Order number of the purchase order that is received]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderNumber] As Int32
		'''<![CDATA[Quantity ordered]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityOrdered] As Double?
		'''<![CDATA[Quantity received]]>
		Public Property [QuantityReceived] As Double?
		'''<![CDATA[Collection of serial numbers]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<![CDATA[Supplier item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierItemCode] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("PurchaseOrderID")>
	Public Class [PurchaseOrder]
		'''<![CDATA[Total amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Total amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Currency code]]>
		Public Property [Currency] As String
		'''<![CDATA[Reference to account for delivery]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccount] As Guid?
		'''<![CDATA[Delivery account code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountCode] As String
		'''<![CDATA[Account name]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAccountName] As String
		'''<![CDATA[Reference to shipping address]]>
		Public Property [DeliveryAddress] As Guid?
		'''<![CDATA[Reference to contact for delivery]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContact] As Guid?
		'''<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContactPersonFullName] As String
		'''<![CDATA[Description of the purchase order]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Document that is manually linked to the purchase order]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Subject of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Shows if it is a drop shipment purchase order]]>
		Public Property [DropShipment] As Boolean?
		'''<![CDATA[Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.]]>
		Public Property [ExchangeRate] As Double?
		'''<![CDATA[Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceStatus] As Int32?
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[Name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Order date]]>
		Public Property [OrderDate] As DateTime?
		'''<![CDATA[Human readable id of the purchase order]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderStatus] As Int32?
		'''<![CDATA[The payment condition code used for due date and discount calculation]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of payment condition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [PurchaseOrderID] As Guid
		'''<![CDATA[Collection of lines]]>
		Public Property [PurchaseOrderLines] As IEnumerable(Of Models.PurchaseOrder.PurchaseOrderLine)
		'''<![CDATA[This field shows the date the goods are expected to be received.]]>
		Public Property [ReceiptDate] As DateTime?
		'''<![CDATA[Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceiptStatus] As Int32?
		'''<![CDATA[Include any relevant remarks regarding the purchase order.]]>
		Public Property [Remarks] As String
		'''<![CDATA[Reference to sales order when purchase order generated via back to back sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<![CDATA[Number of the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier's items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Source] As Int16?
		'''<![CDATA[Reference to supplier account]]>
		Public Property [Supplier] As Guid?
		'''<![CDATA[Code of supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierCode] As String
		'''<![CDATA[Contact of supplier]]>
		Public Property [SupplierContact] As Guid?
		'''<![CDATA[Contact person full name of supplier]]>
		Public Property [SupplierContactPersonFullName] As String
		'''<![CDATA[Name of supplier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierName] As String
		'''<![CDATA[Total VAT amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmount] As Double?
		'''<![CDATA[Warehouse]]>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<![CDATA[Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, False, True)>
	<DataServiceKey("ID")>
	Public Class [PurchaseOrderLine]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Reference to Cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Reference to Cost unit]]>
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
		'''<![CDATA[Description of the purchase order line]]>
		Public Property [Description] As String
		'''<![CDATA[Discount in percentage for item]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Expense related to the Work Breakdown Structure of the selected project. Only available with a professional service license]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Expense] As Guid?
		'''<![CDATA[Description of expense. Only available with a professional service license]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ExpenseDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InStock] As Double?
		'''<![CDATA[Quantity of item that has been invoiced]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoicedQuantity] As Double?
		'''<![CDATA[Reference to the item for purchase order]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
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
		'''<![CDATA[The net price is the unit price (VAT code taken into account) with any discount applied]]>
		Public Property [NetPrice] As Double?
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Reference to project. Only available with a professional service license]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Project code. Only available with a professional service license]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectCode] As String
		'''<![CDATA[Description of the project. Only available with a professional service license]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectedStock] As Double?
		'''<![CDATA[Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID]]>
		Public Property [PurchaseOrderID] As Guid
		'''<![CDATA[Quantity in item units]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Quantity] As Double?
		'''<![CDATA[Quantity in purchase units. Use this field when creating a purchase order]]>
		Public Property [QuantityInPurchaseUnits] As Double?
		'''<![CDATA[Indicates whether the purchase order line needs to be rebilled. Only available with a professional service license]]>
		Public Property [Rebill] As Boolean?
		'''<![CDATA[Date the goods are expected to be received]]>
		Public Property [ReceiptDate] As DateTime?
		'''<![CDATA[Quantity of goods received]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ReceivedQuantity] As Double?
		'''<![CDATA[Sales order that is linked to a back to back sales order in purchase order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrder] As Guid?
		'''<![CDATA[Sales order line of the sales order that is linked to a back to back sales order in purchase order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLine] As Guid?
		'''<![CDATA[Number of the sales order line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<![CDATA[Number of the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[Code the supplier uses for this item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SupplierItemCode] As String
		'''<![CDATA[Code of item unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unit] As String
		'''<![CDATA[Description of unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Item price per purchase unit]]>
		Public Property [UnitPrice] As Double?
		'''<![CDATA[Amount of VAT charges calculated from total amount and vat percentage]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATAmount] As Double?
		'''<![CDATA[The VAT code used when the invoice was registered]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of vat code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATDescription] As String
		'''<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace