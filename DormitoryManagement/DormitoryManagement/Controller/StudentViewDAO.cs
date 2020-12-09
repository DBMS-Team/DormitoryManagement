using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public class StudentViewDAO
    {
        public static List<StudentViewDTO> GetListStudentView()
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneral");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentView = new StudentViewDTO(item);
                studentViewDTOs.Add(studentView);
            }
            return studentViewDTOs;
        }
        public static List<StudentViewDTO> GetListStudentViewALive()
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralALive");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentView = new StudentViewDTO(item);
                studentViewDTOs.Add(studentView);
            }
            return studentViewDTOs;
        }
        public static List<StudentViewDTO> GetListStudentViewGoingOut()
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralGoingOut");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentView = new StudentViewDTO(item);
                studentViewDTOs.Add(studentView);
            }
            return studentViewDTOs;
        }
        public static List<StudentViewDTO> SearchStudentViewByUserId(string userId)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByUserId @USER_ID = '{0}'", userId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;
        }
        public static List<StudentViewDTO> SearchStudentViewByStudentId(string studentId)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByStudentId @STUDENT_ID = '{0}'", studentId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;

        }
        public static List<StudentViewDTO> SearchStudentViewByFullName(string fullName)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByFullName @FULL_NAME = N'{0}'", fullName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;

        }
        public static List<StudentViewDTO> SearchStudentViewByGender(string gender)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByGender @GENDER = N'{0}'", gender);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;

        }
        public static List<StudentViewDTO> SearchStudentViewBySsn(string ssn)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralBySsn @SSN = '{0}'", ssn);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;

        }
        public static List<StudentViewDTO> SearchStudentViewByCollege(string college)
        {
            List<StudentViewDTO> studentViewDTOs = new List<StudentViewDTO>();
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByCollegeName @COLLEGE_NAME = N'{0}'", college);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StudentViewDTO studentViewDTO = new StudentViewDTO(item);
                studentViewDTOs.Add(studentViewDTO);
            }
            return studentViewDTOs;

        }
    }
}
