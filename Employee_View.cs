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
namespace Wikramarachchi_Opticians
{
    public partial class Employee_View : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        public Employee_View()
        {
            InitializeComponent();
        }

       

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }

        

        private void btnView_Click(object sender, EventArgs e)
        {

            try
            {
                string Sql = "select *from EmployeeRegister_tb where Emp_fullName='" + txtSearch.Text + "'";
                SqlDataAdapter ada = new SqlDataAdapter(Sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvViewEmployee.DataSource = dt;
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
