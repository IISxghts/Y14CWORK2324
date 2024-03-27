using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;
using System.ComponentModel.Design;


namespace _9320RyanMillerDatabase
{
    public class BookingDAL
    {
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;
        public static bool Check;
        public static DataTable GetLessonsFromBooking(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                

                // opens SQL connection to database
                connection.Open();

                // initialises object command of class SqlCommand, allows us to store SQL command to be executed within it
                SqlCommand command = new SqlCommand();

                // the SQL command that will retrieve th
                string sqlQuery = @"SELECT Courses.CourseID, CourseTitle, StartDate, EndDate, Timing, Price, Capacity, SpacesBooked FROM Courses
                                   LEFT JOIN
                                   (SELECT Count(*) as 'SpacesBooked', Booking.CourseID FROM Booking
                                   GROUP BY Booking.CourseID) as BookingResults
                                   on Courses.CourseID = BookingResults.CourseID
                                   WHERE BookingResults.SpacesBooked IS NULL OR Capacity >= BookingResults.SpacesBooked";

                //sets the command to be executed to be the inputted sqlQuery
                command.CommandText = sqlQuery;
                
                // command.Parameters.AddWithValue("Date", date);
                
                command.Connection = connection;

                // initialises object dt of class DataTable, allows us to bridge connection between the executed SQL and the server, hence casting the SQL stored in variable command
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // initialises object dt of class DataTable, allows us to store and retrieve data from database
                DataTable dt = new DataTable();
                
                // loads the DataGridView with valid retrieved data
                adapter.Fill(dt);

                // closes the SQL connection
                connection.Close();

                // returns result of method
                return dt;
            }
            
        }

        public static int AddBooking(BookingModel booking)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "AddBooking";

                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseID", booking._CourseID));
                insertProjectCommand.Parameters.Add(new SqlParameter("@BookingDate", booking._BookingDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Discount", booking._DiscountYN));
                insertProjectCommand.Parameters.Add(new SqlParameter("@DiscountPercent", booking._DiscountPercent));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerNum", booking._CustomerNum));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerQuantity", booking._CustomerQuantity));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Paid", booking._Paid));

                int rowsAffected = insertProjectCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }

        public static List<int> DoubleBooking(int CourseID, int CustID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                
                List<int> bookIDs = new List<int>();

                connection.Open();

                string sqlQuery = string.Format("SELECT BookingID FROM Booking WHERE CourseID = {0} AND CustomerNum = {1}", CourseID, CustID);

                SqlCommand bookCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader dataReader = bookCommand.ExecuteReader();               


                while (dataReader.Read())
                {
                    int bookID = (int)dataReader["BookingID"];

                    bookIDs.Add(bookID);

                }

                connection.Close();

                return bookIDs;
                    
            }
        }

        public static List<int> CorrectDate(string chosen)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {


                List<int> bookIDs = new List<int>();

                connection.Open();

                string SQLQuery = string.Format("SELECT Courses.EndDate, BookingDate FROM Booking JOIN Courses ON Booking.CourseID = Courses.CourseID WHERE BookingDate = {0} > EndDate", chosen);

                SqlCommand megaCommand = new SqlCommand(SQLQuery, connection);

                SqlDataReader dataReader = megaCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int bookID = (int)dataReader["BookingID"];

                    bookIDs.Add(bookID);

                }

                connection.Close();

                return bookIDs;

            }
        }

        public static DataTable ViewBookings()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT * FROM Booking";

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
