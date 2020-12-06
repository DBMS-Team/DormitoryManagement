using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using DormitoryManagement.View;

namespace DormitoryManagement
{
    public enum ItemType
    {
        Building,
        Employee,
        Service,
        HoaDon,
        RoomType,
        Unknown
    }
    public delegate void ClickEvent();

    public partial class Item : UserControl
    {
        public ClickEvent ClickEvent = null; //delegate
        public event EventHandler ButtonClick;
        private ItemType type = ItemType.Unknown;
        private string strKey = "";

        #region Constructors
        public Item()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
        }

        public Item(ClickEvent click)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.ClickEvent = click;
        }

        public Item(ItemType type)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.Type = type;
            this.ClickEvent = EventClick;
        }

        public Item(ItemType type, string key)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.Type = type;
            this.ClickEvent = ShowInfo;
            StrKey = key;
        }
        #endregion

        private void ShowInfo()
        {
            switch (this.Type)
            {
                //case ItemType.KhuPhong:
                //    break;
                //case ItemType.RoomType:
                //    FrmLoaiPhong loaiPhong = new FrmLoaiPhong(this.strKey);
                //    loaiPhong.ShowDialog();
                //    break;
                //case ItemType.NhanVien:
                //    FrmNhanVien nhanVien = new FrmNhanVien(this.strKey);
                //    nhanVien.ShowDialog();
                //    break;
                //case ItemType.Service:
                //    FrmDichVu dichVu = new FrmDichVu(this.strKey);
                //    dichVu.ShowDialog();
                //    break;
            }
        }

        private void EventClick()
        {
            //FrmTongQuan tongQuan = new FrmTongQuan(this.type);
            //tongQuan.ShowDialog();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
                this.ClickEvent();
        }

        private void btnTitle_Enter(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Coral;
        }

        private void btnTitle_Leave(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Transparent;
        }

        [Browsable(true)][Category("Action")][Description("Invoked when user clicks button")]
        private void item1_Click(object sender, EventArgs e)
        {
            this.ClickEvent();
        }

        [Category("Button"), Description("")]
        public string Title { get => this.btnTitle.Text; set => this.btnTitle.Text = value; }

        [Category("PictureBox"), Description("")]
        public Image ImageItem { get => this.picItem.BackgroundImage; set => this.picItem.BackgroundImage = value; }
        [Category("PictureBox"), Description("")]
        
        public string StrKey { get => strKey; set => strKey = value; }
        public ItemType Type { get => type; set => type = value; }
    }
}
