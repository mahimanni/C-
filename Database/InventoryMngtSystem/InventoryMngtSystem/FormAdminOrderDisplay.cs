using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMngtSystem
{
    public partial class FormAdminOrderDisplay : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormAdminOrderDisplay()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAdminOrderDisplay_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }
        private void LoadOrderData()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");

            // SQL query to fetch the top 1000 rows from the orders table
            sql = "SELECT TOP (1000) [orderid], [id], [pid], [deliveryaddress], [paymentmethod], [quantity], [items], [deliverycharge], [itemsdiscount], [ordertotal], [order_date], [delivery_date] FROM [dbo].[orders]";

            try
            {
                conn.Open();
                da = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                // Bind the data table to the DataGridView
                dataGridViewOrders.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee fe = new FormEmployee();
            fe.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            fc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInventory fi = new FormInventory();
            fi.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct();
            fp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
