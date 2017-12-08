
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
	If UCase(DataTable.Value("Execute")) ="Y" Then
	
 Reporter.ReportEvent micDone,  "****************************Start Executing Test Name: "& DataTable.Value("TestName")&"**************************************", ""
		'If true then Execute TestName from the corresponding row in the Datasheet
		'The sub routines are located under Library  Functions
 		Execute  DataTable.Value("TestName")

 Reporter.ReportEvent micDone,  "----------------------------End  Executing Test Name: "& DataTable.Value("TestName")&"----------------------------------------", ""
	End If
Next

'

'
'Browser("micclass:=Browser").Page("micclass:=Page").WebButton("type:=submit","html tag:=BUTTON","acc_name:=Search").Click
'wait 10
'

'Browser("Facebook").Page("Rahima Mokter - Facebook").WebButton("Search").Click
'Browser("Facebook").Page("Rahima Mokter - Facebook").WebButton("Search").Click

