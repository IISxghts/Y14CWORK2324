namespace _9320RyanMillerDatabase
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.CustomerInfoDGV = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lakeside9320SearchDataSet = new _9320RyanMillerDatabase.Lakeside9320SearchDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lakeside9320SearchBookingDataSet = new _9320RyanMillerDatabase.Lakeside9320SearchBookingDataSet();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320SearchDataSetTableAdapters.CustomerTableAdapter();
            this.CriteriaLbl = new System.Windows.Forms.Label();
            this.CriteriaSelectBox = new System.Windows.Forms.ComboBox();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.TableSelectBox = new System.Windows.Forms.ComboBox();
            this.TableLbl = new System.Windows.Forms.Label();
            this.lakeside9320SearchCoursesDataSet = new _9320RyanMillerDatabase.Lakeside9320SearchCoursesDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new _9320RyanMillerDatabase.Lakeside9320SearchCoursesDataSetTableAdapters.CoursesTableAdapter();
            this.bookingTableAdapter = new _9320RyanMillerDatabase.Lakeside9320SearchBookingDataSetTableAdapters.BookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchCoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfoDGV
            // 
            this.CustomerInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfoDGV.Location = new System.Drawing.Point(16, 178);
            this.CustomerInfoDGV.Name = "CustomerInfoDGV";
            this.CustomerInfoDGV.RowHeadersWidth = 51;
            this.CustomerInfoDGV.RowTemplate.Height = 24;
            this.CustomerInfoDGV.Size = new System.Drawing.Size(772, 293);
            this.CustomerInfoDGV.TabIndex = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lakeside9320SearchDataSet;
            // 
            // lakeside9320SearchDataSet
            // 
            this.lakeside9320SearchDataSet.DataSetName = "Lakeside9320SearchDataSet";
            this.lakeside9320SearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.lakeside9320SearchBookingDataSet;
            // 
            // lakeside9320SearchBookingDataSet
            // 
            this.lakeside9320SearchBookingDataSet.DataSetName = "Lakeside9320SearchBookingDataSet";
            this.lakeside9320SearchBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CriteriaLbl
            // 
            this.CriteriaLbl.AutoSize = true;
            this.CriteriaLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaLbl.Location = new System.Drawing.Point(12, 154);
            this.CriteriaLbl.Name = "CriteriaLbl";
            this.CriteriaLbl.Size = new System.Drawing.Size(235, 21);
            this.CriteriaLbl.TabIndex = 2;
            this.CriteriaLbl.Text = "Select Criteria to search by";
            // 
            // CriteriaSelectBox
            // 
            this.CriteriaSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CriteriaSelectBox.FormattingEnabled = true;
            this.CriteriaSelectBox.Items.AddRange(new object[] {
            "Forename",
            "Surname"});
            this.CriteriaSelectBox.Location = new System.Drawing.Point(284, 151);
            this.CriteriaSelectBox.Name = "CriteriaSelectBox";
            this.CriteriaSelectBox.Size = new System.Drawing.Size(146, 24);
            this.CriteriaSelectBox.TabIndex = 3;
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(515, 125);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(226, 22);
            this.SearchTxtBox.TabIndex = 4;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(442, 126);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(67, 21);
            this.SearchLbl.TabIndex = 5;
            this.SearchLbl.Text = "Search";
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(167, 6);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(578, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - CUSTOMER SEARCH";
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
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 63);
            this.panel3.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuTSM
            // 
            this.MainMenuTSM.Name = "MainMenuTSM";
            this.MainMenuTSM.Size = new System.Drawing.Size(97, 24);
            this.MainMenuTSM.Text = "Main Menu";
            this.MainMenuTSM.Click += new System.EventHandler(this.MainMenuTSM_Click);
            // 
            // TableSelectBox
            // 
            this.TableSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableSelectBox.FormattingEnabled = true;
            this.TableSelectBox.Items.AddRange(new object[] {
            "Customer",
            "Bookings",
            "Activity"});
            this.TableSelectBox.Location = new System.Drawing.Point(257, 105);
            this.TableSelectBox.Name = "TableSelectBox";
            this.TableSelectBox.Size = new System.Drawing.Size(146, 24);
            this.TableSelectBox.TabIndex = 9;
            this.TableSelectBox.SelectedIndexChanged += new System.EventHandler(this.TableSelectBox_SelectedIndexChanged);
            // 
            // TableLbl
            // 
            this.TableLbl.AutoSize = true;
            this.TableLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLbl.Location = new System.Drawing.Point(12, 107);
            this.TableLbl.Name = "TableLbl";
            this.TableLbl.Size = new System.Drawing.Size(196, 21);
            this.TableLbl.TabIndex = 8;
            this.TableLbl.Text = "Select Table to search";
            // 
            // lakeside9320SearchCoursesDataSet
            // 
            this.lakeside9320SearchCoursesDataSet.DataSetName = "Lakeside9320SearchCoursesDataSet";
            this.lakeside9320SearchCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.lakeside9320SearchCoursesDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.TableSelectBox);
            this.Controls.Add(this.TableLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.CriteriaSelectBox);
            this.Controls.Add(this.CriteriaLbl);
            this.Controls.Add(this.CustomerInfoDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchForm";
            this.Text = "CustomerSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320SearchCoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerInfoDGV;
        private Lakeside9320SearchDataSet lakeside9320SearchDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lakeside9320SearchDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label CriteriaLbl;
        private System.Windows.Forms.ComboBox CriteriaSelectBox;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTSM;
        private System.Windows.Forms.ComboBox TableSelectBox;
        private System.Windows.Forms.Label TableLbl;
        private Lakeside9320SearchCoursesDataSet lakeside9320SearchCoursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Lakeside9320SearchCoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private Lakeside9320SearchBookingDataSet lakeside9320SearchBookingDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private Lakeside9320SearchBookingDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
    }
}