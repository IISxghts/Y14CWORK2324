using Microsoft.CodeAnalysis.CSharp.Syntax;
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

namespace _9320RyanMillerDatabase
{
    public partial class DeleteBookingForm : Form
    {
        public DeleteBookingForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataRowView DFRowSelectBooking;

        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        bool sidebarOtherExpand;
        
        private void RowChoose()
        {
            DFRowSelectBooking = BookDeleteDGV.CurrentRow != null ? (DataRowView)BookDeleteDGV.CurrentRow.DataBoundItem : null;
            
            ViewBookingIDBox.Text = Convert.ToString(DFRowSelectBooking["BookingID"]);
        }
        private void DeleteBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320DeleteBookingDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.lakeside9320DeleteBookingDataSet.Booking);
        }

        private void BookDeleteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowChoose();
        }

        private void BookingTableRefresh()
        {
            this.bookingTableAdapter.Fill(this.lakeside9320DeleteBookingDataSet.Booking);
        }
        private void DelBookingBtn_Click(object sender, EventArgs e)
        {

            object paidCellValue = BookDeleteDGV.CurrentRow.Cells[7].Value;


            if (paidCellValue != null && Convert.ToBoolean(paidCellValue) == false)
            {
                System.Windows.MessageBox.Show("This booking is unpaid. Please make sure it is paid before deletion.", "Unpaid Booking");
                return; 
            }

            ViewBookingIDBox.Text = Convert.ToString(DFRowSelectBooking["BookingID"]);
            string cusNum = Convert.ToString(DFRowSelectBooking["CustomerNum"]);

            if (DFRowSelectBooking != null)
            {
                MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure you want to delete this booking with ID: " + ViewBookingIDBox.Text + " belonging to customer with ID: " + cusNum, "Confirm Deletion", MessageBoxButton.OKCancel);

                if (confirmResult == MessageBoxResult.OK)
                {
                    int rowsAffected = BookingDAL.DeleteBookingOfDisloyalCustomer(Convert.ToInt32(DFRowSelectBooking["BookingID"]));

                    if (rowsAffected > 0)
                    {
                        System.Windows.MessageBox.Show("Booking has successfully been deleted", "Completed");
                        BookingTableRefresh();
                        ViewBookingIDBox.Text = "";
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("An error has occurred", "Error");
                        BookingTableRefresh();
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Deletion cancelled.");
                    BookingTableRefresh();
                    ViewBookingIDBox.Text = "";
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a booking to delete", "Error");
            }

        }

        #region sidebar controls
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

        private void G2ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportSideTimer.Start();
        }

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
        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void AddCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCourseForm().Show();
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

        private void G2AddCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
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

        private void G2EditBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditBookingForm().Show();
        }

        private void G2AddBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingForm().Show();
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
