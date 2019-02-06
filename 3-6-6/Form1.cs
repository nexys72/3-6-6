using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            int i;
            int n;
            int l;
            k = Convert.ToInt32(textBox1.Text);
            i = Convert.ToInt32(textBox2.Text);
            n = Convert.ToInt32(Math.Pow(2, i));
            l = k * i;
            textBox3.Text = n.ToString();
            textBox4.Text = l.ToString();
        }
    }
}
