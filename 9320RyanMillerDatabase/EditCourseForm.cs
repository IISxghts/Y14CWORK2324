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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void EFCustEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void EFCustSNDBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lakeside9320CoursesEditDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.lakeside9320CoursesEditDataSet.Courses);

        }
    }
}
