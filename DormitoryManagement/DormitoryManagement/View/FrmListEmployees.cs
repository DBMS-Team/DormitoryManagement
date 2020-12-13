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
    public partial class FrmListEmployees : Form
    {
        public FrmListEmployees()
        {
            InitializeComponent();
        }

        private void FrmListEmployees_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = EmployeeDAO.GetEmployees();
            txtQuantity.Text =(dgvEmployees.Rows.Count - 1).ToString();
            AutoSizeModeColumn(dgvEmployees);

        }
        void AutoSizeModeColumn(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count -1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
