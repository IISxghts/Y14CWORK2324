namespace _9320RyanMillerDatabase
{
    partial class CustomerReportOne
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lakeside9320CustDataSet = new _9320RyanMillerDatabase.Lakeside9320CustDataSet();
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customerTableAdapter = new _9320RyanMillerDatabase.Lakeside9320CustDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustDataSet)).BeginInit();
            this.SuspendLayout();
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
            // ReportViewer1
            // 
            reportDataSource1.Name = "Report1Dataset";
            reportDataSource1.Value = this.customerBindingSource;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "_9320RyanMillerDatabase.CustomerListReport.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(12, 26);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.ServerReport.BearerToken = null;
            this.ReportViewer1.Size = new System.Drawing.Size(776, 412);
            this.ReportViewer1.TabIndex = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerReportOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportViewer1);
            this.Name = "CustomerReportOne";
            this.Text = "CustomerReportOne";
            this.Load += new System.EventHandler(this.CustomerReportOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakeside9320CustDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        private Lakeside9320CustDataSet lakeside9320CustDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lakeside9320CustDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}