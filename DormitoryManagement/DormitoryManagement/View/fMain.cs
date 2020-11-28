using DormitoryManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        // để nút để test
        private void btnlogin_Click(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            this.Hide();
            fLogin.ShowDialog();

        }
    }
}
