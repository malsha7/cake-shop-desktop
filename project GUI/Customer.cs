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

namespace project_GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusid.Text = "";
            txtcusname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();


                string sql = @"INSERT INTO Customer_Detail (customer_id,customer_name,customer_address,contact_no)
                 VALUES ('" + Convert.ToInt32 (txtCusid.Text) + "','" + txtcusname.Text + "','" + txtaddress.Text + "','" + Convert.ToInt32(txtcontact.Text) + "' ); ";
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();
                string sql = "select*from Customer_Detail;";//sql query
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                                                           //SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
               dataGridViewCustomer.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order frm = new Order();
            frm.ShowDialog();

        }

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out();
            frm.ShowDialog();

        }

        private void bIlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill frm = new Bill();
            frm.ShowDialog();

        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product frm = new Product();
            frm.ShowDialog();

        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empoyee frm = new Empoyee();
            frm.ShowDialog();

        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_user frm = new Add_user();
            frm.ShowDialog();

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loging frm = new Loging();
            frm.ShowDialog();

        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.ShowDialog();

        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.ShowDialog();

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
