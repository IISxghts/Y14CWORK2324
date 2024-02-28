using Guna.UI2.WinForms;
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
        
        DataRowView DFRowSelectCustomer;
        DataRowView DFRowSelectCourse;
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

        private void BookingTablesRefresh()
        {
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
            if (DiscountCheckBox.Checked)
            {
                DiscountBookingLbl.Visible = true;
                DiscountSelectBox.Visible = true;
            }
            else
            {
                DiscountBookingLbl.Visible = false;
                DiscountSelectBox.Visible = false;
            }
        }

        private void G2AddBookingBtn_Click(object sender, EventArgs e)
        {
            if(NullChecker())
            {
                 if (DFRowSelectCourse != null && DFRowSelectCustomer != null)
                 {
                    
                    int CustID = Convert.ToInt32(DFRowSelectCustomer["CustomerNum"]);
                    int CourseID = Convert.ToInt32(DFRowSelectCourse["CourseID"]);
                    DateTime bookDate = DTPBooking.Value; 
                    bool discountYN = false;
                    int discountPercent = Convert.ToInt32(DiscountSelectBox.Value);
                    if (DiscountCheckBox.Checked == true)
                    {
                         discountYN = true;                      
                    }
                    else
                    {
                        discountYN = false;
                    }
                    int customerQuantity = Convert.ToInt32(QuantitySelectBox.Value);

                    BookingModel newBooking = new BookingModel(CourseID, bookDate, discountYN, discountPercent, CustID, customerQuantity);

                    int rowsAffected = BookingDAL.AddBooking(newBooking);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New booking has been reserved", "Success");
                    }
                    else
                    {
                        MessageBox.Show("An error has occured in creating the booking", "Failure");
                    }
                }
                 else
                 {
                     MessageBox.Show("Please select a customer and a course to book", "Error");
                 }

            }
            

        }

        private bool NullChecker()
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(DiscountSelectBox.Text))
            {
                error.AppendLine("You must enter an amount of attendees.");
            }
            if (DiscountCheckBox.Checked && string.IsNullOrEmpty(DiscountSelectBox.ToString()))
            {
                error.AppendLine("You must enter a discount percentage.");
            }
            if (string.IsNullOrEmpty(error.ToString()))
            {
                return true;
            }
            MessageBox.Show(error.ToString(), "Required fields left blank");
            return false;
        }
    
        
        private void DGVCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRowings();
        }
        private void ChooseTheRowings()
        {
            DFRowSelectCustomer = DGVCustomer.CurrentRow != null ? (DataRowView)DGVCustomer.CurrentRow.DataBoundItem : null;
            DFRowSelectCourse = DGVCourse.CurrentRow != null ? (DataRowView)DGVCourse.CurrentRow.DataBoundItem : null;
        }
    }
}
