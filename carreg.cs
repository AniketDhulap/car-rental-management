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
    public partial class carreg : Form
    {
        public carreg()
        {
            InitializeComponent();
            Autono();
            load();
            
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
            sql = "select regno from carreg order by regno desc";
            cmd = new SqlCommand(sql,con);
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
            txtregno.Text = proid.ToString();
            con.Close();


        }

        public void load()
        {
            sql = "select * from carreg";
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
            sql = "select * from carreg where regno ='" + id + "'";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtregno.Text = dr[0].ToString();
                txtcompany.Text = dr[1].ToString();
                txtmodel.Text = dr[2].ToString();
                txtavl.Text = dr[3].ToString();
            }
            con.Close();
        }


        private void carreg_Load(object sender, EventArgs e)
        {
            txtregno.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regno = txtregno.Text;
            string company = txtcompany.Text;
            string model = txtmodel.Text;
            string aval = txtavl.Text;
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();



            if (txtregno.Text == "")
            {
                MessageBox.Show(" Plzzz Enter Car Registration Number");

            }
            else
            {
                if (txtcompany.Text == "")
                {
                    MessageBox.Show(" Plzzz Enter The Company Name");
                    txtcompany.Focus();

                }
                else
                {
                    if (txtmodel.Text == "")
                    {
                        MessageBox.Show("Plzz Enter The Model Name");
                        txtmodel.Focus();

                    }
                    else
                    {
                        if (txtavl.Text == "")
                        {
                            MessageBox.Show("Choose Available Or Not");

                        }
                        else
                        {
                            if (Mode == true)
                            {


                                sql = "insert  into carreg(regno,company,model,available)values(@regno,@company,@model,@available)";
                                con.Open();
                                cmd = new SqlCommand(sql, con);
                                cmd.Parameters.AddWithValue("@regno", regno);
                                cmd.Parameters.AddWithValue("@company", company);
                                cmd.Parameters.AddWithValue("@model", model);
                                cmd.Parameters.AddWithValue("@available", aval);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Added Successfully....");


                                txtcompany.Clear();
                                txtmodel.Clear();
                                txtavl.Items.Clear();
                                txtcompany.Focus();



                            }
                            else
                            {
                                sql = "update carreg set company = @company, model = @model,available = @available where regno = @regno";
                                con.Open();
                                cmd = new SqlCommand(sql, con);

                                cmd.Parameters.AddWithValue("@company", company);
                                cmd.Parameters.AddWithValue("@model", model);
                                cmd.Parameters.AddWithValue("@available", aval);
                                cmd.Parameters.AddWithValue("@regno", id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Updated Successfully....");
                                txtregno.Enabled = true;


                                Mode = true;

                                txtcompany.Clear();
                                txtmodel.Clear();
                                txtavl.Items.Clear();
                                txtcompany.Focus();


                            }
                            con.Close();

                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtregno.Enabled = false;
               
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from carreg where regno =@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully.....");
                con.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
            Autono();

            
            txtcompany.Clear();
            txtmodel.Clear();
            
            txtcompany.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Autono();


            txtcompany.Clear();
            txtmodel.Clear();
           
            txtcompany.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcompany_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
