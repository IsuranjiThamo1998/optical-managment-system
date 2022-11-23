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
    public partial class Employee_Delete : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Employee_Delete()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sql = @"SELECT *FROM EmployeeRegister_tb";
                SqlDataAdapter ada = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvDelete.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String sql = @" delete from EmployeeRegister_tb where Emp_id='" + txtEmployeeID.Text + "' ";
                SqlCommand command = new SqlCommand(sql, con);

                command.ExecuteNonQuery();
                MessageBox.Show("Sucessfully deleted !");
                string SQL = "select *from EmployeeRegister_tb";
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDelete.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDelete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtSearch.Text = dgvDelete.Rows[e.RowIndex].Cells["Emp_fullName"].Value.ToString();
                txtEmployeeID.Text = dgvDelete.Rows[e.RowIndex].Cells["Emp_ID"].Value.ToString();

            }
        }
    }
}
