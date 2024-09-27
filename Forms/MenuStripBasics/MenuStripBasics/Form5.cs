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

namespace MenuStripBasics
{
    public partial class Form5 : Form
    {
        private System.Windows.Forms.Timer timer;
        System.Windows.Forms.Label label1;
        int i = 50;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1 = new System.Windows.Forms.Label();
            label1.Location = new Point(50, 200);
            label1.Text = "CAR";
            label1.BackColor = Color.DarkBlue;
            label1.ForeColor = Color.White;
            label1.Font = new Font("Times New Roman", 20);
            label1.Size = new Size(110, 50);
            this.Controls.Add(label1);


            timer = new System.Windows.Forms.Timer(); // Initialize the Timer
            timer.Interval = 1000;// Set the interval to 1000 milliseconds (1 second)
            timer.Tick += Timer_Tick;// Attach the Tick event to a handler method
        }

        // Event handler that runs every time the Tick event is raised (every second)
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Code to execute on every tick (e.g., updating a label)
            //label1.Text = DateTime.Now.ToString("hh:mm:ss tt");

            //int winHeight = this.Height;
            int winWidth = this.Width;

            label1.Location = new Point(i, 200);
            if (i <= winWidth)
                i += 50;
            else
                i = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();//start the timer
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();//stop the timer
        }
    }
}
