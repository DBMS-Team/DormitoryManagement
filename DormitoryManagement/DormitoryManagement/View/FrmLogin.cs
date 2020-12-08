using DormitoryManagement.Controller;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            if (Login(userName, passWord))
            {
                UserDTO user = UserDAO.GetUserByUsername(userName);
                string userType = user.UserType;
                long UserId = user.UserId;
                if (userType.Equals("ADMIN") && user.Status == true)
                {
                    AdminDTO admin = AdminDAO.GetAdminById(UserId);
                    FrmAdmin frmAdmin = new FrmAdmin(admin, user);
                    this.Hide();
                    frmAdmin.ShowDialog();
                    txtPassword.Text = "";
                }
                else if (userType.Equals("EMPLOYEE") && user.Status == true)
                {
                    EmployeeDTO employee = EmployeeDAO.GetEmployeeById(UserId);
                    FrmEmployee frmEmployee = new FrmEmployee(employee, user);
                    this.Hide();
                    frmEmployee.ShowDialog();
                    txtPassword.Text = "";
                }
                else if (user.Status == true)
                {
                    StudentDTO student = StudentDAO.GetStudentById(UserId);
                    FrmStudent frmStudent = new FrmStudent(student, user);
                    this.Hide();
                    frmStudent.ShowDialog();
                    txtPassword.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGuest frmGuest = new FrmGuest();
            frmGuest.ShowDialog();
        }
        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.UseSystemPasswordChar == true)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region Methods 
        bool Login(string username, string password)
        {
            return UserDAO.Login(username, password);
        }
        #endregion
    }
}
