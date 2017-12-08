
'Browser("Amazon.com: Online Shopping").Page("Amazon.com Sign In Security").WebEdit("dcq_question_subjective_1").Set "75243"
'Browser("Amazon.com: Online Shopping").Page("Amazon.com Sign In Security").WebButton("Sign in using our secure").Click
'Browser("Amazon.com: Online Shopping").Page("Amazon.com Sign In Security").WebEdit("dcq_question_subjective_1").Set "35216"
'Browser("Amazon.com: Online Shopping").Page("Amazon.com Sign In Security").WebButton("Sign in using our secure").Click


''System.getProperty("user.dir")
'msgbox Setting("actionsspath")



With Browser("creationtime:=0")
While .Exist(1)
'Close the browser
.Close
Wend
End With


Systemutil.Run "https://www.amazon.com"

wait(6)


'' Browser("micclass:=Browser").Page("micclass:=Page").Link("text:=Your Account","index:=0").Click



Browser("Amazon.com: Online Shopping").Page("Amazon.com: Online Shopping").Link("Hello. Sign inAccount").Click
Browser("Amazon.com: Online Shopping").Page("Amazon Sign In").WebEdit("email").Set "mokter@gmail.com"
Browser("Amazon.com: Online Shopping").Page("Amazon Sign In").WebEdit("password").SetSecure "58310381a198ccb95e6dc0634da16f6311fc4140580ebc511f9823a321280ace3ec9"
Browser("Amazon.com: Online Shopping").Page("Amazon Sign In").WebButton("Sign in").Click

wait (10)

