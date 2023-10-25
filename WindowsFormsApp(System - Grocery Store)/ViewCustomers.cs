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
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select Cus_name, Reg_date, Cus_Address, Tel_no from tbl_Customers3 where Cus_Id = '" + text_SearchName.Text + "'";

            SqlDataReader da = cmd.ExecuteReader();
            

            while (da.Read())
            {
                text_Cusname.Text = da.GetValue(0).ToString();
                dateTimePicker_CusRegister.Text = da.GetValue(1).ToString();
                text_CusADD.Text = da.GetValue(2).ToString();
                text_Telno.Text = da.GetValue(3).ToString();

            }

            da.Close();

            int i = cmd.ExecuteNonQuery();

            if (i == 0)
            {

                MessageBox.Show("Enter valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

           

            con.Close();

        }

        private void text_SearchName_TextChanged(object sender, EventArgs e)
        {

            text_Cusname.Clear();
            text_CusADD.Clear();
            text_Telno.Clear();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "update tbl_Customers3 set Cus_name ='" + text_Cusname.Text + "', Cus_address ='" + text_CusADD.Text + "', Tel_no =" + text_Telno.Text + " where Cus_Id ='" + text_SearchName.Text + "'";

            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Data updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Data Cannot be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            con.Close();

        }

        private void btn_DEL_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this customer ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                con.Open();

                cmd.CommandText = "Delete from tbl_Customers3 where Cus_Id = '" + text_SearchName.Text + "'";

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Customer deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Customer Cannot be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                con.Close();

                text_Cusname.Clear();
                text_CusADD.Clear();
                text_Telno.Clear();
                


            }

        }
    }
}
