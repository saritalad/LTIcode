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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=abc_computer;Database=northwind;Integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select * from customers";
            da.SelectCommand = com;
            da.Fill(ds,"Cust");
            dataGridView1.DataSource = ds.Tables["Cust"];

        }
    }
}
