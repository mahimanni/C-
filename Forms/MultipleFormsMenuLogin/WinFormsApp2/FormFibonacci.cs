using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, a, b, c;
            String s = "";
            n = Convert.ToInt32(textBox1.Text);
            a = 0; b = 1;
            s += a + " " + b + " ";
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                s += c + " ";
                a = b;
                b = c;
            }
            label2.Text = s;
        }
    }
}
