namespace DormitoryManagement.View
{
    partial class FrmReport
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlReportMonthly = new DormitoryManagement.Item();
            this.ctrlReportAnnual = new DormitoryManagement.Item();
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
            this.lbTitle.Size = new System.Drawing.Size(514, 76);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "REPORT";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlReportMonthly
            // 
            this.ctrlReportMonthly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlReportMonthly.ImageItem = global::DormitoryManagement.Properties.Resources.Report;
            this.ctrlReportMonthly.Location = new System.Drawing.Point(91, 151);
            this.ctrlReportMonthly.Name = "ctrlReportMonthly";
            this.ctrlReportMonthly.Size = new System.Drawing.Size(110, 148);
            this.ctrlReportMonthly.StrKey = "";
            this.ctrlReportMonthly.TabIndex = 14;
            this.ctrlReportMonthly.Title = "MONTHLY";
            this.ctrlReportMonthly.Type = DormitoryManagement.ItemType.Unknown;
            // 
            // ctrlReportAnnual
            // 
            this.ctrlReportAnnual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlReportAnnual.ImageItem = global::DormitoryManagement.Properties.Resources.Report;
            this.ctrlReportAnnual.Location = new System.Drawing.Point(314, 151);
            this.ctrlReportAnnual.Name = "ctrlReportAnnual";
            this.ctrlReportAnnual.Size = new System.Drawing.Size(110, 148);
            this.ctrlReportAnnual.StrKey = "";
            this.ctrlReportAnnual.TabIndex = 15;
            this.ctrlReportAnnual.Title = "ANNUAL";
            this.ctrlReportAnnual.Type = DormitoryManagement.ItemType.Unknown;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 362);
            this.Controls.Add(this.ctrlReportMonthly);
            this.Controls.Add(this.ctrlReportAnnual);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private Item ctrlReportMonthly;
        private Item ctrlReportAnnual;
    }
}