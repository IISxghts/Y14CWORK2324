namespace _9320RyanMillerDatabase.UserControls
{
    partial class UC_Reports
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
            this.LLReportsLbl = new System.Windows.Forms.Label();
            this.G2BtnReportOne = new Guna.UI2.WinForms.Guna2CircleButton();
            this.G2ReportTwoBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // LLReportsLbl
            // 
            this.LLReportsLbl.AutoSize = true;
            this.LLReportsLbl.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLReportsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLReportsLbl.Location = new System.Drawing.Point(3, 0);
            this.LLReportsLbl.Name = "LLReportsLbl";
            this.LLReportsLbl.Size = new System.Drawing.Size(267, 81);
            this.LLReportsLbl.TabIndex = 4;
            this.LLReportsLbl.Text = "Reports";
            // 
            // G2BtnReportOne
            // 
            this.G2BtnReportOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnReportOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnReportOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnReportOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnReportOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2BtnReportOne.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnReportOne.ForeColor = System.Drawing.Color.White;
            this.G2BtnReportOne.Location = new System.Drawing.Point(17, 84);
            this.G2BtnReportOne.Name = "G2BtnReportOne";
            this.G2BtnReportOne.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.G2BtnReportOne.Size = new System.Drawing.Size(150, 150);
            this.G2BtnReportOne.TabIndex = 9;
            this.G2BtnReportOne.Text = "Unpaid Orders";
            this.G2BtnReportOne.Click += new System.EventHandler(this.G2BtnReportOne_Click);
            // 
            // G2ReportTwoBtn
            // 
            this.G2ReportTwoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2ReportTwoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2ReportTwoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2ReportTwoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2ReportTwoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2ReportTwoBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2ReportTwoBtn.ForeColor = System.Drawing.Color.White;
            this.G2ReportTwoBtn.Location = new System.Drawing.Point(206, 84);
            this.G2ReportTwoBtn.Name = "G2ReportTwoBtn";
            this.G2ReportTwoBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.G2ReportTwoBtn.Size = new System.Drawing.Size(150, 150);
            this.G2ReportTwoBtn.TabIndex = 11;
            this.G2ReportTwoBtn.Text = "List of Customers";
            this.G2ReportTwoBtn.Click += new System.EventHandler(this.G2UnpaidOrdersBtn_Click);
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.G2ReportTwoBtn);
            this.Controls.Add(this.G2BtnReportOne);
            this.Controls.Add(this.LLReportsLbl);
            this.Name = "UC_Reports";
            this.Size = new System.Drawing.Size(953, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLReportsLbl;
        private Guna.UI2.WinForms.Guna2CircleButton G2BtnReportOne;
        private Guna.UI2.WinForms.Guna2CircleButton G2ReportTwoBtn;
    }
}
