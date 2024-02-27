using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class ViewBookingsForm : Form
    {
        public ViewBookingsForm()
        {
            InitializeComponent();
            CenterToScreen();

        }
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;

        public static DataTable GetLessonsFromBooking(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT Courses.CourseID, CourseTitle, StartDate, EndDate, Timing, Price, Capacity, SpacesBooked FROM Courses
                                   LEFT JOIN
                                   (SELECT Count(*) as 'SpacesBooked', Booking.CourseID FROM Booking
                                   WHERE BookingDate = @Date GROUP BY Booking.CourseID) as BookingResults
                                   on Courses.CourseID = BookingResults.CourseID
                                   WHERE BookingResults.SpacesBooked IS NULL OR Capacity > BookingResults.SpacesBooked";

                command.CommandText = sqlQuery;
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();

                return dt;
            }

        }
    }
}
