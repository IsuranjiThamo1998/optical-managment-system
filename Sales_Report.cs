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
    public partial class Sales_Report : Form
    {
        ReportDocument reportDocument = new ReportDocument();
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM Sales_tb";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Sales_tb");

            SalesCrystalReport salesCrystalReport = new SalesCrystalReport();
            salesCrystalReport.SetDataSource(dataset);
          SalesCrystalReportViewer.ReportSource = salesCrystalReport;
        }
    }
}
