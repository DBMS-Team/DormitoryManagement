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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbCategoryStudent = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputStudent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoomReg = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCategoryRoomReg = new System.Windows.Forms.ComboBox();
            this.btnSearchRoomReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.txtInputRoomReg = new System.Windows.Forms.TextBox();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch_Bill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbRoom_Bill = new System.Windows.Forms.ComboBox();
            this.cbbBuiding_Bill = new System.Windows.Forms.ComboBox();
            this.ckbPaid = new System.Windows.Forms.CheckBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tabSearch.SuspendLayout();
            this.tabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.lbTitle.Size = new System.Drawing.Size(1482, 76);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "SEARCH";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSearch
            // 
            this.tabSearch.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSearch.Controls.Add(this.tabStudent);
            this.tabSearch.Controls.Add(this.tabPage2);
            this.tabSearch.Controls.Add(this.tabBill);
            this.tabSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(0, 76);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.ShowToolTips = true;
            this.tabSearch.Size = new System.Drawing.Size(1482, 727);
            this.tabSearch.TabIndex = 14;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.dgvStudent);
            this.tabStudent.Controls.Add(this.tableLayoutPanel1);
            this.tabStudent.Location = new System.Drawing.Point(4, 35);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(1474, 688);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "STUDENT";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // dgvStudent
            // 
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle96.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle96.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle96.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle96.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle96;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle97.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle97.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle97.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle97.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle97.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle97.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle97;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle98.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle98.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle98.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle98.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle98.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle98;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.Location = new System.Drawing.Point(3, 83);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvStudent.Name = "dgvStudent";
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle99.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle99.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle99;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            dataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle100.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle100.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle100.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle100.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle100;
            this.dgvStudent.Size = new System.Drawing.Size(1468, 602);
            this.dgvStudent.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.40054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.613079F));
            this.tableLayoutPanel1.Controls.Add(this.cbbCategoryStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInputStudent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1468, 80);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // cbbCategoryStudent
            // 
            this.cbbCategoryStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
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
            "COLLEGE"});
            this.cbbCategoryStudent.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryStudent.Name = "cbbCategoryStudent";
            this.cbbCategoryStudent.Size = new System.Drawing.Size(212, 28);
            this.cbbCategoryStudent.TabIndex = 11;
            this.cbbCategoryStudent.Text = "FULL";
            this.cbbCategoryStudent.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryStudent_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbCategory.Location = new System.Drawing.Point(4, 0);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(212, 40);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Category:";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(224, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1230, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "What to search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInputStudent
            // 
            this.txtInputStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputStudent.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtInputStudent.Location = new System.Drawing.Point(223, 43);
            this.txtInputStudent.Name = "txtInputStudent";
            this.txtInputStudent.Size = new System.Drawing.Size(1232, 35);
            this.txtInputStudent.TabIndex = 14;
            this.txtInputStudent.TextChanged += new System.EventHandler(this.txtInputStudent_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRoomReg);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1474, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ROOM REGISTRATION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoomReg
            // 
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle101;
            this.dgvRoomReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomReg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRoomReg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle102;
            this.dgvRoomReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle103.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle103.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle103.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle103.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.DefaultCellStyle = dataGridViewCellStyle103;
            this.dgvRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomReg.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.Location = new System.Drawing.Point(3, 83);
            this.dgvRoomReg.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvRoomReg.Name = "dgvRoomReg";
            dataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle104.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle104.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle104;
            this.dgvRoomReg.RowHeadersVisible = false;
            this.dgvRoomReg.RowHeadersWidth = 51;
            dataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle105.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle105.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle105.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle105.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle105.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowsDefaultCellStyle = dataGridViewCellStyle105;
            this.dgvRoomReg.Size = new System.Drawing.Size(1468, 602);
            this.dgvRoomReg.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbCategoryRoomReg, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSearchRoomReg, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbRoom, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbbBuilding, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtInputRoomReg, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1468, 80);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(371, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "What to search:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCategoryRoomReg
            // 
            this.cbbCategoryRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbCategoryRoomReg.FormattingEnabled = true;
            this.cbbCategoryRoomReg.Items.AddRange(new object[] {
            "FULL",
            "STUDENT_ID",
            "STUDENT_FULLNAME"});
            this.cbbCategoryRoomReg.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryRoomReg.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryRoomReg.Name = "cbbCategoryRoomReg";
            this.cbbCategoryRoomReg.Size = new System.Drawing.Size(359, 28);
            this.cbbCategoryRoomReg.TabIndex = 15;
            this.cbbCategoryRoomReg.Text = "FULL";
            this.cbbCategoryRoomReg.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryRoomReg_SelectedIndexChanged);
            // 
            // btnSearchRoomReg
            // 
            this.btnSearchRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchRoomReg.Enabled = false;
            this.btnSearchRoomReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoomReg.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchRoomReg.Location = new System.Drawing.Point(1323, 42);
            this.btnSearchRoomReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchRoomReg.Name = "btnSearchRoomReg";
            this.btnSearchRoomReg.Size = new System.Drawing.Size(142, 36);
            this.btnSearchRoomReg.TabIndex = 13;
            this.btnSearchRoomReg.Text = "SEARCH";
            this.btnSearchRoomReg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(738, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1030, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbRoom
            // 
            this.cbbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(1031, 44);
            this.cbbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(285, 28);
            this.cbbRoom.TabIndex = 11;
            this.cbbRoom.SelectedIndexChanged += new System.EventHandler(this.cbbRoom_SelectedIndexChanged);
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Location = new System.Drawing.Point(738, 44);
            this.cbbBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(285, 28);
            this.cbbBuilding.TabIndex = 14;
            this.cbbBuilding.SelectedIndexChanged += new System.EventHandler(this.cbbBuilding_SelectedIndexChanged);
            // 
            // txtInputRoomReg
            // 
            this.txtInputRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtInputRoomReg.Location = new System.Drawing.Point(370, 43);
            this.txtInputRoomReg.Name = "txtInputRoomReg";
            this.txtInputRoomReg.Size = new System.Drawing.Size(361, 26);
            this.txtInputRoomReg.TabIndex = 19;
            this.txtInputRoomReg.TextChanged += new System.EventHandler(this.txtInputRoomReg_TextChanged);
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.dgvBill);
            this.tabBill.Controls.Add(this.tableLayoutPanel2);
            this.tabBill.Location = new System.Drawing.Point(4, 35);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(1474, 688);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "BILL";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle91.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle91.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle91.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle91;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle92.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle92.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle92.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle92.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle92.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle92;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle93.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle93.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle93.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle93.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle93.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle93.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle93;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.Location = new System.Drawing.Point(3, 83);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle94.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle94.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle94.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle94.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle94.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle94;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle95.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle95.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle95.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle95.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle95.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle95;
            this.dgvBill.Size = new System.Drawing.Size(1468, 602);
            this.dgvBill.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch_Bill, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbRoom_Bill, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbBuiding_Bill, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ckbPaid, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpFromDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpToDate, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1468, 80);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1175, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 40);
            this.label10.TabIndex = 17;
            this.label10.Text = "Status:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(297, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch_Bill
            // 
            this.btnSearch_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Bill.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch_Bill.Location = new System.Drawing.Point(1321, 42);
            this.btnSearch_Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Bill.Name = "btnSearch_Bill";
            this.btnSearch_Bill.Size = new System.Drawing.Size(144, 36);
            this.btnSearch_Bill.TabIndex = 13;
            this.btnSearch_Bill.Text = "SEARCH";
            this.btnSearch_Bill.UseVisualStyleBackColor = true;
            this.btnSearch_Bill.Click += new System.EventHandler(this.btnSearch_Bill_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(590, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Building:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(882, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "Room:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbRoom_Bill
            // 
            this.cbbRoom_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom_Bill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbRoom_Bill.FormattingEnabled = true;
            this.cbbRoom_Bill.Location = new System.Drawing.Point(883, 44);
            this.cbbRoom_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoom_Bill.Name = "cbbRoom_Bill";
            this.cbbRoom_Bill.Size = new System.Drawing.Size(285, 28);
            this.cbbRoom_Bill.TabIndex = 11;
            this.cbbRoom_Bill.SelectedIndexChanged += new System.EventHandler(this.cbbRoom_Bill_SelectedIndexChanged);
            // 
            // cbbBuiding_Bill
            // 
            this.cbbBuiding_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuiding_Bill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuiding_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbBuiding_Bill.FormattingEnabled = true;
            this.cbbBuiding_Bill.Location = new System.Drawing.Point(590, 44);
            this.cbbBuiding_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuiding_Bill.Name = "cbbBuiding_Bill";
            this.cbbBuiding_Bill.Size = new System.Drawing.Size(285, 28);
            this.cbbBuiding_Bill.TabIndex = 14;
            this.cbbBuiding_Bill.SelectedIndexChanged += new System.EventHandler(this.cbbBuiding_Bill_SelectedIndexChanged);
            // 
            // ckbPaid
            // 
            this.ckbPaid.AutoSize = true;
            this.ckbPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ckbPaid.Location = new System.Drawing.Point(1175, 43);
            this.ckbPaid.Name = "ckbPaid";
            this.ckbPaid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ckbPaid.Size = new System.Drawing.Size(140, 34);
            this.ckbPaid.TabIndex = 20;
            this.ckbPaid.Text = "Paid";
            this.ckbPaid.UseVisualStyleBackColor = true;
            this.ckbPaid.CheckedChanged += new System.EventHandler(this.ckbPaid_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "M/yyyy";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(3, 43);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(287, 30);
            this.dtpFromDate.TabIndex = 21;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "M/yyyy";
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(296, 43);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(287, 30);
            this.dtpToDate.TabIndex = 22;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbCategoryStudent;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchRoomReg;
        private System.Windows.Forms.ComboBox cbbCategoryRoomReg;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvRoomReg;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInputRoomReg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch_Bill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbRoom_Bill;
        private System.Windows.Forms.ComboBox cbbBuiding_Bill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckbPaid;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
    }
}