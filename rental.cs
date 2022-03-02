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
    public partial class rental : Form
    {
        public rental()
        {
            InitializeComponent();
            Autono();
            carload();
            rentalload();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0SM2B9PI\SQLEXPRESS;Initial Catalog=carrental;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;
        bool Mode = true;
        String id;

        public void Autono()
        {
            sql = "select id from rental order by id desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00000");
            }
            else
            {
                proid = ("00000");
            }
            txtid1.Text = proid.ToString();
            con.Close();


        }

        public void rentalload()
        {
            sql = "select * from rental";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
            con.Close();
        }







        public void carload()
        {
            cmd = new SqlCommand("select * from carreg", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtcarid.Items.Add(dr["regno"].ToString());

            }
            con.Close();

        }









        private void rental_Load(object sender, EventArgs e)
        {
            txtid1.Enabled = false;
        }

        private void txtcarid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from carreg where regno ='"+txtcarid.Text+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string aval;



                aval = dr["available"].ToString();
                label9.Text = aval;

                if (aval == "No")
                {
                    txtcustid.Enabled = false;
                    txtcustname.Enabled = false;
                    txtfee.Enabled = false;
                    txtdate.Enabled = false;
                    txtdue.Enabled = false;
                }
                else
                {
                    txtcustid.Enabled = true;
                    txtcustname.Enabled = true;
                    txtfee.Enabled = true;
                    txtdate.Enabled = true;
                    txtdue.Enabled = true;
                }

            }
            else
            {
                label9.Text = "Car Not Available";
                
            }
            con.Close();
        }

        private void txtcustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
            cmd = new SqlCommand("select * from customer where custid ='"+txtcustid.Text+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtcustname.Text = dr["custname"].ToString();

            }
            else
            {
                MessageBox.Show("Customer ID Not Found");
            }
            con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtid1.Text;
            string carid = txtcarid.Text;
            string custid = txtcustid.Text;
            string custname = txtcustname.Text;
            string fee = txtfee.Text;
            string date = txtdate.Value.Date.ToString("yyyy-MM-dd");
            string due = txtdue.Value.Date.ToString("yyyy-MM-dd");




            if (txtid1.Text == "")
            {
                MessageBox.Show("Enter ID");

            }
            else
            {
                if (txtcarid.Text == "")
                {
                    MessageBox.Show("Plzz Enter Car ID");
                    txtcarid.Focus();

                }
                else
                {
                    if (txtcustid.Text == "")
                    {
                        MessageBox.Show("Plzz Enter Customer ID");
                        txtcustid.Focus();

                    }
                    else
                    {
                        if (txtcustname.Text == "")
                        {
                            MessageBox.Show("Plzz Enter Customer  Name");
                            txtcustname.Focus();

                        }
                        else
                        {
                            if (txtfee.Text == "")
                            {
                                MessageBox.Show("Plzz Enter Fee");
                                txtfee.Focus();

                            }
                            else
                            {
                                if (txtdate.Text == "")
                                {
                                    MessageBox.Show("Plzz Select Date");
                                    txtdate.Focus();

                                }
                                else
                                {
                                    if (txtdue.Text == "")
                                    {
                                        MessageBox.Show("Plzz Select Due Date");
                                        txtdue.Focus();

                                    }
                                    else
                                    {




                                        sql = "insert  into rental(id,car_id,cust_id,custname,fee,date,due)values(@id,@car_id,@cust_id,@custname,@fee,@date,@due)";
                                        con.Open();
                                        cmd = new SqlCommand(sql, con);
                                        cmd.Parameters.AddWithValue("@id", id);
                                        cmd.Parameters.AddWithValue("@car_id", carid);
                                        cmd.Parameters.AddWithValue("@cust_id", custid);
                                        cmd.Parameters.AddWithValue("@custname", custname);
                                        cmd.Parameters.AddWithValue("@fee", fee);
                                        cmd.Parameters.AddWithValue("@date", date);
                                        cmd.Parameters.AddWithValue("@due", due);
                                        cmd.ExecuteNonQuery();


                                        sql1 = "update carreg set available ='No' where regno = @regno";
                                        cmd1 = new SqlCommand(sql1, con);
                                        cmd1.Parameters.AddWithValue("@regno", carid);
                                        cmd1.ExecuteNonQuery();
                                        MessageBox.Show("Record Added Successfully....");
                                        con.Close();







                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtcustid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rentalload();
            Autono();


            
           

            txtcarid.Items.Clear();
            txtcustid.Clear();
            txtcustname.Clear();
            txtfee.Clear();
           
            txtcarid.Focus();
        }

        private void txtfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcustname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
