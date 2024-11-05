using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryMngtSystem
{
    public partial class FormHome : Form
    {
        System.Windows.Forms.Timer timer, timer2;
        int i = 2;
        int j = 5;
        int flag = 0;

        public static string name, category = "none", subject;
        string text;
        int textNo;
        public FormHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //adding timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 500;
            timer2.Tick += timer_Tick2;
            timer2.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //for dealing with picturebox
            if (i > 5)
            {
                i = 1;
            }
            pictureBox1.ImageLocation = @$"C:\Users\manni\source\repos\C#\Database\InventoryMngtSystem\InventoryMngtSystem\assests\s{i}.jpg";
            pictureBox1.Load();
            i += 1;

            //for dealing with progress bar
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label3.Text = $"Loading {progressBar1.Value} %";
            }
            else if (progressBar1.Value == 100)
            {
                timer.Stop();
                Form1 log = new Form1();
                log.ShowDialog();
                this.Close();
            }
        }
        private void timer_Tick2(object sender, EventArgs e)
        {
            //for blinking of the software name
            label2.Visible = !label2.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
