namespace _9320RyanMillerDatabase
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.LLMenuLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.G2CheckAvailabilityBtn = new Guna.UI2.WinForms.Guna2Button();
            this.G2AddBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPBookLbl = new System.Windows.Forms.Label();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
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
            this.lakeside9320CustomerSelectDataSet = new _9320RyanMillerDatabase.Lakeside9320CustomerSelectDataSet();
            this.DGVCourse = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.DTPBooking = new System.Windows.Forms.DateTimePicker();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CustomerSelectDataSetTableAdapters.CustomerTableAdapter();
            this.DiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountSelectBox = new System.Windows.Forms.NumericUpDown();
            this.DiscountBookingLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantitySelectBox = new System.Windows.Forms.NumericUpDown();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustomerSelectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySelectBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LLMenuLbl
            // 
            this.LLMenuLbl.AutoSize = true;
            this.LLMenuLbl.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLMenuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.LLMenuLbl.Location = new System.Drawing.Point(162, 9);
            this.LLMenuLbl.Name = "LLMenuLbl";
            this.LLMenuLbl.Size = new System.Drawing.Size(452, 38);
            this.LLMenuLbl.TabIndex = 1;
            this.LLMenuLbl.Text = "LAKESIDE ESCAPES - BOOKINGS";
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
            this.panel3.TabIndex = 5;
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
            // G2CheckAvailabilityBtn
            // 
            this.G2CheckAvailabilityBtn.AutoRoundedCorners = true;
            this.G2CheckAvailabilityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2CheckAvailabilityBtn.BorderRadius = 21;
            this.G2CheckAvailabilityBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2CheckAvailabilityBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2CheckAvailabilityBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2CheckAvailabilityBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2CheckAvailabilityBtn.FillColor = System.Drawing.Color.Empty;
            this.G2CheckAvailabilityBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.G2CheckAvailabilityBtn.ForeColor = System.Drawing.Color.White;
            this.G2CheckAvailabilityBtn.Location = new System.Drawing.Point(566, 221);
            this.G2CheckAvailabilityBtn.Name = "G2CheckAvailabilityBtn";
            this.G2CheckAvailabilityBtn.Size = new System.Drawing.Size(232, 45);
            this.G2CheckAvailabilityBtn.TabIndex = 27;
            this.G2CheckAvailabilityBtn.Text = "Check Availability";
            this.G2CheckAvailabilityBtn.Click += new System.EventHandler(this.G2CheckAvailabilityBtn_Click);
            // 
            // G2AddBookingBtn
            // 
            this.G2AddBookingBtn.AutoRoundedCorners = true;
            this.G2AddBookingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.G2AddBookingBtn.BorderRadius = 21;
            this.G2AddBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2AddBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2AddBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2AddBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2AddBookingBtn.FillColor = System.Drawing.Color.Empty;
            this.G2AddBookingBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.G2AddBookingBtn.ForeColor = System.Drawing.Color.White;
            this.G2AddBookingBtn.Location = new System.Drawing.Point(570, 398);
            this.G2AddBookingBtn.Name = "G2AddBookingBtn";
            this.G2AddBookingBtn.Size = new System.Drawing.Size(226, 45);
            this.G2AddBookingBtn.TabIndex = 26;
            this.G2AddBookingBtn.Text = "Confirm Booking";
            this.G2AddBookingBtn.Click += new System.EventHandler(this.G2AddBookingBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(11, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Select a customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.label4.Location = new System.Drawing.Point(566, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Check course space";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(570, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add New Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select a course to book";
            // 
            // DTPBookLbl
            // 
            this.DTPBookLbl.AutoSize = true;
            this.DTPBookLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPBookLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.DTPBookLbl.Location = new System.Drawing.Point(578, 92);
            this.DTPBookLbl.Name = "DTPBookLbl";
            this.DTPBookLbl.Size = new System.Drawing.Size(108, 21);
            this.DTPBookLbl.TabIndex = 21;
            this.DTPBookLbl.Text = "Pick a Date";
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AutoGenerateColumns = false;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumDataGridViewTextBoxColumn,
            this.customerForenameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerPostcodeDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTownDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerSpecialReqsDataGridViewTextBoxColumn});
            this.DGVCustomer.DataSource = this.customerBindingSource;
            this.DGVCustomer.Location = new System.Drawing.Point(15, 116);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.RowTemplate.Height = 24;
            this.DGVCustomer.Size = new System.Drawing.Size(535, 150);
            this.DGVCustomer.TabIndex = 19;
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
            this.customerBindingSource.DataSource = this.lakeside9320CustomerSelectDataSet;
            // 
            // lakeside9320CustomerSelectDataSet
            // 
            this.lakeside9320CustomerSelectDataSet.DataSetName = "Lakeside9320CustomerSelectDataSet";
            this.lakeside9320CustomerSelectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVCourse
            // 
            this.DGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCourse.Location = new System.Drawing.Point(12, 293);
            this.DGVCourse.Name = "DGVCourse";
            this.DGVCourse.RowHeadersWidth = 51;
            this.DGVCourse.RowTemplate.Height = 24;
            this.DGVCourse.Size = new System.Drawing.Size(535, 150);
            this.DGVCourse.TabIndex = 18;
            this.DGVCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCourse_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuTSM
            // 
            this.MainMenuTSM.Name = "MainMenuTSM";
            this.MainMenuTSM.Size = new System.Drawing.Size(97, 24);
            this.MainMenuTSM.Text = "Main Menu";
            this.MainMenuTSM.Click += new System.EventHandler(this.MainMenuTSM_Click);
            // 
            // DTPBooking
            // 
            this.DTPBooking.Location = new System.Drawing.Point(582, 116);
            this.DTPBooking.Name = "DTPBooking";
            this.DTPBooking.Size = new System.Drawing.Size(200, 22);
            this.DTPBooking.TabIndex = 29;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // DiscountCheckBox
            // 
            this.DiscountCheckBox.AutoSize = true;
            this.DiscountCheckBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.DiscountCheckBox.Location = new System.Drawing.Point(263, 449);
            this.DiscountCheckBox.Name = "DiscountCheckBox";
            this.DiscountCheckBox.Size = new System.Drawing.Size(104, 25);
            this.DiscountCheckBox.TabIndex = 30;
            this.DiscountCheckBox.Text = "Discount";
            this.DiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountSelectBox
            // 
            this.DiscountSelectBox.Location = new System.Drawing.Point(422, 477);
            this.DiscountSelectBox.Name = "DiscountSelectBox";
            this.DiscountSelectBox.Size = new System.Drawing.Size(120, 22);
            this.DiscountSelectBox.TabIndex = 31;
            // 
            // DiscountBookingLbl
            // 
            this.DiscountBookingLbl.AutoSize = true;
            this.DiscountBookingLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBookingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.DiscountBookingLbl.Location = new System.Drawing.Point(264, 478);
            this.DiscountBookingLbl.Name = "DiscountBookingLbl";
            this.DiscountBookingLbl.Size = new System.Drawing.Size(152, 21);
            this.DiscountBookingLbl.TabIndex = 32;
            this.DiscountBookingLbl.Text = "Discount Percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(9)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Amount of attendees?";
            // 
            // QuantitySelectBox
            // 
            this.QuantitySelectBox.Location = new System.Drawing.Point(16, 478);
            this.QuantitySelectBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.QuantitySelectBox.Name = "QuantitySelectBox";
            this.QuantitySelectBox.Size = new System.Drawing.Size(120, 22);
            this.QuantitySelectBox.TabIndex = 34;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.QuantitySelectBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscountBookingLbl);
            this.Controls.Add(this.DiscountSelectBox);
            this.Controls.Add(this.DiscountCheckBox);
            this.Controls.Add(this.DTPBooking);
            this.Controls.Add(this.G2CheckAvailabilityBtn);
            this.Controls.Add(this.G2AddBookingBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPBookLbl);
            this.Controls.Add(this.DGVCustomer);
            this.Controls.Add(this.DGVCourse);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingForm";
            this.Text = "TempBookingForm";
            this.Load += new System.EventHandler(this.TempBookingForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustomerSelectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantitySelectBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLMenuLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button G2CheckAvailabilityBtn;
        private Guna.UI2.WinForms.Guna2Button G2AddBookingBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DTPBookLbl;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.DataGridView DGVCourse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTSM;
        private System.Windows.Forms.DateTimePicker DTPBooking;
        private Lakeside9320CustomerSelectDataSet lakeside9320CustomerSelectDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lakeside9320CustomerSelectDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSpecialReqsDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox DiscountCheckBox;
        private System.Windows.Forms.NumericUpDown DiscountSelectBox;
        private System.Windows.Forms.Label DiscountBookingLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QuantitySelectBox;
    }
}