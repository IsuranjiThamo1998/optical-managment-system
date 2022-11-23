using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Wikramarachchi_Opticians
{


    public partial class Customer_Report : Form
    {

        ReportDocument reportDocument = new ReportDocument();
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void CustomerCrystalReportViewer_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM Customer_tb";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Customer_tb");

            CustomerCrystalReport customerCrystalReport = new CustomerCrystalReport();
            customerCrystalReport.SetDataSource(dataset);
            CustomerCrystalReportViewer.ReportSource = customerCrystalReport;
        }
    }
}
