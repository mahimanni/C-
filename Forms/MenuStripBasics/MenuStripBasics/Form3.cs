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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label3.Visible = false;
                label2.Visible = false;
                label1.Visible = true;
            }
            timer2.Enabled = true;
            timer1.Enabled = false;
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
            }
            timer3.Enabled = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval <= 1000)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
            }
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }
    }
}
