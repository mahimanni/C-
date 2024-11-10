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
    public partial class DeleteProducts : Form
    {
        SqlConnection conn;
        string str, sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public DeleteProducts()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadProductIDs();
        }
        private void loadProductIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT pid FROM product";// SQL query to get all sids from the supplier table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["pid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
        }

        private void DeleteProducts_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Product ID to delete.");
                return;
            }
            conn.Open();
            sql = "delete from product where pid= @pid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Product deleted successfully");
                comboBox4.Text = "";
                loadProductIDs();
            }
            else
            {
                MessageBox.Show("No product found with the specified Product ID.");
            }
        }
    }
}
