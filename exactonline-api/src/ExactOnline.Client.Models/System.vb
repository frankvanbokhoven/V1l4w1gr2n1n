' Last generated on 2017-05-05 12:58:35Z

Namespace System

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AccountantInfo]
		'''<![CDATA[First address line.]]>
		Public Property [AddressLine1] As String
		'''<![CDATA[Second address line.]]>
		Public Property [AddressLine2] As String
		'''<![CDATA[Third address line.]]>
		Public Property [AddressLine3] As String
		'''<![CDATA[City.]]>
		Public Property [City] As String
		'''<![CDATA[Email.]]>
		Public Property [Email] As String
		'''<![CDATA[The account ID of the accountant.]]>
		Public Property [ID] As Guid
		'''<![CDATA[Indicates if the customer is an accountant himself.]]>
		Public Property [IsAccountant] As Boolean
		'''<![CDATA[Logo.]]>
		Public Property [Logo] As Byte()
		'''<![CDATA[Url to retrieve the logo of the accountant.]]>
		Public Property [MenuLogoUrl] As String
		'''<![CDATA[The name of the accountant.]]>
		Public Property [Name] As String
		'''<![CDATA[Phone.]]>
		Public Property [Phone] As String
		'''<![CDATA[Postcode.]]>
		Public Property [Postcode] As String
		'''<![CDATA[Website.]]>
		Public Property [Website] As String
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("ID")>
	Public Class [AvailableFeature]
		'''<![CDATA[The description of the feature.]]>
		Public Property [Description] As String
		'''<![CDATA[The ID of the feature.]]>
		Public Property [ID] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Code")>
	Public Class [Division]
		'''<![CDATA[Address line 1]]>
		Public Property [AddressLine1] As String
		'''<![CDATA[Address line 2]]>
		Public Property [AddressLine2] As String
		'''<![CDATA[Address line 3]]>
		Public Property [AddressLine3] As String
		'''<![CDATA[Chamber of commerce number]]>
		Public Property [ChamberOfCommerceNumber] As String
		'''<![CDATA[City]]>
		Public Property [City] As String
		'''<![CDATA[Primary key]]>
		Public Property [Code] As Int32
		'''<![CDATA[Country of the division. Is used for determination of legislation]]>
		Public Property [Country] As String
		'''<![CDATA[Creation date]]>
		Public Property [Created] As DateTime
		'''<![CDATA[Default currency]]>
		Public Property [Currency] As String
		'''<![CDATA[True when this division is most recently used by the API]]>
		Public Property [Current] As Boolean
		'''<![CDATA[Owner account of the division]]>
		Public Property [Customer] As Guid?
		'''<![CDATA[Owner account code of the division]]>
		Public Property [CustomerCode] As String
		'''<![CDATA[Owner account name of the division]]>
		Public Property [CustomerName] As String
		'''<![CDATA[Description]]>
		Public Property [Description] As String
		'''<![CDATA[Email address]]>
		Public Property [Email] As String
		'''<![CDATA[Company number that is assigned by the customer]]>
		Public Property [Hid] As Int64
		'''<![CDATA[True if the division is the main division]]>
		Public Property [IsMainDivision] As Boolean
		'''<![CDATA[Last modified date]]>
		Public Property [Modified] As DateTime
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Postcode]]>
		Public Property [Postcode] As String
		'''<![CDATA[State/Province code]]>
		Public Property [State] As String
		'''<![CDATA[Follow the Division Status 0 for Inactive, 1 for Active and 2 for Archived Divisions]]>
		Public Property [Status] As Int32
		'''<![CDATA[The number under which the account is known at the Value Added Tax collection agency]]>
		Public Property [VATNumber] As String
	End Class

End Namespace