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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=nalanda;database=dotnetp4db;integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("connection Eslablished");
            com.Connection = con;
            com.CommandText = "Select * from pranjalitem";
            dr = com.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;


        }

    }
}
