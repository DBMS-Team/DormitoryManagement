namespace DormitoryManagement.View
{
    partial class FrmReportAnnual
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
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbService_tabDorm = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabServices_Dorm = new System.Windows.Forms.TabPage();
            this.tabServices = new System.Windows.Forms.TabControl();
            this.tabServices_Building = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbBuilding_tabBuilding = new System.Windows.Forms.ComboBox();
            this.cbbService_tabBuilding = new System.Windows.Forms.ComboBox();
            this.tabServices_Room = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbRoom_tabRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBuilding_tabRoom = new System.Windows.Forms.ComboBox();
            this.cbbService_tabRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.tabThongKeDV = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabRoomReg = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabServices_Dorm.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabServices_Building.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabServices_Room.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabThongKeDV.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvReport
            // 
            this.rpvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReport.Location = new System.Drawing.Point(0, 269);
            this.rpvReport.Name = "rpvReport";
            this.rpvReport.ServerReport.BearerToken = null;
            this.rpvReport.Size = new System.Drawing.Size(1482, 534);
            this.rpvReport.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 49);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Azure;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Navy;
            this.btnCreate.Location = new System.Drawing.Point(300, 4);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(288, 41);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "CREATE REPORT";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Bisque;
            this.btnPrint.Location = new System.Drawing.Point(892, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(288, 41);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT REPORT";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Goldenrod;
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1482, 55);
            this.pnTop.TabIndex = 8;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1482, 55);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "REPORT ANNUAL";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbService_tabDorm
            // 
            this.cbbService_tabDorm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbService_tabDorm.FormattingEnabled = true;
            this.cbbService_tabDorm.Items.AddRange(new object[] {
            "Điện",
            "Nước"});
            this.cbbService_tabDorm.Location = new System.Drawing.Point(207, 4);
            this.cbbService_tabDorm.Margin = new System.Windows.Forms.Padding(4);
            this.cbbService_tabDorm.Name = "cbbService_tabDorm";
            this.cbbService_tabDorm.Size = new System.Drawing.Size(253, 33);
            this.cbbService_tabDorm.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbbService_tabDorm, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1450, 42);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tabServices_Dorm
            // 
            this.tabServices_Dorm.Controls.Add(this.tableLayoutPanel4);
            this.tabServices_Dorm.Location = new System.Drawing.Point(4, 34);
            this.tabServices_Dorm.Margin = new System.Windows.Forms.Padding(4);
            this.tabServices_Dorm.Name = "tabServices_Dorm";
            this.tabServices_Dorm.Padding = new System.Windows.Forms.Padding(4);
            this.tabServices_Dorm.Size = new System.Drawing.Size(1458, 387);
            this.tabServices_Dorm.TabIndex = 0;
            this.tabServices_Dorm.Text = "Dormitory";
            this.tabServices_Dorm.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.tabServices_Dorm);
            this.tabServices.Controls.Add(this.tabServices_Building);
            this.tabServices.Controls.Add(this.tabServices_Room);
            this.tabServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabServices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabServices.Location = new System.Drawing.Point(4, 4);
            this.tabServices.Margin = new System.Windows.Forms.Padding(4);
            this.tabServices.Name = "tabServices";
            this.tabServices.SelectedIndex = 0;
            this.tabServices.Size = new System.Drawing.Size(1466, 425);
            this.tabServices.TabIndex = 0;
            // 
            // tabServices_Building
            // 
            this.tabServices_Building.Controls.Add(this.tableLayoutPanel3);
            this.tabServices_Building.Location = new System.Drawing.Point(4, 34);
            this.tabServices_Building.Margin = new System.Windows.Forms.Padding(4);
            this.tabServices_Building.Name = "tabServices_Building";
            this.tabServices_Building.Padding = new System.Windows.Forms.Padding(4);
            this.tabServices_Building.Size = new System.Drawing.Size(1458, 387);
            this.tabServices_Building.TabIndex = 1;
            this.tabServices_Building.Text = "Building";
            this.tabServices_Building.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbBuilding_tabBuilding, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbService_tabBuilding, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1450, 42);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Service:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Building:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbBuilding_tabBuilding
            // 
            this.cbbBuilding_tabBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding_tabBuilding.FormattingEnabled = true;
            this.cbbBuilding_tabBuilding.Items.AddRange(new object[] {
            "Điện",
            "Nước"});
            this.cbbBuilding_tabBuilding.Location = new System.Drawing.Point(671, 4);
            this.cbbBuilding_tabBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuilding_tabBuilding.Name = "cbbBuilding_tabBuilding";
            this.cbbBuilding_tabBuilding.Size = new System.Drawing.Size(224, 33);
            this.cbbBuilding_tabBuilding.TabIndex = 1;
            // 
            // cbbService_tabBuilding
            // 
            this.cbbService_tabBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbService_tabBuilding.FormattingEnabled = true;
            this.cbbService_tabBuilding.Location = new System.Drawing.Point(207, 4);
            this.cbbService_tabBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cbbService_tabBuilding.Name = "cbbService_tabBuilding";
            this.cbbService_tabBuilding.Size = new System.Drawing.Size(253, 33);
            this.cbbService_tabBuilding.TabIndex = 9;
            // 
            // tabServices_Room
            // 
            this.tabServices_Room.Controls.Add(this.tableLayoutPanel2);
            this.tabServices_Room.Location = new System.Drawing.Point(4, 34);
            this.tabServices_Room.Margin = new System.Windows.Forms.Padding(4);
            this.tabServices_Room.Name = "tabServices_Room";
            this.tabServices_Room.Padding = new System.Windows.Forms.Padding(4);
            this.tabServices_Room.Size = new System.Drawing.Size(1458, 387);
            this.tabServices_Room.TabIndex = 2;
            this.tabServices_Room.Text = "Room";
            this.tabServices_Room.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Moccasin;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Controls.Add(this.cbbRoom_tabRoom, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbBuilding_tabRoom, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbService_tabRoom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1450, 42);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // cbbRoom_tabRoom
            // 
            this.cbbRoom_tabRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom_tabRoom.FormattingEnabled = true;
            this.cbbRoom_tabRoom.Location = new System.Drawing.Point(1106, 4);
            this.cbbRoom_tabRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoom_tabRoom.Name = "cbbRoom_tabRoom";
            this.cbbRoom_tabRoom.Size = new System.Drawing.Size(224, 33);
            this.cbbRoom_tabRoom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbBuilding_tabRoom
            // 
            this.cbbBuilding_tabRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding_tabRoom.FormattingEnabled = true;
            this.cbbBuilding_tabRoom.Location = new System.Drawing.Point(671, 4);
            this.cbbBuilding_tabRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBuilding_tabRoom.Name = "cbbBuilding_tabRoom";
            this.cbbBuilding_tabRoom.Size = new System.Drawing.Size(224, 33);
            this.cbbBuilding_tabRoom.TabIndex = 4;
            // 
            // cbbService_tabRoom
            // 
            this.cbbService_tabRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbService_tabRoom.FormattingEnabled = true;
            this.cbbService_tabRoom.Items.AddRange(new object[] {
            "Điện",
            "Nước"});
            this.cbbService_tabRoom.Location = new System.Drawing.Point(207, 4);
            this.cbbService_tabRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbService_tabRoom.Name = "cbbService_tabRoom";
            this.cbbService_tabRoom.Size = new System.Drawing.Size(253, 33);
            this.cbbService_tabRoom.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(903, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(468, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Building:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabStudent
            // 
            this.tabStudent.Location = new System.Drawing.Point(4, 37);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(4);
            this.tabStudent.Size = new System.Drawing.Size(1474, 124);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "STUDENT";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // tabThongKeDV
            // 
            this.tabThongKeDV.Controls.Add(this.tabServices);
            this.tabThongKeDV.Location = new System.Drawing.Point(4, 37);
            this.tabThongKeDV.Margin = new System.Windows.Forms.Padding(4);
            this.tabThongKeDV.Name = "tabThongKeDV";
            this.tabThongKeDV.Padding = new System.Windows.Forms.Padding(4);
            this.tabThongKeDV.Size = new System.Drawing.Size(1474, 433);
            this.tabThongKeDV.TabIndex = 3;
            this.tabThongKeDV.Text = "SERVICES";
            this.tabThongKeDV.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudent);
            this.tabControl.Controls.Add(this.tabEmployee);
            this.tabControl.Controls.Add(this.tabRoomReg);
            this.tabControl.Controls.Add(this.tabThongKeDV);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1482, 165);
            this.tabControl.TabIndex = 9;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 37);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.tabEmployee.Size = new System.Drawing.Size(1474, 433);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "EMPLOYEE";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabRoomReg
            // 
            this.tabRoomReg.Location = new System.Drawing.Point(4, 37);
            this.tabRoomReg.Margin = new System.Windows.Forms.Padding(4);
            this.tabRoomReg.Name = "tabRoomReg";
            this.tabRoomReg.Padding = new System.Windows.Forms.Padding(4);
            this.tabRoomReg.Size = new System.Drawing.Size(1474, 433);
            this.tabRoomReg.TabIndex = 2;
            this.tabRoomReg.Text = "ROOM REGISTRATION";
            this.tabRoomReg.UseVisualStyleBackColor = true;
            // 
            // FrmReportAnnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.rpvReport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnTop);
            this.Name = "FrmReportAnnual";
            this.Text = "Report Annual";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabServices_Dorm.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            this.tabServices_Building.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabServices_Room.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabThongKeDV.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbService_tabDorm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tabServices_Dorm;
        private System.Windows.Forms.TabControl tabServices;
        private System.Windows.Forms.TabPage tabServices_Building;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBuilding_tabBuilding;
        private System.Windows.Forms.ComboBox cbbService_tabBuilding;
        private System.Windows.Forms.TabPage tabServices_Room;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbbRoom_tabRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBuilding_tabRoom;
        private System.Windows.Forms.ComboBox cbbService_tabRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabThongKeDV;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabRoomReg;
    }
}