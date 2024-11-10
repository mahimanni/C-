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
    public partial class DeleteInventory : Form
    {
        SqlConnection conn;
        string str, sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public DeleteInventory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadInventoryIDs();
        }
        private void loadInventoryIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT wid FROM inventory";// SQL query to get all sids from the supplier table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["wid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string id = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Inventory ID to delete.");
                return;
            }
            conn.Open();
            sql = "delete from inventory where wid= @wid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@wid", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Inventory deleted successfully");
                comboBox4.Text = "";
                loadInventoryIDs();
            }
            else
            {
                MessageBox.Show("No inventory found with the specified Inventory ID.");
            }
        }
    }
}
