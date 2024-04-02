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
    public partial class DeleteCustomerForm : Form
    {
        DataRowView rowselect;
        public DeleteCustomerForm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;

        // this part of the code will refresh the table automatically once a change has been made
        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustDataSet.Customer);
        }

        private void CustomerTableRefresh()
        {
            customerTableAdapter.Fill(lakeside9320CustDataSet.Customer);
        }

        private void DeleteCustBtn_Click(object sender, EventArgs e)
        {
            ViewCourseIDBox.Text = Convert.ToString(rowselect["CustomerNum"]);

            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this customer with ID:" + ViewCourseIDBox.Text, "Confirm Deletion", MessageBoxButton.OKCancel);

            if (confirmResult == MessageBoxResult.OK)
            {
                int rowingsAffected = CustomerDAL.DeleteDisloyalCustomer(Convert.ToInt32(rowselect["CustomerNum"]));
                if (rowingsAffected > 0)
                {
                    System.Windows.MessageBox.Show("Customer has successfully been deleted", "Completed");
                    CustomerTableRefresh();
                    ViewCourseIDBox.Text = "";
                }
                else
                {
                    System.Windows.MessageBox.Show("An error has occured", "Error");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Deletion cancelled.");
                CustomerTableRefresh();
                ViewCourseIDBox.Text = "";
            }
        }

        private void CustDeleteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRow();
        }
        private void ChooseTheRow()
        {
            rowselect = CustDeleteDGV.CurrentRow != null ? (DataRowView)CustDeleteDGV.CurrentRow.DataBoundItem : null;
        }


        #region ///sidebar\\\

        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
        #endregion
    }
}
