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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();


                string sql = @" select Customer_Detail.customer_id,Customer_Detail.customer_name,Bill_Detail.order_type,Bill_Detail.quantity,Bill_Detail.tatal_amount,Bill_Detail.pay_date
                             From Customer_Detail
                             inner join Bill_Detail
                             on Customer_Detail.customer_id=Bill_Detail.customer_id;";
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewreport.DataSource = dataTable;
                conn.Close();
                
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
           Empoyee frm = new Empoyee ();
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
            Log_out frm = new Log_out();
            frm.ShowDialog();
        }
    }
}
