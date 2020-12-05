using DormitoryManagement.Controller;
using DormitoryManagement.Model;
using DormitoryManagement.Utility;
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
        string provinceName = "";
        string districtName = "";
        #endregion

        #region Events
        private void FrmAddNewEmployee_Load(object sender, EventArgs e)
        {
            LoadListProvinceInCombobox();
            LoadListAdminInCombobox();
        }
        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            provinceName = comboBox.Text;
            LoadListDistrictByProvinceNameInCombobox(provinceName);
        }
        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            districtName = comboBox.Text;
            LoadListCommunateByProvinceNameInCombobox(provinceName,districtName);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if(txtLastName.Text == "")
            {
                MessageBox.Show("LastName Not Null", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else if (txtFirstName.Text == "" && flag == 0 )
            {
                MessageBox.Show("FirstName Not Null", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else if (txtStreet.Text == "" && flag == 0)
            {
                MessageBox.Show("Street Not Null", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else if ((txtPhone1.Text == "" && flag == 0) || FormatData.IsEmail(txtPhone1.Text) == false)
            {
                MessageBox.Show("Not Is Phone Number", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else if (txtEmail.Text == "" && flag == 0 && FormatData.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Not Is Mail", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
        }
        #endregion

        #region Methods
        void LoadListProvinceInCombobox()
        {
            List<ProvinceDTO> provinceDTOs = ProvinceDAO.GetListProvince();
            cbbProvince.DataSource = provinceDTOs;
            cbbProvince.DisplayMember = "ProvinceName";
        }
        void LoadListDistrictByProvinceNameInCombobox(string provinceName)
        {
            List<DistrictDTO> districtDTOs = DistrictDAO.GetListDistrictByProvinceName(provinceName);
            cbbDistrict.DataSource = districtDTOs;
            cbbDistrict.DisplayMember = "DistrictName";
        }
        void LoadListCommunateByProvinceNameInCombobox(string provinceName,string districtName)
        {
            List<CommuneDTO> communeDTOs = CommuneDAO.GetLisCommuneByProvinceAndDistrict(provinceName,districtName);
            cbbCommnune.DataSource = communeDTOs;
            cbbCommnune.DisplayMember = "CommuneName";
        }
        void LoadListAdminInCombobox()
        {
            List<UserDTO> adminDTOs = AdminDAO.GetListAdmin();
            cbbManager.DataSource = adminDTOs;
            cbbManager.DisplayMember = "LastName";
        }

        #endregion

        
    }
}
