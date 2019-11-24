
Create Database MyDevices

use [MyDevices]

Create Table [dbo].[Rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [nvarchar] (50) NOT NULL,
	
	CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]







