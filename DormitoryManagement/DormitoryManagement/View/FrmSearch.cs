﻿using DormitoryManagement.Controller;
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
        string indexSectorIdSelected="";
        string indexRoomIdSelected="";
        string SectorNameSelected="";
        int indexSelectedRoomRegistration = 0;
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
            AutoSizeModeColumn(dgvStudent);
            //
            GetListRoomRegistration();
            AutoSizeModeColumn(dgvRoomReg);
            GetListSector();
            txtInputRoomRegistration.Enabled = false;
            //

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
                else if (inputText.Length < 16)
                {
                    GetFullListStudentByStudentId(inputText);
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
        /// <summary>
        /// ---------------------------ROOM_REGISTRATION
        /// </summary>
        /// <param ></param>
        /// <param></param>
        private void cbbCategoryRoomReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            indexSelectedRoomRegistration = comboBox.SelectedIndex;
            switch (indexSelectedRoomRegistration)
            {
                case 0:
                    {
                        GetListRoomRegistration();
                        txtInputRoomRegistration.Enabled = false;
                        txtInputRoomRegistration.Text = "";
                        break;
                    }
                case 1:
                    {
                        GetListRoomRegistration();
                        txtInputRoomRegistration.Enabled = true;
                        txtInputRoomRegistration.Text = "";
                        break;
                    }
                case 2:
                    {
                        GetListRoomRegistration();
                        txtInputRoomRegistration.Enabled = true;
                        txtInputRoomRegistration.Text = "";
                        break;
                    }
                default:
                    {
                        GetListRoomRegistration();
                        txtInputRoomRegistration.Text = "";
                        break;
                    }
            }
        }
        private void cbbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            SectorDTO sectorDTO = (SectorDTO)comboBox.SelectedValue;
            indexSectorIdSelected = sectorDTO.SectorId;
            SectorNameSelected = sectorDTO.SectorName;
            GetListRoomBySectorId(indexSectorIdSelected);
            GetListRoomRegistrationByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }
        private void cbbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            RoomDTO roomDTO = (RoomDTO)comboBox.SelectedValue;
            indexRoomIdSelected = roomDTO.RoomId;
            GetListRoomRegistrationByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }
        private void txtInputRoomRegistration_TextChanged(object sender, EventArgs e)
        {
            string inputText = "";
            inputText = txtInputRoomRegistration.Text.Trim().ToString();
            
            if (indexSelectedRoomRegistration == 0)
            {
                if (txtInputRoomRegistration.Text == "")
                {
                    GetListRoomRegistration();
                }
            }
            else if (indexSelectedRoomRegistration == 1)
            {
                if (txtInputRoomRegistration.Text == "")
                {
                    GetListRoomRegistration();
                }
                else if (inputText.Length < 16)
                {
                    GetListRoomRegistrationByStudentId(inputText);
                }
            }
            else if (indexSelectedRoomRegistration == 2)
            {
                if (txtInputRoomRegistration.Text == "")
                {
                    GetListRoomRegistration();
                }
                else if (inputText.Length < 101)
                {
                    GetListRoomRegistrationByStudentName(inputText);
                }
            }
        }
        private void btnSearchRoomReg_Click(object sender, EventArgs e)
        {
            string test1 = indexSectorIdSelected;
            string test2 = indexRoomIdSelected;

        }
        /// <summary>
        /// ---------------------------BILL
        /// </summary>
        /// <param ></param>
        /// <param></param>
        /// 
        private void cbbBuiding_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            SectorDTO sectorDTO = (SectorDTO)comboBox.SelectedValue;
            indexSectorIdSelected = sectorDTO.SectorId;
            SectorNameSelected = sectorDTO.SectorName;
            GetListRoomBySectorId(indexSectorIdSelected);
        }
        #endregion

        #region Methods
        void AutoSizeModeColumn(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dgvStudent.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
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
        /// <summary>
        /// ---------------------------ROOM_REGISTRATION
        /// </summary>
        /// <param ></param>
        /// <param></param>
        void GetListRoomRegistration()
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistration();
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListSector()
        {
            List<SectorDTO> sectorDTOs = SectorDAO.GetListSector();
            cbbBuilding.DataSource = sectorDTOs;
            cbbBuilding.DisplayMember = "SectorName";
            cbbBuiding_Bill.DataSource = sectorDTOs;
            cbbBuiding_Bill.DisplayMember = "SectorName";
        }
        void GetListRoomBySectorId(string SectorId)
        {
            List<RoomDTO> roomDTOs = RoomDAO.GetListRoomBySector(SectorId);
            cbbRoom.DataSource = roomDTOs;
            cbbRoom.DisplayMember = "RoomId";
            cbbRoom_Bill.DataSource = roomDTOs;
            cbbRoom_Bill.DisplayMember = "RoomId";
        }
        void GetListRoomRegistrationByStudentId(string studentId)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByStudentId(studentId);
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListRoomRegistrationByStudentName(string studentName)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByStudentName(studentName);
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListRoomRegistrationByBuildingAndRoom(string building, string room)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByBuldingAndRoom(building,room);
            dgvRoomReg.DataSource = dataTable;
        }
        /// <summary>
        /// ---------------------------BILL
        /// </summary>
        /// <param ></param>
        /// <param></param>
        
        #endregion


    }
}
