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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            CenterToScreen();
            Discount();
        }

        private void MainMenuTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void TempBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustomerSelectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustomerSelectDataSet.Customer);

        }

        private void G2CheckAvailabilityBtn_Click(object sender, EventArgs e)
        {
            if(DTPBooking.Value.Date >= DateTime.Now.Date)
            {
                DGVCourse.DataSource = BookingDAL.GetLessonsFromBooking(DTPBooking.Value.Date);
            }
            else
            {
                MessageBox.Show("Please select a date from the future", "Error");
            }
        }

        private void Discount()
        {
            if (DiscountCheckBox.Checked == true)
            {
                DiscountSelectBox.Visible = true;
            }
            else
            {

            }
        }

        private void G2AddBookingBtn_Click(object sender, EventArgs e)
        {

        }

    /*    private bool NullChecker()
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(custFnameBox.Text))
            {
                error.AppendLine("You must enter a first name.");
            }
            if (string.IsNullOrEmpty(error.ToString()))
            {
                return true;
            }
            MessageBox.Show(error.ToString(), "Required fields left blank");
            return false;
        } */
    }
}
