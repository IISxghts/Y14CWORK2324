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

        private void EFCMainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new DatabaseMenu().Show();
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

        private void EFCustEditBtn_Click(object sender, EventArgs e)
        {
            if (DFRowSelect != null)
            {
                int IDThatSelected = Convert.ToInt32(DFRowSelect["CustomerNum"]);
                EFCustIDTB.Text = Convert.ToString(IDThatSelected);
                EFCustForenameTB.Text = Convert.ToString(DFRowSelect["CustomerForename"]);
                EFCustSurnameTB.Text = Convert.ToString(DFRowSelect["CustomerSurname"]);
                EFCustAddressTB.Text = Convert.ToString(DFRowSelect["CustomerAddress"]);
                EFCustPostcodeTB.Text = Convert.ToString(DFRowSelect["CustomerPostcode"]);
                EFCustTownTB.Text = Convert.ToString(DFRowSelect["CustomerTown"]);
                EFCustDOBTB.Text = Convert.ToString(DFRowSelect["CustomerDOB"]);
                EFCustPhoneTB.Text = Convert.ToString(DFRowSelect["CustomerPhone"]);
                EFCustSpecialReqTB.Text = Convert.ToString(DFRowSelect["CustomerSpecialReqs"]);


            }
        }
    }
}
