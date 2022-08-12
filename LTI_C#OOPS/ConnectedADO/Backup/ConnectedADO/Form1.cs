using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ConnectedADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection("Server=abc_computer;integrated Security=true;database=SaritaDb");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Connection Established");
            com.CommandText = "Select * from students";
            com.Connection = con;
            dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText = "select * from Students;select * from employee";
         //   com.CommandText = "select * from Students"; 
            com.Connection = con;
            dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                MessageBox.Show("Student Id " + dr[0].ToString() + 
                      "Name" + dr[1].ToString());

            }
            bool result = dr.NextResult();
            if (result == true)
                MessageBox.Show("yes more records");
            while (dr.Read())
            {
                MessageBox.Show("Emp details " + dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());

            }

            dr.Close();
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32 (textBox1.Text);
            SqlCommand delcom = new SqlCommand("deletemp", con);
            delcom.CommandType = CommandType.StoredProcedure;
           delcom.Parameters.Add("@empno", d);
           con.Open();
                delcom.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted successfully");
                        con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText ="select count(*) from students";
    int c=  Convert .ToInt32 (  com.ExecuteScalar ());
     MessageBox .Show ("Total No of students "+c.ToString ());
     con.Close();
        }
    }
}
