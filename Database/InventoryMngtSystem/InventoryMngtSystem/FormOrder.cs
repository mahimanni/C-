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

namespace InventoryMngtSystem
{
    public partial class FormOrder : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;

        decimal items;
        string new_product_id;
        public FormOrder()
        {
            InitializeComponent();
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash on Delivery");
            comboBox1.Items.Add("Card");
            comboBox1.Items.Add("UPI");
            LoadProductData();

            textBox4.Text = "1";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            items = Convert.ToDecimal(textBox5.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string customer_id, product_id, order_deliveryaddress, order_paymentmethod, order_quantity, order_items, order_deliverycharge, order_itemsdiscount, order_ordertotal, order_orderdate, order_deliverydate;
            customer_id = textBox2.Text;
            product_id = new_product_id;
            order_deliveryaddress = textBox3.Text;
            order_paymentmethod = comboBox1.Text;
            order_quantity = textBox4.Text;
            order_items = textBox5.Text;
            order_deliverycharge = textBox6.Text;
            order_itemsdiscount = textBox7.Text;
            order_ordertotal = textBox8.Text;
            order_orderdate = textBox9.Text;
            order_deliverydate = textBox10.Text;

            // Define the SQL query with parameters
            sql = "insert into orders  (id,pid, deliveryaddress, paymentmethod, quantity, items, deliverycharge, itemsdiscount, ordertotal, order_date, delivery_date)values(@id, @pid, @deliveryaddress, @paymentmethod, @quantity, @items, @deliverycharge, @itemsdiscount, @ordertotal, @order_date, @delivery_date);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(customer_id, product_id, order_deliveryaddress, order_paymentmethod, order_quantity, order_items, order_deliverycharge, order_itemsdiscount, order_ordertotal, order_orderdate, order_deliverydate))
                {
                    MessageBox.Show("A record with these details already exists. Please enter unique details.");
                    return;
                }
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@id", customer_id);
                cmd.Parameters.AddWithValue("@pid", product_id);
                cmd.Parameters.AddWithValue("@deliveryaddress", order_deliveryaddress);
                cmd.Parameters.AddWithValue("@paymentmethod", order_paymentmethod);
                cmd.Parameters.AddWithValue("@quantity", order_quantity);
                cmd.Parameters.AddWithValue("@items", order_items);
                cmd.Parameters.AddWithValue("@deliverycharge", order_deliverycharge);
                cmd.Parameters.AddWithValue("@itemsdiscount", order_itemsdiscount);
                cmd.Parameters.AddWithValue("@ordertotal", order_ordertotal);
                cmd.Parameters.AddWithValue("@order_date", order_orderdate);
                cmd.Parameters.AddWithValue("@delivery_date", order_deliverydate);

                // Execute the command and get the new inserted ID
                object newId = cmd.ExecuteScalar(); // Use ExecuteScalar to get the first column of the first row

                if (newId != null)
                {
                    MessageBox.Show("Order placed successfully. Order ID: " + newId.ToString());
                }
                else
                {
                    MessageBox.Show("Order placed, but could not retrieve the ID.");
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
        private bool IsDuplicateRecord(string id, string pid, string deliveryaddress, string paymentmethod, string quantity, string items, string deliverycharge, string itemsdiscount, string ordertotal, string orderdate, string deliverydate)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM orders WHERE id=@id AND pid=@pid AND deliveryaddress=@deliveryaddress AND paymentmethod=@paymentmethod AND quantity= @quantity AND items= @items AND deliverycharge= @deliverycharge AND itemsdiscount=@itemsdiscount AND ordertotal= @ordertotal AND order_date=@orderdate AND delivery_date=@deliverydate";

            // Initialize the command and connection
            using (cmd = new SqlCommand(checkQuery, conn))
            {
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@deliveryaddress", deliveryaddress);
                cmd.Parameters.AddWithValue("@paymentmethod", paymentmethod);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@items", items);
                cmd.Parameters.AddWithValue("@deliverycharge", deliverycharge);
                cmd.Parameters.AddWithValue("@itemsdiscount", itemsdiscount);
                cmd.Parameters.AddWithValue("@ordertotal", ordertotal);
                cmd.Parameters.AddWithValue("@orderdate", orderdate);
                cmd.Parameters.AddWithValue("@deliverydate", deliverydate);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //<-------------------------------------------------for showing the products------------------------------------------------->
        private void LoadProductData()
        {
            SqlConnection conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                conn.Open();
                sql = "SELECT pid, pname, pdesc, pprice, pcategory FROM product";
                da = new SqlDataAdapter(sql, conn);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridViewProducts.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //<-------------------------------------------------To add the items in the cart------------------------------------------------->
        private void button8_Click(object sender, EventArgs e)
        {
            string product_id = textBox11.Text;
            int quantity = Convert.ToInt32(textBox4.Text);
            SqlConnection conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            sql = "select pprice from product where pid= @product_id";
            conn.Open();
            cmd = new SqlCommand(sql, conn);

            // Replace 'product_id' with the actual ID value we want to use
            cmd.Parameters.AddWithValue("@product_id", product_id);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                // Read the data and assign it to the TextBox
                dr.Read(); // Move to the first row
                items+= quantity*Convert.ToDecimal(dr["pprice"].ToString());//for items
            }
            else
            {
                MessageBox.Show("No product found with the given ID.");
            }
            textBox5.Text = items.ToString();
            textBox8.Text = items.ToString();

            textBox9.Text= DateTime.Now.ToString("MMMM dd, yyyy");
            // Get the current date and add 3 days
            DateTime dateAfterThreeDays = DateTime.Now.AddDays(3);
            textBox10.Text= dateAfterThreeDays.ToString("MMMM dd, yyyy");

            new_product_id = product_id;
        }
    }
}
