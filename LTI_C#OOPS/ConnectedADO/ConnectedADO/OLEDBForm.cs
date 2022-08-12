using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;



namespace ConnectedADO
{
    public partial class OLEDBForm : Form
    {
        public OLEDBForm()
        {
            InitializeComponent();
        }
       OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Z:\\ConnectedADO\\ConnectedADO\\mydb.accdb");
   
 OleDbCommand com=new OleDbCommand ();
        OleDbDataAdapter da=new OleDbDataAdapter ();
        DataSet ds=new DataSet ();

        private void OLEDBForm_Load(object sender, EventArgs e)
        {
            con.Open ();
            MessageBox .Show ("Connection Established");
        }

    
    
    }
}
