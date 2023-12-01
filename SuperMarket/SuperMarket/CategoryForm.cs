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
            //try
            //{
                con.Open();
                string query = "insert into CategoryTb1 values(" + CatIDTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfuly");
                con.Close();
                populate();

            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void populate()
        {
            con.Open();
            string query = "select * from CategoryTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIDTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIDTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoryTb1 where CatId=" + CatIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CatEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIDTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "" )
                {
                    MessageBox.Show("Missing Informationa");
                }
                else
                {
                    con.Open();
                    string query = "update CategoryTb1 set CatName='" + CatNameTb.Text + "', CatDesc='" + CatDescTb.Text + "' where CatId=" + CatIDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Update");
                    con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
