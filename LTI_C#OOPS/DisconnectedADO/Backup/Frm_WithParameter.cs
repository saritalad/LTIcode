using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DisconnectedADO
{
    public partial class Frm_WithParameter : Form
    {
        public Frm_WithParameter()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=abc_computer;Database=northwind;Integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "select * from customers where city=@cty";
            SqlParameter p1 = new SqlParameter("@cty", SqlDbType.NVarChar);
            p1.Value = comboBox1.Text;
            com.Parameters.Add(p1);
            da.SelectCommand = com;
            da.Fill(ds, "cust");
            dataGridView1.DataSource = ds.Tables[0];
                          
        }

        private void Frm_WithParameter_Load(object sender, EventArgs e)
        {
 com.Connection = con;
 com.CommandText = "select city from customers";
 da.SelectCommand = com;
 da.Fill(ds, "cust");
 comboBox1.DataSource = ds.Tables[0];
 comboBox1.DisplayMember = "City";
 comboBox1.ValueMember = "city";


        }
    }
}
