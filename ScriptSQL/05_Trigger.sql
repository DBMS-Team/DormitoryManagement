﻿USE [DormitoryManagement]
GO

-- Thay đổi mật khẩu mặc định
CREATE OR ALTER TRIGGER TRG_DefaultPassword ON [dbo].[USER]
FOR INSERT
AS
	BEGIN
	    DECLARE @lass_USER_ID BIGINT
		DECLARE @newPassword VARCHAR(32)
		SET @lass_USER_ID= ( SELECT TOP 1 USER_ID FROM dbo.[USER] ORDER BY USER_ID DESC)
		SET @newPassword = dbo.UFN_NewPassword('','dbms',32)
		SET @newPassword = dbo.UFN_GenerateMD5(@newPassword)
		UPDATE dbo.[USER] SET PASSWORD = @newPassword WHERE USER_ID = @lass_USER_ID AND USER_TYPE = 'EMPLOYEE'
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
-- TRG CHECKBILL
CREATE OR ALTER TRIGGER CheckBill
ON dbo.BILL
FOR INSERT
AS
	DECLARE @Sector_ID VARCHAR(10),
		    @Room_ID NVARCHAR(10),
			@Month INT,
			@Year INT,
			@Old_Sector_Name VARCHAR(10),
			@Old_Room_ID NVARCHAR(10),
			@Old_Month INT,
			@Old_Year INT
			
	SELECT @Sector_ID = Inserted.Sector_ID FROM Inserted
	SELECT @Room_ID = Inserted.ROOM_ID FROM Inserted
	SELECT @Month = Inserted.MONTH FROM Inserted
	SELECT @Year = Inserted.YEAR FROM Inserted

	IF (@Sector_ID IN (SELECT dbo.TEMPT.T_Sector_ID FROM dbo.TEMPT)
		AND @Room_ID IN (SELECT dbo.TEMPT.T_Room_ID FROM dbo.TEMPT WHERE dbo.TEMPT.T_Sector_ID = @Sector_ID)
		AND @Month IN (SELECT dbo.TEMPT.T_MONTH FROM dbo.TEMPT WHERE dbo.TEMPT.T_Sector_ID = @Sector_ID AND dbo.TEMPT.T_Room_ID = @Room_ID)
		AND @Year IN (SELECT dbo.TEMPT.T_YEAR FROM dbo.TEMPT WHERE dbo.TEMPT.T_Sector_ID = @Sector_ID AND dbo.TEMPT.T_Room_ID = @Room_ID AND dbo.TEMPT.T_MONTH = @Month)
		)
	BEGIN
		RAISERROR(N'Bill Is Exists',16,1)
		ROLLBACK
	END
	ELSE
		BEGIN
				INSERT INTO dbo.TEMPT
				(
					T_Sector_ID,
					T_Room_ID,
					T_Month,
					T_Year
				)
				VALUES
				(   
					@Sector_ID,
					@Room_ID, 
					@Month,
					@Year 
				)
		END
GO
--TRG_INSERT_ROOM_REGISTRATION
CREATE OR ALTER TRIGGER TRG_INSERT_ROOM_REGISTRATION
ON dbo.ROOM_REGISTRATION
FOR INSERT
AS
	DECLARE @SSN VARCHAR(12), @SECTOR_ID VARCHAR(10), @ROOM_ID NVARCHAR(10), @CAPACITY INT, @CURRENT_REGISTRATER INT
	SELECT @SSN = Inserted.SSN FROM Inserted
	SELECT @SECTOR_ID =  Inserted.SECTOR_ID FROM Inserted
	SELECT @ROOM_ID = Inserted.ROOM_ID FROM Inserted
	SELECT @CAPACITY = dbo.ROOM_TYPE.CAPACITY FROM dbo.ROOM INNER JOIN dbo.ROOM_TYPE ON ROOM_TYPE.ROOM_TYPE_ID = ROOM.ROOM_TYPE_ID
												WHERE dbo.ROOM.SECTOR_ID = @SECTOR_ID AND dbo.ROOM.ROOM_ID = @ROOM_ID
	SELECT @CURRENT_REGISTRATER = dbo.UFN_CountNumberOfStudentInRoom(@SECTOR_ID,@ROOM_ID)
	IF (@SSN IN (SELECT dbo.[USER].SSN FROM dbo.STUDENT INNER JOIN dbo.[USER] ON [USER].USER_ID = STUDENT.USER_ID
										WHERE dbo.STUDENT.STATUS_REGISTRATION_ROOM = 1))
	BEGIN
	    RAISERROR(N'SSN Is Exist',16,1)
		ROLLBACK
	END
	ELSE IF(@CURRENT_REGISTRATER = @CAPACITY + 1)
	BEGIN
	    RAISERROR(N'ROOM IS FULL',16,1)
		ROLLBACK
	END
	ELSE
	BEGIN
	    DECLARE @USER_ID_UPDATE VARCHAR(12)
		SELECT @USER_ID_UPDATE = dbo.[USER].USER_ID FROM dbo.STUDENT INNER JOIN dbo.[USER] ON [USER].USER_ID = STUDENT.USER_ID
													WHERE dbo.[USER].SSN = @SSN
		UPDATE dbo.STUDENT
		SET STATUS_REGISTRATION_ROOM = 1
		WHERE dbo.STUDENT.USER_ID = @USER_ID_UPDATE
	END
GO

-- Thay đổi mật khẩu mặt định sinh viên
CREATE OR ALTER TRIGGER TRG_DefaultPasswordStudent ON [dbo].[USER]
FOR INSERT
AS
	BEGIN
	    DECLARE @lass_USER_ID BIGINT
		DECLARE @newPassword VARCHAR(32)
		SET @lass_USER_ID= ( SELECT TOP 1 USER_ID FROM dbo.[USER] ORDER BY USER_ID DESC)
		SET @newPassword = dbo.UFN_NewPassword('','mem',32)
		SET @newPassword = dbo.UFN_GenerateMD5(@newPassword)
		UPDATE dbo.[USER] SET PASSWORD = @newPassword WHERE USER_ID = @lass_USER_ID
		AND USER_TYPE = 'STUDENT'
	END
GO