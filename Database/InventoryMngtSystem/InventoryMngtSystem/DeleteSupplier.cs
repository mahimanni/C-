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
    public partial class DeleteSupplier : Form
    {
        SqlConnection conn;
        string str, sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public DeleteSupplier()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadSupplierIDs();
        }
        private void loadSupplierIDs()
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT sid FROM supplier";// SQL query to get all sids from the supplier table
            conn.Open();// Open the connection
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();// Execute the command and read the data

            comboBox4.Items.Clear();// Clear the ComboBox before adding new items

            while (dr.Read())// Check if there are any rows returned
            {
                comboBox4.Items.Add(dr["sid"].ToString());// Add each sid value from the supplier table to the ComboBox
            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            string id = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a Supplier ID to delete.");
                return;
            }
            conn.Open();
            sql = "delete from supplier where sid= @sid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sid", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Supplier deleted successfully");
                comboBox4.Text = "";
                loadSupplierIDs();
            }
            else
            {
                MessageBox.Show("No supplier found with the specified Supplier ID.");
            }
        }
    }
}
