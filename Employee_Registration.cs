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
    public partial class Employee_Registration : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);
        public Employee_Registration()
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
            txtEmployeeID.Text = "";
            txtFullName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            cmbRole.Text = "";
        }

        private void btnLogot_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "" || txtFullName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("please fill all field!", ("texbox validation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    String sql = @"insert into EmployeeRegister_tb(Emp_id,Emp_fullName,Emp_age,Emp_email,Emp_username,Emp_password,Emp_role) values('" + txtEmployeeID.Text + "','" + txtFullName.Text + "','" + txtAge.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbRole.Text + "')";
                    SqlCommand command = new SqlCommand(sql, con);




                    MessageBox.Show("data saved!", ("texbox "), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    command.ExecuteNonQuery();

                    con.Close();


                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }

        }

        private void Employee_Register_Load(object sender, EventArgs e)
        {
            AutoGenerateID();
        }

        public void AutoGenerateID()
        {
            String empid;
            String query = "select Emp_id from EmployeeRegister_tb order by Emp_id  Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                empid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                empid = ("001");
            }
            else
            {
                empid = ("001");
            }
            con.Close();
            txtEmployeeID.Text = empid.ToString();
        }


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if ((txtEmail.Text != string.Empty) && (txtEmail.Text.Contains("@") && (txtEmail.Text.Contains("."))))
            {
                errorProviderER.SetError(txtEmail, null);
            }
            else
            {
                txtEmail.Focus();
                errorProviderER.SetError(txtEmail, "Please enter valid email address !");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if ((txtPassword.Text != string.Empty) && (txtPassword.TextLength == 4))
            {
                errorProviderER.SetError(txtPassword, null);
            }
            else
            {
                txtPassword.Focus();
                errorProviderER.SetError(txtPassword, "Please enter valid password !");
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {

            if (txtConfirm.Text != txtPassword.Text)
            {
                txtConfirm.Focus();
                errorProviderER.SetError(txtConfirm, "confirm pw anot matching new pw");
            }
            else
            {
                errorProviderER.SetError(txtConfirm, null);
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {

            if (txtAge.Text.Any(char.IsDigit))


            {


                errorProviderER.SetError(txtAge, null);


            }
            else
            {
                txtAge.Focus();
                errorProviderER.SetError(txtAge, "Please enter only digits !");
            }
        }

       
    }
}
