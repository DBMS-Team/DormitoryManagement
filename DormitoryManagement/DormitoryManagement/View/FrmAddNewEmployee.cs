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
    public partial class FrmAddNewEmployee : Form
    {
        public FrmAddNewEmployee()
        {
            InitializeComponent();
        }
        #region Var
        bool flagAddEmployee = false;
        #endregion

        #region Events
        private void FrmAddNewEmployee_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            LoadProvinceInCombobox();
        }
        #endregion

        #region Methods
        void LoadProvinceInCombobox()
        {
            List<ProvinceDTO> provinceDTOs = ProvinceDAO.GetListProvince();
            cbbProvince.DataSource = provinceDTOs;
            cbbProvince.DisplayMember = "ProvinceName";
        }
        #endregion


    }
}
