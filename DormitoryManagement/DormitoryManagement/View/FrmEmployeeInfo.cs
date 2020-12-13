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
    public partial class FrmEmployeeInfo : Form
    {
        #region Fields
        private string img_path;
        private bool isOnlyViewInfo = false;
        #endregion

        #region Properties
        public string Img_path { get => img_path; set => img_path = value; }

        /// <summary>
        /// Check xem form đang được tạo để thêm mới nhân viên hay chỉ để xem thông tin của user
        /// </summary>
        public bool IsOnlyViewInfo { get => isOnlyViewInfo; set => isOnlyViewInfo = value; }
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
            cbbPriority.DataSource = communeDTOs;
            cbbPriority.DisplayMember = "Priority";
        }
        bool AddEmployee(string lastName, string firstName, DateTime dob, string gender, string ssn, string phoneNumber1,
            string phoneNumber2, string email, string imagePath, string userType, string provinceName, string districtName, string communeName,
            string street, DateTime startDate, string salary)
        {
            return UserDAO.AddUser(lastName, firstName, dob, gender, ssn, phoneNumber1, phoneNumber2, email, imagePath, userType, provinceName, districtName, communeName,
            street, startDate, salary);
        }
       #endregion

        #region Events
        private void FrmEmployeeInfo_Load(object sender, EventArgs e)
        {
            LoadListProvinceInCombobox();
            if (IsOnlyViewInfo)
            {
                //Load Employee's info
            }   
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
            LoadListCommunateByProvinceNameInCombobox(provinceName, districtName);
        }
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("FirstName Not Null", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if (txtLastName.Text == "" && flag == 0)
                {
                    MessageBox.Show("LastName Not Null", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if ((txtSSN.Text == "" && flag == 0) || FormatData.IsSSN(txtSSN.Text) == false)
                {
                    MessageBox.Show("Not Is SSN", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if (txtStreet.Text == "" && flag == 0)
                {
                    MessageBox.Show("Street Not Null", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if ((txtPhone1.Text == "" && flag == 0) || FormatData.IsPhone(txtPhone1.Text) == false)
                {
                    MessageBox.Show("Not Is Phone Number 1", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if ((txtPhone2.Text == "" && flag == 0) || FormatData.IsPhone(txtPhone2.Text) == false)
                {
                    MessageBox.Show("Not Is Phone Number 2", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if ((txtEmail.Text == "" && flag == 0) || FormatData.IsEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Not Is Mail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if ((txtSalary.Text == "" && flag == 0) || FormatData.IsNumber(txtSalary.Text) == false)
                {
                    MessageBox.Show("Not Is Salary", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else if (txtStreet.Text.Length > 50 && flag == 0)
                {
                    MessageBox.Show("Stree < 50", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                string lastName = txtLastName.Text;
                lastName = FormatData.CapitalizeEachWord(lastName);
                string firstName = txtFirstName.Text;
                firstName = FormatData.CapitalizeEachWord(firstName);
                DateTime dob = dtpDoB.Value;
                string gender;
                if (ckbFemale.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                string ssn = txtSSN.Text.Trim().ToString();
                string phoneNumber1 = txtPhone1.Text.Trim().ToString();
                string phoneNumber2 = txtPhone2.Text.Trim().ToString();
                string email = txtEmail.Text.Trim().ToString();
                string imagePath = "tobe";
                string userType = cbbUserType.Text;
                string provinceName = cbbProvince.Text;
                string districtName = cbbDistrict.Text;
                string communeName = cbbCommune.Text;
                string street = txtStreet.Text;
                street = FormatData.CapitalizeEachWord(street);
                DateTime startDate = dtpStartDate.Value;
                string salary = txtSalary.Text;
                List<UserDTO> userDTOs = UserDAO.GetListUser();
                foreach (var item in userDTOs)
                {
                    if (item.Ssn.Equals(ssn) && flag == 0)
                    {
                        MessageBox.Show("SSN already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                    if (item.PhoneNumber1.Equals(phoneNumber1) && flag == 0)
                    {
                        MessageBox.Show("Phone already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                    if (item.PhoneNumber2.Equals(phoneNumber1) && flag == 0)
                    {
                        MessageBox.Show("Phone already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                    if (item.PhoneNumber1.Equals(phoneNumber2) && flag == 0)
                    {
                        MessageBox.Show("Phone already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                    if (item.PhoneNumber2.Equals(phoneNumber2) && flag == 0)
                    {
                        MessageBox.Show("Phone already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                    if (item.Email.Equals(email) && flag == 0)
                    {
                        MessageBox.Show("Phone already exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        return;
                    }
                }
                if (flag == 0)
                {
                    if (AddEmployee(lastName, firstName, dob, gender, ssn, phoneNumber1, phoneNumber2, email, imagePath, userType, provinceName, districtName, communeName,
                street, startDate, salary))
                    {
                        MessageBox.Show("Added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLastName.Text = "";
                        txtFirstName.Text = "";
                        txtSSN.Text = "";
                        txtPhone1.Text = "";
                        txtPhone2.Text = "";
                        txtEmail.Text = "";
                        txtStreet.Text = "";
                        txtSalary.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("One of the problems is faulty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
            
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion
    }
}
