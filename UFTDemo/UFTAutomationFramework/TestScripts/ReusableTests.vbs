''Facebook Page Component

''''FacebookLogin

Sub Test1
'Close Browser
	Call CloseOpenBrowsers
	
	'FB Login
	Call FacebookLogin
	
	' Verify Facebook Find Friends
	Call CheckFindFriendsNav
	
	'Logout FB
	Call FBLogout
	
End Sub


Sub Test2


'Close Browser
	Call CloseOpenBrowsers
	
	'FB Login
	Call FacebookLogin
	
	Call CheckFindFriendsSearch

	Call FBLogout

End Sub

