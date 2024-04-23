using Guna.UI2.WinForms;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _9320RyanMillerDatabase
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            CenterToScreen();
            DiscountSelectBox.Visible = false;
            Discount();
            DateTime dt = DateTime.Now;
            DTPBooking.Value = dt;
        }


        DataRowView DFRowSelectCustomer;
        DataRowView DFRowSelectCourse;

        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;

        private void TempBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustomerSelectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustomerSelectDataSet.Customer);

        }

        private void RefreshForm()
        {
            this.customerTableAdapter.Fill(this.lakeside9320CustomerSelectDataSet.Customer);
        }


        private void G2CheckAvailabilityBtn_Click(object sender, EventArgs e)
        {
            DateTime dtPicked = DTPBooking.Value.Date;

            if (dtPicked >= DateTime.Now.Date)
            {
                DGVCourse.DataSource = BookingDAL.GetLessonsFromBooking(dtPicked);
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
                DiscountBookingLbl.Visible = true;
            }
            else if (DiscountCheckBox.Checked == false)
            {
                DiscountSelectBox.Visible = false;
                DiscountBookingLbl.Visible = false;
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

                    DateTime chosenDate = DTPBooking.Value.Date;

                    if (BookingDAL.DoubleBooking(CourseID, CustID).Count != 0)
                    {
                        MessageBox.Show("This customer has already been booked for this course", "Double booking");
                    }
                  /*  else if (BookingDAL.CorrectDate(chosenDate).Count != 0)
                    {
                        MessageBox.Show("Course does not run on this date, try again", "Error");
                    } */
                    else
                    {
             
                        string discountYN = "N/A";
                        decimal discountPercent = DiscountSelectBox.Value;
                        int paidYN;
                        if (DiscountCheckBox.Checked == true)
                        {
                            discountYN = "Yes";
                        }
                        else
                        {
                            discountYN = "No";
                        }
                        if (PaidCB.Checked == true)
                        {
                            paidYN = 1;
                        }
                        else
                        {
                            paidYN = 0;
                        }
                        int customerQuantity = (int)QuantitySelectBox.Value;

                        BookingModel newBooking = new BookingModel(CourseID, chosenDate, discountYN, discountPercent, CustID, customerQuantity, paidYN);

                        int rowsAffected = BookingDAL.AddBooking(newBooking);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New booking has been reserved", "Success");
                            RefreshForm();

                        }
                        else
                        {
                            MessageBox.Show("An error has occured in creating the booking", "Failure");
                             RefreshForm();
                        }
                    }
                    
                    }
                    else
                    {
                        MessageBox.Show("Please select a customer and a course to book", "Error");
                    }
                          

            }
            else
            {
                MessageBox.Show("Required fields left blank", "Error");
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

        private void DiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Discount();
        }



        #region sidebar
        private void G2BookSideBtn_Click(object sender, EventArgs e)
        {
            BookSideTimer.Start();
        }

        private void G2CourseSideBtn_Click(object sender, EventArgs e)
        {
            CourseSideTimer.Start();
        }

        private void G2CustSideBtn_Click(object sender, EventArgs e)
        {
            CustSideTimer.Start();
        }

        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }
        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }        
        private void G2ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportSideTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void ReportSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarReportsExpand)
            {
                ReportsContainer.Height += 10;
                if (ReportsContainer.Height == ReportsContainer.MaximumSize.Height)
                {
                    sidebarReportsExpand = false;
                    ReportSideTimer.Stop();
                }
            }
            else
            {
                ReportsContainer.Height -= 10;
                if (ReportsContainer.Height == ReportsContainer.MinimumSize.Height)
                {
                    sidebarReportsExpand = true;
                    ReportSideTimer.Stop();
                }
            }
        }

        private void CustSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarCustExpand)
            {
                customerContainer.Height += 10;
                if (customerContainer.Height == customerContainer.MaximumSize.Height)
                {
                    sidebarCustExpand = false;
                    CustSideTimer.Stop();
                }
            }
            else
            {
                customerContainer.Height -= 10;
                if (customerContainer.Height == customerContainer.MinimumSize.Height)
                {
                    sidebarCustExpand = true;
                    CustSideTimer.Stop();
                }
            }
        }

        private void CourseSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarCourseExpand)
            {
                coursesContainer.Height += 10;
                if (coursesContainer.Height == coursesContainer.MaximumSize.Height)
                {
                    sidebarCourseExpand = false;
                    CourseSideTimer.Stop();
                }
            }
            else
            {
                coursesContainer.Height -= 10;
                if (coursesContainer.Height == coursesContainer.MinimumSize.Height)
                {
                    sidebarCourseExpand = true;
                    CourseSideTimer.Stop();
                }
            }
        }

        private void BookSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarBookExpand)
            {
                bookingContainer.Height += 10;
                if (bookingContainer.Height == bookingContainer.MaximumSize.Height)
                {
                    sidebarBookExpand = false;
                    BookSideTimer.Stop();
                }
            }
            else
            {
                bookingContainer.Height -= 10;
                if (bookingContainer.Height == bookingContainer.MinimumSize.Height)
                {
                    sidebarBookExpand = true;
                    BookSideTimer.Stop();
                }
            }
        }

        private void G2AddCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
        }

        private void G2EditCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomerForm().Show();
        }

        private void G2DeleteCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomerForm().Show();
        }

        private void AddCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCourseForm().Show();
        }

        private void EditCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCourseForm().Show();    
        }

        private void DeleteCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCourseForm().Show();
        }

        private void G2AddBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingForm().Show();
        }

        private void G2EditBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditBookingForm().Show();
        }

        private void G2DeleteBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteBookingForm().Show();
        }

        private void G2UnpaidBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerReportOne().Show();
        }


        #endregion
    }
}
