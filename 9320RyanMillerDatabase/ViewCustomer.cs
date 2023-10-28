﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustDataSet.Customer);

        }

        private void CustomerTableRefresh()
        {
            customerTableAdapter.Fill(lakeside9320CustDataSet.Customer);
        }

        private void DeleteCustBtn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this customer with ID:" + ViewCustIDBox.Text, "Confirm Deletion", MessageBoxButton.OKCancel);

            // if the user selects ok, invoke the method which will 

            if (confirmResult == MessageBoxResult.OK)
            {
                int rowingsAffected = CustomerDAL.DeleteDisloyalCustomer(Convert.ToInt32(ViewCustIDBox.Text));
                if (rowingsAffected > 0)
                {
                    System.Windows.MessageBox.Show("Customer has successfully been deleted", "Completed");
                    CustomerTableRefresh();
                    ViewCustIDBox.Text = "";
                }
                else
                {
                    System.Windows.MessageBox.Show("An error has occured", "Error");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Deletion cancelled.");
                CustomerTableRefresh();
                ViewCustIDBox.Text = "";
            }
        }
    }
}
