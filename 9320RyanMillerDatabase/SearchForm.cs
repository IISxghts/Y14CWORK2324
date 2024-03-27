
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
    }
}
