datatable.Import "C:\Users\zahid\Google Drive\UFTDemo\FBExcelData.xls"

'System.getProperty("user.dir")
'msgbox Setting("actionsspath")

wait(2)

For i = 1 To datatable.GetRowCount Step 1


With Browser("creationtime:=0")
While .Exist(1)
'Close the browser
.Close
Wend
End With


Systemutil.Run "https://www.facebook.com/"

wait(2)

Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")


	
Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=email").Set Datatable.Value("username") 

Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=pass").Set Datatable.Value("password")

Browser("micclass:=Browser").Page("micclass:=Page").WebButton("name:=Log In").Click

datatable.SetNextRow

wait(1)


wait(1)


sName=oBrowser.WebElement("html id:=findFriendsNav").GetROProperty("innertext")

If sName="Find Friends" Then
'msgbox "Yes"
Reporter.ReportEvent micPass,"The Find Friends is available"," Yes, the Find Friends is available"
Else
'msgbox "No"
Reporter.ReportEvent micFail,"The Find Friends is not available","No,the Find Friends is not available"
End If


wait(3)




Browser("micclass:=Browser").Page("micclass:=Page").WebElement("html id:=userNavigationLabel").Click
	wait(3)

	Browser("micclass:=Browser").Page("micclass:=Page").Link("name:=Log Out").Click
wait 2

Browser("micclass:=Browser").Close

Next

