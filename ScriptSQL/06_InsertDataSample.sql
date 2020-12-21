USE [DormitoryManagement]
GO

INSERT INTO dbo.ADDRESS (STREET, COMMNUNE_ID, DISTRICT_ID, PROVINCE_ID)
VALUES 
	(N'Thôn Trì Bình', '21043', '524', '51' )	--id 1
GO

INSERT INTO dbo.[USER] ( LAST_NAME, FIRST_NAME, DOB, GENDER, SSN, ADDRESS_ID, USERNAME, PASSWORD, USER_TYPE)
VALUES
	(N'Hồ Huy', N'Hoàng', '19991223', N'Male', '212860117', 1, 'admin', '12', 'ADMIN')
GO

UPDATE dbo.[USER] SET PASSWORD='C20AD4D76FE97759AA27A0C99BFF6710' WHERE USERNAME='admin' 

INSERT INTO [dbo].[SECTOR] ( [SECTOR_ID], [SECTOR_NAME])
VALUES 
	('A', N'Khu A'),
	('B', N'Khu B'),
	('C', N'Khu C'),
	('D', N'Khu D'),
	('E', N'Khu E'),
	('F', N'Khu F'),
	('TT', N'Khu Trung Tâm'),
	('X', N'Khu Nhà Xưởng'),
	('TH', N'Khu Tầng Hầm')
GO



INSERT INTO [dbo].[ROOM_TYPE] ( [ROOM_TYPE_NAME], [PRICE], [AREA], [CAPACITY] )
VALUES
	(N'Phòng 2', 1000000, 25, 2 ),	-- id 1
	(N'Phòng 6', 400000, 85, 6 ),	-- id 2
	(N'Phòng 8', 300000, 100, 8 ),	-- id 3
	(N'Phòng 2 máy lạnh', 1200000, 25, 2 ),	-- id 4
	(N'Phòng 6 máy lạnh', 500000, 85, 6 ),	-- id 5
	(N'Phòng 8 máy lạnh', 350000, 100, 8 )	-- id 6
GO

INSERT INTO [dbo].[ROOM] ([ROOM_ID], [SECTOR_ID], [ROOM_TYPE_ID] )
VALUES
	(N'A101', 'A', 1),
	(N'A102', 'A', 1),
	(N'A103', 'A', 1),
	(N'A104', 'A', 1),
	(N'A105', 'A', 1),
	(N'A106', 'A', 1),
	(N'A201', 'A', 1),
	(N'A202', 'A', 1),
	(N'A203', 'A', 1),
	(N'A204', 'A', 1),
	(N'A205', 'A', 1),
	(N'A206', 'A', 1),
	(N'A301', 'A', 1),
	(N'A302', 'A', 1),
	(N'A303', 'A', 1),
	(N'A304', 'A', 1),
	(N'A305', 'A', 1),
	(N'A306', 'A', 1),
	(N'B101', 'B', 2),
	(N'B102', 'B', 2),
	(N'B103', 'B', 2),
	(N'B104', 'B', 2),
	(N'B105', 'B', 2),
	(N'B106', 'B', 2),
	(N'B201', 'B', 2),
	(N'B202', 'B', 2),
	(N'B203', 'B', 2),
	(N'B204', 'B', 2),
	(N'B205', 'B', 2),
	(N'B206', 'B', 2),
	(N'B301', 'B', 2),
	(N'B302', 'B', 2),
	(N'B303', 'B', 2),
	(N'B304', 'B', 2),
	(N'B305', 'B', 2),
	(N'B306', 'B', 2),
	(N'C101', 'C', 3),
	(N'C102', 'C', 3),
	(N'C103', 'C', 3),
	(N'C104', 'C', 3),
	(N'C105', 'C', 3),
	(N'C106', 'C', 3),
	(N'C201', 'C', 3),
	(N'C202', 'C', 3),
	(N'C203', 'C', 3),
	(N'C204', 'C', 3),
	(N'C205', 'C', 3),
	(N'C206', 'C', 3),
	(N'C301', 'C', 3),
	(N'C302', 'C', 3),
	(N'C303', 'C', 3),
	(N'C304', 'C', 3),
	(N'C305', 'C', 3),
	(N'C306', 'C', 3),
	(N'D101', 'D', 4),
	(N'D102', 'D', 4),
	(N'D103', 'D', 4),
	(N'D104', 'D', 4),
	(N'D105', 'D', 4),
	(N'D106', 'D', 4),
	(N'D201', 'D', 4),
	(N'D202', 'D', 4),
	(N'D203', 'D', 4),
	(N'D204', 'D', 4),
	(N'D205', 'D', 4),
	(N'D206', 'D', 4),
	(N'D301', 'D', 4),
	(N'D302', 'D', 4),
	(N'D303', 'D', 4),
	(N'D304', 'D', 4),
	(N'D305', 'D', 4),
	(N'D306', 'D', 4)
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
	(N'Nước', 2, 10000, 1),
	(N'Đổ rác', 3, 10000, 1)
GO


	