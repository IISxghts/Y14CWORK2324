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

        public static DataTable ViewBook(int BookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT Customer.CustomerNum, Customer.CustomerForename, Customer.CustomerSurname, Customer.CustomerPhone, Customer.CustomerPostcode, Booking.BookingID, Booking.BookingDate
                                    FROM Customer
                                          INNER JOIN Booking ON Customer.CustomerNum = Booking.CustomerNum
                                              WHERE Booking.BookingID = @BookingID;";

                command.CommandText = sqlQuery;
                command.Connection = connection;
                command.Parameters.AddWithValue("@BookingID", BookingID); 

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();

                return dt;
            }

        }

        public static DataTable ViewCourse(int courseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {


                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT CUSTOMER.CustomerForename, CUSTOMER.CustomerSurname, CUSTOMER.CustomerAddress, CUSTOMER.CustomerTown, CUSTOMER.CustomerPostcode, CUSTOMER.CustomerPhone, CUSTOMER.CustomerDOB FROM CUSTOMER
                                    INNER JOIN Booking ON Customer.CustomerNum = Booking.CustomerNum
                                    INNER JOIN Courses ON Booking.CourseID = Courses.CourseID
                                    WHERE Courses.CourseID = @CourseID";

                command.CommandText = sqlQuery;
                command.Connection = connection;
                command.Parameters.AddWithValue("@CourseID", courseID); 

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();

                return dt;
            }
        }

        public static DataTable ViewCustomer(int customerNum)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT Customer.CustomerNum, Customer.CustomerForename, Customer.CustomerSurname, Customer.CustomerPhone, Courses.CourseID, Courses.CourseTitle, Booking.BookingID, Booking.BookingDate
                                     FROM Booking
                                     INNER JOIN Customer ON Booking.CustomerNum = Customer.CustomerNum
                                     INNER JOIN Courses ON Booking.CourseID = Courses.CourseID
                                     WHERE Customer.CustomerNum = @CustomerNum;";

                command.CommandText = sqlQuery;
                command.Connection = connection;
                command.Parameters.AddWithValue("@CustomerNum", customerNum); 

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();

                return dt;
            }

        }

    }
}
