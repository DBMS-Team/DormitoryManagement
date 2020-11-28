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
    }
}
