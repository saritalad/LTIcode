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
    public partial class MARS : Form
    {
        public MARS()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=abc_computer;integrated Security=true;database=saritadb;MultipleActiveResultSets=true");
        SqlCommand com1 = new SqlCommand();
        SqlCommand com2 = new SqlCommand();
        SqlDataReader dr1=null,dr2=null;
        DataTable dt1= new DataTable ();
        DataTable dt2 = new DataTable();
        private void MARS_Load(object sender, EventArgs e)
        {
            con.Open();
            com1.CommandText = "select * from students";
            com2.CommandText = "select * from employee";
        //or com1=new SqlCommand( "select * from students",con);
       // com2=new SqlCommand( "select * from employee",con);
            com1.Connection = con;
            com2.Connection = con;
            dr1 = com1.ExecuteReader();
            dr2 = com2.ExecuteReader();
            dt1.Load(dr1);
            dt2.Load(dr2);
            dataGridView1.DataSource = dt1;

            dataGridView2.DataSource = dt2;
            dr1.Close();
            dr2.Close();
            con.Close();

        }
    }
}
