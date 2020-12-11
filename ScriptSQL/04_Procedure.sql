USE [DormitoryManagement]
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
	@Year INT, 
	@Unit_Name NVARCHAR(20), 
	@Total_Cost DECIMAL(19,4))
AS
BEGIN
    DECLARE @Bill_ID BIGINT, @Service_ID INT, @Old_Quantity INT,@New_Quantity INT, @Sector_ID NVARCHAR(20)
    SELECT @Bill_ID = (SELECT MAX(dbo.BILL.BILL_ID) FROM dbo.BILL)
    SELECT @Sector_ID = dbo.SECTOR.SECTOR_ID FROM dbo.SECTOR WHERE dbo.SECTOR.SECTOR_NAME = @Sector_Name
    SET @Month = @Month - 1
    IF(@Month = 0)
    BEGIN
        SET @Month = 12
        SET @Year = @Year -1
    END
    SELECT @Service_ID = dbo.SERVICE.SERVICE_ID FROM dbo.SERVICE WHERE dbo.SERVICE.SERVICE_NAME = @Service_Name
    SET @Old_Quantity = dbo.UFN_GetOldQuantityForNewBill(@Sector_ID,@Room_ID,@Month,@Year,@Service_Name)
    SET @New_Quantity = @Old_Quantity + @Quantity
    INSERT INTO dbo.BILL_DETAIL(BILL_ID, SERVICE_ID, OLD_QUANTITY, NEW_QUANTITY, UNIT_NAME,TOTAL_COST)
    VALUES
    (   @Bill_ID, -- BILL_ID - bigint
        @Service_ID, -- SERVICE_ID - int
        @Old_Quantity, -- OLD_QUANTITY - int
        @New_Quantity,  -- NEW_QUANTITY - int
        @Unit_Name,
        @Total_Cost
    )
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
-- Lấy danh sách đơn vị dịch vụ
CREATE OR ALTER PROC [dbo].[USP_GetListServiceUnit]
AS
BEGIN
    SELECT *
	FROM dbo.V_SERVICE_UNIT
	WHERE STATUS = 1
END
GO

-- Lấy danh sách College
CREATE OR ALTER PROC USP_GetListCollege
AS
BEGIN
    SELECT *
	FROM dbo.COLLEGE
END
GO
-- Thêm bảo hiểm
CREATE OR ALTER PROC USP_INSERT_INSURANCE
(@Insurence_ID VARCHAR(15))
AS
BEGIN
    INSERT INTO dbo.INSURANCE
    (
        INSURANCE_ID,
        BASE_PRACTICE,
        REGISTRATION_DATE,
        DURATION
    )
    VALUES
    (   @Insurence_ID,        
        NULL,       
        NULL, 
        NULL
        )
END
GO
--- THÊM USER - STUDENT
CREATE OR ALTER PROC USP_INSERT_USER_STUDENT
(
	@LAST_NAME NVARCHAR(40),
	@FIRST_NAME NVARCHAR(20),
	@DOB DATE,@GENDER NVARCHAR(5),
	@SSN VARCHAR(12),
	@PHONE_NUMBER_1 VARCHAR(15),
	@PHONE_NUMBER_2 VARCHAR(15),
	@EMAIL VARCHAR(40),
	@IMAGE_PATH VARCHAR(300),
	@USER_TYPE VARCHAR(10),
	@STATUS BIT
)
AS
BEGIN
	DECLARE @ADDRESS_ID INT
	SELECT @ADDRESS_ID = (SELECT MAX(ADDRESS_ID) FROM dbo.ADDRESS)
	INSERT INTO dbo.[USER]
	(
	    LAST_NAME,
	    FIRST_NAME,
	    DOB,
	    GENDER,
	    SSN,
	    ADDRESS_ID,
	    PHONE_NUMBER_1,
	    PHONE_NUMBER_2,
	    EMAIL,
	    IMAGE_PATH,
	    USERNAME,
	    PASSWORD,
	    USER_TYPE,
	    STATUS
	)
	VALUES
	(   @LAST_NAME,       -- LAST_NAME - nvarchar(40)
	    @FIRST_NAME,       -- FIRST_NAME - nvarchar(20)
	    @DOB, -- DOB - date
	    @GENDER,       -- GENDER - nvarchar(5)
	    @SSN,        -- SSN - varchar(12)
	    @ADDRESS_ID,         -- ADDRESS_ID - bigint
	    @PHONE_NUMBER_1,        -- PHONE_NUMBER_1 - varchar(15)
	    @PHONE_NUMBER_2,        -- PHONE_NUMBER_2 - varchar(15)
	    @EMAIL,        -- EMAIL - varchar(40)
	    @IMAGE_PATH,        -- IMAGE_PATH - varchar(300)
	    @EMAIL,        -- USERNAME - varchar(16)
	    'student',        -- PASSWORD - varchar(32)
	    @USER_TYPE,        -- USER_TYPE - varchar(10)
	    @STATUS       -- STATUS - bit
	    )
