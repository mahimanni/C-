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
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee fe = new FormEmployee();
            fe.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCustomer fc= new FormCustomer();
            fc.ShowDialog();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSupplier fs= new FormSupplier();
            fs.ShowDialog();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInventory fi= new FormInventory();
            fi.ShowDialog();    
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProduct fp= new FormProduct();
            fp.ShowDialog();
            //this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*FormOrder fo = new FormOrder();
            fo.ShowDialog();
            this.Close();*/
        }
    }
}
