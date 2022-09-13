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
    public partial class Log_out : Form
    {
        public Log_out()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
         if  ( MessageBox.Show("Do you want to log out","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
         else
            {
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.ShowDialog();
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

        private void pictureBoxwelcome_Click(object sender, EventArgs e)
        {

        }

        private void Log_out_Load(object sender, EventArgs e)
        {

        }
    }
}
