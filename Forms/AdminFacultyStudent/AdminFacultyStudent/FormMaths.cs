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

namespace AdminFacultyStudent
{
    public partial class FormMaths : Form
    {
        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
        String functionName = FormStudent.mathFunction;
        public FormMaths()
        {
            InitializeComponent();
        }

        private void FormMaths_Load(object sender, EventArgs e)
        {
            //For Math functions
            if (functionName == "Sq")
            {
                label1.Text = "Square Function";
                sqFunc();
            }
            else if (functionName == "Pow")//takes 2 parameters
            {
                label1.Text = "Power Function";
                powFunc();
            }
            else if (functionName == "Min")//takes 3 parameters
            {
                label1.Text = "Minimum of three numbers";
                minFunc();
            }
            else if (functionName == "Max")//takes 4 parameters
            {
                label1.Text = "Maximum of four numbers";
                maxFunc();
            }
            else if (functionName == "Abs")
            {
                label1.Text = "Absolute of a number";
                absFunc();
            }
            else
            {
                label1.Text = "Not an valid option selected";
            }
        }

        //for numbers
        private void sqFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter number";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.ForeColor = Color.Black;
            //textBox1.Padding = new Padding(15,15,15,15);
            textBox1.Name = "textBox1";
            //textBox1.Font = new Font("Times New Roman", 18);
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

        }

        private void powFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter number";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            textBox2.Location = new Point(280, 120);
            textBox2.Text = "Enter power";
            textBox2.AutoSize = true;
            textBox2.BackColor = Color.LightGray;
            textBox2.Name = "textBox2";
            textBox2.Width = 200;
            this.Controls.Add(textBox2);
        }

        private void minFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter 1st number";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            textBox2.Location = new Point(280, 120);
            textBox2.Text = "Enter 2nd number";
            textBox2.AutoSize = true;
            textBox2.BackColor = Color.LightGray;
            textBox2.Name = "textBox2";
            textBox2.Width = 200;
            this.Controls.Add(textBox2);

            textBox3.Location = new Point(280, 160);
            textBox3.Text = "Enter 3rd number";
            textBox3.AutoSize = true;
            textBox3.BackColor = Color.LightGray;
            textBox3.Name = "textBox3";
            textBox3.Width = 200;
            this.Controls.Add(textBox3);
        }

        private void maxFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter 1st number";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            textBox2.Location = new Point(280, 120);
            textBox2.Text = "Enter 2nd number";
            textBox2.AutoSize = true;
            textBox2.BackColor = Color.LightGray;
            textBox2.Name = "textBox2";
            textBox2.Width = 200;
            this.Controls.Add(textBox2);

            textBox3.Location = new Point(280, 160);
            textBox3.Text = "Enter 3rd number";
            textBox3.AutoSize = true;
            textBox3.BackColor = Color.LightGray;
            textBox3.Name = "textBox3";
            textBox3.Width = 200;
            this.Controls.Add(textBox3);

            textBox4.Location = new Point(280, 200);
            textBox4.Text = "Enter 4th number";
            textBox4.AutoSize = true;
            textBox4.BackColor = Color.LightGray;
            textBox4.Name = "textBox4";
            textBox4.Width = 200;
            this.Controls.Add(textBox4);
        }

        private void absFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter number";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (functionName == "Sq")
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                int n = Convert.ToInt32(textBox1.Text);
                int sq = n * n;
                label1.Text = sq.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName == "Pow")
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                int n = Convert.ToInt32(textBox1.Text);
                int power = Convert.ToInt32(textBox2.Text);
                int res = 1;
                while (power > 0)
                {
                    res = res * n;
                    power--;
                }
                label1.Text = res.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName == "Min")
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int res;

                if (a <= b && a <= c)
                {
                    res = a;
                }
                else if (b <= a && b <= c)
                {
                    res = b;
                }
                else
                {
                    res = c;
                }

                label1.Text = res.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName == "Max")
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int res;

                if (a >= b && a >= c && a >= d)
                {
                    res = a;
                }
                else if (b >= a && b >= c && b >= d)
                {
                    res = b;
                }
                else if (c >= a && c >= b && c >= d)
                {
                    res = c;
                }
                else
                {
                    res = d;
                }

                label1.Text = res.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName == "Abs")
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                int n = Convert.ToInt32(textBox1.Text);

                if (n < 0)
                {
                    String s = textBox1.Text;
                    s = s.Substring(1);
                    n = Convert.ToInt32(s);
                }

                label1.Text = n.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else
            {
                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                label1.Text = "Not an option";
                label1.Width = 500;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
        }
    }
}
