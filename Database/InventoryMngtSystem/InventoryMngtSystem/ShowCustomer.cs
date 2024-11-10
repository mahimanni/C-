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
    public partial class ShowCustomer : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public ShowCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCustomerData();
        }
        private void ShowCustomer_Load(object sender, EventArgs e)
        {

        }
        private void LoadCustomerData()
        {
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT name, age, gender, email, phoneno, pwd, address, pincode, state, country FROM customer";

                try
                {
                    conn = new SqlConnection(connectionString);
                    da = new SqlDataAdapter(query, conn);
                    conn.Open();

                    // Create a data table to hold the results
                    dt = new DataTable();
                    da.Fill(dt);// Fill the data table with the data from the query

                    // Set the DataGridView's data source to the data table
                    dataGridViewCustomer.DataSource = dt;

                    // Set column headers for better readability
                    dataGridViewCustomer.Columns["id"].HeaderText = "Customer Id";
                    dataGridViewCustomer.Columns["name"].HeaderText = "Customer Name";
                    dataGridViewCustomer.Columns["age"].HeaderText = "Age";
                    dataGridViewCustomer.Columns["gender"].HeaderText = "Gender";
                    dataGridViewCustomer.Columns["email"].HeaderText = "Email";
                    dataGridViewCustomer.Columns["phoneno"].HeaderText = "Phone Number";
                    dataGridViewCustomer.Columns["pwd"].HeaderText = "Password";
                    dataGridViewCustomer.Columns["address"].HeaderText = "Address";
                    dataGridViewCustomer.Columns["pincode"].HeaderText = "Pincode";
                    dataGridViewCustomer.Columns["state"].HeaderText = "State";
                    dataGridViewCustomer.Columns["country"].HeaderText = "Country";

                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Display any errors that occur
                    MessageBox.Show("Error: " + ex.Message);
                }
        }
    }
}
