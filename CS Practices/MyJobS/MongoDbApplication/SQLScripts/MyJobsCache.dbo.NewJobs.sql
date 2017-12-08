IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[NewJobs]')) 
   ALTER TABLE [dbo].[NewJobs] 
   ENABLE  CHANGE_TRACKING
GO
