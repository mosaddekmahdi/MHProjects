-- This code can be used to disable change tracking within your database
-- Please ensure all tables have stopped using chagne tracking before executing this code
    
IF EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'C:\USERS\MHOSSAIN2\DESKTOP\MYJOBS-AMONGODBAPPLICATION_11-15\MONGODBAPPLICATION\MYJOBS.MDF')) 
  ALTER DATABASE [C:\USERS\MHOSSAIN2\DESKTOP\MYJOBS-AMONGODBAPPLICATION_11-15\MONGODBAPPLICATION\MYJOBS.MDF] 
  SET  CHANGE_TRACKING = OFF
GO
