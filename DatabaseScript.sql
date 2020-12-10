USE master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'DormitoryManagement')
BEGIN
	ALTER DATABASE [DormitoryManagement] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE IF EXISTS [DormitoryManagement]
END
GO

CREATE DATABASE [DormitoryManagement]
GO

USE [DormitoryManagement]
GO

-- TỈNH/ TP
CREATE TABLE [dbo].[PROVINCE] (
	[PROVINCE_ID] VARCHAR(2) NOT NULL,
	[PROVINCE_NAME] NVARCHAR(20) NOT NULL,
	[PROVINCE_TYPE] VARCHAR(1) NOT NULL,				-- C: thành phố trực thuộc trung ương, P: tỉnh

	CONSTRAINT [PK_PROVINCE] PRIMARY KEY([PROVINCE_ID]),
)
GO

-- HUYỆN/ QUẬN
CREATE TABLE [dbo].[DISTRICT] (
	[DISTRICT_ID] VARCHAR(3) NOT NULL,
	[DISTRICT_NAME] NVARCHAR(40) NOT NULL,
	[DISTRICT_TYPE] VARCHAR(1) NOT NULL, 				-- C: thành phố trực thuộc tỉnh, D: quận, H: huyện, T: thị xã
	[PROVINCE_ID] VARCHAR(2) NOT NULL,

	CONSTRAINT [PK_DISTRICT] PRIMARY KEY([DISTRICT_ID]),
	CONSTRAINT [FK_DISTRICT_PROVINCE] FOREIGN KEY ([PROVINCE_ID]) REFERENCES [PROVINCE]([PROVINCE_ID]),
)
GO

-- XÃ/ PHƯỜNG
CREATE TABLE [dbo].[COMMUNE] (
	[COMMUNE_ID] VARCHAR(5) NOT NULL,
	[COMMUNE_NAME] NVARCHAR(40) NOT NULL,
	[COMMUNE_TYPE] VARCHAR(1) NOT NULL, 				-- W: Phường, V: xã, T: thị trấn
	[PRIORITY] VARCHAR(6) NOT NULL DEFAULT N'KV3', 		-- độ ưu tiên (KV1, KV2, KV2-NT, KV3)
	[DISTRICT_ID] VARCHAR(3) NOT NULL,

	CONSTRAINT [PK_COMMUNE] PRIMARY KEY([COMMUNE_ID]),
	CONSTRAINT [FK_COMMUNE_DISTRICT] FOREIGN KEY ([DISTRICT_ID]) REFERENCES [DISTRICT]([DISTRICT_ID]),
)
GO


-- ĐỊA CHỈ
CREATE TABLE [dbo].[ADDRESS] (
	[ADDRESS_ID] BIGINT IDENTITY(1, 1),
	[STREET] NVARCHAR(50) NULL,
	[COMMNUNE_ID] VARCHAR(5) NOT NULL,
	[DISTRICT_ID] VARCHAR(3) NOT NULL,
	[PROVINCE_ID] VARCHAR(2) NOT NULL,

	CONSTRAINT [PK_ADDRESS] PRIMARY KEY([ADDRESS_ID]),
	CONSTRAINT [FK_ADDRESS_COMMUNE] FOREIGN KEY ([COMMNUNE_ID]) REFERENCES [COMMUNE]([COMMUNE_ID]),
	CONSTRAINT [FK_ADDRESS_DISTRICT] FOREIGN KEY ([DISTRICT_ID]) REFERENCES [DISTRICT]([DISTRICT_ID]),
	CONSTRAINT [FK_ADDRESS_PROVINCE] FOREIGN KEY ([PROVINCE_ID]) REFERENCES [PROVINCE]([PROVINCE_ID]),
)
GO

-- TRƯỜNG CAO ĐẲNG/ ĐẠI HỌC
CREATE TABLE [dbo].[COLLEGE] (
	[COLLEGE_ID] INT IDENTITY(1, 1) NOT NULL,
	[COLLEGE_CODE] VARCHAR(5) NULL, 				-- MÃ TRƯỜNG SPK, BKU
	[COLLEGE_NAME] NVARCHAR(100) NOT NULL,

	CONSTRAINT [PK_COLLEGE] PRIMARY KEY ([COLLEGE_ID])
)
GO

-- BẢO HIỂM Y TẾ
CREATE TABLE [dbo].[INSURANCE] (
	[INSURANCE_ID] VARCHAR(15) NOT NULL,
	[BASE_PRACTICE] NVARCHAR(50) NULL, 			-- NƠI ĐĂNG KÝ KHÁM CHỮA BỆNH BAN ĐẦU
	[REGISTRATION_DATE] DATE NULL,				-- NGÀY ĐĂNG KÝ
	[DURATION] INT NULL,						-- THỜI HẠN SỬ DỤNG (SỐ THÁNG)

	CONSTRAINT [PK_INSURANCE] PRIMARY KEY([INSURANCE_ID]),
)
GO

-- LƯU TÀI KHẢON ĐĂNG NHẬP VÀ THÔNG TIN NGƯỜI DÙNG
CREATE TABLE [dbo].[USER] (
	[USER_ID] BIGINT IDENTITY(1, 1) NOT NULL,
	[LAST_NAME] NVARCHAR(40) NOT NULL,
	[FIRST_NAME] NVARCHAR(20) NOT NULL,
	[DOB] DATE NOT NULL,								-- NGÀY SINH
	[GENDER] NVARCHAR(5) NOT NULL,						-- GIỚI TÍNH
	[SSN] VARCHAR(12) NULL, 							-- CHỨNG MINH NHÂN DÂN

	[ADDRESS_ID] BIGINT NOT NULL,
	[PHONE_NUMBER_1] VARCHAR(15) NULL,					-- SỐ ĐIỆN THOẠI 1
	[PHONE_NUMBER_2] VARCHAR(15) NULL,					-- SỐ ĐIỆN THOẠI 2
	[EMAIL] VARCHAR(40) NULL,
	[IMAGE_PATH] VARCHAR(300) NULL,

	[USERNAME] VARCHAR(16) NOT NULL,
	[PASSWORD] VARCHAR(32) NOT NULL,
	[USER_TYPE] VARCHAR(10) NOT NULL DEFAULT 'STUDENT',	-- ADMIN: TK QUẢN TRỊ, EMPLOYEE: NHÂN VIÊN, STUDENT: SINH VIÊN, RELATIVE: NGƯỜI THÂN
	[STATUS] BIT DEFAULT 1 NOT NULL
)
GO

ALTER TABLE dbo.[USER] ADD CONSTRAINT [PK_USER] PRIMARY KEY([USER_ID])
ALTER TABLE dbo.[USER] ADD CONSTRAINT [FK_USER_ADDRESS] FOREIGN KEY ([ADDRESS_ID]) REFERENCES [ADDRESS]([ADDRESS_ID])
ALTER TABLE dbo.[USER] ADD CONSTRAINT [USERNAME_UNINE] UNIQUE(USERNAME)
ALTER TABLE dbo.[USER] ADD CONSTRAINT [PK_UNIQUE] UNIQUE(SSN)
GO

-- Set nullable unique for column email
CREATE UNIQUE NONCLUSTERED INDEX IDX_USER_MAIL_Unique_Nullable ON [dbo].[User]([EMAIL]) WHERE [EMAIL] IS NOT NULL
CREATE UNIQUE NONCLUSTERED INDEX IDX_USER_PHONENUMBER1_Unique_Nullable ON [dbo].[USER]([PHONE_NUMBER_1]) WHERE [PHONE_NUMBER_1] IS NOT NULL
CREATE UNIQUE NONCLUSTERED INDEX IDX_USER_PHONENUMBER2_Unique_Nullable ON [dbo].[USER]([PHONE_NUMBER_2]) WHERE [PHONE_NUMBER_2] IS NOT NULL
GO

