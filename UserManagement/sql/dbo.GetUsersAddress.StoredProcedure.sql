USE [UserManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetUsersAddress]    Script Date: 08/04/2015 22:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[GetUsersAddress] @userId int
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select   distinct u.FirstName, u.LastName, u.Age, u.Id from [UserManagement].[dbo].[User] u
	join UserAddress ad on ad.UserId = u.Id 
	where u.Id = @userId

	select a.Id, a.DoorNo, a.StreetName, a.City, a.Country from Address a
	join UserAddress ad on ad.AddressId = a.Id
	where ad.UserId = @userId
	
END
 
 
  
GO
