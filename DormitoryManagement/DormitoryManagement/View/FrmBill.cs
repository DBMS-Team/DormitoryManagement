﻿using System;
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
using DormitoryManagement.Utility;

namespace DormitoryManagement.View
{
    public partial class FrmBill : Form
    {
        private bool payment_status; 
        private UserDTO user;
        public UserDTO User
        {
            get => user;
            set
            {
                this.user = value;
            }
        }
        public FrmBill(UserDTO user)
        {
            InitializeComponent();
            this.User = user;
        }
        #region FillDaTa
        public void FillDataServiceUnit() //Load tất cả các Service
        {
            List<ServiceDTO> ListService = ServiceDAO.GetListService();
            cbbServiceName.DataSource = ListService;
            cbbServiceName.DisplayMember = "ServiceName";
            txtPricePerUnit.Text = ListServiceUnit[0].PricePerUnit.ToString();
            txtUnit.Text = ListServiceUnit[0].UnitName.ToString();
        }
        public void FillDataSector() //Load tất cả các khu phòng
        {
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            cbbBuilding.DataSource = ListSector;
            cbbBuilding.DisplayMember = "SectorName";
        }
        public void FillDataRoom() // Load tất cả các phòng
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoom();
            cbbRoom.DataSource = ListRoom;
            cbbRoom.DisplayMember = "RoomId";
        }
        public void FillDataRoomBySector(string Sector_Name) // Load danh sách phòng theo Khu
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoomBySector(Sector_Name);
            cbbRoom.DataSource = ListRoom;
            cbbRoom.DisplayMember = "RoomId";
        }
        #endregion
        #region Get___By____
        public string GetServiceIDByServiceName(string ServiceName)
        {
            List<ServiceDTO> ListService = ServiceDAO.GetListService();
            for (int i = 0; i < ListService.Count; i++)
            {
                if (ServiceName == ListService[i].ServiceName)
                {
                    return ListService[i].ServiceId.ToString();
                }
            }
            return "";
        }
        public string GetUnitNameByServiceName(string ServiceName)
        {
            UnitDTO Unit = UnitDAO.GetUnitByServiceName(ServiceName);
            return Unit.UnitName;
        }
        #endregion
        
        private bool CanLoadPayment()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(cbbBuilding.Text).Append(cbbRoom.Text).Append(cbbMonth.Text).Append(txtYear.Text);
            if (string.IsNullOrEmpty(sb.ToString()))
                return false;
            return true;
        }

        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check du lieu dau vao co du chua
            if (cbbBuilding.Text == "")
            {
                MessageBox.Show("Sector not null");
            }
            else if (cbbRoom.Text == "")
            {
                MessageBox.Show("Room not null");
            }
            else if (cbbMonth.Text == "")
            {
                MessageBox.Show("Month not null");
            }
            else if (txtYear.Text == "")
            {
                MessageBox.Show("Year not null");
            }
            else if (cbbServiceName.Text.Trim() == "" || numQuantity.Value <= 0)//Kiểm tra dữ liệu có phù hợp không
            {
                MessageBox.Show("Số liệu không hợp lệ", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                string Unit = GetUnitNameByServiceName(cbbServiceName.Text.ToString());
                string Service_ID = GetServiceIDByServiceName(cbbServiceName.Text.ToString());
                int SoLuong = Int32.Parse(numQuantity.Value.ToString());
                decimal Gia = Decimal.Parse(txtPricePerUnit.Text.ToString());
                string Price = (SoLuong * Gia).ToString();
                decimal total = Decimal.Parse(txtTotal.Text.ToString());
                total += (SoLuong * Gia);
                txtTotal.Text = total.ToString();
                string[] rowValue = new string[] { Service_ID, cbbServiceName.Text, txtUnit.Text, txtPricePerUnit.Text, numQuantity.Value.ToString(), Price};
                for (int i = 0; i < dgvBillReg.Rows.Count; i++)// Kiểm tra nếu dịch vụ đó đã có sử dụng thì cộng thêm với số lượng cũ
                {
                    if (dgvBillReg.Rows[i].Cells[1].Value.ToString() == cbbServiceName.Text)
                    {
                        decimal price = Decimal.Parse(dgvBillReg.Rows[i].Cells[5].Value.ToString());
                        decimal Number = Decimal.Parse(dgvBillReg.Rows[i].Cells[4].Value.ToString());
                        Number += numQuantity.Value;
                        price += Gia * numQuantity.Value;
                        dgvBillReg.Rows[i].Cells[4].Value = Number.ToString();
                        dgvBillReg.Rows[i].Cells[5].Value = price.ToString();
                        return;
                    }
                }
                dgvBillReg.Rows.Add(rowValue);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvBillReg.CurrentCell.RowIndex;
                decimal Price = Decimal.Parse(dgvBillReg.Rows[index].Cells[5].Value.ToString());
                decimal Total = Decimal.Parse(txtTotal.Text.ToString());
                Total = Total - Price;
                txtTotal.Text = Total.ToString();
                var row = dgvBillReg.Rows[index];
                if (row.IsNewRow == false)
                {
                    string maDV = row.Cells[0].Value.ToString().Trim();
                    dgvBillReg.Rows.Remove(row);
                }
                dgvBillReg.Refresh();
                MessageBox.Show("Đã xóa xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBillReg.Rows.Count <= 1)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long Employee_ID = User.UserId;
            string Room_Name = cmbRoom.Text;
            string Sector_Name = cmbBuilding.Text;
            string Month = cmbMonth.Text;
            string Year = txtYear.Text;
            string Status = "0";
            string Total = txtTotal.Text;
            DateTime CreatDay = dtCreatedDate.Value;
            if (AddBill(Employee_ID, Room_Name, Sector_Name, CreatDay, Month, Year, Status, Total))
            {
                for (int i = 0; i < dgvBillReg.Rows.Count - 1; i++)
                {
                    string Service_Name = dgvBillReg.Rows[i].Cells[1].Value.ToString();
                    string Quantity = dgvBillReg.Rows[i].Cells[4].Value.ToString();
                    string Unit_Name = dgvBillReg.Rows[i].Cells[2].Value.ToString();
                    string Total_Cost_Per_Service = dgvBillReg.Rows[i].Cells[5].Value.ToString();
                    BillDetailDAO.AddDetailBill(Service_Name, Quantity, Sector_Name, Room_Name, Month, Year, Unit_Name, Total_Cost_Per_Service);
                }
                MessageBox.Show("Add Bill Success");
                dgvBillReg.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        bool AddBill(long Employee_ID, string Room_Name, string Sector_Name, DateTime CreatDay, string Month, string Year, string Status, string Total)
        {
            return BillDAO.AddBill(Employee_ID, Room_Name, Sector_Name, CreatDay, Month, Year, Status, Total);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string SectorName = cmbBuilding.Text;
            string RoomId = cmbRoom.Text;
            string Month = cmbMonth.Text.ToString();
            string Year = txtYear.Text;
            List<BillDetailDTO> ListService = BillDetailDAO.GetViewBillDetail(SectorName, RoomId, Month, Year);
            for (int i = 0; i < ListService.Count; i++)
            {
                BillDetailDTO OneService = ListService[i];
                int Quantity = OneService.NewQuantity - OneService.OldQuantity;
                decimal Total_Cost_Per_Service = OneService.ToTal_Cost_Per_Service;
                decimal Cost_Per_Unit = Total_Cost_Per_Service / Quantity;
                string[] rowvalue = new string[] { OneService.ServiceId.ToString(),
                                                   OneService.ServiceName.ToString(),
                                                   OneService.UnitName.ToString(),
                                                   Cost_Per_Unit.ToString(),
                                                   Quantity.ToString(),
                                                   Total_Cost_Per_Service.ToString()};
                dgvPayment.Rows.Add(rowvalue);
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal Total_Cost_Bill = 0;
            for (int i = 0; i < dgvPayment.Rows.Count - 1; i++)
            {
                decimal temp = Decimal.Parse(dgvPayment.Rows[i].Cells[5].Value.ToString());
                Total_Cost_Bill = Total_Cost_Bill + temp;
            }
            DateTime CreatDay = dtCreatedDate.Value;
            PayMentDAO.AddPayMent(User.UserId.ToString(), CreatDay, Total_Cost_Bill, cmbBuilding.Text.ToString(), cmbRoom.Text.ToString(), cmbMonth.Text.ToString(), txtYear.Text.ToString());
            MessageBox.Show(Total_Cost_Bill.ToString());

        }
        #endregion
        private void FrmBill_Load(object sender, EventArgs e)
        {
            FillDataServiceUnit();
            FillDataSector();
            txtEmployee.Text = User.FirstName.ToString() + " "+User.LastName.ToString();
            DateTime now = DateTime.Now;
            cbbMonth.Text = now.Month.ToString();
            txtYear.Text = now.Year.ToString();
            dgvBillReg.Rows[0].Cells[5].Value = 0;
            txtTotal.Text = "0";
        }
        #region EventChange
        private void cmbBuilding_SelectedValueChanged(object sender, EventArgs e)
        {
            string SectorName = cbbBuilding.Text.ToString();
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            for (int i = 0; i < ListSector.Count; i++)
            {
                SectorDTO Sector = ListSector[i];
                if (SectorName == Sector.SectorName)
                {
                    FillDataRoomBySector(Sector.SectorId);
                }
            }
        }

        private void cmbTenDV_SelectedValueChanged(object sender, EventArgs e)
        {
            string ServiceName = cbbServiceName.Text.ToString();
            List<ServiceUnitDTO> ListServiceUnit = ServiceUnitDAO.GetListServiceUnit();
            for (int i = 0; i < ListServiceUnit.Count; i++)
            {
                ServiceUnitDTO ServiceUnit = ListServiceUnit[i];
                if (ServiceName == ServiceUnit.ServiceName)
                {
                    txtPricePerUnit.Text = ServiceUnit.PricePerUnit.ToString();
                    txtUnit.Text = ServiceUnit.UnitName.ToString();
                }
            }
        }
        #endregion
    }
}
