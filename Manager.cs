using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wikramarachchi_Opticians
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Registration register_Employee = new Employee_Registration();
            register_Employee.Show();
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_View view_Employee = new Employee_View();
            view_Employee.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Edit edit_Employee = new Employee_Edit();
            edit_Employee.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Delete delete_Employee = new Employee_Delete();
            delete_Employee.Show();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_New_Stock add_New_Item = new Add_New_Stock();
            add_New_Item.Show();
        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Stock add_New_Stock = new Edit_Stock();
            add_New_Stock.Show();
        }

        private void btnDeleteFrame_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete_Frame delete_Frame = new Delete_Frame();
            delete_Frame.Show();
        }

        private void btnDeleteLens_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete_Lens delete_Lens = new Delete_Lens();
            delete_Lens.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Close();
            Report report = new Report();
            report.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
