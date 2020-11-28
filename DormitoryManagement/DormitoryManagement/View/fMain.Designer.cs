namespace DormitoryManagement
{
    partial class fMain
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.fLPAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.pnInformation = new System.Windows.Forms.Panel();
            this.fLPInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.fLPAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain.SuspendLayout();
            this.pnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMain.Controls.Add(this.btnlogin);
            this.pnMain.Controls.Add(this.fLPAdd);
            this.pnMain.Controls.Add(this.pnAdd);
            this.pnMain.Controls.Add(this.pnAdmin);
            this.pnMain.Controls.Add(this.pnInformation);
            this.pnMain.Controls.Add(this.pnBottom);
            this.pnMain.Location = new System.Drawing.Point(1, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1576, 688);
            this.pnMain.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(1322, 31);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(224, 23);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // fLPAdd
            // 
            this.fLPAdd.Location = new System.Drawing.Point(804, 239);
            this.fLPAdd.Margin = new System.Windows.Forms.Padding(4);
            this.fLPAdd.Name = "fLPAdd";
            this.fLPAdd.Size = new System.Drawing.Size(587, 185);
            this.fLPAdd.TabIndex = 1;
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnAdd.Location = new System.Drawing.Point(800, 239);
            this.pnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(776, 218);
            this.pnAdd.TabIndex = 2;
            // 
            // pnAdmin
            // 
            this.pnAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnAdmin.Location = new System.Drawing.Point(1, 239);
            this.pnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(800, 218);
            this.pnAdmin.TabIndex = 1;
            // 
            // pnInformation
            // 
            this.pnInformation.BackColor = System.Drawing.SystemColors.Control;
            this.pnInformation.Controls.Add(this.fLPInformation);
            this.pnInformation.Location = new System.Drawing.Point(1, 455);
            this.pnInformation.Margin = new System.Windows.Forms.Padding(4);
            this.pnInformation.Name = "pnInformation";
            this.pnInformation.Size = new System.Drawing.Size(1575, 190);
            this.pnInformation.TabIndex = 1;
            // 
            // fLPInformation
            // 
            this.fLPInformation.Location = new System.Drawing.Point(83, 1);
            this.fLPInformation.Margin = new System.Windows.Forms.Padding(4);
            this.fLPInformation.Name = "fLPInformation";
            this.fLPInformation.Size = new System.Drawing.Size(744, 185);
            this.fLPInformation.TabIndex = 1;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnBottom.Location = new System.Drawing.Point(1, 645);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1575, 42);
            this.pnBottom.TabIndex = 0;
            // 
            // fLPAdmin
            // 
            this.fLPAdmin.Location = new System.Drawing.Point(1, 239);
            this.fLPAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.fLPAdmin.Name = "fLPAdmin";
            this.fLPAdmin.Size = new System.Drawing.Size(744, 185);
            this.fLPAdmin.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.fLPAdmin);
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnMain.ResumeLayout(false);
            this.pnInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.FlowLayoutPanel fLPAdd;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.Panel pnInformation;
        private System.Windows.Forms.FlowLayoutPanel fLPInformation;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.FlowLayoutPanel fLPAdmin;
        private System.Windows.Forms.Button btnlogin;
    }
}