-- QUẢN TRỊ - ADMIN
CREATE TABLE [dbo].[ADMIN] (
	[USER_ID] BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES

	CONSTRAINT [PK_ADMIN] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_ADMIN_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
)
GO

-- NHÂN VIÊN QUẢN LÝ
CREATE TABLE [dbo].[EMPLOYEE] (
	[USER_ID] BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES
	[START_DATE] DATE DEFAULT GETDATE(),
	[SALARY] DECIMAL(19, 4),

	CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_EMPLOYEE_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	--CONSTRAINT [FK_EMPLOYEE_ADMIN] FOREIGN KEY ([MANAGER_ID]) REFERENCES [ADMIN]([USER_ID]),
)
GO

-- STUDENT
CREATE TABLE [dbo].[STUDENT] (
	[USER_ID] BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES
	
	[STUDENT_ID] VARCHAR(15) NOT NULL,		-- MÃ SỐ SINH VIÊN, KHÔNG DÙNG ĐỂ REFERENCES
	[COLLEGE_ID] INT NOT NULl,				-- TRƯỜNG
	[FACULTY] NVARCHAR(50),					-- KHOA
	[MAJORS] NVARCHAR(50),					-- NGÀNH HỌC

	[INSURANCE_ID] VARCHAR(15) NOT NULL,	-- MÃ SỐ BẢO HIỂM
	
	CONSTRAINT [PK_STUDENT] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_STUDENT_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	CONSTRAINT [FK_STUDENT_COLLEGE] FOREIGN KEY ([COLLEGE_ID]) REFERENCES [COLLEGE]([COLLEGE_ID]),
	CONSTRAINT [FK_STUDENT_INSURANCE] FOREIGN KEY ([INSURANCE_ID]) REFERENCES [INSURANCE]([INSURANCE_ID]),
)
GO

