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
    public partial class DatabaseMenu : Form
    {
        public DatabaseMenu()
        {
            CenterToScreen();
            InitializeComponent();
        }
        
        #region MAIN MENU BUTTONS
        private void DBMenuBtn1_Click(object sender, EventArgs e)
        {
            // ADD CUSTOMER
            new AddCustomerForm().Show();
            Hide();
             
        }

        private void DBMenuBtn2_Click(object sender, EventArgs e)
        {
            // EDIT CUSTOMER
            Hide();
            new EditCustomerForm().Show();
            
        }
        private void DBMenuBtn3_Click(object sender, EventArgs e)
        {
            // DELETE CUSTOMER
            Hide();
            new DeleteCustomerForm().Show();
        }
        private void MMExitBtn_Click(object sender, EventArgs e)
        {
            // closes the system
            Environment.Exit(0);
        }
        #endregion


    }
}