END
GO
-- THÊM SINH VIÊN
CREATE OR ALTER PROC USP_INSERT_STUDENT
(
	@STUDENT_ID VARCHAR(15), 
	@COLLEGE_NAME NVARCHAR(50),
	@FACULTY NVARCHAR(50), 
	@MAJORS NVARCHAR(50),
	@INSURANCE_ID VARCHAR(15),
	@STATUS_REGISTRATION_ROOM BIT
)
AS
BEGIN
    DECLARE @USER_ID BIGINT, @COLLEGE_ID INT
	SELECT @USER_ID = (SELECT MAX(USER_ID) FROM dbo.[USER])
	SELECT @COLLEGE_ID = dbo.COLLEGE.COLLEGE_ID FROM dbo.COLLEGE WHERE dbo.COLLEGE.COLLEGE_NAME = @COLLEGE_NAME
	INSERT INTO dbo.STUDENT
	(
	    USER_ID,
	    STUDENT_ID,
	    COLLEGE_ID,
	    FACULTY,
	    MAJORS,
	    INSURANCE_ID,
	    STATUS_REGISTRATION_ROOM
	)
	VALUES
	(   @USER_ID,   -- USER_ID - bigint
	    @STUDENT_ID,  -- STUDENT_ID - varchar(15)
	    @COLLEGE_ID,   -- COLLEGE_ID - int
	    @FACULTY, -- FACULTY - nvarchar(50)
	    @MAJORS, -- MAJORS - nvarchar(50)
	    @INSURANCE_ID,  -- INSURANCE_ID - varchar(15)
	    @STATUS_REGISTRATION_ROOM -- STATUS_REGISTRATION_ROOM - bit
	    )
END
GO

