' Last generated on 2017-05-05 12:58:35Z

Namespace OpeningBalance

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalanceAfterEntry]
		'''<![CDATA[The opening balance amount of the G/L account.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
		Public Property [BalanceSide] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[The balance sheet account.]]>
		Public Property [GLAccount] As Guid
		'''<![CDATA[The code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[The description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[The reporting year of the opening balance.]]>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalancePreviousYearAfterEntry]
		'''<![CDATA[The opening balance amount of the G/L account.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
		Public Property [BalanceSide] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[The balance sheet account.]]>
		Public Property [GLAccount] As Guid
		'''<![CDATA[The code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[The description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[The reporting year of the opening balance.]]>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalancePreviousYearProcessed]
		'''<![CDATA[The opening balance amount of the G/L account.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
		Public Property [BalanceSide] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[The balance sheet account.]]>
		Public Property [GLAccount] As Guid
		'''<![CDATA[The code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[The description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[The reporting year of the opening balance.]]>
		Public Property [ReportingYear] As Int32
	End Class

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Division,ReportingYear,GLAccount")>
	Public Class [OpeningBalanceProcessed]
		'''<![CDATA[The opening balance amount of the G/L account.]]>
		Public Property [Amount] As Double?
		'''<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
		Public Property [BalanceSide] As String
		'''<![CDATA[Division code.]]>
		Public Property [Division] As Int32
		'''<![CDATA[The balance sheet account.]]>
		Public Property [GLAccount] As Guid
		'''<![CDATA[The code of the G/L account.]]>
		Public Property [GLAccountCode] As String
		'''<![CDATA[The description of the G/L account.]]>
		Public Property [GLAccountDescription] As String
		'''<![CDATA[The reporting year of the opening balance.]]>
		Public Property [ReportingYear] As Int32
	End Class

End Namespace