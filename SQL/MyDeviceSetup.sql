

CREATE DATABASE MyDevices
GO
USE [MyDevices]
GO
CREATE Table [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar] (50) NOT NULL,
	[LastName] [nvarchar] (50),
	[Age] [nvarchar] (50),
	[EmailAddress] [nvarchar] (100),
	[CellphoneNumber] [varchar](20)
CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
use MyDevices
CREATE Table [dbo].DeviceType(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar] (50) NOT NULL
CONSTRAINT [PK_DeviceTypes] PRIMARY KEY CLUSTERED
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
CREATE Table [dbo].[Rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [nvarchar] (50) NOT NULL,
	
	CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

Create Table [dbo].[Devices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DeviceName] [nvarchar] (50) NOT NULL,
	[DeviceType] [nvarchar] (50) NULL,
	[IPAddress] [nvarchar] (12) NULL,
	[MACAddress] [nvarchar] (12) NULL,
	[Mobile] [char] (1) NOT NULL
	
	CONSTRAINT [PK_Devices] PRIMARY KEY CLUSTERED
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

