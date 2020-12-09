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
    public partial class FrmSearch : Form
    {
        #region Var
        int indexSelected;
        #endregion
        public FrmSearch()
        {
            InitializeComponent();
        }
        #region Events
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            GetFullListStudent();
            txtInputStudent.Enabled = false;
        }
        /// <summary>
        /// ---------------------------STUDENTS
        /// </summary>
        /// <param ></param>
        /// <param></param>
        private void cbbCategoryStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            indexSelected = comboBox.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                {
                    GetFullListStudent();
                    txtInputStudent.Enabled = false;
                    txtInputStudent.Text = "";
                    break;
                }  
                case 1:
                {
                    GetFullListStudentALive();
                    txtInputStudent.Enabled = false;
                    txtInputStudent.Text = "";
                    break;
                }
                case 2:
                {
                    GetFullListStudentGoingOut();
                    txtInputStudent.Enabled = false;
                    txtInputStudent.Text = "";
                    break;
                }
                default:
                {
                    GetFullListStudent();
                    txtInputStudent.Enabled = true;
                    txtInputStudent.Text = "";
                    break;
                }
            }
        }
        private void txtInputStudent_TextChanged(object sender, EventArgs e)
        {
            string inputText = "";
            inputText = txtInputStudent.Text.Trim().ToString();
            if (indexSelected == 3)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }    
                else if (txtInputStudent.Text == "HHH")
                {
                    txtInputStudent.Text = "";
                }
                else if (FormatData.IsNumber(inputText) == true && inputText.Length < 10)
                {
                    GetFullListStudentByUserId(inputText);
                }
                else if (txtInputStudent.Text != "")
                {
                    txtInputStudent.Text = "HHH";
                }
            }
            else if (indexSelected == 4)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (txtInputStudent.Text == "HHH")
                {
                    txtInputStudent.Text = "";
                }
                else if (FormatData.IsNumber(inputText) == true && inputText.Length < 16)
                {
                    GetFullListStudentByStudentId(inputText);
                }
                else if (txtInputStudent.Text != "")
                {
                    txtInputStudent.Text = "HHH";
                }
            }
            else if (indexSelected == 5)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 101)
                {
                    GetFullListStudentByFullName(inputText);
                }
            }
            else if (indexSelected == 6)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 11)
                {
                    GetFullListStudentByGender(inputText);
                }
            }
            else if (indexSelected == 7)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 13)
                {
                    GetFullListStudentBySsn(inputText);
                }
            }
            else if (indexSelected == 8)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 150)
                {
                    GetFullListStudentByCollege(inputText);
                }
            }
        }
        #endregion

        #region Methods
        void GetFullListStudent()
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.GetListStudentView();
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentALive()
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.GetListStudentViewALive();
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentGoingOut()
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.GetListStudentViewGoingOut();
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentByUserId(string userId)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewByUserId(userId);
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentByStudentId(string studentId)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewByStudentId(studentId);
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentByFullName(string fullName)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewByFullName(fullName);
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentByGender(string gender)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewByGender(gender);
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentBySsn(string ssn)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewBySsn(ssn);
            dgvStudent.DataSource = studentViewDTOs;
        }
        void GetFullListStudentByCollege(string college)
        {
            List<StudentViewDTO> studentViewDTOs = StudentViewDAO.SearchStudentViewByCollege(college);
            dgvStudent.DataSource = studentViewDTOs;
        }
        #endregion


    }
}
