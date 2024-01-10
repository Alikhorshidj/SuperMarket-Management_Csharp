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
            string query = "select ProdName,ProdPrice from ProduvtTb2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV2.DataSource = ds.Tables[0];
            con.Close();

        }


        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ProdDGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV2.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV2.SelectedRows[0].Cells[1].Value.ToString();
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
                Amdlbl.Text =  Grdtotal + "Rs";
            }


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
    }
}
