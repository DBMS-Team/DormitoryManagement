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
    public partial class FrmStudentInfo : Form
    {
        #region Fields
        private string img_path;
        #endregion

        #region Properties
        public string Img_path { get => img_path; set => img_path = value; }
        #endregion

        public FrmStudentInfo()
        {
            InitializeComponent();
        }
        bool flagAddStudent = false;
        string provinceName = "";
        string districtName = "";

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

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            provinceName = comboBox.Text;
            LoadListDistrictByProvinceName(provinceName);
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            districtName = comboBox.Text;
            LoadListCommunateByProvinceName(provinceName, districtName);
        }

        private void cmbCommune_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region methods
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
        void LoadListCommunateByProvinceName(string provinceName, string districtName)
        {
            List<CommuneDTO> communeDTOs = CommuneDAO.GetLisCommuneByProvinceAndDistrict(provinceName, districtName);
            cbbCommune.DataSource = communeDTOs;
            cbbCommune.DisplayMember = "CommuneName";
        }
        void LoadListCollege()
        {
            List<CollegeDTO> ListCollege = CollegeDAO.GetListColloge();
            cbbUniversity.DataSource = ListCollege;
            cbbUniversity.DisplayMember = "CollegeName";
        }
        void LoadListUniversityInCombobox()
        {

        }
        #endregion

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            LoadListProvinceInCombobox();
            LoadListCollege();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check dien day du du lieu khong
            #region Check input
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap MSSV");
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap Ho cua Minh");
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap Ten Lot Va Ten Cua Minh");
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap CMND");
            }
            else if (txtHealthInsurance.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap So Bao Hiem Y Te");
            }
            else if (cbbProvince.Text == "")
            {
                MessageBox.Show("Ban Chua Chon Thanh Pho");
            }
            else if (cbbDistrict.Text == "")
            {
                MessageBox.Show("Ban Chua Chon Huyen");
            }
            else if (cbbCommune.Text == "")
            {
                MessageBox.Show("Ban Chua Chon Xa");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Ban Chua Nhap Dia Chi");
            }
            else if (txtPhone1.Text == "")
            {
                MessageBox.Show("Ban chua nhap sdt 1");
            }
            else if (txtPhone2.Text == "")
            {
                MessageBox.Show("Ban chua nhap sdt 2");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Ban chua nhap email");
            }
            else if (cbbUniversity.Text == "")
            {
                MessageBox.Show("Ban chua chon ten truong");
            }
            else if (txtFaculty.Text == "")
            {
                MessageBox.Show("Ban chua chon Khoa");
            }
            else if (txtMajor.Text == "")
            {
                MessageBox.Show("ban chua chon Nganh Hoc");
            }
            #endregion
            //Luu Du Lieu Vao data

        }
    }
}