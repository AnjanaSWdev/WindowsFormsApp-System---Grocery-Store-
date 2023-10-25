using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_System___Grocery_Store_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            if (text_Username.Text == "Anjana" && text_Password.Text == "Login@123")
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();

            }

            else if (text_Username.Text != "Anjana" && text_Password.Text != "Login@123")
            {
                MessageBox.Show("Username and Password are invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if(text_Username.Text != "Anjana")
            {
                MessageBox.Show("Username is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (text_Password.Text != "Login@123")
            {
                MessageBox.Show("Password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

            text_Password.PasswordChar.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabel1.Text == "Show")
            {

                text_Password.PasswordChar = '\0';
                linkLabel1.Text = "Hide";

            }

            else 
            {

                text_Password.PasswordChar = '*';
                linkLabel1.Text = "Show";

            }
        }
    }
}
