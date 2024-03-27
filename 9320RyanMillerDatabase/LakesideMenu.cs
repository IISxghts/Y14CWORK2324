using _9320RyanMillerDatabase.UserControls;
using _9320RyanMillerDatabase.UserControlsMMStaff;
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
    public partial class LakesideMenu : Form
    {
        public LakesideMenu()
        {
            InitializeComponent();
            CenterToScreen();
            LLMenuGreetLbl.Text = "Welcome, " + DataModel.DisplayUname + "!";
        }
         

        private void AddUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #region//Buttons\\

        private void G2BtnCustomer_Click(object sender, EventArgs e)
        {
            UC_CustomerStaff customer = new UC_CustomerStaff();
            AddUserControls(customer);
        }

        private void G2BtnCourses_Click(object sender, EventArgs e)
        {
            UC_CoursesStaff courses = new UC_CoursesStaff();
            AddUserControls(courses);
        }

        private void G2BtnBookings_Click(object sender, EventArgs e)
        {
             
            UC_BookingsStaff bookings = new UC_BookingsStaff();
            AddUserControls(bookings);
        }

        private void G2BtnReports_Click(object sender, EventArgs e)
        {
            UC_ReportsStaff reports = new UC_ReportsStaff();
            AddUserControls(reports);
        }
        private void G2SettingsBtn_Click(object sender, EventArgs e)
        {
            UC_Settings settings = new UC_Settings();
            AddUserControls(settings);
        }
        #endregion
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            
            CenterToScreen();
            
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButton.OKCancel);

            // if the user selects ok, exit the system
           
            if (confirmResult == MessageBoxResult.OK)
            {
                Environment.Exit(0); 
            }
            else
            {
                System.Windows.MessageBox.Show("Exit cancelled", "Notification");
            }

        }


    }
}
