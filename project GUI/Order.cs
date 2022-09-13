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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

      private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();

                string sql = @"INSERT INTO Order_Detail (Order_No,Order_cus_Name ,Order_type,Ordered_Date ,Delivered_Date,customer_id)
                 VALUES ('"+ Convert.ToInt32(txtordrno.Text) + "','" + txtname.Text + "','" + cbotype.SelectedItem + "','" + dateorder.Value + "','" + datedeliver.Value + "','" + Convert.ToInt32(txtcusid.Text) + "'); ";
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                conn.Close(); MessageBox.Show("Successfully added");
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

                string sql = "select*from Order_Detail;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);
                dgcustomer.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtordrno.Clear();
            txtname.Clear();
            txtcusid.Clear();
            cbotype.Text = "";
            // DateTime date = dateorder.Value;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void pictureBoxwelcome_Click(object sender, EventArgs e)
        {

        }

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out();
            frm.ShowDialog();

        }

        private void cOUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer();
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

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
