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
    public partial class FrmReportMonthly : Form
    {
        public FrmReportMonthly()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

            this.rpvReport.RefreshReport();
            
        }
    }
}
