use MyDevices


/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 11/6/2019 6:53 AM******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/**

[id] [int] IDENTITY(1,1) NOT NULL,
	[DeviceName] [nvarchar] (50) NULL,
	[DeviceType] [nvarchar] (50) NULL,
	[IPAddress] [nvarchar] (12) NULL,
	[MACAddress] [nvarchar] (12) NULL,
	[Mobile] [char] (1) NOT NULL
	


**/

CREATE PROCEDURE [dbo].[spDevices_Insert] 
	@DeviceName nvarchar(50),
	@DeviceType nvarchar(50),
	@IPAddress nvarchar(12), 
	@MACAddress nvarchar(12),
	@Mobile char(1),

	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.People (FirstName, LastName, EmailAddress, CellphoneNumber,Age)
	values (@DeviceName, @DeviceType, @IPAddress, @MACAddress,@Mobile);

	select @id=SCOPE_IDENTITY();
END
GO