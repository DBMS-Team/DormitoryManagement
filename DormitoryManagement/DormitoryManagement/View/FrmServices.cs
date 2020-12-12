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
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmServiceInfo frmServiceInfo = new FrmServiceInfo();
            frmServiceInfo.btnDelete.Visible = false;
            frmServiceInfo.btnOK.Visible = true;
            frmServiceInfo.btnOK.Enabled = true;
            frmServiceInfo.btnEdit.Visible = false;
            frmServiceInfo.ShowDialog();
        }
    }
}
