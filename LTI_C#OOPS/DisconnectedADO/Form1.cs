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
        public CurrencyManager cm = null;
        public SqlCommandBuilder cb;
        SqlConnection con = new SqlConnection("Server=abccomputer;Database=synergeticsDb;Integrated security=true");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select customerId,ContactName,city,country from customers";
            da.SelectCommand = com;
            da.Fill(ds,"Cust");
            cb = new SqlCommandBuilder(da);
            dt = new DataTable();
            dt = ds.Tables[0];
           
          //  myCurrencyManager = (CurrencyManager)this.BindingContext[dt];
            grid.DataSource = ds.Tables["Cust"];
             cm = (CurrencyManager)this.grid.BindingContext[this.grid.DataSource, this.grid.DataMember];
         
            textBox1.DataBindings.Add("text", ds.Tables[0], "contactname");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = cm.List[1] as DataRowView;
            if (dataRowView != null)
            {
                DataRow dataRow = dataRowView.Row;
                Console.WriteLine(dataRow["city"].ToString());
            }
        }
    }
}
