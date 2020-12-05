﻿using DormitoryManagement.Model;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmAdmin : Form
    {
        #region Fields
        private Item ctrlLogout;
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
        public Item CtrlAddEmployee { get => ctrlAddEmployee; set => ctrlAddEmployee = value; }
        public Item CtrlRoomRegistration { get => ctrlRoomRegistration; set => ctrlRoomRegistration = value; }
        #endregion

        private AdminDTO loginAdmin;
        private UserDTO loginUser;
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
        public FrmAdmin(AdminDTO admin, UserDTO user)
        {
            this.InitializeComponent();
            Init();
            this.LoginAdmin = admin;
            this.LoginUser = user;
        }
        #region Events

        #endregion
        #region Methods
        protected void Init()
        {
            #region Management
            //Đăng xuất
            CtrlLogout = Dashboard.InitLogout();
            tlpManage.Controls.Add(CtrlLogout);
            //Thoát
            CtrlExit = Dashboard.InitExit();
            tlpManage.Controls.Add(CtrlExit);
            #endregion

            #region Information
            //DS Nhân viên
            CtrlListEmployees = Dashboard.InitListEmployees();
            tlpInfo.Controls.Add(CtrlListEmployees);
            //DS Sinh viên
            CtrlListStudents = Dashboard.InitListStudents();
            tlpInfo.Controls.Add(CtrlListStudents);
            //Báo cáo
            CtrlReport = Dashboard.InitReport();
            tlpInfo.Controls.Add(CtrlReport);
            //DS Khu phòng
            CtrlBuildings = Dashboard.InitBuildings();
            tlpInfo.Controls.Add(CtrlBuildings);
            //DS Loại Phòng
            CtrlRoomType = Dashboard.InitRoomType();
            tlpInfo.Controls.Add(CtrlRoomType);
            //DS dịch vụ
            CtrlServices = Dashboard.InitServices();
            tlpInfo.Controls.Add(CtrlServices);
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