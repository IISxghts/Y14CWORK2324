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
    public partial class UC_Booking : UserControl
    {
        public UC_Booking()
        {
            InitializeComponent();
        }

        private void G2BtnNewBook_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new BookingForm().Show();
        }

        private void G2BtnEditBook_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new EditBookingForm().Show();
        }

        private void G2BtnDeleteBook_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new DeleteBookingForm().Show();
        }

        private void G2ViewBookBtn_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new ViewDataForm().Show();
        }
    }
}
