''Reusable Functions
'

Function VerifyFacebookFindFriends
	'Verify  Find Friends
		Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
	sName=oBrowser.WebElement("html id:=findFriendsNav").GetROProperty("innertext")
	If sName="Find Friends" Then
	'msgbox "Yes"
	Reporter.ReportEvent micPass,"The Find Friends is available"," Yes, the Find Friends is available"
	Else
	'msgbox "No"
	Reporter.ReportEvent micFail,"The Find Friends is not available","No,the Find Friends is not available"
	End If
	
End Function
