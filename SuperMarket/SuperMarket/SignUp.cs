using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperMarket
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENHDEN5K;Initial Catalog=smarket;Integrated Security=True");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(SELID.Text == "" || NAMEID.Text == "" || AGEID.Text == "" || PHONEID.Text == "" || PASSID.Text == "")
            {
                MessageBox.Show("Insert Values");
            }
           // else if (Convert.ToInt64(SELID.Text) <= 1000000000 || Convert.ToInt64(SELID.Text) >= 9999999999)
           // {
           //     MessageBox.Show("Your ID Not True");
           // }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into SellerTb1 values(" + SELID.Text + ",'" + NAMEID.Text + "'," + AGEID.Text + "," + PHONEID.Text + ",'" + PASSID.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SignUp Successfuly");
                    con.Close();
                    SELID.Text = "";
                    NAMEID.Text = "";
                    AGEID.Text = "";
                    PHONEID.Text = "";
                    PASSID.Text = "";
 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 rr = new Form1();
            rr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
