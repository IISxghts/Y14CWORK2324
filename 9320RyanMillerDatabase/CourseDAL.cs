using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _9320RyanMillerDatabase
{
    public class CourseDAL
    {
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;

        public static int AddCourse(CourseModel course)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "AddCourse";

                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseTitle", course._Coursename));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StartDate", course._StartDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@EndDate", course._EndDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Timing", course._Timing));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Price", course._Price));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Capacity", course._Capacity));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StaffID", course._staffID));

                int rowsAffected = insertProjectCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }
        public static int DeleteCourse(int CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("DELETE FROM Courses WHERE CourseID = '{0}'", CourseID);

                SqlCommand custDelCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = custDelCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }

        }
        public static int EditLoyalCustomer(CourseModel course)

        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "EditCourse";


                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseID", course._Courseid));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseTitle", course._Coursename));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StartDate", course._StartDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@EndDate", course._EndDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Timing", course._Timing));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Price", course._Price));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Capacity", course._Capacity));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StaffID", course.StaffID));

                int rowsAffected = insertProjectCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;

            }
        }

        public static DataTable ViewCourses()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT * FROM Courses";

                command.CommandText = sqlQuery;
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();

                return dt;
            }
        }

        public static List<int> StaffIDValid(int StaffID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<int> staffIDs = new List<int>();

                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffID = {0}", StaffID);

                SqlCommand bookCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader dataReader = bookCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    int staffID = (int)dataReader["StaffID"];

                    staffIDs.Add(staffID);

                }

                connection.Close();

                return staffIDs;
            }
        }

        public static List<int> CustomerBookCheck(int CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<int> courseIDs = new List<int>();

                connection.Open();

                string sqlQuery = string.Format("SELECT DISTINCT CustomerNum FROM Booking WHERE CourseID = {0}", CourseID);

                SqlCommand bookCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader dataReader = bookCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    int courseID = (int)dataReader["CustomerNum"];

                    courseIDs.Add(courseID);

                }

                connection.Close();

                return courseIDs;
            }
        }
    }
}
    
