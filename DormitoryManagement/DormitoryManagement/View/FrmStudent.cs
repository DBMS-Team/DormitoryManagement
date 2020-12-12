﻿using DormitoryManagement.Model;
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
        private Item ctrlBill;
        private Item ctrlStudentInfo;
        private Item ctrlRoomRegistration;
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
        public Item CtrlBill { get => ctrlBill; set => ctrlBill = value; }
        public Item CtrlStudentInfo { get => ctrlStudentInfo; set => ctrlStudentInfo = value; }
        public Item CtrlRoom { get => ctrlRoomRegistration; set => ctrlRoomRegistration = value; }
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
            CtrlLogout = Dashboard.InitLogout(this);
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
            //Hướng dẫn
            CtrlGuide = Dashboard.InitGuide();
            tlpInfo.Controls.Add(CtrlGuide);
            #endregion

            #region Persional Information
            //Phòng
            CtrlRoom = Dashboard.InitRoom(Dashboard.User);
            tlpPersionalInfo.Controls.Add(CtrlRoom);
            //Hoá đơn
            CtrlBill = Dashboard.InitBill(LoginUser);
            tlpPersionalInfo.Controls.Add(CtrlBill);
            //Sinh viên
            CtrlStudentInfo = Dashboard.InitStudentInfo();
            tlpPersionalInfo.Controls.Add(CtrlStudentInfo);
            #endregion
        }
        #endregion
    }
}
