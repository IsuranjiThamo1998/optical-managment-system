using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Wikramarachchi_Opticians
{
    public partial class Employee_Edit : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Employee_Edit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }

        private void btnLogot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "";
            txtFullName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtSearch.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = con.CreateCommand();

            command.CommandText = "SELECT *FROM EmployeeReg_tb where Emp_fullName = '" + txtSearch.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgvEdit.DataSource = dt;
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "" || txtFullName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("please fill all field!", ("texbox validation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    String sql = @"update EmployeeReg_tb set Emp_fullName='" + txtFullName.Text + "', Emp_age='" + txtAge.Text + "',Emp_email='" + txtEmail.Text + "',Emp_username='" + txtUsername.Text + "',Emp_password='" + txtPassword.Text + "' where Emp_id='" + txtEmployeeID.Text + "'";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated !");
                    String SQL = "select *from EmployeeReg_tb ";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEdit.DataSource = dt;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

            }
        }

        private void dgvEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_id"].Value.ToString();
            txtFullName.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_fullName"].Value.ToString();
            txtAge.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_age"].Value.ToString();
            txtEmail.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_email"].Value.ToString();
            txtUsername.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_username"].Value.ToString();
            txtPassword.Text = dgvEdit.Rows[e.RowIndex].Cells["Emp_password"].Value.ToString();
        }
    }
}
