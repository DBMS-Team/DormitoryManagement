USE master
GO

DROP DATABASE IF EXISTS [DormitoryManagement]
Go

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
DROP TABLE IF EXISTS [dbo].[ADDRESS]
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
	[USER_ID] BIGINT IDENTITY(1, 1),
	[LAST_NAME] NVARCHAR(40),
	[FIRST_NAME] NVARCHAR(20),
	[DOB] DATE,								-- NGÀY SINH
	[GENDER] NVARCHAR(5),					-- GIỚI TÍNH
	[SSN] VARCHAR(12), 						-- CHỨNG MINH NHÂN DÂN

	[ADDRESS_ID] BIGINT NOT NULL,
	[PHONE_NUMBER_1] VARCHAR(15),			-- SỐ ĐIỆN THOẠI 1
	[PHONE_NUMBER_2] VARCHAR(15),			-- SỐ ĐIỆN THOẠI 2
	[EMAIL] VARCHAR(40),
	[IMAGE_PATH] VARCHAR(300),

	[USERNAME] VARCHAR(16),
	[PASSWORD] VARCHAR(32),
	[USER_TYPE] VARCHAR(10),				-- ADMIN: TK QUẢN TRỊ, EMPLOYEE: NHÂN VIÊN, STUDENT: SINH VIÊN, RELATIVE: NGƯỜI THÂN

)
ALTER TABLE dbo.[USER] ADD [STATUS] BIT DEFAULT 1
GO
ALTER TABLE dbo.[USER] ADD CONSTRAINT [PK_USER] PRIMARY KEY([USER_ID])
GO
ALTER TABLE dbo.[USER] ADD CONSTRAINT [FK_USER_ADDRESS] FOREIGN KEY ([ADDRESS_ID]) REFERENCES [ADDRESS]([ADDRESS_ID])
GO
ALTER TABLE dbo.[USER] ADD CONSTRAINT [USERNAME_UNINE] UNIQUE(USERNAME)
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
	[MANAGER_ID] BIGINT NOT NULL,			-- MÃ NGƯỜI QUẢN LÝ

	[START_DATE] DATE DEFAULT GETDATE(),
	[SALARY] DECIMAL(19, 4),

	CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_EMPLOYEE_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	CONSTRAINT [FK_EMPLOYEE_ADMIN] FOREIGN KEY ([MANAGER_ID]) REFERENCES [ADMIN]([USER_ID]),
)
GO
ALTER TABLE dbo.EMPLOYEE DROP CONSTRAINT FK_EMPLOYEE_ADMIN
ALTER TABLE dbo.EMPLOYEE DROP COLUMN MANAGER_ID
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
	CONSTRAINT [PK_BILL] PRIMARY KEY ([BILL_ID]),
	CONSTRAINT [FK_BILL_EMPLOYEE] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [EMPLOYEE]([USER_ID]),
	CONSTRAINT [FK_BILL_ROOM] FOREIGN KEY ([ROOM_ID]) REFERENCES [ROOM]([ROOM_ID]),
)
GO
ALTER TABLE dbo.BILL ADD [STATUS] BIT  DEFAULT 0
GO
ALTER TABLE dbo.BILL ADD [MONTH] INT 
GO
ALTER TABLE dbo.BILL ADD [YEAR] INT 
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
----------------------
-- VIEW
----------------------

----------------------
-- FUNCTION
----------------------
-- Generate mật khẩu:
CREATE FUNCTION UFN_GenerateMD5(@OldPass VARCHAR(32))
RETURNS VARCHAR(32)
AS
BEGIN
	RETURN CONVERT(VARCHAR(32), HashBytes('MD5', @OldPass), 2)
END
GO
-- Hàm lấy mã tỉnh bằng tên tỉnh:
CREATE FUNCTION UFN_GetProvinceIdByProvinceName(@PROVINCE_NAME NVARCHAR(20))
RETURNS VARCHAR(2)
AS
BEGIN
	DECLARE @PROVINCE_ID VARCHAR(2)
	SELECT @PROVINCE_ID = PROVINCE_ID FROM dbo.PROVINCE WHERE PROVINCE_NAME = @PROVINCE_NAME
	RETURN @PROVINCE_ID
END
GO
-- Hàm lấy mã huyện bằng tên huyện:
CREATE FUNCTION UFN_GetDistrictIdByDictrictName(@DISTRICT_NAME NVARCHAR(40),@PROVINCE_ID VARCHAR(2))
RETURNS VARCHAR(3)
AS
BEGIN
	DECLARE @DISTRICT_ID VARCHAR(3)
	SELECT @DISTRICT_ID = DISTRICT_ID FROM dbo.DISTRICT WHERE DISTRICT_NAME = @DISTRICT_NAME AND PROVINCE_ID = @PROVINCE_ID
	RETURN @DISTRICT_ID
