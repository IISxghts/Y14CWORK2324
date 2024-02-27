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
    public partial class UC_CustomerStaf : UserControl
    {
        public UC_CustomerStaf()
        {
            InitializeComponent();
        }

        private void G2BtnDelCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new DeleteCustomerForm().Show();
        }

        private void G2BtnEditCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new EditCustomerForm().Show();
        }

        private void G2BtnAddCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new AddCustomerForm().Show();
        }

        private void LLMenuLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
