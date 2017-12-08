'Reusable Functions


Function CloseOpenBrowsers
		
With Browser("creationtime:=0")
While .Exist(1)
'Close the browser
.Close
Wend
End With

End Function


Function FacebookLogin
	
Systemutil.Run "https://www.facebook.com/"
wait(2)
Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
With oBrowser

.WebEdit("html id:=email").Set DataTable.Value("UserName")
wait(1)
.WebEdit("html id:=pass").Set DataTable.Value("Password")
wait(1)
.WebButton("name:=Log In").Click
wait(2)
End With
End Function



Function FBLogout
	
	Browser("micclass:=Browser").Page("micclass:=Page").WebElement("html id:=userNavigationLabel").Click
		wait(2)
	
		Browser("micclass:=Browser").Page("micclass:=Page").Link("name:=Log Out").Click
	wait 2
	
	Browser("micclass:=Browser").Close

End Function


Function CheckFindFriendsNav



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


Function CheckFindFriendsSearch
	
	Dim xlApp, xlBook, xlSheet
Dim iRow, sControl, sPlayerID, sResult
CONST iControlCol = 1	'Control is in Column A
CONST iNameCol = 2	'Date is in Column B
'CONST iResultCol = 3	'Result is in Column C

Set xlApp = CreateObject("Excel.Application")
Set xlBook = xlApp.WorkBooks.Open("C:\Users\zahid\Desktop\Mokter\UFTAutomationFramework\TestData\FBFriendlist.xls")
Set xlSheet = xlBook.WorkSheets("Sheet1")
 
'Loop 2 to entire rows
For iRow = 2 to xlSheet.UsedRange.Rows.Count
 
   'Retrieve Control ,Date and PlayerID from "iRow" rows and columns A, B & C
   sControl = xlSheet.Rows(iRow).Columns(iControlCol).Value
   sName = xlSheet.Rows(iRow).Columns(iNameCol).Value
   'sResult = xlSheet.Rows(iRow).Columns(iResultCol).Value

'Execute if Contol value is y

 If UCase(sControl)="Y" Then


Browser("micclass:=Browser").Page("micclass:=Page").Link("html id:=findFriendsNav").Click
wait 2

Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("class:=_1frb").Set sName
wait 2
Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("class:=_1frb").Click

wait 5

'
'	'Verify  Find Friends
'	Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
'	sName=oBrowser.WebElement("html id:=findFriendsNav").GetROProperty("innertext")
'	If sName="Find Friends" Then
'	'msgbox "Yes"
'	Reporter.ReportEvent micPass,"The Find Friends is available"," Yes, the Find Friends is available"
'	Else
'	'msgbox "No"
'	Reporter.ReportEvent micFail,"The Find Friends is not available","No,the Find Friends is not available"
'	End If
End if
Next

'xlBook.Save 
xlBook.Close
xlApp.Quit
Set xlSheet = Nothing
Set xlBook = Nothing
Set xlApp = Nothing


End Function
