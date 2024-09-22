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

namespace DynamicTextBoxes
{
    public partial class FormFunction : Form
    {
        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
        String functionName = Form1.value;

        public FormFunction()
        {
            InitializeComponent();
        }

        private void FormFunction_Load(object sender, EventArgs e)
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
            //For string functions
            else if (functionName == "Length")
            {
                label1.Text = "Length Function";
                LengthFunc();
            }
            else if (functionName == "ToUpper")
            {
                label1.Text = "ToUpper Function";
                ToUpperFunc();
            }
            else if (functionName == "Substring")//takes 2 parameters
            {
                label1.Text = "Substring till the specified position";
                SubstringFunc();
            }
            else if (functionName == "Replace")//takes 3 parameters
            {
                label1.Text = "Replace character in a String";
                ReplaceCharFunc();
            }
            else if (functionName == "CountChars")
            {
                label1.Text = "Count alphabets, numbers, special characters";
                CountCharsFunc();
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

            /*// Creating Button using Button class
            System.Windows.Forms.Button find = new System.Windows.Forms.Button();
            find.Location = new Point(310, 130);// Set the location of the button
            find.Text = "Find";// Set text inside the button
            find.AutoSize = true;// Set the AutoSize property of the button
            find.BackColor = Color.DarkBlue;// Set the background color of the button
            find.ForeColor = Color.White;
            find.Padding = new Padding(5);// Set the padding of the button
            find.Font = new Font("Times New Roman", 18);//can be set to "French Script MT"
            find.Name = "find";
            //find.Click += find_Click;
            // Add this Button to form
            this.Controls.Add(find);*/  
        }
        /*private void find_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();
            int n = Convert.ToInt32(textBox1.Text);
            int sq = n * n;
            label1.Text = sq.ToString();
            label1.Location = new Point(350, 150);
            this.Controls.Add(label1);
        }*/

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

        //for strings
        private void LengthFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter string";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);
        }
        private void ToUpperFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter string";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);
        }
        private void SubstringFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter string";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            textBox2.Location = new Point(280, 120);
            textBox2.Text = "Enter position upto which you want the string";
            textBox2.AutoSize = true;
            textBox2.BackColor = Color.LightGray;
            textBox2.Name = "textBox2";
            textBox2.Width = 200;
            this.Controls.Add(textBox2);
        }
        private void ReplaceCharFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter string";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            textBox2.Location = new Point(280, 120);
            textBox2.Text = "Enter character to replace";
            textBox2.AutoSize = true;
            textBox2.BackColor = Color.LightGray;
            textBox2.Name = "textBox2";
            textBox2.Width = 200;
            this.Controls.Add(textBox2);

            textBox3.Location = new Point(280, 160);
            textBox3.Text = "Enter replacing character";
            textBox3.AutoSize = true;
            textBox3.BackColor = Color.LightGray;
            textBox3.Name = "textBox3";
            textBox3.Width = 200;
            this.Controls.Add(textBox3);
        }
        private void CountCharsFunc()
        {
            textBox1.Location = new Point(280, 80);
            textBox1.Text = "Enter string";
            textBox1.AutoSize = true;
            textBox1.BackColor = Color.LightGray;
            textBox1.Name = "textBox1";
            textBox1.Width = 200;
            this.Controls.Add(textBox1);
        }


        //button
        private void button1_Click(object sender, EventArgs e)
        {
            if (functionName == "Sq")
            {
                Label label1 = new Label();
                int n = Convert.ToInt32(textBox1.Text);
                int sq = n * n;
                label1.Text = sq.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName == "Pow")
            {
                Label label1 = new Label();
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
            else if(functionName == "Min")
            {
                Label label1 = new Label();
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int res;

                if(a<=b && a <= c)
                {
                    res = a;
                }
                else if (b<= a && b <= c)
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
            else if(functionName == "Max")
            {
                Label label1 = new Label();
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int res;

                if (a >= b && a >= c && a>=d)
                {
                    res = a;
                }
                else if (b >= a && b >= c && b>=d)
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
            else if(functionName == "Abs")
            {
                Label label1 = new Label();
                int n = Convert.ToInt32(textBox1.Text);

                if (n < 0)
                {
                    String s= textBox1.Text;
                    s = s.Substring(1);
                    n = Convert.ToInt32(s);
                }

                label1.Text = n.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName=="Length")
            {
                Label label1 = new Label();
                string str = textBox1.Text;

                str += " ";
                int last = str.LastIndexOf(" ");
                int len = 0;
                while (len < last)
                {
                    len++;
                }

                label1.Text = len.ToString();
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName =="ToUpper")
            {
                Label label1 = new Label();
                string str = textBox1.Text;
                string s = "";

                int i = 0;
                while (i < str.Length)
                {
                    if (str[i]>=97 && str[i]<=122)
                     s += (char)(str[i] - 32);
                    else
                     s += str[i];
                    i++;
                }

                label1.Text = s;
                label1.Width = 400;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName =="Substring")
            {
                Label label1 = new Label();
                string str = textBox1.Text;
                int n = Convert.ToInt32(textBox2.Text);
                string s = "";

                int i = 0;
                while (i < n)
                {
                    s += str[i];
                    i++;
                }

                label1.Text = s;
                label1.Width = 800;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName =="Replace")
            {
                Label label1 = new Label();
                string str = textBox1.Text;
                string ch = textBox2.Text;
                string newch = textBox3.Text;

                string s = "";

                int i = 0;
                while (i < str.Length)
                {
                    if (str[i].ToString() == ch){
                        s += newch;
                    }
                    else
                    {
                        s += str[i];
                    }
                    i++;
                }

                label1.Text = s;
                label1.Width = 800;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
            else if (functionName =="CountChars")
            {
                Label label1 = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                string str = textBox1.Text;

                int countAlpha = 0, countDigit = 0, countSpecChar = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                        countAlpha++;
                    else if (str[i] >= 48 && str[i] <= 57)
                        countDigit++;
                    else
                        countSpecChar++;
                }

                label1.Text = "No of alphabets: "+countAlpha;
                label1.Width = 800;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);

                label2.Text = "No of digits: " + countDigit;
                label2.Width = 800;
                label2.Location = new Point(350, 350);
                this.Controls.Add(label2);

                label3.Text = "No of special characters: " + countSpecChar;
                label3.Width = 800;
                label3.Location = new Point(350, 400);
                this.Controls.Add(label3);
            }
            else
            {
                Label label1 = new Label();
                label1.Text = "Not an option";
                label1.Width = 500;
                label1.Location = new Point(350, 300);
                this.Controls.Add(label1);
            }
        }
    }
}
