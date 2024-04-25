using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase.UserControlsMMStaff
{
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void G2BtnAddCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new AddCustomerForm().Show();
        }

        private void G2BtnEditCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new EditCustomerForm().Show();
        }

        private void G2BtnDelCust_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new DeleteCustomerForm().Show();
        }

        private void G2ViewCustBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new ViewDataForm().Show();
        }
    }
}
