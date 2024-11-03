using System.Data.SqlClient;
using System.Xml.Serialization;
namespace InventoryMngtSystem
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd, cmd1;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;
        Random r = new Random();
        string val = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void createTable()
        {
            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");
            //Server=localhost;Database=master;Trusted_Connection=True;

            // writing sql query  
            cmd = new SqlCommand("create table customer(id int identity(1,1) primary key, name varchar(50), age int, gender varchar(1), email varchar(50), phoneno varchar(10), pwd varchar(20), address varchar(100), pincode varchar(10), state varchar(100))", conn);
            
            conn.Open();// Opening Connection
            cmd.ExecuteNonQuery();// Executing the SQL query  
            Console.WriteLine("Table created Successfully");// Displaying a message 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;TrustServerCertificate=True");
            createTable();
            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Customer");
            captchaDisplay();
        }

        //<------------------------------------------------------------------------------Captcha Display---------------------------------------------------------------------------------------------------------------->
        private void captchaDisplay()
        {
            try
            {
                conn.Open();

                // Generate a random number for selecting captcha image
                int d1 = r.Next(1, 11); //as there are 10 captcha images in the database (1 to 10)

                // First query to get captcha details
                using (cmd1 = new SqlCommand("SELECT id, imgpath, imgval FROM imgcaptcha WHERE id = @id", conn))
                {
                    // Use parameters to avoid SQL injection and handle query properly
                    cmd1.Parameters.AddWithValue("@id", d1);

                    using (dr = cmd1.ExecuteReader())
                    {
                        if (dr.Read()) // If data exists
                        {
                            val = dr["imgval"].ToString(); // The correct value to match with user input
                            string imgPath = dr["imgpath"].ToString(); // The path to the image

                            if (System.IO.File.Exists(imgPath)) // Check if the file exists
                            {
                                pictureBox1.Image = Image.FromFile(imgPath); // Load and display the image
                            }
                            else
                            {
                                MessageBox.Show("Captcha image not found at the specified path.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Captcha not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying the captcha: " + ex.Message);
            }
            finally
            {
                dr?.Close(); // Ensure the SqlDataReader is closed
                conn.Close(); // Ensure the connection is closed
                cmd1?.Dispose(); // Dispose of SqlCommand to release resources
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            captchaDisplay(); // Reload a new captcha
        }

        //<------------------------------------------------------------------------------Login Authorization--------------------------------------------------------------------------------------------------------------->
        private void button1_Click(object sender, EventArgs e)
        {
            string person, name, email, password;
            person = comboBox1.Text;
            name = textBox1.Text;
            email = textBox2.Text;
            password = textBox3.Text;
            if (person == "User")
                sql = "select * from user where name='" + name + "'and email='" + email + "'and pwd='" + password + "'";
            else if (person == "Customer")
                sql = "select * from customer where cname='" + name + "'and cemail='" + email + "'and cpwd='" + password + "'";

            conn.Open();
            using (cmd = new SqlCommand(sql, conn))
            {
                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows && textBox4.Text == val)//String.Equals(textBox4.Text,val)
                    {
                        FormMenu fm = new FormMenu();
                        fm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/email or password or category");
                    }
                }
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();
        }

        //for login window of the Admin
        private void label5_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.ShowDialog();
            this.Close();
        }

        //Signup Window
        private void label8_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            fc.ShowDialog();
            this.Close();
        }
    }
}
