namespace _9320RyanMillerDatabase.UserControlsMMStaff
{
    partial class UC_Other
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LLOtherLbl = new System.Windows.Forms.Label();
            this.G2BtnViewData = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // LLOtherLbl
            // 
            this.LLOtherLbl.AutoSize = true;
            this.LLOtherLbl.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLOtherLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLOtherLbl.Location = new System.Drawing.Point(3, 0);
            this.LLOtherLbl.Name = "LLOtherLbl";
            this.LLOtherLbl.Size = new System.Drawing.Size(203, 81);
            this.LLOtherLbl.TabIndex = 5;
            this.LLOtherLbl.Text = "Other";
            // 
            // G2BtnViewData
            // 
            this.G2BtnViewData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnViewData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnViewData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnViewData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnViewData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2BtnViewData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnViewData.ForeColor = System.Drawing.Color.White;
            this.G2BtnViewData.Location = new System.Drawing.Point(17, 84);
            this.G2BtnViewData.Name = "G2BtnViewData";
            this.G2BtnViewData.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.G2BtnViewData.Size = new System.Drawing.Size(150, 150);
            this.G2BtnViewData.TabIndex = 9;
            this.G2BtnViewData.Text = "View Data";
            this.G2BtnViewData.Click += new System.EventHandler(this.G2BtnViewData_Click);
            // 
            // UC_Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.G2BtnViewData);
            this.Controls.Add(this.LLOtherLbl);
            this.Name = "UC_Other";
            this.Size = new System.Drawing.Size(953, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLOtherLbl;
        private Guna.UI2.WinForms.Guna2CircleButton G2BtnViewData;
    }
}
