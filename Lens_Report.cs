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
    public partial class Lens_Report : Form
    {
        ReportDocument reportDocument = new ReportDocument();
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Lens_Report()
        {
            InitializeComponent();
        }

        private void LensCrystalReportViewer_Load(object sender, EventArgs e)
        {
            string Sql = @"SELECT * FROM Lens_tb";
            SqlDataAdapter dt = new SqlDataAdapter(Sql, con);
            DataSet dataset = new DataSet();
            dt.Fill(dataset, "Lens_tb");



            LensCrystalReport lensCrystalReport = new LensCrystalReport();
            lensCrystalReport.SetDataSource(dataset);
            LensCrystalReportViewer.ReportSource = lensCrystalReport;
        }
    }
}
