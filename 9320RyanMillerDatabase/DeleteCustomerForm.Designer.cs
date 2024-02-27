namespace _9320RyanMillerDatabase
{
    partial class DeleteCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomerForm));
            this.CustDeleteDGV = new System.Windows.Forms.DataGridView();
            this.customerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerForenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSpecialReqsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lakeside9320CustDataSet = new _9320RyanMillerDatabase.Lakeside9320CustDataSet();
            this.ViewCustIDLbl = new System.Windows.Forms.Label();
            this.ViewCourseIDBox = new System.Windows.Forms.TextBox();
            this.DeleteCourseBtn = new System.Windows.Forms.Button();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CustDataSetTableAdapters.CustomerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CustDeleteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustDeleteDGV
            // 
            this.CustDeleteDGV.AutoGenerateColumns = false;
            this.CustDeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDeleteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumDataGridViewTextBoxColumn,
            this.customerForenameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerPostcodeDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTownDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerSpecialReqsDataGridViewTextBoxColumn});
            this.CustDeleteDGV.DataSource = this.customerBindingSource;
            this.CustDeleteDGV.Location = new System.Drawing.Point(12, 159);
            this.CustDeleteDGV.Name = "CustDeleteDGV";
            this.CustDeleteDGV.RowHeadersWidth = 51;
            this.CustDeleteDGV.RowTemplate.Height = 24;
            this.CustDeleteDGV.Size = new System.Drawing.Size(620, 307);
            this.CustDeleteDGV.TabIndex = 0;
            this.CustDeleteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustDeleteDGV_CellClick);
            // 
            // customerNumDataGridViewTextBoxColumn
            // 
            this.customerNumDataGridViewTextBoxColumn.DataPropertyName = "CustomerNum";
            this.customerNumDataGridViewTextBoxColumn.HeaderText = "CustomerNum";
            this.customerNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNumDataGridViewTextBoxColumn.Name = "customerNumDataGridViewTextBoxColumn";
            this.customerNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerForenameDataGridViewTextBoxColumn
            // 
            this.customerForenameDataGridViewTextBoxColumn.DataPropertyName = "CustomerForename";
            this.customerForenameDataGridViewTextBoxColumn.HeaderText = "CustomerForename";
            this.customerForenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerForenameDataGridViewTextBoxColumn.Name = "customerForenameDataGridViewTextBoxColumn";
            this.customerForenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerPostcodeDataGridViewTextBoxColumn
            // 
            this.customerPostcodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerPostcode";
            this.customerPostcodeDataGridViewTextBoxColumn.HeaderText = "CustomerPostcode";
            this.customerPostcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPostcodeDataGridViewTextBoxColumn.Name = "customerPostcodeDataGridViewTextBoxColumn";
            this.customerPostcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTownDataGridViewTextBoxColumn
            // 
            this.customerTownDataGridViewTextBoxColumn.DataPropertyName = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.HeaderText = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerTownDataGridViewTextBoxColumn.Name = "customerTownDataGridViewTextBoxColumn";
            this.customerTownDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDOBDataGridViewTextBoxColumn
            // 
            this.customerDOBDataGridViewTextBoxColumn.DataPropertyName = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.HeaderText = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDOBDataGridViewTextBoxColumn.Name = "customerDOBDataGridViewTextBoxColumn";
            this.customerDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSpecialReqsDataGridViewTextBoxColumn
            // 
            this.customerSpecialReqsDataGridViewTextBoxColumn.DataPropertyName = "CustomerSpecialReqs";
            this.customerSpecialReqsDataGridViewTextBoxColumn.HeaderText = "CustomerSpecialReqs";
            this.customerSpecialReqsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSpecialReqsDataGridViewTextBoxColumn.Name = "customerSpecialReqsDataGridViewTextBoxColumn";
            this.customerSpecialReqsDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lakeside9320CustDataSet;
            // 
            // lakeside9320CustDataSet
            // 
            this.lakeside9320CustDataSet.DataSetName = "Lakeside9320CustDataSet";
            this.lakeside9320CustDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewCustIDLbl
            // 
            this.ViewCustIDLbl.AutoSize = true;
            this.ViewCustIDLbl.Location = new System.Drawing.Point(661, 76);
            this.ViewCustIDLbl.Name = "ViewCustIDLbl";
            this.ViewCustIDLbl.Size = new System.Drawing.Size(115, 16);
            this.ViewCustIDLbl.TabIndex = 1;
            this.ViewCustIDLbl.Text = "Customer Number";
            // 
            // ViewCourseIDBox
            // 
            this.ViewCourseIDBox.Location = new System.Drawing.Point(664, 159);
            this.ViewCourseIDBox.Name = "ViewCourseIDBox";
            this.ViewCourseIDBox.Size = new System.Drawing.Size(100, 22);
            this.ViewCourseIDBox.TabIndex = 2;
            // 
            // DeleteCourseBtn
            // 
            this.DeleteCourseBtn.Location = new System.Drawing.Point(664, 187);
            this.DeleteCourseBtn.Name = "DeleteCourseBtn";
            this.DeleteCourseBtn.Size = new System.Drawing.Size(100, 52);
            this.DeleteCourseBtn.TabIndex = 3;
            this.DeleteCourseBtn.Text = "Delete Customer";
            this.DeleteCourseBtn.UseVisualStyleBackColor = true;
            this.DeleteCourseBtn.Click += new System.EventHandler(this.DeleteCustBtn_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.bookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "editCustStrip";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerTSM,
            this.editCustomerTSM});
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.addCustomerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerTSM
            // 
            this.addCustomerTSM.Name = "addCustomerTSM";
            this.addCustomerTSM.Size = new System.Drawing.Size(187, 26);
            this.addCustomerTSM.Text = "Add Customer";
            this.addCustomerTSM.Click += new System.EventHandler(this.addCustomerTSM_Click);
            // 
            // editCustomerTSM
            // 
            this.editCustomerTSM.Name = "editCustomerTSM";
            this.editCustomerTSM.Size = new System.Drawing.Size(187, 26);
            this.editCustomerTSM.Text = "Edit Customer";
            this.editCustomerTSM.Click += new System.EventHandler(this.editCustomerTSM_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseTSM,
            this.editCourseTSM,
            this.deleteCourseTSM});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseTSM
            // 
            this.addCourseTSM.Name = "addCourseTSM";
            this.addCourseTSM.Size = new System.Drawing.Size(185, 26);
            this.addCourseTSM.Text = "Add Course";
            this.addCourseTSM.Click += new System.EventHandler(this.addCourseTSM_Click);
            // 
            // editCourseTSM
            // 
            this.editCourseTSM.Name = "editCourseTSM";
            this.editCourseTSM.Size = new System.Drawing.Size(185, 26);
            this.editCourseTSM.Text = "Edit Course";
            this.editCourseTSM.Click += new System.EventHandler(this.editCourseTSM_Click);
            // 
            // deleteCourseTSM
            // 
            this.deleteCourseTSM.Name = "deleteCourseTSM";
            this.deleteCourseTSM.Size = new System.Drawing.Size(185, 26);
            this.deleteCourseTSM.Text = "Delete Course";
            this.deleteCourseTSM.Click += new System.EventHandler(this.deleteCourseTSM_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingFormToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // bookingFormToolStripMenuItem
            // 
            this.bookingFormToolStripMenuItem.Name = "bookingFormToolStripMenuItem";
            this.bookingFormToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.bookingFormToolStripMenuItem.Text = "Booking Form";
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(167, 6);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(582, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - DELETE CUSTOMERS";
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
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 63);
            this.panel3.TabIndex = 69;
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteCourseBtn);
            this.Controls.Add(this.ViewCourseIDBox);
            this.Controls.Add(this.ViewCustIDLbl);
            this.Controls.Add(this.CustDeleteDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeleteCustomerForm";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustDeleteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustDeleteDGV;
        private Lakeside9320CustDataSet lakeside9320CustDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lakeside9320CustDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSpecialReqsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ViewCustIDLbl;
        private System.Windows.Forms.TextBox ViewCourseIDBox;
        private System.Windows.Forms.Button DeleteCourseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerTSM;
        private System.Windows.Forms.ToolStripMenuItem editCustomerTSM;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem editCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingFormToolStripMenuItem;
        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}