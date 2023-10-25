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
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btn_CLEAR_Click(object sender, EventArgs e)
        {

            text_ItemID.Clear();
            text_IName.Clear();
            text_ItemPrice.Clear();
            text_ItemQty.Clear();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to cancel ?, All the data will be deleted", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();

            }

            

        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {   
            if(text_ItemID.Text.Length == 0)
            {

                MessageBox.Show("Customer ID cannot be blank", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if(text_IName.Text.Length == 0 && text_IName.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Customer name cannot be blank and cannot have any numbers", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if(text_ItemPrice.Text.Length == 0 && text_ItemPrice.Text.Any(char.IsLetter))
            {

                MessageBox.Show("Price cannot be blank and have any letters", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (text_ItemQty.Text.Length == 0 && text_ItemQty.Text.Any(char.IsLetter))
            {

                MessageBox.Show("Quantity cannot be blank and have any letters", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else 
            {



                String IName = text_IName.Text;
                String Pdate = dateTimePicker_BookPurchase.Text;
                Int64 IPrice = Int64.Parse(text_ItemPrice.Text);
                Int64 Qty = Int64.Parse(text_ItemQty.Text);


                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                con.Open();


                cmd.CommandText = "Insert into AddItems (iName,PDate,iPrice,iQty) values ('" + IName + "', '" + Pdate + "', " + IPrice + ", " + Qty + ")";
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


            /*else
            {

                MessageBox.Show("Empty Fields are not allowed, Please check again", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/


        }

        private void AddItems_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            con.Open();

            cmd.CommandText = "select Item_ID from AddItems";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet Ds = new DataSet();
            da.Fill(Ds);

            //text_ItemID.Text = Ds.Tables[0].Rows[0][1].ToString();

            con.Close();


        }
    }
}
