IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[FavJobs]')) 
   ALTER TABLE [dbo].[FavJobs] 
   ENABLE  CHANGE_TRACKING
GO
