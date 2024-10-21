using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Source = UNDIVIDED\SQLEXPRESS; Initial Catalog = Employee; Integrated Security = True; Trust Server Certificate = True
            conn = new SqlConnection("Data Source = UNDIVIDED\\SQLEXPRESS; Initial Catalog = Employee; Integrated Security = True; TrustServerCertificate = True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            sql= "select * from auth where uname= '"+username+"'and pwd='"+password+"'";
            cmd= new SqlCommand(sql, conn);

            conn.Open();
            dr = cmd.ExecuteReader();
           
            if (dr.HasRows)//can use dr.Read() also
            {
                FormMenu fm = new FormMenu();
                fm.ShowDialog();
                this.Close();
            }

            conn.Close();
            cmd.Dispose();
        }
    }
}
