using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace School
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;

        //<------------------------------------------------------------------------------Creating Tables---------------------------------------------------------------------------------------------------------------->
        public void CreateTable()
        {
            try
            {
                // Creating Connection  
                conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;TrustServerCertificate=True");

                // writing sql query  
                cmd = new SqlCommand("create table student(id int identity(1,1) primary key, name varchar(50), email varchar(50), course varchar(50), join_date date)", conn);
                cmd = new SqlCommand("create table teacher(tid int identity(1,1) primary key, tname varchar(50), temail varchar(50), tcourse varchar(50), tqualification varchar(100), tjoin_date date)", conn);
                cmd = new SqlCommand("create table staff(sid int identity(1,1) primary key, sname varchar(50), semail varchar(50), sjob varchar(50), squalification varchar(100), sjoin_date date)", conn);

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
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                // writing sql query  
                //for student
                cmd = new SqlCommand("insert into student  (name, email, course, join_date)values('Ram', 'ram@gmail.com', 'bba', '1/7/2022')" +
                    ",('Sita', 'sita@gmail.com', 'bca', '1/7/2022')" +
                    ",('Manya', 'manya@gmail.com', 'bca', '1/7/2023')" +
                    ",('Rahul', 'rahul@gmail.com', 'bvoc', '10/8/2024')," +
                    "('Priya', 'priya@gmail.com', 'bba', '1/7/2022')", conn);

                //for teacher
                cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Sk', 'sk@gmail.com', 'bsc', 'phd', '11/8/2019')" +
                    ",('Sunil', 'sunil@gmail.com', 'btech', 'mtech', convert(datetime,'12/7/2020'))" +
                    ",('Tarun', 'tarun@gmail.com', 'ba', 'phd', convert(datetime,'9/7/2013'))" +
                    ",('Rahul', 'rahul@gmail.com', 'bvoc', 'convert(datetime,'12/8/2012'))," +
                    "('Shirly', 'shirly@gmail.com', 'bvoc', 'phd', convert(datetime,'11/10/2016'))", conn);

                //in sql
                /*insert into teacher(tname, temail, tcourse, tqualification, tjoin_date)
                    values('Sk', 'sk@gmail.com', 'bsc', 'phd', '11/8/2019')
                    ,('Sunil', 'sunil@gmail.com', 'btech', 'mtech', convert(datetime, '2/7/2020'))
                    ,('Tarun', 'tarun@gmail.com', 'ba', 'phd', convert(datetime, '9/7/2013'))
                    ,('Rahul', 'rahul@gmail.com', 'bca', 'mca', convert(datetime, '12/8/2012'))
                    ,('Shirly', 'shirly@gmail.com', 'bvoc', 'phd', convert(datetime, '11/10/2016'));*/

                //cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Sk', 'sk@gmail.com', 'bsc', 'phd', '11/8/2019')" , conn);
                //cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Sunil', 'sunil@gmail.com', 'btech', 'mtech', '12/7/2020')", conn);
                //cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Tarun', 'tarun@gmail.com', 'ba', 'phd', '13/7/2013')" , conn);
                //cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Rahul', 'rahul@gmail.com', 'bca', 'mca', '16/8/2012')" , conn);
                //cmd = new SqlCommand("insert into teacher  (tname, temail, tcourse, tqualification, tjoin_date)values('Shirly', 'shirly@gmail.com', 'bvoc', 'phd', '17/10/2016')", conn);

                //for staff
                cmd = new SqlCommand("insert into staff (sname, semail, sjob, squalification,  sjoin_date)values('Ramu', 'ramu@gmail.com', 'lab assistant', 'bba', '1/7/2022')" +
                    ",('Prateek', 'prateek@gmail.com', 'lab assistant', 'bca', '1/7/2022')" +
                    ",('Meena', 'meena@gmail.com', 'lab assistant', 'bca', '1/7/2023')" +
                    ",('Rishi', 'rishi@gmail.com', 'lab assistant', 'bvoc', '10/8/2024')" +
                    ",('Priyu', 'priyu@gmail.com', 'lab assistant', 'bba', '1/7/2022')", conn);

                conn.Open();// Opening Connection
                cmd.ExecuteNonQuery();// Executing the SQL query  
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

            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;TrustServerCertificate=True");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Staff");
        }

        //<------------------------------------------------------------------------------Login Authorization--------------------------------------------------------------------------------------------------------------->
        private void button1_Click(object sender, EventArgs e)
        {
            string person, name, email;
            person = comboBox1.Text;
            name = textBox1.Text;
            email = textBox2.Text;
            if (person == "Student")
                sql = "select * from student where name='" + name + "'and email='" + email + "'";
            else if (person == "Teacher")
                sql = "select * from teacher where tname='" + name + "'and temail='" + email + "'";
            else
                sql = "select * from staff where sname='" + name + "'and semail='" + email + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                FormMenu fm = new FormMenu();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or email or category");
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();
        }
    }
}
