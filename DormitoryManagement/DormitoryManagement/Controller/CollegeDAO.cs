using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class CollegeDAO
    {
        public static List<CollegeDTO> GetListColloge()
        {
            string query = string.Format("EXEC dbo.USP_GetListCollege");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<CollegeDTO> listCollege = new List<CollegeDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                CollegeDTO temp = new CollegeDTO(item);
                listCollege.Add(temp);
            }
            return listCollege;
        }
    }
}
