using DormitoryManagement.Model;
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
            string query = string.Format("EXEC dbo.USP_Login @USERNAME = '{0}',@PASSWORD = '{1}'", userName, passWord);
            DataTable result = DataProvider.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
        public static UserDTO GetUserByUsername(string userName)
        {
            string query = string.Format("EXEC dbo.USP_GetUserByUsername @USERNAME = '{0}'",userName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new UserDTO(item);
            }
            return null;
        }
        public static UserDTO GetUserById(string id)
        {
            string query = string.Format("EXEC dbo.USP_GetUserById @USER_ID = {0}", id);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new UserDTO(item);

            }
            return null;
        }
    }
}
