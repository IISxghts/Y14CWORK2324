namespace _9320RyanMillerDatabase.UserControlsMMStaff
{
    partial class UC_Settings
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
            this.LLSettingsLbl = new System.Windows.Forms.Label();
            this.G2BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.BrightLbl = new System.Windows.Forms.Label();
            this.BrightCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LLSettingsLbl
            // 
            this.LLSettingsLbl.AutoSize = true;
            this.LLSettingsLbl.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLSettingsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLSettingsLbl.Location = new System.Drawing.Point(3, 0);
            this.LLSettingsLbl.Name = "LLSettingsLbl";
            this.LLSettingsLbl.Size = new System.Drawing.Size(277, 81);
            this.LLSettingsLbl.TabIndex = 5;
            this.LLSettingsLbl.Text = "Settings";
            // 
            // G2BtnLogout
            // 
            this.G2BtnLogout.AutoRoundedCorners = true;
            this.G2BtnLogout.BorderRadius = 32;
            this.G2BtnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.G2BtnLogout.CustomBorderColor = System.Drawing.Color.Transparent;
            this.G2BtnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.G2BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2BtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.G2BtnLogout.ForeColor = System.Drawing.Color.White;
            this.G2BtnLogout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2BtnLogout.Location = new System.Drawing.Point(0, 253);
            this.G2BtnLogout.Name = "G2BtnLogout";
            this.G2BtnLogout.Size = new System.Drawing.Size(185, 67);
            this.G2BtnLogout.TabIndex = 6;
            this.G2BtnLogout.Text = "Logout";
            this.G2BtnLogout.Click += new System.EventHandler(this.G2BtnLogout_Click);
            // 
            // BrightLbl
            // 
            this.BrightLbl.AutoSize = true;
            this.BrightLbl.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.BrightLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.BrightLbl.Location = new System.Drawing.Point(9, 95);
            this.BrightLbl.Name = "BrightLbl";
            this.BrightLbl.Size = new System.Drawing.Size(176, 41);
            this.BrightLbl.TabIndex = 7;
            this.BrightLbl.Text = "Brightness";
            // 
            // BrightCB
            // 
            this.BrightCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BrightCB.FormattingEnabled = true;
            this.BrightCB.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.BrightCB.Location = new System.Drawing.Point(191, 112);
            this.BrightCB.Name = "BrightCB";
            this.BrightCB.Size = new System.Drawing.Size(145, 24);
            this.BrightCB.TabIndex = 8;
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BrightCB);
            this.Controls.Add(this.BrightLbl);
            this.Controls.Add(this.G2BtnLogout);
            this.Controls.Add(this.LLSettingsLbl);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(953, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLSettingsLbl;
        private Guna.UI2.WinForms.Guna2Button G2BtnLogout;
        private System.Windows.Forms.Label BrightLbl;
        private System.Windows.Forms.ComboBox BrightCB;
    }
}
