USE [DormitoryManagement]
GO

INSERT INTO [dbo].[SECTOR] ([SECTOR_ID], [SECTOR_NAME])
VALUES 
	('A', N'Khu A'),
	('B', N'Khu B'),
	('C', N'Khu C'),
	('D', N'Khu D')
GO

INSERT INTO [dbo].[ROOM_TYPE] ( [ROOM_TYPE_NAME], [PRICE], [AREA], [CAPACITY] )
VALUES
	(N'Phòng đôi', 200000, 25, 2),		-- id 1
	(N'Phòng sáu', 150000, 85, 6),		-- id 2
	(N'Phòng tám', 100000, 100, 8),		-- id 3
	(N'Phòng mười hai', 90000, 140, 12)	-- id 4
GO

INSERT INTO [dbo].[ROOM] ([ROOM_ID], [SECTOR_ID], [ROOM_TYPE_ID] )
VALUES
	(N'A101', 'A', 1),
	(N'A102', 'A', 1),
	(N'A103', 'A', 1),
	(N'B101', 'B', 2),
	(N'B102', 'B', 2),
	(N'C101', 'C', 3),
	(N'C102', 'C', 3),
	(N'C103', 'C', 3),
	(N'C104', 'C', 3),
	(N'D101', 'D', 4)
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


INSERT INTO [dbo].[ADDRESS] ([STREET], [COMMNUNE_ID], [DISTRICT_ID], [PROVINCE_ID])
VALUES
	(N'1 Võ Văn Ngân', '00001', '001', '79'),
    (N'2 Đường ABC', '26764', '761', '79'),
    (N'3 Đường ABC', '26803', '762', '79'),
    (N'4 Đường ABC', '26833', '763', '79'), 
    (N'5 Đường ABC', '26767', '761', '79'),
    (N'6 Đường ABC', '27052', '768', '79'),
    (N'7 Đường ABC', '27130', '770', '79'),
    (N'8 Đường ABC', '26734', '760', '79'),
    (N'9 Đường ABC', '26923', '765', '79'),
    (N'10 Đường XYZ', '26882', '764', '79'),
    (N'11 Đường XYZ', '26971', '766', '79'),
    (N'12 Đường XYZ', '27058', '768', '79'),
    (N'13 Đường XYZ', '27226', '772', '79'),
    (N'14 Đường XYZ', '26809', '762', '79'),
    (N'15 Đường XYZ', '26929', '765', '79')
GO


INSERT INTO [dbo].[USER] ([LAST_NAME], [FIRST_NAME], [DOB], [GENDER], [SSN], [ADDRESS_ID], [PHONE_NUMBER_1], [PHONE_NUMBER_2], [EMAIL], [USERNAME], [PASSWORD], [USER_TYPE], [STATUS])
VALUES
(   N'',       -- LAST_NAME - nvarchar(40)
    N'',       -- FIRST_NAME - nvarchar(20)
    GETDATE(), -- DOB - date
    N'',       -- GENDER - nvarchar(5)
    '',        -- SSN - varchar(12)
    0,         -- ADDRESS_ID - bigint
    '',        -- PHONE_NUMBER_1 - varchar(15)
    '',        -- PHONE_NUMBER_2 - varchar(15)
    '',        -- EMAIL - varchar(40)
    '',        -- IMAGE_PATH - varchar(300)
    '',        -- USERNAME - varchar(16)
    '',        -- PASSWORD - varchar(32)
    '',        -- USER_TYPE - varchar(10)
    NULL       -- STATUS - bit
    )
GO

EXEC dbo.USP_AddEmployee @LAST_NAME = N'Lâm',           -- nvarchar(40)
	                     @FIRST_NAME = N'Khánh',          -- nvarchar(20)
	                     @DOB = '2000-09-02',        -- date
	                     @GENDER = N'Nam',              -- nvarchar(5)
	                     @SSN = '072200004503',                  -- varchar(12)
	                     @PHONE_NUMBER_1 = '0949494029',       -- varchar(15)
	                     @PHONE_NUMBER_2 = '0969696029',       -- varchar(15)
	                     @EMAIL = 'quockhanhdev@gmail.com',                -- varchar(40)
	                     @IMAGE_PATH = '',           -- varchar(300)
	                     @USER_TYPE = 'EMPLOYEE',            -- varchar(10)
	                     @PROVINCE_NAME = N'Tây Ninh',       -- nvarchar(20)
	                     @DISTRICT_NAME = N'Gò Dầu',       -- nvarchar(40)
	                     @COMMUNE_NAME = N'Bàu Đồn',        -- nvarchar(40)
	                     @STREET = N'Đường tỉnh 782',              -- nvarchar(50)
	                     @STATR_DATE = '2020-12-23', -- date
	                     @SALARY = NULL              -- decimal(19, 4)
GO
EXEC dbo.USP_CREATE_LOGIN_USER @Role_Name = 'EMPLOYEE',     -- varchar(50)
                               @Login_Name = '072200004503',    -- varchar(50)
                               @Password_Login = 'dbms000000' -- varchar(50)


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



	