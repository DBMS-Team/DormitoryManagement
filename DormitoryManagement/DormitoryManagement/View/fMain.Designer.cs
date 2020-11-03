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
            this.pnBottom = new System.Windows.Forms.Panel();
            this.pnInformation = new System.Windows.Forms.Panel();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.fLPAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain.SuspendLayout();
            this.pnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMain.Controls.Add(this.fLPAdd);
            this.pnMain.Controls.Add(this.pnAdd);
            this.pnMain.Controls.Add(this.pnAdmin);
            this.pnMain.Controls.Add(this.pnInformation);
            this.pnMain.Controls.Add(this.pnBottom);
            this.pnMain.Location = new System.Drawing.Point(1, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1182, 559);
            this.pnMain.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnBottom.Location = new System.Drawing.Point(1, 524);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1181, 34);
            this.pnBottom.TabIndex = 0;
            // 
            // pnInformation
            // 
            this.pnInformation.BackColor = System.Drawing.SystemColors.Control;
            this.pnInformation.Controls.Add(this.fLPInformation);
            this.pnInformation.Location = new System.Drawing.Point(1, 370);
            this.pnInformation.Name = "pnInformation";
            this.pnInformation.Size = new System.Drawing.Size(1181, 154);
            this.pnInformation.TabIndex = 1;
            // 
            // pnAdmin
            // 
            this.pnAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnAdmin.Location = new System.Drawing.Point(1, 194);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(600, 177);
            this.pnAdmin.TabIndex = 1;
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnAdd.Location = new System.Drawing.Point(600, 194);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(582, 177);
            this.pnAdd.TabIndex = 2;
            // 
            // fLPAdmin
            // 
            this.fLPAdmin.Location = new System.Drawing.Point(1, 194);
            this.fLPAdmin.Name = "fLPAdmin";
            this.fLPAdmin.Size = new System.Drawing.Size(558, 150);
            this.fLPAdmin.TabIndex = 0;
            // 
            // fLPAdd
            // 
            this.fLPAdd.Location = new System.Drawing.Point(603, 194);
            this.fLPAdd.Name = "fLPAdd";
            this.fLPAdd.Size = new System.Drawing.Size(440, 150);
            this.fLPAdd.TabIndex = 1;
            // 
            // fLPInformation
            // 
            this.fLPInformation.Location = new System.Drawing.Point(62, 1);
            this.fLPInformation.Name = "fLPInformation";
            this.fLPInformation.Size = new System.Drawing.Size(558, 150);
            this.fLPInformation.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.fLPAdmin);
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fMain";
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
    }
}

