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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
            CenterToScreen();
            CourseSNDBtn.Visible = false;
        }

        DataRowView DFRowSelect;
        
        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;
        bool sidebarOtherExpand;
        private void EditCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320ActualCourseEditDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.lakeside9320ActualCourseEditDataSet.Courses);

        }

        private void CourseTableRefresh()
        {
            this.coursesTableAdapter.Fill(this.lakeside9320ActualCourseEditDataSet.Courses);
        }

        private void EditCourseBtn_Click(object sender, EventArgs e)
        {
           
            if (DFRowSelect != null)
            {
                int IDThatSelected = Convert.ToInt32(DFRowSelect["CourseID"]);
                EFCourseIDTB.Text = Convert.ToString(IDThatSelected);
                EFCourseTitleTB.Text = Convert.ToString(DFRowSelect["CourseTitle"]);
                EFCourseStartDateTB.Text = Convert.ToString(DFRowSelect["StartDate"]);
                EFEndDateTB.Text = Convert.ToString(DFRowSelect["EndDate"]);
                EFCourseTimeTB.Text = Convert.ToString(DFRowSelect["Timing"]);
                int CapacityThatSelected = Convert.ToInt32(DFRowSelect["Capacity"]);
                EFCourseCapTB.Text = Convert.ToString(CapacityThatSelected);
                decimal PriceThatSelected = Convert.ToDecimal(DFRowSelect["Price"]);
                EFCoursePriceTB.Text = Convert.ToString(PriceThatSelected);
                EFStaffIDTB.Text = Convert.ToString(DFRowSelect["StaffID"]);

                CourseSNDBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a course to edit", "Error");
            }

        }

        private void CourseSNDBtn_Click(object sender, EventArgs e)
        {
            string courseidhold = EFCourseIDTB.Text;
            int courseID = Convert.ToInt32(courseidhold);
            string title = EFCourseTitleTB.Text;
            string startdate = EFCourseStartDateTB.Text;
            string enddate = EFEndDateTB.Text;
            string time = EFCourseTimeTB.Text;
            string priceHold = EFCoursePriceTB.Text;
            decimal price = Convert.ToDecimal(priceHold);
            string capacityHold = EFCourseCapTB.Text;
            int capacity = Convert.ToInt32(capacityHold);
            
            string staffIDHold = EFStaffIDTB.Text;
            int staffID = Convert.ToInt32(staffIDHold);

            if (CourseDAL.StaffIDValid(staffID).Count != 0)
            {
                CourseModel existingCourse = new CourseModel(courseID, title, startdate, enddate, price, time, capacity, staffID);

                int rowsAffected = CourseDAL.EditLoyalCustomer(existingCourse);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course has been edited successfully", "Success");
                    CourseTableRefresh();

                }
                else
                {
                    MessageBox.Show("An error has occured in editing the course", "Failure");
                    CourseTableRefresh();
                }
            }
            else
            {
                MessageBox.Show("This is not a valid Staff ID.", "Error");
            }


        }
        private void EFCourseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRowings();
        }
        private void ChooseTheRowings()
        {
            DFRowSelect = EFCourseDGV.CurrentRow != null ? (DataRowView)EFCourseDGV.CurrentRow.DataBoundItem : null;
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

        private void G2OtherSideBtn_Click(object sender, EventArgs e)
        {
            OtherSideTimer.Start();
        }

        #endregion


    }
}
