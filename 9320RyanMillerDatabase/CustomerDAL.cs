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
    public class CustomerDAL
    {
        public static string _connectionString = ConfigurationManager.ConnectionStrings["LakesideConnection"].ConnectionString;


        public static int AddCustomer(CustomerModel customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "AddCustomer";

                // Prevents data not of the correct format being entered therefore stopping malicious

                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerForename", customer._fname));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerSurname", customer._sname));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerAddress", customer._address));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerPostcode", customer._pcode));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerTown", customer._town));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerPhone", customer._phone));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerDOB", customer._dob));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerSpecialReqs", customer._specialreqs));

                int rowsAffected = insertProjectCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }
        public static int DeleteDisloyalCustomer(int CustomerNum)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("DELETE FROM Customer WHERE CustomerNum = '{0}'", CustomerNum);

                SqlCommand custDelCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = custDelCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }

        }
        public static int EditLoyalCustomer(CustomerModel customer)

        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertProjectCommand.CommandText = "EditCustomer";

                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerNum", customer._id));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerForename", customer._fname));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerSurname", customer._sname));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerAddress", customer._address));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerPostcode", customer._pcode));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerTown", customer._town));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerPhone", customer._phone));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerDOB", customer._dob));
                insertProjectCommand.Parameters.Add(new SqlParameter("@CustomerSpecialReqs", customer._specialreqs));

                int rowsAffected = insertProjectCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;

            }
        }

        public static DataTable ViewCustomer()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"SELECT * FROM Customer";

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
