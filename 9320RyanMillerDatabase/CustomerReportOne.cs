using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class CustomerReportOne : Form
    {
        public CustomerReportOne()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CustomerReportOne_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustDataSet.Customer);

            this.ReportViewer1.RefreshReport();
        }
    }
}
