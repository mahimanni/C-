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
    public partial class ShowSupplier : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public ShowSupplier()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadSupplierData(); // Load data when the form loads
        }
        private void ShowSupplier_Load(object sender, EventArgs e)
        {

        }
        private void LoadSupplierData()
        {
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT sid, sname, scontactperson, semail FROM supplier";

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    using (da = new SqlDataAdapter(query, conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);

                        // Set the DataGridView data source to the DataTable
                        dataGridViewSupplier.DataSource = dt;

                        // Set the headers for better readability
                        dataGridViewSupplier.Columns["sid"].HeaderText = "Supplier Id";
                        dataGridViewSupplier.Columns["sname"].HeaderText = "Supplier Name";
                        dataGridViewSupplier.Columns["scontactperson"].HeaderText = "Contact Person";
                        dataGridViewSupplier.Columns["semail"].HeaderText = "Email";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
