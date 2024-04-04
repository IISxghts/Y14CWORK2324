using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _9320RyanMillerDatabase
{
    public class ViewDAL
    {
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;

        public static DataTable ViewThingy(string choice)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
               
                
                connection.Open();

                SqlCommand command = new SqlCommand();

                    string sqlQuery = @"SELECT BookingID, Booking.CustomerNum, Courses.CourseID, CustomerForename, CustomerSurname, CourseTitle, Price, StartDate, EndDate FROM Booking
                                    JOIN Courses on Courses.CourseID = Booking.CourseID JOIN Customer on Customer.CustomerNum = Booking.CustomerNum";

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
