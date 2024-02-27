namespace _9320RyanMillerDatabase.UserControls
{
    partial class UC_BookingsStaff
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
            this.LLBookingsLbl = new System.Windows.Forms.Label();
            this.G2BtnNewBook = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // LLBookingsLbl
            // 
            this.LLBookingsLbl.AutoSize = true;
            this.LLBookingsLbl.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLBookingsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLBookingsLbl.Location = new System.Drawing.Point(3, 0);
            this.LLBookingsLbl.Name = "LLBookingsLbl";
            this.LLBookingsLbl.Size = new System.Drawing.Size(312, 81);
            this.LLBookingsLbl.TabIndex = 4;
            this.LLBookingsLbl.Text = "Bookings";
            // 
            // G2BtnNewBook
            // 
            this.G2BtnNewBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnNewBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnNewBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnNewBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnNewBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.G2BtnNewBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnNewBook.ForeColor = System.Drawing.Color.White;
            this.G2BtnNewBook.Location = new System.Drawing.Point(17, 84);
            this.G2BtnNewBook.Name = "G2BtnNewBook";
            this.G2BtnNewBook.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.G2BtnNewBook.Size = new System.Drawing.Size(150, 150);
            this.G2BtnNewBook.TabIndex = 5;
            this.G2BtnNewBook.Text = "New Booking";
            this.G2BtnNewBook.Click += new System.EventHandler(this.G2BtnNewBook_Click);
            // 
            // UC_BookingsStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.G2BtnNewBook);
            this.Controls.Add(this.LLBookingsLbl);
            this.Name = "UC_BookingsStaff";
            this.Size = new System.Drawing.Size(953, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLBookingsLbl;
        private Guna.UI2.WinForms.Guna2CircleButton G2BtnNewBook;
    }
}
