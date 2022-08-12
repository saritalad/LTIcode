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
    public partial class ExecuteNonQury_Example : Form
    {
        public ExecuteNonQury_Example()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=abc_computer ;integrated Security=true;database=SaritaDb");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        private void ExecuteNonQury_Example_Load(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select rollno,studnm as name,courseid from students";
            dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load (dr);
            dataGridView1 .DataSource =dt;
            dr.Close ();
            con.Close ();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtroll.Clear();
            //txtname.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            com.Connection = con;
            com.CommandText = "insert into students(studnm,courseid,rollno)values(@st,@cid,@roll)";
            SqlParameter p1 = new SqlParameter("@st", SqlDbType.NVarChar);
            SqlParameter p2 = new SqlParameter("@cid", SqlDbType.BigInt);
            SqlParameter p3 = new SqlParameter("@roll", SqlDbType.BigInt);
            p1.Value = txtname.Text;
            p2.Value = Convert.ToInt32 (txtcourseid.Text);
            p3.Value = Convert.ToInt32(txtroll.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Record added successfully");
            con.Close();

        }
    }
}
