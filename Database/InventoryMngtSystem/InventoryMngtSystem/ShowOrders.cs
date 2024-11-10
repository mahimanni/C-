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
    public partial class ShowOrders : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public ShowOrders()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            LoadOrdersData();
        }

        private void ShowOrders_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrdersData()
        {
            // Connection string to your database
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT orderid, id, pid, deliveryaddress, paymentmethod, quantity, items, deliverycharge, itemsdiscount, ordertotal, order_date, delivery_date FROM orders";

            try
            {
                // Initialize the connection
                conn = new SqlConnection(connectionString);
                da = new SqlDataAdapter(query, conn);

                // Fill the DataTable with data from the database
                dt = new DataTable();
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridViewOrders.DataSource = dt;

                // Set column headers to be more user-friendly
                dataGridViewOrders.Columns["orderid"].HeaderText = "Order ID";
                dataGridViewOrders.Columns["id"].HeaderText = "Customer ID";
                dataGridViewOrders.Columns["pid"].HeaderText = "Product ID";
                dataGridViewOrders.Columns["deliveryaddress"].HeaderText = "Delivery Address";
                dataGridViewOrders.Columns["paymentmethod"].HeaderText = "Payment Method";
                dataGridViewOrders.Columns["quantity"].HeaderText = "Quantity";
                dataGridViewOrders.Columns["items"].HeaderText = "Items";
                dataGridViewOrders.Columns["deliverycharge"].HeaderText = "Delivery Charge";
                dataGridViewOrders.Columns["itemsdiscount"].HeaderText = "Items Discount";
                dataGridViewOrders.Columns["ordertotal"].HeaderText = "Order Total";
                dataGridViewOrders.Columns["order_date"].HeaderText = "Order Date";
                dataGridViewOrders.Columns["delivery_date"].HeaderText = "Delivery Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
