namespace DormitoryManagement.View
{
    partial class FrmRoomTypes
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
            this.dgvRoomTypes = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomTypes
            // 
            this.dgvRoomTypes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomTypes.Location = new System.Drawing.Point(0, 76);
            this.dgvRoomTypes.Name = "dgvRoomTypes";
            this.dgvRoomTypes.RowHeadersWidth = 51;
            this.dgvRoomTypes.RowTemplate.Height = 24;
            this.dgvRoomTypes.Size = new System.Drawing.Size(1482, 727);
            this.dgvRoomTypes.TabIndex = 16;
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
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "ROOM TYPES";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRoomTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.dgvRoomTypes);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmRoomTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Types";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomTypes;
        private System.Windows.Forms.Label lbTitle;
    }
}