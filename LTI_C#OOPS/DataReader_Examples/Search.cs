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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=nalanda;database=dotnetp4db;integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Parameters.Clear();
            dt.Clear();
            con.Open(); 
            com.Connection = con;
            com.CommandText = "Select * from sarojorder where itemid=@id";
            SqlParameter p = new SqlParameter("@id", SqlDbType.BigInt);
            p.Value = Convert.ToInt32(textBox1.Text);
            com.Parameters.Add(p);
            dr = com.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
