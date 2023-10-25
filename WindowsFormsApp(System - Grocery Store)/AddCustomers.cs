using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_System___Grocery_Store_
{
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Int64 Cus_Id = Int64.Parse(text_CusID.Text);
            String Cus_name = text_Cusname.Text;
            String Reg_date = dateTimePicker_CusRegister.Text;
            String Cus_address = text_CusADD.Text;
            Int64 Tel_no = Int64.Parse(text_Telno.Text);

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Insert into tbl_Customers3 (Cus_Id,Cus_name,Reg_date,Cus_address,Tel_no) values( " + Cus_Id + ",'" +Cus_name + "', '" +Reg_date + "', '" +Cus_address + "', " +Tel_no + ")";
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {

                MessageBox.Show("Data Save Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                MessageBox.Show("Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            con.Close();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            text_Cusname.Clear();
            text_CusADD.Clear();
            text_Telno.Clear();


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();

            }

        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
