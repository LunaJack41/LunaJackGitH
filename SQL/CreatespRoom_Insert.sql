USE [MyDevices]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spRoom_Insert]
	@RoomName nvarchar(50),
	@RoomLocation nvarchar(50),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Rooms (RoomName, RoomLocation)
	values (@RoomName, @RoomLocation);

	select @id=SCOPE_IDENTITY();
END

GO
