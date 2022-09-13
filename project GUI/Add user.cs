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
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();


                string sql = @"INSERT INTO Add_User (employee_id,usrname,password)
                 VALUES ('" + txtEId.Text + "','" + txtUsername.Text + "','" +txtPassword.Text+ "' ); ";
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                conn.Close();
                 MessageBox.Show("Successfully added");
            }
            catch (Exception ex)
            {                throw ex;
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
                string sql = "select*from Add_User;";//sql query
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                                                           //SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewAdduser.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEId.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";

        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order frm = new Order();
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

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out();
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

        private void menuStriplogout_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.ShowDialog();
        }

        private void Add_user_Load(object sender, EventArgs e)
        {

        }
    }
}