-- THÂN NHÂN
CREATE TABLE [dbo].[RELATIVE] (
	[USER_ID] BIGINT NOT NULL,						-- USER_ID ĐỊNH DANH LẤY USER ĐỂ LƯU THÔNG TIN (ID CỦA NGƯỜI THÂN)
	[RELATIVE_USER_ID] BIGINT NOT NULL,				-- USER_ID CỦA SINH VIÊN/ NHÂN VIÊN/ ADMIN
	[RELATIONSHIP] NVARCHAR(20),					-- QUAN HỆ
	
	CONSTRAINT [PK_RELATIVE] PRIMARY KEY([USER_ID], [RELATIVE_USER_ID]),
	CONSTRAINT [FK_RELATIVE_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	CONSTRAINT [FK_RELATIVE_USER_DESC] FOREIGN KEY ([RELATIVE_USER_ID]) REFERENCES [USER]([USER_ID]),
)
GO

-- KHU VỰC
CREATE TABLE [dbo].[SECTOR] (
	[SECTOR_ID] VARCHAR(10) NOT NULL,
	[SECTOR_NAME] NVARCHAR(50),

	CONSTRAINT [PK_SECTOR] PRIMARY KEY([SECTOR_ID]), 
)
GO

-- LOẠI PHÒNGG
CREATE TABLE [dbo].[ROOM_TYPE] (
	[ROOM_TYPE_ID] INT IDENTITY(1, 1),
	[ROOM_TYPE_NAME] NVARCHAR(20),
	[PRICE] DECIMAL(19, 4),
	[AREA] DECIMAL(8, 2),				-- DIỆN TÍCH
	[CAPACITY] INT,						-- SỨC CHỨA

	CONSTRAINT [PK_ROOM_TYPE] PRIMARY KEY ([ROOM_TYPE_ID]),
)
GO

-- PHÒNG
CREATE TABLE [dbo].[ROOM] (
	[ROOM_ID] NVARCHAR(10) NOT NULL,
	[SECTOR_ID] VARCHAR(10) NOT NULL,
	[ROOM_TYPE_ID] INT NOT NULL,

	CONSTRAINT [PK_ROOM] PRIMARY KEY ([ROOM_ID]),
	CONSTRAINT [FK_ROOM_SECTOR] FOREIGN KEY ([SECTOR_ID]) REFERENCES [SECTOR]([SECTOR_ID]),
	CONSTRAINT [PK_ROOM_ROOM_TYPE] FOREIGN KEY ([ROOM_TYPE_ID]) REFERENCES [ROOM_TYPE]([ROOM_TYPE_ID]),
)
GO

-- ĐƠN VỊ
CREATE TABLE [dbo].[UNIT] (
	[UNIT_ID] INT IDENTITY(1, 1),
	[UNIT_NAME] NVARCHAR(50),

	CONSTRAINT [PK_UNIT] PRIMARY KEY([UNIT_ID]),
)

-- DỊCH VỤ
CREATE TABLE [dbo].[SERVICE] (
	[SERVICE_ID] INT IDENTITY(1, 1),		-- MÃ DV
	[SERVICE_NAME] NVARCHAR(50),			-- TÊN DV
	[UNIT_ID] INT NOT NULL,					-- 
	[PRICE_PER_UNIT] DECIMAL(19, 4),		-- ĐƠN GIÁ
	[STATUS] BIT DEFAULT 1, 				-- TRẠNG THÁI 1: CÒN, 0: ẨN(XÓA)

	CONSTRAINT [PK_SERVICE] PRIMARY KEY ([SERVICE_ID]),
	CONSTRAINT [FK_SERVICE_UNIT] FOREIGN KEY ([UNIT_ID]) REFERENCES [UNIT]([UNIT_ID]),
)
GO

-- HÓA ĐƠN
CREATE TABLE [dbo].[BILL] (
	[BILL_ID] BIGINT IDENTITY(1, 1),
	[EMPLOYEE_ID] BIGINT NOT NULL,
	[ROOM_ID] NVARCHAR(10) NOT NULL,
	[CREATE_TIME] DATETIME DEFAULT GETDATE(),
	[TOTAL] DECIMAL(19, 4),	

	[SECTOR_ID] VARCHAR(10),
	[STATUS] BIT  DEFAULT 0,
	[MONTH] INT,
	[YEAR] INT,

	CONSTRAINT [PK_BILL] PRIMARY KEY ([BILL_ID]),
	CONSTRAINT [FK_BILL_EMPLOYEE] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [EMPLOYEE]([USER_ID]),
	CONSTRAINT [FK_BILL_ROOM] FOREIGN KEY ([ROOM_ID]) REFERENCES [ROOM]([ROOM_ID]),
)
GO

ALTER TABLE [dbo].[BILL] ADD CONSTRAINT [FK_BILL_SECTOR] FOREIGN KEY ([SECTOR_ID]) REFERENCES [SECTOR] ([SECTOR_ID])
GO 


-- CHI TIẾT HÓA ĐƠN
CREATE TABLE [dbo].[BILL_DETAIL] (
	[BILL_DETAIL_ID] BIGINT IDENTITY(1, 1),
	[BILL_ID] BIGINT NOT NULL,
	[SERVICE_ID] INT NOT NULL,
	[OLD_QUANTITY] INT NOT NULL,			-- SỐ CŨ
	[NEW_QUANTITY] INT NOT NULL,			-- SỐ MỚI

	CONSTRAINT [PK_BILL_DETAIL] PRIMARY KEY ([BILL_DETAIL_ID], [BILL_ID]),
	CONSTRAINT [FK_BILL_DETAIL_BILL] FOREIGN KEY ([BILL_ID]) REFERENCES [BILL]([BILL_ID]),
	CONSTRAINT [FK_BILL_DETAIL_SERVICE] FOREIGN KEY ([SERVICE_ID]) REFERENCES [SERVICE]([SERVICE_ID]),
)
GO

-- THANH TOÁN
CREATE TABLE [dbo].[PAYMENT] (
	[PAYMENT_ID] BIGINT IDENTITY(1, 1),				
	[BILL_ID] BIGINT NOT NULL,					 	-- MẢ HÓA ĐƠN
	[EMPLOYEE_ID] BIGINT NOT NULL,					-- MÃ NHÂN VIÊN NHẬN TIỀN
	[PAYING_DATE] DATETIME DEFAULT GETDATE(),		-- NGÀY THANH TOÁN
	[AMOUNT] DECIMAL(19, 4), 						-- SỐ TIỀN

	CONSTRAINT [PK_PAYMENT] PRIMARY KEY ([PAYMENT_ID], [BILL_ID]),
	CONSTRAINT [FK_PAYMENT_BILL] FOREIGN KEY ([BILL_ID]) REFERENCES [BILL]([BILL_ID]),
	CONSTRAINT [FK_PAYMENT_EMPLOYEE] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [EMPLOYEE]([USER_ID]),
)
GO

-- ĐĂNG KÍ PHÒNG
CREATE TABLE [dbo].[ROOM_REGISTRATION]
(
	[ROOM_REGISTRATION_ID] BIGINT IDENTITY(1, 1),
	[SSN] VARCHAR(12) NOT NULL,
	[ROOM_ID] NVARCHAR(10) NOT NULL,
	[EMPLOYEE_ID] BIGINT NOT NULL,
	[SECTOR_ID] VARCHAR(10) NOT NULL,
	[START_DATE] DATETIME DEFAULT GETDATE(),
	[SEMESTER] INT,
	[ACADEMIC_YEAR] INT,
	[DURATION] NVARCHAR(20),
	[STATUS] BIT DEFAULT 0
	
	CONSTRAINT [PK_ROOM_REGISTRATION] PRIMARY KEY ([ROOM_REGISTRATION_ID]),
	CONSTRAINT [FK_ROOM_ID] FOREIGN KEY ([ROOM_ID]) REFERENCES [dbo].[ROOM]([ROOM_ID]),
	CONSTRAINT [FK_EMPLOYEE_ID] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [dbo].[EMPLOYEE]([USER_ID]),
	CONSTRAINT [FK_SECTOR_ID] FOREIGN KEY ([SECTOR_ID]) REFERENCES [dbo].[SECTOR]([SECTOR_ID]),
)
GO


----------------------
-- VIEW
----------------------

-- Tạo view tỉnh
CREATE OR ALTER VIEW [V_PROVINCE] AS
	SELECT 
		P.PROVINCE_ID,
		CASE
			WHEN P.PROVINCE_TYPE = 'C' THEN CONCAT(N'Thành phố ', P.PROVINCE_NAME)
			ELSE CONCAT(N'Tỉnh ', P.PROVINCE_NAME)
		END AS PROVINCE_NAME ,
		P.PROVINCE_TYPE
	FROM [dbo].[PROVINCE] AS P
GO

-- Tạo view huyện
CREATE OR ALTER VIEW [V_DISTRICT] AS
	SELECT 
		D.DISTRICT_ID,
		CASE
			WHEN D.DISTRICT_TYPE = 'C' THEN CONCAT(N'Thành phố ', D.DISTRICT_NAME)
			WHEN D.DISTRICT_TYPE = 'D' THEN CONCAT(N'Quận ', D.DISTRICT_NAME)
			WHEN D.DISTRICT_TYPE = 'T' THEN CONCAT(N'Thị xã ', D.DISTRICT_NAME)
			ELSE CONCAT(N'Huyện ', D.DISTRICT_NAME)
		END AS DISTRICT_NAME,
		D.PROVINCE_ID,
		D.DISTRICT_TYPE
	FROM [dbo].[DISTRICT] AS D
GO

-- Tạo view xã, phường
CREATE OR ALTER VIEW [V_COMMUNE] AS
	SELECT 
		C.COMMUNE_ID,
		CASE
			WHEN C.COMMUNE_TYPE = 'T' THEN CONCAT(N'Thị trấn ', C.COMMUNE_NAME)
			WHEN C.COMMUNE_TYPE = 'W' THEN CONCAT(N'Phường ', C.COMMUNE_NAME)
			ELSE CONCAT(N'Xã ', C.COMMUNE_NAME)
		END AS COMMUNE_NAME,
		C.COMMUNE_TYPE,
		C.PRIORITY,
		C.DISTRICT_ID
	FROM [dbo].[COMMUNE] AS C
GO

-- Tạo view địa chỉ
CREATE OR ALTER VIEW [V_ADDRESS] AS
	SELECT A.ADDRESS_ID, A.STREET, P.PROVINCE_NAME, D.DISTRICT_NAME, C.COMMUNE_NAME
	FROM [dbo].[ADDRESS] AS A
		INNER JOIN [dbo].[V_PROVINCE] AS P ON P.PROVINCE_ID = A.PROVINCE_ID
		INNER JOIN [dbo].[V_DISTRICT] AS D ON D.DISTRICT_ID = A.DISTRICT_ID
		INNER JOIN [dbo].[V_COMMUNE] AS C ON C.COMMUNE_ID = A.COMMNUNE_ID
GO

-- Tạo view nhân viên
CREATE OR ALTER VIEW [V_EMPLOYEE] AS
	SELECT 
		U.[USER_ID], 
		U.LAST_NAME, 
		U.FIRST_NAME, 
		CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS [FULL_NAME],
		U.DOB,
		U.GENDER,
		U.SSN,

		A.STREET,
		A.PROVINCE_NAME,
		A.DISTRICT_NAME,
		A.COMMUNE_NAME,

		U.PHONE_NUMBER_1,
		U.PHONE_NUMBER_2,
		U.EMAIL,

		E.[START_DATE],
		E.SALARY

	FROM [dbo].[USER] AS U 
		INNER JOIN [dbo].[V_ADDRESS] AS A ON A.ADDRESS_ID = U.ADDRESS_ID
		INNER JOIN [dbo].[EMPLOYEE] AS E ON E.[USER_ID] = U.[USER_ID]
GO

-- Tạo view sinh viên
CREATE OR ALTER VIEW [V_STUDENT] AS
	SELECT 
		U.[USER_ID], 
		U.LAST_NAME, 
		U.FIRST_NAME, 
		CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS [FULL_NAME],
		U.DOB,
		U.GENDER,
		U.SSN,

		A.STREET,
		A.PROVINCE_NAME,
		A.DISTRICT_NAME,
		A.COMMUNE_NAME,

		U.PHONE_NUMBER_1,
		U.PHONE_NUMBER_2,
		U.EMAIL,

		S.STUDENT_ID,
		C.COLLEGE_NAME,
		S.FACULTY,
		S.MAJORS

	FROM [dbo].[USER] AS U 
		INNER JOIN [dbo].[V_ADDRESS] AS A ON A.ADDRESS_ID = U.ADDRESS_ID
		INNER JOIN [dbo].[STUDENT] AS S ON S.[USER_ID] = U.[USER_ID]
		INNER JOIN [dbo].[COLLEGE] AS C ON C.COLLEGE_ID = S.COLLEGE_ID
GO

-- Tạo view sinh viên general
CREATE OR ALTER VIEW [V_STUDENTGENERAL] AS
	SELECT 
		U.[USER_ID],  
		CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS [FULL_NAME],
		U.DOB,
		U.GENDER,
		U.SSN,


		U.PHONE_NUMBER_1,
		U.EMAIL,

		S.STUDENT_ID,
		C.COLLEGE_NAME

	FROM [dbo].[USER] AS U 
		INNER JOIN [dbo].[V_ADDRESS] AS A ON A.ADDRESS_ID = U.ADDRESS_ID
		INNER JOIN [dbo].[STUDENT] AS S ON S.[USER_ID] = U.[USER_ID]
		INNER JOIN [dbo].[COLLEGE] AS C ON C.COLLEGE_ID = S.COLLEGE_ID
GO
-- Tạo view room regestration
CREATE OR ALTER VIEW [V_ROOM_REGISTRATION] AS
	SELECT 
		RR.ROOM_REGISTRATION_ID AS [Id],
		
		S.SECTOR_NAME AS [Building],
		R.ROOM_ID AS [Room],
		STU.STUDENT_ID AS [Student Id],
		STU.FULL_NAME AS [Student Name],

		E.USER_ID AS [Employee Id],
		E.FULL_NAME AS [Employee Name],

		RR.START_DATE AS [Start date],
		RR.DURATION AS [Duration]
		
	FROM [dbo].[ROOM_REGISTRATION] AS RR
		INNER JOIN [dbo].[SECTOR] AS S ON S.SECTOR_ID = RR.SECTOR_ID
		INNER JOIN [dbo].[ROOM] AS R ON R.ROOM_ID = RR.ROOM_ID
		INNER JOIN (
			SELECT U.SSN, S.STUDENT_ID, CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS FULL_NAME
			FROM [dbo].[STUDENT] AS S 
				INNER JOIN [dbo].[USER] AS U ON U.[USER_ID] = S.[USER_ID]
 		) AS STU ON STU.SSN = RR.SSN
		INNER JOIN (
			SELECT E.[USER_ID], CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS FULL_NAME
			FROM [dbo].[EMPLOYEE] AS E 
				INNER JOIN [dbo].[USER] AS U ON U.[USER_ID] = E.[USER_ID]
		) AS E ON E.USER_ID = RR.EMPLOYEE_ID
GO

----------------------
-- FUNCTION
----------------------
-- Generate mật khẩu:
CREATE OR ALTER FUNCTION UFN_GenerateMD5 (@OldPass VARCHAR(32))
	RETURNS VARCHAR(32)
AS
BEGIN
	RETURN CONVERT(VARCHAR(32), HashBytes('MD5', @OldPass), 2)
END
GO

-- Hàm lấy mã tỉnh bằng tên tỉnh:
CREATE OR ALTER FUNCTION UFN_GetProvinceIdByProvinceName (@PROVINCE_NAME NVARCHAR(20))
	RETURNS VARCHAR(2)
AS
BEGIN
	DECLARE @PROVINCE_ID VARCHAR(2)
	SELECT @PROVINCE_ID = PROVINCE_ID FROM dbo.PROVINCE WHERE PROVINCE_NAME = @PROVINCE_NAME
	RETURN @PROVINCE_ID
END
GO

-- Hàm lấy mã huyện bằng tên huyện:
CREATE OR ALTER FUNCTION UFN_GetDistrictIdByDictrictName(@DISTRICT_NAME NVARCHAR(40),@PROVINCE_ID VARCHAR(2))
RETURNS VARCHAR(3)
AS
BEGIN
	DECLARE @DISTRICT_ID VARCHAR(3)
	SELECT @DISTRICT_ID = DISTRICT_ID FROM dbo.DISTRICT WHERE DISTRICT_NAME = @DISTRICT_NAME AND PROVINCE_ID = @PROVINCE_ID
	RETURN @DISTRICT_ID
END
GO

-- Hàm tạo mật khẩu mặt định
CREATE OR ALTER FUNCTION UFN_NewPassword(@lastPassword VARCHAR(32), @preFix VARCHAR(4), @size INT)
RETURNS VARCHAR(10)
AS
	BEGIN
	    IF (@lastPassword = '')
			SET @lastPassword = @preFix + REPLICATE(0, @size - LEN(@preFix))
		DECLARE @newPassword VARCHAR(32)
		SET @lastPassword = LTRIM(RTRIM(@lastPassword))
		SET @size = @size - LEN(@preFix)
		SET @newPassword = @preFix + REPLICATE(0, @size - LEN(@preFix))
		RETURN @newPassword
	END
GO


-- Lấy Commune_ID từ Commune_Name----------
CREATE OR ALTER FUNCTION UFN_GetCommuneidByCommuneName
(
	@Commune_Name NVARCHAR(40),
	@Distric_ID VARCHAR(3)
)
RETURNS VARCHAR(3)
AS
BEGIN
	DECLARE @COMMUNE_ID VARCHAR(5)
	SELECT @COMMUNE_ID = COMMUNE_ID FROM dbo.COMMUNE WHERE COMMUNE_NAME = @Commune_Name AND DISTRICT_ID = @Distric_ID
	RETURN @COMMUNE_ID
END
GO


-- Lấy Bill ID -- GET_BILL_ID_BY_SECTORNAME_ROOMID_MONTH_YEAR
CREATE OR ALTER FUNCTION UFN_GetBillIdBySectornameRoomidMonthYear
(
	@Sector_Name VARCHAR(10),
	@Room_ID NVARCHAR(10), 
	@Month INT, 
	@Year INT
)
RETURNS INT
AS
BEGIN
	DECLARE @Sector_ID VARCHAR(10), 
			@Bill_ID INT
	SELECT @Sector_ID = dbo.SECTOR.SECTOR_ID FROM dbo.SECTOR WHERE dbo.SECTOR.SECTOR_NAME = @Sector_Name
	SELECT @Bill_ID = dbo.BILL.BILL_ID FROM dbo.BILL WHERE dbo.BILL.Sector_ID = @Sector_ID
														AND dbo.BILL.ROOM_ID = @Room_ID
														AND dbo.BILL.MONTH = @Month
														AND dbo.BILL.YEAR = @Year 
    RETURN @Bill_ID
END
GO

-- Lấy chỉ số mới của tháng trước đó của Bill 
CREATE OR ALTER FUNCTION [dbo].[UFN_GetOldQuantityForNewBill]
(
	@Sector_ID VARCHAR(10), 
	@Room_ID NVARCHAR(10), 
	@Month INT, @Year INT, 
	@Service_Name NVARCHAR(20)
)
RETURNS INT
AS
BEGIN
	DECLARE @Name NVARCHAR(20), 
			@Quantity INT
	SET @Name = @Service_Name
	SELECT @Quantity = dbo.BILL_DETAIL.NEW_QUANTITY
	FROM dbo.BILL INNER JOIN dbo.BILL_DETAIL ON BILL_DETAIL.BILL_ID = BILL.BILL_ID INNER JOIN dbo.SERVICE ON SERVICE.SERVICE_ID = BILL_DETAIL.SERVICE_ID
	WHERE dbo.BILL.Sector_ID = @Sector_ID
   AND dbo.BILL.ROOM_ID = @Room_ID
   AND dbo.BILL.MONTH = @Month
   AND dbo.BILL.YEAR = @Year
   AND dbo.SERVICE.SERVICE_NAME =  @Service_Name
   IF @Quantity IS NULL
       SET @Quantity = 0
   RETURN @Quantity
END
GO

--Trả về số lượng sinh viên đã đăng lý vào phòng nào đó
CREATE OR ALTER FUNCTION UFN_CountNumberOfStudentInRoom
(
	@Sector_ID VARCHAR(10),
	@Room_ID NVARCHAR(10)
)
RETURNS INT
AS BEGIN
		DECLARE @Number INT
        SELECT @Number = COUNT(dbo.ROOM_REGISTRATION.SSN)
		FROM dbo.ROOM_REGISTRATION
		WHERE ROOM_REGISTRATION.SECTOR_ID = @Sector_ID
		AND ROOM_REGISTRATION.ROOM_ID = @Room_ID
		RETURN @Number
END
GO

-- Tạo hàm tìm tên gần đúng
CREATE OR ALTER FUNCTION [dbo].[SearchLike] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput 
	IF @strInput = '' RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý 
	ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy 
	AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 INT 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
				SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +
				SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK 
			END 
		SET @COUNTER1 = @COUNTER1 +1 
	END 
	SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO


-- lấy danh sách sinh viên theo status
-- status = 0 : outgoing, 
-- status = 1 : alive, 
-- status = 2 : all status 

CREATE OR ALTER FUNCTION UFN_GetListStudent (@STATUS INT)
RETURNS @Result TABLE (
	[Id] BIGINT NOT NULL,
	[Full name] NVARCHAR(51) NULL,
	[Date of birth] DATE,
	[Gender] VARCHAR(5),
	[Ssn] VARCHAR(12),
	[Phone number] VARCHAR(15),
	[Email] VARCHAR(40),
	[Student Id] VARCHAR(15) NOT NULL,
	[College] NVARCHAR(100) NOT NULL
)
AS
BEGIN
	INSERT @Result
    SELECT 
		U.[USER_ID] AS [Id],
		CONCAT(U.LAST_NAME, ' ', U.FIRST_NAME) AS [Full name],
		U.DOB AS [Date of birth],
		U.GENDER AS [Gender],
		U.SSN,

		U.PHONE_NUMBER_1 AS [Phone number],
		U.EMAIL AS [Email],

		S.STUDENT_ID AS [Student Id],
		C.COLLEGE_NAME AS [College]

	FROM [dbo].[USER] AS U 
		INNER JOIN [dbo].[V_ADDRESS] AS A ON A.ADDRESS_ID = U.ADDRESS_ID
		INNER JOIN [dbo].[STUDENT] AS S ON S.[USER_ID] = U.[USER_ID]
		INNER JOIN [dbo].[COLLEGE] AS C ON C.COLLEGE_ID = S.COLLEGE_ID
	WHERE U.[STATUS] = @STATUS OR @STATUS = 2

	RETURN
END
GO

----------------------
-- PROC
----------------------

-- Dùng để Insert dữ liệu từ file Excel
CREATE OR ALTER PROCEDURE [USP_INSERT_COMMUNE]
	@COMMUNE_ID VARCHAR(5),
	@COMMUNE_NAME NVARCHAR(40),
	@COMMUNE_TYPE VARCHAR(1), 
	@DISTRICT_ID VARCHAR(3),
	@DISTRICT_NAME NVARCHAR(40),
	@DISTRICT_TYPE VARCHAR(1),
	@PROVINCE_ID VARCHAR(2),
	@PROVINCE_NAME NVARCHAR(20),
	@PROVINCE_TYPE VARCHAR(1)
AS BEGIN
	DECLARE @IS_EXITS INT

	-- Kiểm tra tỉnh có tồn tại hay không, nếu không thì insert record mới
	SELECT @IS_EXITS = COUNT(*) FROM [dbo].[PROVINCE] WHERE [PROVINCE_ID] = @PROVINCE_ID
	IF @IS_EXITS = 0
	BEGIN
		INSERT INTO [dbo].[PROVINCE] ([PROVINCE_ID], [PROVINCE_NAME], [PROVINCE_TYPE])
		VALUES (@PROVINCE_ID, @PROVINCE_NAME, @PROVINCE_TYPE)
	END

	-- Kiểm tra huyện có tồn tại hay không, nếu không thì insert record mới
	SELECT @IS_EXITS = COUNT(*) FROM [dbo].DISTRICT WHERE [DISTRICT_ID] = @DISTRICT_ID
	IF @IS_EXITS = 0
	BEGIN
		INSERT INTO [dbo].[DISTRICT] ( [DISTRICT_ID], [DISTRICT_NAME], [DISTRICT_TYPE], [PROVINCE_ID] )
		VALUES (@DISTRICT_ID, @DISTRICT_NAME, @DISTRICT_TYPE, @PROVINCE_ID)
	END

	-- Kiểm tra xã có tồn tại hay không, nếu không thì insert record mới
	SELECT @IS_EXITS = COUNT(*) FROM [dbo].[COMMUNE] WHERE [COMMUNE_ID] = @COMMUNE_ID
	IF @IS_EXITS = 0
	BEGIN
		INSERT INTO [dbo].[COMMUNE] ( [COMMUNE_ID], [COMMUNE_NAME], [COMMUNE_TYPE], [DISTRICT_ID] )
		VALUES (@COMMUNE_ID, @COMMUNE_NAME, @COMMUNE_TYPE, @DISTRICT_ID)
	END
END
GO

-- Dùng để đăng nhập:
CREATE OR ALTER PROC USP_Login
	@USERNAME VARCHAR(16), 
	@PASSWORD VARCHAR(32)
AS
BEGIN
	DECLARE @PASSWORD_GENERATE VARCHAR(32)
	SET @PASSWORD_GENERATE = dbo.UFN_GenerateMD5(@PASSWORD)

	SELECT * FROM dbo.[USER] WHERE USERNAME = @USERNAME COLLATE SQL_Latin1_General_CP1_CS_AS
	AND PASSWORD = @PASSWORD_GENERATE COLLATE SQL_Latin1_General_CP1_CS_AS -- Phân biệt chữ hoa chữ thường
END
GO

-- Dùng để lấy người dùng bằng username.
CREATE OR ALTER PROC USP_GetUserByUsername
	@USERNAME VARCHAR(16)
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USERNAME = @USERNAME
END
GO

-- Dùng để lấy người dùng bằng id.
CREATE OR ALTER PROC USP_GetUserById
	@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy sinh viên bằng id.
CREATE OR ALTER PROC USP_GetStudentById
	@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.STUDENT WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy quản trị viên bằng id.
CREATE OR ALTER PROC USP_GetAdminById
	@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.ADMIN WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy nhân viên bằng id.
CREATE OR ALTER PROC USP_GetEmployeeById
	@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.EMPLOYEE WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy Province.
CREATE OR ALTER PROC USP_GetListProvince
AS
BEGIN
	SELECT * FROM dbo.PROVINCE
END
GO

-- Dùng để lấy quận, huyện bằng tên tỉnh.
CREATE OR ALTER PROC USP_GetListDistrictByProvinceName
	@PROVINCE_NAME NVARCHAR(20)
AS
BEGIN
	DECLARE @PROVINCE_ID VARCHAR(2)
	SET @PROVINCE_ID = dbo.UFN_GetProvinceIdByProvinceName(@PROVINCE_NAME)
	SELECT * FROM dbo.DISTRICT WHERE PROVINCE_ID = @PROVINCE_ID
END
GO

-- Dùng để lấy xã, phường bằng của huyện bằng tỉnh, huyện.
CREATE OR ALTER PROC USP_GetListCommuneByProvinceAndDistrict
	@PROVINCE_NAME NVARCHAR(20),
	@DISTRICT_NAME NVARCHAR(40)
AS
BEGIN
	DECLARE @PROVINCE_ID VARCHAR(2)
	DECLARE @DISTRICT_ID VARCHAR(3)
	SET @PROVINCE_ID = dbo.UFN_GetProvinceIdByProvinceName(@PROVINCE_NAME)
	SET @DISTRICT_ID = dbo.UFN_GetDistrictIdByDictrictName(@DISTRICT_NAME,@PROVINCE_ID)
	SELECT * FROM dbo.COMMUNE WHERE DISTRICT_ID = @DISTRICT_ID
END
GO

-- Dùng để lấy danh sách quản trị viên.
CREATE OR ALTER PROC USP_GetListAdmin
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USER_TYPE = 'ADMIN'
END
GO

-- Dùng để thêm nhân viên
CREATE OR ALTER PROC USP_AddEmployee
	@LAST_NAME NVARCHAR(40),
	@FIRST_NAME NVARCHAR(20),
	@DOB DATE,
	@GENDER NVARCHAR(5),
	@SSN VARCHAR(12),
	@PHONE_NUMBER_1 VARCHAR(15),
	@PHONE_NUMBER_2 VARCHAR(15),
	@EMAIL VARCHAR(40),
	@IMAGE_PATH VARCHAR(300),
	@USER_TYPE VARCHAR(10),
	@PROVINCE_NAME NVARCHAR(20),
	@DISTRICT_NAME NVARCHAR(40),
	@COMMUNE_NAME NVARCHAR(40),
	@STREET NVARCHAR(50),
	@STATR_DATE DATE, 
	@SALARY DECIMAL(19,4)
AS
BEGIN
	-- Tạo ra biến
	DECLARE @PROVINCE_ID VARCHAR(2)
	DECLARE @DISTRICT_ID VARCHAR(3)
	DECLARE @COMMUNE_ID VARCHAR(5)
	DECLARE @ADDRESS_ID BIGINT
	DECLARE @USER_ID BIGINT
	-- Gán dữ liệu cho 3 biến
	SET @PROVINCE_ID = dbo.UFN_GetProvinceIdByProvinceName(@PROVINCE_NAME)
	SET @DISTRICT_ID = dbo.UFN_GetDistrictIdByDictrictName(@DISTRICT_NAME,@PROVINCE_ID)
	SELECT @COMMUNE_ID = COMMUNE_ID FROM dbo.COMMUNE WHERE DISTRICT_ID = @DISTRICT_ID AND COMMUNE_NAME = @COMMUNE_NAME
	-- Thêm địa chỉ
	INSERT INTO dbo.[ADDRESS] (STREET,COMMNUNE_ID,DISTRICT_ID,PROVINCE_ID)
	VALUES (@STREET,@COMMUNE_ID,@DISTRICT_ID,@PROVINCE_ID)
	-- Lấy ra mã địa chỉ
	SET @ADDRESS_ID = ( SELECT TOP 1 ADDRESS_ID FROM dbo.[ADDRESS] ORDER BY ADDRESS_ID DESC)
	--Thêm vào bảng User
	INSERT INTO dbo.[USER] (LAST_NAME, FIRST_NAME, DOB, GENDER, SSN, ADDRESS_ID, PHONE_NUMBER_1, PHONE_NUMBER_2, EMAIL, IMAGE_PATH, USERNAME, PASSWORD, USER_TYPE, STATUS)
	VALUES (@LAST_NAME, @FIRST_NAME, @DOB,@GENDER, @SSN,@ADDRESS_ID, @PHONE_NUMBER_1, @PHONE_NUMBER_2, @EMAIL, @IMAGE_PATH, @SSN,'', @USER_TYPE, 1)
	-- Lấy ra User vừa được thêm vào
	SET @USER_ID = (SELECT TOP 1 USER_ID FROM dbo.[USER] ORDER BY USER_ID DESC)
	-- Thêm vào bảng nhân viên
	INSERT INTO dbo.[EMPLOYEE] (USER_ID, START_DATE, SALARY)
	VALUES(@USER_ID, @STATR_DATE, @SALARY)
END
GO
-- Dùng để thay đổi mật khẩu
CREATE OR ALTER PROC USP_ChangePassword
	@USER_ID BIGINT,
	@NEWPASS VARCHAR(32)
AS
BEGIN
	DECLARE @newPassword VARCHAR(32)
	SET @newPassword = dbo.UFN_GenerateMD5(@NEWPASS)
	UPDATE dbo.[USER] SET PASSWORD = @newPassword WHERE USER_ID = @USER_ID
END
GO
-- Lấy danh sách phòng
CREATE OR ALTER PROC [dbo].[USP_GetListRoom]
AS
BEGIN
    SELECT * FROM dbo.ROOM
END
GO
-- Lấy danh sách phòng bằng Sector_Id
CREATE OR ALTER PROC [dbo].[USP_GetListRoomBySectorID]
	@Sector_ID VARCHAR(10)
AS
BEGIN
    SELECT * FROM dbo.ROOM
	WHERE dbo.ROOM.SECTOR_ID = @Sector_ID
END
GO

-- Lấy danh sách khu
CREATE OR ALTER PROC [dbo].[USP_GetListSector]
AS
BEGIN
    SELECT * FROM dbo.SECTOR
END
GO

--Lấy danh sách dịch vụ
CREATE OR ALTER PROC [dbo].[USP_GetListService]
AS
BEGIN
	SELECT * FROM dbo.SERVICE
END
GO

-- Lấy danh sách đơn vị của dịch vụ
CREATE OR ALTER PROC [dbo].[GetUnitByServiceName]
	@Service_name NVARCHAR(60)
AS
BEGIN
    SELECT dbo.UNIT.UNIT_NAME, dbo.UNIT.UNIT_ID
    FROM dbo.SERVICE, dbo.UNIT 
    WHERE dbo.SERVICE.UNIT_ID = dbo.UNIT.UNIT_ID 
		AND SERVICE_NAME = @Service_name
END
GO

-- Dùng để thêm địa chỉ
CREATE OR ALTER PROC [dbo].[USP_INSERT_ADDRESS]
(
	@Street NVARCHAR(50), 
	@Commune_Name NVARCHAR(50), 
	@District_Name NVARCHAR(50),
	@Province_Name NVARCHAR(50)
)
AS
BEGIN
    DECLARE @Commune_ID VARCHAR(5),
			@District_ID VARCHAR(3),
			@Province_ID VARCHAR(2)

	SELECT @Province_ID = dbo.UFN_GetProvinceIdByProvinceName(@Province_Name)
	SELECT @District_ID = dbo.UFN_GetDistrictIdByDictrictName(@District_Name, @Province_ID)
	SELECT @Commune_ID = dbo.UFN_GetCommuneidByCommuneName(@Commune_Name,@District_ID)

	INSERT INTO dbo.ADDRESS (STREET, COMMNUNE_ID, DISTRICT_ID, PROVINCE_ID)
	VALUES (@Street, @Commune_ID, @District_ID, @Province_ID )
END
GO

-- Thêm Bill
CREATE OR ALTER PROC [dbo].[USP_InsetBill]
(
	@Employee_ID BIGINT, 
	@Room_Name NVARCHAR(10), 
	@Sector_Name NVARCHAR(50), 
	@Create_date DATETIME, 
	@Month INT, 
	@Year INT, 
	@Status BIT, 
	@total DECIMAL(19,4)
)
AS
BEGIN
	DECLARE @Room_ID NVARCHAR(10), @Sector_ID VARCHAR(10)
	SELECT @Sector_ID = dbo.SECTOR.SECTOR_ID FROM dbo.SECTOR WHERE dbo.SECTOR.SECTOR_NAME = @Sector_Name

	SELECT @Room_ID = dbo.ROOM.ROOM_ID FROM dbo.ROOM 
	WHERE dbo.ROOM.SECTOR_ID = @Sector_ID
		AND dbo.ROOM.ROOM_ID = @Room_Name 

    INSERT INTO dbo.BILL(EMPLOYEE_ID, ROOM_ID, CREATE_TIME, TOTAL, STATUS, MONTH, YEAR, Sector_ID) 
	VALUES (@Employee_ID, @Room_ID, @Create_date, @total, @Status, @Month, @Year, @Sector_ID)
END
GO

-- Thêm dịch vụ  vào chi tiết hóa đơn
CREATE OR ALTER PROC [dbo].[USP_INSERT_SERVICE_BILL_DETAIL]
(
	@Service_Name NVARCHAR(20), 
	@Quantity INT,
	@Sector_Name VARCHAR(10), 
	@Room_ID NVARCHAR(10),
	@Month INT, 
	@Year INT
)
AS
BEGIN
	DECLARE @Bill_ID BIGINT, 
			@Service_ID INT, 
			@Old_Quantity INT,
			@New_Quantity INT, 
			@Sector_ID NVARCHAR(20)

	SELECT @Bill_ID = (SELECT MAX(dbo.BILL.BILL_ID) FROM dbo.BILL)
	SELECT @Sector_ID = dbo.SECTOR.SECTOR_ID FROM dbo.SECTOR WHERE dbo.SECTOR.SECTOR_NAME = @Sector_Name
	SET @Month = @Month - 1

	IF(@Month = 0)
	BEGIN
	    SET @Month = 12
		SET @Year = @Year -1
	END

	SELECT @Service_ID = dbo.SERVICE.SERVICE_ID FROM dbo.SERVICE WHERE dbo.SERVICE.SERVICE_NAME = @Service_Name
	SET @Old_Quantity = dbo.UFN_get_New_Quantity_For_New_Bill(@Sector_ID,@Room_ID,@Month,@Year,@Service_Name)
	SET @New_Quantity = @Old_Quantity + @Quantity

    INSERT INTO dbo.BILL_DETAIL(BILL_ID, SERVICE_ID, OLD_QUANTITY, NEW_QUANTITY)
	VALUES (@Bill_ID, @Service_ID, @Old_Quantity, @New_Quantity)
END
GO

-- Thanh toán
CREATE OR ALTER PROC [dbo].[USP_INSERT_PAYMENT]
(
	@Employee_ID INT, 
	@Paying_Date DATETIME, 
	@Amount DECIMAL(19,4),
	@Sector_Name VARCHAR(10),
	@Room_ID NVARCHAR(10), 
	@Month INT, 
	@Year INT
)
AS
BEGIN
    DECLARE @Bill_ID INT
	SET @Bill_ID = dbo.UFN_GetBillIdBySectornameRoomidMonthYear(@Sector_Name,@Room_ID,@Month,@Year)

	INSERT INTO dbo.PAYMENT (BILL_ID, EMPLOYEE_ID, PAYING_DATE, AMOUNT)
	VALUES (@Bill_ID, @Employee_ID, @Paying_Date, @Amount)
END
GO

-- Lấy danh sách sinh viên general
CREATE OR ALTER PROC USP_GetListStudentGeneral
AS
BEGIN
	SELECT  * FROM dbo.UFN_GetListStudent(2)
END
GO

-- Lấy danh sách sinh viên general Alive
CREATE OR ALTER PROC USP_GetListStudentGeneralALive
AS
BEGIN
    SELECT  * FROM dbo.UFN_GetListStudent(1)
END
GO

-- Lấy danh sách sinh viên general Alive
CREATE OR ALTER PROC USP_GetListStudentGeneralGoingOut
AS
BEGIN
    SELECT * FROM dbo.UFN_GetListStudent(0)
END
GO

-- Tìm kiếm gần đúng sinh viên bởi userId
CREATE OR ALTER PROC USP_GetListStudentGeneralByUserId(@USER_ID VARCHAR(10))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](USER_ID) 
	LIKE N'%' + dbo.[SearchLike](@USER_ID) + '%'
