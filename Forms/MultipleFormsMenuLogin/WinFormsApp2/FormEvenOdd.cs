using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormEvenOdd : Form
    {
        public FormEvenOdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            if (n % 2 == 0)
            {
                label2.Text = "Even Number";
            }
            else
            {
                label2.Text = "Odd Number";
            }
        }
    }
}
