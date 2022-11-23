using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wikramarachchi_Opticians
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Report report = new Report();
            report.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCusReport_Click(object sender, EventArgs e)
        {
           this.Close();
           Customer_Report customer_Report= new Customer_Report();
           customer_Report.Show();
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Report sales_Report = new Sales_Report();
            sales_Report.Show();
        }

       
        

        private void btnLensReport_Click(object sender, EventArgs e)
        {
            this.Close();
            Lens_Report lens_Report = new Lens_Report();
            lens_Report.Show();
        }

        private void btnFrameReport_Click(object sender, EventArgs e)
        {
            this.Close();
            Frame_Report frame_Report = new Frame_Report();
            frame_Report.Show();
        }
    }
}
