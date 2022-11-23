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


    public partial class Login : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=true";
        SqlConnection con = new SqlConnection(connectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;


            if(username == "man" && password == "1234" && role == "Manager")
            {
                this.Close();
                Manager manager = new Manager();
                manager.Show();
            }


           else if (username != "" && password != "" && role == "Manager")
            {
                try
                {
                    con.Open();
                    String SQL = "select count (*) from EmployeeRegister_tb where Emp_username=('" + txtUsername.Text + "') and Emp_password=('" + txtPassword.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Close();
                        Manager manager = new Manager();
                        manager.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username OR Password Incorrect!");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if (username != "" && password != "" && role == "Receptionist")
            {

               try
                {
                    con.Open();
                    String SQL = "select count (*) from EmployeeRegister_tb where Emp_username=('" + txtUsername.Text + "') and Emp_password=('" + txtPassword.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Close();
                        Receptionist receptionist = new Receptionist();
                        receptionist.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username OR Password Incorrect!");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (username != "" && password != "" && role == "Eye Technician")
            {
              try
                {
                    con.Open();
                    String SQL = "select count (*) from EmployeeRegister_tb where Emp_username=('" + txtUsername.Text + "') and Emp_password=('" + txtPassword.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Close();
                        Eye_Technician eye_Technician = new Eye_Technician();
                        eye_Technician.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username OR Password Incorrect!");
                    }


                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (username != "" && password != "" && role == "Worker")
            {
                try
                {
                    con.Open();
                    String SQL = "select count (*) from EmployeeRegister_tb where Emp_username=('" + txtUsername.Text + "') and Emp_password=('" + txtPassword.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Close();
                        Workshop workshop = new Workshop();
                        workshop.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username OR Password Incorrect!");
                    }

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username OR Password Incorrect!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
