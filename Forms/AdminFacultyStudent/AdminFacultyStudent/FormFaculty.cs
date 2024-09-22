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

namespace AdminFacultyStudent
{
    public partial class FormFaculty : Form
    {
        public static string stringfunction = "";
        public FormFaculty()
        {
            InitializeComponent();
        }

        private void FormFaculty_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Length");
            comboBox1.Items.Add("ToUpper");
            comboBox1.Items.Add("Substring");
            comboBox1.Items.Add("Replace");
            comboBox1.Items.Add("CountChars");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringfunction = comboBox1.Text;
            FormStrings fs = new FormStrings();
            fs.ShowDialog();
            this.Close();
        }
    }
}
