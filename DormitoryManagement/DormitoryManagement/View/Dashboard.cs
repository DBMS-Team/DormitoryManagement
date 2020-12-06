using System.Drawing;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public static class Dashboard
    {
        #region Init

        #region General
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

        public static Item InitChangePassword(object account)
        {
            Item ctrlChangePassword = new Item(Dashboard.ChangePassword, account);
            ctrlChangePassword.picItem.BackgroundImage = Properties.Resources.ForgotPassword;
            ctrlChangePassword.btnTitle.Text = "CHANGE";
            ctrlChangePassword.btnTitle.ForeColor = Color.DarkRed;
            return ctrlChangePassword;
        }

        public static Item InitExit()
        {
            Item ctrlExit = new Item(Dashboard.Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            return ctrlExit;
        }
        #endregion

        #region Add

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
            Item ctrlAddStudent = new Item(Dashboard.StudentInfo);
            ctrlAddStudent.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlAddStudent.btnTitle.Text = "STUDENT";
            return ctrlAddStudent;
        }

        public static Item InitAddEmployee()
        {
            Item ctrlAddEmployee = new Item(Dashboard.EmployeeInfo);
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
        #endregion

        #region Information
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

        public static Item InitSearch()
        {
            Item ctrlSearch = new Item(Dashboard.Search);
            ctrlSearch.picItem.BackgroundImage = Properties.Resources.Search;
            ctrlSearch.btnTitle.Text = "SEARCH";
            return ctrlSearch;
        }

        public static Item InitReport()
        {
            Item ctrlReport = new Item(Dashboard.Report);
            ctrlReport.picItem.BackgroundImage = Properties.Resources.Report;
            ctrlReport.btnTitle.Text = "REPORT";
            return ctrlReport;
        }

        public static Item InitListBuildings()
        {
            Item ctrlBuildings = new Item(Dashboard.ListBuildings);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            return ctrlBuildings;
        }

        public static Item InitListRoomType()
        {
            Item ctrlRoomType = new Item(Dashboard.ListRoomTypes);
            ctrlRoomType.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoomType.btnTitle.Text = "ROOM TYPES";
            return ctrlRoomType;
        }

        public static Item InitListServices()
        {
            Item ctrlServices = new Item(Dashboard.ListServices);
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

        #endregion

        #region Delegate method

        #region General
        public static void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        public static void Logout()
        {
            DialogResult re = MessageBox.Show("Bạn muốn đăng xuất khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                
            }
        }

        public static void ChangePassword(object account)
        {
            FrmChangePassword changePassword = new FrmChangePassword();
            changePassword.ShowDialog();
        }

        public static void Exit()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Add
        public static void Bill()
        {
            FrmBill frmBill = new FrmBill();
            frmBill.ShowDialog();
        }

        public static void RoomRegistration()
        {
            FrmRoomRegistration frmDangKyPhong = new FrmRoomRegistration();
            frmDangKyPhong.ShowDialog();
        }

        public static void EmployeeInfo()
        {
            FrmEmployeeInfo frmEmployeeInfo = new FrmEmployeeInfo();
            frmEmployeeInfo.ShowDialog();
        }

        public static void StudentInfo()
        {
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo();
            frmStudentInfo.ShowDialog();
        }
        #endregion

        #region Information

        public static void Room()
        {
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.ShowDialog();
        }

        public static void ListStudents()
        {
            FrmStudent frmStudent = new FrmStudent(null, null);
            frmStudent.ShowDialog();
        }

        public static void ListServices()
        {
            FrmServices frmServices = new FrmServices();
            frmServices.ShowDialog();
        }

        public static void ListBuildings()
        {
            FrmBuildings frmBuildings = new FrmBuildings();
            frmBuildings.ShowDialog();
        }

        public static void ListRoomTypes()
        {
            FrmRoomTypes frmRoomTypes = new FrmRoomTypes();
            frmRoomTypes.ShowDialog();
        }

        public static void Guide()
        {
            FrmGuide frmGuide = new FrmGuide();
            frmGuide.ShowDialog();
        }

        public static void Search()
        {
            FrmSearch search = new FrmSearch();
            search.ShowDialog();
        }

        public static void Report()
        {
            FrmReport report = new FrmReport();
            report.ShowDialog();
        }
        #endregion

        #endregion
    }
}
