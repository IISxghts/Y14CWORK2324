namespace _9320RyanMillerDatabase
{
    partial class ViewBookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookingsForm));
            this.BookingViewDGV = new System.Windows.Forms.DataGridView();
            this.ViewBookingBtn = new System.Windows.Forms.Button();
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BookingViewDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookingViewDGV
            // 
            this.BookingViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingViewDGV.Location = new System.Drawing.Point(12, 126);
            this.BookingViewDGV.Name = "BookingViewDGV";
            this.BookingViewDGV.RowHeadersWidth = 51;
            this.BookingViewDGV.RowTemplate.Height = 24;
            this.BookingViewDGV.Size = new System.Drawing.Size(776, 312);
            this.BookingViewDGV.TabIndex = 0;
            // 
            // ViewBookingBtn
            // 
            this.ViewBookingBtn.Location = new System.Drawing.Point(12, 69);
            this.ViewBookingBtn.Name = "ViewBookingBtn";
            this.ViewBookingBtn.Size = new System.Drawing.Size(226, 51);
            this.ViewBookingBtn.TabIndex = 1;
            this.ViewBookingBtn.Text = "View Booking";
            this.ViewBookingBtn.UseVisualStyleBackColor = true;
            this.ViewBookingBtn.Click += new System.EventHandler(this.ViewBookingBtn_Click);
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(167, 12);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(518, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - VIEW BOOKING";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(144, 51);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.LLMenuLbl);
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 63);
            this.panel3.TabIndex = 7;
            // 
            // ViewBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ViewBookingBtn);
            this.Controls.Add(this.BookingViewDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBookingsForm";
            this.Text = "View Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.BookingViewDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingViewDGV;
        private System.Windows.Forms.Button ViewBookingBtn;
        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}