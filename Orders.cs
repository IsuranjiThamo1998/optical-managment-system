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
    public partial class Orders : Form
    {

        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Orders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string Sql = @"SELECT P_id,P_fullName,P_age FROM  Customer_tb WHERE P_fullName like'" + txtSearch.Text + "%'";

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

        private void btnOrder_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                string Sql = @"INSERT INTO Orders_tb(Order_id,P_id,P_fullName,P_age,Order_date)
                              VALUES('" + txtOrderID.Text + "','" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + dateTimePicker1.Value.ToString() + "')";



                string SQL = @"INSERT INTO OrderDetails_tb (OrderDetails_id,P_id,P_fullName,P_age,Order_date)
                              VALUES('" + txtOrderID.Text + "','" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + dateTimePicker1.Value.ToString() + "')";

                SqlCommand comm = new SqlCommand(Sql, con);
                SqlCommand command = new SqlCommand(SQL, con);

                command.ExecuteNonQuery();
                comm.ExecuteNonQuery();

                MessageBox.Show("successfully placed orders !");
                con.Close();



                txtOrderID.Clear();
                txtPatientID.Clear();
                txtFullName.Clear();
                txtAge.Clear();
                dateTimePicker1.Text = "";


                AutoGenerateID();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            AutoGenerateID();
        }

        public void AutoGenerateID()
        {
            String orderid;
            String query = "select OrderDetails_id from OrderDetails_tb order by OrderDetails_id  Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                orderid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                orderid = ("001");
            }
            else
            {
                orderid = ("001");
            }
            con.Close();
            txtOrderID.Text = orderid.ToString();
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtPatientID.Text = dgvView.Rows[e.RowIndex].Cells["P_id"].Value.ToString();
                txtFullName.Text = dgvView.Rows[e.RowIndex].Cells["P_fullName"].Value.ToString();
                txtAge.Text = dgvView.Rows[e.RowIndex].Cells["P_age"].Value.ToString();

            }
        }
    }
}
