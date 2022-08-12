using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LateBinding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Type t = typeof(Book);

            //BookAtrribute ba =(BookAtrribute) BookAtrribute.GetCustomAttributes(typeof(BookAtrribute), typeof(Book),true);
            
            foreach(Attribute a in t.GetCustomAttributes(true))
            {
                BookAtrribute b = (BookAtrribute)a;
            MessageBox.Show(b._author + " " + b._publisher);
            }
        }
    }
    [BookAtrribute("james","wrox","12/09/02")]
    public class Book
    {
    }
}