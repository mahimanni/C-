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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
namespace InventoryMngtSystem
{
    public partial class FormInventory : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormInventory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string insertQuery = @"
            INSERT INTO inventory (pid, sid, ItemName, Category, SKU, UPC, QuantityInStock, ReorderLevel, 
                QuantityOnOrder, SafetyStock, UnitOfMeasure, PurchasePrice, SellingPrice, Discount, TaxRate, 
                WarehouseLocation, BinNumber, DateAdded, LastUpdated, ExpirationDate, LastOrderedDate, 
                LastSoldDate, ItemCondition, Status, Notes)
            VALUES (@pid, @sid,@ItemName, @Category, @SKU, @UPC, @QuantityInStock, @ReorderLevel, 
                @QuantityOnOrder, @SafetyStock, @UnitOfMeasure, @PurchasePrice, @SellingPrice, @Discount, 
                @TaxRate, @WarehouseLocation, @BinNumber, @DateAdded, @LastUpdated, @ExpirationDate, 
                @LastOrderedDate, @LastSoldDate, @ItemCondition, @Status, @Notes);
            " + "SELECT SCOPE_IDENTITY();";

            string itemname= getProductName(textBox2.Text);

                try
                {
                        // Open the connection to the database
                        conn.Open();

                        cmd = new SqlCommand(insertQuery, conn);
                
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@pid", 1);  // Product ID (Foreign key)
                        cmd.Parameters.AddWithValue("@sid", 1);  // Supplier ID (Foreign key)
                        cmd.Parameters.AddWithValue("@ItemName", itemname);  // Supplier ID (Foreign key)
                        cmd.Parameters.AddWithValue("@Category", "Electronics");
                        cmd.Parameters.AddWithValue("@SKU", "12345");
                        cmd.Parameters.AddWithValue("@UPC", "67890");
                        cmd.Parameters.AddWithValue("@QuantityInStock", 100);
                        cmd.Parameters.AddWithValue("@ReorderLevel", 20);
                        cmd.Parameters.AddWithValue("@QuantityOnOrder", 50);
                        cmd.Parameters.AddWithValue("@SafetyStock", 10);
                        cmd.Parameters.AddWithValue("@UnitOfMeasure", "Pieces");
                        cmd.Parameters.AddWithValue("@PurchasePrice", 25.50);
                        cmd.Parameters.AddWithValue("@SellingPrice", 50.75);
                        cmd.Parameters.AddWithValue("@Discount", 5.00);
                        cmd.Parameters.AddWithValue("@TaxRate", 18.00);
                        cmd.Parameters.AddWithValue("@WarehouseLocation", "A1");
                        cmd.Parameters.AddWithValue("@BinNumber", "B123");
                        cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now); // Defaults to current date
                        cmd.Parameters.AddWithValue("@LastUpdated", DBNull.Value); // Can be NULL
                        cmd.Parameters.AddWithValue("@ExpirationDate", DBNull.Value); // Can be NULL
                        cmd.Parameters.AddWithValue("@LastOrderedDate", DBNull.Value); // Can be NULL
                        cmd.Parameters.AddWithValue("@LastSoldDate", DBNull.Value); // Can be NULL
                        cmd.Parameters.AddWithValue("@ItemCondition", "New");
                        cmd.Parameters.AddWithValue("@Status", "In Stock");
                        cmd.Parameters.AddWithValue("@Notes", "Sample item for testing.");

                    
                    // Execute the command and get the new inserted ID
                    object newId = cmd.ExecuteScalar(); // Use ExecuteScalar to get the first column of the first row

                    if (newId != null)
                    {
                        MessageBox.Show("Record inserted successfully. New ID: " + newId.ToString());
                        textBox1.Text = newId.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Record inserted, but could not retrieve the ID.");
                    }
                }
                catch (Exception ex)
                {
                // Handle any exceptions that occur
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
                }
                conn.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee fe= new FormEmployee();
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
            FormAdminOrderDisplay fod = new FormAdminOrderDisplay();
            fod.ShowDialog();
            //this.Close();
        }

        private string getProductName(string productid)
        {
            // Get the Product ID (pid) entered by the user
            int pid = Convert.ToInt32(productid); // txtProductId is a TextBox where user enters pid

            // Define the connection string (update with your actual database details)
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            

            // Define the SQL query to get the product name based on the pid
            string selectQuery = "SELECT pname FROM product WHERE pid = @pid";

            // Create a new connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection to the database
                    connection.Open();

                    // Create a SqlCommand object with the SQL query and connection
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Add parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@pid", pid);

                        // Execute the command and get the product name
                        object result = command.ExecuteScalar();

                        // Check if a result was returned
                        if (result != null)
                        {
                            // Display the product name in textbox control
                            textBox24.Text =  result.ToString();
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product not found for the given Product ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur
                    MessageBox.Show("Error: " + ex.Message);
                }
                return "No name found";
                connection.Close();
            }
        }
    }
}
