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
    public partial class FormFactorial : Form
    {
        public FormFactorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,f=1;
            n= Convert.ToInt32(textBox1.Text);
            for(int i=1; i <= n; i++)
            {
                f=f*i;
            }
            label2.Text = f.ToString();
        }
    }
}
