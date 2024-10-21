using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMinder
{
    public partial class FormLogin : Form
    {
        string[] name = { "Mahi", "Manya", "Abhi", "Prisha", "Priya" };
        string[] password = { "mahi", "manya", "abhi", "prisha", "priya" };
        int flag = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (textBox1.Text == name[i] && textBox2.Text == password[i])
                {
                    label3.Text = "Login Successful";
                    flag = 1;
                    MDIParent1 note = new MDIParent1();
                    note.ShowDialog();
                    this.Close();
                }
            }
            if (flag == 0)
            {
                label3.Text = "Login Unsuccessful";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
