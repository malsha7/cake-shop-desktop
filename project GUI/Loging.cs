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
    public partial class Loging : Form
    {
        
        public Loging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string connectingstring = "";
            connectingstring = "Data Source=localhost\\SQLEXPRESS;Database=jays_art;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connectingstring);
            conn.Open();
            string Uname = txtUser_name.Text;
            string Password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select usrname,password from Add_User where usrname= '" + txtUser_name.Text + "' and  password='" + txtPassword.Text + "'",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

               
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login Please Enter Correct Username and Password");
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }
    }
}
