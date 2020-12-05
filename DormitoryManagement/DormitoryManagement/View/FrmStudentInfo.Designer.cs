namespace DormitoryManagement.View
{
    partial class FrmStudentInfo
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnSV = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.lbProfilePhoto = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.groupPersionalInfo = new System.Windows.Forms.GroupBox();
            this.groupAvatar = new System.Windows.Forms.GroupBox();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.txtHealthInsurance = new System.Windows.Forms.TextBox();
            this.lbInsuranceID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSSN = new System.Windows.Forms.Label();
            this.ckbFemale = new System.Windows.Forms.CheckBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDoB = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.txtProvice = new System.Windows.Forms.TextBox();
            this.lbCommune = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupUniversity = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbUniversity = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbMajor = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnSV.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.pnTop.SuspendLayout();
            this.groupPersionalInfo.SuspendLayout();
            this.groupAvatar.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.groupAddress.SuspendLayout();
            this.groupAccount.SuspendLayout();
            this.groupUniversity.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoose.Location = new System.Drawing.Point(84, 358);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 37);
            this.btnChoose.TabIndex = 24;
            this.btnChoose.Text = "CHOOSE";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1523, 53);
            this.panel2.TabIndex = 29;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(581, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 34);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(729, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.lbTitle.Size = new System.Drawing.Size(1523, 62);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "STUDENT INFORMATION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnSV.Size = new System.Drawing.Size(1523, 544);
            this.pnSV.TabIndex = 32;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.groupUniversity);
            this.pnContainer.Controls.Add(this.groupAccount);
            this.pnContainer.Controls.Add(this.groupAddress);
            this.pnContainer.Controls.Add(this.groupContact);
            this.pnContainer.Controls.Add(this.groupAvatar);
            this.pnContainer.Controls.Add(this.groupPersionalInfo);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1523, 491);
            this.pnContainer.TabIndex = 30;
            // 
            // picAvt
            // 
            this.picAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvt.Location = new System.Drawing.Point(44, 91);
            this.picAvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(180, 240);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvt.TabIndex = 52;
            this.picAvt.TabStop = false;
            // 
            // lbProfilePhoto
            // 
            this.lbProfilePhoto.AutoSize = true;
            this.lbProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfilePhoto.Location = new System.Drawing.Point(75, 46);
            this.lbProfilePhoto.Name = "lbProfilePhoto";
            this.lbProfilePhoto.Size = new System.Drawing.Size(116, 20);
            this.lbProfilePhoto.TabIndex = 23;
            this.lbProfilePhoto.Text = "Profile photo";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.MinimumSize = new System.Drawing.Size(959, 62);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1523, 62);
            this.pnTop.TabIndex = 34;
            // 
            // groupPersionalInfo
            // 
            this.groupPersionalInfo.Controls.Add(this.cmbPriority);
            this.groupPersionalInfo.Controls.Add(this.lbPriority);
            this.groupPersionalInfo.Controls.Add(this.txtHealthInsurance);
            this.groupPersionalInfo.Controls.Add(this.lbInsuranceID);
            this.groupPersionalInfo.Controls.Add(this.txtID);
            this.groupPersionalInfo.Controls.Add(this.lbSSN);
            this.groupPersionalInfo.Controls.Add(this.ckbFemale);
            this.groupPersionalInfo.Controls.Add(this.lbGender);
            this.groupPersionalInfo.Controls.Add(this.dateTimePicker1);
            this.groupPersionalInfo.Controls.Add(this.lbDoB);
            this.groupPersionalInfo.Controls.Add(this.txtStudentID);
            this.groupPersionalInfo.Controls.Add(this.lbStudentID);
            this.groupPersionalInfo.Controls.Add(this.lbLastName);
            this.groupPersionalInfo.Controls.Add(this.txtLastName);
            this.groupPersionalInfo.Controls.Add(this.lbFirstName);
            this.groupPersionalInfo.Controls.Add(this.txtFirstName);
            this.groupPersionalInfo.Location = new System.Drawing.Point(32, 28);
            this.groupPersionalInfo.Name = "groupPersionalInfo";
            this.groupPersionalInfo.Size = new System.Drawing.Size(360, 429);
            this.groupPersionalInfo.TabIndex = 61;
            this.groupPersionalInfo.TabStop = false;
            this.groupPersionalInfo.Text = "Persional Info";
            // 
            // groupAvatar
            // 
            this.groupAvatar.Controls.Add(this.picAvt);
            this.groupAvatar.Controls.Add(this.lbProfilePhoto);
            this.groupAvatar.Controls.Add(this.btnChoose);
            this.groupAvatar.Location = new System.Drawing.Point(1224, 28);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(265, 429);
            this.groupAvatar.TabIndex = 62;
            this.groupAvatar.TabStop = false;
            this.groupAvatar.Text = "Avatar";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.txtPhone2);
            this.groupContact.Controls.Add(this.lbPhone2);
            this.groupContact.Controls.Add(this.txtEmail);
            this.groupContact.Controls.Add(this.txtSDT);
            this.groupContact.Controls.Add(this.lbEmail);
            this.groupContact.Controls.Add(this.lbPhone);
            this.groupContact.Location = new System.Drawing.Point(430, 28);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(345, 188);
            this.groupContact.TabIndex = 65;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // txtPhone2
            // 
            this.txtPhone2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone2.Location = new System.Drawing.Point(106, 83);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(212, 27);
            this.txtPhone2.TabIndex = 70;
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone2.Location = new System.Drawing.Point(20, 83);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(66, 20);
            this.lbPhone2.TabIndex = 69;
            this.lbPhone2.Text = "Phone 2";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(106, 134);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 27);
            this.txtEmail.TabIndex = 68;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtSDT.Location = new System.Drawing.Point(106, 32);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 27);
            this.txtSDT.TabIndex = 66;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(20, 134);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 20);
            this.lbEmail.TabIndex = 67;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(20, 32);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 20);
            this.lbPhone.TabIndex = 65;
            this.lbPhone.Text = "Phone";
            // 
            // cmbPriority
            // 
            this.cmbPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "2NT",
            "3"});
            this.cmbPriority.Location = new System.Drawing.Point(123, 378);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(212, 28);
            this.cmbPriority.TabIndex = 88;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriority.Location = new System.Drawing.Point(20, 381);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(61, 20);
            this.lbPriority.TabIndex = 87;
            this.lbPriority.Text = "Priority";
            // 
            // txtHealthInsurance
            // 
            this.txtHealthInsurance.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthInsurance.Location = new System.Drawing.Point(123, 326);
            this.txtHealthInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHealthInsurance.Name = "txtHealthInsurance";
            this.txtHealthInsurance.Size = new System.Drawing.Size(212, 27);
            this.txtHealthInsurance.TabIndex = 86;
            // 
            // lbInsuranceID
            // 
            this.lbInsuranceID.AutoSize = true;
            this.lbInsuranceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsuranceID.Location = new System.Drawing.Point(20, 329);
            this.lbInsuranceID.Name = "lbInsuranceID";
            this.lbInsuranceID.Size = new System.Drawing.Size(97, 20);
            this.lbInsuranceID.TabIndex = 85;
            this.lbInsuranceID.Text = "Insurance ID";
            this.lbInsuranceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(123, 274);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(212, 27);
            this.txtID.TabIndex = 84;
            // 
            // lbSSN
            // 
            this.lbSSN.AutoSize = true;
            this.lbSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSN.Location = new System.Drawing.Point(20, 277);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(37, 20);
            this.lbSSN.TabIndex = 83;
            this.lbSSN.Text = "SSN";
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFemale.Location = new System.Drawing.Point(123, 228);
            this.ckbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(89, 27);
            this.ckbFemale.TabIndex = 80;
            this.ckbFemale.Text = "Female";
            this.ckbFemale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(20, 231);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 79;
            this.lbGender.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 27);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(20, 183);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(39, 20);
            this.lbDoB.TabIndex = 77;
            this.lbDoB.Text = "DoB";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentID.Location = new System.Drawing.Point(123, 32);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(212, 27);
            this.txtStudentID.TabIndex = 76;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(20, 32);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(84, 20);
            this.lbStudentID.TabIndex = 75;
            this.lbStudentID.Text = "Student ID";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(20, 134);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(81, 20);
            this.lbLastName.TabIndex = 73;
            this.lbLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.Location = new System.Drawing.Point(123, 134);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 27);
            this.txtLastName.TabIndex = 74;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(20, 83);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(83, 20);
            this.lbFirstName.TabIndex = 71;
            this.lbFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.Location = new System.Drawing.Point(123, 83);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 27);
            this.txtFirstName.TabIndex = 72;
            // 
            // groupAddress
            // 
            this.groupAddress.Controls.Add(this.label1);
            this.groupAddress.Controls.Add(this.txtProvice);
            this.groupAddress.Controls.Add(this.lbCommune);
            this.groupAddress.Controls.Add(this.txtDoB);
            this.groupAddress.Controls.Add(this.lbDistrict);
            this.groupAddress.Controls.Add(this.txtFullName);
            this.groupAddress.Location = new System.Drawing.Point(430, 241);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Size = new System.Drawing.Size(345, 216);
            this.groupAddress.TabIndex = 66;
            this.groupAddress.TabStop = false;
            this.groupAddress.Text = "Address";
            // 
            // txtProvice
            // 
            this.txtProvice.BackColor = System.Drawing.SystemColors.Control;
            this.txtProvice.Location = new System.Drawing.Point(106, 159);
            this.txtProvice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProvice.Name = "txtProvice";
            this.txtProvice.Size = new System.Drawing.Size(212, 27);
            this.txtProvice.TabIndex = 63;
            // 
            // lbCommune
            // 
            this.lbCommune.AutoSize = true;
            this.lbCommune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommune.Location = new System.Drawing.Point(20, 162);
            this.lbCommune.Name = "lbCommune";
            this.lbCommune.Size = new System.Drawing.Size(81, 20);
            this.lbCommune.TabIndex = 67;
            this.lbCommune.Text = "Commune";
            // 
            // txtDoB
            // 
            this.txtDoB.BackColor = System.Drawing.SystemColors.Control;
            this.txtDoB.Location = new System.Drawing.Point(106, 95);
            this.txtDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(212, 27);
            this.txtDoB.TabIndex = 66;
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistrict.Location = new System.Drawing.Point(20, 98);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(60, 20);
            this.lbDistrict.TabIndex = 64;
            this.lbDistrict.Text = "District";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.Location = new System.Drawing.Point(106, 38);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(212, 27);
            this.txtFullName.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Provice";
            // 
            // groupAccount
            // 
            this.groupAccount.Controls.Add(this.textBox2);
            this.groupAccount.Controls.Add(this.lbPassword);
            this.groupAccount.Controls.Add(this.textBox1);
            this.groupAccount.Controls.Add(this.lbUserName);
            this.groupAccount.Controls.Add(this.cmbUserType);
            this.groupAccount.Controls.Add(this.label2);
            this.groupAccount.Location = new System.Drawing.Point(812, 28);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(375, 188);
            this.groupAccount.TabIndex = 72;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(133, 83);
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
            this.lbPassword.Location = new System.Drawing.Point(26, 83);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(76, 20);
            this.lbPassword.TabIndex = 75;
            this.lbPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(133, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 74;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(26, 32);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(84, 20);
            this.lbUserName.TabIndex = 73;
            this.lbUserName.Text = "User name";
            // 
            // cmbUserType
            // 
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(133, 130);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(212, 28);
            this.cmbUserType.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "User type";
            // 
            // groupUniversity
            // 
            this.groupUniversity.Controls.Add(this.comboBox2);
            this.groupUniversity.Controls.Add(this.lbMajor);
            this.groupUniversity.Controls.Add(this.cmbClass);
            this.groupUniversity.Controls.Add(this.lbFaculty);
            this.groupUniversity.Controls.Add(this.comboBox1);
            this.groupUniversity.Controls.Add(this.lbUniversity);
            this.groupUniversity.Location = new System.Drawing.Point(812, 241);
            this.groupUniversity.Name = "groupUniversity";
            this.groupUniversity.Size = new System.Drawing.Size(375, 216);
            this.groupUniversity.TabIndex = 73;
            this.groupUniversity.TabStop = false;
            this.groupUniversity.Text = "University";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 28);
            this.comboBox1.TabIndex = 74;
            // 
            // lbUniversity
            // 
            this.lbUniversity.AutoSize = true;
            this.lbUniversity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUniversity.Location = new System.Drawing.Point(26, 41);
            this.lbUniversity.Name = "lbUniversity";
            this.lbUniversity.Size = new System.Drawing.Size(80, 20);
            this.lbUniversity.TabIndex = 73;
            this.lbUniversity.Text = "University";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(133, 92);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(212, 28);
            this.cmbClass.TabIndex = 84;
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaculty.Location = new System.Drawing.Point(26, 95);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(59, 20);
            this.lbFaculty.TabIndex = 83;
            this.lbFaculty.Text = "Faculty";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 146);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 28);
            this.comboBox2.TabIndex = 86;
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.Location = new System.Drawing.Point(26, 149);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(50, 20);
            this.lbMajor.TabIndex = 85;
            this.lbMajor.Text = "Major";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(874, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 606);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnTop);
            this.MaximizeBox = false;
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.panel2.ResumeLayout(false);
            this.pnSV.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.groupPersionalInfo.ResumeLayout(false);
            this.groupPersionalInfo.PerformLayout();
            this.groupAvatar.ResumeLayout(false);
            this.groupAvatar.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            this.groupUniversity.ResumeLayout(false);
            this.groupUniversity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Label lbProfilePhoto;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupPersionalInfo;
        private System.Windows.Forms.GroupBox groupAvatar;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvice;
        private System.Windows.Forms.Label lbCommune;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.TextBox txtHealthInsurance;
        private System.Windows.Forms.Label lbInsuranceID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.CheckBox ckbFemale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupUniversity;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbUniversity;
        private System.Windows.Forms.Button btnDelete;
    }
}