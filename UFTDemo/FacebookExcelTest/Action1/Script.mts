	datatable.Import "C:\Users\zahid\Google Drive\UFTDemo\FBExcelData.xls"
	
	wait(10)
	
	With Browser("creationtime:=0")
	While .Exist(1)
	'Close the browser
	.Close
	Wend
	End With
	
	
	Systemutil.Run "https://www.facebook.com/"
	
	wait(2)
	
	'Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
	
	For i = 1 To datatable.GetRowCount Step 1
		
	Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=email").Set Datatable.Value("username") 
	
	Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=pass").Set Datatable.Value("password")
	
	Browser("micclass:=Browser").Page("micclass:=Page").WebButton("name:=Log In").Click
	
	datatable.SetNextRow
	
	wait(1)
	
	Next
	
	wait(1)
	
	
	Browser("micclass:=Browser").Page("micclass:=Page").WebElement("html id:=userNavigationLabel").Click
	
	wait(3)
	
	'.WebElement("innertext:=Log Out").Click
	
	
	
	Browser("micclass:=Browser").Close
	
	'sName=oBrowser.WebElement("class:=f_click").GetROProperty("innertext", 8)
	'
	'If sName="Mmh" Then
	''msgbox "Yes"
	'Reporter.ReportEvent micPass,"The Mmh profile is available"," Yes, the Mmh profile is available"
	'Else
	''msgbox "No"
	'Reporter.ReportEvent micFail,"The Follow button is not available","No,the Mmh profile is not available"
	'End If
	'
	
	
	
