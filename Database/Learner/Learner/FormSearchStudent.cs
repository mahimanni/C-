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
    public partial class FormSearchStudent : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;

        string category = FormMenu.category, searchCategory = FormMenu.searchCategory;
        string toSearchText;
        System.Windows.Forms.TextBox toSearch;
        Label result;
        public FormSearchStudent()
        {
            InitializeComponent();
        }

        private void FormSearchStudent_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

            Label displayCategory = new Label();
            displayCategory.Location = new Point(100, 100);
            displayCategory.Text = " Welcome to the Student Search Window ";
            displayCategory.Font = new Font("Times New Roman", 18);
            displayCategory.ForeColor = Color.CadetBlue;
            displayCategory.AutoSize = true;
            this.Controls.Add(displayCategory);

            toSearchStudentRecord();

            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
            button1.Location = new Point(100, 250);
            button1.Size = new Size(100, 30);
            button1.Text = "SEARCH";
            button1.Click += new EventHandler(this.button1_Click);
            this.Controls.Add(button1);
        }

        private void toSearchStudentRecord()
        {
            Label toSearchLabel = new Label();
            toSearchLabel.Location = new Point(100, 200);
            toSearchLabel.Size = new Size(200, 50);

            toSearch = new System.Windows.Forms.TextBox();
            toSearch.Location = new Point(300, 200);
            toSearch.Name = "toSearch";
            this.Controls.Add(toSearch);

            if (searchCategory == "course")
                toSearchLabel.Text = "Enter course name: ";
            else if (searchCategory == "name")
                toSearchLabel.Text = "Enter student name: ";
            this.Controls.Add(toSearchLabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toSearchText = toSearch.Text;  // Fetch input from TextBox after button click

            result = new Label();
            result.Location = new Point(100, 300);  // Position result label below search button
            result.Width = 900;
            result.Height = 500;

            if (string.IsNullOrEmpty(toSearchText))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            // Clear previous result text before displaying new search result
            result.Text = "";

            // Use parameterized query to prevent SQL injection
            if (searchCategory == "course")
                sql = "SELECT * FROM student WHERE course = @toSearchText";
            else if (searchCategory == "name")
                sql = "SELECT * FROM student WHERE name = @toSearchText";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@toSearchText", toSearchText);  // Set parameter value

                conn.Open();
                dr = cmd.ExecuteReader();

                // Display result in label or MessageBox
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result.Text += $"{dr["id"]}  {dr["name"]} {dr["age"]} {dr["gender"]} {dr["email"]} {dr["phoneno"]} {dr["pwd"]}  {dr["course"]} {dr["currentyear"]} {dr["join_date"]}\n";
                    }
                }
                else
                {
                    result.Text = "No records found.";
                }

                this.Controls.Add(result);  // Add the result label to the form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();  // Ensure connection is closed after query
                cmd.Dispose();
            }
        }
    }
}
