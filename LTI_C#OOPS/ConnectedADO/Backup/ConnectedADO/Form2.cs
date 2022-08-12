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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=nalanda;integrated Security=true;database=saritadb");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            com.CommandText = "Select * from students where rollno <@n";
            com.Connection = con;
            SqlParameter p1 = new SqlParameter("@n", SqlDbType.BigInt);
            p1.Value =Convert.ToInt32 (textBox1 .Text);
            com.Parameters.Add(p1);
            con.Open();
            MessageBox.Show("Connection Established");
            dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            con.Close();
        }
    }
}
