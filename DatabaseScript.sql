CREATE DATABASE [DormitoryManagement]
GO

USE [DormitoryManagement]
GO

-- TỈNH/ TP
CREATE TABLE [PROVINCE] (
	[PROVINCE_ID] VARCHAR(2) NOT NULL,
	[PROVINCE_NAME] NVARCHAR(20) NOT NULL,
	[PROVINCE_TYPE] VARCHAR(1) NOT NULL,		-- C: thành phố trực thuộc trung ương, P: tỉnh
	[PRIORITY] INT NOT NULL, 					-- độ ưu tiên (khu vực 1, 2, 3)

	CONSTRAINT [PK_PROVINCE] PRIMARY KEY([PROVINCE_ID]),
)
GO

-- HUYỆN/ QUẬN
CREATE TABLE [DISTRICT] (
	[DISTRICT_ID] VARCHAR(3) NOT NULL,
	[DISTRICT_NAME] NVARCHAR(40) NOT NULL,
	[DISTRICT_TYPE] VARCHAR(1) NOT NULL, 		-- C: thành phố trực thuộc tỉnh, D: quận, H: huyện, T: thị xã
	[PROVINCE_ID] VARCHAR(2) NOT NULL,

	CONSTRAINT [PK_DISTRICT] PRIMARY KEY([DISTRICT_ID]),
	CONSTRAINT [FK_DISTRICT_PROVINCE] FOREIGN KEY ([PROVINCE_ID]) REFERENCES [PROVINCE]([PROVINCE_ID]),
)
GO

-- XÃ/ PHƯỜNG
CREATE TABLE [COMMUNE] (
	[COMMUNE_ID] VARCHAR(5) NOT NULL,
	[COMMUNE_NAME] NVARCHAR(40) NOT NULL,
	[COMMUNE_TYPE] VARCHAR(1) NOT NULL, 		-- W: Phường, V: xã, T: thị trấn
	[DISTRICT_ID] VARCHAR(3) NOT NULL,

	CONSTRAINT [PK_COMMUNE] PRIMARY KEY([COMMUNE_ID]),
	CONSTRAINT [FK_COMMUNE_DISTRICT] FOREIGN KEY ([DISTRICT_ID]) REFERENCES [DISTRICT]([DISTRICT_ID]),
)
GO


-- ĐỊA CHỈ
CREATE TABLE [ADDRESS] (
	[ADDRESS_ID] BIGINT IDENTITY(1, 1),
	[STREET] NVARCHAR(50),
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
CREATE TABLE [COLLEGE] (
	[COLLEGE_ID] INT IDENTITY(1, 1) NOT NULL,
	[COLLEGE_CODE] VARCHAR(5), -- MÃ TRƯỜNG SPK, BKU
	[COLLEGE_NAME] NVARCHAR(100),

	CONSTRAINT [PK_COLLEGE] PRIMARY KEY ([COLLEGE_ID])
)
GO

CREATE TABLE [INSURANCE] (
	[INSURANCE_ID] VARCHAR(15) NOT NULL,
	[BASE_PRACTICE] NVARCHAR(50), 			-- NƠI ĐĂNG KÝ KHÁM CHỮA BỆNH BAN ĐẦU
	[REGISTRATION_DATE] DATE,				-- NGÀY ĐĂNG KÝ
	[DURATION] INT,							-- THỜI HẠN SỬ DỤNG (SỐ THÁNG)

	CONSTRAINT [PK_INSURANCE] PRIMARY KEY([INSURANCE_ID]),
)

-- LƯU TÀI KHẢON ĐĂNG NHẬP VÀ THÔNG TIN NGƯỜI DÙNG
CREATE TABLE [USER] (
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

	CONSTRAINT [PK_USER] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_USER_ADDRESS] FOREIGN KEY ([ADDRESS_ID]) REFERENCES [ADDRESS]([ADDRESS_ID]),
)
GO

-- QUẢN TRỊ - ADMIN
CREATE TABLE [ADMIN] (
	[USER_ID] BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES

	CONSTRAINT [PK_ADMIN] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_ADMIN_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
)
GO

