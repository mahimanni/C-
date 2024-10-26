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

        private void FormStaff_Load(object sender, EventArgs e)
        {
            //for job
            comboBox1.Items.Add("lab assistant");
            comboBox1.Items.Add("staff assistant");
            comboBox1.Items.Add("assistant");
            comboBox1.Items.Add("auditorium manager");
            comboBox1.Items.Add("curriculum manager");
            comboBox1.Items.Add("fee counter");
            comboBox1.Items.Add("librarian");
            comboBox1.Items.Add("notice manager");

            //for working years
            comboBox2.Items.Add("Fresher");
            comboBox2.Items.Add("More than 2yrs");
            comboBox2.Items.Add("More than 5yrs");
            comboBox2.Items.Add("More than 7yrs");
            comboBox2.Items.Add("More than 10yrs");
            comboBox2.Items.Add("More than 15yrs");

            //for qualification
            comboBox3.Items.Add("BTECH");
            comboBox3.Items.Add("MTECH");
            comboBox3.Items.Add("BCA");
            comboBox3.Items.Add("BBA");
            comboBox3.Items.Add("BA");
            comboBox3.Items.Add("BSC");
            comboBox3.Items.Add("BVOC");
            comboBox3.Items.Add("MCA");
            comboBox3.Items.Add("MBA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

            string user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_job, user_workingyear, user_qualification, user_joindate;
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
            user_job = comboBox1.Text;
            user_workingyear = comboBox2.Text;
            user_qualification = comboBox3.Text;
            user_joindate = textBox9.Text;

            if (user_phoneno.Length != 10)
            {
                MessageBox.Show("Phone Number should be of 10 digits");
                return;
            }

            // Define the SQL query with parameters
            sql = "insert into staff  (sname, sage, sgender, semail, sphoneno, spwd, sjob, sworkingyear, squalification, sjoin_date)values(@name, @age, @gender, @email, @phoneno, @pwd, @job, @workingyear, @qualification, @join_date);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variable3
                cmd.Parameters.AddWithValue("@name", user_name);
                cmd.Parameters.AddWithValue("@age", user_age);
                cmd.Parameters.AddWithValue("@gender", user_gender);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.Parameters.AddWithValue("@phoneno", user_phoneno);
                cmd.Parameters.AddWithValue("@pwd", user_pwd);
                cmd.Parameters.AddWithValue("@job", user_job);
                cmd.Parameters.AddWithValue("@workingyear", user_workingyear);
                cmd.Parameters.AddWithValue("@qualification", user_qualification);
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
    }
}
