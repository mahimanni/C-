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
    public partial class FormAdmin : Form
    {
        public static FormAdmin Current;
        public FormAdmin()
        {
            Current = this;
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Faculty");
            comboBox1.Items.Add("Admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userType = comboBox1.Text;
            string userName = textBox1.Text;
            string passWord = textBox2.Text;

            Label label1 = new Label();
            label1.Location = new Point(300, 350);
            label1.Width = 300;
            this.Controls.Add(label1);

            if (userType!="" && userName!="" && passWord != "")
            {
                Form1.users.Add(userName);
                Form1.passwords.Add(passWord);
                Form1.usertypes.Add(userType);
                label1.Text = "Signed In successfully";

                this.Close();
                /*Form1.Current.ShowDialog();*/
            }
            else
            {
                label1.Text = "Input entries for every field";
            }
        }
    }
}
