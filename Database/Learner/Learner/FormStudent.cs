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
namespace Learner
{
    public partial class FormStudent : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

            string user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_course, user_currentyear, user_joindate;
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
            user_course = comboBox1.Text;
            user_currentyear = comboBox2.Text;
            user_joindate = textBox9.Text;

            if (user_phoneno.Length != 10)
            {
                MessageBox.Show("Phone Number should be of 10 digits");
                return;
            }

            // Define the SQL query with parameters
            //cmd = new SqlCommand("insert into student  (name, email, course, join_date)values(@name, @email, @course, @join_date)", conn);
            sql = "insert into student  (name, age, gender, email, phoneno, pwd, course, currentyear, join_date)values(@name, @age, @gender, @email, @phoneno, @pwd, @course, @currentyear, @join_date);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection

                //Check if the record already exists using the new function
                if (IsDuplicateRecord(user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_course, user_currentyear, user_joindate))
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
                cmd.Parameters.AddWithValue("@course", user_course);
                cmd.Parameters.AddWithValue("@currentyear", user_currentyear);
                cmd.Parameters.AddWithValue("@join_date", user_joindate);

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
        private bool IsDuplicateRecord(string name, string age, string gender, string email, string phoneno, string pwd, string course, string currentyear, string joindate)
        {
            // Define the SQL query to check for duplicate records
            string checkQuery = "SELECT COUNT(*) FROM student WHERE name=@name AND age=@age AND gender=@gender AND email=@email AND phoneno=@phoneno AND pwd=@pwd AND course=@course AND currentyear=@currentyear AND join_date=@join_date";

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
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@currentyear", currentyear);
                cmd.Parameters.AddWithValue("@join_date", joindate);

                // Execute the query and return if the record exists
                int recordCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                return recordCount > 0; // If any record matches, return true (duplicate exists)
            }
        }


        private void FormStudent_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BCA");
            comboBox1.Items.Add("BBA");
            comboBox1.Items.Add("BA");
            comboBox1.Items.Add("BSC");
            comboBox1.Items.Add("BVOC");
            comboBox1.Items.Add("BTECH");
            comboBox1.Items.Add("MCA");
            comboBox1.Items.Add("MBA");

            comboBox2.Items.Add("1st semester");
            comboBox2.Items.Add("2nd semester");
            comboBox2.Items.Add("3rd semester");
            comboBox2.Items.Add("4th semester");
            comboBox2.Items.Add("5th semester");
            comboBox2.Items.Add("6th semester");
            comboBox2.Items.Add("7th semester");
            comboBox2.Items.Add("8th semester");
        }
    }
}
