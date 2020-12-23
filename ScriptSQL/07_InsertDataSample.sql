USE [DormitoryManagement]
GO

CREATE LOGIN 0123456789 WITH PASSWORD = '000000'
CREATE USER 0123456789 FOR LOGIN 0123456789
EXEC sys.sp_addrolemember @rolename = EMPLOYEE,  -- sysname
                          @membername = khanh@gmail -- sysname

--Add Test
CREATE LOGIN p@gmail WITH PASSWORD = '000000'
CREATE USER p@gmail FOR LOGIN p@gmail
EXEC sys.sp_addrolemember @rolename = STUDENT,  -- sysname
                          @membername = p@gmail -- sysnam


--
--Add Test ADMIN
CREATE LOGIN ntp@gmail WITH PASSWORD = '000000'
CREATE USER ntp@gmail FOR LOGIN ntp@gmail
EXEC sys.sp_addrolemember @rolename = ADMIN,  -- sysname
                          @membername = ntp@gmail -- sysname


INSERT INTO dbo.ADDRESS (STREET, COMMNUNE_ID, DISTRICT_ID, PROVINCE_ID)
VALUES 
	(N'1 Dường ABC', '00001', '001', '01' ),
	(N'2 Đường XYZ', '00001', '001', '01' )
GO

INSERT INTO dbo.[USER] ( LAST_NAME, FIRST_NAME, DOB, GENDER, SSN, ADDRESS_ID, USERNAME, PASSWORD, USER_TYPE)
VALUES
	(N' ', N' ', '20000520', N'Nữ', '11', 1, 'admin', '12', 'ADMIN'),
	(N' ', N' ', '20000520', N'Nữ', '1111', 2, 'empl', '12', 'EMPLOYEE')
GO

UPDATE dbo.[USER] SET PASSWORD='C20AD4D76FE97759AA27A0C99BFF6710' WHERE USERNAME='admin' OR USERNAME = 'empl'

INSERT INTO [dbo].[SECTOR] ( [SECTOR_ID], [SECTOR_NAME])
VALUES 
	('A', N'Khu A'),
	('B', N'Khu B')
GO

INSERT INTO [dbo].[ROOM_TYPE] ( [ROOM_TYPE_NAME], [PRICE], [AREA], [CAPACITY] )
VALUES
	(N'Phòng đôi', 200000, 25, 2 ),	-- id 1
	(N'Phòng sáu', 150000, 85, 6 )	-- id 2
GO

INSERT INTO [dbo].[ROOM] ([ROOM_ID], [SECTOR_ID], [ROOM_TYPE_ID] )
VALUES
	(N'A101', 'A', 1),
	(N'A102', 'A', 1),
	(N'B101', 'B', 2),
	(N'B102', 'B', 2)
GO

INSERT INTO dbo.UNIT (UNIT_NAME)
VALUES 
	(N'KWh'),	-- id 1
	(N'Khối'),	-- id 2
	(N'Lần')	-- id 3
GO

INSERT INTO [dbo].[SERVICE] ([SERVICE_NAME], [UNIT_ID], [PRICE_PER_UNIT], [STATUS])
VALUES
	(N'Điện', 1, 3000, 1),
	(N'Nước', 2, 2500, 1),
	(N'Đổ rác', 3, 10000, 1)
GO

EXEC dbo.USP_InsetBill @Employee_ID = 2,                     -- bigint
                       @Room_Name = N'A101',                     -- nvarchar(10)
                       @Sector_Name = N'Khu A',                   -- nvarchar(50)
                       @Create_date = '2020-12-04', -- datetime
                       @Month = 10,                           -- int
                       @Year = 2021,                            -- int
                       @Status = 0,                       -- bit
                       @total = 20                         -- decimal(19, 4)



	