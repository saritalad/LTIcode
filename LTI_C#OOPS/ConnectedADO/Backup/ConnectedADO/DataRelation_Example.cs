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
    public partial class DataRelation_Example : Form
    {
        public DataRelation_Example()
        {
            InitializeComponent();
        }

        private void DataRelation_Example_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'date_CAt_Product.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.date_CAt_Product.Products);
            // TODO: This line of code loads data into the 'date_CAt_Product.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.date_CAt_Product.Categories);

        }
    }
}
