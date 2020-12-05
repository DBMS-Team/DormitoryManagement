namespace DormitoryManagement.View
{
    partial class FrmEmployeeInfo
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtHealthInsurance = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbHealthInsurance = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.groupAvatar = new System.Windows.Forms.GroupBox();
            this.lbProfilePhoto = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCommune = new System.Windows.Forms.ComboBox();
            this.lbCommune = new System.Windows.Forms.Label();
            this.cbbDistrict = new System.Windows.Forms.ComboBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.cbbProvince = new System.Windows.Forms.ComboBox();
            this.lbProvince = new System.Windows.Forms.Label();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.groupManagement = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.lbManager = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.ckbFemale = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSSN = new System.Windows.Forms.Label();
            this.pnSV = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.groupAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.groupAccount.SuspendLayout();
            this.groupAddress.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.groupManagement.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.pnSV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.MinimumSize = new System.Drawing.Size(959, 62);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1515, 62);
            this.pnTop.TabIndex = 36;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.MinimumSize = new System.Drawing.Size(965, 62);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1515, 62);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "EMPLOYEE INFORMATION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(20, 181);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 42;
            this.lbGender.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.Location = new System.Drawing.Point(113, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 27);
            this.txtFirstName.TabIndex = 39;
            // 
            // txtHealthInsurance
            // 
            this.txtHealthInsurance.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthInsurance.Location = new System.Drawing.Point(113, 273);
            this.txtHealthInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHealthInsurance.Name = "txtHealthInsurance";
            this.txtHealthInsurance.Size = new System.Drawing.Size(212, 27);
            this.txtHealthInsurance.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(94, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 27);
            this.txtEmail.TabIndex = 18;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtSDT.Location = new System.Drawing.Point(94, 38);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 27);
            this.txtSDT.TabIndex = 16;
            // 
            // lbHealthInsurance
            // 
            this.lbHealthInsurance.AutoSize = true;
            this.lbHealthInsurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHealthInsurance.Location = new System.Drawing.Point(20, 266);
            this.lbHealthInsurance.Name = "lbHealthInsurance";
            this.lbHealthInsurance.Size = new System.Drawing.Size(77, 40);
            this.lbHealthInsurance.TabIndex = 19;
            this.lbHealthInsurance.Text = "Health\r\nInsurance";
            this.lbHealthInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(14, 157);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 20);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(14, 40);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 20);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "Phone";
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.groupAvatar);
            this.pnContainer.Controls.Add(this.groupAccount);
            this.pnContainer.Controls.Add(this.groupAddress);
            this.pnContainer.Controls.Add(this.groupContact);
            this.pnContainer.Controls.Add(this.groupManagement);
            this.pnContainer.Controls.Add(this.groupInfo);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1515, 494);
            this.pnContainer.TabIndex = 30;
            // 
            // groupAvatar
            // 
            this.groupAvatar.Controls.Add(this.lbProfilePhoto);
            this.groupAvatar.Controls.Add(this.btnChoose);
            this.groupAvatar.Controls.Add(this.picAvt);
            this.groupAvatar.Location = new System.Drawing.Point(1224, 26);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(265, 443);
            this.groupAvatar.TabIndex = 72;
            this.groupAvatar.TabStop = false;
            this.groupAvatar.Text = "Avatar";
            // 
            // lbProfilePhoto
            // 
            this.lbProfilePhoto.AutoSize = true;
            this.lbProfilePhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfilePhoto.Location = new System.Drawing.Point(81, 67);
            this.lbProfilePhoto.Name = "lbProfilePhoto";
            this.lbProfilePhoto.Size = new System.Drawing.Size(101, 20);
            this.lbProfilePhoto.TabIndex = 55;
            this.lbProfilePhoto.Text = "Profile photo";
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoose.Location = new System.Drawing.Point(85, 385);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 37);
            this.btnChoose.TabIndex = 53;
            this.btnChoose.Text = "CHOOSE";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // picAvt
            // 
            this.picAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvt.Location = new System.Drawing.Point(42, 123);
            this.picAvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(180, 240);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvt.TabIndex = 54;
            this.picAvt.TabStop = false;
            // 
            // groupAccount
            // 
            this.groupAccount.Controls.Add(this.textBox2);
            this.groupAccount.Controls.Add(this.lbPassword);
            this.groupAccount.Controls.Add(this.textBox1);
            this.groupAccount.Controls.Add(this.lbUserName);
            this.groupAccount.Controls.Add(this.cbbUserType);
            this.groupAccount.Controls.Add(this.label1);
            this.groupAccount.Location = new System.Drawing.Point(25, 292);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(375, 177);
            this.groupAccount.TabIndex = 71;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(133, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(212, 27);
            this.textBox2.TabIndex = 76;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(26, 94);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(76, 20);
            this.lbPassword.TabIndex = 75;
            this.lbPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(133, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 74;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(26, 47);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(84, 20);
            this.lbUserName.TabIndex = 73;
            this.lbUserName.Text = "User name";
            // 
            // cbbUserType
            // 
            this.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Location = new System.Drawing.Point(133, 136);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(212, 28);
            this.cbbUserType.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "User type";
            // 
            // groupAddress
            // 
            this.groupAddress.Controls.Add(this.txtAddress);
            this.groupAddress.Controls.Add(this.label4);
            this.groupAddress.Controls.Add(this.cbbCommune);
            this.groupAddress.Controls.Add(this.lbCommune);
            this.groupAddress.Controls.Add(this.cbbDistrict);
            this.groupAddress.Controls.Add(this.lbDistrict);
            this.groupAddress.Controls.Add(this.cbbProvince);
            this.groupAddress.Controls.Add(this.lbProvince);
            this.groupAddress.Location = new System.Drawing.Point(822, 26);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Size = new System.Drawing.Size(375, 235);
            this.groupAddress.TabIndex = 70;
            this.groupAddress.TabStop = false;
            this.groupAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Location = new System.Drawing.Point(110, 182);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 27);
            this.txtAddress.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Address";
            // 
            // cbbCommune
            // 
            this.cbbCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCommune.FormattingEnabled = true;
            this.cbbCommune.Location = new System.Drawing.Point(110, 134);
            this.cbbCommune.Name = "cbbCommune";
            this.cbbCommune.Size = new System.Drawing.Size(212, 28);
            this.cbbCommune.TabIndex = 77;
            // 
            // lbCommune
            // 
            this.lbCommune.AutoSize = true;
            this.lbCommune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommune.Location = new System.Drawing.Point(17, 134);
            this.lbCommune.Name = "lbCommune";
            this.lbCommune.Size = new System.Drawing.Size(81, 20);
            this.lbCommune.TabIndex = 76;
            this.lbCommune.Text = "Commune";
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistrict.FormattingEnabled = true;
            this.cbbDistrict.Location = new System.Drawing.Point(110, 87);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Size = new System.Drawing.Size(212, 28);
            this.cbbDistrict.TabIndex = 75;
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistrict.Location = new System.Drawing.Point(17, 87);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(60, 20);
            this.lbDistrict.TabIndex = 74;
            this.lbDistrict.Text = "District";
            // 
            // cbbProvince
            // 
            this.cbbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvince.FormattingEnabled = true;
            this.cbbProvince.Location = new System.Drawing.Point(110, 40);
            this.cbbProvince.Name = "cbbProvince";
            this.cbbProvince.Size = new System.Drawing.Size(212, 28);
            this.cbbProvince.TabIndex = 73;
            // 
            // lbProvince
            // 
            this.lbProvince.AutoSize = true;
            this.lbProvince.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvince.Location = new System.Drawing.Point(17, 40);
            this.lbProvince.Name = "lbProvince";
            this.lbProvince.Size = new System.Drawing.Size(69, 20);
            this.lbProvince.TabIndex = 72;
            this.lbProvince.Text = "Province";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.txtEmail);
            this.groupContact.Controls.Add(this.lbPhone);
            this.groupContact.Controls.Add(this.lbEmail);
            this.groupContact.Controls.Add(this.txtPhone2);
            this.groupContact.Controls.Add(this.txtSDT);
            this.groupContact.Controls.Add(this.lbPhone2);
            this.groupContact.Location = new System.Drawing.Point(822, 271);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(375, 198);
            this.groupContact.TabIndex = 69;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // txtPhone2
            // 
            this.txtPhone2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone2.Location = new System.Drawing.Point(94, 96);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(212, 27);
            this.txtPhone2.TabIndex = 64;
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone2.Location = new System.Drawing.Point(14, 98);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(66, 20);
            this.lbPhone2.TabIndex = 63;
            this.lbPhone2.Text = "Phone 2";
            // 
            // groupManagement
            // 
            this.groupManagement.Controls.Add(this.dtpStartDate);
            this.groupManagement.Controls.Add(this.lbStartDate);
            this.groupManagement.Controls.Add(this.txtStudentID);
            this.groupManagement.Controls.Add(this.lbEmployeeID);
            this.groupManagement.Controls.Add(this.txtSalary);
            this.groupManagement.Controls.Add(this.lbSalary);
            this.groupManagement.Controls.Add(this.txtManagerID);
            this.groupManagement.Controls.Add(this.lbManager);
            this.groupManagement.Location = new System.Drawing.Point(25, 26);
            this.groupManagement.Name = "groupManagement";
            this.groupManagement.Size = new System.Drawing.Size(375, 240);
            this.groupManagement.TabIndex = 68;
            this.groupManagement.TabStop = false;
            this.groupManagement.Text = "Management";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(133, 187);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(212, 27);
            this.dtpStartDate.TabIndex = 71;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(24, 192);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(78, 20);
            this.lbStartDate.TabIndex = 67;
            this.lbStartDate.Text = "Start date";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentID.Location = new System.Drawing.Point(133, 39);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(212, 27);
            this.txtStudentID.TabIndex = 38;
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeID.Location = new System.Drawing.Point(26, 42);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(97, 20);
            this.lbEmployeeID.TabIndex = 36;
            this.lbEmployeeID.Text = "Employee ID";
            this.lbEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalary.Location = new System.Drawing.Point(133, 139);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(212, 27);
            this.txtSalary.TabIndex = 66;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(26, 142);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 20);
            this.lbSalary.TabIndex = 65;
            this.lbSalary.Text = "Salary";
            // 
            // txtManagerID
            // 
            this.txtManagerID.BackColor = System.Drawing.SystemColors.Control;
            this.txtManagerID.Location = new System.Drawing.Point(133, 89);
            this.txtManagerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(212, 27);
            this.txtManagerID.TabIndex = 62;
            // 
            // lbManager
            // 
            this.lbManager.AutoSize = true;
            this.lbManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManager.Location = new System.Drawing.Point(26, 92);
            this.lbManager.Name = "lbManager";
            this.lbManager.Size = new System.Drawing.Size(91, 20);
            this.lbManager.TabIndex = 61;
            this.lbManager.Text = "Manager ID";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.dtpDoB);
            this.groupInfo.Controls.Add(this.txtLastName);
            this.groupInfo.Controls.Add(this.lbLastName);
            this.groupInfo.Controls.Add(this.txtFirstName);
            this.groupInfo.Controls.Add(this.lbFirstName);
            this.groupInfo.Controls.Add(this.lbDoB);
            this.groupInfo.Controls.Add(this.ckbFemale);
            this.groupInfo.Controls.Add(this.txtID);
            this.groupInfo.Controls.Add(this.txtHealthInsurance);
            this.groupInfo.Controls.Add(this.lbSSN);
            this.groupInfo.Controls.Add(this.lbGender);
            this.groupInfo.Controls.Add(this.lbHealthInsurance);
            this.groupInfo.Location = new System.Drawing.Point(424, 26);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(375, 443);
            this.groupInfo.TabIndex = 67;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Persional Info";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(113, 134);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(212, 27);
            this.dtpDoB.TabIndex = 63;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.Location = new System.Drawing.Point(113, 85);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 27);
            this.txtLastName.TabIndex = 62;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(20, 88);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(81, 20);
            this.lbLastName.TabIndex = 61;
            this.lbLastName.Text = "Last name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(20, 39);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(83, 20);
            this.lbFirstName.TabIndex = 37;
            this.lbFirstName.Text = "First name";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(20, 137);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(39, 20);
            this.lbDoB.TabIndex = 40;
            this.lbDoB.Text = "DoB";
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFemale.Location = new System.Drawing.Point(113, 178);
            this.ckbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(89, 27);
            this.ckbFemale.TabIndex = 60;
            this.ckbFemale.Text = "Female";
            this.ckbFemale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(113, 222);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(212, 27);
            this.txtID.TabIndex = 14;
            // 
            // lbSSN
            // 
            this.lbSSN.AutoSize = true;
            this.lbSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSN.Location = new System.Drawing.Point(20, 224);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(37, 20);
            this.lbSSN.TabIndex = 13;
            this.lbSSN.Text = "SSN";
            // 
            // pnSV
            // 
            this.pnSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnSV.Controls.Add(this.pnContainer);
            this.pnSV.Controls.Add(this.panel2);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSV.Location = new System.Drawing.Point(0, 62);
            this.pnSV.Margin = new System.Windows.Forms.Padding(4);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(1515, 547);
            this.pnSV.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1515, 53);
            this.panel2.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(856, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(563, 9);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 34);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(711, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 609);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnTop);
            this.Name = "FrmEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.groupAvatar.ResumeLayout(false);
            this.groupAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.groupManagement.ResumeLayout(false);
            this.groupManagement.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.pnSV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtHealthInsurance;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbHealthInsurance;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.CheckBox ckbFemale;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Label lbManager;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.GroupBox groupManagement;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.GroupBox groupAvatar;
        private System.Windows.Forms.Label lbProfilePhoto;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbCommune;
        private System.Windows.Forms.Label lbCommune;
        private System.Windows.Forms.ComboBox cbbDistrict;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.ComboBox cbbProvince;
        private System.Windows.Forms.Label lbProvince;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}