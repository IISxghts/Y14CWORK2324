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

        public static int AddCourse(CourseModel customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "AddCourse";

                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseTitle", customer._Coursename));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StartDate", customer._StartDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@EndDate", customer._EndDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Timing", customer._Timing));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Price", customer._Price));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Capacity", customer._Capacity));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CManagerName", customer._Managername));

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

                insertProjectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "EditCourse";


                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseID", course._Courseid));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CourseTitle", course._Coursename));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StartDate", course._StartDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@EndDate", course._EndDate));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Timing", course._Timing));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Price", course._Price));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Capacity", course._Capacity));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CManagerName", course._Managername));

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
    }
}
    
