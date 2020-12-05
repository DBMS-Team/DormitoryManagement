<<<<<<< HEAD:DormitoryManagement/DormitoryManagement/View/FrmAddNewEmployee.cs
﻿using DormitoryManagement.Controller;
using DormitoryManagement.Model;
using System;
=======
﻿using System;
>>>>>>> f23f06229bbce7834c4536a592179e2eedee5920:DormitoryManagement/DormitoryManagement/View/FrmEmployeeInfo.cs
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.Controller;
using DormitoryManagement.Model;

namespace DormitoryManagement.View
{
    public partial class FrmEmployeeInfo : Form
    {
        #region Fields
        private string img_path;
        #endregion

        #region Properties
        public string Img_path { get => img_path; set => img_path = value; }
        #endregion

        public FrmEmployeeInfo()
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
            btnSave.Enabled = false;
            LoadListProvinceInCombobox();
        }
        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            provinceName = comboBox.Text;
            LoadListDistrictByProvinceName(provinceName);
        }
        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            districtName = comboBox.Text;
<<<<<<< HEAD:DormitoryManagement/DormitoryManagement/View/FrmEmployeeInfo.cs
<<<<<<< HEAD:DormitoryManagement/DormitoryManagement/View/FrmAddNewEmployee.cs
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
=======
            LoadListCommunateByProvinceName(provinceName, districtName);
>>>>>>> f23f06229bbce7834c4536a592179e2eedee5920:DormitoryManagement/DormitoryManagement/View/FrmEmployeeInfo.cs
=======
            LoadListCommunateByProvinceName(provinceName,districtName);
>>>>>>> parent of ece0217 (update employee):DormitoryManagement/DormitoryManagement/View/FrmAddNewEmployee.cs
        }
        #endregion

        #region Methods
        void LoadListProvinceInCombobox()
        {
            List<ProvinceDTO> provinceDTOs = ProvinceDAO.GetListProvince();
            cbbProvince.DataSource = provinceDTOs;
            cbbProvince.DisplayMember = "ProvinceName";
        }
        void LoadListDistrictByProvinceName(string provinceName)
        {
            List<DistrictDTO> districtDTOs = DistrictDAO.GetListDistrictByProvinceName(provinceName);
            cbbDistrict.DataSource = districtDTOs;
            cbbDistrict.DisplayMember = "DistrictName";
        }
<<<<<<< HEAD:DormitoryManagement/DormitoryManagement/View/FrmEmployeeInfo.cs
<<<<<<< HEAD:DormitoryManagement/DormitoryManagement/View/FrmAddNewEmployee.cs
        void LoadListCommunateByProvinceNameInCombobox(string provinceName,string districtName)
=======
        void LoadListCommunateByProvinceName(string provinceName, string districtName)
>>>>>>> f23f06229bbce7834c4536a592179e2eedee5920:DormitoryManagement/DormitoryManagement/View/FrmEmployeeInfo.cs
=======
        void LoadListCommunateByProvinceName(string provinceName,string districtName)
>>>>>>> parent of ece0217 (update employee):DormitoryManagement/DormitoryManagement/View/FrmAddNewEmployee.cs
        {
            List<CommuneDTO> communeDTOs = CommuneDAO.GetLisCommuneByProvinceAndDistrict(provinceName, districtName);
            cbbCommune.DataSource = communeDTOs;
            cbbCommune.DisplayMember = "CommuneName";
        }

        #endregion

        #region Events

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Multiselect = false,
            };
            DialogResult re = dialog.ShowDialog();
            if (re == DialogResult.OK)
            {
                Img_path = dialog.FileName;
                picAvt.BackgroundImage = Image.FromFile(Img_path);
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
