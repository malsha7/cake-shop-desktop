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
    public partial class Empoyee : Form
    {
        public Empoyee()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();
                string sql = "select*from Employee_Detail;";//sql query
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                                                           //SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dgemployee.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btncal_Click(object sender, EventArgs e)
        {

            double workdays;
            double salary;
            workdays = Convert.ToDouble(txtwrkdays.Text);

            if (workdays >= 25)
            {

                salary = workdays * 1000 + 5000;

            }
            else if (workdays >= 15)
            {

                salary = workdays * 1000 + 2500;

            }
            else
            {

                salary = workdays * 1000 + 1000;

            }
            lblsalary.Text = "Salary=" + salary.ToString();
    }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();


                string sql = @"INSERT INTO Employee_Detail (employee_id,employee_name,working_day)
                 VALUES ('" + Convert.ToInt32 (txtemid.Text)+ "','" + txtemname.Text + "','" + txtwrkdays.Text + "' ); ";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtemid.Text = "";
            txtemname.Text = "";
            txtwrkdays.Text = "";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out();
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
    }
}
