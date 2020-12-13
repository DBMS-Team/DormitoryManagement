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
        private UserDTO loginUser;
        private StudentDTO loginStudent;
        #endregion

        #region Properties
        public UserDTO LoginUser
        {
            get => loginUser;
            set
            {
                this.loginUser = value;
            }
        }

        public StudentDTO LoginStudent
        {
            get => loginStudent;
            set
            {
                this.loginStudent = value;
            }
        }
        public string Img_path { get => img_path; set => img_path = value; }
        #endregion

        public FrmStudentInfo(StudentDTO student, UserDTO user)
        {
            InitializeComponent();
            this.LoginStudent = student;
            this.LoginUser = user;

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
            if (LoginUser.UserType.Equals("STUDENT"))
            {
                txtStudentID.Text = LoginStudent.StudentId;
                txtFirstName.Text = LoginUser.FirstName;
                txtLastName.Text = LoginUser.LastName;
                dateTimePicker1.Value = LoginUser.Dob;
                if (LoginUser.Gender.Equals("Nữ"))
                {
                    ckbFemale.Checked = true;
                }
                else
                    ckbFemale.Checked = false;
                txtID.Text = LoginUser.Ssn;
                txtHealthInsurance.Text = LoginStudent.InsuranceId;
                DataGridView gridView = new DataGridView();
                
                DataTable dt = UserDAO.GetListStudentView(LoginUser.UserId);
                cbbProvince.Text = dt.Rows[0][8].ToString();
                cbbDistrict.Text = dt.Rows[0][9].ToString();
                cbbCommune.Text = dt.Rows[0][10].ToString();
                txtAddress.Text = dt.Rows[0][7].ToString();
                cbbPriority.Text = "3";
                txtPhone1.Text = dt.Rows[0][11].ToString();
                txtPhone2.Text = dt.Rows[0][12].ToString();
                txtEmail.Text = dt.Rows[0][13].ToString();
                cbbUniversity.Text = dt.Rows[0][15].ToString();
                txtFaculty.Text = dt.Rows[0][16].ToString();
                txtMajor.Text = dt.Rows[0][17].ToString();
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                dateTimePicker1.Enabled = false;
                ckbFemale.Enabled = false;
                txtID.Enabled = false;
                txtStudentID.Enabled = false;
                txtHealthInsurance.Enabled = false;
                cbbProvince.Enabled = false;
                cbbDistrict.Enabled = false;
                cbbCommune.Enabled = false;
                txtAddress.Enabled = false;
                cbbPriority.Enabled = false;
                txtPhone1.Enabled = false;
                txtPhone2.Enabled = false;
                txtEmail.Enabled = false;
                cbbUniversity.Enabled = false;
                txtFaculty.Enabled = false;
                txtMajor.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = false;
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check dien day du du lieu khong
            if(LoginUser.UserType.Equals("EMPLOYEE"))
            {
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
                //Luu Du Lieu Vao data
                string AddRess = Convert.ToString(txtAddress.Text);
                string Commune_Name = Convert.ToString(cbbCommune.Text);
                string District_Name = Convert.ToString(cbbDistrict.Text);
                string Province_Name = Convert.ToString(cbbProvince.Text);
                string Insurance_ID = Convert.ToString(txtHealthInsurance.Text);
                string Last_Name = Convert.ToString(txtLastName.Text);
                string First_Name = Convert.ToString(txtFirstName.Text);
                DateTime DOB = dateTimePicker1.Value;
                string gender = "Nam";
                if (ckbFemale.Checked)
                {
                    gender = "Nữ";
                }
                string Ssn = Convert.ToString(txtID.Text);
                string Phone_Number_1 = Convert.ToString(txtPhone1.Text);
                string Phone_Number_2 = Convert.ToString(txtPhone2.Text);
                string Email = Convert.ToString(txtEmail.Text);
                string Image_Path = "NULL";
                string User_Type = "STUDENT";
                string Status = "1";
                string Student_ID = Convert.ToString(txtStudentID.Text);
                string College_Name = Convert.ToString(cbbUniversity.Text);
                string Faculty = Convert.ToString(txtFaculty.Text);
                string Major = Convert.ToString(txtMajor.Text);
                if (AddStudent(AddRess, Commune_Name, District_Name, Province_Name, Insurance_ID, Last_Name, First_Name,
                    DOB, gender, Ssn, Phone_Number_1, Phone_Number_2, Email, Image_Path, User_Type, Status, Student_ID, College_Name, Faculty, Major))
                {
                    MessageBox.Show("Add Studetn Success!");
                }
                else
                {
                    MessageBox.Show("Error!!!!");
                }
            }   
            else
            {
                string Ssn = Convert.ToString(txtID.Text);
                string Province_Name = Convert.ToString(cbbProvince.Text);
                string District_Name = Convert.ToString(cbbDistrict.Text);
                string Commune_Name = Convert.ToString(cbbCommune.Text);
                string Street = Convert.ToString(txtAddress.Text);
                string Phone1 = Convert.ToString(txtPhone1.Text);
                string Phone2 = Convert.ToString(txtPhone2.Text);
                string Email = Convert.ToString(txtEmail.Text);
                string College_Name = Convert.ToString(cbbUniversity.Text);
                string Faculty = Convert.ToString(txtFaculty.Text);
                string Major = Convert.ToString(txtMajor.Text);
                //StudentDAO.UpdateStudent(Ssn, Street, Commune_Name, District_Name, Province_Name, College_Name, Faculty, Major, Phone1, Phone2, Email);
                if(UpdateStudent(Ssn, Street, Commune_Name, District_Name, Province_Name, College_Name, Faculty, Major, Phone1, Phone2, Email))
                {
                    MessageBox.Show("Update Success!!!");
                }
            }    
        }
        bool AddStudent(string Street, string Commune_Name, string District_Name, string Province_Name, string Insurance_ID, string Last_Name, string First_Name, DateTime DoB, string Gender, string Ssn, string Phone_Number_1, string Phone_Number_2, string Email, string Image_Path, string User_Type, string Status, string Student_ID, string College_Name, string Faculty, string Majors)
        {
            return StudentDAO.AddStudent(Street, Commune_Name, District_Name, Province_Name, Insurance_ID, Last_Name, First_Name,
                DoB, Gender, Ssn, Phone_Number_1, Phone_Number_2, Email, Image_Path, User_Type, Status, Student_ID, College_Name, Faculty, Majors);
        }
        bool UpdateStudent(string Ssn, string Street, string Commune_Name, string District_Name, string Province_Name, string College_Name, string Faculty, string Major, string Phone_Number_1, string Phone_Number_2, string Email)
        {
            return StudentDAO.UpdateStudent(Ssn, Street, Commune_Name, District_Name, Province_Name, College_Name, Faculty, Major, Phone_Number_1, Phone_Number_2, Email);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            cbbProvince.Enabled = true;
            cbbDistrict.Enabled = true;
            cbbCommune.Enabled = true;
            txtAddress.Enabled = true;
            cbbPriority.Enabled = true;
            txtPhone1.Enabled = true;
            txtPhone2.Enabled = true;
            txtEmail.Enabled = true;
            cbbUniversity.Enabled = true;
            txtFaculty.Enabled = true;
            txtMajor.Enabled = true;
        }
    }
}