using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase.UserControls
{
    public partial class UC_Reports : UserControl
    {
        public UC_Reports()
        {
            InitializeComponent();
        }

        private void G2BtnReportOne_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new CustomerReportOne().Show();
        }

        private void G2UnpaidOrdersBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new CustomerReportTwo().Show();
        }
        private void G2SearchBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new SearchForm().Show();
        }
    }
}
