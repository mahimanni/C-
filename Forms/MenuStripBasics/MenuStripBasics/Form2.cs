using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripBasics
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer2.Enabled = true;//timer2 activated
            timer1.Enabled = false;//timer1 deactivated
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer1.Enabled = true;//timer1 activated
            timer2.Enabled = false;//timer2 deactivated
        }
    }
}
