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

        public static DataTable GetLessonsFromBooking()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                string sqlQuery = @"";

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
