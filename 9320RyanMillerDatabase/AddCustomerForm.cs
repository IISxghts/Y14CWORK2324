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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            CenterToScreen();
            custReqRTB.Visible = false;
            custPSLbl.Visible = false;
            DateTime today = DateTime.Now.Date;
            custDTP.Value = today; 
        }
       
        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        
        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            if (NullChecker()) //if all fields are filled, move on
            {
                string forename = custFnameBox.Text;
                string surname = custSnameBox.Text;
                string address = custAddressBox.Text;
                string postcode = custPostcodeBox.Text;
                string town = custTownBox.Text;
                string phone = custPhoneBox.Text;
                string bdate = custDTP.Text;
                string specialreqs = custReqRTB.Text;

                CustomerModel newcustomer = new CustomerModel(forename, surname, address, postcode, town, phone, bdate, specialreqs);

                int rowsAffected = CustomerDAL.AddCustomer(newcustomer);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New customer has been successfully added", "Success");
                }
                else
                {
                    MessageBox.Show("An error has occured in adding the customer", "Failure");
                }



            }
        }
        private void specialReqCB_CheckedChanged(object sender, EventArgs e)
        {
            if (specialReqCB.Checked == true)
            {
                custPSLbl.Visible = true;
                custReqRTB.Visible = true;
                custReqRTB.Text = "";
            }
            else if (specialReqCB.Checked == false)
            {
                custPSLbl.Visible = false;
                custReqRTB.Visible = false;
                custReqRTB.Text = "N/A";
            }
        }
        private bool NullChecker()
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(custFnameBox.Text))
            {
                error.AppendLine("You must enter a first name.");
            }
            if (string.IsNullOrEmpty(custSnameBox.Text))
            {
                error.AppendLine("You must enter a  surname.");
            }
            if (string.IsNullOrEmpty(custPostcodeBox.Text))
            {
                error.AppendLine("You must enter a postcode.");
            }
            if (string.IsNullOrEmpty(custAddressBox.Text))
            {
                error.AppendLine("You must enter an address.");
            }
            if (string.IsNullOrEmpty(custDTP.Text))
            {
                error.AppendLine("You must enter a date of birth.");
            }
            if (string.IsNullOrEmpty(custTownBox.Text))
            {
                error.AppendLine("You must enter a town.");
            }
            if (string.IsNullOrEmpty(custPhoneBox.Text))
            {
                error.AppendLine("You must enter a phone number.");
            }
            if (string.IsNullOrEmpty(custDTP.Text))
            {
                error.AppendLine("You must enter a date of birth.");
            }
            if(string.IsNullOrEmpty(error.ToString()))
            {
                return true;
            }
            MessageBox.Show(error.ToString(), "Required fields left blank");
            return false;
        }

        #region sidebar 

        #endregion

        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
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

        
    }
}