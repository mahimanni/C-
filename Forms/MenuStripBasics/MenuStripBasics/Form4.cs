using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MenuStripBasics
{
    public partial class Form4 : Form
    {
        System.Windows.Forms.Timer timer,timer2,timer3;
        Label label1, label2, label3;
        int state = 0; // State to track which light is currently on: 0=Red, 1=Yellow, 2=Green
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //adding labels
            label1 = new Label();
            label1.Location = new Point(300, 200);
            label1.Size = new Size(100, 50);
            label1.BackColor = Color.Red;
            this.Controls.Add(label1);

            label2 = new Label();
            label2.Location = new Point(300, 250);
            label2.Size = new Size(100, 50);
            label2.BackColor = Color.Yellow;
            this.Controls.Add(label2);

            label3 = new Label();
            label3.Location = new Point(300, 300);
            label3.Size = new Size(100, 50);
            label3.BackColor = Color.Green;
            this.Controls.Add(label3);

            //adding timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Code to execute on every tick (e.g., updating a label)
            switch (state)
            {
                case 0: // Red light
                    label1.Visible = true;  // Red is on
                    label2.Visible = false; // Yellow is off
                    label3.Visible = false; // Green is off
                    break;
                case 1: // Yellow light
                    label1.Visible = false; // Red is off
                    label2.Visible = true;  // Yellow is on
                    label3.Visible = false; // Green is off
                    break;
                case 2: // Green light
                    label1.Visible = false; // Red is off
                    label2.Visible = false; // Yellow is off
                    label3.Visible = true;  // Green is on
                    break;
            }

            // Increment the state and wrap it around (0 -> 1 -> 2 -> 0)
            state = (state + 1) % 3;
        }
    }
}
