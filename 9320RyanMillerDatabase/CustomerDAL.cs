﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
        public static int EditLoyalCustomer(int CustomerNum, string CustomerForename, string CustomerSurname, string CustomerAddress, string CustomerPostcode, string CustomerTown, string CustomerPhone, string CustomerDOB, string CustomerSpecialReqs)

        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Customer SET CustomerForename = '{0}', CustomerSurname = '{1}', CustomerAddress = '{2}', CustomerPostcode = '{3}', CustomerTown = '{4}', CustomerPhone = '{5}', CustomerDOB = '{6}', CustomerSpecialReqs = '{7}' WHERE CustomerNum = {8}", CustomerForename, CustomerSurname, CustomerAddress, CustomerPostcode, CustomerTown, CustomerPhone, CustomerDOB, CustomerSpecialReqs);
                SqlCommand CustomerEditSQLCmd = new SqlCommand(sqlQuery, connection);
                int effectedRows = CustomerEditSQLCmd.ExecuteNonQuery();
                connection.Close();
                return effectedRows;

            }
        }
    }
}
