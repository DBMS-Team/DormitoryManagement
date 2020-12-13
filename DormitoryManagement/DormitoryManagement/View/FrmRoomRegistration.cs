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
        private UserDTO user;
        public UserDTO User
        {
            get => user;
            set
            {
                this.user = value;
            }
        }
        public FrmRoomRegistration(UserDTO user)
        {
            InitializeComponent();
            this.User = user;
            lbMaNV.Text = Convert.ToString(User.UserId);
        }

        public FrmRoomRegistration(UserDTO user, string roomRegID)
        {
            InitializeComponent();
            this.User = user;
            btnOK.Visible = false;
            tlpBottom.ColumnCount = 2;
            panel1.Enabled = false;

            //Load RoomReg Info using roomRegID
            LoadRoomRegInfo(roomRegID);
        }

        /// <summary>
        /// Load thông tin chi tiết của RoomReg dựa vào ID
        /// </summary>
        private void LoadRoomRegInfo(string id)
        {

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSSN.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Chứng Minh Nhân Dân");
            }
            else if (cmbSemester.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Học Kỳ");
            }
            else if (txtAcademicYear.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Năm Học");
            }
            else if (cbbDuration.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Thời Hạn");
            }
            else
            {
                long Employee_ID = User.UserId;
                string Ssn = Convert.ToString(txtSSN.Text);
                string Sector_Name = Convert.ToString(cmbBuilding.Text);
                string Room_ID = Convert.ToString(cmbRoom.Text);
                DateTime Start_Day = dtpStartDate.Value;
                int Semester = Convert.ToInt32(cmbSemester.Text);
                int Academic_Year = Convert.ToInt32(txtAcademicYear.Text);
                string Duaration = Convert.ToString(cbbDuration.Text);
                string Status = "1";
                if (AddRoomRegistration(Employee_ID, Ssn, Sector_Name, Room_ID, Start_Day, Semester, Academic_Year, Duaration, Status))
                {
                    MessageBox.Show("Registration Success");
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        bool AddRoomRegistration(long Employee_ID, string Ssn, string Sector_Name, string Room_ID, DateTime Start_Day, int Semester, int Academic_Year, string Duaration, string Status)
        {
            return RoomRegistrationDAO.AddRoomRegistration(Employee_ID, Ssn, Sector_Name, Room_ID, Start_Day, Semester, Academic_Year, Duaration, Status);
        }
    }
}
