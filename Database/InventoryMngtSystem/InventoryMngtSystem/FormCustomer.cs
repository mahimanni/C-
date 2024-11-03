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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryMngtSystem
{
    public partial class FormCustomer : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");

            //Adding Indian States
            comboBox1.Items.Add("Andhra Pradesh");
            comboBox1.Items.Add("Arunachal Pradesh");
            comboBox1.Items.Add("Assam");
            comboBox1.Items.Add("Bihar");
            comboBox1.Items.Add("Chhattisgarh");
            comboBox1.Items.Add("Goa");
            comboBox1.Items.Add("Gujarat");
            comboBox1.Items.Add("Haryana");
            comboBox1.Items.Add("Himachal Pradesh");
            comboBox1.Items.Add("Jharkhand");
            comboBox1.Items.Add("Karnataka");
            comboBox1.Items.Add("Kerala");
            comboBox1.Items.Add("Madhya Pradesh");
            comboBox1.Items.Add("Maharashtra");
            comboBox1.Items.Add("Manipur");
            comboBox1.Items.Add("Meghalaya");
            comboBox1.Items.Add("Mizoram");
            comboBox1.Items.Add("Nagaland");
            comboBox1.Items.Add("Odisha");
            comboBox1.Items.Add("Punjab");
            comboBox1.Items.Add("Rajasthan");
            comboBox1.Items.Add("Sikkim");
            comboBox1.Items.Add("Tamil Nadu");
            comboBox1.Items.Add("Telangana");
            comboBox1.Items.Add("Tripura");
            comboBox1.Items.Add("Uttar Pradesh");
            comboBox1.Items.Add("Uttarakhand");
            comboBox1.Items.Add("West Bengal");

            // Adding Union Territories
            comboBox1.Items.Add("Andaman and Nicobar Islands");
            comboBox1.Items.Add("Chandigarh");
            comboBox1.Items.Add("Dadra and Nagar Haveli and Daman and Diu");
            comboBox1.Items.Add("Lakshadweep");
            comboBox1.Items.Add("Delhi");
            comboBox1.Items.Add("Puducherry");
            comboBox1.Items.Add("Ladakh");
            comboBox1.Items.Add("Jammu and Kashmir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_address, user_pincode, user_state;
            user_name = textBox1.Text;
            user_age = textBox2.Text;
            // Check which RadioButton is selected for gender
            if (radioButton2.Checked)
            {
                user_gender = "M";
            }
            else if (radioButton1.Checked)
            {
                user_gender = "F";
            }
            else if (radioButton3.Checked)
            {
                user_gender = "O";
            }
            else
            {
                // Optional: Handle case where no RadioButton is selected
                MessageBox.Show("Please select a gender.");
                return;
            }
            user_email = textBox4.Text;
            user_phoneno = textBox5.Text;
            user_pwd = textBox6.Text;
            user_address = textBox3.Text;
            user_pincode = textBox7.Text;
            user_state= comboBox1.Text;

            if (user_phoneno.Length != 10)
            {
                MessageBox.Show("Phone Number should be of 10 digits");
                return;
            }

            // Define the SQL query with parameters
            //cmd = new SqlCommand("insert into customer  (name, email, course, join_date)values(@name, @email, @course, @join_date)", conn);
            sql = "insert into customer  (name, age, gender, email, phoneno, pwd, address, pincode, state)values(@name, @age, @gender, @email, @phoneno, @pwd, @address, @pincode, @state);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_address, user_pincode, user_state))
                {
                    MessageBox.Show("A record with these details already exists. Please enter unique details.");
                    return;
                }
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@name", user_name);
                cmd.Parameters.AddWithValue("@age", user_age);
                cmd.Parameters.AddWithValue("@gender", user_gender);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.Parameters.AddWithValue("@phoneno", user_phoneno);
                cmd.Parameters.AddWithValue("@pwd", user_pwd);
                cmd.Parameters.AddWithValue("@address", user_address);
                cmd.Parameters.AddWithValue("@pincode", user_pincode);
                cmd.Parameters.AddWithValue("@state", user_state);

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
        // New function to check if a record with the same details exists
        private bool IsDuplicateRecord(string name, string age, string gender, string email, string phoneno, string pwd, string address, string pincode, string state)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM customer WHERE name=@name AND age=@age AND gender=@gender AND email=@email AND phoneno=@phoneno AND pwd=@pwd AND address=@address AND pincode=@pincode AND state=@state";

            // Initialize the command and connection
            using (cmd = new SqlCommand(checkQuery, conn))
            {
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phoneno", phoneno);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@pincode", pincode);
                cmd.Parameters.AddWithValue("@state", state);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }
    }
}
