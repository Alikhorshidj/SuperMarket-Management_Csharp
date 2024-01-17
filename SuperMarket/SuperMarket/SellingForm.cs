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
using System.Text.RegularExpressions;


namespace SuperMarket
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENHDEN5K;Initial Catalog=smarket;Integrated Security=True");


        private void populate()
        {
            con.Open();
            string query = "select ProdName,ProdPriceS from ProductTb2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV2.DataSource = ds.Tables[0];
            con.Close();

        }
        private void populatebills()
        {
            con.Open();
            string query = "select * from BillTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCombo();
            SellerNamelbl.Text = Form1.Sellername;
        }

        int flag = 0;

        private void ProdDGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV2.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV2.SelectedRows[0].Cells[1].Value.ToString();
            flag = 1;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int Grdtotal = 0;
        int n = 0;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            
            if(ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Select atleast one Product");
            }
            else
            {
                
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amdlbl.Text =  ""+Grdtotal ;
            }


        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if(BillId.Text == "")
            {
                MessageBox.Show("Missing to insert Bill Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillTb1 values(" + BillId.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amdlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfuly");
                    con.Close();
                    populatebills();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(70,100));
            e.Graphics.DrawString("SellerName:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(70,120));
            e.Graphics.DrawString("Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(70,140));
            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(70,160));
            e.Graphics.DrawString("Welcome", new Font("Century Gothic", 25, FontStyle.Italic), Brushes.Black, new Point(230,230));
        }


        private void CatEdit_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProdName,ProdPrice from ProduvtTb2 where ProdCat='"+SearchCb.SelectedValue.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV2.DataSource = ds.Tables[0];
            con.Close();
        }

        private void FillCombo()
        {
            //This Metod Will bind the ComboBox with the Database
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTb1", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
           // CatCb.ValueMember = "CatName";
           //  CatCb.DataSource = dt;
                       SearchCb.ValueMember = "CatName";
                       SearchCb.DataSource = dt;

            con.Close();

        }






        private void CatDescTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CatNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
