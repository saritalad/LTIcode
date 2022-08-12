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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=nalanda;integrated Security=true;database=SaritaDb");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Form5_Load(object sender, EventArgs e)
        {
            com.CommandText = "Select * from Employee";
            com.Connection = con;
            da.SelectCommand = com;
            da.Fill(ds, "Ëmp");
            dataGridView1.DataSource = ds.Tables["Ëmp"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
         com.Parameters.Clear();
            com.CommandText ="Insert into Employee(EmpName,basic_sal)Values(@Empnm,@empSal)";
                com.Connection =con;
                SqlParameter p1 = new SqlParameter("@EmpNm", SqlDbType.NVarChar);
                SqlParameter p2 = new SqlParameter("@EmpSal", SqlDbType.Decimal);
                p1.Value = textBox2.Text;
                p2.Value = Convert.ToDecimal(textBox3.Text);
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");
                con.Close();
                dataGridView1.Refresh();


        }
    }
}
