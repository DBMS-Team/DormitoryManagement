using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class UserDAO
    {
        public static bool Login(string userName, string passWord)
        {
            string query = string.Format("EXEC dbo.USP_Login @USERNAME = N'{0}',@PASSWORD = N'{1}'", userName, passWord);
            DataTable result = DataProvider.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
