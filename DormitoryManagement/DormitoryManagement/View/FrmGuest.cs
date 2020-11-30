using DormitoryManagement.View;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class FrmGuest : Form
    {
        #region Fields
        private Item ctrlLogin;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlSearch;
        private Item ctrlGuide;
        #endregion

        #region Properties
        public Item CtrlLogin { get => ctrlLogin; set => ctrlLogin = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        #endregion

        public FrmGuest()
        {
            InitializeComponent();
            Init();
        }

        #region Init

        protected void Init()
        {
            #region Management
            //Đăng nhập
            CtrlLogin = Dashboard.InitLogin(CtrlLogin);
            tlpManage.Controls.Add(ctrlLogin);
            //Thoát
            CtrlExit = Dashboard.InitExit(CtrlExit);
            tlpManage.Controls.Add(ctrlExit);
            #endregion

            #region Info
            //DS Khu phòng
            CtrlBuildings = Dashboard.InitBuildings(CtrlBuildings);
            tlpInfo.Controls.Add(ctrlBuildings);
            //Loại phòng
            CtrlRoomType = Dashboard.InitRoomType(CtrlRoomType);
            tlpInfo.Controls.Add(ctrlRoomType);
            //DS dịch vụ
            CtrlServices = Dashboard.InitServices(CtrlServices);
            tlpInfo.Controls.Add(ctrlServices);
            //Tìm kiếm
            CtrlSearch = Dashboard.InitSearch(CtrlSearch);
            tlpInfo.Controls.Add(ctrlSearch);
            //Hướng dẫn
            CtrlGuide = Dashboard.InitGuide(CtrlGuide);
            tlpInfo.Controls.Add(ctrlGuide);
            #endregion
        }
        #endregion
    }
}
