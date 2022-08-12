using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataReader_Examples
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=nalanda;database=dotnetp4db;integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select Productid,productname ,ProductDescription as 'description' from vipulproduct where Productid=@pid";
            SqlParameter p = new SqlParameter("@pid", SqlDbType.BigInt);
            p.Value =Convert .ToInt32 (textBox1 .Text );
            com.Parameters.Add(p);

            dr = com.ExecuteReader();

            try
            {

                while (dr.Read())
                {

                    textBox1.Text = dr["Productid"].ToString();
                    textBox2.Text = dr["ProductName"].ToString();
                    textBox3.Text = dr["description"].ToString();

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            com.Parameters.Clear();
            con.Open();
            com.Connection = con;
            com.CommandText = "update vipulproduct set Productname=@pnm,ProductDescription=@pd where productid=@pid";
            SqlParameter p1 = new SqlParameter("@pid", SqlDbType.BigInt);
            p1.Value = Convert.ToInt32(textBox1.Text);
            SqlParameter p2 = new SqlParameter("@pnm", SqlDbType.NVarChar );
            p2.Value = textBox2.Text;
            SqlParameter p3 = new SqlParameter("@pd", SqlDbType.NVarChar);
            p3.Value = textBox3.Text;
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();

        }
    }
}
