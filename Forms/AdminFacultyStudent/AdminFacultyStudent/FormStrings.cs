using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminFacultyStudent
{
    public partial class FormStrings : Form
    {
        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
        String functionName = FormFaculty.stringfunction;
        public FormStrings()
        {
            InitializeComponent();
        }

        private void FormStrings_Load(object sender, EventArgs e)
        {
            //For string functions
            if (functionName == "Length")
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (functionName == "Length")
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
            else if (functionName == "ToUpper")
            {
                Label label1 = new Label();
                string str = textBox1.Text;
                string s = "";

                int i = 0;
                while (i < str.Length)
                {
                    if (str[i] >= 97 && str[i] <= 122)
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
            else if (functionName == "Substring")
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
            else if (functionName == "Replace")
            {
                Label label1 = new Label();
                string str = textBox1.Text;
                string ch = textBox2.Text;
                string newch = textBox3.Text;

                string s = "";

                int i = 0;
                while (i < str.Length)
                {
                    if (str[i].ToString() == ch)
                    {
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
            else if (functionName == "CountChars")
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

                label1.Text = "No of alphabets: " + countAlpha;
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
