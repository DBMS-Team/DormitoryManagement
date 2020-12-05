using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.Controller;
using DormitoryManagement.Model;

namespace DormitoryManagement.View
{
    public partial class FrmRoomRegistration : Form
    {
        public FrmRoomRegistration()
        {
            InitializeComponent();
        }
        public void FillDataSector() //Load tất cả các khu phòng
        {
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            cmbBuilding.DataSource = ListSector;
            cmbBuilding.DisplayMember = "SectorName";
        }
        public void FillDataRoom() // Load tất cả các phòng
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoom();
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }
        public void FillDataRoomBySector(string Sector_Name) // Load danh sách phòng theo Khu
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoomBySector(Sector_Name);
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }

        private void cmbBuilding_SelectedValueChanged(object sender, EventArgs e)
        {
            string SectorName = cmbBuilding.Text.ToString();
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            for (int i = 0; i < ListSector.Count; i++)
            {
                SectorDTO Sector = ListSector[i];
                if (SectorName == Sector.SectorName)
                {
                    FillDataRoomBySector(Sector.SectorId);
                }
            }
        }

        private void FrmRoomRegistration_Load(object sender, EventArgs e)
        {
            FillDataSector();
        }
    }
}
