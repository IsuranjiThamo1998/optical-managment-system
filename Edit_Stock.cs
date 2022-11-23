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
    public partial class Edit_Stock : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Edit_Stock()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {

            
            txtItemID.Text = "";
            cmbItemType.Text = "";
            txtQuantity.Text = "";
        }

      

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemType.Text == "Frame")
                {
                    con.Open();
                    String sql = @"update  Frame_tb set F_quantity='" + txtQuantity.Text + "' WHERE  F_id='" + txtItemID.Text + "' ";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated !");
                    String SQL = "SELECT F_id ,F_type,F_quantity FROM Frame_tb  ";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStock.DataSource = dt;

                    con.Close();
                }
                else if (cmbItemType.Text == "Lens")
                {
                    con.Open();
                    String sql = @"update Lens_tb set L_quantity='" + txtQuantity.Text + "' WHERE L_id='" + txtItemID.Text + "'";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated !");
                    String SQL = "select  L_id,L_type,L_quantity  from Lens_tb   ";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridStockL.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void dataGridStockL_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridStockL.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                txtItemID.Text = dataGridStockL.Rows[e.RowIndex].Cells["L_id"].FormattedValue.ToString();
                txtQuantity.Text = dataGridStockL.Rows[e.RowIndex].Cells["L_quantity"].FormattedValue.ToString();


            }

        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                txtItemID.Text = dgvStock.Rows[e.RowIndex].Cells["F_id"].FormattedValue.ToString();
                txtQuantity.Text = dgvStock.Rows[e.RowIndex].Cells["F_quantity"].FormattedValue.ToString();


            }
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbItemType.Text == "Frame")
            {

                con.Open();
                this.dataGridStockL.Visible = false;
                this.dgvStock.Visible = true;
                SqlCommand command = con.CreateCommand();

                command.CommandText = "SELECT F_id ,F_type,F_quantity FROM Frame_tb  ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dgvStock.DataSource = dt;
                con.Close();

            }
            else if (cmbItemType.Text == "Lens")
            {

                con.Open();
                this.dgvStock.Visible = false;
                this.dataGridStockL.Visible = true;
                SqlCommand command = con.CreateCommand();

                command.CommandText = "SELECT L_id,L_type,L_quantity FROM Lens_tb ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dataGridStockL.DataSource = dt;
                con.Close();

            }
        }
    }
}
