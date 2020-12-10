ALTER PROC TRANS_INSERT_STUDENT
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
		CREATE TABLE TEMPT
		(
			T_SSN VARCHAR(12),
			T_INSURANCE_ID VARCHAR(15),
			T_PHONENUMBER1 VARCHAR(15),
			T_PHONENUMBER2 VARCHAR(15),
			T_EMAIL VARCHAR(40)
		)
		INSERT INTO dbo.TEMPT
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
		EXEC dbo.USP_INSERT_STUDENT @STUDENT_ID = @STUDENT_ID,    -- varchar(15)
		                            @COLLEGE_NAME = @COLLEGE_NAME, -- nvarchar(50)
		                            @FACULTY = @FACULTY,      -- nvarchar(50)
		                            @MAJORS = @MAJORS,       -- nvarchar(50)
		                            @INSURANCE_ID = @Insurence_ID   -- varchar(15)

		IF(@Insurence_ID IN (SELECT dbo.TEMPT.T_INSURANCE_ID FROM dbo.TEMPT))
		BEGIN
		    ROLLBACK
		END
		ELSE
		BEGIN
			DROP TABLE dbo.TEMPT
			COMMIT
		END	
END
GO