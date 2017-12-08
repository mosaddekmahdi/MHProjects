
'Main Script
 Dim iRowCount
 Dim i

'Count the total number of executable rows 
 iRowCount = DataTable.GetRowCount

 'Loop through the total number of executable rows 
 For i = 1 to iRowCount

	'Set i value in the currect row
	DataTable.SetCurrentRow(i)
	'
    'Check if Execute is set to Y or y
	If Ucase(DataTable.Value("Execute")) ="Y" Then

	
 Reporter.ReportEvent micDone,  "****************************Start Executing Test Name: "& DataTable.Value("TestName")&"**************************************", ""
		'If true then Execute TestName from the corresponding row in the Datasheet
		'The sub routines are located under Library  Functions
 		Execute  DataTable.Value("TestName")

 Reporter.ReportEvent micDone,  "----------------------------End  Executing Test Name: "& DataTable.Value("TestName")&"----------------------------------------", ""
	End If
Next

'
'
'Function FacebookLogin
'	
'	Systemutil.Run "https://www.facebook.com/"
'	wait(2)
'	Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
'	With oBrowser
'	
'	.WebEdit("html id:=email").Set ("mmhusabd@gmail.com")
'	wait(1)
'	.WebEdit("html id:=pass").Set ("Tarash6780")
'	wait(1)
'	.WebButton("name:=Log In").Click
'	wait(2)
'	End With
'End Function
'
'
'''Facebook Page Component
'
'''''FacebookLogin
'
'Sub Test1
'	
'	Call FacebookLogin
'	
'End Sub
'


'
''
''
''Sub Test1
''	
''	Call FacebookLogin
''	
''End Sub
''
''
''
''Function FacebookLogin
''	
''Systemutil.Run "https://www.facebook.com/"
''wait(2)
''Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
''With oBrowser
''
''.WebEdit("html id:=email").Set ("mmhusabd@gmail.com")
''wait(1)
''.WebEdit("html id:=pass").Set ("Tarash6780")
''wait(1)
''.WebButton("name:=Log In").Click
''wait(2)
''End With
''End Function
''
'
'
'datatable.Import "C:\Mokter\UFTDemo\UFTAutomationFramework\FBExcelData.xls"
'
''System.getProperty("user.dir")
''msgbox Setting("actionsspath")
'
'wait(1)
'
'For i = 1 To datatable.GetRowCount Step 1
'
''Call CloseOpenBrowsers
'		
'With Browser("creationtime:=0")
'While .Exist(1)
''Close the browser
'.Close
'Wend
'End With
'
'
'Systemutil.Run "https://www.facebook.com/"
'
'wait(2)
'
'Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")
'
'
'	
'Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=email").Set Datatable.Value("username") 
'
'Browser("micclass:=Browser").Page("micclass:=Page").WebEdit("html id:=pass").Set Datatable.Value("password")
'
'Browser("micclass:=Browser").Page("micclass:=Page").WebButton("name:=Log In").Click
'
'datatable.SetNextRow
'
'wait(1)
'
'
'sName=oBrowser.WebElement("html id:=findFriendsNav").GetROProperty("innertext")
'
'If sName="Find Friends" Then
''msgbox "Yes"
'Reporter.ReportEvent micPass,"The Find Friends is available"," Yes, the Find Friends is available"
'Else
''msgbox "No"
'Reporter.ReportEvent micFail,"The Find Friends is not available","No,the Find Friends is not available"
'End If
'
'
'wait(2)
'
'
'
'
'Browser("micclass:=Browser").Page("micclass:=Page").WebElement("html id:=userNavigationLabel").Click
'	wait(2)
'
'	Browser("micclass:=Browser").Page("micclass:=Page").Link("name:=Log Out").Click
'wait 2
'
'Browser("micclass:=Browser").Close
'
'Next
'
'
