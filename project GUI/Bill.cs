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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double total;



            if (cbordrtype.SelectedIndex == 0)
            {
                if (cboqty.SelectedIndex == 5)
                {
                    total = 1000 + 500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 6)
                {
                    total = 1000 + 750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 7)
                {
                    total = 1000 + 1000;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 1000 + 1750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }




            }
            else if (cbordrtype.SelectedIndex == 1)
            {

                if (cboqty.SelectedIndex == 5)
                {
                    total = 1500 + 500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 6)
                {
                    total = 1500 + 750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 7)
                {
                    total = 1500 + 1000;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 1500 + 1750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
            }
            else if (cbordrtype.SelectedIndex == 2)
            {

                if (cboqty.SelectedIndex == 5)
                {
                    total = 500 + 250;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 6)
                {
                    total = 500 + 500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 7)
                {
                    total = 500 + 750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 500 + 1000;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
            }
            else if (cbordrtype.SelectedIndex == 3)
            {
                if (cboqty.SelectedIndex == 5)
                {
                    total = 800 + 250;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 6)
                {
                    total = 800 + 500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 7)
                {
                    total = 800 + 750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 800 + 1000;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }

            }
            else if (cbordrtype.SelectedIndex == 4)
            {
                if (cboqty.SelectedIndex == 5)
                {
                    total = 1500 + 500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();

                }
                else if (cboqty.SelectedIndex == 6)
                {
                    total = 1750 + 750;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 7)
                {
                    total = 2000 + 1000;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 2500 + 1500;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }

            }
            else if (cbordrtype.SelectedIndex == 5)
            {
                if (cboqty.SelectedIndex == 0)
                {

                    total = 50 + 20;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 1)
                {

                    total = 50 * 2 + 20;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 2)
                {
                    total = 50 * 5 + 20;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else if (cboqty.SelectedIndex == 3)
                {

                    total = 50 * 10 + 20;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }
                else
                {

                    total = 100 + 100;
                    lbltot.Text = "Total Amount=" + total.ToString();
                    txtPayammo.Text = total.ToString();
                }


            }
            
            
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtbillno.Clear();
            txtname.Clear();
            txtcontno.Clear();
            cboqty.Text="";
            txtCusid.Text = "";
            cbordrtype.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(connectingstring);
                conn.Open();

                string sql = @"INSERT INTO Bill_Detail(bill_no,pay_cuss_name,pay_cus_contact ,quantity,pay_date,tatal_amount,order_type,customer_id )
                           VALUES('" + Convert.ToInt32(txtbillno.Text) + "','" + txtname.Text + "','" + Convert.ToInt32(txtcontno.Text) + "','" + Convert.ToDouble(cboqty.SelectedItem) + "','" + (dateorder.Value) + "','" + Convert.ToDouble(txtPayammo.Text) + "','" + cbordrtype.SelectedItem + "','" + Convert.ToInt32(txtCusid.Text) + "');";
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

                string sql = "select*from Bill_Detail;";//sql query
                SqlCommand cmd = new SqlCommand(sql, conn);//sql command object
                //SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dgcustomerbill.DataSource = dataTable;//binding
                                                      //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lblqty_Click(object sender, EventArgs e)
        {

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

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out();
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

        private void dgcustomerbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclr_Click_1(object sender, EventArgs e)
        {
            txtbillno.Text = "";
            txtcontno.Text = "";
            txtCusid.Text = "";
            txtname.Text = "";
            txtPayammo.Text = "";
            cboqty.Text = "";
            cbordrtype.Text = "";
            lbltot.Text = "";

        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (bilprintPreviewDialog.ShowDialog() == DialogResult.OK)
                bilprintDocument.Print();

        }

        private void bilprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lblbillno.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 130));
            e.Graphics.DrawString(txtbillno.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 130));
            e.Graphics.DrawString(lblcusname.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 200));
            e.Graphics.DrawString(txtname.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 200));
            e.Graphics.DrawString(lblordr.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 270));
            e.Graphics.DrawString(cbordrtype.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 270));
            e.Graphics.DrawString(lblqty.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 340));
            e.Graphics.DrawString(cboqty.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 340));
            e.Graphics.DrawString(lblpayammount.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 410));
            e.Graphics.DrawString(txtPayammo.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 410));
            e.Graphics.DrawString(lblpaydate.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 480));
            e.Graphics.DrawString(dateorder.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 480));
            e.Graphics.DrawString(lblcont.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Black, new PointF(70, 550));
            e.Graphics.DrawString(txtcontno.Text, new Font("Century Gothic", 34, FontStyle.Bold), Brushes.Blue, new PointF(500, 550));
        }
    }
}