END
GO
-- Hàm tạo mật khẩu mặt định
CREATE FUNCTION UFN_NewPassword(@lastPassword VARCHAR(32), @preFix VARCHAR(4), @size INT)
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
DROP FUNCTION dbo.UFN_NewPassword
PRINT(REPLACE('','dbms',32)+1)
PRINT(REPLICATE('',28))
PRINT('dbms' + REPLICATE(0, 32- LEN(4)))
PRINT(dbo.UFN_NewPassword('','dbms',32))
----------------------
-- PROC
----------------------
-- Dùng để Insert dữ liệu từ file Excel
DROP PROCEDURE IF EXISTS [dbo].[USP_INSERT_COMMUNE] 
GO
CREATE PROCEDURE [USP_INSERT_COMMUNE]
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
CREATE PROC USP_Login
@USERNAME VARCHAR(16), @PASSWORD VARCHAR(32)
AS
BEGIN
	DECLARE @PASSWORD_GENERATE VARCHAR(32)
	SET @PASSWORD_GENERATE = dbo.UFN_GenerateMD5(@PASSWORD)

	SELECT * FROM dbo.[USER] WHERE USERNAME = @USERNAME COLLATE SQL_Latin1_General_CP1_CS_AS
	AND PASSWORD = @PASSWORD_GENERATE COLLATE SQL_Latin1_General_CP1_CS_AS -- Phân biệt chữ hoa chữ thường
END
GO
-- Dùng để lấy người dùng bằng username.
CREATE PROC USP_GetUserByUsername
@USERNAME VARCHAR(16)
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USERNAME = @USERNAME
END
GO
-- Dùng để lấy người dùng bằng id.
CREATE PROC USP_GetUserById
@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USER_ID = @USER_ID
END
GO
-- Dùng để lấy sinh viên bằng id.
CREATE PROC USP_GetStudentById
@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.STUDENT WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy quản trị viên bằng id.
CREATE PROC USP_GetAdminById
@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.ADMIN WHERE USER_ID = @USER_ID
END
GO

-- Dùng để lấy nhân viên bằng id.
CREATE PROC USP_GetEmployeeById
@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.EMPLOYEE WHERE USER_ID = @USER_ID
END
GO
-- Dùng để lấy Province.
CREATE PROC USP_GetListProvince
AS
BEGIN
	SELECT * FROM dbo.PROVINCE
END
GO
-- Dùng để lấy quận, huyện bằng tên tỉnh.
CREATE PROC USP_GetListDistrictByProvinceName
@PROVINCE_NAME NVARCHAR(20)
AS
BEGIN
	DECLARE @PROVINCE_ID VARCHAR(2)
	SET @PROVINCE_ID = dbo.UFN_GetProvinceIdByProvinceName(@PROVINCE_NAME)
	SELECT * FROM dbo.DISTRICT WHERE PROVINCE_ID = @PROVINCE_ID
END
GO

-- Dùng để lấy xã, phường bằng của huyện bằng tỉnh, huyện.
CREATE PROC USP_GetListCommuneByProvinceAndDistrict
@PROVINCE_NAME NVARCHAR(20),@DISTRICT_NAME NVARCHAR(40)
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
CREATE PROC USP_GetListAdmin
AS
BEGIN
	SELECT * FROM dbo.[USER] WHERE USER_TYPE = 'ADMIN'
END
GO

-- Dùng để thêm nhân viên
CREATE PROC USP_AddEmployee
@LAST_NAME NVARCHAR(40),@FIRST_NAME NVARCHAR(20),@DOB DATE,@GENDER NVARCHAR(5),@SSN VARCHAR(12),@PHONE_NUMBER_1 VARCHAR(15),
@PHONE_NUMBER_2 VARCHAR(15),@EMAIL VARCHAR(40),@IMAGE_PATH VARCHAR(300),@USER_TYPE VARCHAR(10),
@PROVINCE_NAME NVARCHAR(20),@DISTRICT_NAME NVARCHAR(40),@COMMUNE_NAME NVARCHAR(40),@STREET NVARCHAR(50),
@STATR_DATE DATE, @SALARY DECIMAL(19,4)
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
	INSERT INTO dbo.[USER] (LAST_NAME,FIRST_NAME,DOB,GENDER,SSN,ADDRESS_ID,PHONE_NUMBER_1,PHONE_NUMBER_2,EMAIL,IMAGE_PATH,USERNAME,PASSWORD,USER_TYPE,STATUS)
	VALUES (@LAST_NAME, @FIRST_NAME, @DOB,@GENDER, @SSN,@ADDRESS_ID, @PHONE_NUMBER_1, @PHONE_NUMBER_2, @EMAIL, @IMAGE_PATH, @SSN,'', @USER_TYPE, NULL)
	-- Lấy ra User vừa được thêm vào
	SET @USER_ID = ( SELECT TOP 1 @USER_ID FROM dbo.[USER] ORDER BY USER_ID DESC)
	-- Thêm vào bảng nhân viên
	INSERT INTO dbo.[EMPLOYEE] (USER_ID,START_DATE,SALARY)
	VALUES(@USER_ID,@STATR_DATE,@SALARY)
END
GO

----------------------
-- TRIGGER
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






























































