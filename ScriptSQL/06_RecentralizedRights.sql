USE DormitoryManagement
GO
CREATE ROLE EMPLOYEE
CREATE ROLE ADMIN
CREATE ROLE STUDENT
-------------
--Grant to EMPLOYEE
--Login -- change password
GRANT EXECUTE ON dbo.USP_Login TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_ChangePassword TO EMPLOYEE
--Room Registration
GRANT EXECUTE ON dbo.USP_GetListSector TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListRoom TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListRoomBySectorID TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_INSERT_ROOMREGISTRATION TO EMPLOYEE
--Bill
GRANT EXECUTE ON dbo.USP_GetListServiceUnit TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListService TO EMPLOYEE
GRANT EXECUTE ON dbo.GetUnitByServiceName TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_InsetBill TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_INSERT_SERVICE_BILL_DETAIL TO EMPLOYEE
GRANT SELECT ON dbo.UFN_ReturnForViewBillDetail TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_INSERT_PAYMENT TO EMPLOYEE
--Insert STUDENT
GRANT EXECUTE ON dbo.USP_GetListProvince TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListDistrictByProvinceName TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListDistrictByProvinceName TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListCollege TO EMPLOYEE
GRANT EXECUTE ON dbo.TRANS_INSERT_STUDENT TO EMPLOYEE
GRANT EXECUTE ON USP_CREATE_LOGIN_USER TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_TRANSACTION_UpdateStudent TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListCommuneByProvinceAndDistrict TO EMPLOYEE
--Service
GRANT EXECUTE ON dbo.USP_GetServicesInfo TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_UpdateService TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_InsertService TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_UnableService TO EMPLOYEE
--Room Type
GRANT EXECUTE ON dbo.USP_GetListRoomView TO EMPLOYEE
--Sector
--dbo.USP_GetListSector
--Search
--Search STUDENT
GRANT EXECUTE ON dbo.USP_GetListStudentGeneral TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralALive TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralGoingOut TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByUserId TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByStudentId TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByFullName TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByGender TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralBySsn TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByCollegeName TO EMPLOYEE
--Search ROOM-REGISTRATION
GRANT EXECUTE ON dbo.USP_GetListRoomRegistration TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationByStudentId TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationByStudentName TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationBySectorAndRoom TO EMPLOYEE
--Search BILL
GRANT EXECUTE ON dbo.USP_GetListBillView TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListBillViewBySectorAndRoom TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetListBillViewByDate TO EMPLOYEE
---Login
GRANT EXECUTE ON dbo.USP_GetUserByUsername TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_GetEmployeeById TO EMPLOYEE
--View Info
GRANT EXECUTE ON dbo.USP_GetEmployeeView TO EMPLOYEE
--Update info
GRANT EXECUTE ON dbo.USP_GetListUser TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_EditEmployee TO EMPLOYEE
---LoadRoomRegistration
GRANT EXECUTE ON USP_LoadRoomRegistrationByStudentID TO EMPLOYEE
GRANT EXECUTE ON dbo.USP_UpdateRoomRegistration TO EMPLOYEE
--- GetStudentInfo
GRANT EXECUTE ON USP_GetStudentInfo TO EMPLOYEE
GRANT EXECUTE ON USP_GetProvinceNameByProvinceID TO EMPLOYEE
GRANT EXECUTE ON USP_GetDistrictNameByDistrictID TO EMPLOYEE
GRANT EXECUTE ON USP_GetCommuneNameByCommuneID TO EMPLOYEE
GRANT EXECUTE ON USP_GetCollegeNameByCollegeID TO EMPLOYEE
--- Lock User Student
GRANT EXECUTE ON USP_LockUserStudent TO EMPLOYEE
CREATE LOGIN khanh@gmail WITH PASSWORD = '000000'
CREATE USER khanh@gmail FOR LOGIN khanh@gmail
EXEC sys.sp_addrolemember @rolename = EMPLOYEE,  -- sysname
                          @membername = khanh@gmail -- sysname
-----------------------------------
-----------------------------------
---Grant STUDENT
-- Cchange Password
GRANT EXECUTE ON dbo.USP_Login TO STUDENT
GRANT EXECUTE ON dbo.USP_ChangePassword TO STUDENT
--View Info
GRANT EXECUTE ON dbo.USP_GetListProvince TO STUDENT
GRANT EXECUTE ON dbo.USP_GetListCollege TO STUDENT
GRANT EXECUTE ON dbo.USP_GetListDistrictByProvinceName TO STUDENT
GRANT EXECUTE ON dbo.USP_GetListCommuneByProvinceAndDistrict TO STUDENT
GRANT EXECUTE ON dbo.USP_GetListStudentView TO STUDENT
--Update Info
GRANT EXECUTE ON dbo.USP_TRANSACTION_UpdateStudent TO STUDENT
--Sector
GRANT EXECUTE ON dbo.USP_GetListSector TO STUDENT
--Room
GRANT EXECUTE ON dbo.USP_GetListRoomView TO STUDENT
--Service
GRANT EXECUTE ON dbo.USP_GetServicesInfo TO STUDENT
--
GRANT EXECUTE ON dbo.USP_GetStudentById TO STUDENT
--Add Test
CREATE LOGIN p@gmail WITH PASSWORD = '000000'
CREATE USER p@gmail FOR LOGIN p@gmail
EXEC sys.sp_addrolemember @rolename = STUDENT,  -- sysname
                          @membername = p@gmail -- sysname
