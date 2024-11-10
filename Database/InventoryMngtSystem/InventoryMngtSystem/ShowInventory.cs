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
    public partial class ShowInventory : Form
    {
        public ShowInventory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Call LoadInventoryData when form loads
            this.Load += new EventHandler(ShowInventory_Load);
        }

        private void ShowInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            // Define the query to select all columns from the inventory table
            string query = "SELECT wid, pid, sid, ItemName, Category, SKU, UPC, QuantityInStock, ReorderLevel, " +
                           "QuantityOnOrder, SafetyStock, UnitOfMeasure, PurchasePrice, SellingPrice, Discount, " +
                           "TaxRate, WarehouseLocation, BinNumber, DateAdded, LastUpdated, ExpirationDate, " +
                           "LastOrderedDate, LastSoldDate, ItemCondition, Status, Notes " +
                           "FROM inventory";

            // Initialize connection string (make sure it matches your database settings)
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the inventory table
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView control
                    dataGridViewInventory.DataSource = dataTable;

                    // Optional: Adjust column headers for better readability
                    dataGridViewInventory.Columns["wid"].HeaderText = "Warehouse ID";
                    dataGridViewInventory.Columns["pid"].HeaderText = "Product ID";
                    dataGridViewInventory.Columns["sid"].HeaderText = "Supplier ID";
                    dataGridViewInventory.Columns["ItemName"].HeaderText = "Item Name";
                    dataGridViewInventory.Columns["Category"].HeaderText = "Category";
                    dataGridViewInventory.Columns["SKU"].HeaderText = "Stock keeping unit";
                    dataGridViewInventory.Columns["UPC"].HeaderText = "Universal product code";
                    dataGridViewInventory.Columns["QuantityInStock"].HeaderText = "Quantity In Stock";
                    dataGridViewInventory.Columns["ReorderLevel"].HeaderText = "Reorder Level";
                    dataGridViewInventory.Columns["QuantityOnOrder"].HeaderText = "Quantity On Order";
                    dataGridViewInventory.Columns["SafetyStock"].HeaderText = "Safety Stock";
                    dataGridViewInventory.Columns["UnitOfMeasure"].HeaderText = "Unit Of Measure";
                    dataGridViewInventory.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                    dataGridViewInventory.Columns["SellingPrice"].HeaderText = "Selling Price";
                    dataGridViewInventory.Columns["Discount"].HeaderText = "Discount";
                    dataGridViewInventory.Columns["TaxRate"].HeaderText = "Tax Rate";
                    dataGridViewInventory.Columns["WarehouseLocation"].HeaderText = "Warehouse Location";
                    dataGridViewInventory.Columns["BinNumber"].HeaderText = "Bin Number";
                    dataGridViewInventory.Columns["DateAdded"].HeaderText = "Date Added";
                    dataGridViewInventory.Columns["LastUpdated"].HeaderText = "Last Updated";
                    dataGridViewInventory.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                    dataGridViewInventory.Columns["LastOrderedDate"].HeaderText = "Last Ordered Date";
                    dataGridViewInventory.Columns["LastSoldDate"].HeaderText = "Last Sold Date";
                    dataGridViewInventory.Columns["ItemCondition"].HeaderText = "Item Condition";
                    dataGridViewInventory.Columns["Status"].HeaderText = "Status";
                    dataGridViewInventory.Columns["Notes"].HeaderText = "Notes";
                }
                catch (Exception ex)
                {
                    // Display any errors that occur during data loading
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

    }
}
