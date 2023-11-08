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
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CEDataSetTableAdapters.CustomerTableAdapter();
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
            this.EFCMainMenuBtn = new System.Windows.Forms.Button();
            this.EFCustSpecReqLbl = new System.Windows.Forms.Label();
            this.EFCustSpecialReqTB = new System.Windows.Forms.TextBox();
            this.EFCustEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EFCustDOBTB = new System.Windows.Forms.TextBox();
            this.EFCustSNDBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EFCustDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CEDataSet)).BeginInit();
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
            this.EFCustDGV.Location = new System.Drawing.Point(212, 8);
            this.EFCustDGV.Name = "EFCustDGV";
            this.EFCustDGV.RowHeadersWidth = 51;
            this.EFCustDGV.RowTemplate.Height = 24;
            this.EFCustDGV.Size = new System.Drawing.Size(576, 258);
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // EFCustIDTB
            // 
            this.EFCustIDTB.Location = new System.Drawing.Point(76, 269);
            this.EFCustIDTB.Name = "EFCustIDTB";
            this.EFCustIDTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustIDTB.TabIndex = 1;
            // 
            // EFCustIDLbl
            // 
            this.EFCustIDLbl.AutoSize = true;
            this.EFCustIDLbl.Location = new System.Drawing.Point(-1, 275);
            this.EFCustIDLbl.Name = "EFCustIDLbl";
            this.EFCustIDLbl.Size = new System.Drawing.Size(77, 16);
            this.EFCustIDLbl.TabIndex = 2;
            this.EFCustIDLbl.Text = "CustomerID";
            // 
            // EFCustForenameLbl
            // 
            this.EFCustForenameLbl.AutoSize = true;
            this.EFCustForenameLbl.Location = new System.Drawing.Point(7, 324);
            this.EFCustForenameLbl.Name = "EFCustForenameLbl";
            this.EFCustForenameLbl.Size = new System.Drawing.Size(69, 16);
            this.EFCustForenameLbl.TabIndex = 4;
            this.EFCustForenameLbl.Text = "Forename";
            // 
            // EFCustForenameTB
            // 
            this.EFCustForenameTB.Location = new System.Drawing.Point(76, 324);
            this.EFCustForenameTB.Name = "EFCustForenameTB";
            this.EFCustForenameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustForenameTB.TabIndex = 3;
            // 
            // EFCustAddressLbl
            // 
            this.EFCustAddressLbl.AutoSize = true;
            this.EFCustAddressLbl.Location = new System.Drawing.Point(7, 422);
            this.EFCustAddressLbl.Name = "EFCustAddressLbl";
            this.EFCustAddressLbl.Size = new System.Drawing.Size(58, 16);
            this.EFCustAddressLbl.TabIndex = 8;
            this.EFCustAddressLbl.Text = "Address";
            // 
            // EFCustAddressTB
            // 
            this.EFCustAddressTB.Location = new System.Drawing.Point(76, 419);
            this.EFCustAddressTB.Name = "EFCustAddressTB";
            this.EFCustAddressTB.Size = new System.Drawing.Size(128, 22);
            this.EFCustAddressTB.TabIndex = 7;
            // 
            // EFCustSurnameLbl
            // 
            this.EFCustSurnameLbl.AutoSize = true;
            this.EFCustSurnameLbl.Location = new System.Drawing.Point(7, 374);
            this.EFCustSurnameLbl.Name = "EFCustSurnameLbl";
            this.EFCustSurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.EFCustSurnameLbl.TabIndex = 6;
            this.EFCustSurnameLbl.Text = "Surname";
            // 
            // EFCustSurnameTB
            // 
            this.EFCustSurnameTB.Location = new System.Drawing.Point(76, 375);
            this.EFCustSurnameTB.Name = "EFCustSurnameTB";
            this.EFCustSurnameTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustSurnameTB.TabIndex = 5;
            // 
            // EFCustPhoneLbl
            // 
            this.EFCustPhoneLbl.AutoSize = true;
            this.EFCustPhoneLbl.Location = new System.Drawing.Point(215, 422);
            this.EFCustPhoneLbl.Name = "EFCustPhoneLbl";
            this.EFCustPhoneLbl.Size = new System.Drawing.Size(97, 16);
            this.EFCustPhoneLbl.TabIndex = 14;
            this.EFCustPhoneLbl.Text = "Phone Number";
            // 
            // EFCustPhoneTB
            // 
            this.EFCustPhoneTB.Location = new System.Drawing.Point(318, 419);
            this.EFCustPhoneTB.Name = "EFCustPhoneTB";
            this.EFCustPhoneTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustPhoneTB.TabIndex = 13;
            // 
            // EFCustPostcodeLbl
            // 
            this.EFCustPostcodeLbl.AutoSize = true;
            this.EFCustPostcodeLbl.Location = new System.Drawing.Point(233, 330);
            this.EFCustPostcodeLbl.Name = "EFCustPostcodeLbl";
            this.EFCustPostcodeLbl.Size = new System.Drawing.Size(65, 16);
            this.EFCustPostcodeLbl.TabIndex = 12;
            this.EFCustPostcodeLbl.Text = "Postcode";
            // 
            // EFCustPostcodeTB
            // 
            this.EFCustPostcodeTB.Location = new System.Drawing.Point(318, 324);
            this.EFCustPostcodeTB.Name = "EFCustPostcodeTB";
            this.EFCustPostcodeTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustPostcodeTB.TabIndex = 11;
            // 
            // EFCustTownLbl
            // 
            this.EFCustTownLbl.AutoSize = true;
            this.EFCustTownLbl.Location = new System.Drawing.Point(233, 275);
            this.EFCustTownLbl.Name = "EFCustTownLbl";
            this.EFCustTownLbl.Size = new System.Drawing.Size(40, 16);
            this.EFCustTownLbl.TabIndex = 10;
            this.EFCustTownLbl.Text = "Town";
            // 
            // EFCustTownTB
            // 
            this.EFCustTownTB.Location = new System.Drawing.Point(318, 275);
            this.EFCustTownTB.Name = "EFCustTownTB";
            this.EFCustTownTB.Size = new System.Drawing.Size(98, 22);
            this.EFCustTownTB.TabIndex = 9;
            // 
            // EFCMainMenuBtn
            // 
            this.EFCMainMenuBtn.Location = new System.Drawing.Point(10, 8);
            this.EFCMainMenuBtn.Name = "EFCMainMenuBtn";
            this.EFCMainMenuBtn.Size = new System.Drawing.Size(108, 41);
            this.EFCMainMenuBtn.TabIndex = 15;
            this.EFCMainMenuBtn.Text = "Main Menu";
            this.EFCMainMenuBtn.UseVisualStyleBackColor = true;
            this.EFCMainMenuBtn.Click += new System.EventHandler(this.EFCMainMenuBtn_Click);
            // 
            // EFCustSpecReqLbl
            // 
            this.EFCustSpecReqLbl.AutoSize = true;
            this.EFCustSpecReqLbl.Location = new System.Drawing.Point(453, 275);
            this.EFCustSpecReqLbl.Name = "EFCustSpecReqLbl";
            this.EFCustSpecReqLbl.Size = new System.Drawing.Size(140, 16);
            this.EFCustSpecReqLbl.TabIndex = 17;
            this.EFCustSpecReqLbl.Text = "Special Requirements";
            // 
            // EFCustSpecialReqTB
            // 
            this.EFCustSpecialReqTB.Location = new System.Drawing.Point(456, 294);
            this.EFCustSpecialReqTB.Multiline = true;
            this.EFCustSpecialReqTB.Name = "EFCustSpecialReqTB";
            this.EFCustSpecialReqTB.Size = new System.Drawing.Size(332, 144);
            this.EFCustSpecialReqTB.TabIndex = 16;
            // 
            // EFCustEditBtn
            // 
            this.EFCustEditBtn.Location = new System.Drawing.Point(45, 142);
            this.EFCustEditBtn.Name = "EFCustEditBtn";
            this.EFCustEditBtn.Size = new System.Drawing.Size(108, 41);
            this.EFCustEditBtn.TabIndex = 18;
            this.EFCustEditBtn.Text = "Edit";
            this.EFCustEditBtn.UseVisualStyleBackColor = true;
            this.EFCustEditBtn.Click += new System.EventHandler(this.EFCustEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date of Birth";
            // 
            // EFCustDOBTB
            // 
            this.EFCustDOBTB.Location = new System.Drawing.Point(318, 374);
            this.EFCustDOBTB.Name = "EFCustDOBTB";
            this.EFCustDOBTB.Size = new System.Drawing.Size(106, 22);
            this.EFCustDOBTB.TabIndex = 19;
            // 
            // EFCustSNDBtn
            // 
            this.EFCustSNDBtn.Location = new System.Drawing.Point(45, 189);
            this.EFCustSNDBtn.Name = "EFCustSNDBtn";
            this.EFCustSNDBtn.Size = new System.Drawing.Size(108, 42);
            this.EFCustSNDBtn.TabIndex = 21;
            this.EFCustSNDBtn.Text = "Save New Details";
            this.EFCustSNDBtn.UseVisualStyleBackColor = true;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EFCustSNDBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EFCustDOBTB);
            this.Controls.Add(this.EFCustEditBtn);
            this.Controls.Add(this.EFCustSpecReqLbl);
            this.Controls.Add(this.EFCustSpecialReqTB);
            this.Controls.Add(this.EFCMainMenuBtn);
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
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFCustDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CEDataSet)).EndInit();
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
        private System.Windows.Forms.Button EFCMainMenuBtn;
        private System.Windows.Forms.Label EFCustSpecReqLbl;
        private System.Windows.Forms.TextBox EFCustSpecialReqTB;
        private System.Windows.Forms.Button EFCustEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EFCustDOBTB;
        private System.Windows.Forms.Button EFCustSNDBtn;
    }
}