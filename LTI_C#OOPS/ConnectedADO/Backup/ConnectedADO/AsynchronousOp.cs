using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ConnectedADO
{
    public partial class AsynchronousOp : Form
    {
        public AsynchronousOp()
        {
            InitializeComponent();
        }
       IAsyncResult res;
      SqlCommand com;
        SqlConnection con;
      
        private void Asynchronous_Load(object sender, EventArgs e)
        {
       con = new SqlConnection("Server=abc_computer;integrated Security=true;database=saritadb;Asynchronous Processing=true");
        com = new SqlCommand("WAITFOR DELAY '0:0:7';SELECT * FROM EMPLOYee",con);
                   }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!res.IsCompleted)
            {
                listBox1.Items.Clear();
                SqlDataReader dr = com.EndExecuteReader(res);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             con.Open();
            res = com.BeginExecuteReader();
        }
    }
}
