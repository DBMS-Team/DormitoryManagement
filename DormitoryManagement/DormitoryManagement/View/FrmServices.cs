using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.Controller;

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

        private void FrmServices_Load(object sender, EventArgs e)
        {
            dgvServices.DataSource = ServiceDAO.GetServicesInfo();
            dgvServices.Columns[0].HeaderText = "Service ID";
            dgvServices.Columns[1].HeaderText = "Service Name";
            dgvServices.Columns[2].HeaderText = "Price/Unit";
            dgvServices.Columns[3].HeaderText = "Unit";
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