-- NHÂN VIÊN QUẢN LÝ
CREATE TABLE [EMPLOYEE] (
	[USER_ID] BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES
	[MANAGER_ID] BIGINT NOT NULL,			-- MÃ NGƯỜI QUẢN LÝ

	[START_DATE] DATE,
	[SALARY] DECIMAL(19, 4),

	CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY([USER_ID]),
	CONSTRAINT [FK_EMPLOYEE_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	CONSTRAINT [FK_EMPLOYEE_ADMIN] FOREIGN KEY ([MANAGER_ID]) REFERENCES [ADMIN]([USER_ID]),
)
GO

-- STUDENT
CREATE TABLE [STUDENT] (
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
CREATE TABLE [RELATIVE] (
	[USER_ID] BIGINT NOT NULL,						-- USER_ID ĐỊNH DANH LẤY USER ĐỂ LƯU THÔNG TIN (ID CỦA NGƯỜI THÂN)
	[RELATIVE_USER_ID] BIGINT NOT NULL,				-- USER_ID CỦA SINH VIÊN/ NHÂN VIÊN/ ADMIN
	[RELATIONSHIP] NVARCHAR(20),					-- QUAN HỆ
	
	CONSTRAINT [PK_RELATIVE] PRIMARY KEY([USER_ID], [RELATIVE_USER_ID]),
	CONSTRAINT [FK_RELATIVE_USER] FOREIGN KEY ([USER_ID]) REFERENCES [USER]([USER_ID]),
	CONSTRAINT [FK_RELATIVE_USER_DESC] FOREIGN KEY ([RELATIVE_USER_ID]) REFERENCES [USER]([USER_ID]),
)
GO

-- KHU VỰC
CREATE TABLE [SECTOR] (
	[SECTOR_ID] VARCHAR(10) NOT NULL,
	[SECTOR_NAME] NVARCHAR(50),

	CONSTRAINT [PK_SECTOR] PRIMARY KEY([SECTOR_ID]), 
)
GO

-- LOẠI PHÒNGG
CREATE TABLE [ROOM_TYPE] (
	[ROOM_TYPE_ID] INT IDENTITY(1, 1),
	[ROOM_TYPE_NAME] NVARCHAR(20),
	[PRICE] DECIMAL(19, 4),
	[AREA] DECIMAL(8, 2),				-- DIỆN TÍCH
	[CAPACITY] INT,						-- SỨC CHỨA

	CONSTRAINT [PK_ROOM_TYPE] PRIMARY KEY ([ROOM_TYPE_ID]),
)
GO


-- PHÒNG
CREATE TABLE [ROOM] (
	[ROOM_ID] NVARCHAR(10) NOT NULL,
	[SECTOR_ID] VARCHAR(10) NOT NULL,
	[ROOM_TYPE_ID] INT NOT NULL,

	CONSTRAINT [PK_ROOM] PRIMARY KEY ([ROOM_ID]),
	CONSTRAINT [FK_ROOM_SECTOR] FOREIGN KEY ([SECTOR_ID]) REFERENCES [SECTOR]([SECTOR_ID]),
	CONSTRAINT [PK_ROOM_ROOM_TYPE] FOREIGN KEY ([ROOM_TYPE_ID]) REFERENCES [ROOM_TYPE]([ROOM_TYPE_ID]),
)
GO

-- ĐƠN VỊ
CREATE TABLE [UNIT] (
	[UNIT_ID] INT IDENTITY(1, 1),
	[UNIT_NAME] NVARCHAR(50),

	CONSTRAINT [PK_UNIT] PRIMARY KEY([UNIT_ID]),
)

-- DỊCH VỤ
CREATE TABLE [SERVICE] (
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
CREATE TABLE [BILL] (
	[BILL_ID] BIGINT IDENTITY(1, 1),
	[EMPLOYEE_ID] BIGINT NOT NULL,
	[ROOM_ID] NVARCHAR(10) NOT NULL,
	[CREATE_TIME] DATETIME DEFAULT GETDATE(),
	[PAYMET_STATUS] NVARCHAR(20),

	CONSTRAINT [PK_BILL] PRIMARY KEY ([BILL_ID]),
	CONSTRAINT [FK_BILL_EMPLOYEE] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [EMPLOYEE]([USER_ID]),
	CONSTRAINT [FK_BILL_ROOM] FOREIGN KEY ([ROOM_ID]) REFERENCES [ROOM]([ROOM_ID]),
)
GO

-- CHI TIẾT HÓA ĐƠN
CREATE TABLE [BILL_DETAIL] (
	[BILL_DETAIL_ID] BIGINT IDENTITY(1, 1),
	[BILL_ID] BIGINT NOT NULL,
	[SERVICE_ID] INT NOT NULL,
	[OLD_QUANTITY] INT NOT NULL,			-- SỐ CŨ
	[NEW_QUANTITY] INT NOT NULL,			-- SỐ MỚI

	CONSTRAINT [PK_BILL_DETAIL] PRIMARY KEY ([BILL_DETAIL_ID], [BILL_ID]),
	CONSTRAINT [FK_BILL_DETAIL_SERVICE] FOREIGN KEY ([SERVICE_ID]) REFERENCES [SERVICE]([SERVICE_ID]),
)
GO

-- THANH TOÁN
CREATE TABLE [PAYMENT] (
	[PAYMENT_ID] BIGINT IDENTITY(1, 1),				
	[BILL_ID] BIGINT NOT NULL,					 	-- MẢ HÓA ĐƠN
	[EMPLOYEE_ID] BIGINT NOT NULL,					-- MÃ NHÂN VIÊN NHẬN TIỀN
	[PAYING_DATE] DATETIME DEFAULT GETDATE(),		-- NGÀY THANH TOÁN
	[AMOUNT] DECIMAL(19, 4), 						-- SỐ TIỀN

	CONSTRAINT [PK_PAYMENT] PRIMARY KEY ([PAYMENT_ID], [BILL_ID]),
	CONSTRAINT [FK_PAYMENT_BILL] FOREIGN KEY ([BILL_ID]) REFERENCES [BILL]([BILL_ID]),
	CONSTRAINT [FK_PAYMENT_EMPLOYEE] FOREIGN KEY ([EMPLOYEE_ID]) REFERENCES [EMPLOYEE]([USER_ID]),
)

-- Insert thông tin trường cao đẳng đại học
SET IDENTITY_INSERT [dbo].[COLLEGE] ON 

INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (1, N'ANS', N'Đại Học An Ninh Nhân Dân')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (2, N'BVS', N'Học Viện Công Nghệ Bưu Chính Viễn Thông (phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (3, N'CSS', N'Đại Học Cảnh Sát Nhân Dân')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (4, N'DCT', N'Đại Học Công Nghiệp Thực Phẩm TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (5, N'DKC', N'Đại học Công Nghệ TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (6, N'DLS', N'Đại Học Lao Động – Xã Hội ( Cơ sở phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (7, N'DMS', N'Đại Học Tài Chính Marketing')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (8, N'DNT', N'Đại Học Ngoại Ngữ – Tin Học TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (9, N'DSD', N'Đại Học Sân Khấu, Điện Ảnh TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (10, N'DSG', N'Đại Học Công Nghệ Sài Gòn')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (11, N'DTM', N'ĐH Tài Nguyên môi trường TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (12, N'DTT', N'Đại Học Tôn Đức Thắng')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (13, N'DVH', N'Đại Học Văn Hiến')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (14, N'DVL', N'Đại Học Văn Lang')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (15, N'GDU', N'Đại Học Gia Định')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (16, N'GSA', N'Đại Học Giao Thông Vận Tải ( Cơ sở Phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (17, N'GTS', N'Đại Học Giao Thông Vận Tải TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (18, N'HCS', N'Học Viện Hành Chính Quốc Gia (phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (19, N'HHK', N'Học Viện Hàng Không Việt Nam')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (20, N'HIU', N'Đại Học Quốc Tế Hồng Bàng')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (21, N'HSU', N'Đại Học Hoa Sen')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (22, N'IUH', N'Đại Học Công Nghiệp TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (23, N'KSA', N'Đại Học Kinh Tế TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (24, N'KTS', N'Đại Học Kiến Trúc TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (25, N'LPS', N'Đại Học Luật TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (26, N'MBS', N'Đại Học Mở TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (27, N'MTS', N'Đại Học Mỹ Thuật TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (28, N'NHS', N'Đại Học Ngân Hàng TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (29, N'NLS', N'Đại Học Nông Lâm TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (30, N'NTS', N'Đại Học Ngoại Thương (phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (31, N'NTT', N'Đại Học Nguyễn Tất Thành')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (32, N'NVS', N'Nhạc Viện TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (33, N'PCS', N'Đại Học Phòng Cháy Chữa Cháy (phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (34, N'PCS1', N'Đại Học Phòng Cháy Chữa Cháy (Hệ Dân sự Phía Nam)')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (35, N'QSB', N'Đại Học Bách Khoa – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (36, N'QSC', N'Đại Học Công Nghệ Thông Tin – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (37, N'QSK', N'Đại học Kinh Tế – Luật – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (38, N'QSQ', N'Đại Học Quốc Tế – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (39, N'QST', N'Đại Học Khoa Học Tự Nhiên – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (40, N'QSX', N'Đại Học Khoa Học Xã Hội và Nhân Văn – Đại Học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (41, N'QSY', N'Khoa Y - Đại học Quốc Gia TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (42, N'RMU', N'Đại Học Quốc Tế RMIT Việt Nam')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (43, N'SGD', N'Đại Học Sài Gòn')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (44, N'SIU', N'Đại Học Quốc Tế Sài Gòn')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (45, N'SPK', N'Đại Học Sư Phạm Kỹ Thuật TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (46, N'SPS', N'Đại Học Sư Phạm TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (47, N'STS', N'Đại Học Sư Phạm Thể DụcThể Thao TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (48, N'TDS', N'Đại Học Thể Dục Thể Thao TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (49, N'TLS', N'Đại Học Thủy Lợi ( Cơ sở 2 )')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (50, N'TYS', N'Đại Học Y Khoa Phạm Ngọc Thạch')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (51, N'UEF', N'Đại Học Kinh Tế -Tài Chính TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (52, N'VGU', N'Đại Học Việt Đức')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (53, N'VHS', N'Đại Học Văn Hóa TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (54, N'VPH', N'Trường Sĩ Quan Kĩ Thuật Quân Sự - Hệ Quân sự - Đại Học Trần Đại Nghĩa')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (55, N'YDS', N'Đại Học Y Dược TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (56, N'ZPH', N'Trường Sĩ Quan Kĩ Thuật Quân Sự - Hệ Dân sự - Đại Học Trần Đại Nghĩa')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (57, N'CBC', N'Cao Đẳng Bán Công Công Nghệ và Quản Trị Doanh Nghiệp')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (58, N'CBV', N'Cao Đẳng Bách Việt')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (59, N'CCO', N'Cao Đẳng Công Nghệ Thủ Đức')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (60, N'CCS', N'Cao Đẳng Kinh Tế Kỹ Thuật Vinatex TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (61, N'CDE', N'Cao Đẳng Điện Lực TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (62, N'CDV', N'Cao Đẳng Viễn Đông')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (63, N'CEP', N'Cao Đẳng Kinh Tế TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (64, N'CES', N'Cao Đẳng Công Thương TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (65, N'CET', N'Cao Đẳng Kinh Tế-Công Nghệ TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (66, N'CGS', N'Cao Đẳng Giao Thông Vận Tải 3')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (67, N'CGT', N'Cao Đẳng Giao Thông Vận Tải TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (68, N'CKC', N'Cao Đẳng Kỹ Thuật Cao Thắng')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (69, N'CKD', N'Cao Đẳng Kinh Tế Đối Ngoại')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (70, N'CKM', N'Cao Đẳng Kinh Tế Kỹ Thuật Miền Nam')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (71, N'CKP', N'Cao Đẳng Kỹ Thuật Lý Tự Trọng TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (72, N'CM3', N'Cao Đẳng Sư Phạm Trung Ương TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (73, N'CPL', N'Cao Đẳng Kinh Tế Kỹ Thuật TP HCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (74, N'CPS', N'Cao Đẳng Phát Thanh Truyền Hình II')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (75, N'CTS', N'Cao Đẳng Tài Chính Hải Quan')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (76, N'CVN', N'Cao Đẳng Văn Hóa Nghệ Thuật TPHCM')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (77, N'CVS', N'Cao Đẳng Văn Hóa Nghệ Thuật và Du Lịch Sài Gòn')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (78, N'CVX', N'Cao Đẳng Kỹ Thuật-Công Nghệ Vạn Xuân')
INSERT [dbo].[COLLEGE] ([COLLEGE_ID], [COLLEGE_CODE], [COLLEGE_NAME]) VALUES (79, N'CXS', N'Cao Đẳng Xây Dựng Số 2')
SET IDENTITY_INSERT [dbo].[COLLEGE] OFF
GO
