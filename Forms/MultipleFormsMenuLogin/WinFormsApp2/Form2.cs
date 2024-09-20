using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFibonacci f3 = new FormFibonacci();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormEvenOdd f4 = new FormEvenOdd();
            f4.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFactorial f5 = new FormFactorial();
            f5.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPalindrome f6 = new FormPalindrome();
            f6.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormArmstrong f7 = new FormArmstrong();
            f7.ShowDialog();
            this.Close();
        }
    }
}
