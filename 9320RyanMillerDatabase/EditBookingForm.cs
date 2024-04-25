using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _9320RyanMillerDatabase
{
    public partial class EditBookingForm : Form
    {
        public EditBookingForm()
        {
            InitializeComponent();
            CenterToScreen();
            BookingSNDBtn.Visible = false;
        }

        DataRowView rowselect;
        
        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        bool sidebarOtherExpand;



        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320BookingEditDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.lakeside9320BookingEditDataSet.Booking);

        }

        private void EditBookingBtn_Click(object sender, EventArgs e)
        {
            

           if(rowselect != null)
            {
                BookingSNDBtn.Visible = true;

                int BookIDThatSelected = Convert.ToInt32(rowselect["BookingID"]);
                EFBookIDTB.Text = Convert.ToString(BookIDThatSelected);
                int CustIDThatSelected = Convert.ToInt32(rowselect["CustomerNum"]);
                EFBookCustNumTB.Text = Convert.ToString(CustIDThatSelected);
                int CourseIDThatSelected = Convert.ToInt32(rowselect["CourseID"]);
                EFBookCourseIDTB.Text = Convert.ToString(CourseIDThatSelected);
                EFBookDiscountTB.Text = Convert.ToString(rowselect["Discount"]);
                DateTime bookDateSelected = Convert.ToDateTime(rowselect["BookingDate"]);
                EFBookDateTB.Text = Convert.ToString(bookDateSelected);
                decimal DiscountPercentHodl = Convert.ToDecimal(rowselect["DiscountPercent"]);
                EFBookPercentTB.Text = Convert.ToString(DiscountPercentHodl);
                int CustQuantityHold = Convert.ToInt32(rowselect["CustomerQuantity"]);
                EFBookQuantityTB.Text = Convert.ToString(CustQuantityHold); 

                DataGridViewRow selectedRow = EFBookDGV.SelectedRows[0];

                bool isPaid = (bool)selectedRow.Cells[7].Value;

                G2BookPaidCB.Checked = isPaid;

             //   int courseId = (int)selectedRow.Cells[1].Value;
             //   EFBookCourseIDTB.Text = courseId.ToString();
            }
            else
            {
                MessageBox.Show("Please select a booking to edit", "Error");
            }
            
        }

        private void BookingSNDBtn_Click(object sender, EventArgs e)
        {
            string bookIDHold = EFBookIDTB.Text;
            int bookID = Convert.ToInt32(bookIDHold);
            string courseIDHold = EFBookCourseIDTB.Text;
            int courseID = Convert.ToInt32(courseIDHold);
            string custNumHold = EFBookCustNumTB.Text;
            int custNum = Convert.ToInt32(custNumHold);
            string discount = EFBookDiscountTB.Text;
            string bookDate = EFBookDateTB.Text;
            string dPercentHold = EFBookPercentTB.Text;
            decimal dPercent = Convert.ToDecimal(dPercentHold);
            string custQuantityHold = EFBookQuantityTB.Text;
            int custQuantity = Convert.ToInt32(custQuantityHold);

            int paidYN;

            if (G2BookPaidCB.Checked == true)
            {
                paidYN = 1;
            }
            else
            {
                paidYN = 0;
            }


            BookingModel existingBooking = new BookingModel(bookID, courseID, bookDate, discount, dPercent, custNum, custQuantity, paidYN);

            int rowsAffected = BookingDAL.EditBooking(existingBooking);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Course has been edited successfully", "Success");
                BookTableRefresh();

            }
            else
            {
                MessageBox.Show("An error has occured in editing the course", "Failure");
                BookTableRefresh();
            }

        }

        private void ChooseRowings()
        {
            rowselect = EFBookDGV.CurrentRow != null ? (DataRowView)EFBookDGV.CurrentRow.DataBoundItem : null;
        }

        private void EFBookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseRowings();
        }

        private void BookTableRefresh()
        {
            this.bookingTableAdapter.Fill(this.lakeside9320BookingEditDataSet.Booking);
        }
       
        #region sidebar controls
        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
                
        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void G2CustSideBtn_Click(object sender, EventArgs e)
        {
            CustSideTimer.Start();
        }

        private void G2CourseSideBtn_Click(object sender, EventArgs e)
        {
            CourseSideTimer.Start();
        }

        private void G2BookSideBtn_Click(object sender, EventArgs e)
        {
            BookSideTimer.Start();
        }

        private void G2ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportSideTimer.Start();
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
        
        private void G2CustListBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerReportTwo().Show();
        }
        
        private void G2OtherSideBtn_Click(object sender, EventArgs e)
        {
            OtherSideTimer.Start();
        }

        private void ViewDataBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewDataForm().Show();
        }

        private void SearchDataBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchForm().Show();
        }

        private void OtherSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarOtherExpand)
            {
                otherContainer.Height += 10;
                if (otherContainer.Height == otherContainer.MaximumSize.Height)
                {
                    sidebarOtherExpand = false;
                    OtherSideTimer.Stop();
                }
            }
            else
            {
                otherContainer.Height -= 10;
                if (otherContainer.Height == otherContainer.MinimumSize.Height)
                {
                    sidebarOtherExpand = true;
                    OtherSideTimer.Stop();
                }
            }
        }

        #endregion
    }
}
