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
    public partial class Frame_Report : Form
    {
        ReportDocument reportDocument = new ReportDocument();
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Frame_Report()
        {
            InitializeComponent();
        }

        private void StockCrystalReportViewer_Load(object sender, EventArgs e)
        {

            string sql = @"SELECT * FROM Frame_tb";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Frame_tb");
            FrameCrystalReport frameCrystalReport = new FrameCrystalReport();
            frameCrystalReport.SetDataSource(dataset);
            FrameCrystalReportViewer.ReportSource = frameCrystalReport;



        }

      

        private void btnLensReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
