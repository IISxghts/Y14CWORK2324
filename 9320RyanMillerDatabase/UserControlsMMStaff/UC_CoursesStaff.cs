﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9320RyanMillerDatabase.UserControls
{
    public partial class UC_CoursesStaff : UserControl
    {
        public UC_CoursesStaff()
        {
            InitializeComponent();
        }

        private void G2BtnAddCourse_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new AddCourseForm().Show();
        }

        private void G2BtnEditCourse_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new EditCourse().Show();
        }

        private void G2BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            ((LakesideMenu)this.TopLevelControl).Hide();
            new DeleteCourse().Show();
        }

    }
}