END
GO
-- Tìm kiếm gần đúng sinh viên bởi StudentId
CREATE OR ALTER PROC USP_GetListStudentGeneralByStudentId(@STUDENT_ID VARCHAR(15))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](STUDENT_ID) 
	LIKE N'%' + dbo.[SearchLike](@STUDENT_ID) + '%'
END
GO
-- Tìm kiếm gần đúng sinh viên bởi FullName
CREATE OR ALTER PROC USP_GetListStudentGeneralByFullName(@FULL_NAME NVARCHAR(100))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](FULL_NAME) 
	LIKE N'%' + dbo.[SearchLike](@FULL_NAME) + '%'
END
GO
-- Tìm kiếm gần đúng sinh viên bởi Gender
CREATE OR ALTER PROC USP_GetListStudentGeneralByGender(@GENDER NVARCHAR(10))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](GENDER) 
	LIKE N'%' + dbo.[SearchLike](@GENDER) + '%'
END
GO
-- Tìm kiếm gần đúng sinh viên bởi Ssn
CREATE OR ALTER PROC USP_GetListStudentGeneralBySsn (@SSN VARCHAR(12))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](SSN) 
	LIKE N'%' + dbo.[SearchLike](@SSN) + '%'
END
GO
-- Tìm kiếm gần đúng sinh viên bởi Gender
CREATE OR ALTER PROC USP_GetListStudentGeneralByCollegeName(@COLLEGE_NAME NVARCHAR(150))
AS BEGIN

	SELECT * FROM dbo.V_STUDENTGENERAL WHERE dbo.[SearchLike](COLLEGE_NAME) 
	LIKE N'%' + dbo.[SearchLike](@COLLEGE_NAME) + '%'
