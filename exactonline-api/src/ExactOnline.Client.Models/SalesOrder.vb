' Last generated on 2017-05-05 12:58:35Z

Namespace SalesOrder

	<SupportedActionsSDK(True, True, True, False)>
	<DataServiceKey("EntryID")>
	Public Class [GoodsDelivery]
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of the creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
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
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryAddress] As Guid?
		'''<![CDATA[Reference to contact for delivery]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContact] As Guid?
		'''<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryContactPersonFullName] As String
		'''<![CDATA[Date of goods delivery]]>
		Public Property [DeliveryDate] As DateTime?
		'''<![CDATA[Delivery number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryNumber] As Int32?
		'''<![CDATA[Header description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Document that is manually linked to the sales order delivery]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Document Subject]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Primary key]]>
		Public Property [EntryID] As Guid
		'''<![CDATA[Entry number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [EntryNumber] As Int32?
		'''<![CDATA[Collection of lines]]>
		Public Property [GoodsDeliveryLines] As IEnumerable(Of Models.SalesOrder.GoodsDeliveryLine)
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
		'''<![CDATA[Reference to shipping method]]>
		Public Property [ShippingMethod] As Guid?
		'''<![CDATA[Code of shipping method]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodCode] As String
		'''<![CDATA[Description of shipping method]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodDescription] As String
		'''<![CDATA[Reference to header tracking number]]>
		Public Property [TrackingNumber] As String
		'''<![CDATA[Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Warehouse] As Guid?
		'''<![CDATA[Code of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
	End Class

	<SupportedActionsSDK(True, True, True, False)>
	<DataServiceKey("ID")>
	Public Class [GoodsDeliveryLine]
		'''<![CDATA[Collection of batch numbers]]>
		Public Property [BatchNumbers] As IEnumerable(Of Models.Inventory.StockBatchNumber)
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Date of goods delivery]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryDate] As DateTime?
		'''<![CDATA[Description of sales order delivery]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID]]>
		Public Property [EntryID] As Guid?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Item] As Guid?
		'''<![CDATA[Item code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
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
		'''<![CDATA[Notes]]>
		Public Property [Notes] As String
		'''<![CDATA[Quantity delivered]]>
		Public Property [QuantityDelivered] As Double?
		'''<![CDATA[Quantity ordered]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityOrdered] As Double?
		'''<![CDATA[Reference to sales order]]>
		Public Property [SalesOrderLineID] As Guid?
		'''<![CDATA[Sales order line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderLineNumber] As Int32?
		'''<![CDATA[Sales order number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalesOrderNumber] As Int32?
		'''<![CDATA[Collection of serial numbers]]>
		Public Property [SerialNumbers] As IEnumerable(Of Models.Inventory.StockSerialNumber)
		'''<![CDATA[Reference to storage location]]>
		Public Property [StorageLocation] As Guid?
		'''<![CDATA[Storage location code]]>
		Public Property [StorageLocationCode] As String
		'''<![CDATA[Storage location description]]>
		Public Property [StorageLocationDescription] As String
		'''<![CDATA[Reference to tracking number]]>
		Public Property [TrackingNumber] As String
		'''<![CDATA[Code of item unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Unitcode] As String
	End Class

	<SupportedActionsSDK(True, False, False, False)>
	<DataServiceKey("OrderId")>
	Public Class [PrintedSalesOrder]
		'''<![CDATA[Division code]]>
		Public Property [Division] As Int32?
		'''<![CDATA[Contains the id of the document that was created]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
		Public Property [DocumentCreationError] As String
		'''<![CDATA[Contains information if a document was succesfully created]]>
		Public Property [DocumentCreationSuccess] As String
		'''<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
		Public Property [DocumentLayout] As Guid?
		'''<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
		Public Property [EmailCreationError] As String
		'''<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
		Public Property [EmailCreationSuccess] As String
		'''<![CDATA[Based on this layout the email text is produced]]>
		Public Property [EmailLayout] As Guid?
		'''<![CDATA[Extra text that can be added to the printed document and email]]>
		Public Property [ExtraText] As String
		'''<![CDATA[Primary key, Reference to OrderID of SalesOrder]]>
		Public Property [OrderId] As Guid
		'''<![CDATA[Set to True if an email containing the sales order should be sent to the customer]]>
		Public Property [SendEmailToCustomer] As Boolean?
		'''<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
		Public Property [SenderEmailAddress] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("OrderID")>
	Public Class [SalesOrder]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Shows if this sales order is approved]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApprovalStatus] As Int16?
		'''<![CDATA[Description of ApprovalStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApprovalStatusDescription] As String
		'''<![CDATA[Approval datetime]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Approved] As DateTime?
		'''<![CDATA[User who approved the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Approver] As Guid?
		'''<![CDATA[Name of approver]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ApproverFullName] As String
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
		'''<![CDATA[Reference to delivery customer]]>
		Public Property [DeliverTo] As Guid?
		'''<![CDATA[Reference to contact person of delivery customer]]>
		Public Property [DeliverToContactPerson] As Guid?
		'''<![CDATA[Name of contact person of delivery customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToContactPersonFullName] As String
		'''<![CDATA[Name of delivery customer]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliverToName] As String
		'''<![CDATA[Delivery address]]>
		Public Property [DeliveryAddress] As Guid?
		'''<![CDATA[Delivery date]]>
		Public Property [DeliveryDate] As DateTime?
		'''<![CDATA[Shipping status]]>
		Public Property [DeliveryStatus] As Int16?
		'''<![CDATA[Description of DeliveryStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DeliveryStatusDescription] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Document that is manually linked to the sales order]]>
		Public Property [Document] As Guid?
		'''<![CDATA[Number of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentNumber] As Int32?
		'''<![CDATA[Subject of the document]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [DocumentSubject] As String
		'''<![CDATA[Invoice status]]>
		Public Property [InvoiceStatus] As Int16?
		'''<![CDATA[Description of InvoiceStatus]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceStatusDescription] As String
		'''<![CDATA[Reference to the Customer who will receive the invoice]]>
		Public Property [InvoiceTo] As Guid?
		'''<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
		Public Property [InvoiceToContactPerson] As Guid?
		'''<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToContactPersonFullName] As String
		'''<![CDATA[Name of the customer who will receive the invoice]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [InvoiceToName] As String
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
		'''<![CDATA[Customer who ordered the sales order]]>
		Public Property [OrderedBy] As Guid?
		'''<![CDATA[Contact person of the customer who ordered the sales order]]>
		Public Property [OrderedByContactPerson] As Guid?
		'''<![CDATA[Name of contact person of the customer who ordered the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByContactPersonFullName] As String
		'''<![CDATA[Name of the customer who ordered the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [OrderedByName] As String
		'''<![CDATA[Primary key]]>
		Public Property [OrderID] As Guid
		'''<![CDATA[Number of sales order]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[The payment condition used for due date and discount calculation]]>
		Public Property [PaymentCondition] As String
		'''<![CDATA[Description of PaymentCondition]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PaymentConditionDescription] As String
		'''<![CDATA[Payment reference for sales order]]>
		Public Property [PaymentReference] As String
		'''<![CDATA[Extra remarks]]>
		Public Property [Remarks] As String
		'''<![CDATA[Collection of lines]]>
		Public Property [SalesOrderLines] As IEnumerable(Of Models.SalesOrder.SalesOrderLine)
		'''<![CDATA[Sales representative]]>
		Public Property [Salesperson] As Guid?
		'''<![CDATA[Name of sales representative]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [SalespersonFullName] As String
		'''<![CDATA[ShippingMethod]]>
		Public Property [ShippingMethod] As Guid?
		'''<![CDATA[Description of ShippingMethod]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ShippingMethodDescription] As String
		'''<![CDATA[The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Status] As Int16?
		'''<![CDATA[Description of Status]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [StatusDescription] As String
		'''<![CDATA[Obsolete]]>
		Public Property [TaxSchedule] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<![CDATA[Code of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseCode] As String
		'''<![CDATA[Description of Warehouse]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [WarehouseDescription] As String
		'''<![CDATA[Warehouse]]>
		Public Property [WarehouseID] As Guid?
		'''<![CDATA[The reference number of the customer]]>
		Public Property [YourRef] As String
	End Class

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [SalesOrderLine]
		'''<![CDATA[Amount in the default currency of the company]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AmountDC] As Double?
		'''<![CDATA[Amount in the currency of the transaction]]>
		Public Property [AmountFC] As Double?
		'''<![CDATA[Reference to Cost center]]>
		Public Property [CostCenter] As String
		'''<![CDATA[Description of CostCenter]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostCenterDescription] As String
		'''<![CDATA[Item cost price]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostPriceFC] As Double?
		'''<![CDATA[Reference to Cost unit]]>
		Public Property [CostUnit] As String
		'''<![CDATA[Description of CostUnit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CostUnitDescription] As String
		'''<![CDATA[Delivery date of this line]]>
		Public Property [DeliveryDate] As DateTime?
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
		Public Property [Discount] As Double?
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Reference to the item that is sold in this sales order line]]>
		Public Property [Item] As Guid?
		'''<![CDATA[Code of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemCode] As String
		'''<![CDATA[Description of Item]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemDescription] As String
		'''<![CDATA[Item Version]]>
		Public Property [ItemVersion] As Guid?
		'''<![CDATA[Description of Item Version]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ItemVersionDescription] As String
		'''<![CDATA[Line number]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [LineNumber] As Int32?
		'''<![CDATA[Sales margin of the sales order line]]>
		Public Property [Margin] As Double?
		'''<![CDATA[Net price of the sales order line]]>
		Public Property [NetPrice] As Double?
		'''<![CDATA[Extra notes]]>
		Public Property [Notes] As String
		'''<![CDATA[The OrderID identifies the sales order. All the lines of a sales order have the same OrderID]]>
		Public Property [OrderID] As Guid
		'''<![CDATA[Number of sales order]]>
		Public Property [OrderNumber] As Int32?
		'''<![CDATA[Price list]]>
		Public Property [Pricelist] As Guid?
		'''<![CDATA[Description of Pricelist]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PricelistDescription] As String
		'''<![CDATA[The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
		Public Property [Project] As Guid?
		'''<![CDATA[Description of Project]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ProjectDescription] As String
		'''<![CDATA[Purchase order that is linked to the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrder] As Guid?
		'''<![CDATA[Purchase order line of the purchase order that is linked to the sales order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLine] As Guid?
		'''<![CDATA[Number of the purchase order line]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderLineNumber] As Int32?
		'''<![CDATA[Number of the purchase order]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [PurchaseOrderNumber] As Int32?
		'''<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
		Public Property [Quantity] As Double?
		'''<![CDATA[The number of items delivered]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityDelivered] As Double?
		'''<![CDATA[The number of items invoiced]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [QuantityInvoiced] As Double?
		'''<![CDATA[Reference to ShopOrder]]>
		Public Property [ShopOrder] As Guid?
		'''<![CDATA[Obsolete]]>
		Public Property [TaxSchedule] As Guid?
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleCode] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [TaxScheduleDescription] As String
		'''<![CDATA[Code of item unit]]>
		Public Property [UnitCode] As String
		'''<![CDATA[Description of Unit]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [UnitDescription] As String
		'''<![CDATA[Price per unit in the currency of the transaction]]>
		Public Property [UnitPrice] As Double?
		'''<![CDATA[Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)]]>
		Public Property [UseDropShipment] As Byte
		'''<![CDATA[VAT amount in the currency of the transaction]]>
		Public Property [VATAmount] As Double?
		'''<![CDATA[VAT code]]>
		Public Property [VATCode] As String
		'''<![CDATA[Description of VATCode]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [VATCodeDescription] As String
		'''<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
		Public Property [VATPercentage] As Double?
	End Class

End Namespace