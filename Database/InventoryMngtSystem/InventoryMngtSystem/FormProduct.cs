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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryMngtSystem
{
    public partial class FormProduct : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormProduct()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadSupplierIDs();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string product_name, product_desc, product_quantity, product_price, product_category, product_sid;
            product_name = textBox2.Text;
            product_desc = textBox3.Text;
            product_quantity = textBox4.Text;
            product_price = textBox5.Text;
            product_category = textBox6.Text;
            product_sid = comboBox1.Text;

            if (product_name == "" || product_desc == "" || product_quantity == "" || product_price == "" || product_category == "" || product_sid == "")
            {
                MessageBox.Show("All fields are necessary to be filled");
                return;
            }
            if (!product_quantity.All(char.IsDigit))
            {
                MessageBox.Show("Product quantity should be in numerals");
                return;
            }
            if (!product_price.All(char.IsDigit))
            {
                MessageBox.Show("Product quantity should be in numerals");
                return;
            }
            // Define the SQL query with parameters
            sql = "insert into product  (pname, pdesc, pquantity, pprice, pcategory, sid)values(@name, @desc, @quantity, @price, @category, @sid);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(product_name, product_desc, product_quantity, product_price, product_category, product_sid))
                {
                    MessageBox.Show("A record with these details already exists. Please enter unique details.");
                    return;
                }
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@name", product_name);
                cmd.Parameters.AddWithValue("@desc", product_desc);
                cmd.Parameters.AddWithValue("@quantity", product_quantity);
                cmd.Parameters.AddWithValue("@price", product_price);
                cmd.Parameters.AddWithValue("@category", product_category);
                cmd.Parameters.AddWithValue("@sid", product_sid);

                // Execute the command and get the new inserted ID
                object newId = cmd.ExecuteScalar(); // Use ExecuteScalar to get the first column of the first row

                if (newId != null)
                {
                    MessageBox.Show("Product added successfully. Product ID: " + newId.ToString());
                }
                else
                {
                    MessageBox.Show("Product added, but could not retrieve the ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);// Display any errors that occur during the execution
            }
            finally
            {
                conn.Close();// Close the connection
            }
        }
        private bool IsDuplicateRecord(string name, string desc, string quantity, string price, string category, string sid)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM product WHERE pname=@name AND pdesc=@desc AND pquantity=@quantity AND pprice=@price AND pcategory=@category AND sid=@sid";

            // Initialize the command and connection
            using (cmd = new SqlCommand(checkQuery, conn))
            {
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@sid", sid);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }

        private void loadSupplierIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT sid FROM supplier";// SQL query to get all sids from the supplier table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox1.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox1.Items.Add(dr["sid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
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
            /*FormProduct fp = new FormProduct();
            fp.ShowDialog();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAdminOrderDisplay fod = new FormAdminOrderDisplay();
            fod.ShowDialog();
            //this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowProducts p = new ShowProducts();
            p.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteProducts dp = new DeleteProducts();
            dp.ShowDialog();
        }
    }
}
