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

namespace carrental
{
    public partial class returncar : Form
    {
        public returncar()
        {
            InitializeComponent();
            returnload();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0SM2B9PI\SQLEXPRESS;Initial Catalog=carrental;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;




        public void returnload()
        {
            sql = "select * from returncar";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3],dr[4],dr[5]);
            }
            con.Close();
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                
            {

                cmd = new SqlCommand("select car_id,cust_id,date,due,DATEDIFF(dd,due,GETDATE())as elap from rental where car_id ='"+txtcarid.Text+"'            ",con );
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcustid.Text = dr["cust_id"].ToString();
                    txtdate.Text = dr["due"].ToString();

                    string elap = dr["elap"].ToString();
                    int elapped = int.Parse(elap);
                    txtelp.Text = (elap);
                    if (elapped > 0)
                    {
                        
                        int fine = elapped * 100;
                        txtfine.Text = fine.ToString();
                    }
                    else
                    {
                        txtfine.Text = "0";
                        txtfine.Text = "0";
                    }
                    con.Close();

                }
                con.Close();
            }

        }

        private void returncar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string carid = txtcarid.Text;
            string custid = txtcustid.Text;
            string date = txtdate.Text;
            string elp = txtelp.Text;
            string fine = txtfine.Text;



            if (txtcarid.Text == "")
            {
                MessageBox.Show("Plzz Select Car ID");
                txtcarid.Focus();

            }
            else
            {
                if (txtcustid.Text == "")
                {
                    MessageBox.Show("Enter Cust ID");
                    txtcustid.Focus();

                }
                else
                {
                    if (txtdate.Text == "")
                    {
                        MessageBox.Show("Enter Date");
                        txtdate.Focus();

                    }
                    else
                    {
                        if (txtelp.Text == "")
                        {
                            MessageBox.Show("Enter Elapsed Date");
                            txtelp.Focus();

                        }
                        else
                        {
                            if (txtfine.Text == "")
                            {
                                MessageBox.Show("Enter Fine");
                                txtfine.Focus();

                            }
                            else
                            {



                                sql = "insert  into returncar(car_id,cust_id,date,elp,fine)values(@car_id,@cust_id,@date,@elp,@fine)";
                                con.Open();
                                cmd = new SqlCommand(sql, con);

                                cmd.Parameters.AddWithValue("@car_id", carid);
                                cmd.Parameters.AddWithValue("@cust_id", custid);
                                cmd.Parameters.AddWithValue("@date", date);
                                cmd.Parameters.AddWithValue("@elp", elp);
                                cmd.Parameters.AddWithValue("@fine", fine);


                                sql1 = "update carreg set available ='Yes' where regno = @regno";
                                cmd1 = new SqlCommand(sql1, con);
                                cmd1.Parameters.AddWithValue("@regno", carid);
                                cmd1.ExecuteNonQuery();



                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Added Successfully....");
                                con.Close();

                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnload();
           

            txtcarid.Clear();
            txtcustid.Clear();
            txtdate.Clear();
            txtelp.Clear();
            txtfine.Clear();

            txtcarid.Focus();
        }

        private void txtcustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
