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
    public partial class OrderReport : Form
    {
        public OrderReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            this.crystalReportViewer1.ReportSource = "C:\\Users\\anjan\\source\\repos\\WindowsFormsApp(System - Grocery Store)\\WindowsFormsApp(System - Grocery Store)\\CrystalReport1.rpt";


        }
    }
}
