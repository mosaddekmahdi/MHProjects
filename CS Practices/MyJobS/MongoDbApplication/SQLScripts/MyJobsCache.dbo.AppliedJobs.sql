IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[AppliedJobs]')) 
   ALTER TABLE [dbo].[AppliedJobs] 
   ENABLE  CHANGE_TRACKING
GO
