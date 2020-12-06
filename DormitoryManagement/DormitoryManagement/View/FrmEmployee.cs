using DormitoryManagement.Model;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmEmployee : Form
    {
        #region Fields
        private Item ctrlLogout;
        private Item ctrlChangePassword;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlGuide;
        private Item ctrlSearch;
        private Item ctrlListStudents;
        private Item ctrlListEmployees;
        private Item ctrlRoom;
        private Item ctrlBill;
        private Item ctrlAddStudent;
        private Item ctrlRoomRegistration;
        private Item ctrlReport;

        #endregion

        #region Properties
        public Item CtrlLogout { get => ctrlLogout; set => ctrlLogout = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        public Item CtrlListStudents { get => ctrlListStudents; set => ctrlListStudents = value; }
        public Item CtrlRoom { get => ctrlRoom; set => ctrlRoom = value; }
        public Item CtrlBill { get => ctrlBill; set => ctrlBill = value; }
        public Item CtrlListEmployees { get => ctrlListEmployees; set => ctrlListEmployees = value; }
        public Item CtrlAddStudent { get => ctrlAddStudent; set => ctrlAddStudent = value; }
        public Item CtrlReport { get => ctrlReport; set => ctrlReport = value; }
        public Item CtrlRoomRegistration { get => ctrlRoomRegistration; set => ctrlRoomRegistration = value; }

        #endregion
        private EmployeeDTO loginEmployee;
        private UserDTO loginUser;
        public EmployeeDTO LoginEmployee
        {
            get => loginEmployee;
            set
            {
                this.loginEmployee = value;
            }
        }
        public UserDTO LoginUser
        {
            get => loginUser;
            set
            {
                this.loginUser = value;
            }
        }

        public Item CtrlChangePassword { get => ctrlChangePassword; set => ctrlChangePassword = value; }
        public Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }

        public FrmEmployee(EmployeeDTO employee, UserDTO user)
        {
            InitializeComponent();
            Init();
            this.LoginEmployee = employee;
            this.LoginUser = user;
        }

        private void Init()
        {
            #region Management
            //Logout
            CtrlLogout = Dashboard.InitLogout();
            tlpManage.Controls.Add(CtrlLogout);
            //Change password
            CtrlChangePassword = Dashboard.InitChangePassword(LoginUser);
            tlpManage.Controls.Add(CtrlChangePassword);
            //Thoát
            CtrlExit = Dashboard.InitExit();
            tlpManage.Controls.Add(CtrlExit);
            #endregion

            #region Information
            //DS Sinh viên
            CtrlListStudents = Dashboard.InitListStudents();
            tlpInfo.Controls.Add(CtrlListStudents);
            //Báo cáo
            CtrlReport = Dashboard.InitReport();
            tlpInfo.Controls.Add(CtrlReport);
            //DS Khu phòng
            CtrlBuildings = Dashboard.InitListBuildings();
            tlpInfo.Controls.Add(CtrlBuildings);
            //Phòng
            CtrlRoom = Dashboard.InitRoom();
            tlpInfo.Controls.Add(CtrlRoom);
            //DS Loại Phòng
            CtrlRoomType = Dashboard.InitListRoomType();
            tlpInfo.Controls.Add(CtrlRoomType);
            //DS dịch vụ
            CtrlServices = Dashboard.InitListServices();
            tlpInfo.Controls.Add(CtrlServices);
            //Search
            CtrlSearch = Dashboard.InitSearch();
            tlpInfo.Controls.Add(CtrlSearch);
            //Hướng dẫn
            CtrlGuide = Dashboard.InitGuide();
            tlpInfo.Controls.Add(CtrlGuide);
            #endregion

            #region Add
            //Phòng
            ctrlRoomRegistration = Dashboard.InitRoomRegistration();
            tlpAdd.Controls.Add(CtrlRoomRegistration);
            //Hoá đơn
            CtrlBill = Dashboard.InitBill();
            tlpAdd.Controls.Add(CtrlBill);
            //Sinh viên
            CtrlAddStudent = Dashboard.InitAddStudent();
            tlpAdd.Controls.Add(CtrlAddStudent);
            #endregion
        }
    }
}
