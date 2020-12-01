using System.Drawing;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public static class Dashboard
    {
        #region Init
        public static Item InitLogin()
        {
            Item ctrlLogin = new Item(Login);
            ctrlLogin.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogin.btnTitle.Text = "LOGIN";
            ctrlLogin.btnTitle.ForeColor = Color.DarkRed;
            return ctrlLogin;
        }

        public static Item InitLogout()
        {
            Item ctrlLogout = new Item(Dashboard.Logout);
            ctrlLogout.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogout.btnTitle.Text = "LOGOUT";
            ctrlLogout.btnTitle.ForeColor = Color.DarkRed;
            return ctrlLogout;
        }

        public static Item InitExit()
        {
            Item ctrlExit = new Item(Dashboard.Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            return ctrlExit;
        }

        public static Item InitRoom()
        {
            Item ctrlRoom = new Item(Dashboard.Room);
            ctrlRoom.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoom.btnTitle.Text = "ROOM";
            return ctrlRoom;
        }

        public static Item InitBill()
        {
            Item ctrlBill = new Item(Dashboard.Bill);
            ctrlBill.picItem.BackgroundImage = Properties.Resources.Form;
            ctrlBill.btnTitle.Text = "BILL";
            return ctrlBill;
        }

        public static Item InitAddStudent()
        {
            Item ctrlAddStudent = new Item(Dashboard.AddNewStudent);
            ctrlAddStudent.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlAddStudent.btnTitle.Text = "STUDENT";
            return ctrlAddStudent;
        }

        public static Item InitAddEmployee()
        {
            Item ctrlAddEmployee = new Item(Dashboard.AddNewEmployee);
            ctrlAddEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlAddEmployee.btnTitle.Text = "EMPLOYEE";
            return ctrlAddEmployee;
        }

        public static Item InitRoomRegistration()
        {
            Item ctrlRoomRegistration = new Item(Dashboard.RoomRegistration);
            ctrlRoomRegistration.picItem.BackgroundImage = Properties.Resources.Room;
            ctrlRoomRegistration.btnTitle.Text = "ROOM";
            return ctrlRoomRegistration;
        }

        public static Item InitListEmployees()
        {
            Item ctrlListEmployees = new Item(ItemType.Employee);
            ctrlListEmployees.picItem.BackgroundImage = Properties.Resources.Collaboration;
            ctrlListEmployees.btnTitle.Text = "EMPLOYEES";
            return ctrlListEmployees;
        }

        public static Item InitListStudents()
        {
            Item ctrlListStudents = new Item(Dashboard.ListStudents);
            ctrlListStudents.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlListStudents.btnTitle.Text = "STUDENTS";
            return ctrlListStudents;
        }

        public static Item InitReport()
        {
            Item ctrlReport = new Item(Dashboard.Report);
            ctrlReport.picItem.BackgroundImage = Properties.Resources.Report;
            ctrlReport.btnTitle.Text = "REPORT";
            return ctrlReport;
        }

        public static Item InitBuildings()
        {
            Item ctrlBuildings = new Item(ItemType.Building);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            return ctrlBuildings;
        }

        public static Item InitRoomType()
        {
            Item ctrlRoomType = new Item(ItemType.RoomType);
            ctrlRoomType.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoomType.btnTitle.Text = "ROOM TYPES";
            return ctrlRoomType;
        }

        public static Item InitServices()
        {
            Item ctrlServices = new Item(ItemType.Service);
            ctrlServices.picItem.BackgroundImage = Properties.Resources.Water;
            ctrlServices.btnTitle.Text = "SERVICES";
            return ctrlServices;
        }

        public static Item InitGuide()
        {
            Item ctrlGuide = new Item(Dashboard.Guide);
            ctrlGuide.picItem.BackgroundImage = Properties.Resources.Info;
            ctrlGuide.btnTitle.Text = "GUIDE";
            return ctrlGuide;
        }
        #endregion

        public static void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.
        }

        public static void Logout()
        {
            DialogResult re = MessageBox.Show("Bạn muốn đăng xuất khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                //isExit = false;
                //FrmDangNhap.exit = false;
                //this.Dispose();
            }
        }

        public static void Exit()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void Guide()
        {
            FrmGuide frmGuide = new FrmGuide();
            frmGuide.ShowDialog();
        }

        public static void Bill()
        {
            FrmBill frmBill = new FrmBill();
            frmBill.ShowDialog();
        }

        public static void Room()
        {
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.ShowDialog();
        }

        public static void ListStudents()
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.ShowDialog();
        }

        public static void RoomRegistration()
        {
            FrmRoomRegistration frmDangKyPhong = new FrmRoomRegistration();
            frmDangKyPhong.ShowDialog();
        }

        public static void AddNewEmployee()
        {
            FrmAddNewEmployee frmAddEmployee = new FrmAddNewEmployee();
            frmAddEmployee.ShowDialog();
        }

        public static void AddNewStudent()
        {
            FrmAddNewStudent frmSinhVien = new FrmAddNewStudent();
            frmSinhVien.ShowDialog();
        }

        public static void Report()
        {
            FrmReport baoCao = new FrmReport();
            baoCao.ShowDialog();
        }
    }
}
