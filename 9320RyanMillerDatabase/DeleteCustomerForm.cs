using System;
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
    public partial class DeleteCustomerForm : Form
    {
        DataRowView rowselect;
        public DeleteCustomerForm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        // this part of the code will refresh the table automatically once a change has been made
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
            ViewCourseIDBox.Text = Convert.ToString(rowselect["CustomerNum"]);

            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this customer with ID:" + ViewCourseIDBox.Text, "Confirm Deletion", MessageBoxButton.OKCancel);   

            if (confirmResult == MessageBoxResult.OK)
            {
                int rowingsAffected = CustomerDAL.DeleteDisloyalCustomer(Convert.ToInt32(rowselect["CustomerNum"]));
                if (rowingsAffected > 0)
                {
                    System.Windows.MessageBox.Show("Customer has successfully been deleted", "Completed");
                    CustomerTableRefresh();
                    ViewCourseIDBox.Text = "";
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
                ViewCourseIDBox.Text = "";
            }
        }

        private void CustDeleteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRow();
        }
        private void ChooseTheRow()
        {
            rowselect = CustDeleteDGV.CurrentRow != null ? (DataRowView)CustDeleteDGV.CurrentRow.DataBoundItem : null;
        }


        #region ///MENU STRIP CONTROLS\\\
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void addCustomerTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
        }

        private void editCustomerTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomerForm().Show();
        }
        
        private void addCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCourseForm().Show();
        }

        private void editCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCourse().Show();
        }

        private void deleteCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCourse().Show();
        }
        #endregion
    }
}
