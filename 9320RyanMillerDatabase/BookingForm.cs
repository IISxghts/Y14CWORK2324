using Guna.UI2.WinForms;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _9320RyanMillerDatabase
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            CenterToScreen();
            DiscountSelectBox.Visible = false;
            Discount();
            DTPValue();
        }
        bool ConfirmedBook;

        DataRowView DFRowSelectCustomer;
        DataRowView DFRowSelectCourse;

        FileStream aFile;
        StreamWriter sw;

        private void MainMenuTSM_Click(object sender, EventArgs e)
        {
            Hide();
            new LakesideMenu().Show();
        }

        private void TempBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CustomerSelectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lakeside9320CustomerSelectDataSet.Customer);

        }

        private void BookingTablesRefresh()
        {
            this.customerTableAdapter.Fill(this.lakeside9320CustomerSelectDataSet.Customer);

        }

        private void G2CheckAvailabilityBtn_Click(object sender, EventArgs e)
        {
            if(DTPBooking.Value.Date >= DateTime.Now.Date)
            {
                DGVCourse.DataSource = BookingDAL.GetLessonsFromBooking(DTPBooking.Value.Date);
            }
            else
            {
                MessageBox.Show("Please select a date from the future", "Error");
            }
        }

        private void Discount()
        {
            if (DiscountCheckBox.Checked == true)
            {
                DiscountSelectBox.Visible = true;
                DiscountBookingLbl.Visible = true;
            }
            else if (DiscountCheckBox.Checked == false)
            {
                DiscountSelectBox.Visible = false;
                DiscountBookingLbl.Visible = false;
            }

        }

        public void DTPValue()
        {
            DateTime dt = DateTime.Now;

            DTPBooking.Value = dt;
        }

        private void G2AddBookingBtn_Click(object sender, EventArgs e)
        {
            if(NullChecker())
            {
                bool status = false;
                DoubleBookCheck(status);

                if (status == false)
                {
                    MessageBox.Show("Unable to confirm booking", "Double booking");                    
                }
                else
                {
                    if (DFRowSelectCourse != null && DFRowSelectCustomer != null)
                    {
                        ConfirmedBook = true;

                        int CustID = Convert.ToInt32(DFRowSelectCustomer["CustomerNum"]);
                        int CourseID = Convert.ToInt32(DFRowSelectCourse["CourseID"]);
                        DateTime bookDateHold = DTPBooking.Value;
                        string bookDate = bookDateHold.ToShortDateString();
                        string discountYN = "N/A";
                        decimal discountPercent = DiscountSelectBox.Value;
                        if (DiscountCheckBox.Checked == true)
                        {
                            discountYN = "Yes";
                        }
                        else
                        {
                            discountYN = "No";
                        }
                        int customerQuantity = (int)QuantitySelectBox.Value;

                        BookingModel newBooking = new BookingModel(CourseID, bookDate, discountYN, discountPercent, CustID, customerQuantity);

                        int rowsAffected = BookingDAL.AddBooking(newBooking);

                          WriteToFile();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New booking has been reserved", "Success");
                        }
                        else
                        {
                            MessageBox.Show("An error has occured in creating the booking", "Failure");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a customer and a course to book", "Error");
                    }
                }           

            }
            

        }

        private bool NullChecker()
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(DiscountSelectBox.Text))
            {
                error.AppendLine("You must enter an amount of attendees.");
            }
            if (DiscountCheckBox.Checked && string.IsNullOrEmpty(DiscountSelectBox.ToString()))
            {
                error.AppendLine("You must enter a discount percentage.");
            }
            if (string.IsNullOrEmpty(error.ToString()))
            {
                return true;
            }
            MessageBox.Show(error.ToString(), "Required fields left blank");
            return false;
        }
    
        
        private void DGVCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseTheRowings();
        }
        private void ChooseTheRowings()
        {
            DFRowSelectCustomer = DGVCustomer.CurrentRow != null ? (DataRowView)DGVCustomer.CurrentRow.DataBoundItem : null;
            DFRowSelectCourse = DGVCourse.CurrentRow != null ? (DataRowView)DGVCourse.CurrentRow.DataBoundItem : null;
        }

        private void DiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Discount();
        }

        public void WriteToFile()
        {
            FileStream aFile;
            StreamWriter sw;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "BookingsMade.txt");

            if (System.IO.File.Exists(filePath))
            {

                aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            }
            else
            {
                aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);

            }

            sw = new StreamWriter(aFile);

            if (ConfirmedBook == true)
            {
                string CustID = Convert.ToString(DFRowSelectCustomer["CustomerNum"]);
                string CustPhone = Convert.ToString(DFRowSelectCustomer["CustomerPhone"]);
                string CourseID = Convert.ToString(DFRowSelectCourse["CourseID"]);

                string[] data = new string[2];

                data[0] = CustID;
                data[1] = CourseID;
                data[2] = CustPhone;

                sw.WriteLine(data[0], data[1], data[2]);

                sw.Close();
                aFile.Close();
            }
            else
            {
                MessageBox.Show("Unable to backup data for booking", "Error");
            }
        }
        
        public bool DoubleBookCheck(bool status)
        {

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "BookingsMade.txt");
            bool bookExist = false;

            try
            {
                StreamReader bookingExists = new StreamReader(filePath);
                string line;
                while ((line = bookingExists.ReadLine()) != null)
                {
                    string user = line.Split('~')[0];
                    string course = line.Split('~')[1];
                    string phone = line.Split('~')[2];

                    string CustID = Convert.ToString(DFRowSelectCustomer["CustomerNum"]);
                    string CustPhone = Convert.ToString(DFRowSelectCustomer["CustomerPhone"]);
                    string CourseID = Convert.ToString(DFRowSelectCourse["CourseID"]);

                    if (user == CustID && course == CourseID && phone == CustPhone) // what to use as check
                    {
                        bookExist = true;
                        break;
                    }

                    bookingExists.Close();

                    if (bookExist == true)
                    {
                        status = false;
                    }
                    else if (bookExist == false) 
                    {
                        status = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot verify status of booking", "Error occured");
            }
            return false;
        }


    }
}
