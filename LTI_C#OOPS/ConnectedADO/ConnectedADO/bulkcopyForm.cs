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
    public partial class bulkcopyForm : Form
    {
        public bulkcopyForm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection("Server=abc_computer;integrated Security=true;database=SaritaDb");

               
         SqlConnection con2 = new SqlConnection("Server=abc_computer;integrated Security=true;database=northwind");
      
         private void button1_Click(object sender, EventArgs e)
         {
             DataSet ds = new DataSet();
             SqlDataAdapter sda = new SqlDataAdapter("select * from _product",con1);
             sda.Fill(ds, "prod");
             SqlBulkCopy mybulkcopy = new SqlBulkCopy(con2);
             mybulkcopy.DestinationTableName = "_product";
             con2.Open();
             mybulkcopy.WriteToServer(ds.Tables["prod"]);
             MessageBox .Show ("Copied all data ");
             mybulkcopy.Close();
             con2.Close();
         }
    }
}
