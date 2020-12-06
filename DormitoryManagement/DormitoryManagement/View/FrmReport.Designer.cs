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
            this.item1 = new DormitoryManagement.Item();
            this.item2 = new DormitoryManagement.Item();
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
            // item1
            // 
            this.item1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.item1.BackgroundImage = global::DormitoryManagement.Properties.Resources.Report;
            this.item1.ImageItem = global::DormitoryManagement.Properties.Resources.Report;
            this.item1.Location = new System.Drawing.Point(91, 151);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(110, 148);
            this.item1.StrKey = "";
            this.item1.TabIndex = 14;
            this.item1.Title = "MONTHLY";
            this.item1.Type = DormitoryManagement.ItemType.Unknown;
            this.item1.Click += new System.EventHandler(this.item1_Click);
            // 
            // item2
            // 
            this.item2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.item2.BackgroundImage = global::DormitoryManagement.Properties.Resources.Report;
            this.item2.ImageItem = global::DormitoryManagement.Properties.Resources.Report;
            this.item2.Location = new System.Drawing.Point(314, 151);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(110, 148);
            this.item2.StrKey = "";
            this.item2.TabIndex = 15;
            this.item2.Title = "ANNUAL";
            this.item2.Type = DormitoryManagement.ItemType.Unknown;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 362);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmReport";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private Item item1;
        private Item item2;
    }
}