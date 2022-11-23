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
using System.Text.RegularExpressions;

namespace Wikramarachchi_Opticians
{
    public partial class Patient_Registration : Form
    {

        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);

        public Patient_Registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {


                if ((txtFullName.Text == "") || (txtAge.Text == "") || (txtContactNo.Text == "") || (txtAddress.Text == "") || (dateTimePicker1.Text == ""))
                {
                    MessageBox.Show("Please Enter All Details");
                }

                else
                {

                    con.Open();

                    string Sql = @"INSERT INTO Register_tb(R_id,R_fullName,R_age,R_email,R_contact,R_address,R_reg_date)
                              VALUES('" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtEmail.Text + "','" + txtContactNo.Text + "','" + txtAddress.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                    SqlCommand comm = new SqlCommand(Sql, con);


                    string sql = @"INSERT INTO Customer_tb(P_id,P_fullName,P_age,P_email,P_contact,P_address,P_reg_date)
                              VALUES('" + txtPatientID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtEmail.Text + "','" + txtContactNo.Text + "','" + txtAddress.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                    SqlCommand command = new SqlCommand(sql, con);

                    command.ExecuteNonQuery();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("All entries are successfully saved !");
                    con.Close();

                    txtFullName.Clear();
                    txtAge.Clear();
                    txtEmail.Clear();
                    txtContactNo.Clear();
                    txtAddress.Clear();
                    dateTimePicker1.Text = "";
                    txtPatientID.Clear();
                    AutoGenerateID();

                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;

                errorProvider_patient_reg.SetError(txtFullName, "Please Enter Full Name !");
                MessageBox.Show("Please Enter Full Name..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_reg.SetError(txtFullName, null);

            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                e.Cancel = true;

                errorProvider_patient_reg.SetError(txtAge, "Please Enter your Age..!");
                MessageBox.Show("Please Enter your Age..!");
            }

            else if (txtAge.Text.Any(char.IsDigit))


            {
                errorProvider_patient_reg.SetError(txtAge, null);
            }
            else
            {
                txtAge.Focus();
                errorProvider_patient_reg.SetError(txtAge, "Please Enter Only Digits..!");
                MessageBox.Show("Please Enter Only Digits..!");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if ((txtEmail.Text != string.Empty) && (txtEmail.Text.Contains("@") && (txtEmail.Text.Contains("."))))
            {
                errorProvider_patient_reg.SetError(txtEmail, null);

            }
            else
            {
                MessageBox.Show("Please Enter Valid Email..!");


            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {

            if ((txtContactNo.Text != string.Empty) && (txtContactNo.TextLength == 10) && (txtContactNo.Text.Any(char.IsDigit)))
            {
                errorProvider_patient_reg.SetError(txtContactNo, null);
            }
            else
            {

                errorProvider_patient_reg.SetError(txtContactNo, "Please Enter Valid Phone number !");
                MessageBox.Show("Please Enter Valid Phone Number..!");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;

                errorProvider_patient_reg.SetError(txtAddress, "Please Enter your Address !");
            }
            else
            {
                e.Cancel = false;
                errorProvider_patient_reg.SetError(txtAddress, null);
            }
        }

        private void Patient_Register_Load(object sender, EventArgs e)
        {
            AutoGenerateID();
        }

        public void AutoGenerateID()
        {
            String patientid;
            String query = "select P_id from Customer_tb order by P_id  Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                patientid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                patientid = ("001");
            }
            else
            {
                patientid = ("001");
            }
            con.Close();
            txtPatientID.Text = patientid.ToString();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
