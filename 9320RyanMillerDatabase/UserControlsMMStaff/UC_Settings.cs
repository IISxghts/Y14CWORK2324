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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void G2BtnLogout_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();

            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButton.OKCancel);

            // if the user selects ok, exit the system

            if (confirmResult == MessageBoxResult.OK)
            {
                Hide();
                new LoginScreen().Show();
            }
            else
            {
                ((LakesideMenu)this.TopLevelControl).Show();

                System.Windows.MessageBox.Show("Logout cancelled", "Notification");
            }
        }

        public void SystemBrightness()
        {
            if (BrightCB.Text == "Dark")
            {
                
            }
            else if (BrightCB.Text == "Light")
            {
                
            }
          
        }
    }
}
