﻿using DormitoryManagement.Model;
using System;
using System.Data;

namespace DormitoryManagement.Controller
{
   public static class StudentDAO
   {
      public static StudentDTO GetStudentById(long id)
      {
         string query = string.Format("EXEC dbo.USP_GetStudentById @USER_ID = {0}", id);
         DataTable dataTable = DataProvider.ExcuteQuery(query);
         foreach (DataRow item in dataTable.Rows)
         {
            return new StudentDTO(item);
         }
         return null;
      }

      public static bool AddStudent(string Street, string Commune_Name, string District_Name, string Province_Name, string Insurance_ID, string Last_Name, string First_Name, DateTime DoB, string Gender, string Ssn, string Phone_Number_1, string Phone_Number_2, string Email, string Image_Path, string User_Type, string Status, string Student_ID, string College_Name, string Faculty, string Majors)
      {
         string query = "EXEC dbo.TRANS_INSERT_STUDENT @Street , @Commune_Name , @District_Name , @Province_Name " +
            ", @Insurence_ID , @LAST_NAME , @FIRST_NAME , @DOB , @GENDER , @SSN , @PHONE_NUMBER_1 , @PHONE_NUMBER_2 " +
            ", @EMAIL , @IMAGE_PATH , @USER_TYPE , @STATUS , @STUDENT_ID " +
            ", @COLLEGE_NAME , @FACULTY , @MAJORS ";

         var paras = new object[] {
            Street,
            Commune_Name,
            District_Name,
            Province_Name,
            Insurance_ID,
            Last_Name,
            First_Name,
            Convert.ToDateTime(DoB).ToString("yyyyMMdd"),
            Gender,
            Ssn,
            Phone_Number_1,
            Phone_Number_2,
            Email,
            Image_Path ?? "",
            User_Type,
            Status,
            Student_ID,
            College_Name,
            Faculty,
            Majors
         };

         int result = DataProvider.ExcuteNonQuery(query, paras);
         return result > 0;
      }
   }
}