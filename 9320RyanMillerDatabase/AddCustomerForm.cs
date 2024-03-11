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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            CenterToScreen();
            custReqRTB.Visible = false;
            custPSLbl.Visible = false;
        }

        private void custAddBtn_Click(object sender, EventArgs e)
        {
            if (NullChecker()) //if all fields are filled, move on
            {
                string forename = custFnameBox.Text;
                string surname = custSnameBox.Text;
                string address = custAddressBox.Text;
                string postcode = custPostcodeBox.Text;
                string town = custTownBox.Text;
                string phone = custPhoneBox.Text;
                DateTime bdate = custDTP.Value;
                string specialreqs = custReqRTB.Text;
                
                CustomerModel newcustomer = new CustomerModel(forename, surname, address, postcode, town, phone, bdate, specialreqs);

                int rowsAffected = CustomerDAL.AddCustomer(newcustomer);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New customer has been successfully added", "Success");
                }
                else
                {
                    MessageBox.Show("An error has occured in adding the customer", "Failure");
                }



            }
        }
        private void specialReqCB_CheckedChanged(object sender, EventArgs e)
        {
            if (specialReqCB.Checked == true)
            {
                custPSLbl.Visible = true;
                custReqRTB.Visible = true;
                custReqRTB.Text = "";
            }
            else if (specialReqCB.Checked == false)
            {
                custPSLbl.Visible = false;
                custReqRTB.Visible = false;
                custReqRTB.Text = "N/A";
            }
        }
        private bool NullChecker()
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(custFnameBox.Text))
            {
                error.AppendLine("You must enter a first name.");
            }
            if (string.IsNullOrEmpty(custSnameBox.Text))
            {
                error.AppendLine("You must enter a  surname.");
            }
            if (string.IsNullOrEmpty(custPostcodeBox.Text))
            {
                error.AppendLine("You must enter a postcode.");
            }
            if (string.IsNullOrEmpty(custAddressBox.Text))
            {
                error.AppendLine("You must enter an address.");
            }
            if (string.IsNullOrEmpty(custDTP.Text))
            {
                error.AppendLine("You must enter a date of birth.");
            }
            if (string.IsNullOrEmpty(custTownBox.Text))
            {
                error.AppendLine("You must enter a town.");
            }
            if (string.IsNullOrEmpty(custPhoneBox.Text))
            {
                error.AppendLine("You must enter a phone number.");
            }
            if (string.IsNullOrEmpty(custDTP.Text))
            {
                error.AppendLine("You must enter a date of birth.");
            }
            if(string.IsNullOrEmpty(error.ToString()))
            {
                return true;
            }
            MessageBox.Show(error.ToString(), "Required fields left blank");
            return false;
        }

       

        #region BUTTONS

        private void ViewCustBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomerForm().Show();
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomerForm().Show();
        }

        private void ACMainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }
        

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

        private void deleteCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCourse().Show();
        }

        private void editCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCourse().Show();
        }

        private void addCourseTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCourseForm().Show();
        }
        #endregion
    }
}