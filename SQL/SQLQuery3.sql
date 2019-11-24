  USE [MyDevices]
GO
/****** Object:  StoredProcedure [dbo].[spPerson_Insert]    Script Date: 11/13/2019 4:08:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spPerson_Insert] 
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(100),
	@CellphoneNumber varchar(20),
	@Age varchar(20),

	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Person (FirstName, LastName, EmailAddress, CellphoneNumber,Age)
	values (@FirstName, @LastName, @EmailAddress, @CellphoneNumber,@Age);

	select @id=SCOPE_IDENTITY();
END
