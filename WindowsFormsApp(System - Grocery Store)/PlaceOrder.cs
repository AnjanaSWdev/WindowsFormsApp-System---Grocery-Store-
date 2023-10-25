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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd = new SqlCommand("Select iName from AddItems ", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {

                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmb_Items.Items.Add(Sdr.GetString(i));
                }

            }

            Sdr.Close();
            con.Close();

        }

        private void cmb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select * from AddItems where iName = '" + cmb_Items.SelectedItem + "'";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            DA.Fill(Ds);

            if (Ds.Tables[0].Rows.Count != 0)
            {
                text_Itemname.Text = Ds.Tables[0].Rows[0][1].ToString();
                text_Price.Text = Ds.Tables[0].Rows[0][3].ToString();
                text_avbQTY.Text = Ds.Tables[0].Rows[0][4].ToString();

            }

            Int64 quan = Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(text_Price.Text);

            text_Tot.Text = (quan * price).ToString();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            Int64 quan = Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(text_Price.Text);

            text_Tot.Text = (quan * price).ToString();

            

        }

        protected int n, total = 0;



        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            if (text_Tot.Text != "0" && text_Tot.Text != "")
            {

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = text_Itemname.Text;
                dataGridView1.Rows[n].Cells[1].Value = text_Price.Text;
                dataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Value;
                dataGridView1.Rows[n].Cells[3].Value = text_Tot.Text;

                total = total + int.Parse(text_Tot.Text);

                label_TotAmount.Text = "Rs. " + total;




            }

            else
            {

                MessageBox.Show("Minimum quantity should be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        int amount = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }

            catch { }



        }


        private void btn_removeItem_Click(object sender, EventArgs e)
        {

            try
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }

            catch { }

            total = total - amount;
            label_TotAmount.Text = "Rs." + total;


        }



    }
}
