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
    public partial class Delete_Lens : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        public Delete_Lens()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = @" delete from Lens_tb where L_id='" + txtLensID.Text + "' ";
                SqlCommand command = new SqlCommand(sql, con);

                command.ExecuteNonQuery();
                MessageBox.Show("Sucessfully deleted !");
                string SQL = "select *from Lens_tb";
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = @"SELECT *FROM Lens_tb ";
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

        private void dgvDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDelete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                txtSearch.Text = dgvDelete.Rows[e.RowIndex].Cells["L_type"].Value.ToString();
                txtLensID.Text = dgvDelete.Rows[e.RowIndex].Cells["L_id"].Value.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
