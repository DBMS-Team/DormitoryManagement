using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmStudent : Form
    {
        #region Fields
        private Item ctrlLogout;
        private Item ctrlChangePassword;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlGuide;
        private Item ctrlListStudents;
        private Item ctrlListEmployees;
        private Item ctrlRoom;
        private Item ctrlBill;
        private Item ctrlAddStudent;
        private Item ctrlAddEmployee;
        private Item ctrlRoomRegistration;
        private Item ctrlSearch;
        private Item ctrlReport;
        private AdminDTO loginAdmin;
        private UserDTO loginUser;
        private StudentDTO loginStudent;
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
        public Item CtrlAddEmployee { get => ctrlAddEmployee; set => ctrlAddEmployee = value; }
        public Item CtrlRoomRegistration { get => ctrlRoomRegistration; set => ctrlRoomRegistration = value; }
        public Item CtrlChangePassword { get => ctrlChangePassword; set => ctrlChangePassword = value; }
        public AdminDTO LoginAdmin
        {
            get => loginAdmin;
            set
            {
                this.loginAdmin = value;
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

        public StudentDTO LoginStudent
        {
            get => loginStudent;
            set
            {
                this.loginStudent = value;
            }
        }

        public Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }
        #endregion

        public FrmStudent(StudentDTO student, UserDTO user)
        {
            InitializeComponent();
            Init();
        }

        #region Methods
        protected void Init()
        {
            #region Management
            //Logout
            CtrlLogout = Dashboard.InitLogout();
            tlpManage.Controls.Add(CtrlLogout);
            //Change password
            CtrlChangePassword = Dashboard.InitChangePassword(null);
            tlpManage.Controls.Add(CtrlChangePassword);
            //Exit
            CtrlExit = Dashboard.InitExit();
            tlpManage.Controls.Add(CtrlExit);
            #endregion

            #region Information
            //DS Khu phòng
            CtrlBuildings = Dashboard.InitListBuildings();
            tlpInfo.Controls.Add(CtrlBuildings);
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
            CtrlRoomRegistration = Dashboard.InitRoomRegistration();
            tlpAdd.Controls.Add(CtrlRoomRegistration);
            //Hoá đơn
            CtrlBill = Dashboard.InitBill();
            tlpAdd.Controls.Add(CtrlBill);
            //Sinh viên
            CtrlAddStudent = Dashboard.InitAddStudent();
            tlpAdd.Controls.Add(CtrlAddStudent);
            //Nhân viên
            CtrlAddEmployee = Dashboard.InitAddEmployee();
            tlpAdd.Controls.Add(CtrlAddEmployee);
            #endregion
        }
        #endregion
    }
}
