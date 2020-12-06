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
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.cbbCategoryStudent = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputStudent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoomReg = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbCategoryRoomReg = new System.Windows.Forms.ComboBox();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.btnSearchRoomReg = new System.Windows.Forms.Button();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.cbbCategoryBill = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputBill = new System.Windows.Forms.TextBox();
            this.tabEmployee = new System.Windows.Forms.TabPage();
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
            this.tabSearch.Controls.Add(this.tabEmployee);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.Location = new System.Drawing.Point(3, 83);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvStudent.Name = "dgvStudent";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudent.Size = new System.Drawing.Size(1468, 602);
            this.dgvStudent.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchStudent, 2, 1);
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
            // btnSearchStudent
            // 
            this.btnSearchStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchStudent.Location = new System.Drawing.Point(1250, 42);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(215, 36);
            this.btnSearchStudent.TabIndex = 13;
            this.btnSearchStudent.Text = "SEARCH";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // cbbCategoryStudent
            // 
            this.cbbCategoryStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategoryStudent.FormattingEnabled = true;
            this.cbbCategoryStudent.Location = new System.Drawing.Point(4, 44);
            this.cbbCategoryStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategoryStudent.Name = "cbbCategoryStudent";
            this.cbbCategoryStudent.Size = new System.Drawing.Size(212, 31);
            this.cbbCategoryStudent.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(1019, 40);
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
            this.txtInputStudent.Size = new System.Drawing.Size(1021, 35);
            this.txtInputStudent.TabIndex = 14;
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
            this.dgvRoomReg.Location = new System.Drawing.Point(3, 83);
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
            this.dgvRoomReg.Size = new System.Drawing.Size(1468, 602);
            this.dgvRoomReg.TabIndex = 15;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1468, 80);
            this.tableLayoutPanel3.TabIndex = 13;
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
            this.cbbCategoryRoomReg.Size = new System.Drawing.Size(212, 31);
            this.cbbCategoryRoomReg.TabIndex = 15;
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuilding.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Location = new System.Drawing.Point(224, 44);
            this.cbbBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(505, 31);
            this.cbbBuilding.TabIndex = 14;
            // 
            // btnSearchRoomReg
            // 
            this.btnSearchRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchRoomReg.Enabled = false;
            this.btnSearchRoomReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoomReg.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchRoomReg.Location = new System.Drawing.Point(1249, 42);
            this.btnSearchRoomReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchRoomReg.Name = "btnSearchRoomReg";
            this.btnSearchRoomReg.Size = new System.Drawing.Size(216, 36);
            this.btnSearchRoomReg.TabIndex = 13;
            this.btnSearchRoomReg.Text = "SEARCH";
            this.btnSearchRoomReg.UseVisualStyleBackColor = true;
            // 
            // cbbRoom
            // 
            this.cbbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(737, 44);
            this.cbbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(505, 31);
            this.cbbRoom.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(224, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(505, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.Location = new System.Drawing.Point(3, 83);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBill.Size = new System.Drawing.Size(1468, 602);
            this.dgvBill.TabIndex = 15;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1468, 80);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchBill.Location = new System.Drawing.Point(1250, 42);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(215, 36);
            this.btnSearchBill.TabIndex = 13;
            this.btnSearchBill.Text = "SEARCH";
            this.btnSearchBill.UseVisualStyleBackColor = true;
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
            this.cbbCategoryBill.Size = new System.Drawing.Size(212, 31);
            this.cbbCategoryBill.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(224, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1019, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "What to search:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInputBill
            // 
            this.txtInputBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputBill.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtInputBill.Location = new System.Drawing.Point(223, 43);
            this.txtInputBill.Name = "txtInputBill";
            this.txtInputBill.Size = new System.Drawing.Size(1021, 35);
            this.txtInputBill.TabIndex = 14;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 35);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1474, 688);
            this.tabEmployee.TabIndex = 3;
            this.tabEmployee.Text = "EMPLOYEE";
            this.tabEmployee.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.ComboBox cbbCategoryStudent;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.ComboBox cbbCategoryBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputBill;
        private System.Windows.Forms.Button btnSearchRoomReg;
        private System.Windows.Forms.ComboBox cbbCategoryRoomReg;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvRoomReg;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabPage tabEmployee;
    }
}