use MyDevices

Select *
From dbo.Devices
Select *
From dbo.Person
Select *
From dbo.Rooms
DELETE FROM dbo.Devices
DELETE FROM	dbo.Person
DELETE FROM	dbo.Rooms
