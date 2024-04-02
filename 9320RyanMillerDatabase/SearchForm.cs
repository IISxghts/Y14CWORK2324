
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _9320RyanMillerDatabase
{

    public partial class SearchForm : Form
    {
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;
        public SearchForm()
        {
            InitializeComponent();
            CenterToScreen();
            Init();
        }
        // GOAL: Allow user to select what they want to search by.

        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;


        private void Init()
        {
            SearchLbl.Visible = false;
            CriteriaLbl.Visible = false;
            SearchTxtBox.Visible = false;
            CriteriaSelectBox.Visible = false;
        }

        private void MainMenuTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void TableSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriaSelectBox.Items.Clear();
            CustomerInfoDGV.DataSource = null;
            SearchTxtBox.Text = string.Empty;
            switch (TableSelectBox.SelectedItem)
            {
                case "Customer":
                    CriteriaSelectBox.Items.AddRange(new String[] { "Customer ID", "Customer Forename", "Customer Surname", "Customer Postcode", "Customer Town", "Customer Phone", "Customer DOB" });
                    DataModel.ViewOption = "C";
                    break;
                case "Bookings":
                    CriteriaSelectBox.Items.AddRange(new String[] { "Booking ID", "Booking Date", "Customer ID" });
                    DataModel.ViewOption = "B";
                    break;
                case "Courses":
                    CriteriaSelectBox.Items.AddRange(new String[] { "Course ID", "Course Title", "Capacity", "Course Manager Name" });
                    DataModel.ViewOption = "A";
                    break;
            }

            CriteriaSelectBox.Visible = true;
            CriteriaLbl.Visible = true;
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlC = new SqlConnection(_connectionString);

            if (DataModel.ViewOption == "C")
            {                
                if (CriteriaSelectBox.Text == "Customer ID")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerNum LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer Forename")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerForename LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer Surname")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerSurname LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }

                else if (CriteriaSelectBox.Text == "Customer Postcode")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerPostcode LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer Town")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerTown LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer Phone")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerPhone LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer DOB")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerDOB LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }

            }
            else if (DataModel.ViewOption == "B")
            {
                if (CriteriaSelectBox.Text == "Booking ID")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Booking WHERE BookingID LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Booking Date")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Booking WHERE BookingDate LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Customer ID")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Booking WHERE CustomerNum LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
            }
            else if (DataModel.ViewOption == "A")
            {
                if (CriteriaSelectBox.Text == "Course ID")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Courses WHERE CoufseID LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Course Title")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Courses WHERE CourseTitle LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }            
                else if (CriteriaSelectBox.Text == "Capacity")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Courses WHERE Capacity LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
                else if (CriteriaSelectBox.Text == "Course Manager Name")
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Courses WHERE CManagerName LIKE '" + SearchTxtBox.Text + "%'", sqlC);
                    DataTable dataT = new DataTable();
                    sqlDA.Fill(dataT);
                    CustomerInfoDGV.DataSource = dataT;
                }
            }
            else
            {
                MessageBox.Show("Error searching for criteria", "Error");
            }

            // you can do some sql here that can show the details for a specific course
        }

        private void CriteriaSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataModel.ViewOption == "C")
            {
                CustomerInfoDGV.DataSource = CustomerDAL.ViewCustomer(); 
            }
            else if (DataModel.ViewOption == "B")
            {
                CustomerInfoDGV.DataSource = BookingDAL.ViewBookings();
            }
            else if (DataModel.ViewOption == "A")
            {
                CustomerInfoDGV.DataSource = CourseDAL.ViewCourses();
            }
           
            SearchLbl.Visible = true;
            SearchTxtBox.Visible = true;
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
    }
}
