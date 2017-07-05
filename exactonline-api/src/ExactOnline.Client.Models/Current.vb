' Last generated on 2017-05-05 12:58:35Z

Namespace Current

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("UserID")>
	Public Class [Me]
		'''<![CDATA[Division number that is currently used in the API. You should use a division number in the url]]>
		Public Property [CurrentDivision] As Int32
		'''<![CDATA[Owner account of the division]]>
		Public Property [DivisionCustomer] As Guid?
		'''<![CDATA[Owner account code of the division]]>
		Public Property [DivisionCustomerCode] As String
		'''<![CDATA[Owner account name of the division]]>
		Public Property [DivisionCustomerName] As String
		'''<![CDATA[Email address of the user]]>
		Public Property [Email] As String
		'''<![CDATA[Employee ID]]>
		Public Property [EmployeeID] As Guid
		'''<![CDATA[First name]]>
		Public Property [FirstName] As String
		'''<![CDATA[Full name of the user]]>
		Public Property [FullName] As String
		'''<![CDATA[Gender: M=Male, V=Female, O=Unknown]]>
		Public Property [Gender] As String
		'''<![CDATA[Initials]]>
		Public Property [Initials] As String
		'''<![CDATA[Language spoken by this user]]>
		Public Property [Language] As String
		'''<![CDATA[Language (culture) that is used in Exact Online]]>
		Public Property [LanguageCode] As String
		'''<![CDATA[Last name]]>
		Public Property [LastName] As String
		'''<![CDATA[Legislation]]>
		Public Property [Legislation] As Int64
		'''<![CDATA[Middle name]]>
		Public Property [MiddleName] As String
		'''<![CDATA[Mobile phone]]>
		Public Property [Mobile] As String
		'''<![CDATA[Nationality]]>
		Public Property [Nationality] As String
		'''<![CDATA[Phone number]]>
		Public Property [Phone] As String
		'''<![CDATA[Phone number extension]]>
		Public Property [PhoneExtension] As String
		'''<![CDATA[Url that can be used to retrieve the picture of the user]]>
		Public Property [PictureUrl] As String
		'''<![CDATA[The current date and time in Exact Online]]>
		Public Property [ServerTime] As String
		'''<![CDATA[The time difference with UTC in seconds]]>
		Public Property [ServerUtcOffset] As Double
		'''<![CDATA[Binary thumbnail picture of this user]]>
		Public Property [ThumbnailPicture] As Byte()
		'''<![CDATA[File type of the picture]]>
		Public Property [ThumbnailPictureFormat] As String
		'''<![CDATA[Title]]>
		Public Property [Title] As String
		'''<![CDATA[Primary key]]>
		Public Property [UserID] As Guid
		'''<![CDATA[Login name of the user]]>
		Public Property [UserName] As String
	End Class

End Namespace