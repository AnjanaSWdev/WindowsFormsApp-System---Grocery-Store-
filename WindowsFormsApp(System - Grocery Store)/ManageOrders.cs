using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_System___Grocery_Store_
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

       

            void populate()
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

                try
                {
                   
                   con.Open();

                   string MyQuery = "Select * from tbl_Customers3";

                   SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
                   SqlCommandBuilder builder = new SqlCommandBuilder(da);
                   var ds = new DataSet();

                   da.Fill(ds);

                   CustomersGV.DataSource = ds.Tables[0];

                   con.Close();



                }

                
                
                catch { }


            }


        void populateItems()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            try
            {

                con.Open();

                string MyQuery = "Select * from AddItems";

                SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();

                da.Fill(ds);

                ItemsGV.DataSource = ds.Tables[0];

                con.Close();



            }



            catch { }


        }


        void updateproduct()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            

            int updatedStock = Convert.ToInt32(stock - quan);

            if(updatedStock < 0)
            {

                MessageBox.Show("Operation cannot be fullfille", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                con.Open();

                string query = "update AddItems set IQty = " + updatedStock + " where Item_ID = " + Item_Id + "";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();
                populateItems();

            }
            

        }



        private void ManageOrders_Load(object sender, EventArgs e)
        {

            populate();
            populateItems();


        }

        /*private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            text_CusId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();

        }*/

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CusId, Cus_name;

            if (e.RowIndex >= 0)
            {
                
                CusId = (CustomersGV.Rows[e.RowIndex].Cells[0].Value.ToString());

                text_CusId.Text = CusId;

                Cus_name = (CustomersGV.Rows[e.RowIndex].Cells[1].Value.ToString());

                text_Cusname.Text = Cus_name;

            }



            

        }


        protected string product,uprice;
        protected Int64 quan, totprice, stock = 0;
        protected int flag, Item_Id;

        private void ItemsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            product = (ItemsGV.Rows[e.RowIndex].Cells[1].Value.ToString());
            uprice = (ItemsGV.Rows[e.RowIndex].Cells[3].Value.ToString());

            stock = Convert.ToInt64(ItemsGV.Rows[e.RowIndex].Cells[4].Value.ToString());
            flag = 1;

            Item_Id = Convert.ToInt32(ItemsGV.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btn_InsertOrder_Click(object sender, EventArgs e)
        {
            int Order_Id = Convert.ToInt32(text_OrderId.Text);
            int Cus_Id = Convert.ToInt32(text_CusId.Text);
            string Cus_name = text_Cusname.Text;

            int Tot_Amount = Convert.ToInt32(total);

            if(text_OrderId.Text != "" || text_CusId.Text != "" || text_Cusname.Text != "" || label_TotAmount.Text != "")
            {

                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                con.Open();


                cmd.CommandText = "Insert into tbl_Order (Order_Id,Cus_Id,Cus_name,Order_date,Tot_amount) values (" + Order_Id + ", " + Cus_Id + ", '" + Cus_name + "', '" + order_date.Text + "', '" + Tot_Amount + "')";
                int i = cmd.ExecuteNonQuery();


                if (i == 1)
                {

                    MessageBox.Show("Order Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("Order cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                OrderGV.Rows.Clear();

                


                con.Close();


            }

            else
            {

                MessageBox.Show("Data fields cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ViewOrders vo = new ViewOrders();
            this.Close();
            vo.Show();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            quan = Int64.Parse(numericUpDown1.Value.ToString());
            totprice = (quan * Convert.ToInt64(uprice));


        }

        protected int n; 
        Int64 total=0;
        private void btn_addtocart_Click(object sender, EventArgs e)
        {

            totprice = (quan * Convert.ToInt64(uprice));
            if (totprice == 0 && quan == 0)
            {

                MessageBox.Show("Enter the quantity of the products...!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
            else if(flag == 0)
            {

                MessageBox.Show("Select a product...!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if(numericUpDown1.Value > stock)
            {

                MessageBox.Show("Entered quantity is greater than the available quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                n = OrderGV.Rows.Add();
                OrderGV.Rows[n].Cells[0].Value = product;
                OrderGV.Rows[n].Cells[1].Value = uprice;
                OrderGV.Rows[n].Cells[2].Value = numericUpDown1.Value;
                OrderGV.Rows[n].Cells[3].Value = totprice;

                flag = 0;

                total = total + totprice;

                label_TotAmount.Text = "Rs. " + total;


                updateproduct();
            }

            


        }
    }
}