--Grant Admin
--Login -- change password
GRANT EXECUTE ON dbo.USP_Login TO ADMIN
GRANT EXECUTE ON dbo.USP_ChangePassword TO ADMIN
--Room Registration
GRANT EXECUTE ON dbo.USP_GetListSector TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListRoom TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListRoomBySectorID TO ADMIN
GRANT EXECUTE ON dbo.USP_INSERT_ROOMREGISTRATION TO ADMIN
--Bill
GRANT EXECUTE ON dbo.USP_GetListServiceUnit TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListService TO ADMIN
GRANT EXECUTE ON dbo.GetUnitByServiceName TO ADMIN
GRANT EXECUTE ON dbo.USP_InsetBill TO ADMIN
GRANT EXECUTE ON dbo.USP_INSERT_SERVICE_BILL_DETAIL TO ADMIN
GRANT SELECT ON dbo.UFN_ReturnForViewBillDetail TO ADMIN
GRANT EXECUTE ON dbo.USP_INSERT_PAYMENT TO ADMIN
--Insert STUDENT
GRANT EXECUTE ON dbo.USP_GetListProvince TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListDistrictByProvinceName TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListDistrictByProvinceName TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListCollege TO ADMIN
GRANT EXECUTE ON dbo.TRANS_INSERT_STUDENT TO ADMIN
GRANT EXECUTE ON USP_CREATE_LOGIN_USER TO ADMIN
GRANT EXECUTE ON dbo.USP_TRANSACTION_UpdateStudent TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListCommuneByProvinceAndDistrict TO ADMIN
--Service
GRANT EXECUTE ON dbo.USP_GetServicesInfo TO ADMIN
GRANT EXECUTE ON dbo.USP_UpdateService TO ADMIN
GRANT EXECUTE ON dbo.USP_InsertService TO ADMIN
GRANT EXECUTE ON dbo.USP_UnableService TO ADMIN
--Room Type
GRANT EXECUTE ON dbo.USP_GetListRoomView TO ADMIN
--Sector
--dbo.USP_GetListSector
--Search
--Search STUDENT
GRANT EXECUTE ON dbo.USP_GetListStudentGeneral TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralALive TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralGoingOut TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByUserId TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByStudentId TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByFullName TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByGender TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralBySsn TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListStudentGeneralByCollegeName TO ADMIN
--Search ROOM-REGISTRATION
GRANT EXECUTE ON dbo.USP_GetListRoomRegistration TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationByStudentId TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationByStudentName TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListRoomRegistrationBySectorAndRoom TO ADMIN
--Search BILL
GRANT EXECUTE ON dbo.USP_GetListBillView TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListBillViewBySectorAndRoom TO ADMIN
GRANT EXECUTE ON dbo.USP_GetListBillViewByDate TO ADMIN
---Login
GRANT EXECUTE ON dbo.USP_GetUserByUsername TO ADMIN
GRANT EXECUTE ON dbo.USP_GetEmployeeById TO ADMIN
--View Info
GRANT EXECUTE ON dbo.USP_GetEmployeeView TO ADMIN
--Update info
GRANT EXECUTE ON dbo.USP_GetListUser TO ADMIN
GRANT EXECUTE ON dbo.USP_EditEmployee TO ADMIN
---LoadRoomRegistration
GRANT EXECUTE ON USP_LoadRoomRegistrationByStudentID TO ADMIN
GRANT EXECUTE ON dbo.USP_UpdateRoomRegistration TO ADMIN
--- GetStudentInfo
GRANT EXECUTE ON USP_GetStudentInfo TO ADMIN
GRANT EXECUTE ON USP_GetProvinceNameByProvinceID TO ADMIN
GRANT EXECUTE ON USP_GetDistrictNameByDistrictID TO ADMIN
GRANT EXECUTE ON USP_GetCommuneNameByCommuneID TO ADMIN
GRANT EXECUTE ON USP_GetCollegeNameByCollegeID TO ADMIN
--- Lock User Student
GRANT EXECUTE ON USP_LockUserStudent TO ADMIN
-- Add employee
GRANT EXECUTE ON dbo.USP_AddEmployee TO ADMIN
--View List Employee
GRANT EXECUTE ON dbo.USP_GetListEmployeeView TO ADMIN
--Update salary employee
GRANT EXECUTE ON dbo.USP_UpdateSalary TO ADMIN
--Get admin by ID
GRANT EXECUTE ON dbo.USP_GetAdminById TO ADMIN
--
--Add Test ADMIN
CREATE LOGIN ntp@gmail WITH PASSWORD = '000000'
CREATE USER ntp@gmail FOR LOGIN ntp@gmail
EXEC sys.sp_addrolemember @rolename = ADMIN,  -- sysname
                          @membername = ntp@gmail -- sysname