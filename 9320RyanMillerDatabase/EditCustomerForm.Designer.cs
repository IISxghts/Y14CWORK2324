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
            this.EFCustSNDBtn = new System.Windows.Forms.Button();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CEDataSetTableAdapters.CustomerTableAdapter();
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditCustDTP = new System.Windows.Forms.DateTimePicker();
            this.G2HomeSideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.G2CustSideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.G2CourseSideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.G2BookSideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.G2ReportsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuSideLbl = new System.Windows.Forms.Label();
            this.SidebarPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.customerContainer = new System.Windows.Forms.Panel();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.G2AddCustBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.G2DeleteCustBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.G2EditCustBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.coursesContainer = new System.Windows.Forms.Panel();
            this.AddCourseBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteCourseBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.EditCourseBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.bookingContainer = new System.Windows.Forms.Panel();
            this.G2AddBookBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.G2DeleteBookBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.G2EditBookBtnS = new Guna.UI2.WinForms.Guna2Button();
            this.ReportsContainer = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.G2UnpaidBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ReportSideTimer = new System.Windows.Forms.Timer(this.components);
            this.CustSideTimer = new System.Windows.Forms.Timer(this.components);
            this.CourseSideTimer = new System.Windows.Forms.Timer(this.components);
            this.BookSideTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EFCustDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarPB)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            this.customerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            this.coursesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            this.bookingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            this.ReportsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
            this.EFCustDGV.Location = new System.Drawing.Point(227, 79);
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
            this.EFCustIDTB.Location = new System.Drawing.Point(416, 340);
            this.EFCustIDTB.Name = "EFCustIDTB";
            this.EFCustIDTB.ReadOnly = true;
            this.EFCustIDTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustIDTB.TabIndex = 1;
            // 
            // EFCustIDLbl
            // 
            this.EFCustIDLbl.AutoSize = true;
            this.EFCustIDLbl.Location = new System.Drawing.Point(233, 340);
            this.EFCustIDLbl.Name = "EFCustIDLbl";
            this.EFCustIDLbl.Size = new System.Drawing.Size(77, 16);
            this.EFCustIDLbl.TabIndex = 2;
            this.EFCustIDLbl.Text = "CustomerID";
            // 
            // EFCustForenameLbl
            // 
            this.EFCustForenameLbl.AutoSize = true;
            this.EFCustForenameLbl.Location = new System.Drawing.Point(233, 365);
            this.EFCustForenameLbl.Name = "EFCustForenameLbl";
            this.EFCustForenameLbl.Size = new System.Drawing.Size(69, 16);
            this.EFCustForenameLbl.TabIndex = 4;
            this.EFCustForenameLbl.Text = "Forename";
            // 
            // EFCustForenameTB
            // 
            this.EFCustForenameTB.Location = new System.Drawing.Point(408, 368);
            this.EFCustForenameTB.Name = "EFCustForenameTB";
            this.EFCustForenameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustForenameTB.TabIndex = 3;
            // 
            // EFCustAddressLbl
            // 
            this.EFCustAddressLbl.AutoSize = true;
            this.EFCustAddressLbl.Location = new System.Drawing.Point(239, 424);
            this.EFCustAddressLbl.Name = "EFCustAddressLbl";
            this.EFCustAddressLbl.Size = new System.Drawing.Size(58, 16);
            this.EFCustAddressLbl.TabIndex = 8;
            this.EFCustAddressLbl.Text = "Address";
            // 
            // EFCustAddressTB
            // 
            this.EFCustAddressTB.Location = new System.Drawing.Point(408, 424);
            this.EFCustAddressTB.Name = "EFCustAddressTB";
            this.EFCustAddressTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustAddressTB.TabIndex = 7;
            // 
            // EFCustSurnameLbl
            // 
            this.EFCustSurnameLbl.AutoSize = true;
            this.EFCustSurnameLbl.Location = new System.Drawing.Point(239, 393);
            this.EFCustSurnameLbl.Name = "EFCustSurnameLbl";
            this.EFCustSurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.EFCustSurnameLbl.TabIndex = 6;
            this.EFCustSurnameLbl.Text = "Surname";
            // 
            // EFCustSurnameTB
            // 
            this.EFCustSurnameTB.Location = new System.Drawing.Point(408, 396);
            this.EFCustSurnameTB.Name = "EFCustSurnameTB";
            this.EFCustSurnameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustSurnameTB.TabIndex = 5;
            // 
            // EFCustPhoneLbl
            // 
            this.EFCustPhoneLbl.AutoSize = true;
            this.EFCustPhoneLbl.Location = new System.Drawing.Point(516, 427);
            this.EFCustPhoneLbl.Name = "EFCustPhoneLbl";
            this.EFCustPhoneLbl.Size = new System.Drawing.Size(97, 16);
            this.EFCustPhoneLbl.TabIndex = 14;
            this.EFCustPhoneLbl.Text = "Phone Number";
            // 
            // EFCustPhoneTB
            // 
            this.EFCustPhoneTB.Location = new System.Drawing.Point(619, 424);
            this.EFCustPhoneTB.Name = "EFCustPhoneTB";
            this.EFCustPhoneTB.Size = new System.Drawing.Size(102, 22);
            this.EFCustPhoneTB.TabIndex = 13;
            // 
            // EFCustPostcodeLbl
            // 
            this.EFCustPostcodeLbl.AutoSize = true;
            this.EFCustPostcodeLbl.Location = new System.Drawing.Point(520, 374);
            this.EFCustPostcodeLbl.Name = "EFCustPostcodeLbl";
            this.EFCustPostcodeLbl.Size = new System.Drawing.Size(65, 16);
            this.EFCustPostcodeLbl.TabIndex = 12;
            this.EFCustPostcodeLbl.Text = "Postcode";
            // 
            // EFCustPostcodeTB
            // 
            this.EFCustPostcodeTB.Location = new System.Drawing.Point(619, 368);
            this.EFCustPostcodeTB.Name = "EFCustPostcodeTB";
            this.EFCustPostcodeTB.Size = new System.Drawing.Size(102, 22);
            this.EFCustPostcodeTB.TabIndex = 11;
            // 
            // EFCustTownLbl
            // 
            this.EFCustTownLbl.AutoSize = true;
            this.EFCustTownLbl.Location = new System.Drawing.Point(520, 346);
            this.EFCustTownLbl.Name = "EFCustTownLbl";
            this.EFCustTownLbl.Size = new System.Drawing.Size(40, 16);
            this.EFCustTownLbl.TabIndex = 10;
            this.EFCustTownLbl.Text = "Town";
            // 
            // EFCustTownTB
            // 
            this.EFCustTownTB.Location = new System.Drawing.Point(619, 340);
            this.EFCustTownTB.Name = "EFCustTownTB";
            this.EFCustTownTB.Size = new System.Drawing.Size(102, 22);
            this.EFCustTownTB.TabIndex = 9;
            // 
            // EFCustSpecReqLbl
            // 
            this.EFCustSpecReqLbl.AutoSize = true;
            this.EFCustSpecReqLbl.Location = new System.Drawing.Point(762, 340);
            this.EFCustSpecReqLbl.Name = "EFCustSpecReqLbl";
            this.EFCustSpecReqLbl.Size = new System.Drawing.Size(140, 16);
            this.EFCustSpecReqLbl.TabIndex = 17;
            this.EFCustSpecReqLbl.Text = "Special Requirements";
            // 
            // EFCustSpecialReqTB
            // 
            this.EFCustSpecialReqTB.Location = new System.Drawing.Point(765, 362);
            this.EFCustSpecialReqTB.Multiline = true;
            this.EFCustSpecialReqTB.Name = "EFCustSpecialReqTB";
            this.EFCustSpecialReqTB.Size = new System.Drawing.Size(232, 84);
            this.EFCustSpecialReqTB.TabIndex = 16;
            // 
            // EFCustEditBtn
            // 
            this.EFCustEditBtn.Location = new System.Drawing.Point(236, 455);
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
            this.label1.Location = new System.Drawing.Point(520, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date of Birth";
            // 
            // EFCustSNDBtn
            // 
            this.EFCustSNDBtn.Location = new System.Drawing.Point(352, 455);
            this.EFCustSNDBtn.Name = "EFCustSNDBtn";
            this.EFCustSNDBtn.Size = new System.Drawing.Size(108, 42);
            this.EFCustSNDBtn.TabIndex = 21;
            this.EFCustSNDBtn.Text = "Save New Details";
            this.EFCustSNDBtn.UseVisualStyleBackColor = true;
            this.EFCustSNDBtn.Click += new System.EventHandler(this.EFCustSNDBtn_Click);
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
            this.LLMenuLbl.Location = new System.Drawing.Point(466, 9);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(531, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - EDIT CUSTOMER";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(316, 9);
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
            this.panel3.Size = new System.Drawing.Size(1000, 63);
            this.panel3.TabIndex = 23;
            // 
            // EditCustDTP
            // 
            this.EditCustDTP.Location = new System.Drawing.Point(619, 396);
            this.EditCustDTP.Name = "EditCustDTP";
            this.EditCustDTP.Size = new System.Drawing.Size(140, 22);
            this.EditCustDTP.TabIndex = 24;
            // 
            // G2HomeSideBtn
            // 
            this.G2HomeSideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2HomeSideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2HomeSideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2HomeSideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2HomeSideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2HomeSideBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2HomeSideBtn.ForeColor = System.Drawing.Color.White;
            this.G2HomeSideBtn.Location = new System.Drawing.Point(3, 3);
            this.G2HomeSideBtn.Name = "G2HomeSideBtn";
            this.G2HomeSideBtn.Size = new System.Drawing.Size(209, 47);
            this.G2HomeSideBtn.TabIndex = 13;
            this.G2HomeSideBtn.Text = "Home";
            this.G2HomeSideBtn.Click += new System.EventHandler(this.G2HomeSideBtn_Click);
            // 
            // G2CustSideBtn
            // 
            this.G2CustSideBtn.Animated = true;
            this.G2CustSideBtn.BackColor = System.Drawing.Color.Transparent;
            this.G2CustSideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2CustSideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2CustSideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2CustSideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2CustSideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2CustSideBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2CustSideBtn.ForeColor = System.Drawing.Color.White;
            this.G2CustSideBtn.Location = new System.Drawing.Point(3, 0);
            this.G2CustSideBtn.Name = "G2CustSideBtn";
            this.G2CustSideBtn.Size = new System.Drawing.Size(215, 50);
            this.G2CustSideBtn.TabIndex = 13;
            this.G2CustSideBtn.Text = "Customers";
            this.G2CustSideBtn.UseTransparentBackground = true;
            this.G2CustSideBtn.Click += new System.EventHandler(this.G2CustSideBtn_Click);
            // 
            // G2CourseSideBtn
            // 
            this.G2CourseSideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2CourseSideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2CourseSideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2CourseSideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2CourseSideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2CourseSideBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2CourseSideBtn.ForeColor = System.Drawing.Color.White;
            this.G2CourseSideBtn.Location = new System.Drawing.Point(3, 0);
            this.G2CourseSideBtn.Name = "G2CourseSideBtn";
            this.G2CourseSideBtn.Size = new System.Drawing.Size(215, 50);
            this.G2CourseSideBtn.TabIndex = 13;
            this.G2CourseSideBtn.Text = "Courses";
            this.G2CourseSideBtn.Click += new System.EventHandler(this.G2CourseSideBtn_Click);
            // 
            // G2BookSideBtn
            // 
            this.G2BookSideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BookSideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BookSideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BookSideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BookSideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2BookSideBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2BookSideBtn.ForeColor = System.Drawing.Color.White;
            this.G2BookSideBtn.Location = new System.Drawing.Point(0, 0);
            this.G2BookSideBtn.Name = "G2BookSideBtn";
            this.G2BookSideBtn.Size = new System.Drawing.Size(215, 50);
            this.G2BookSideBtn.TabIndex = 13;
            this.G2BookSideBtn.Text = "Bookings";
            this.G2BookSideBtn.Click += new System.EventHandler(this.G2BookSideBtn_Click);
            // 
            // G2ReportsBtn
            // 
            this.G2ReportsBtn.Animated = true;
            this.G2ReportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.G2ReportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2ReportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2ReportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2ReportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2ReportsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2ReportsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.G2ReportsBtn.Location = new System.Drawing.Point(0, 0);
            this.G2ReportsBtn.Name = "G2ReportsBtn";
            this.G2ReportsBtn.Size = new System.Drawing.Size(215, 50);
            this.G2ReportsBtn.TabIndex = 15;
            this.G2ReportsBtn.Text = "Reports";
            this.G2ReportsBtn.UseTransparentBackground = true;
            this.G2ReportsBtn.Click += new System.EventHandler(this.G2ReportsBtn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.homePanel);
            this.sidebar.Controls.Add(this.customerContainer);
            this.sidebar.Controls.Add(this.coursesContainer);
            this.sidebar.Controls.Add(this.bookingContainer);
            this.sidebar.Controls.Add(this.ReportsContainer);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(215, 500);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 500);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(70, 500);
            this.sidebar.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuSideLbl);
            this.panel1.Controls.Add(this.SidebarPB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 60);
            this.panel1.TabIndex = 9;
            // 
            // MenuSideLbl
            // 
            this.MenuSideLbl.AutoSize = true;
            this.MenuSideLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MenuSideLbl.ForeColor = System.Drawing.Color.White;
            this.MenuSideLbl.Location = new System.Drawing.Point(84, 19);
            this.MenuSideLbl.Name = "MenuSideLbl";
            this.MenuSideLbl.Size = new System.Drawing.Size(45, 19);
            this.MenuSideLbl.TabIndex = 13;
            this.MenuSideLbl.Text = "Menu";
            // 
            // SidebarPB
            // 
            this.SidebarPB.Image = ((System.Drawing.Image)(resources.GetObject("SidebarPB.Image")));
            this.SidebarPB.ImageRotate = 0F;
            this.SidebarPB.Location = new System.Drawing.Point(17, 13);
            this.SidebarPB.Name = "SidebarPB";
            this.SidebarPB.Size = new System.Drawing.Size(39, 32);
            this.SidebarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SidebarPB.TabIndex = 12;
            this.SidebarPB.TabStop = false;
            this.SidebarPB.Click += new System.EventHandler(this.SidebarPB_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.guna2PictureBox10);
            this.homePanel.Controls.Add(this.G2HomeSideBtn);
            this.homePanel.Location = new System.Drawing.Point(3, 69);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(215, 46);
            this.homePanel.TabIndex = 15;
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.Image")));
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(61, 46);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox10.TabIndex = 12;
            this.guna2PictureBox10.TabStop = false;
            // 
            // customerContainer
            // 
            this.customerContainer.Controls.Add(this.guna2PictureBox9);
            this.customerContainer.Controls.Add(this.G2AddCustBtnS);
            this.customerContainer.Controls.Add(this.G2DeleteCustBtnS);
            this.customerContainer.Controls.Add(this.G2CustSideBtn);
            this.customerContainer.Controls.Add(this.G2EditCustBtnS);
            this.customerContainer.Location = new System.Drawing.Point(3, 121);
            this.customerContainer.MaximumSize = new System.Drawing.Size(215, 155);
            this.customerContainer.MinimumSize = new System.Drawing.Size(215, 50);
            this.customerContainer.Name = "customerContainer";
            this.customerContainer.Size = new System.Drawing.Size(215, 50);
            this.customerContainer.TabIndex = 21;
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox9.Image")));
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(68, 52);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox9.TabIndex = 12;
            this.guna2PictureBox9.TabStop = false;
            // 
            // G2AddCustBtnS
            // 
            this.G2AddCustBtnS.Animated = true;
            this.G2AddCustBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2AddCustBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2AddCustBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2AddCustBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2AddCustBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2AddCustBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2AddCustBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2AddCustBtnS.ForeColor = System.Drawing.Color.White;
            this.G2AddCustBtnS.Location = new System.Drawing.Point(0, 50);
            this.G2AddCustBtnS.Name = "G2AddCustBtnS";
            this.G2AddCustBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2AddCustBtnS.TabIndex = 17;
            this.G2AddCustBtnS.Text = "Add Customer";
            this.G2AddCustBtnS.UseTransparentBackground = true;
            this.G2AddCustBtnS.Click += new System.EventHandler(this.G2AddCustBtnS_Click);
            // 
            // G2DeleteCustBtnS
            // 
            this.G2DeleteCustBtnS.Animated = true;
            this.G2DeleteCustBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2DeleteCustBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2DeleteCustBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2DeleteCustBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2DeleteCustBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2DeleteCustBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2DeleteCustBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2DeleteCustBtnS.ForeColor = System.Drawing.Color.White;
            this.G2DeleteCustBtnS.Location = new System.Drawing.Point(0, 120);
            this.G2DeleteCustBtnS.Name = "G2DeleteCustBtnS";
            this.G2DeleteCustBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2DeleteCustBtnS.TabIndex = 18;
            this.G2DeleteCustBtnS.Text = "Delete Customer";
            this.G2DeleteCustBtnS.UseTransparentBackground = true;
            this.G2DeleteCustBtnS.Click += new System.EventHandler(this.G2DeleteCustBtnS_Click);
            // 
            // G2EditCustBtnS
            // 
            this.G2EditCustBtnS.Animated = true;
            this.G2EditCustBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2EditCustBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2EditCustBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2EditCustBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2EditCustBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2EditCustBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2EditCustBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2EditCustBtnS.ForeColor = System.Drawing.Color.White;
            this.G2EditCustBtnS.Location = new System.Drawing.Point(0, 85);
            this.G2EditCustBtnS.Name = "G2EditCustBtnS";
            this.G2EditCustBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2EditCustBtnS.TabIndex = 16;
            this.G2EditCustBtnS.Text = "Edit Customer";
            this.G2EditCustBtnS.UseTransparentBackground = true;
            this.G2EditCustBtnS.Click += new System.EventHandler(this.G2EditCustBtnS_Click);
            // 
            // coursesContainer
            // 
            this.coursesContainer.Controls.Add(this.AddCourseBtnS);
            this.coursesContainer.Controls.Add(this.DeleteCourseBtnS);
            this.coursesContainer.Controls.Add(this.guna2PictureBox7);
            this.coursesContainer.Controls.Add(this.EditCourseBtnS);
            this.coursesContainer.Controls.Add(this.G2CourseSideBtn);
            this.coursesContainer.Location = new System.Drawing.Point(3, 177);
            this.coursesContainer.MaximumSize = new System.Drawing.Size(215, 155);
            this.coursesContainer.MinimumSize = new System.Drawing.Size(215, 50);
            this.coursesContainer.Name = "coursesContainer";
            this.coursesContainer.Size = new System.Drawing.Size(215, 50);
            this.coursesContainer.TabIndex = 14;
            // 
            // AddCourseBtnS
            // 
            this.AddCourseBtnS.Animated = true;
            this.AddCourseBtnS.BackColor = System.Drawing.Color.Transparent;
            this.AddCourseBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCourseBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCourseBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCourseBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCourseBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.AddCourseBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCourseBtnS.ForeColor = System.Drawing.Color.White;
            this.AddCourseBtnS.Location = new System.Drawing.Point(0, 50);
            this.AddCourseBtnS.Name = "AddCourseBtnS";
            this.AddCourseBtnS.Size = new System.Drawing.Size(215, 35);
            this.AddCourseBtnS.TabIndex = 20;
            this.AddCourseBtnS.Text = "Add Course";
            this.AddCourseBtnS.UseTransparentBackground = true;
            this.AddCourseBtnS.Click += new System.EventHandler(this.AddCourseBtnS_Click);
            // 
            // DeleteCourseBtnS
            // 
            this.DeleteCourseBtnS.Animated = true;
            this.DeleteCourseBtnS.BackColor = System.Drawing.Color.Transparent;
            this.DeleteCourseBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCourseBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCourseBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteCourseBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteCourseBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.DeleteCourseBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteCourseBtnS.ForeColor = System.Drawing.Color.White;
            this.DeleteCourseBtnS.Location = new System.Drawing.Point(0, 120);
            this.DeleteCourseBtnS.Name = "DeleteCourseBtnS";
            this.DeleteCourseBtnS.Size = new System.Drawing.Size(215, 35);
            this.DeleteCourseBtnS.TabIndex = 21;
            this.DeleteCourseBtnS.Text = "Delete Course";
            this.DeleteCourseBtnS.UseTransparentBackground = true;
            this.DeleteCourseBtnS.Click += new System.EventHandler(this.DeleteCourseBtnS_Click);
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(-3, 0);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(64, 52);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox7.TabIndex = 12;
            this.guna2PictureBox7.TabStop = false;
            // 
            // EditCourseBtnS
            // 
            this.EditCourseBtnS.Animated = true;
            this.EditCourseBtnS.BackColor = System.Drawing.Color.Transparent;
            this.EditCourseBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditCourseBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditCourseBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditCourseBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditCourseBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.EditCourseBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditCourseBtnS.ForeColor = System.Drawing.Color.White;
            this.EditCourseBtnS.Location = new System.Drawing.Point(0, 85);
            this.EditCourseBtnS.Name = "EditCourseBtnS";
            this.EditCourseBtnS.Size = new System.Drawing.Size(215, 35);
            this.EditCourseBtnS.TabIndex = 19;
            this.EditCourseBtnS.Text = "Edit Course";
            this.EditCourseBtnS.UseTransparentBackground = true;
            this.EditCourseBtnS.Click += new System.EventHandler(this.EditCourseBtnS_Click);
            // 
            // bookingContainer
            // 
            this.bookingContainer.Controls.Add(this.G2AddBookBtnS);
            this.bookingContainer.Controls.Add(this.G2DeleteBookBtnS);
            this.bookingContainer.Controls.Add(this.guna2PictureBox8);
            this.bookingContainer.Controls.Add(this.G2EditBookBtnS);
            this.bookingContainer.Controls.Add(this.G2BookSideBtn);
            this.bookingContainer.Location = new System.Drawing.Point(3, 233);
            this.bookingContainer.MaximumSize = new System.Drawing.Size(215, 155);
            this.bookingContainer.MinimumSize = new System.Drawing.Size(215, 50);
            this.bookingContainer.Name = "bookingContainer";
            this.bookingContainer.Size = new System.Drawing.Size(215, 50);
            this.bookingContainer.TabIndex = 15;
            // 
            // G2AddBookBtnS
            // 
            this.G2AddBookBtnS.Animated = true;
            this.G2AddBookBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2AddBookBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2AddBookBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2AddBookBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2AddBookBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2AddBookBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2AddBookBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2AddBookBtnS.ForeColor = System.Drawing.Color.White;
            this.G2AddBookBtnS.Location = new System.Drawing.Point(0, 50);
            this.G2AddBookBtnS.Name = "G2AddBookBtnS";
            this.G2AddBookBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2AddBookBtnS.TabIndex = 17;
            this.G2AddBookBtnS.Text = "Add Booking";
            this.G2AddBookBtnS.UseTransparentBackground = true;
            this.G2AddBookBtnS.Click += new System.EventHandler(this.G2AddBookBtnS_Click);
            // 
            // G2DeleteBookBtnS
            // 
            this.G2DeleteBookBtnS.Animated = true;
            this.G2DeleteBookBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2DeleteBookBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2DeleteBookBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2DeleteBookBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2DeleteBookBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2DeleteBookBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2DeleteBookBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2DeleteBookBtnS.ForeColor = System.Drawing.Color.White;
            this.G2DeleteBookBtnS.Location = new System.Drawing.Point(0, 120);
            this.G2DeleteBookBtnS.Name = "G2DeleteBookBtnS";
            this.G2DeleteBookBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2DeleteBookBtnS.TabIndex = 18;
            this.G2DeleteBookBtnS.Text = "Delete Booking";
            this.G2DeleteBookBtnS.UseTransparentBackground = true;
            this.G2DeleteBookBtnS.Click += new System.EventHandler(this.G2DeleteBookBtnS_Click);
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox8.Image")));
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(0, -2);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(61, 52);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox8.TabIndex = 12;
            this.guna2PictureBox8.TabStop = false;
            // 
            // G2EditBookBtnS
            // 
            this.G2EditBookBtnS.Animated = true;
            this.G2EditBookBtnS.BackColor = System.Drawing.Color.Transparent;
            this.G2EditBookBtnS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2EditBookBtnS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2EditBookBtnS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2EditBookBtnS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2EditBookBtnS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2EditBookBtnS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2EditBookBtnS.ForeColor = System.Drawing.Color.White;
            this.G2EditBookBtnS.Location = new System.Drawing.Point(0, 85);
            this.G2EditBookBtnS.Name = "G2EditBookBtnS";
            this.G2EditBookBtnS.Size = new System.Drawing.Size(215, 35);
            this.G2EditBookBtnS.TabIndex = 16;
            this.G2EditBookBtnS.Text = "Edit Booking";
            this.G2EditBookBtnS.UseTransparentBackground = true;
            this.G2EditBookBtnS.Click += new System.EventHandler(this.G2EditBookBtnS_Click);
            // 
            // ReportsContainer
            // 
            this.ReportsContainer.Controls.Add(this.guna2PictureBox2);
            this.ReportsContainer.Controls.Add(this.G2UnpaidBtn);
            this.ReportsContainer.Controls.Add(this.G2ReportsBtn);
            this.ReportsContainer.Location = new System.Drawing.Point(3, 289);
            this.ReportsContainer.MaximumSize = new System.Drawing.Size(209, 84);
            this.ReportsContainer.MinimumSize = new System.Drawing.Size(209, 46);
            this.ReportsContainer.Name = "ReportsContainer";
            this.ReportsContainer.Size = new System.Drawing.Size(209, 46);
            this.ReportsContainer.TabIndex = 9;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::_9320RyanMillerDatabase.Properties.Resources.DocIconFinal;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(61, 46);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // G2UnpaidBtn
            // 
            this.G2UnpaidBtn.Animated = true;
            this.G2UnpaidBtn.BackColor = System.Drawing.Color.Transparent;
            this.G2UnpaidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2UnpaidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2UnpaidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2UnpaidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2UnpaidBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.G2UnpaidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.G2UnpaidBtn.ForeColor = System.Drawing.Color.White;
            this.G2UnpaidBtn.Location = new System.Drawing.Point(0, 48);
            this.G2UnpaidBtn.Name = "G2UnpaidBtn";
            this.G2UnpaidBtn.Size = new System.Drawing.Size(215, 35);
            this.G2UnpaidBtn.TabIndex = 14;
            this.G2UnpaidBtn.Text = "Unpaid Orders";
            this.G2UnpaidBtn.UseTransparentBackground = true;
            this.G2UnpaidBtn.Click += new System.EventHandler(this.G2UnpaidBtn_Click);
            // 
            // ReportSideTimer
            // 
            this.ReportSideTimer.Interval = 10;
            this.ReportSideTimer.Tick += new System.EventHandler(this.ReportSideTimer_Tick);
            // 
            // CustSideTimer
            // 
            this.CustSideTimer.Interval = 10;
            this.CustSideTimer.Tick += new System.EventHandler(this.CustSideTimer_Tick);
            // 
            // CourseSideTimer
            // 
            this.CourseSideTimer.Interval = 10;
            this.CourseSideTimer.Tick += new System.EventHandler(this.CourseSideTimer_Tick);
            // 
            // BookSideTimer
            // 
            this.BookSideTimer.Interval = 10;
            this.BookSideTimer.Tick += new System.EventHandler(this.BookSideTimer_Tick);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.EditCustDTP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EFCustSNDBtn);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarPB)).EndInit();
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            this.customerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            this.coursesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            this.bookingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            this.ReportsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
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
        private System.Windows.Forms.Button EFCustSNDBtn;
        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker EditCustDTP;
        private Guna.UI2.WinForms.Guna2Button G2HomeSideBtn;
        private Guna.UI2.WinForms.Guna2Button G2CustSideBtn;
        private Guna.UI2.WinForms.Guna2Button G2CourseSideBtn;
        private Guna.UI2.WinForms.Guna2Button G2BookSideBtn;
        private Guna.UI2.WinForms.Guna2Button G2ReportsBtn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MenuSideLbl;
        private Guna.UI2.WinForms.Guna2PictureBox SidebarPB;
        private System.Windows.Forms.Panel homePanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        private System.Windows.Forms.Panel customerContainer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private Guna.UI2.WinForms.Guna2Button G2AddCustBtnS;
        private Guna.UI2.WinForms.Guna2Button G2DeleteCustBtnS;
        private Guna.UI2.WinForms.Guna2Button G2EditCustBtnS;
        private System.Windows.Forms.Panel coursesContainer;
        private Guna.UI2.WinForms.Guna2Button AddCourseBtnS;
        private Guna.UI2.WinForms.Guna2Button DeleteCourseBtnS;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private Guna.UI2.WinForms.Guna2Button EditCourseBtnS;
        private System.Windows.Forms.Panel bookingContainer;
        private Guna.UI2.WinForms.Guna2Button G2AddBookBtnS;
        private Guna.UI2.WinForms.Guna2Button G2DeleteBookBtnS;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private Guna.UI2.WinForms.Guna2Button G2EditBookBtnS;
        private System.Windows.Forms.Panel ReportsContainer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button G2UnpaidBtn;
        private System.Windows.Forms.Timer ReportSideTimer;
        private System.Windows.Forms.Timer CustSideTimer;
        private System.Windows.Forms.Timer CourseSideTimer;
        private System.Windows.Forms.Timer BookSideTimer;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}