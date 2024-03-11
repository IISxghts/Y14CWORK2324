using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
        {
            CenterToScreen();
            InitializeComponent();
        }

        DataRowView DFRowSelect;

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CEDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CEDataSet.Customer);

        }

        private void CustomerTableRefresh()
        {
            customerTableAdapter.Fill(lakeside9320CEDataSet.Customer);
        }

        // ROW SELECTION CODE

        private void EFCustDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRowings();
        }

        private void ChooseTheRowings()
        {
            DFRowSelect = EFCustDGV.CurrentRow != null ? (DataRowView)EFCustDGV.CurrentRow.DataBoundItem : null;
        }

        
        // Code that sends the details of the selected customer into the text boxes, allowing them to be edited.
        private void EFCustEditBtn_Click(object sender, EventArgs e)
        {
            if (DFRowSelect != null)
            {
                int IDThatSelected = Convert.ToInt32(DFRowSelect["CustomerNum"]);
                EFCustIDTB.Text = Convert.ToString(IDThatSelected);
                EFCustForenameTB.Text = Convert.ToString(DFRowSelect["CustomerForename"]);
                EFCustSurnameTB.Text = Convert.ToString(DFRowSelect["CustomerSurname"]);
                EFCustPostcodeTB.Text = Convert.ToString(DFRowSelect["CustomerPostcode"]);
                EFCustAddressTB.Text = Convert.ToString(DFRowSelect["CustomerAddress"]);
                EFCustTownTB.Text = Convert.ToString(DFRowSelect["CustomerTown"]);
                EditCustDTP.Value = Convert.ToDateTime(DFRowSelect["CustomerDOB"]);
                EFCustPhoneTB.Text = Convert.ToString(DFRowSelect["CustomerPhone"]);
                EFCustSpecialReqTB.Text = Convert.ToString(DFRowSelect["CustomerSpecialReqs"]);
            }
        }

        
        // Code that will allow us to make changes 
        private void EFCustSNDBtn_Click(object sender, EventArgs e)
        {
            string custidhold = EFCustIDTB.Text;
            int customerid = Convert.ToInt32(custidhold);
            string forename = EFCustForenameTB.Text;
            string surname = EFCustSurnameTB.Text;
            string address = EFCustAddressTB.Text;
            string postcode = EFCustPostcodeTB.Text;
            string town = EFCustTownTB.Text;
            string phone = EFCustPhoneTB.Text;
            DateTime bdate = EditCustDTP.Value;
            string specialreqs = EFCustSpecialReqTB.Text;                        

            CustomerModel existingcustomers = new CustomerModel(customerid, forename, surname, address, postcode, town, phone, bdate, specialreqs);

            int rowsAffected = CustomerDAL.EditLoyalCustomer(existingcustomers);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer has been edited successfully", "Success");
                CustomerTableRefresh();
                
            }
            else
            {
                MessageBox.Show("An error has occured in editing the customer", "Failure");
                CustomerTableRefresh();
            }
        }

        #region///MENU STRIP\\\
        private void mainMenuTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void addCustomerTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
        }

        private void deleteCustomerTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomerForm().Show();
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

        private void bookingFormTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingForm().Show();   
        }
        #endregion
    }
}   
