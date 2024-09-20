namespace ComboBoxBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //adding items in comboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kiwi");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Apple");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;//retrieve data from combobox and showing it in textbox

            string x = textBox1.Text;
            if (x == "Mango")
            {
                label1.Text = "My Favorite";
            }
            else
            {
                label1.Text = "I will eat";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Items.Clear();
        }
    }
}
