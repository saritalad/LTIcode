using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectedADO
{
    public partial class BindingSource_Ex : Form
    {
        public BindingSource_Ex()
        {
            InitializeComponent();
        }

        private void BindingSource_Ex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet3.Employees);

        }
    }
}
