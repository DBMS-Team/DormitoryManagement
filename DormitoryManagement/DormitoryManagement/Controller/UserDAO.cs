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
        public static bool Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM dbo.Account WHERE Username = '{0}' AND Password = '{1}'", username, password);
            DataTable result = DataProvider.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
