using System.Drawing;
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
        private Item ctrlSearch;
        private Item ctrlGuide;

        private Item ctrlListStudents;
        private Item ctrlListEmployees;
        private Item ctrlRoom;
        private Item ctrlBill;
        private Item ctrlAddStudent;
        private Item ctrlAddEmployee;
        private Item ctrlReport;

        #endregion

        #region Properties
        public Item CtrlLogout { get => ctrlLogout; set => ctrlLogout = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        public Item CtrlListStudents { get => ctrlListStudents; set => ctrlListStudents = value; }
        public Item CtrlRoom { get => ctrlRoom; set => ctrlRoom = value; }
        public Item CtrlBill { get => ctrlBill; set => ctrlBill = value; }
        public Item CtrlListEmployees { get => ctrlListEmployees; set => ctrlListEmployees = value; }
        public Item CtrlAddStudent { get => ctrlAddStudent; set => ctrlAddStudent = value; }
        public Item CtrlReport { get => ctrlReport; set => ctrlReport = value; }
        public Item CtrlAddEmployee { get => ctrlAddEmployee; set => ctrlAddEmployee = value; }
        #endregion

        public FrmAdmin()
        {
            this.InitializeComponent();
            Init();
        }

        protected void Init()
        {
            #region Management
            //Đăng xuất
            ctrlLogout = new Item(Logout);
            ctrlLogout.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogout.btnTitle.Text = "LOGOUT";
            ctrlLogout.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlLogout);
            //Thoát
            ctrlExit = new Item(Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlExit);
            #endregion

            #region Information
            //DS Nhân viên
            CtrlListEmployees = new Item(ItemType.Employee);
            CtrlListEmployees.picItem.BackgroundImage = Properties.Resources.Collaboration;
            CtrlListEmployees.btnTitle.Text = "EMPLOYEES";
            tlpInfo.Controls.Add(CtrlListEmployees);
            //DS Sinh viên
            CtrlListStudents = new Item(ListStudents);
            CtrlListStudents.picItem.BackgroundImage = Properties.Resources.Student;
            CtrlListStudents.btnTitle.Text = "STUDENTS";
            tlpInfo.Controls.Add(CtrlListStudents);
            //Báo cáo
            CtrlReport = new Item(BaoCao);
            CtrlReport.picItem.BackgroundImage = Properties.Resources.Report;
            CtrlReport.btnTitle.Text = "REPORT";
            CtrlReport.Dock = DockStyle.Top;
            tlpInfo.Controls.Add(CtrlReport);
            //DS Khu phòng
            ctrlBuildings = new Item(ItemType.Building);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            tlpInfo.Controls.Add(ctrlBuildings);
            //DS Loại Phòng
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
            #endregion

            #region Add
            //Phòng
            CtrlRoom = new Item(RoomRegistration);
            CtrlRoom.picItem.BackgroundImage = Properties.Resources.BunkBed;
            CtrlRoom.btnTitle.Text = "ROOM";
            tlpAdd.Controls.Add(CtrlRoom);
            //Hoá đơn
            CtrlBill = new Item(Bill);
            CtrlBill.picItem.BackgroundImage = Properties.Resources.Form;
            CtrlBill.btnTitle.Text = "BILL";
            tlpAdd.Controls.Add(CtrlBill);
            //Sinh viên
            ctrlAddStudent = new Item(AddNewStudent);
            ctrlAddStudent.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlAddStudent.btnTitle.Text = "STUDENT";
            tlpAdd.Controls.Add(CtrlAddStudent);
            //Nhân viên
            ctrlAddEmployee = new Item(AddNewEmployee);
            ctrlAddEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlAddEmployee.btnTitle.Text = "EMPLOYEE";
            tlpAdd.Controls.Add(CtrlAddEmployee);
            #endregion
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
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();
        }

        protected void Guide()
        {
            FrmGuide frmGuide = new FrmGuide();
            frmGuide.ShowDialog();
        }

        private void Bill()
        {
            FrmBill frmBill = new FrmBill();
            frmBill.ShowDialog();
        }

        private void Room()
        {
            FrmRoomRegistration frmRoom = new FrmRoomRegistration();
            frmRoom.ShowDialog();
        }

        private void ListStudents()
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.ShowDialog();
        }

        private void RoomRegistration()
        {
            FrmRoomRegistration frmDangKyPhong = new FrmRoomRegistration();
            frmDangKyPhong.ShowDialog();
        }

        private void AddNewEmployee()
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();
        }
        private void AddNewStudent()
        {
            FrmAddNewStudent frmSinhVien = new FrmAddNewStudent();
            frmSinhVien.ShowDialog();
        }

        private void BaoCao()
        {
            FrmReport baoCao = new FrmReport();
            baoCao.ShowDialog();
        }
    }
}