END
GO
-- Lấy danh sách user
CREATE OR ALTER PROC USP_GetListUser
AS BEGIN
	SELECT * FROM dbo.[USER]
END
GO
-- Lấy danh sách Room_Registration
CREATE OR ALTER PROC USP_GetListRoomRegistration
AS BEGIN
	SELECT * FROM dbo.V_ROOM_REGISTRATION
END
GO
-- Lấy danh sách Room_Registration bằng StudentId
CREATE OR ALTER PROC USP_GetListRoomRegistrationByStudentId(@STUDENT_ID VARCHAR(15))
AS BEGIN
	SELECT * FROM dbo.V_ROOM_REGISTRATION WHERE dbo.[SearchLike]([Student Id]) 
	LIKE N'%' + dbo.[SearchLike](@STUDENT_ID) + '%'
END
GO
-- Lấy danh sách Room_Registration bằng StudentName
CREATE OR ALTER PROC USP_GetListRoomRegistrationByStudentName(@STUDENT_NAME NVARCHAR(100))
AS BEGIN
	SELECT * FROM dbo.V_ROOM_REGISTRATION WHERE dbo.[SearchLike]([Student Name]) 
	LIKE N'%' + dbo.[SearchLike](@STUDENT_NAME) + '%'
END
GO

-- Lấy danh sách Room_Registration bằng Sector và room
CREATE OR ALTER PROC USP_GetListRoomRegistrationBySectorAndRoom(
	@SECTOR_NAME NVARCHAR(50),
	@ROOM_ID NVARCHAR(10)
	)