-- TRANSACTION -- THÊM 1 SINH VIÊN
CREATE OR ALTER PROC TRANS_INSERT_STUDENT
(
	@Street NVARCHAR(50), 
	@Commune_Name NVARCHAR(50), 
	@District_Name NVARCHAR(50),
	@Province_Name NVARCHAR(50),
	@Insurence_ID VARCHAR(15),
	@LAST_NAME NVARCHAR(40),
	@FIRST_NAME NVARCHAR(20),
	@DOB DATE,@GENDER NVARCHAR(5),
	@SSN VARCHAR(12),
	@PHONE_NUMBER_1 VARCHAR(15),
	@PHONE_NUMBER_2 VARCHAR(15),
	@EMAIL VARCHAR(40),
	@IMAGE_PATH VARCHAR(300),
	@USER_TYPE VARCHAR(10),
	@STATUS BIT,
	@STUDENT_ID VARCHAR(15), 
	@COLLEGE_NAME NVARCHAR(50),
	@FACULTY NVARCHAR(50), 
	@MAJORS NVARCHAR(50)
)
AS
BEGIN
	BEGIN TRANSACTION
		CREATE TABLE TEMPT_STUDENT
		(
			T_SSN VARCHAR(12),
			T_INSURANCE_ID VARCHAR(15),
			T_PHONENUMBER1 VARCHAR(15),
			T_PHONENUMBER2 VARCHAR(15),
			T_EMAIL VARCHAR(40)
		)
		INSERT INTO dbo.TEMPT_STUDENT
		(
			T_SSN,
			T_INSURANCE_ID,
			T_PHONENUMBER1,
			T_PHONENUMBER2,
			T_EMAIL
		)
		SELECT dbo.[USER].SSN, dbo.STUDENT.INSURANCE_ID, dbo.[USER].PHONE_NUMBER_1, dbo.[USER].PHONE_NUMBER_2, dbo.[USER].EMAIL
		FROM dbo.[USER] INNER JOIN dbo.STUDENT ON STUDENT.USER_ID = [USER].USER_ID
		EXEC dbo.USP_INSERT_INSURANCE @Insurence_ID = @Insurence_ID 
		EXEC dbo.USP_INSERT_ADDRESS @Street = @Street, 
		                            @Commune_Name = @Commune_Name, 
		                            @District_Name = @District_Name, 
		                            @Province_Name = @Province_Name 
		EXEC dbo.USP_INSERT_USER_STUDENT @LAST_NAME = @LAST_NAME,     -- nvarchar(40)
		                                 @FIRST_NAME = @FIRST_NAME,    -- nvarchar(20)
		                                 @DOB = @DOB,  -- date
		                                 @GENDER = @GENDER,        -- nvarchar(5)
		                                 @SSN = @SSN,            -- varchar(12)
		                                 @PHONE_NUMBER_1 = @PHONE_NUMBER_1, -- varchar(15)
		                                 @PHONE_NUMBER_2 = @PHONE_NUMBER_2, -- varchar(15)
		                                 @EMAIL = @EMAIL,          -- varchar(40)
		                                 @IMAGE_PATH = '',     -- varchar(300)
		                                 @USER_TYPE = @USER_TYPE,      -- varchar(10)
		                                 @STATUS = @STATUS        -- bit
		EXEC dbo.USP_INSERT_STUDENT @STUDENT_ID = @STUDENT_ID,                -- varchar(15)
		                            @COLLEGE_NAME = @COLLEGE_NAME,             -- nvarchar(50)
		                            @FACULTY = @FACULTY,                  -- nvarchar(50)
		                            @MAJORS = @MAJORS,                   -- nvarchar(50)
		                            @INSURANCE_ID = @Insurence_ID,              -- varchar(15)
		                            @STATUS_REGISTRATION_ROOM = 0 -- bit
		
		IF( @SSN IN (SELECT dbo.TEMPT_STUDENT.T_SSN FROM dbo.TEMPT_STUDENT))
		BEGIN
			RAISERROR('SSN Is exist',16,1)
		    ROLLBACK
		END
		ELSE
		BEGIN
			DROP TABLE dbo.TEMPT_STUDENT
			COMMIT
		END	
END
GO
--USP_INSERT_ROOMREGISTRATION
CREATE OR ALTER PROC USP_INSERT_ROOMREGISTRATION
(
	@EMPLOYEE_ID BIGINT, 
	@SSN VARCHAR(12), 
	@SECTOR_NAME NVARCHAR(50), 
	@ROOM_ID NVARCHAR(10), 
	@START_DAY DATETIME, 
	@SEMESTER INT, 
	@ACADEMIC_YEAR INT, 
	@DURATION NVARCHAR(20), 
	@STATUS BIT
)
AS
BEGIN
    DECLARE @SECTOR_ID VARCHAR(10)
	SELECT @SECTOR_ID = dbo.UFN_Get_SectorID_By_SectorName(@SECTOR_NAME)
	INSERT INTO dbo.ROOM_REGISTRATION
	(
	    SSN,
	    ROOM_ID,
	    EMPLOYEE_ID,
	    SECTOR_ID,
	    START_DATE,
	    SEMESTER,
	    ACADEMIC_YEAR,
	    DURATION,
	    STATUS
	)
	VALUES
	(   @SSN,
	    @ROOM_ID,
	    @EMPLOYEE_ID, 
	    @SECTOR_ID, 
	    @START_DAY,
	    @SEMESTER,
	    @ACADEMIC_YEAR, 
	    @DURATION,
	    @STATUS
	    )
END
GO
-- Lấy danh sách College
CREATE OR ALTER PROC USP_GetListBillView
AS
BEGIN
    SELECT * FROM dbo.[V_BILL]
END
GO
-- Lấy danh sách Room_Registration bằng Sector và room
CREATE OR ALTER PROC USP_GetListBillViewBySectorAndRoom(
	@SECTOR_NAME NVARCHAR(50),
	@ROOM_ID NVARCHAR(10)
	)
AS BEGIN
	SELECT * FROM dbo.[V_BILL] WHERE Sector = @SECTOR_NAME AND Room = @ROOM_ID
END
GO
