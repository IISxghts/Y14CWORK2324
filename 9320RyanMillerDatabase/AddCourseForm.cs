using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
            CenterToScreen();
            DateTime today = DateTime.Now;
            StartDateDTP.Value = today;
            EndDateDTP.Value = today;
        }

        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        bool sidebarOtherExpand;

        private void G2AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (NullChecker())
            {

                string CourseName = CourseNameBox.Text;
                string StartHour = StartHourDTP.Text;
                string StartDate = StartDateDTP.Value.Date.ToShortDateString();
                string EndDate = EndDateDTP.Value.Date.ToShortDateString();
                string holdprice = CoursePriceBox.Text;
                decimal price = Convert.ToDecimal(holdprice);
                string holdcapacity = CourseCapacityBox.Text;
                int capacity = Convert.ToInt32(holdcapacity);
                string staffIDHold = CourseStaffIDTB.Text;
                int staffID = Convert.ToInt32(staffIDHold);

                if (CourseDAL.StaffIDValid(staffID).Count != 0)
                {                
                    
                    CourseModel newcourse = new CourseModel(CourseName, StartDate, EndDate, StartHour, price, capacity, staffID);

                    int rowsThatDothBeAffected = CourseDAL.AddCourse(newcourse);

                    if (rowsThatDothBeAffected > 0)
                    {
                        MessageBox.Show("Course has been successfully added", "Success");
                    }
                    else
                    {
                    MessageBox.Show("An error has occured in adding the course", "Failure");
                    }

                }
                else
                {
                    MessageBox.Show("Staff ID not valid", "Error");
                }


            }
        }

        private bool NullChecker()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(CourseNameBox.Text))
            {               
              sb.AppendLine("You must enter a course name.");
            }
            if (string.IsNullOrEmpty(StartHourDTP.Text))
            {
                sb.AppendLine("You must enter a starting time.");
            }
            if (string.IsNullOrEmpty(StartDateDTP.Text))
            {
                sb.AppendLine("You must enter a starting date.");
            }
            if (string.IsNullOrEmpty(EndDateDTP.Text))
            {
                sb.AppendLine("You must enter a end date.");
            }
            if (string.IsNullOrEmpty(CoursePriceBox.Text))
            {
                sb.AppendLine("You must enter a price.");
            }
            if (string.IsNullOrEmpty(CourseCapacityBox.Text))
            {
                sb.AppendLine("You must enter a capacity.");
            }
            if (string.IsNullOrEmpty(CourseStaffIDTB.Text))
            {
                sb.AppendLine("You must enter a staff ID.");
            }
            if (string.IsNullOrEmpty(sb.ToString()))
            {
                return true;
            }
            MessageBox.Show(sb.ToString(), "Required fields left blank");
            return false;
        }

        private void MMBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
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


        private void G2ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportSideTimer.Start();
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



        private void G2DeleteCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomerForm().Show();
        }

        private void G2EditCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomerForm().Show();
        }

        private void G2AddCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
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

        private void G2CustListBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerReportTwo().Show();
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
