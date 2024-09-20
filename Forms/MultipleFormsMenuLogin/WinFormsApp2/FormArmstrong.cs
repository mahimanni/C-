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
    public partial class FormArmstrong : Form
    {
        public FormArmstrong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,s=0,m,a;
            n = Convert.ToInt32(textBox1.Text);
            m = n;
            while (n > 0)
            {
                a = n % 10;
                s = s + a*a*a;
                n = n / 10;
            }
            if (m == s)
                label2.Text = "Armstrong number";
            else
                label2.Text = "Not a Armstrong number";
        }
    }
}
