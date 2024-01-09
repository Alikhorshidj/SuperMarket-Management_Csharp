using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else
            {
                if (RoleCb.SelectedItem.ToString() == "ADMIN")
                {
                    if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                    {
                        ProductForm productForm = new ProductForm();
                        this.Hide();
                        productForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Insert Wrong Username or Password");
                    }
                }
                else if (RoleCb.SelectedItem.ToString() == "SELLER")
                {
                    MessageBox.Show("You are a Seller");
                }
                else
                {
                    MessageBox.Show("You must Select a Role");

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }
    }
}
