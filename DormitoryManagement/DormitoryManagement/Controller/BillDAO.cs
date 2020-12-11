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
        public static DataTable GetListBillView()
        {
            string query = string.Format("EXEC dbo.USP_GetListBillView");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListBillViewByBuldingAndRoom(string bulding, string room)
        {
            string query = string.Format("EXEC dbo.USP_GetListBillViewBySectorAndRoom @SECTOR_NAME = N'{0}', @ROOM_ID = N'{1}'", bulding, room);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListBillViewByStatus(bool status)
        {
            string query = string.Format("EXEC dbo.USP_GetListBillViewByStatus @STATUS = {0}", status);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
