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
    public partial class Eye_Technician : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=true";
        SqlConnection connection = new SqlConnection(connectionString);
        public Eye_Technician()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into Eye_technician_tb(Job_id,P_id,P_fullName,P_age,Right_eye_power,Left_eye_power,L_id,F_id,Discription) values('" + txtOrderID.Text + "','" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtRight.Text + "','" + txtLeft.Text + "','" + txtLensType.Text + "','" + txtFrameType.Text + "','" + txtDiscription.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");


                string sql = @"DELETE FROM Orders_tb WHERE Order_id='" + txtOrderID.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("deleted");



                string Sql = @"SELECT Order_id,P_fullName,P_id,P_age,Order_date FROM  Orders_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvPatient.DataSource = dt;



                connection.Close();

                txtOrderID.Text = "";
                txtPatientID.Text = "";
                txtFullName.Text = "";
                txtAge.Text = "";
                txtRegisterDate.Text = "";
                txtRight.Text = "";
                txtLeft.Text = "";
                txtLensType.Text = "";
                txtFrameType.Text = "";
                txtDiscription.Text = "";
         

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data not insert successfully");
            }
       

        }

        private void Eye_Technician_Load(object sender, EventArgs e)
        {
          


            try
            {

                string Sql = @"SELECT Order_id,P_fullName,P_age,Order_date,P_id FROM Orders_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                dgvPatient.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


            try
            {


                string Sql = @"SELECT L_id,L_type FROM  Lens_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvLensType.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


            try
            {


                string Sql = @"SELECT F_id,F_type FROM  Frame_tb ";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvFrameType.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

    

        

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPatient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtOrderID.Text = dgvPatient.Rows[e.RowIndex].Cells["Order_id"].Value.ToString();
                txtPatientID.Text = dgvPatient.Rows[e.RowIndex].Cells["P_id"].Value.ToString();
                txtFullName.Text = dgvPatient.Rows[e.RowIndex].Cells["P_fullName"].Value.ToString();
                txtAge.Text = dgvPatient.Rows[e.RowIndex].Cells["P_age"].Value.ToString();
                txtRegisterDate.Text = dgvPatient.Rows[e.RowIndex].Cells["Order_date"].Value.ToString();
            }
        }

        private void dgvFrameType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFrameType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtFrameType.Text = dgvFrameType.Rows[e.RowIndex].Cells["F_id"].Value.ToString();              
            }
        }

        private void dgvLensType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvLensType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtLensType.Text = dgvLensType.Rows[e.RowIndex].Cells["L_id"].Value.ToString();
            }
        }


        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Sql = @"SELECT * FROM  Orders_tb WHERE P_fullName like'" + txtFullName.Text + "%'";

                SqlDataAdapter ada = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dgvPatient.DataSource = dt;
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void txtPatientID_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                e.Cancel = true;
                txtPatientID.Focus();
                errorProvider1.SetError(txtPatientID, "Patient ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPatientID, null);
            }
        }

        private void txtFullName_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "Patient Name is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);
            }
        }

        private void txtAge_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                e.Cancel = true;
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Patient Age is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAge, null);
            }
        }

        private void txtRegisterDate_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRegisterDate.Text))
            {
                e.Cancel = true;
                txtRegisterDate.Focus();
                errorProvider1.SetError(txtRegisterDate, "Register date is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRegisterDate, null);
            }
        }

        private void txtRight_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRight.Text))
            {
                e.Cancel = true;
                txtRight.Focus();
                errorProvider1.SetError(txtRight, "Patient right eye size is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRight, null);
            }
        }

        private void txtLeft_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLeft.Text))
            {
                e.Cancel = true;
                txtLeft.Focus();
                errorProvider1.SetError(txtLeft, "Patient left eye size is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLeft, null);
            }
        }

        private void txtFrameType_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrameType.Text))
            {
                e.Cancel = true;
                txtFrameType.Focus();
                errorProvider1.SetError(txtFrameType, "Frame type is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFrameType, null);
            }
        }

        private void txtLensType_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLensType.Text))
            {
                e.Cancel = true;
                txtLensType.Focus();
                errorProvider1.SetError(txtLensType, "Lens type is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLensType, null);
            }
        }
    }
}
