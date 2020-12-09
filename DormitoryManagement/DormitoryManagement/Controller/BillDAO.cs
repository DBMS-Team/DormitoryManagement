using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class BillDAO
    {
        public static bool AddBill(long Employee_ID, string Room_Name, string Sector_Name, DateTime CreatDay, string Month, string Year, string Status, string Total)
        {
            string CREATEDAY = Convert.ToDateTime(CreatDay).ToString("yyyyMMdd");
            string query = string.Format("EXEC dbo.USP_InsetBill @Employee_ID = {0}," +
                                                                "@Room_Name = N'{1}'," +
                                                                "@Sector_Name = N'{2}'," +
                                                                "@Create_date = '{3}'," +
                                                                "@Month = {4}," +
                                                                "@Year = {5}, " +
                                                                "@Status = {6}," +
                                                                "@total ={7} ", Employee_ID, Room_Name,Sector_Name, CREATEDAY,Month,Year,Status,Total);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
