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
    public partial class ShowProducts : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public ShowProducts()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProductData();
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {

        }
        private void LoadProductData()
        {
            // Connection string to your database
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT pid, pname, pdesc, pquantity, pprice, pcategory, sid FROM product";

            try
            {
                // Initialize the connection
                conn = new SqlConnection(connectionString);
                da = new SqlDataAdapter(query, conn);

                // Fill the DataTable with data from the database
                dt = new DataTable();
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridViewProduct.DataSource = dt;

                // Set column headers to be more user-friendly
                dataGridViewProduct.Columns["pid"].HeaderText = "Product ID";
                dataGridViewProduct.Columns["pname"].HeaderText = "Product Name";
                dataGridViewProduct.Columns["pdesc"].HeaderText = "Description";
                dataGridViewProduct.Columns["pquantity"].HeaderText = "Quantity";
                dataGridViewProduct.Columns["pprice"].HeaderText = "Price";
                dataGridViewProduct.Columns["pcategory"].HeaderText = "Category";
                dataGridViewProduct.Columns["sid"].HeaderText = "Supplier ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
