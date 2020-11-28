using DormitoryManagement.Controller;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain fMain = new fMain();
            fMain.ShowDialog();
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
