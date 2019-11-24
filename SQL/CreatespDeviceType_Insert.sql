


use MyDevices


/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 11/6/2019 6:53 AM******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/**
[id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar] (50) NOT NULL
	


**/

CREATE PROCEDURE [dbo].[spDeviceType_Insert] 
	@Type nvarchar(50),
	
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.DeviceType(Type)
	values (@Type);

	select @id=SCOPE_IDENTITY();
END
GO