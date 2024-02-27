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


        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            

            // you can do some sql here that can show the details for a specific course
        }
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
            switch (TableSelectBox.SelectedItem)
            {                
                case "Customer":
                    CriteriaSelectBox.Items.AddRange(new String[] { "Customer Number", "Customer Forename", "Customer Surname", "Customer Postcode", "Customer Town", "Customer Phone", "Customer DOB" });
                    break;
                case "Bookings":
                    CriteriaSelectBox.Items.AddRange(new String[] { "Booking ID", "Booking Date", "Customer ID" });
                    break;
                case "Activity":
                    CriteriaSelectBox.Items.AddRange(new String[] {"Course ID", "Course Title", "Start Date", "End Date", "Timing", "Price", "Capacity", "Manager Name" });
                    break;
            }

            CriteriaSelectBox.Visible = true;
            CriteriaLbl.Visible = true;
        }
    }
}
