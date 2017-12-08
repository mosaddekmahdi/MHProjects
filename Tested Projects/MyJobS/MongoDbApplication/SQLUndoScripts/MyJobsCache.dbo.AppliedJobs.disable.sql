IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[AppliedJobs]')) 
   ALTER TABLE [dbo].[AppliedJobs] 
   DISABLE  CHANGE_TRACKING
GO
