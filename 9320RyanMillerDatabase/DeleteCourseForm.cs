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
using Tmds.DBus.Protocol;

namespace _9320RyanMillerDatabase
{
    public partial class DeleteCourseForm : Form
    {
        public DeleteCourseForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataRowView rowselect;
        
        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        bool sidebarOtherExpand;





        #region sidebar controls
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
        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
            Hide() ;
            new DeleteBookingForm().Show();
        }

        private void G2UnpaidBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerReportOne().Show();
        }
        #endregion

        private void DelCourseBtn_Click(object sender, EventArgs e)
        {

            int CourseIDChosen = Convert.ToInt32(rowselect["CourseID"]);
            string courseNameChosen = Convert.ToString(rowselect["CourseTitle"]);

            if (rowselect != null)
            {
                if (CourseDAL.CustomerBookCheck(CourseIDChosen).Count == 0)
                {
                    MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure you want to delete this course with ID: " + ViewCourseIDBox.Text + " with the name: " + courseNameChosen, "Confirm Deletion", MessageBoxButton.OKCancel);

                    if (confirmResult == MessageBoxResult.OK)
                    {
                        int rowsAffected = CourseDAL.DeleteCourse(CourseIDChosen);

                        if (rowsAffected > 0)
                        {
                            System.Windows.MessageBox.Show("Booking has successfully been deleted", "Completed");
                            CourseTableRefresh();
                            ViewCourseIDBox.Text = "";
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("An error has occurred", "Error");
                            CourseTableRefresh();
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Deletion cancelled.");
                        CourseTableRefresh();
                        ViewCourseIDBox.Text = "";
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Customers are already booked to this course and therefore it cannot be deleted", "Deletion Cancelled");
                    CourseTableRefresh();
                    ViewCourseIDBox.Text = "";
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a course before continuing", "Error");
            }
        }

        private void DeleteCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320ActualDeleteCoursesDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.lakeside9320ActualDeleteCoursesDataSet.Courses);

        }

        private void CourseTableRefresh()
        {
            coursesTableAdapter.Fill(lakeside9320ActualDeleteCoursesDataSet.Courses);
        }

        private void CourseDeleteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowChoose();
        }

        private void RowChoose()
        {
            rowselect = CourseDeleteDGV.CurrentRow != null ? (DataRowView)CourseDeleteDGV.CurrentRow.DataBoundItem : null;

            ViewCourseIDBox.Text = Convert.ToString(rowselect["CourseID"]);
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
    }
}