AS BEGIN
	SELECT * FROM dbo.V_ROOM_REGISTRATION WHERE Building = @SECTOR_NAME AND Room = @ROOM_ID
END
GO

------------TRIGGER
----------------------
----------------------
-- Thay đổi mật khẩu mặt định
CREATE TRIGGER TRG_DefaultPassword ON [dbo].[USER]
FOR INSERT
AS
	BEGIN
	    DECLARE @lass_USER_ID BIGINT
		DECLARE @newPassword VARCHAR(32)
		SET @lass_USER_ID= ( SELECT TOP 1 USER_ID FROM dbo.[USER] ORDER BY USER_ID DESC)
		SET @newPassword = dbo.UFN_NewPassword('','dbms',32)
		SET @newPassword = dbo.UFN_GenerateMD5(@newPassword)
		UPDATE dbo.[USER] SET PASSWORD = @newPassword WHERE USER_ID = @lass_USER_ID
	END
GO
-- Cập nhật trạng thái tại bẳng hóa đơn bằng 1 (đã thanh toán) -- nếu hóa đơn đó đã thanh toán thì thông báo "this bill has been paid"
CREATE OR ALTER TRIGGER TRG_INSERT_PAYMENT
ON dbo.PAYMENT
FOR INSERT
AS
	DECLARE @Bill_ID INT
	SELECT @Bill_ID = Inserted.BILL_ID FROM Inserted
	IF(@Bill_ID IN (SELECT dbo.BILL.BILL_ID FROM dbo.BILL WHERE dbo.BILL.STATUS = 1))
	BEGIN
	    RAISERROR(N'This bill has been paid',16,1)
		ROLLBACK
	END
	ELSE
	BEGIN
	    UPDATE dbo.BILL
		SET STATUS = 1 WHERE dbo.BILL.BILL_ID = @Bill_ID
	END
