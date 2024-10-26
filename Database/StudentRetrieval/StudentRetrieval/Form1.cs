using System.Data.SqlClient;
namespace StudentRetrieval
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
            conn = new SqlConnection("Data Source=UNDIVIDED\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True;TrustServerCertificate=True");
            showInComboBox();
        }

        private void showInComboBox()
        {
            comboBox1.Items.Clear();
            //for disabling the controls
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            pictureBox1.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;

            int idVal = 0;
            sql = "select max(id) from emp";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string x = dr[0].ToString();
                    idVal = Convert.ToInt32(x);
                }
            }
            for (int i = 1; i <= idVal; i++)//displaying ids in the comboBox items from 1 to maximum id
            {
                comboBox1.Items.Add(i);
            }
            conn.Close();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //for Save
        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBox2.Text, user_address = textBox3.Text;
            conn.Open();
            sql = "insert into emp(name, address, photo)values(@name, @address, @photo);" + "select scope_identity();";
            cmd = new SqlCommand(sql, conn);

            if (pictureBox1.Image == null || string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(user_address))
            {
                MessageBox.Show("Please enter all the fields first");
                return;
            }
            byte[] user_photo = ImageToByteArray(pictureBox1.Image);
            cmd.Parameters.AddWithValue("@name", user_name);
            cmd.Parameters.AddWithValue("@address", user_address);
            cmd.Parameters.AddWithValue("@photo", user_photo);

            object newId = cmd.ExecuteScalar();
            if (newId != null)
                MessageBox.Show("Record inserted successfully. New ID: " + newId.ToString());
            else
                MessageBox.Show("Record inserted, but could not retrieve the ID.");

            conn.Close();
            cmd.Dispose();

            showInComboBox();
        }

        //for New
        private void button2_Click(object sender, EventArgs e)
        {
            //on clicking the new button we can give value of name photo(upload it also) and can save it, cannot give id still
            //textBox1.Clear();
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;

            textBox2.Enabled = true;
            pictureBox1.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
        }

        //for Update
        private void button3_Click(object sender, EventArgs e)
        {
            //id, name and photo should not be changed so updation can be done on address part only
            sql = "update emp set address='" + textBox3.Text + "'where id='" + textBox1.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0) { MessageBox.Show("Record Updated"); }
            conn.Close();
            cmd.Dispose();
        }

        //for Delete
        private void button4_Click(object sender, EventArgs e)
        {
            //as id is the unique parameter here
            sql = "delete from emp where id='" + textBox1.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0) { MessageBox.Show("Record Deleted"); }
            conn.Close();
            cmd.Dispose();
        }

        //For selecting or uploading the image
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idStr = comboBox1.Text;
            int id = Convert.ToInt32(idStr);
            conn.Open();
            sql = "select * from emp where id=" + id + "";
            cmd= new SqlCommand(sql, conn);
            dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["id"].ToString();
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["address"].ToString();
                // Check if the photo column is not null
                if (dr["photo"] != DBNull.Value)
                {
                    byte[] photoData = (byte[])dr["photo"];// Get the byte array from the photo column

                    // Convert the byte array to an Image and display it in the PictureBox
                    pictureBox1.Image = ByteArrayToImage(photoData);
                }
                else
                {
                    MessageBox.Show("No photo available for this record.");
                }
            }
            conn.Close();
            showInComboBox();
        }

        // Helper function to convert a byte array to an Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
