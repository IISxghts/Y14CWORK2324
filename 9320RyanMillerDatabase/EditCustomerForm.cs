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
            G2SaveDetailsBtn.Visible = false;
        }

        DataRowView DFRowSelect;

        bool sidebarExpand;
        bool sidebarReportsExpand;
        bool sidebarCourseExpand;
        bool sidebarCustExpand;
        bool sidebarBookExpand;

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
        private void G2EditCustBtn_Click(object sender, EventArgs e)
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
                DTTextBox.Text = Convert.ToString(DFRowSelect["CustomerDOB"]);
                EFCustPhoneTB.Text = Convert.ToString(DFRowSelect["CustomerPhone"]);
                EFCustSpecialReqTB.Text = Convert.ToString(DFRowSelect["CustomerSpecialReqs"]);

                G2SaveDetailsBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a customer to edit", "Error");
            }
        }

        // Code that will write the new details through the DAL.
        private void G2SaveDetailsBtn_Click(object sender, EventArgs e)
        {
            string custidhold = EFCustIDTB.Text;
            int customerid = Convert.ToInt32(custidhold);
            string forename = EFCustForenameTB.Text;
            string surname = EFCustSurnameTB.Text;
            string address = EFCustAddressTB.Text;
            string postcode = EFCustPostcodeTB.Text;
            string town = EFCustTownTB.Text;
            string phone = EFCustPhoneTB.Text;
            string bdate = DTTextBox.Text;
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


        #region sidebar controls
        private void G2HomeSideBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void G2CustSideBtn_Click(object sender, EventArgs e)
        {
           CustSideTimer.Start();
        }

        private void G2CourseSideBtn_Click(object sender, EventArgs e)
        {
            CourseSideTimer.Start();
        }

        private void G2BookSideBtn_Click(object sender, EventArgs e)
        {
            BookSideTimer.Start();
        }

        private void G2ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportSideTimer.Start();
        }

        private void SidebarPB_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void G2AddCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerForm().Show();
        }

        private void G2EditCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomerForm().Show();
        }

        private void G2DeleteCustBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomerForm().Show();
        }

        private void AddCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCourseForm().Show();
        }

        private void EditCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCourseForm().Show();
        }

        private void DeleteCourseBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCourseForm().Show();
        }

        private void G2AddBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingForm().Show();
        }

        private void G2EditBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new EditBookingForm().Show();
        }

        private void G2DeleteBookBtnS_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteBookingForm().Show(); 
        }

        private void G2UnpaidBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerReportOne().Show();
        }

        private void ReportSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarReportsExpand)
            {
                ReportsContainer.Height += 10;
                if (ReportsContainer.Height == ReportsContainer.MaximumSize.Height)
                {
                    sidebarReportsExpand = false;
                    ReportSideTimer.Stop();
                }
            }
            else
            {
                ReportsContainer.Height -= 10;
                if (ReportsContainer.Height == ReportsContainer.MinimumSize.Height)
                {
                    sidebarReportsExpand = true;
                    ReportSideTimer.Stop();
                }
            }
        }

        private void CustSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarCustExpand)
            {
                customerContainer.Height += 10;
                if (customerContainer.Height == customerContainer.MaximumSize.Height)
                {
                    sidebarCustExpand = false;
                    CustSideTimer.Stop();
                }
            }
            else
            {
                customerContainer.Height -= 10;
                if (customerContainer.Height == customerContainer.MinimumSize.Height)
                {
                    sidebarCustExpand = true;
                    CustSideTimer.Stop();
                }
            }
        }

        private void CourseSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarCourseExpand)
            {
                coursesContainer.Height += 10;
                if (coursesContainer.Height == coursesContainer.MaximumSize.Height)
                {
                    sidebarCourseExpand = false;
                    CourseSideTimer.Stop();
                }
            }
            else
            {
                coursesContainer.Height -= 10;
                if (coursesContainer.Height == coursesContainer.MinimumSize.Height)
                {
                    sidebarCourseExpand = true;
                    CourseSideTimer.Stop();
                }
            }
        }

        private void BookSideTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarBookExpand)
            {
                bookingContainer.Height += 10;
                if (bookingContainer.Height == bookingContainer.MaximumSize.Height)
                {
                    sidebarBookExpand = false;
                    BookSideTimer.Stop();
                }
            }
            else
            {
                bookingContainer.Height -= 10;
                if (bookingContainer.Height == bookingContainer.MinimumSize.Height)
                {
                    sidebarBookExpand = true;
                    BookSideTimer.Stop();
                }
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        #endregion


    }
}   
