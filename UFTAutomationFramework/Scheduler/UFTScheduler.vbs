Set qtApp = CreateObject("QuickTest.Application")
qtApp.Launch
qtApp.Visible = True
qtApp.WindowState = "Maximized"' Maximize the QuickTest window
qtApp.ActivateView "ExpertView"' Display the Expert View
qtApp.open "C:\Users\zahid\Desktop\Mokter\UFTAutomationFramework", False
qtApp.Test.Run

'close the test
qtApp.Test.Close

'quit the QTP application
qtApp.quit
