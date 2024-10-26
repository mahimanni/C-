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
    public partial class FormTeacher : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            //for course
            comboBox1.Items.Add("BCA");
            comboBox1.Items.Add("BBA");
            comboBox1.Items.Add("BA");
            comboBox1.Items.Add("BSC");
            comboBox1.Items.Add("BVOC");
            comboBox1.Items.Add("BTECH");
            comboBox1.Items.Add("MCA");
            comboBox1.Items.Add("MBA");

            //for experience
            comboBox2.Items.Add("2+ years");
            comboBox2.Items.Add("5+ years");
            comboBox2.Items.Add("7+ years");
            comboBox2.Items.Add("10+ years");
            comboBox2.Items.Add("15+ years");

            //for qualification
            comboBox3.Items.Add("PHD");
            comboBox3.Items.Add("MTECH");
            comboBox3.Items.Add("MASTERS");
            comboBox3.Items.Add("GATE QUALIFIED");
            comboBox3.Items.Add("IIT QUALIFIED");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

            string user_name, user_age, user_gender, user_email, user_phoneno, user_pwd, user_course, user_experience, user_qualification, user_joindate;
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
            user_experience = comboBox2.Text;
            user_qualification = comboBox3.Text;
            user_joindate = textBox9.Text;

            if (user_phoneno.Length != 10)
            {
                MessageBox.Show("Phone Number should be of 10 digits");
                return;
            }

            // Define the SQL query with parameters
            sql = "insert into teacher  (tname, tage, tgender, temail, tphoneno, tpwd, tcourse, texperience, tqualification, tjoin_date)values(@name, @age, @gender, @email, @phoneno, @pwd, @course, @experience, @qualification, @join_date);" + "SELECT SCOPE_IDENTITY();";

            try
            {
                conn.Open();// Open the connection
                cmd = new SqlCommand(sql, conn);

                // Define parameters and assign values from variables
                cmd.Parameters.AddWithValue("@name", user_name);
                cmd.Parameters.AddWithValue("@age", user_age);
                cmd.Parameters.AddWithValue("@gender", user_gender);
                cmd.Parameters.AddWithValue("@email", user_email);
                cmd.Parameters.AddWithValue("@phoneno", user_phoneno);
                cmd.Parameters.AddWithValue("@pwd", user_pwd);
                cmd.Parameters.AddWithValue("@course", user_course);
                cmd.Parameters.AddWithValue("@experience", user_experience);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
