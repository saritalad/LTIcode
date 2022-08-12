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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=nalanda;integrated Security=true;database=SaritaDb");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


        private void Form3_Load(object sender, EventArgs e)
        {
            com.CommandText ="Select * from Employee;select * from Students";
            com.Connection = con;
            da.SelectCommand = com; 
            da.Fill (ds,"Emp");
                    
            dataGridView1.DataSource = ds.Tables["Emp"];
            dataGridView2.DataSource = ds.Tables[1];

        }
    }
}
