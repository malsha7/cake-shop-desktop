using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Loging frm = new Loging();
            frm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnCoustomer_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Order frm = new Order();
            frm.ShowDialog();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Bill frm = new Bill();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            Product frm = new Product();
            frm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Empoyee frm = new Empoyee();
            frm.ShowDialog();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Add_user frm = new Add_user();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Log_out frm = new Log_out();
            frm.ShowDialog();
        }

        private void btnCoustomer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer();
            frm.ShowDialog();

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
