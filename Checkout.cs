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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Wikramarachchi_Opticians
{
    public partial class Checkout : Form
    {
        static string connectionString = @"Data Source=LAPTOP-99795JHL;Initial Catalog=Wikramarachchi_db;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Checkout()
        {
            InitializeComponent();
        }


        string pid;
        string age;
        string name;
        string lens;
        string frame;
        float lens_price;
        float frame_price;
        float servise_charge;
        float total;
        float discount;


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
        }

       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {


                if ((txtPatientID.Text == "") || (txtFullName.Text == "") || (txtAge.Text == "") || (txtServiceCharge.Text == "") || (txtGrandTotal.Text == ""))
                {
                    MessageBox.Show("Please Enter All Details");
                }

                else
                {


                    con.Open();
                    string sql = @"INSERT INTO Sales_tb(Receipt_id,P_fullName,P_id,P_age,L_price,F_price,Service_charge,Discount,GrandTotal)
                              VALUES('" + txtReceiptID.Text + "','" + txtFullName.Text + "','" + txtPatientID.Text + "','" + txtAge.Text + "','" + txtLensPrice.Text + "','" + txtFramePrice.Text + "','" + txtServiceCharge.Text + "','" + txtDiscount.Text + "','" + txtGrandTotal.Text + "')";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();


                    MessageBox.Show("All entries are successfully saved !");


                    string sqldelete = @"DELETE FROM Workshop_tb WHERE W_id='" + txtWorkID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("Sucessfully deleted !");
                 
                    con.Close();


                    Receipt receipt = new Receipt();
                    CrystalReportBill bill = new CrystalReportBill();
                    TextObject receipt_text = (TextObject)bill.ReportDefinition.Sections["Section2"].ReportObjects["ReceiptNo"];
                    receipt_text.Text = txtReceiptID.Text;
                    TextObject patient_text = (TextObject)bill.ReportDefinition.Sections["Section2"].ReportObjects["id"];
                    patient_text.Text = txtPatientID.Text;
                    TextObject name_text = (TextObject)bill.ReportDefinition.Sections["Section2"].ReportObjects["name"];
                    name_text.Text = txtFullName.Text;
                    TextObject age_text = (TextObject)bill.ReportDefinition.Sections["Section2"].ReportObjects["age"];
                    age_text.Text = txtAge.Text;

                    TextObject lens_text = (TextObject)bill.ReportDefinition.Sections["Section3"].ReportObjects["lensprice"];
                    lens_text.Text = txtLensPrice.Text;
                    TextObject fram_text = (TextObject)bill.ReportDefinition.Sections["Section3"].ReportObjects["frameprice"];
                    fram_text.Text = txtFramePrice.Text;
                    TextObject servise_text = (TextObject)bill.ReportDefinition.Sections["Section3"].ReportObjects["servisecharge"];
                    servise_text.Text = txtServiceCharge.Text;
                    TextObject discount_text = (TextObject)bill.ReportDefinition.Sections["Section3"].ReportObjects["discount"];
                    discount_text.Text = txtDiscount.Text;
                    TextObject total_text = (TextObject)bill.ReportDefinition.Sections["Section3"].ReportObjects["total"];
                    total_text.Text = txtGrandTotal.Text;

                    receipt.crystalReportViewerBill.ReportSource = bill;

                    receipt.Show();


                    txtReceiptID.Clear();
                    txtFullName.Clear();
                    txtPatientID.Clear();
                    txtAge.Clear();
                    txtLensPrice.Clear();
                    txtFramePrice.Clear();
                    txtServiceCharge.Clear();
                    txtDiscount.Clear();
                    txtGrandTotal.Clear();
                    txtWorkID.Clear();

                  



                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                txtPatientID.Text = dgvView.Rows[e.RowIndex].Cells["P_id"].FormattedValue.ToString();
                txtFullName.Text = dgvView.Rows[e.RowIndex].Cells["P_fullName"].FormattedValue.ToString();
                txtWorkID.Text = dgvView.Rows[e.RowIndex].Cells["W_id"].FormattedValue.ToString();

            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            AutoGenerateID();

            try
            {

                string SQL = @"SELECT P_fullName,P_id,W_id FROM Workshop_tb";

                SqlDataAdapter ada = new SqlDataAdapter(SQL, con);
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

        public void AutoGenerateID()
        {
            String Receiptid;
            String query = @"SELECT Receipt_id FROM Sales_tb order by Receipt_id  Desc";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                Receiptid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                Receiptid = ("001");
            }
            else
            {
                Receiptid = ("001");
            }
            con.Close();
            txtReceiptID.Text = Receiptid.ToString();
        }

      

       

       
        



        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if ((txtLensPrice.Text == "") || (txtFramePrice.Text == ""))
                {


                    servise_charge = float.Parse(txtServiceCharge.Text);
                    discount = float.Parse(txtDiscount.Text);
                    total = (servise_charge - discount);
                    txtGrandTotal.Text = Convert.ToString(total);
                }
                else
                {
                    lens_price = float.Parse(txtLensPrice.Text);
                    frame_price = float.Parse(txtFramePrice.Text);
                    servise_charge = float.Parse(txtServiceCharge.Text);

                    discount = float.Parse(txtDiscount.Text);
                    total = (servise_charge + frame_price + lens_price - discount);
                    txtGrandTotal.Text = Convert.ToString(total);
                }
            }
            catch (Exception ex)
            {

                txtGrandTotal.Clear();
            }
        }

        private void txtLensPrice_Validating_1(object sender, CancelEventArgs e)
        {

            if (txtLensPrice.Text.Any(char.IsDigit))


            {
                errorProviderCheckout.SetError(txtFramePrice, null);
            }
            else
            {


                MessageBox.Show("Please Enter Only Digits..!");
            }
        }

        private void txtFramePrice_Validating_1(object sender, CancelEventArgs e)
        {

            if (txtFramePrice.Text.Any(char.IsDigit) && txtLensPrice.Text == "")


            {
                errorProviderCheckout.SetError(txtFramePrice, null);
            }
            else
            {


                MessageBox.Show("Please Enter Only Digits..!");
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Sql = @"SELECT P_fullName,W_id,P_id FROM Workshop_tb WHERE P_fullName like'" + txtFullName.Text + "%'";
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

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string query = "SELECT * FROM Workshop_tb WHERE P_id = " + txtPatientID.Text;
                string get_lens_id = "SELECT * FROM Workshop_tb WHERE P_id =" + txtPatientID.Text;
                string get_frame_id = "SELECT * FROM Workshop_tb WHERE P_id =" + txtPatientID.Text;

                SqlCommand chek = new SqlCommand(query, con);
                con.Open();
                SqlDataReader check_read = chek.ExecuteReader();
                check_read.Read();

                pid = Convert.ToString(check_read["P_id"]);
                name = Convert.ToString(check_read["P_fullname"]);
                age = Convert.ToString(check_read["P_age"]);

                txtAge.Text = age;

                check_read.Close();


                SqlCommand chek_1 = new SqlCommand(get_lens_id, con);
                SqlDataReader check_reader_1 = chek_1.ExecuteReader();
                check_reader_1.Read();
                lens = Convert.ToString(check_reader_1["L_id"]);
                check_reader_1.Close();


                SqlCommand chek_2 = new SqlCommand(get_frame_id, con);
                SqlDataReader check_reader_2 = chek_2.ExecuteReader();
                check_reader_2.Read();
                frame = Convert.ToString(check_reader_2["F_id"]);
                check_reader_2.Close();


                try
                {

                    string get_frame_price = "SELECT * FROM Frame_tb WHERE F_id = " + frame;


                    SqlCommand chek_3 = new SqlCommand(get_frame_price, con);
                    SqlDataReader check_reader_3 = chek_3.ExecuteReader();
                    check_reader_3.Read();
                    string frame_1 = Convert.ToString(check_reader_3["F_price"]);
                    check_reader_3.Close();

                    txtFramePrice.Text = frame_1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selected frame is unavilable");
                }

                try
                {
                    string get_lens_price = "SELECT * FROM Lens_tb WHERE L_id = " + lens;

                    SqlCommand chek_4 = new SqlCommand(get_lens_price, con);
                    SqlDataReader check_reader_4 = chek_4.ExecuteReader();
                    check_reader_4.Read();
                    string lens_1 = Convert.ToString(check_reader_4["L_price"]);
                    check_reader_4.Close();

                    txtLensPrice.Text = lens_1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selected lens is unavilble");
                }


                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
    
}
