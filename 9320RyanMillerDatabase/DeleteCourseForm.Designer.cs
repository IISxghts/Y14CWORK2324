namespace _9320RyanMillerDatabase
{
    partial class DeleteCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCourseForm));
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteCourseBtn = new System.Windows.Forms.Button();
            this.ViewCourseIDBox = new System.Windows.Forms.TextBox();
            this.CustDeleteDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDeleteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(167, 6);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(536, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - DELETE COURSES";
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
            this.panel3.TabIndex = 68;
            // 
            // DeleteCourseBtn
            // 
            this.DeleteCourseBtn.Location = new System.Drawing.Point(674, 135);
            this.DeleteCourseBtn.Name = "DeleteCourseBtn";
            this.DeleteCourseBtn.Size = new System.Drawing.Size(100, 52);
            this.DeleteCourseBtn.TabIndex = 71;
            this.DeleteCourseBtn.Text = "Delete Course";
            this.DeleteCourseBtn.UseVisualStyleBackColor = true;
            this.DeleteCourseBtn.Click += new System.EventHandler(this.DeleteCourseBtn_Click);
            // 
            // ViewCourseIDBox
            // 
            this.ViewCourseIDBox.Location = new System.Drawing.Point(674, 107);
            this.ViewCourseIDBox.Name = "ViewCourseIDBox";
            this.ViewCourseIDBox.Size = new System.Drawing.Size(100, 22);
            this.ViewCourseIDBox.TabIndex = 70;
            // 
            // CustDeleteDGV
            // 
            this.CustDeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDeleteDGV.Location = new System.Drawing.Point(22, 107);
            this.CustDeleteDGV.Name = "CustDeleteDGV";
            this.CustDeleteDGV.RowHeadersWidth = 51;
            this.CustDeleteDGV.RowTemplate.Height = 24;
            this.CustDeleteDGV.Size = new System.Drawing.Size(620, 307);
            this.CustDeleteDGV.TabIndex = 69;
            // 
            // DeleteCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCourseBtn);
            this.Controls.Add(this.ViewCourseIDBox);
            this.Controls.Add(this.CustDeleteDGV);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCourseForm";
            this.Text = "DeleteCourse";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDeleteDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DeleteCourseBtn;
        private System.Windows.Forms.TextBox ViewCourseIDBox;
        private System.Windows.Forms.DataGridView CustDeleteDGV;
    }
}