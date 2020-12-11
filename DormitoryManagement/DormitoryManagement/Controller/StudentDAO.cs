using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string DOB = Convert.ToDateTime(DoB).ToString("yyyyMMdd");
            string query = string.Format("EXEC dbo.TRANS_INSERT_STUDENT @Street = N'{0}', " +
                                                                        "@Commune_Name = N'{1}'," +
                                                                        "@District_Name = N'{2}'," +
                                                                        "@Province_Name = N'{3}'," +
                                                                        "@Insurence_ID = {4}," +
                                                                        "@LAST_NAME = N'{5}'," +
                                                                        "@FIRST_NAME = N'{6}'," +
                                                                        "@DOB = '{7}'," +
                                                                        "@GENDER = N'{8}'," +
                                                                        "@SSN = {9}," +
                                                                        "@PHONE_NUMBER_1 = {10}, " +
                                                                        "@PHONE_NUMBER_2 = {11}," +
                                                                        "@EMAIL = N'{12}', " +
                                                                        "@IMAGE_PATH = {13}," +
                                                                        "@USER_TYPE = '{14}'," +
                                                                        "@STATUS = {15}," +
                                                                        "@STUDENT_ID = {16}," +
                                                                        "@COLLEGE_NAME = N'{17}'," +
                                                                        "@FACULTY = N'{18}'," +
                                                                        "@MAJORS = N'{19}'",Street, Commune_Name, District_Name, Province_Name, Insurance_ID, Last_Name, First_Name, DOB, Gender, Ssn, Phone_Number_1, Phone_Number_2, Email, Image_Path, User_Type, Status, Student_ID, College_Name, Faculty, Majors);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