GO

-------------------------------------------------------------------------------------------

-- Insert thông tin trường cao đẳng đại học
SET IDENTITY_INSERT [dbo].[COLLEGE] ON 

INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES 
	(1, N'ANS', N'Đại Học An Ninh Nhân Dân'),
	(2, N'BVS', N'Học Viện Công Nghệ Bưu Chính Viễn Thông (phía Nam)'),
	(3, N'CSS', N'Đại Học Cảnh Sát Nhân Dân'),
	(4, N'DCT', N'Đại Học Công Nghiệp Thực Phẩm TPHCM'),
	(5, N'DKC', N'Đại học Công Nghệ TPHCM'),
	(6, N'DLS', N'Đại Học Lao Động – Xã Hội ( Cơ sở phía Nam)'),
	(7, N'DMS', N'Đại Học Tài Chính Marketing'),
	(8, N'DNT', N'Đại Học Ngoại Ngữ – Tin Học TPHCM'),
	(9, N'DSD', N'Đại Học Sân Khấu, Điện Ảnh TPHCM'),
	(10, N'DSG', N'Đại Học Công Nghệ Sài Gòn'),
	(11, N'DTM', N'ĐH Tài Nguyên môi trường TPHCM'),
	(12, N'DTT', N'Đại Học Tôn Đức Thắng'),
	(13, N'DVH', N'Đại Học Văn Hiến'),
	(14, N'DVL', N'Đại Học Văn Lang'),
	(15, N'GDU', N'Đại Học Gia Định'),
	(16, N'GSA', N'Đại Học Giao Thông Vận Tải ( Cơ sở Phía Nam)'),
	(17, N'GTS', N'Đại Học Giao Thông Vận Tải TPHCM'),
	(18, N'HCS', N'Học Viện Hành Chính Quốc Gia (phía Nam)'),
	(19, N'HHK', N'Học Viện Hàng Không Việt Nam'),
	(20, N'HIU', N'Đại Học Quốc Tế Hồng Bàng'),
	(21, N'HSU', N'Đại Học Hoa Sen'),
	(22, N'IUH', N'Đại Học Công Nghiệp TPHCM'),
	(23, N'KSA', N'Đại Học Kinh Tế TPHCM'),
	(24, N'KTS', N'Đại Học Kiến Trúc TPHCM'),
	(25, N'LPS', N'Đại Học Luật TPHCM'),
	(26, N'MBS', N'Đại Học Mở TPHCM'),
	(27, N'MTS', N'Đại Học Mỹ Thuật TPHCM'),
	(28, N'NHS', N'Đại Học Ngân Hàng TPHCM'),
	(29, N'NLS', N'Đại Học Nông Lâm TPHCM'),
	(30, N'NTS', N'Đại Học Ngoại Thương (phía Nam)'),
	(31, N'NTT', N'Đại Học Nguyễn Tất Thành'),
	(32, N'NVS', N'Nhạc Viện TPHCM'),
	(33, N'PCS', N'Đại Học Phòng Cháy Chữa Cháy (phía Nam)'),
	(34, N'PCS1', N'Đại Học Phòng Cháy Chữa Cháy (Hệ Dân sự Phía Nam)'),
	(35, N'QSB', N'Đại Học Bách Khoa – Đại Học Quốc Gia TPHCM'),
	(36, N'QSC', N'Đại Học Công Nghệ Thông Tin – Đại Học Quốc Gia TPHCM'),
	(37, N'QSK', N'Đại học Kinh Tế – Luật – Đại Học Quốc Gia TPHCM'),
	(38, N'QSQ', N'Đại Học Quốc Tế – Đại Học Quốc Gia TPHCM'),
	(39, N'QST', N'Đại Học Khoa Học Tự Nhiên – Đại Học Quốc Gia TPHCM'),
	(40, N'QSX', N'Đại Học Khoa Học Xã Hội và Nhân Văn – Đại Học Quốc Gia TPHCM'),
	(41, N'QSY', N'Khoa Y - Đại học Quốc Gia TPHCM'),
	(42, N'RMU', N'Đại Học Quốc Tế RMIT Việt Nam'),
	(43, N'SGD', N'Đại Học Sài Gòn'),
	(44, N'SIU', N'Đại Học Quốc Tế Sài Gòn'),
	(45, N'SPK', N'Đại Học Sư Phạm Kỹ Thuật TPHCM'),
	(46, N'SPS', N'Đại Học Sư Phạm TPHCM'),
	(47, N'STS', N'Đại Học Sư Phạm Thể DụcThể Thao TPHCM'),
	(48, N'TDS', N'Đại Học Thể Dục Thể Thao TPHCM'),
	(49, N'TLS', N'Đại Học Thủy Lợi ( Cơ sở 2 )'),
	(50, N'TYS', N'Đại Học Y Khoa Phạm Ngọc Thạch'),
	(51, N'UEF', N'Đại Học Kinh Tế -Tài Chính TPHCM'),
	(52, N'VGU', N'Đại Học Việt Đức'),
	(53, N'VHS', N'Đại Học Văn Hóa TPHCM'),
	(54, N'VPH', N'Trường Sĩ Quan Kĩ Thuật Quân Sự - Hệ Quân sự - Đại Học Trần Đại Nghĩa'),
	(55, N'YDS', N'Đại Học Y Dược TPHCM'),
	(56, N'ZPH', N'Trường Sĩ Quan Kĩ Thuật Quân Sự - Hệ Dân sự - Đại Học Trần Đại Nghĩa'),
	(57, N'CBC', N'Cao Đẳng Bán Công Công Nghệ và Quản Trị Doanh Nghiệp'),
	(58, N'CBV', N'Cao Đẳng Bách Việt'),
	(59, N'CCO', N'Cao Đẳng Công Nghệ Thủ Đức'),
	(60, N'CCS', N'Cao Đẳng Kinh Tế Kỹ Thuật Vinatex TPHCM'),
	(61, N'CDE', N'Cao Đẳng Điện Lực TPHCM'),
	(62, N'CDV', N'Cao Đẳng Viễn Đông'),
	(63, N'CEP', N'Cao Đẳng Kinh Tế TPHCM'),
	(64, N'CES', N'Cao Đẳng Công Thương TPHCM'),
	(65, N'CET', N'Cao Đẳng Kinh Tế-Công Nghệ TPHCM'),
	(66, N'CGS', N'Cao Đẳng Giao Thông Vận Tải 3'),
	(67, N'CGT', N'Cao Đẳng Giao Thông Vận Tải TPHCM'),
	(68, N'CKC', N'Cao Đẳng Kỹ Thuật Cao Thắng'),
	(69, N'CKD', N'Cao Đẳng Kinh Tế Đối Ngoại'),
	(70, N'CKM', N'Cao Đẳng Kinh Tế Kỹ Thuật Miền Nam'),
	(71, N'CKP', N'Cao Đẳng Kỹ Thuật Lý Tự Trọng TPHCM'),
	(72, N'CM3', N'Cao Đẳng Sư Phạm Trung Ương TPHCM'),
	(73, N'CPL', N'Cao Đẳng Kinh Tế Kỹ Thuật TP HCM'),
	(74, N'CPS', N'Cao Đẳng Phát Thanh Truyền Hình II'),
	(75, N'CTS', N'Cao Đẳng Tài Chính Hải Quan'),
	(76, N'CVN', N'Cao Đẳng Văn Hóa Nghệ Thuật TPHCM'),
	(77, N'CVS', N'Cao Đẳng Văn Hóa Nghệ Thuật và Du Lịch Sài Gòn'),
	(78, N'CVX', N'Cao Đẳng Kỹ Thuật-Công Nghệ Vạn Xuân'),
	(79, N'CXS', N'Cao Đẳng Xây Dựng Số 2')
SET IDENTITY_INSERT [dbo].[COLLEGE] OFF
=======
	SELECT @Bill_ID = (SELECT MAX(dbo.PAYMENT.BILL_ID) FROM dbo.PAYMENT)
	UPDATE dbo.BILL
	SET STATUS = 1 WHERE dbo.BILL.BILL_ID = @Bill_ID
>>>>>>> 2e367214c4336cb64199e4d6cf409ec5993eae7b
GO