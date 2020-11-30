using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DormitoryManagement.View
{
    public static class Dashboard
    {
        public static Item InitLogin(Item ctrlLogin)
        {
            ctrlLogin = new Item(Login);
            ctrlLogin.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogin.btnTitle.Text = "LOGIN";
            ctrlLogin.Anchor = AnchorStyles.Right;
            ctrlLogin.btnTitle.ForeColor = Color.DarkRed;
            return ctrlLogin;
        }

        public static Item InitLogout(Item ctrlLogout)
        {
            ctrlLogout = new Item(Dashboard.Logout);
            ctrlLogout.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogout.btnTitle.Text = "LOGOUT";
            ctrlLogout.btnTitle.ForeColor = Color.DarkRed;
            return ctrlLogout;
        }

        public static Item InitExit(Item ctrlExit)
        {
            ctrlExit = new Item(Dashboard.Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            return ctrlExit;
        }

        public static Item InitRoom(Item ctrlRoom)
        {
            ctrlRoom = new Item(Dashboard.RoomRegistration);
            ctrlRoom.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoom.btnTitle.Text = "ROOM";
            return ctrlRoom;
        }

        public static Item InitBill(Item ctrlBill)
        {
            ctrlBill = new Item(Dashboard.Bill);
            ctrlBill.picItem.BackgroundImage = Properties.Resources.Form;
            ctrlBill.btnTitle.Text = "BILL";
            return ctrlBill;
        }

        public static Item InitAddStudent(Item ctrlAddStudent)
        {
            ctrlAddStudent = new Item(Dashboard.AddNewStudent);
            ctrlAddStudent.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlAddStudent.btnTitle.Text = "STUDENT";
            return ctrlAddStudent;
        }

        public static Item InitAddEmployee(Item ctrlAddEmployee)
        {
            ctrlAddEmployee = new Item(Dashboard.AddNewEmployee);
            ctrlAddEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlAddEmployee.btnTitle.Text = "EMPLOYEE";
            return ctrlAddEmployee;
        }

        public static Item InitListEmployees(Item ctrlListEmployees)
        {
            ctrlListEmployees = new Item(ItemType.Employee);
            ctrlListEmployees.picItem.BackgroundImage = Properties.Resources.Collaboration;
            ctrlListEmployees.btnTitle.Text = "EMPLOYEES";
            return ctrlListEmployees;
        }    

        public static Item InitListStudents(Item ctrlListStudents)
        {
            ctrlListStudents = new Item(Dashboard.ListStudents);
            ctrlListStudents.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlListStudents.btnTitle.Text = "STUDENTS";
            return ctrlListStudents;
        }

        public static Item InitReport(Item ctrlReport)
        {
            ctrlReport = new Item(Dashboard.Report);
            ctrlReport.picItem.BackgroundImage = Properties.Resources.Report;
            ctrlReport.btnTitle.Text = "REPORT";
            return ctrlReport;
        }

        public static Item InitBuildings(Item ctrlBuildings)
        {
            ctrlBuildings = new Item(ItemType.Building);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            return ctrlBuildings;
        }    

        public static Item InitRoomType(Item ctrlRoomType)
        {
            ctrlRoomType = new Item(ItemType.RoomType);
            ctrlRoomType.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoomType.btnTitle.Text = "ROOM TYPES";
            return ctrlRoomType;
        }

        public static Item InitServices(Item ctrlServices)
        {
            ctrlServices = new Item(ItemType.Service);
            ctrlServices.picItem.BackgroundImage = Properties.Resources.Water;
            ctrlServices.btnTitle.Text = "SERVICES";
            return ctrlServices;
        }

        public static Item InitSearch(Item ctrlSearch)
        {
            ctrlSearch = new Item(Dashboard.Search);
            ctrlSearch.picItem.BackgroundImage = Properties.Resources.Search;
            ctrlSearch.btnTitle.Text = "SEARCH";
            return ctrlSearch;
        }

        public static Item InitGuide(Item ctrlGuide)
        {
            ctrlGuide = new Item(Dashboard.Guide);
            ctrlGuide.picItem.BackgroundImage = Properties.Resources.Info;
            ctrlGuide.btnTitle.Text = "GUIDE";
            return ctrlGuide;
        }

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

        public static void Search()
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();
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
            FrmRoomRegistration frmRoom = new FrmRoomRegistration();
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
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
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
