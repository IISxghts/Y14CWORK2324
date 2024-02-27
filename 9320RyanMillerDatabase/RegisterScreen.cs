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
using System.Windows.Media.Imaging;

namespace _9320RyanMillerDatabase
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
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

            TxtBoxP2.BackColor = SystemColors.Control;
            G2PassPanel2.BackColor = SystemColors.Control;
        }

        private void G2BtnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginScreen().Show();
        }

        private void G2BtnRegister_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Users.txt");
            FileStream aFile;
            StreamWriter sw;
            try
            {

                string EnteredUser = TxtBoxU.Text;
                string EnteredPass = TxtBoxP.Text;
                string EnteredSecondPass = TxtBoxP2.Text;
                bool UsernameExistsAlready = false;
                
                

                if (!string.IsNullOrEmpty(EnteredUser) && !string.IsNullOrEmpty(EnteredPass) && !string.IsNullOrEmpty(EnteredSecondPass))
                {
                    if (EnteredPass == EnteredSecondPass)
                    {
                        if (EnteredUser.Length < 12)
                        {
                            StreamReader userExist = new StreamReader("../../Users.txt");
                            string line;
                            while ((line = userExist.ReadLine()) != null)
                            {
                                String user = line.Split('~')[0];

                                if (user == EnteredUser)
                                {
                                    UsernameExistsAlready = true;
                                    break;
                                }
                            }
                            userExist.Close();


                            if (UsernameExistsAlready == false)
                            {
                                if (!File.Exists(filePath))
                                {

                                    aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

                                }
                                else
                                {
                                    aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);

                                }

                                sw = new StreamWriter(aFile);

                                switch (G2ComboBox.SelectedItem)
                                {
                                    case "Staff":
                                        sw.WriteLine(EnteredUser + "~" + EnteredPass + "~" + "STAFF"); 
                                        break;
                                    case "Customer":
                                        sw.WriteLine(EnteredUser + "~" + EnteredPass + "~" + "CUSTOMER");
                                        break;
                                }


                                sw.Close();
                                aFile.Close();

                                TxtBoxU.Text = "";
                                TxtBoxP.Text = "";
                                TxtBoxP2.Text = "";
                                G2ComboBox.SelectedItem = null;
                               

                                MessageBox.Show("New user has been added successfully", "Successful");

                            }
                            else
                            {
                                MessageBox.Show("Username already exists in system.", "Username error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username cannot be longer than 12 characters.", "Username too long");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords entered are not the same", "Re-entry required.");
                    }
                }
                else
                {
                    MessageBox.Show("Username and password must not be empty", "Username or password missing");

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("User failed to add", "Error occured");
            }
        }

        private void TxtBoxU_Click(object sender, EventArgs e)
        {
            TxtBoxU.BackColor = Color.White;
            G2UserPanel.BackColor = Color.White;

            TxtBoxP.BackColor = SystemColors.Control;
            G2PassPanel.BackColor = SystemColors.Control;

            TxtBoxP2.BackColor = SystemColors.Control;
            G2PassPanel2.BackColor = SystemColors.Control;
        }

        private void TxtBoxP_Click(object sender, EventArgs e)
        {
            TxtBoxU.BackColor = SystemColors.Control;
            G2UserPanel.BackColor = SystemColors.Control;

            TxtBoxP.BackColor = Color.White;
            G2PassPanel.BackColor = Color.White;

            TxtBoxP2.BackColor = SystemColors.Control;
            G2PassPanel2.BackColor = SystemColors.Control;
        }

        private void TxtBoxP2_Click(object sender, EventArgs e)
        {
            TxtBoxU.BackColor = SystemColors.Control;
            G2UserPanel.BackColor = SystemColors.Control;

            TxtBoxP.BackColor = SystemColors.Control;
            G2PassPanel.BackColor = SystemColors.Control;    

            TxtBoxP2.BackColor = Color.White;
            G2PassPanel2.BackColor = Color.White;
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
     
    }
}
