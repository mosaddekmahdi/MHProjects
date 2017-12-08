With Browser("creationtime:=0")
While .Exist(1)
'Close the browser
.Close
Wend
End With

'Systemutil.Run "https://www.google.com", "C:\Program Files (x86)\Internet Explorer\iexplorer.exe"

Systemutil.Run "https://www.google.com/"
wait(2)
Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")

With oBrowser
.WebEdit("acc_name:=Search").Set ("Mokter Hossain")
wait(1)
.WebElement("class:=sbico").Click
'wait(1)
.Link("name:=Dr. Md Mokter Hossain - Google Scholar Citations").Click
'wait(1)
'msgbox .WebButton("html id:=gsc_fol_btn").GetROProperty("innertext")

End With
sName=oBrowser.WebButton("html id:=gsc_fol_btn").GetROProperty("innertext")

If sName="Follow" Then
'msgbox "Yes"
Reporter.ReportEvent micPass,"The Follow button is available"," Yessss"
Else
'msgbox "No"
Reporter.ReportEvent micFail,"The Follow button is not available","Nooo"
End If

If sName="Follow" Then
'msgbox "Yes"
Reporter.ReportEvent micPass,"The Follow button is available"," Yes"
Else
'msgbox "No"
Reporter.ReportEvent micFail,"The Follow button is not available","No"
End If

'msgbox .
''Browser("micclass:=Browser").Page("micclass:=Page").Link("innertext:=Awards").Click(
'
'Browser("Facebook - Log In or Sign").Page("mokter hossain - Google").WebEdit("Search").Set "Mokter Hossain"
'Browser("Facebook - Log In or Sign").Page("mokter hossain - Google").Link("Dr. Mokter Hossain | Computer").Click
'Browser("Facebook - Log In or Sign").Page("Dr. Mokter Hossain | Computer").Link("Education").Click
'
'Browser("Facebook - Log In or Sign").Page("Education | Dr. Mokter").WebElement("Education").Check CheckPoint("Education")
'
'Browser("Facebook - Log In or Sign").Page("Education | Dr. Mokter").Link("myBooks").Click
'Browser("Facebook - Log In or Sign").Page("myBooks | Dr. Mokter Hossain").Link("Brief Features of My Books").Click
'

'Browser("Facebook - Log In or Sign").CloseAllTabs


'Browser("micclass:=Browser").Page("micclass:=Page").Link("innertext:=Awards").Click




