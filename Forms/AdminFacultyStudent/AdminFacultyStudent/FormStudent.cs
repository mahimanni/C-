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
    public partial class FormStudent : Form
    {
        public static string mathFunction="";
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sq");
            comboBox1.Items.Add("Pow");
            comboBox1.Items.Add("Min");
            comboBox1.Items.Add("Max");
            comboBox1.Items.Add("Abs");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mathFunction = comboBox1.Text;
            FormMaths fm= new FormMaths();
            fm.ShowDialog();
            this.Close();
        }

    }
}
