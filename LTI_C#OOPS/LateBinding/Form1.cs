using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace LateBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Assembly asm;
        Type[] types;
        MethodInfo[] methods;
        ParameterInfo[] parameters;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            object obj,result;
            object[] param ={ 2, 3 };
            asm = Assembly.LoadFrom(textBox1.Text);
            types = asm.GetTypes(); //loads all types;
            foreach (Type t in types)
            {
                listBox1.Items.Add(t.FullName);
                obj = asm.CreateInstance(t.FullName);

                methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    listBox2.Items.Add(m.Name);
                    parameters = m.GetParameters();
                    result = t.InvokeMember(m.Name, BindingFlags.Public | BindingFlags.InvokeMethod| BindingFlags.Instance, null, obj, param);
                    MessageBox.Show(result.ToString());

                }
            }

        }
    }
}