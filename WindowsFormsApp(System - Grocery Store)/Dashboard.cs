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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning )== DialogResult.Yes)
            {
                
                this.Close();
                Application.Exit();
            }

           
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddItems adt = new AddItems();
            adt.Show();


        }



        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void addDealersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddCustomers adc = new AddCustomers();
            adc.Show();

        }

        private void viewDealersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewCustomers vwc= new ViewCustomers();
            vwc.Show();

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PlaceOrder PO = new PlaceOrder();
            //PO.Show();

            ManageOrders MO = new ManageOrders();
            MO.Show();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to log out ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                LoginForm fm = new LoginForm();
                this.Hide();
                fm.Show();


            }

        }
    }
}
