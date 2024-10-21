using System.Data.SqlClient;

namespace DatabaseConn2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAB4PC5\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            sql = "select * from auth where uname='" + username + "' and pwd= '" + password + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();
        }
    }
}
