using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace InventoryMngtSystem
{
    public partial class FormSupplier : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormSupplier()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {

        }
        private bool IsDuplicateRecord(string name, string contactperson, string email)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM supplier WHERE sname=@name AND scontactperson =@contactperson AND semail=@email";

            // Initialize the command and connection
            using (cmd = new SqlCommand(checkQuery, conn))
            {
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactperson", contactperson);
                cmd.Parameters.AddWithValue("@email", email);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string user_name, user_contactperson, user_email;
            user_name = textBox2.Text;
            user_contactperson = textBox3.Text;
            user_email = textBox4.Text;

            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            // Define the SQL query with parameters
            sql = "insert into supplier  (sname, scontactperson, semail)values(@name, @contactperson, @email);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(user_name, user_contactperson, user_email))
                {
                    MessageBox.Show("A supplier with these details already exists. Please enter unique details.");
                    return;
                }
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@name", user_name);
                cmd.Parameters.AddWithValue("@contactperson", user_contactperson);
                cmd.Parameters.AddWithValue("@email", user_email);

                // Execute the command and get the new inserted ID
                object newId = cmd.ExecuteScalar(); // Use ExecuteScalar to get the first column of the first row

                if (newId != null)
                {
                    MessageBox.Show("Supplier added successfully. Supplier ID: " + newId.ToString());
                }
                else
                {
                    MessageBox.Show("Supplier added, but could not retrieve the ID.");
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

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteSupplier ds = new DeleteSupplier();
            ds.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowSupplier ss = new ShowSupplier();
            ss.ShowDialog();
        }
    }
}
