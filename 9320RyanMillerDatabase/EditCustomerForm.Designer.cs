namespace _9320RyanMillerDatabase
{
    partial class EditCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerForm));
            this.EFCustDGV = new System.Windows.Forms.DataGridView();
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
            this.lakeside9320CEDataSet = new _9320RyanMillerDatabase.Lakeside9320CEDataSet();
            this.EFCustIDTB = new System.Windows.Forms.TextBox();
            this.EFCustIDLbl = new System.Windows.Forms.Label();
            this.EFCustForenameLbl = new System.Windows.Forms.Label();
            this.EFCustForenameTB = new System.Windows.Forms.TextBox();
            this.EFCustAddressLbl = new System.Windows.Forms.Label();
            this.EFCustAddressTB = new System.Windows.Forms.TextBox();
            this.EFCustSurnameLbl = new System.Windows.Forms.Label();
            this.EFCustSurnameTB = new System.Windows.Forms.TextBox();
            this.EFCustPhoneLbl = new System.Windows.Forms.Label();
            this.EFCustPhoneTB = new System.Windows.Forms.TextBox();
            this.EFCustPostcodeLbl = new System.Windows.Forms.Label();
            this.EFCustPostcodeTB = new System.Windows.Forms.TextBox();
            this.EFCustTownLbl = new System.Windows.Forms.Label();
            this.EFCustTownTB = new System.Windows.Forms.TextBox();
            this.EFCustSpecReqLbl = new System.Windows.Forms.Label();
            this.EFCustSpecialReqTB = new System.Windows.Forms.TextBox();
            this.EFCustEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EFCustDOBTB = new System.Windows.Forms.TextBox();
            this.EFCustSNDBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingFormTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CEDataSetTableAdapters.CustomerTableAdapter();
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EFCustDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CEDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EFCustDGV
            // 
            this.EFCustDGV.AutoGenerateColumns = false;
            this.EFCustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EFCustDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumDataGridViewTextBoxColumn,
            this.customerForenameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerPostcodeDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTownDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerSpecialReqsDataGridViewTextBoxColumn});
            this.EFCustDGV.DataSource = this.customerBindingSource;
            this.EFCustDGV.Location = new System.Drawing.Point(209, 105);
            this.EFCustDGV.Name = "EFCustDGV";
            this.EFCustDGV.RowHeadersWidth = 51;
            this.EFCustDGV.RowTemplate.Height = 24;
            this.EFCustDGV.Size = new System.Drawing.Size(679, 258);
            this.EFCustDGV.TabIndex = 0;
            this.EFCustDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EFCustDGV_CellClick);
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
            this.customerBindingSource.DataSource = this.lakeside9320CEDataSet;
            // 
            // lakeside9320CEDataSet
            // 
            this.lakeside9320CEDataSet.DataSetName = "Lakeside9320CEDataSet";
            this.lakeside9320CEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EFCustIDTB
            // 
            this.EFCustIDTB.Location = new System.Drawing.Point(81, 385);
            this.EFCustIDTB.Name = "EFCustIDTB";
            this.EFCustIDTB.ReadOnly = true;
            this.EFCustIDTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustIDTB.TabIndex = 1;
            // 
            // EFCustIDLbl
            // 
            this.EFCustIDLbl.AutoSize = true;
            this.EFCustIDLbl.Location = new System.Drawing.Point(-2, 388);
            this.EFCustIDLbl.Name = "EFCustIDLbl";
            this.EFCustIDLbl.Size = new System.Drawing.Size(77, 16);
            this.EFCustIDLbl.TabIndex = 2;
            this.EFCustIDLbl.Text = "CustomerID";
            // 
            // EFCustForenameLbl
            // 
            this.EFCustForenameLbl.AutoSize = true;
            this.EFCustForenameLbl.Location = new System.Drawing.Point(-2, 413);
            this.EFCustForenameLbl.Name = "EFCustForenameLbl";
            this.EFCustForenameLbl.Size = new System.Drawing.Size(69, 16);
            this.EFCustForenameLbl.TabIndex = 4;
            this.EFCustForenameLbl.Text = "Forename";
            // 
            // EFCustForenameTB
            // 
            this.EFCustForenameTB.Location = new System.Drawing.Point(73, 413);
            this.EFCustForenameTB.Name = "EFCustForenameTB";
            this.EFCustForenameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustForenameTB.TabIndex = 3;
            // 
            // EFCustAddressLbl
            // 
            this.EFCustAddressLbl.AutoSize = true;
            this.EFCustAddressLbl.Location = new System.Drawing.Point(4, 472);
            this.EFCustAddressLbl.Name = "EFCustAddressLbl";
            this.EFCustAddressLbl.Size = new System.Drawing.Size(58, 16);
            this.EFCustAddressLbl.TabIndex = 8;
            this.EFCustAddressLbl.Text = "Address";
            // 
            // EFCustAddressTB
            // 
            this.EFCustAddressTB.Location = new System.Drawing.Point(73, 469);
            this.EFCustAddressTB.Name = "EFCustAddressTB";
            this.EFCustAddressTB.Size = new System.Drawing.Size(128, 22);
            this.EFCustAddressTB.TabIndex = 7;
            // 
            // EFCustSurnameLbl
            // 
            this.EFCustSurnameLbl.AutoSize = true;
            this.EFCustSurnameLbl.Location = new System.Drawing.Point(4, 441);
            this.EFCustSurnameLbl.Name = "EFCustSurnameLbl";
            this.EFCustSurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.EFCustSurnameLbl.TabIndex = 6;
            this.EFCustSurnameLbl.Text = "Surname";
            // 
            // EFCustSurnameTB
            // 
            this.EFCustSurnameTB.Location = new System.Drawing.Point(73, 441);
            this.EFCustSurnameTB.Name = "EFCustSurnameTB";
            this.EFCustSurnameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustSurnameTB.TabIndex = 5;
            // 
            // EFCustPhoneLbl
            // 
            this.EFCustPhoneLbl.AutoSize = true;
            this.EFCustPhoneLbl.Location = new System.Drawing.Point(212, 472);
            this.EFCustPhoneLbl.Name = "EFCustPhoneLbl";
            this.EFCustPhoneLbl.Size = new System.Drawing.Size(97, 16);
            this.EFCustPhoneLbl.TabIndex = 14;
            this.EFCustPhoneLbl.Text = "Phone Number";
            // 
            // EFCustPhoneTB
            // 
            this.EFCustPhoneTB.Location = new System.Drawing.Point(315, 469);
            this.EFCustPhoneTB.Name = "EFCustPhoneTB";
            this.EFCustPhoneTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustPhoneTB.TabIndex = 13;
            // 
            // EFCustPostcodeLbl
            // 
            this.EFCustPostcodeLbl.AutoSize = true;
            this.EFCustPostcodeLbl.Location = new System.Drawing.Point(216, 419);
            this.EFCustPostcodeLbl.Name = "EFCustPostcodeLbl";
            this.EFCustPostcodeLbl.Size = new System.Drawing.Size(65, 16);
            this.EFCustPostcodeLbl.TabIndex = 12;
            this.EFCustPostcodeLbl.Text = "Postcode";
            // 
            // EFCustPostcodeTB
            // 
            this.EFCustPostcodeTB.Location = new System.Drawing.Point(315, 413);
            this.EFCustPostcodeTB.Name = "EFCustPostcodeTB";
            this.EFCustPostcodeTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustPostcodeTB.TabIndex = 11;
            // 
            // EFCustTownLbl
            // 
            this.EFCustTownLbl.AutoSize = true;
            this.EFCustTownLbl.Location = new System.Drawing.Point(216, 391);
            this.EFCustTownLbl.Name = "EFCustTownLbl";
            this.EFCustTownLbl.Size = new System.Drawing.Size(40, 16);
            this.EFCustTownLbl.TabIndex = 10;
            this.EFCustTownLbl.Text = "Town";
            // 
            // EFCustTownTB
            // 
            this.EFCustTownTB.Location = new System.Drawing.Point(315, 385);
            this.EFCustTownTB.Name = "EFCustTownTB";
            this.EFCustTownTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustTownTB.TabIndex = 9;
            // 
            // EFCustSpecReqLbl
            // 
            this.EFCustSpecReqLbl.AutoSize = true;
            this.EFCustSpecReqLbl.Location = new System.Drawing.Point(450, 366);
            this.EFCustSpecReqLbl.Name = "EFCustSpecReqLbl";
            this.EFCustSpecReqLbl.Size = new System.Drawing.Size(140, 16);
            this.EFCustSpecReqLbl.TabIndex = 17;
            this.EFCustSpecReqLbl.Text = "Special Requirements";
            // 
            // EFCustSpecialReqTB
            // 
            this.EFCustSpecialReqTB.Location = new System.Drawing.Point(453, 385);
            this.EFCustSpecialReqTB.Multiline = true;
            this.EFCustSpecialReqTB.Name = "EFCustSpecialReqTB";
            this.EFCustSpecialReqTB.Size = new System.Drawing.Size(435, 44);
            this.EFCustSpecialReqTB.TabIndex = 16;
            // 
            // EFCustEditBtn
            // 
            this.EFCustEditBtn.Location = new System.Drawing.Point(48, 274);
            this.EFCustEditBtn.Name = "EFCustEditBtn";
            this.EFCustEditBtn.Size = new System.Drawing.Size(108, 41);
            this.EFCustEditBtn.TabIndex = 18;
            this.EFCustEditBtn.Text = "Edit Customer";
            this.EFCustEditBtn.UseVisualStyleBackColor = true;
            this.EFCustEditBtn.Click += new System.EventHandler(this.EFCustEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date of Birth";
            // 
            // EFCustDOBTB
            // 
            this.EFCustDOBTB.Location = new System.Drawing.Point(315, 441);
            this.EFCustDOBTB.Name = "EFCustDOBTB";
            this.EFCustDOBTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustDOBTB.TabIndex = 19;
            // 
            // EFCustSNDBtn
            // 
            this.EFCustSNDBtn.Location = new System.Drawing.Point(48, 321);
            this.EFCustSNDBtn.Name = "EFCustSNDBtn";
            this.EFCustSNDBtn.Size = new System.Drawing.Size(108, 42);
            this.EFCustSNDBtn.TabIndex = 21;
            this.EFCustSNDBtn.Text = "Save New Details";
            this.EFCustSNDBtn.UseVisualStyleBackColor = true;
            this.EFCustSNDBtn.Click += new System.EventHandler(this.EFCustSNDBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuTSM,
            this.addCustomerToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.bookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "editCustStrip";
            // 
            // mainMenuTSM
            // 
            this.mainMenuTSM.Name = "mainMenuTSM";
            this.mainMenuTSM.Size = new System.Drawing.Size(97, 24);
            this.mainMenuTSM.Text = "Main Menu";
            this.mainMenuTSM.Click += new System.EventHandler(this.mainMenuTSM_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerTSM,
            this.deleteCustomerTSM});
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.addCustomerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerTSM
            // 
            this.addCustomerTSM.Name = "addCustomerTSM";
            this.addCustomerTSM.Size = new System.Drawing.Size(203, 26);
            this.addCustomerTSM.Text = "Add Customer";
            this.addCustomerTSM.Click += new System.EventHandler(this.addCustomerTSM_Click);
            // 
            // deleteCustomerTSM
            // 
            this.deleteCustomerTSM.Name = "deleteCustomerTSM";
            this.deleteCustomerTSM.Size = new System.Drawing.Size(203, 26);
            this.deleteCustomerTSM.Text = "Delete Customer";
            this.deleteCustomerTSM.Click += new System.EventHandler(this.deleteCustomerTSM_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseTSM,
            this.editCourseTSM,
            this.deleteCourseTSM});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
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
            this.bookingFormTSM});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // bookingFormTSM
            // 
            this.bookingFormTSM.Name = "bookingFormTSM";
            this.bookingFormTSM.Size = new System.Drawing.Size(185, 26);
            this.bookingFormTSM.Text = "Booking Form";
            this.bookingFormTSM.Click += new System.EventHandler(this.bookingFormTSM_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(162, 6);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(531, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - EDIT CUSTOMER";
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
            this.panel3.Size = new System.Drawing.Size(900, 63);
            this.panel3.TabIndex = 23;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.EFCustSNDBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EFCustDOBTB);
            this.Controls.Add(this.EFCustEditBtn);
            this.Controls.Add(this.EFCustSpecReqLbl);
            this.Controls.Add(this.EFCustSpecialReqTB);
            this.Controls.Add(this.EFCustPhoneLbl);
            this.Controls.Add(this.EFCustPhoneTB);
            this.Controls.Add(this.EFCustPostcodeLbl);
            this.Controls.Add(this.EFCustPostcodeTB);
            this.Controls.Add(this.EFCustTownLbl);
            this.Controls.Add(this.EFCustTownTB);
            this.Controls.Add(this.EFCustAddressLbl);
            this.Controls.Add(this.EFCustAddressTB);
            this.Controls.Add(this.EFCustSurnameLbl);
            this.Controls.Add(this.EFCustSurnameTB);
            this.Controls.Add(this.EFCustForenameLbl);
            this.Controls.Add(this.EFCustForenameTB);
            this.Controls.Add(this.EFCustIDLbl);
            this.Controls.Add(this.EFCustIDTB);
            this.Controls.Add(this.EFCustDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFCustDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CEDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EFCustDGV;
        private Lakeside9320CEDataSet lakeside9320CEDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lakeside9320CEDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSpecialReqsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox EFCustIDTB;
        private System.Windows.Forms.Label EFCustIDLbl;
        private System.Windows.Forms.Label EFCustForenameLbl;
        private System.Windows.Forms.TextBox EFCustForenameTB;
        private System.Windows.Forms.Label EFCustAddressLbl;
        private System.Windows.Forms.TextBox EFCustAddressTB;
        private System.Windows.Forms.Label EFCustSurnameLbl;
        private System.Windows.Forms.TextBox EFCustSurnameTB;
        private System.Windows.Forms.Label EFCustPhoneLbl;
        private System.Windows.Forms.TextBox EFCustPhoneTB;
        private System.Windows.Forms.Label EFCustPostcodeLbl;
        private System.Windows.Forms.TextBox EFCustPostcodeTB;
        private System.Windows.Forms.Label EFCustTownLbl;
        private System.Windows.Forms.TextBox EFCustTownTB;
        private System.Windows.Forms.Label EFCustSpecReqLbl;
        private System.Windows.Forms.TextBox EFCustSpecialReqTB;
        private System.Windows.Forms.Button EFCustEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EFCustDOBTB;
        private System.Windows.Forms.Button EFCustSNDBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuTSM;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerTSM;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerTSM;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem editCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseTSM;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingFormTSM;
        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}