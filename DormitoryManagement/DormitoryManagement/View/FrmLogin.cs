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
            //Demo
            FrmDashboard dashboard = new FrmDashboard();
            this.Hide();
            dashboard.ShowDialog();
            return;

            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            if (Login(userName, passWord))
            {
                UserDTO user = UserDAO.GetUserByUsername(userName);
                string userType = user.UserType;
                long UserId = user.UserId;
                if (userType.Equals("ADMIN"))
                {
                    AdminDTO admin = AdminDAO.GetAdminById(UserId);
                    txtPassword.Text = "";
                }
                else if (userType.Equals("EMPLOYEE"))
                {
                    EmployeeDTO employee = EmployeeDAO.GetEmployeeById(UserId);
                    txtPassword.Text = "";
                }
                else
                {
                    StudentDTO student = StudentDAO.GetStudentById(UserId);
                    txtPassword.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGuest fMain = new FrmGuest();
            fMain.ShowDialog();
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
