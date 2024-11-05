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

            string user_location, user_capacity, user_email, user_pid;
            user_location = textBox2.Text;
            user_capacity = textBox3.Text;
            user_email = textBox4.Text;
            user_pid = textBox5.Text;

            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            // Define the SQL query with parameters
            sql = "insert into warehouse  (wlocation, wcapacity, wemail, pid)values(@location, @capacity, @email, @pid);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(user_location, user_capacity, user_email, user_pid))
                {
                    MessageBox.Show("A record with these details already exists. Please enter unique details.");
                    return;
                }
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@location", user_location);
                cmd.Parameters.AddWithValue("@capacity", user_capacity);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.Parameters.AddWithValue("@pid", user_pid);


                // Execute the command and get the new inserted ID
                object newId = cmd.ExecuteScalar(); // Use ExecuteScalar to get the first column of the first row

                if (newId != null)
                {
                    MessageBox.Show("Record inserted successfully. New ID: " + newId.ToString());
                }
                else
                {
                    MessageBox.Show("Record inserted, but could not retrieve the ID.");
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
        private bool IsDuplicateRecord(string location, string capacity, string email, string pid)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM warehouse WHERE wlocation=@location AND wcapacity =@capacity AND wemail=@email AND pid=@pid";

            // Initialize the command and connection
            using (cmd = new SqlCommand(checkQuery, conn))
            {
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pid", pid);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
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
           /* FormInventory fi = new FormInventory();
            fi.ShowDialog();*/
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
    }
}
