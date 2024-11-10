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
    public partial class FormEmployee : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            comboBox1.Items.Add("Inventory Manager");
            comboBox1.Items.Add("Warehouse Staff");
            comboBox1.Items.Add("Procurement Officer");
            comboBox1.Items.Add("Sales Representative");
            comboBox1.Items.Add("Data Entry Clerk");
            comboBox1.Items.Add("Quality Control Specialist");
            comboBox1.Items.Add("Logistics Coordinator");
            comboBox1.Items.Add("System Administrator");

            comboBox2.Items.Add("Read Only");
            comboBox2.Items.Add("Edit");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_salary, user_role, user_access, user_joindate;
            user_name = textBox2.Text;
            user_age = textBox3.Text;
            // Check which RadioButton is selected for gender
            if (radioButton1.Checked)
            {
                user_gender = "M";
            }
            else if (radioButton2.Checked)
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
            user_salary = textBox7.Text;
            user_role = comboBox1.Text;
            user_access = comboBox2.Text;
            user_joindate = textBox8.Text;

            if (user_phoneno.Length != 10)
            {
                MessageBox.Show("Phone Number should be of 10 digits");
                return;
            }

            // Define the SQL query with parameters
            sql = "insert into employee  (ename, eage, egender, eemail, ephoneno, epwd, esalary, erole, eaccess, ejoin_date)values(@name, @age, @gender, @email, @phoneno, @pwd, @salary, @role, @access, @joindate);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_salary, user_role, user_access, user_joindate))
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
                cmd.Parameters.AddWithValue("@salary", user_salary);
                cmd.Parameters.AddWithValue("@role", user_role);
                cmd.Parameters.AddWithValue("@access", user_access);
                cmd.Parameters.AddWithValue("@joindate", user_joindate);

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
        private bool IsDuplicateRecord(string name, string age, string gender, string email, string phoneno, string pwd, string salary, string role, string access, string joindate)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM employee WHERE ename=@name AND eage=@age AND egender=@gender AND eemail=@email AND ephoneno=@phoneno AND epwd=@pwd AND esalary=@salary AND erole=@role AND eaccess=@access AND ejoin_date=@joindate";

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
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@access", access);
                cmd.Parameters.AddWithValue("@joindate", joindate);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
