' Last generated on 2017-05-05 12:58:35Z

Namespace VAT

	<SupportedActionsSDK(True, True, True, True)>
	<DataServiceKey("ID")>
	Public Class [VATCode]
		'''<![CDATA[Tax account]]>
		Public Property [Account] As Guid?
		'''<![CDATA[Code of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountCode] As String
		'''<![CDATA[Name of Account]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [AccountName] As String
		'''<![CDATA[Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax]]>
		Public Property [CalculationBasis] As Byte?
		'''<![CDATA[Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created]]>
		Public Property [Charged] As Boolean?
		'''<![CDATA[VAT code]]>
		Public Property [Code] As String
		'''<![CDATA[Obsolete]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Country] As String
		'''<![CDATA[Creation date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Created] As DateTime?
		'''<![CDATA[User ID of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Creator] As Guid?
		'''<![CDATA[Name of creator]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [CreatorFullName] As String
		'''<![CDATA[Description of the VAT code]]>
		Public Property [Description] As String
		'''<![CDATA[Division code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Division] As Int32?
		'''<![CDATA[Used in all legislations except France. Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation]]>
		Public Property [EUSalesListing] As String
		'''<![CDATA[Indicates the purchase discount GL account linked to the VAT codes for German legislation]]>
		Public Property [GLDiscountPurchase] As Guid?
		'''<![CDATA[Code of GLDiscountPurchase]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountPurchaseCode] As String
		'''<![CDATA[Description of GLDiscountPurchase]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountPurchaseDescription] As String
		'''<![CDATA[Indicates the sales discount GL account linked to the VAT codes for German legislation]]>
		Public Property [GLDiscountSales] As Guid?
		'''<![CDATA[Code of GLDiscountSales]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountSalesCode] As String
		'''<![CDATA[Description of GLDiscountSales]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLDiscountSalesDescription] As String
		'''<![CDATA[G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT]]>
		Public Property [GLToClaim] As Guid?
		'''<![CDATA[Code of GLToClaim]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToClaimCode] As String
		'''<![CDATA[Description of GLToClaim]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToClaimDescription] As String
		'''<![CDATA[G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT]]>
		Public Property [GLToPay] As Guid?
		'''<![CDATA[Code of GLToPay]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToPayCode] As String
		'''<![CDATA[Description of GLToPay]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [GLToPayDescription] As String
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
		'''<![CDATA[Used in all legislations except France. Indicates if intrastat is used]]>
		Public Property [IntraStat] As Boolean?
		'''<![CDATA[Used in France legislation only. Indicates if and how transactions using the VAT code appear on the DEB/DES return. L = Goods, N = Empty, S = Services]]>
		Public Property [IntrastatType] As String
		'''<![CDATA[Indicates if the VAT code may still be used]]>
		Public Property [IsBlocked] As Boolean?
		'''<![CDATA[Legal description for VAT code to print in the total block of the invoice]]>
		Public Property [LegalText] As String
		'''<![CDATA[Last modified date]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modified] As DateTime?
		'''<![CDATA[User ID of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Modifier] As Guid?
		'''<![CDATA[User name of modifier]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [ModifierFullName] As String
		'''<![CDATA[Percentage of the VAT code]]>
		<SDKFieldType(FieldType.ReadOnly)>
		Public Property [Percentage] As Double?
		'''<![CDATA[Indicates what type of Taxcode it is: can be VAT, IncomeTax]]>
		Public Property [TaxReturnType] As Int16?
		'''<![CDATA[Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT]]>
		Public Property [Type] As String
		'''<![CDATA[Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type]]>
		Public Property [VatDocType] As String
		'''<![CDATA[The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)]]>
		Public Property [VatMargin] As Byte
		'''<![CDATA[Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability]]>
		Public Property [VATPartialRatio] As Int16?
		'''<![CDATA[VAT percentages. You can have several VAT percentages, with start and end dates]]>
		Public Property [VATPercentages] As IEnumerable(Of Models.VAT.VatPercentage)
		'''<![CDATA[Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales]]>
		Public Property [VATTransactionType] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [VatPercentage]
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
		'''<![CDATA[End date of the date range during which this percentage is valid]]>
		Public Property [EndDate] As DateTime?
		'''<![CDATA[Primary key]]>
		Public Property [ID] As Guid
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
		'''<![CDATA[Percentage]]>
		Public Property [Percentage] As Double?
		'''<![CDATA[Start date of the date range during which this percentage is valid]]>
		Public Property [StartDate] As DateTime?
		'''<![CDATA[0 = Normal, 1 = Extra duty]]>
		Public Property [Type] As Int16
		'''<![CDATA[VAT code]]>
		Public Property [VATCodeID] As Guid
	End Class

End Namespace