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
            LLMenuGreetLbl.Text = DateTime.Now.Date.ToString();
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
            UC_Customer customer = new UC_Customer();
            AddUserControls(customer);
        }

        private void G2BtnCourses_Click(object sender, EventArgs e)
        {
            UC_Courses courses = new UC_Courses();
            AddUserControls(courses);
        }

        private void G2BtnBookings_Click(object sender, EventArgs e)
        {
             
            UC_Booking bookings = new UC_Booking();
            AddUserControls(bookings);
        }

        private void G2BtnReports_Click(object sender, EventArgs e)
        {
            UC_Reports reports = new UC_Reports();
            AddUserControls(reports);
        }
        private void G2SettingsBtn_Click(object sender, EventArgs e)
        {

            UC_Other other = new UC_Other();
            AddUserControls(other);
        }
        #endregion
       
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
