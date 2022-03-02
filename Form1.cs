using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "Admin" && txtpass.Text == "Pass")
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button11.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button7.Enabled = true;

                txtuname.Clear();
                txtpass.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter correct Login details", "Car Rental System");
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            carreg a = new carreg();
            a.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            customer b = new customer();
            b.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            rental c = new rental();
            c.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
            returncar d = new returncar();
            d.Show();
        }
        private void txtuname_TextChanged(object sender, EventArgs e)
        { }
        private void button8_Click_1(object sender, EventArgs e)
        {
            crystalcustomer r = new crystalcustomer();
            r.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {  

            crystalrental m = new crystalrental();
            m.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {  
            crystalreturn cr = new crystalreturn();
            cr.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            crystalcar f = new crystalcar();
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button11.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button7.Enabled = false;
            button10.Enabled = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure want to Logout ?", "Car Rental System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {             
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button11.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button7.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtuname.Clear();
            txtpass.Clear();
            txtuname.Focus();
        }
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want close", "Car Rental System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
