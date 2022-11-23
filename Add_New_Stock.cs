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
  
    public partial class Add_New_Stock : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Add_New_Stock()
        {
            InitializeComponent();
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager manager = new Manager();
            manager.Show();
        }


        private void Add_New_Item_Load(object sender, EventArgs e)
        {
            AutoGenerateLensID();
            AutoGenerateFrameID();
        }


        public void AutoGenerateLensID()
        {
            String LensId;
            String query = "select L_id from Lens_tb order by  L_id Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                LensId = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                LensId = ("001");
            }
            else
            {
                LensId = ("001");
            }
            con.Close();
            txtLensID.Text = LensId.ToString();
        }

        public void AutoGenerateFrameID()
        {
            String frameId;
            String query = "select F_id from Frame_tb order by  F_id Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                frameId = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                frameId = ("001");
            }
            else
            {
                frameId = ("001");
            }
            con.Close();
            txtframeID.Text = frameId.ToString();
        }
        private void btnLensAdd_Click(object sender, EventArgs e)
        {

            if (txtLensID.Text == "" || txtLensTpye.Text == "" || txtPurchasePrice.Text == "" || txtLensPrice.Text == "" || txtLensColor.Text == "" || txtLensQuantity.Text == "" )
            {
                MessageBox.Show("please fill all field!", ("texbox validation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();

                    String sql = @"insert into Lens_tb(L_id,L_type,Pur_price,L_price,L_color,L_quantity) values('" + txtLensID.Text + "','" + txtLensTpye.Text + "','" + txtPurchasePrice.Text + "','" + txtLensPrice.Text + "','" + txtLensColor.Text + "','" + txtLensQuantity.Text + "')";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("sucessfuly record");
                    con.Close();




                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnFrameAdd_Click(object sender, EventArgs e)
        {

            if (txtframeID.Text == "" || txtFrameTpye.Text == "" || txtFramePurchasePrice.Text == "" || txtFramePrice.Text == "" || txtFrameSize.Text == "" || txtFrameColor.Text == "" || txtFrameQuantity.Text == "" )
            {
                MessageBox.Show("please fill all field!", ("texbox validation"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();

                    String sql = @"insert into Frame_tb(F_id,F_type,Pur_price,F_price,F_size,F_color,F_quantity) values('" + txtframeID.Text + "','" + txtFrameTpye.Text + "','" + txtFramePurchasePrice.Text + "','" + txtFramePrice.Text + "','" + txtFrameSize.Text + "','" + txtFrameColor.Text + "','" + txtFrameQuantity.Text + "')";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("sucessfuly record");
                    con.Close();




                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLensID.Text = "";
            txtLensTpye.Text = "";
            txtPurchasePrice.Text = "";
            txtLensPrice.Text = "";
            txtLensColor.Text = "";
            txtLensQuantity.Text = "";
            
            txtframeID.Text = "";
            txtFrameTpye.Text = "";
            txtFramePurchasePrice.Text = "";
            txtFramePrice.Text = "";
            txtFrameSize.Text = "";
            txtFrameColor.Text = "";
            txtFrameQuantity.Text = "";
          
        }

        private void txtPurchasePrice_Validating(object sender, CancelEventArgs e)
        {

            if (txtPurchasePrice.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtPurchasePrice, null);
            }
            else
            {
                txtPurchasePrice.Focus();
                errorProviderANI.SetError(txtPurchasePrice, "Please enter only digits !");
            }
        }

        private void txtFramePurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtFramePurchasePrice.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtFramePurchasePrice, null);
            }
            else
            {
                txtFramePurchasePrice.Focus();
                errorProviderANI.SetError(txtFramePurchasePrice, "Please enter only digits !");
            }
        }

        private void txtLensPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtLensPrice.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtLensPrice, null);
            }
            else
            {
                txtLensPrice.Focus();
                errorProviderANI.SetError(txtLensPrice, "Please enter only digits !");
            }
        }

        private void txtFramePrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtFramePrice.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtFramePrice, null);
            }
            else
            {
                txtFramePrice.Focus();
                errorProviderANI.SetError(txtFramePrice, "Please enter only digits !");
            }
        }

        private void txtLensQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtFrameQuantity.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtFrameQuantity, null);
            }
            else
            {
                txtFrameQuantity.Focus();
                errorProviderANI.SetError(txtFrameQuantity, "Please enter only digits !");
            }
        }

        private void txtFrameQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtFrameQuantity.Text.Any(char.IsDigit))


            {
                errorProviderANI.SetError(txtFrameQuantity, null);
            }
            else
            {
                txtFrameQuantity.Focus();
                errorProviderANI.SetError(txtFrameQuantity, "Please enter only digits !");
            }
        }
    }
}
