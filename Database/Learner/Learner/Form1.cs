using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace Learner
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

        //<------------------------------------------------------------------------------Creating Tables---------------------------------------------------------------------------------------------------------------->
        public void CreateTable()
        {
            try
            {
                // Creating Connection  
                conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

                // writing sql query  
                cmd = new SqlCommand("create table student(id int identity(1,1) primary key, name varchar(50), age int, gender varchar(1), email varchar(50), phoneno varchar(10), pwd varchar(20), course varchar(50), currentyear varchar(20), join_date date)", conn);
                cmd = new SqlCommand("create table teacher(tid int identity(1,1) primary key, tname varchar(50), tage int, tgender varchar(1), temail varchar(50), tphoneno varchar(10), tpwd varchar(20), tcourse varchar(50), texperience varchar(50), tqualification varchar(100), tjoin_date date)", conn);
                cmd = new SqlCommand("create table staff(sid int identity(1,1) primary key, sname varchar(50), sage int, sgender varchar(1), semail varchar(50), sphoneno varchar(10), spwd varchar(20), sjob varchar(50), sworkingyear varchar(50), squalification varchar(100), sjoin_date date)", conn);

                conn.Open();// Opening Connection
                cmd.ExecuteNonQuery();// Executing the SQL query  
                Console.WriteLine("Table created Successfully");// Displaying a message  
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                conn.Close();// Closing the connection
            }
        }

        //<------------------------------------------------------------------------------Inserting Tables---------------------------------------------------------------------------------------------------------------->
        public void InsertTable()
        {
            // Creating Connection  
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conn.Open();// Opening Connection
                // writing sql query  
                //for student
                cmd = new SqlCommand("insert into student  (name, age, gender, email, phoneno, pwd, course, currentyear, join_date)values('Ram', 21, 'M', 'ram@gmail.com', '8489078789', 'ram' , 'BBA', '3rd semester', '1/7/2022')" +
                    ",('Sita', 20, 'F', 'sita@gmail.com','8389054389', 'sita', 'BCA', '3rd semester', '10/7/2022')" +
                    ",('Manya', 20, 'F', 'manya@gmail.com','8354076389', 'manya', 'BCA', '3rd semester', '9/7/2023')" +
                    ",('Rahul', 23, 'M', 'rahul@gmail.com','8385876389', 'rahul', 'BVOC', '2nd semester', '7/8/2024')," +
                    "('Priya', 18, 'F', 'priya@gmail.com','8569076389', 'priya', 'BA', '1st semester', '8/7/2022')", conn);
                cmd.ExecuteNonQuery();


                //for teacher
                cmd = new SqlCommand("insert into teacher  (tname, tage, tgender, temail, tphoneno, tpwd, tcourse, texperience, tqualification, tjoin_date)values('Sk', 51, 'M', 'sk@gmail.com', '9389043389', 'sk','BSC', '10+ years', 'PHD', '11/8/2019')" +
                    ",('Sunil',51, 'M', 'sunil@gmail.com', '9343002389', 'sunil', 'BTECH', '7+ years', 'MTECH', '12/7/2020')" +
                    ",('Tarun',54, 'M', 'tarun@gmail.com', '8389076389', 'tarun', 'BA',  '5+ years', 'PHD',  '9/7/2013')" +
                    ",('Rahul',31, 'M', 'rahul@gmail.com', '8343002389', 'rahul', 'BVOC', '10+ years', 'MASTERS',  '12/8/2012')" +
                    ",('Shirly',38, 'F', 'shirly@gmail.com', '9679002389', 'shirly', 'BVOC',  '2+ years', 'PHD', '11/10/2016')", conn);
                cmd.ExecuteNonQuery();

                //for staff
                cmd = new SqlCommand("insert into staff (sname, sage, sgender, semail, sphoneno, spwd, sjob, sworkingyear, squalification, sjoin_date)values" +
                    "('Ramu', 21, 'M', 'ramu@gmail.com', '9140019727', 'ram', 'lab assistant', 'More than 5yrs', 'BBA', '1/7/2022')" +
                    ",('Prateek', 23, 'M', 'prateek@gmail.com','9389002389', 'prateek', 'staff assistant', 'More than 2yrs', 'BCA', '1/7/2022')" +
                    ",('Meena', 20, 'F', 'meena@gmail.com', '9124354908', 'meena', 'lab assistant', 'More than 5yrs', 'BCA', '1/7/2023')" +
                    ",('Rishi', 27, 'M', 'rishi@gmail.com', '9124354908', 'rishi', 'lab assistant', 'More than 2yrs', 'BVOC', '10/8/2024')" +
                    ",('Priyu', 23, 'F', 'priyu@gmail.com', '9124354908', 'priyu', 'assistant', 'Fresher', 'BBA', '1/7/2022')", conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Record Inserted Successfully");// Displaying a message  
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                conn.Close();// Closing the connection
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new Form1().CreateTable(); //to create student, teacher, staff tables
            //new Form1().InsertTable(); //to insert the records into tables
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Learner;Integrated Security=True;TrustServerCertificate=True");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Staff");

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
                //MessageBox.Show("Generated Captcha ID: " + d1.ToString());

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



        //<------------------------------------------------------------------------------Login Authorization--------------------------------------------------------------------------------------------------------------->
        private void button1_Click(object sender, EventArgs e)
        {
            string person, name, email, password;
            person = comboBox1.Text;
            name = textBox1.Text;
            email = textBox2.Text;
            password = textBox3.Text;
            if (person == "Student")
                sql = "select * from student where name='" + name + "'and email='" + email + "'and pwd='" + password + "'";
            else if (person == "Teacher")
                sql = "select * from teacher where tname='" + name + "'and temail='" + email + "'and tpwd='" + password + "'";
            else
                sql = "select * from staff where sname='" + name + "'and semail='" + email + "'and spwd='" + password + "'";

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
        }

        private void label7_Click(object sender, EventArgs e)
        {
            captchaDisplay(); // Reload a new captcha
        }
    }
}
