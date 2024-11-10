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
    public partial class ShowEmployee : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public ShowEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadEmployeeData();
        }
        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            //this.Load += ShowEmployee_Load;
        }
        private void LoadEmployeeData()
        {
            string connectionString = "Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT ename, eage, egender, eemail, ephoneno, epwd, esalary, erole, eaccess, ejoin_date FROM employee";
            conn = new SqlConnection(connectionString);
            try
            {
                    conn.Open();
                    using (da = new SqlDataAdapter(query, conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);

                        // Set the DataGridView data source to the DataTable
                        dataGridViewEmployee.DataSource = dt;

                        // Set the headers for better readability
                        dataGridViewEmployee.Columns["eid"].HeaderText = "Employee Id";
                        dataGridViewEmployee.Columns["ename"].HeaderText = "Employee Name";
                        dataGridViewEmployee.Columns["eage"].HeaderText = "Age";
                        dataGridViewEmployee.Columns["egender"].HeaderText = "Gender";
                        dataGridViewEmployee.Columns["eemail"].HeaderText = "Email";
                        dataGridViewEmployee.Columns["ephoneno"].HeaderText = "Phone Number";
                        dataGridViewEmployee.Columns["epwd"].HeaderText = "Password";
                        dataGridViewEmployee.Columns["esalary"].HeaderText = "Salary";
                        dataGridViewEmployee.Columns["erole"].HeaderText = "Role";
                        dataGridViewEmployee.Columns["eaccess"].HeaderText = "Access Level";
                        dataGridViewEmployee.Columns["ejoin_date"].HeaderText = "Join Date";
                    }
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
