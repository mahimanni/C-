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

namespace School
{
    public partial class FormStaff : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;TrustServerCertificate=True");

            string user_name, user_email, user_job, user_joindate, user_qualification;
            user_name = textBox1.Text;
            user_email = textBox2.Text;
            user_job = textBox3.Text;
            user_qualification = textBox4.Text;
            user_joindate = textBox5.Text;

            // Define the SQL query with parameters
            //cmd = new SqlCommand("insert into student  (name, email, course, join_date)values(@name, @email, @course, @join_date)", conn);
            sql = "insert into staff  (sname, semail, sjob, squalification, sjoin_date)values(@sname, @semail, @sjob, @squalification, @sjoin_date)";

            // Using the SqlConnection and SqlCommand objects
            using (SqlConnection conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create the SqlCommand object
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Define parameters and assign values from variables
                        cmd.Parameters.AddWithValue("@sname", user_name);
                        cmd.Parameters.AddWithValue("@semail", user_email);
                        cmd.Parameters.AddWithValue("@sjob", user_job);
                        cmd.Parameters.AddWithValue("@squalification", user_qualification);
                        cmd.Parameters.AddWithValue("@sjoin_date", user_joindate);

                        // Execute the command (for INSERT, UPDATE, DELETE use ExecuteNonQuery)
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records were inserted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display any errors that occur during the execution
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }
        }
    }
}
