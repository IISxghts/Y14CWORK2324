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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void custAddBtn_Click(object sender, EventArgs e)
        {            
            string forename = custFnameBox.Text;
            string surname = custSnameBox.Text;
            string address = custAddressBox.Text;
            string postcode = custPostcodeBox.Text;
            string town = custTownBox.Text;
            string phone = custPhoneBox.Text;
            string bdate = custDTP.Text;
            string specialreqs = custReqRTB.Text;

            CustomerModel newcustomer = new CustomerModel(forename, surname, address, postcode, town, phone, bdate, specialreqs);

            int rowsAffected = CustomerDAL.AddCustomer(newcustomer);

            if (rowsAffected > 0)
            {
                MessageBox.Show("New project has been successfully added", "Success");
            }
            else
            {
                MessageBox.Show("An error has occured in adding the project", "Failure");
            }

        }

        private void specialReqCB_CheckedChanged(object sender, EventArgs e)
        {
            if (specialReqCB.Checked)
            {
                custPSLbl.Visible = true;
                custReqRTB.Visible = true;
                custReqRTB.Text = "";
            }
            else if (specialReqCB.Checked != true)
            {
                custPSLbl.Visible = false;
                custReqRTB.Visible = false;
                custReqRTB.Text = "N/A";
            }
        }
    }
}
