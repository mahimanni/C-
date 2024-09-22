namespace AdminFacultyStudent
{
    public partial class Form1 : Form
    {
        public static string person = "";
        public static List<string> users = new List<string>();
        public static List<string> passwords = new List<string>();
        public static List<string> usertypes = new List<string>();

        public static Form1 Current;
        public Form1()
        {
            Current = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Faculty");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login
            person = comboBox1.Text;

            Label lblinvalid = new Label();
            lblinvalid.Location = new Point(300, 300);
            lblinvalid.Width = 300;
            this.Controls.Add(lblinvalid);

            if (comboBox1.Text == "Student")
            {
                if (loginValid())
                {
                    FormStudent stu = new FormStudent();
                    stu.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblinvalid.Text = "Invalid Username/Password";
                }
            }
            else if (comboBox1.Text == "Faculty")
            {
                if (loginValid())
                {
                    FormFaculty fac = new FormFaculty();
                    fac.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblinvalid.Text = "Invalid Username/Password";
                }
            }
            else if (comboBox1.Text == "Admin")
            {
                FormAdmin ad = new FormAdmin();
                ad.ShowDialog();
                //this.Close();
            }
            else
            {
                lblinvalid.Text = "Invalid User Type selected";
            }
        }

        private bool loginValid()
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i] == textBox1.Text)
                {
                    if (passwords[i] == textBox2.Text)
                    {
                        if (usertypes[i] == comboBox1.Text)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
