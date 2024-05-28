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
            SearchCb.ValueMember = "CatName";
            SearchCb.DataSource = dt;

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
            string query = "select * from ProductTb2";
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
                string query = "insert into ProductTb2 values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + ","+ ProdPrice.Text + ",'"+ (Convert.ToInt32(ProdPrice.Text) + ((Convert.ToInt32(ProdPrice.Text))*20/100)) +"','" + CatCb.SelectedValue.ToString()+"')";
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
           if (MessageBox.Show("Are you want to close program", "Close Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[5].Value.ToString();

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
                    string query = "update ProductTb2 set ProdName='" + ProdName.Text + "', ProdQty='" + ProdQty.Text + "', ProdPriceM='" + ProdPrice.Text + "', ProdPriceS='"+ (Convert.ToInt32(ProdPrice.Text) + ((Convert.ToInt32(ProdPrice.Text))*20/100)) +"', ProdCat='" + CatCb.SelectedValue.ToString() + "' where ProdId=" + ProdId.Text + ";";
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

        private void ProdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from ProductTb2 where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    con.Open();
        //    string query = "select * from ProduvtTb1 where ProdCat=";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    ProdDGV.DataSource = ds.Tables[0];
        //   con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm sell = new SellingForm();
            sell.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
                if (MessageBox.Show("Are you want to close program", "Close Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.Exit();
        }
    }
}
