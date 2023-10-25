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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }


        void populateOrders()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=ANJANA;Initial Catalog=GroceryStore;Integrated Security=True";

            try
            {

                con.Open();

                string MyQuery = "Select * from tbl_Order";

                SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();

                da.Fill(ds);

                OrdersGV.DataSource = ds.Tables[0];

                con.Close();



            }



            catch { }


        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {

            populateOrders();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            ManageOrders MO = new ManageOrders();
            this.Close();
            MO.Show();

        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            
            OrderReport OR = new OrderReport();
            this.Close();
            OR.Show();  

        }
    }
}
