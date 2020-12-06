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
    public partial class FrmReport : Form
    {
        
        public FrmReport()
        {
            InitializeComponent();
            ctrlReportMonthly.ClickEvent += new ClickEvent(InitReportMonthly);
            ctrlReportAnnual.ClickEvent += new ClickEvent(InitReportAnnual);
        }

        public void InitReportMonthly()
        {
            FrmReportMonthly reportMonthly = new FrmReportMonthly();
            this.Hide();
            reportMonthly.ShowDialog();
            this.Dispose();
        }

        public void InitReportAnnual()
        {
            FrmReportAnnual reportAnnual = new FrmReportAnnual();
            this.Hide();
            reportAnnual.ShowDialog();
            this.Dispose();
        }
    }
}
