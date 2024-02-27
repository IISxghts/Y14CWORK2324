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
    public partial class UC_BookingsStaff : UserControl
    {
        public UC_BookingsStaff()
        {
            InitializeComponent();
        }

        private void G2BtnNewBook_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new BookingForm().Show();
        }
    }
}
