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

namespace _9320RyanMillerDatabase
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            CenterToScreen();
            InitialLoadout();
        }

        
        private void InitialLoadout()
        {
            TxtBoxU.BackColor = SystemColors.Control;
            G2UserPanel.BackColor = SystemColors.Control;

            TxtBoxP.BackColor = SystemColors.Control;
            G2PassPanel.BackColor = SystemColors.Control;

        }
        private void G2BtnLogin_Click(object sender, EventArgs e)
        {
            string Username = TxtBoxU.Text;
            string Password = TxtBoxP.Text;
            string pathForFile = Path.Combine(Directory.GetCurrentDirectory(), "Users.txt");

            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                if (File.Exists(pathForFile))
                {
                    string[] users = File.ReadLines(pathForFile).ToArray();
                    bool customerFound = false;
                    bool staffFound = false;

                    for (int i = 0; i < users.Length; i++)
                    {
                        string[] UsernameAndPassword = users[i].Split('~');

                        if (Username == UsernameAndPassword[0] && Password == UsernameAndPassword[1] && UsernameAndPassword[2] == "STAFF")
                        {
                            staffFound = true;
                            DataModel.UserType = "S";
                            break;
                        }
                        else if (Username == UsernameAndPassword[0] && Password == UsernameAndPassword[1] && UsernameAndPassword[2] == "CUSTOMER")
                        {
                            customerFound = true;
                            DataModel.UserType = "C";
                            break;
                        }
                    }

                    if (customerFound)
                    {
                        Hide();
                        DataModel.DisplayUname = TxtBoxU.Text;
                        new LakesideMenu().Show();
                    }
                    else if(staffFound)
                    {
                        Hide();
                        DataModel.DisplayUname = TxtBoxU.Text;
                        new LakesideMenu().Show();
                    }
                    else
                    {
                        MessageBox.Show("User is not valid \n Please try again", "User not found");
                    }



                }
                else
                {
                    MessageBox.Show("No users have been registered", "No users found");
                }
            }

            else
            {
                MessageBox.Show("Username and password must not be empty", "Username or password missing");
            }

        }

        private void G2BtnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterScreen().Show();
        }




        private void G2PBEyeView_MouseDown(object sender, MouseEventArgs e)
        {

            TxtBoxP.UseSystemPasswordChar = false;

            G2PBEyeView.Image = ImageResource.newhidevs;
        }

        private void G2PBEyeView_MouseUp(object sender, MouseEventArgs e)
        {
            TxtBoxP.UseSystemPasswordChar = true;

            G2PBEyeView.Image = ImageResource.eyefinalvs;
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtBoxU_Click(object sender, EventArgs e)
        {
            TxtBoxU.BackColor = Color.White;
            G2UserPanel.BackColor = Color.White;

            TxtBoxP.BackColor = SystemColors.Control;
            G2PassPanel.BackColor = SystemColors.Control;
        }

        private void TxtBoxP_Click(object sender, EventArgs e)
        {
                        TxtBoxU.BackColor = SystemColors.Control;
            G2UserPanel.BackColor = SystemColors.Control;

            TxtBoxP.BackColor = Color.White;
            G2PassPanel.BackColor = Color.White;
        }
    }
}
