using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase.UserControlsMMStaff
{
    public partial class UC_Other : UserControl
    {
        public UC_Other()
        {
            InitializeComponent();
        }

        private void G2BtnViewData_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new ViewDataForm().Show();
        }

        private void G2LogoutBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new LoginScreen().Show();
        }

        private void G2SearchFormBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new SearchForm().Show();
        }
    }
}
