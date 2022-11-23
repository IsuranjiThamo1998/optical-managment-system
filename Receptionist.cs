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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

       

      

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            this.Close();

            Patient_Registration patient_Register = new Patient_Registration();
            patient_Register.Show();
        }

        private void btnViewPatient_Click_1(object sender, EventArgs e)
        {
            this.Close();

            Patient_View patient_View = new Patient_View();
            patient_View.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            this.Close();

            Orders orders = new Orders();
            orders.Show();
        }
    }
}
