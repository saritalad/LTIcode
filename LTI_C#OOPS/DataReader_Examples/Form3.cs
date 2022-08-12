using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataReader_Examples
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=nalanda;database=dotnetp4db;integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "insert into vipulproduct(productid,productname,productdescription)values(@PID,@Pnm,@Pd)";
            SqlParameter p1 = new SqlParameter("@PID", SqlDbType.BigInt);
            SqlParameter p2 = new SqlParameter("@Pnm", SqlDbType.NVarChar);
            SqlParameter p3 = new SqlParameter("@Pd", SqlDbType.NVarChar);
            p1.Value = Convert.ToInt32(textBox1.Text);
            p2.Value = textBox2.Text;
            p3.Value = textBox3.Text;
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            con.Open();

            com.ExecuteNonQuery();
            MessageBox.Show("Record added Successfull");
            con.Close();
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select Productid,productname as 'Name',ProductDescription as 'description' from vipulproduct";
            dr = com.ExecuteReader();
            dt.Load(dr);
           
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText ="Update vipulproduct set ProductName =@pnm,productdescription=@Pd where productid=@pid";
            SqlParameter p1 = new SqlParameter("@pid", SqlDbType.BigInt);
            SqlParameter p2 = new SqlParameter("@Pnm", SqlDbType.NVarChar);
            SqlParameter p3 = new SqlParameter("@Pd", SqlDbType.NVarChar);
            p1.Value = Convert.ToInt32(textBox1.Text);
            p2.Value = textBox2.Text;
            p3.Value = textBox3.Text;
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Record Changed Successfully");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
