using DormitoryManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            Init();
        }

        #region Init
        private Item ctrlLogin;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlSearch;
        private Item ctrlGuide;

        private void Init()
        {
            //Đăng nhập
            ctrlLogin = new Item(btnLogin_Click);
            ctrlLogin.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogin.btnTitle.Text = "LOGIN";
            ctrlLogin.Anchor = AnchorStyles.Right;
            ctrlLogin.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlLogin);
            //Thoát
            ctrlExit = new Item(Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            ctrlExit.Anchor = AnchorStyles.Left;
            ctrlExit.btnTitle.ForeColor = Color.DarkRed;
            tlpManage.Controls.Add(ctrlExit);
            //DS Khu phòng
            ctrlBuildings = new Item(ItemType.Building);
            ctrlBuildings.picItem.BackgroundImage = Properties.Resources.Building;
            ctrlBuildings.btnTitle.Text = "BUILDINGS";
            tlpInfo.Controls.Add(ctrlBuildings);
            //DS Khu phòng
            ctrlRoomType = new Item(ItemType.RoomType);
            ctrlRoomType.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoomType.btnTitle.Text = "ROOM TYPES";
            tlpInfo.Controls.Add(ctrlRoomType);
            //DS dịch vụ
            ctrlServices = new Item(ItemType.Service);
            ctrlServices.picItem.BackgroundImage = Properties.Resources.Water;
            ctrlServices.btnTitle.Text = "SERVICES";
            tlpInfo.Controls.Add(ctrlServices);
            //Tìm kiếm
            ctrlSearch = new Item(Search);
            ctrlSearch.picItem.BackgroundImage = Properties.Resources.Search;
            ctrlSearch.btnTitle.Text = "SEARCH";
            tlpInfo.Controls.Add(ctrlSearch);
            //Hướng dẫn
            ctrlGuide = new Item(Guide);
            ctrlGuide.picItem.BackgroundImage = Properties.Resources.Info;
            ctrlGuide.btnTitle.Text = "GUIDE";
            tlpInfo.Controls.Add(ctrlGuide);
        }
        #endregion

        private void Exit()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Search()
        {
            FrmSearch frmTimKiem = new FrmSearch();
            frmTimKiem.ShowDialog();
        }

        private void Guide()
        {
            FrmGuide huongDan = new FrmGuide();
            huongDan.ShowDialog();
        }


        // để nút để test
        private void btnLogin_Click()
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.ShowDialog();
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }
    }
}
