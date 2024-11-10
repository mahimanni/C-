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
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
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
            comboBox1.Items.Add("Pieces");
            comboBox1.Items.Add("Kilograms");
            comboBox1.Items.Add("Metres");
            comboBox1.Items.Add("Litres");
            comboBox1.Items.Add("Boxes");

            comboBox2.Items.Add("In Stock");
            comboBox2.Items.Add("Out of Stock");
            comboBox2.Items.Add("Backordered");
            comboBox2.Items.Add("Discontinued");
            loadProductIDs();
        }
        private void loadProductIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT pid FROM product";// SQL query to get all sids from the supplier table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["pid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
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

            string pid = comboBox4.Text;
            string sid = textBox2.Text;

            string category = textBox4.Text;
            string sku = textBox5.Text;
            string upc = textBox6.Text;

            string quantityinstock = textBox7.Text;
            string reorderlevel = textBox8.Text;
            string quantityonorder = textBox9.Text;
            string safetystock = textBox10.Text;

            string unitofmeasure = comboBox1.Text;

            string purchaseprice = textBox11.Text;
            string sellingprice = textBox12.Text;
            string discount = textBox13.Text;
            string taxrate = textBox14.Text;

            string warehouselocation = textBox15.Text;
            string binnumber = textBox16.Text;

            string dateadded = textBox17.Text;
            string lastupdated = textBox18.Text;
            string expirationdate = textBox19.Text;
            string lastordered = textBox20.Text;
            string lastsold = textBox21.Text;

            string itemcond = textBox22.Text;
            string status = comboBox2.Text;
            string notes = textBox23.Text;

            string itemname = getProductName(comboBox4.Text);

            try
            {
                // Open the connection to the database
                conn.Open();

                cmd = new SqlCommand(insertQuery, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@pid", pid);  // Product ID (Foreign key)
                cmd.Parameters.AddWithValue("@sid", sid);  // Supplier ID (Foreign key)
                cmd.Parameters.AddWithValue("@ItemName", itemname);  // Supplier ID (Foreign key)
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@SKU", sku);
                cmd.Parameters.AddWithValue("@UPC", upc);
                cmd.Parameters.AddWithValue("@QuantityInStock", quantityinstock);
                cmd.Parameters.AddWithValue("@ReorderLevel", reorderlevel);
                cmd.Parameters.AddWithValue("@QuantityOnOrder", quantityonorder);
                cmd.Parameters.AddWithValue("@SafetyStock", safetystock);
                cmd.Parameters.AddWithValue("@UnitOfMeasure", unitofmeasure);
                cmd.Parameters.AddWithValue("@PurchasePrice", purchaseprice);
                cmd.Parameters.AddWithValue("@SellingPrice", sellingprice);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@TaxRate", taxrate);
                cmd.Parameters.AddWithValue("@WarehouseLocation", warehouselocation);
                cmd.Parameters.AddWithValue("@BinNumber", binnumber);
                cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now); // Defaults to current date
                cmd.Parameters.AddWithValue("@LastUpdated", lastupdated); // Can be NULL
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationdate); // Can be NULL
                cmd.Parameters.AddWithValue("@LastOrderedDate", lastordered); // Can be NULL
                cmd.Parameters.AddWithValue("@LastSoldDate", lastsold); // Can be NULL
                cmd.Parameters.AddWithValue("@ItemCondition", itemcond);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Notes", notes);

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

        private void getSidAndPquantity(int pid)
        {
            string query = "SELECT sid, pquantity, pprice, pcategory FROM product WHERE pid = @pid";
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the pid parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@pid", pid);

                    // Execute the command and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there is a row returned
                        if (reader.Read())
                        {
                            // Get sid and pquantity from the reader
                            string sid = (reader["sid"]).ToString();
                            string pquantity = (reader["pquantity"]).ToString();
                            string pprice = (reader["pprice"]).ToString();
                            string category = (reader["pcategory"]).ToString();

                            // Display or use the retrieved data
                            textBox2.Text = sid;
                            textBox7.Text = pquantity;
                            textBox11.Text = pprice;
                            textBox4.Text = category;
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given Product ID (pid).");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            FormAdminOrderDisplay fod = new FormAdminOrderDisplay();
            fod.ShowDialog();
            //this.Close();
        }

        private string getProductName(string productid)
        {
            // Get the Product ID (pid) entered by the user
            int pid = Convert.ToInt32(productid);

            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string selectQuery = "SELECT pname FROM product WHERE pid = @pid";

            // Create a new connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
                            textBox24.Text = result.ToString();
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
        //when OK button is clicked then supplierid, itemname, category, quantity in stock, purchase price
        private void button8_Click(object sender, EventArgs e)
        {
            textBox24.Text = getProductName(comboBox4.Text);
            getSidAndPquantity(Convert.ToInt32(comboBox4.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowInventory si= new ShowInventory();
            si.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteInventory di= new DeleteInventory();
            di.ShowDialog();
        }
    }
}