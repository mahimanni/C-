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
    public partial class DeleteEmployee : Form
    {
        SqlConnection conn;
        string str, sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public DeleteEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadEmployeeIDs();
        }
        private void loadEmployeeIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT eid FROM employee";// SQL query to get all sids from the employee table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["eid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string id = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Employee ID to delete.");
                return;
            }
            conn.Open();
            sql = "delete from employee where eid= @eid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@eid", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Employee deleted successfully");
                comboBox4.Text = "";
                loadEmployeeIDs();
            }
            else
            {
                MessageBox.Show("No Employee found with the specified Employee ID.");
            }
        }
    }
}
