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
            LoadListCommunateByProvinceNameInCombobox(provinceName,districtName);
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
        
        void LoadListCommunateByProvinceNameInCombobox(string provinceName,string districtName)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
