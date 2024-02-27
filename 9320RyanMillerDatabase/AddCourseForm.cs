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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void G2AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (NullChecker())
            {

                string CourseName = CourseNameBox.Text;
                string StartHour = StartHourDTP.Text;
                string StartDate = StartDateDTP.Text;
                string EndDate = EndDateDTP.Text;
                string holdprice = CoursePriceBox.Text;
                decimal price = Convert.ToDecimal(holdprice);
                string holdcapacity = CourseCapacityBox.Text;
                int capacity = Convert.ToInt32(holdcapacity);
                string CourseManagerName = CManagerNameBox.Text;

                CourseModel newcourse = new CourseModel(CourseName, StartDate, EndDate, StartHour, price, capacity, CourseManagerName);

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
            if (string.IsNullOrEmpty(CManagerNameBox.Text))
            {
                sb.AppendLine("You must enter a course manager name.");
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

        
    }
}
