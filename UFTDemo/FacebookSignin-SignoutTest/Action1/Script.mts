With Browser("creationtime:=0")
While .Exist(1)
'Close the browser
.Close
Wend
End With

'Systemutil.Run "https://www.facebook.com", "C:\Program Files (x86)\Internet Explorer\iexplorer.exe"

Systemutil.Run "https://www.facebook.com/"
wait(2)
Set oBrowser=Browser("micclass:=Browser").Page("micclass:=Page")

With oBrowser
.WebEdit("html id:=email").Set ("mmhusabd@gmail.com")
wait(1)
.WebEdit("html id:=pass").Set ("Tarash6780")
wait(1)
.WebButton("name:=Log In").Click
wait(2)

.WebElement("html id:=userNavigationLabel").Click

wait(3)

'.WebElement("innertext:=Log Out").Click


End With

wait(5)

Browser("micclass:=Browser").Close

'
'sName=oBrowser.WebElement("class:=f_click").GetROProperty("innertext")
'
'If sName="Mmh" Then
''msgbox "Yes"
'Reporter.ReportEvent micPass,"The Mmh profile is available"," Yes, the Mmh profile is available"
'Else
''msgbox "No"
'Reporter.ReportEvent micFail,"The Follow button is not available","No,the Mmh profile is not available"
'End If
'



