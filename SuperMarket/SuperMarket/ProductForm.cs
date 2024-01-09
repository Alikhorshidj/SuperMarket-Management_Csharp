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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENHDEN5K;Initial Catalog=smarket;Integrated Security=True");

        private void FillCombo()
        {
          //This Metod Will bind the ComboBox with the Database
          con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTb1", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
          con.Close();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from ProduvtTb2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void ProdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProduvtTb2 values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + ","+ ProdPrice.Text +",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfuly");
                con.Close();
                populate();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



















        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void ProdEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "" || CatCb.Text == "")
                {
                    MessageBox.Show("Missing Informationa");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTb1 set ProdName='" + ProdName.Text + "', ProdQty='" + ProdQty.Text + "', ProdPrice='" + ProdPrice.Text + "', ProdCat='" + CatCb.SelectedValue.ToString() + "' where ProdId=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Update");
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
