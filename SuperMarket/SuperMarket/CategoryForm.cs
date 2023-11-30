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

namespace SuperMarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENHDEN5K;Initial Catalog=smarket;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CategoryTb1 values(" + CatIDTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";

                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
