using System.Drawing;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmDashboard : Form
    {
        #region Fields
        private Item ctrlLogout;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlSearch;
        private Item ctrlGuide;
        #endregion

        #region Properties
        public Item CtrlLogout { get => ctrlLogout; set => ctrlLogout = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        #endregion

        public FrmDashboard()
        {
            this.InitializeComponent();
            Init();
        }

        protected void Init()
        {
            //Đăng xuất
            ctrlLogout = new Item(Logout);
            ctrlLogout.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogout.btnTitle.Text = "LOGOUT";
            ctrlLogout.Anchor = AnchorStyles.Right;
            ctrlLogout.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlLogout);
            //Thoát
            ctrlExit = new Item(Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.Anchor = AnchorStyles.Left;
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlExit);
            //DS Khu phòng
            ctrlBuildings = new Item(ItemType.Building);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            tlpInfo.Controls.Add(ctrlBuildings);
            //DS Khu phòng
            ctrlRoomType = new Item(ItemType.RoomType);
            ctrlRoomType.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoomType.btnTitle.Text = "ROOM TYPES";
            tlpInfo.Controls.Add(ctrlRoomType);
            //DS dịch vụ
            ctrlServices = new Item(ItemType.Service);
            ctrlServices.picItem.BackgroundImage = Properties.Resources.Water;
            ctrlServices.btnTitle.Text = "SERVICES";
            tlpInfo.Controls.Add(ctrlServices);
            //Tìm kiếm
            ctrlSearch = new Item(Search);
            ctrlSearch.picItem.BackgroundImage = Properties.Resources.Search;
            ctrlSearch.btnTitle.Text = "SEARCH";
            tlpInfo.Controls.Add(ctrlSearch);
            //Hướng dẫn
            ctrlGuide = new Item(Guide);
            ctrlGuide.picItem.BackgroundImage = Properties.Resources.Info;
            ctrlGuide.btnTitle.Text = "GUIDE";
            tlpInfo.Controls.Add(ctrlGuide);
        }

        private void Logout()
        {
            DialogResult re = MessageBox.Show("Bạn muốn đăng xuất khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                //isExit = false;
                //FrmDangNhap.exit = false;
                this.Dispose();
            }
        }

        protected void Exit()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected void Search()
        {
            FrmSearch frmTimKiem = new FrmSearch();
            frmTimKiem.ShowDialog();
        }

        protected void Guide()
        {
            FrmGuide huongDan = new FrmGuide();
            huongDan.ShowDialog();
        }
    }
}
