using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperMarket
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENHDEN5K;Initial Catalog=smarket;Integrated Security=True");


        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from SellerTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTb1 values(" + SELID.Text + ",'" + NAMEID.Text + "'," + AGEID.Text + "," + PHONEID.Text + ",'" + PASSID.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfuly");
                con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reflectionImage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SELID.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            NAMEID.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            AGEID.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PHONEID.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            PASSID.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void SellerEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (SELID.Text == "" || NAMEID.Text == "" || AGEID.Text == "" || PHONEID.Text == "" || PASSID.Text == "")
                {
                    MessageBox.Show("Missing Informationa");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTb1 set SellerName='" + NAMEID.Text + "', SellerAge='" + AGEID.Text + "', SellerPhone='" + PHONEID.Text + "', SellerPass='" + PASSID.Text + "' where SellerID=" + SELID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Update");
                    con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SELID.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from SellerTb1 where SellerId=" + SELID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    con.Close();
                    populate();
                    SELID.Text = "";
                    NAMEID.Text = "";
                    AGEID.Text = "";
                    PHONEID.Text = "";
                    PASSID.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
