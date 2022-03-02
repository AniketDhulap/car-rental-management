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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            Autono();
            customerload();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0SM2B9PI\SQLEXPRESS;Initial Catalog=carrental;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool Mode = true;
        String id;



        public void Autono()
        {
            sql = "select custid from customer order by custid desc";
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
                proid = ("00001");
            }
            else
            {
                proid = ("00001");
            }
            txtid.Text = proid.ToString();
            con.Close();


        }


        public void customerload()
        {
            sql = "select * from customer";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
        }

        public void getid(String id)
        {
            sql = "select * from customer where custid ='" + id + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                txtaddress.Text = dr[2].ToString();
                txtmobile.Text = dr[3].ToString();
            }
            con.Close();
        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string custid = txtid.Text;
            string custname = txtname.Text;
            string address = txtaddress.Text;
            string mobile = txtmobile.Text;



            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            if (txtid.Text == "")
            {
                MessageBox.Show("Plzz Enter Customer ID");

            }
            else
            {
                if (txtname.Text == "")
                {
                    MessageBox.Show("Plzz Enter Customer Name");
                    txtname.Focus();
                    

                }
                else
                {
                    if (txtaddress.Text == "")
                    {
                        MessageBox.Show("Plzz Enter Addresss");
                        txtaddress.Focus();

                    }
                    else
                    {
                        if (txtmobile.Text == "")
                        {
                            MessageBox.Show("Enter Mobile Number");
                            txtmobile.Focus();

                        }
                        else
                        {


                            if (Mode == true)
                            {


                                sql = "insert  into customer(custid,custname,address,mobile)values(@custid,@custname,@address,@mobile)";
                                con.Open();
                                cmd = new SqlCommand(sql, con);
                                cmd.Parameters.AddWithValue("@custid", custid);
                                cmd.Parameters.AddWithValue("@custname", custname);
                                cmd.Parameters.AddWithValue("@address", address);
                                cmd.Parameters.AddWithValue("@mobile", mobile);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Added Successfully....");


                                txtname.Clear();
                                txtaddress.Clear();
                                txtmobile.Clear();
                                txtname.Focus();



                            }
                            else
                            {
                                sql = "update customer set custname = @custname, address = @address,mobile = @mobile where custid = @custid";
                                con.Open();
                                cmd = new SqlCommand(sql, con);


                                cmd.Parameters.AddWithValue("@custname", custname);
                                cmd.Parameters.AddWithValue("@address", address);
                                cmd.Parameters.AddWithValue("@mobile", mobile);
                                cmd.Parameters.AddWithValue("@custid", custid);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Updated Successfully....");
                                txtid.Enabled = true;


                                Mode = true;

                                txtname.Clear();
                                txtaddress.Clear();
                                txtmobile.Clear();
                                txtname.Focus();


                            }
                            con.Close();

                        }
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void customer_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtid.Enabled = false;

                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from customer where cusid =@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully.....");
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Autono();


            txtname.Clear();
            txtaddress.Clear();

            txtname.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerload();
            Autono();


            txtname.Clear();
            txtaddress.Clear();

            txtname.Focus();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
    }
}
