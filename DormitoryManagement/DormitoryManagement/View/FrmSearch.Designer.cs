namespace DormitoryManagement.View
{
    partial class FrmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInputBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCategoryBill = new System.Windows.Forms.ComboBox();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.btnSearchRoomReg = new System.Windows.Forms.Button();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.cbbCategoryRoomReg = new System.Windows.Forms.ComboBox();
            this.dgvRoomReg = new System.Windows.Forms.DataGridView();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInputStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbbCategoryStudent = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.SCHOOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabBill.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).BeginInit();
            this.tabStudent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1857, 129);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "SEARCH";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.dgvBill);
            this.tabBill.Controls.Add(this.tableLayoutPanel2);
            this.tabBill.Location = new System.Drawing.Point(4, 35);
            this.tabBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBill.Size = new System.Drawing.Size(1849, 816);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "BILL";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearchBill, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbCategoryBill, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInputBill, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1843, 80);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // txtInputBill
            // 
            this.txtInputBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputBill.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtInputBill.Location = new System.Drawing.Point(279, 42);
            this.txtInputBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputBill.Name = "txtInputBill";
            this.txtInputBill.Size = new System.Drawing.Size(1284, 35);
            this.txtInputBill.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(280, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1282, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "What to search:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCategoryBill
            // 
            this.cbbCategoryBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategoryBill.FormattingEnabled = true;
            this.cbbCategoryBill.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryBill.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryBill.Name = "cbbCategoryBill";
            this.cbbCategoryBill.Size = new System.Drawing.Size(268, 31);
            this.cbbCategoryBill.TabIndex = 11;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchBill.Location = new System.Drawing.Point(1569, 42);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(271, 36);
            this.btnSearchBill.TabIndex = 13;
            this.btnSearchBill.Text = "SEARCH";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.Location = new System.Drawing.Point(3, 82);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.Size = new System.Drawing.Size(1843, 732);
            this.dgvBill.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRoomReg);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1849, 816);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ROOM REGISTRATION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.cbbCategoryRoomReg, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbbBuilding, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSearchRoomReg, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbbRoom, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1843, 80);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(924, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(639, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(280, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(637, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbRoom
            // 
            this.cbbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(925, 44);
            this.cbbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(637, 31);
            this.cbbRoom.TabIndex = 11;
            // 
            // btnSearchRoomReg
            // 
            this.btnSearchRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchRoomReg.Enabled = false;
            this.btnSearchRoomReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoomReg.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchRoomReg.Location = new System.Drawing.Point(1569, 42);
            this.btnSearchRoomReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchRoomReg.Name = "btnSearchRoomReg";
            this.btnSearchRoomReg.Size = new System.Drawing.Size(271, 36);
            this.btnSearchRoomReg.TabIndex = 13;
            this.btnSearchRoomReg.Text = "SEARCH";
            this.btnSearchRoomReg.UseVisualStyleBackColor = true;
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuilding.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Location = new System.Drawing.Point(280, 44);
            this.cbbBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(637, 31);
            this.cbbBuilding.TabIndex = 14;
            // 
            // cbbCategoryRoomReg
            // 
            this.cbbCategoryRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryRoomReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryRoomReg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategoryRoomReg.FormattingEnabled = true;
            this.cbbCategoryRoomReg.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryRoomReg.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryRoomReg.Name = "cbbCategoryRoomReg";
            this.cbbCategoryRoomReg.Size = new System.Drawing.Size(268, 31);
            this.cbbCategoryRoomReg.TabIndex = 15;
            // 
            // dgvRoomReg
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoomReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomReg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRoomReg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoomReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomReg.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.Location = new System.Drawing.Point(3, 82);
            this.dgvRoomReg.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvRoomReg.Name = "dgvRoomReg";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoomReg.RowHeadersVisible = false;
            this.dgvRoomReg.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRoomReg.Size = new System.Drawing.Size(1843, 732);
            this.dgvRoomReg.TabIndex = 15;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.dgvStudent);
            this.tabStudent.Controls.Add(this.tableLayoutPanel1);
            this.tabStudent.Location = new System.Drawing.Point(4, 35);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStudent.Size = new System.Drawing.Size(1849, 848);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "STUDENT";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.47924F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5445881F));
            this.tableLayoutPanel1.Controls.Add(this.cbbCategoryStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInputStudent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1843, 80);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtInputStudent
            // 
            this.txtInputStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputStudent.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtInputStudent.Location = new System.Drawing.Point(279, 42);
            this.txtInputStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputStudent.Name = "txtInputStudent";
            this.txtInputStudent.Size = new System.Drawing.Size(1550, 35);
            this.txtInputStudent.TabIndex = 14;
            this.txtInputStudent.TextChanged += new System.EventHandler(this.txtInputStudent_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(280, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1548, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "What to search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCategory
            // 
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbCategory.Location = new System.Drawing.Point(4, 0);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(268, 40);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Category:";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCategoryStudent
            // 
            this.cbbCategoryStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryStudent.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbbCategoryStudent.FormattingEnabled = true;
            this.cbbCategoryStudent.Items.AddRange(new object[] {
            "FULL",
            "ALIVE",
            "GOING OUT",
            "USER_ID",
            "STUDENT_ID",
            "FULLNAME",
            "GENDER",
            "SSN",
            "SCHOOL"});
            this.cbbCategoryStudent.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryStudent.Name = "cbbCategoryStudent";
            this.cbbCategoryStudent.Size = new System.Drawing.Size(268, 31);
            this.cbbCategoryStudent.TabIndex = 11;
            this.cbbCategoryStudent.Text = "FULL";
            this.cbbCategoryStudent.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryStudent_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.STUDENT_ID,
            this.FULLNAME,
            this.GENDER,
            this.DOB,
            this.SSN,
            this.PHONE,
            this.EMAIL,
            this.SCHOOL});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.Location = new System.Drawing.Point(3, 82);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStudent.Size = new System.Drawing.Size(1843, 764);
            this.dgvStudent.TabIndex = 14;
            // 
            // SCHOOL
            // 
            this.SCHOOL.DataPropertyName = "College";
            this.SCHOOL.FillWeight = 184.5167F;
            this.SCHOOL.HeaderText = "SCHOOL";
            this.SCHOOL.MinimumWidth = 6;
            this.SCHOOL.Name = "SCHOOL";
            this.SCHOOL.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "Email";
            this.EMAIL.FillWeight = 139.2859F;
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PhoneNumber";
            this.PHONE.FillWeight = 95.2465F;
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.MinimumWidth = 6;
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // SSN
            // 
            this.SSN.DataPropertyName = "Ssn";
            this.SSN.FillWeight = 71.70272F;
            this.SSN.HeaderText = "SSN";
            this.SSN.MinimumWidth = 6;
            this.SSN.Name = "SSN";
            this.SSN.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "Dob";
            this.DOB.FillWeight = 56.72098F;
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "Gender";
            this.GENDER.FillWeight = 67.37967F;
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.MinimumWidth = 6;
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "FullName";
            this.FULLNAME.FillWeight = 132.6145F;
            this.FULLNAME.HeaderText = "FULLNAME";
            this.FULLNAME.MinimumWidth = 6;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.ReadOnly = true;
            // 
            // STUDENT_ID
            // 
            this.STUDENT_ID.DataPropertyName = "StudentId";
            this.STUDENT_ID.FillWeight = 85.82027F;
            this.STUDENT_ID.HeaderText = "STUDENT_ID";
            this.STUDENT_ID.MinimumWidth = 6;
            this.STUDENT_ID.Name = "STUDENT_ID";
            this.STUDENT_ID.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.FillWeight = 66.71265F;
            this.UserId.HeaderText = "USER_ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSearch.Controls.Add(this.tabStudent);
            this.tabSearch.Controls.Add(this.tabPage2);
            this.tabSearch.Controls.Add(this.tabBill);
            this.tabSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(0, 129);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.ShowToolTips = true;
            this.tabSearch.Size = new System.Drawing.Size(1857, 887);
            this.tabSearch.TabIndex = 14;
            // 
            // FrmSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1857, 1016);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.tabBill.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).EndInit();
            this.tabStudent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.ComboBox cbbCategoryBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputBill;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRoomReg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbCategoryRoomReg;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Button btnSearchRoomReg;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCHOOL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbCategoryStudent;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputStudent;
        private System.Windows.Forms.TabControl tabSearch;
    }
}