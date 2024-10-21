using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DatabaseConn2
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAB4PC5\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);

            //sql = "select * from employee_details where NAME='" + name + "'";
            sql= "select * from employee_details";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                }
            }
            /*else
            {
                MessageBox.Show("Invalid username or password");
            }*/
            conn.Close();
            dr.Close();
            cmd.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = listBox1.Text;
            sql = "select * from employee_details where NAME='" + name + "'";
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();

                }
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
