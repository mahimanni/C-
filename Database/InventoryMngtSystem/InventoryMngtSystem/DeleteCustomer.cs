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
    public partial class DeleteCustomer : Form
    {
        SqlConnection conn;
        string str, sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public DeleteCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadCustomerIDs();
        }
        private void loadCustomerIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT id FROM customer";
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["id"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string id = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Customer ID to delete.");
                return;
            }
            conn.Open();
            sql = "delete from customer where id= @id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer deleted successfully");
                comboBox4.Text = "";
                loadCustomerIDs();
            }
            else
            {
                MessageBox.Show("No Customer found with the specified Customer ID.");
            }
            conn.Close();
        }
    }
}
