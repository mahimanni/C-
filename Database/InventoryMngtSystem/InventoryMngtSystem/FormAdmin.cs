using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMngtSystem
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.ImageLocation = @$"C:\Users\manni\source\repos\C#\Database\InventoryMngtSystem\InventoryMngtSystem\assests\admin.jpg";
            pictureBox1.Load();
        }
        //<------------------------------------------------------------------------------Admin Authorization--------------------------------------------------------------------------------------------------------------->
        private void button1_Click(object sender, EventArgs e)
        {
            string name, email, password;
            name = textBox1.Text;
            email = textBox2.Text;
            password = textBox3.Text;

            //if (name == "Mahima" && email == "mahima@gmail.com" && password = "mahi")
            if (String.Equals(name, "Mahima") && String.Equals(email, "mahima@gmail.com") && String.Equals(password, "mahi"))
            {
                FormAdminMenu fam = new FormAdminMenu();
                fam.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Admin Credentials");
            }
        }
    }
}
