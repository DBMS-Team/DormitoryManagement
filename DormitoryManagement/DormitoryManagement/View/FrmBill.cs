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
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }
        #region Function
        public void FillDataService() //Load tất cả các Service
        {
            List<ServiceDTO> ListService = ServiceDAO.GetListService();
            cmbTenDV.DataSource = ListService;
            cmbTenDV.DisplayMember = "ServiceName";
        }
        public void FillDataSector() //Load tất cả các khu phòng
        {
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            cmbBuilding.DataSource = ListSector;
            cmbBuilding.DisplayMember = "SectorName";
        }
        public void FillDataRoom() // Load tất cả các phòng
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoom();
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }
        public void FillDataRoomBySector(string Sector_Name) // Load danh sách phòng theo Khu
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoomBySector(Sector_Name);
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }
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

        private void cmbBuilding_SelectedValueChanged(object sender, EventArgs e)
        {
            string SectorName = cmbBuilding.Text.ToString();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTenDV.Text.Trim() == "" || numSoLuong.Value <= 0)//Kiểm tra dữ liệu có phù hợp không
            {
                MessageBox.Show("Số liệu không hợp lệ", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Unit = GetUnitNameByServiceName(cmbTenDV.Text.ToString());
            string Service_ID = GetServiceIDByServiceName(cmbTenDV.Text.ToString());
            string[] rowValue = new string[] { Service_ID, cmbTenDV.Text, numSoLuong.Value.ToString(), Unit };
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)// Kiểm tra nếu dịch vụ đó đã có sử dụng thì cộng thêm với số lượng cũ
            {
                if (dgvHoaDon.Rows[i].Cells[1].Value == cmbTenDV.Text)
                {
                    decimal a = Decimal.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                    a += numSoLuong.Value;
                    dgvHoaDon.Rows[i].Cells[2].Value = a.ToString();
                    return;
                }
            }
            dgvHoaDon.Rows.Add(rowValue);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = dgvHoaDon.CurrentCell.RowIndex;
            var row = dgvHoaDon.Rows[index];
            if (row.IsNewRow == false)
            {
                string maDV = row.Cells[0].Value.ToString().Trim();
                dgvHoaDon.Rows.Remove(row);
            }
            dgvHoaDon.Refresh();
            MessageBox.Show("Đã xóa xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count <= 1)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            FillDataService();
            FillDataSector();
            FillDataRoom();
            cmbBuilding.Text = "";
        }
    }
}
