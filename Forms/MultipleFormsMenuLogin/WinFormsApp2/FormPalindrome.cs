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
    public partial class FormPalindrome : Form
    {
        public FormPalindrome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,m;
            n = Convert.ToInt32(textBox1.Text);
            m = n;
            int a, r=0;
            while (n > 0)
            {
                a = n % 10;
                r = r * 10 + a;
                n = n / 10;
            }
            if (r == m)
                label2.Text = "Palindrome Number";
            else
                label2.Text = "Not a Palindrome Number";
        }
    }
}
