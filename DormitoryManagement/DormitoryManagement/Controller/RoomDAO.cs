using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class RoomDAO
    {
        public static List<RoomDTO> GetListRoom()
        {
            string query = string.Format("SELECT * FROM dbo.ROOM");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<RoomDTO> ListRoom = new List<RoomDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                RoomDTO Room = new RoomDTO(item);
                ListRoom.Add(Room);
            }
            return ListRoom;
        }
        public static List<RoomDTO> GetListRoomBySector(string Sector_Name)
        {
            string query = string.Format("SELECT * FROM dbo.ROOM WHERE dbo.ROOM.SECTOR_ID = {0}", Sector_Name);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<RoomDTO> ListRoom = new List<RoomDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                RoomDTO Room = new RoomDTO(item);
                ListRoom.Add(Room);
            }
            return ListRoom;
        }
    }
}
