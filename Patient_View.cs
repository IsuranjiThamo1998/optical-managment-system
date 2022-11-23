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
    public partial class Patient_View : Form
    {

        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Patient_View()
        {
            InitializeComponent();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string Sql = @"select *from Customer_tb ";
                SqlDataAdapter ada = new SqlDataAdapter(Sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvView.DataSource = dt;
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Sql = @"SELECT * FROM  Customer_tb WHERE P_fullName like'" + txtSearch.Text + "%'";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvView.DataSource = dt;
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Patient_View_Load(object sender, EventArgs e)
        {
            try
            {
                string Sql = @"SELECT * FROM  Customer_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvView.DataSource = dt;
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtPatientID.Text == "" || txtFullName.Text == "" || txtAge.Text == "" )
            {
                MessageBox.Show("please fill all field!", ("texbox validation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    String sql = @"update Customer_tb  set P_fullName='" + txtFullName.Text + "', P_age='" + txtAge.Text + "',P_email='" + txtEmail.Text + "',P_contact='"+ txtContactNo.Text + "',P_address='" + txtAddress.Text + "' where P_id='" + txtPatientID.Text + "'";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    //MessageBox.Show("Successfully updated !");
              


                    String Sql = @"update Register_tb  set R_fullName='" + txtFullName.Text + "', R_age='" + txtAge.Text + "',R_email='" + txtEmail.Text + "',R_contact='" + txtContactNo.Text + "',R_address='" + txtAddress.Text + "' where R_id='" + txtPatientID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Sql, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully updated !");


                    String SQL = "select *from Customer_tb ";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvView.DataSource = dt;

                    MessageBox.Show("Successfully updated !");

                    con.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtPatientID.Text = dgvView.Rows[e.RowIndex].Cells["P_id"].Value.ToString();
                txtFullName.Text = dgvView.Rows[e.RowIndex].Cells["P_fullName"].Value.ToString();

                txtAge.Text = dgvView.Rows[e.RowIndex].Cells["P_age"].Value.ToString();
                txtEmail.Text = dgvView.Rows[e.RowIndex].Cells["P_email"].Value.ToString();
                txtContactNo.Text = dgvView.Rows[e.RowIndex].Cells["P_contact"].Value.ToString();
                txtAddress.Text = dgvView.Rows[e.RowIndex].Cells["P_address"].Value.ToString();
                
            }
        }
    }
}
