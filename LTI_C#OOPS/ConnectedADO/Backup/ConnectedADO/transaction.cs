﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions ;
namespace ConnectedADO
{//Hint : add reference from solution explorer
    // start service MSDTC from administrative tools component service transaction 
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection("Server=nalanda;integrated Security=true;database=SaritaDb");
      //  SqlCommand com = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope s = new TransactionScope())
                {
                    using (SqlConnection con = new SqlConnection("Server=nalanda;integrated Security=true;database=SaritaDb"))
                    {
                        con.Open();
                        SqlCommand com1 = new SqlCommand();
                        com1.Connection = con;
                        com1.CommandText ="insert into employee  (empname,basic_sal)values('A R Rahman',23000.00)";

                        com1.ExecuteNonQuery();
                    }
                     using (SqlConnection con1 = new SqlConnection("Server=nalanda;integrated Security=true;database=SaritaDb"))
                    {
                        con1.Open();
                        SqlCommand com2 = new SqlCommand();
                        com2.Connection = con1;
                         com2.CommandText ="insert into students (rollno)values(8)";
                         com2.ExecuteNonQuery();
                    }
                     s.Complete();
                     MessageBox.Show("Transaction Complete");
                    }
                
                }
                
            catch(Exception ex)
            {MessageBox .Show (ex.Message );
            }
            
            }
    
    }

        }
 