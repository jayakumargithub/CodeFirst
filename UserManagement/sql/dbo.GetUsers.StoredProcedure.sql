USE [UserManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetUsers]    Script Date: 08/04/2015 22:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create PROCEDURE  [dbo].[GetUsers]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 
SELECT [Id]
      ,[FirstName]
      ,[LastName]
      ,[Age]
  FROM [dbo].[User]
 


END

GO
