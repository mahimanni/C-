namespace DynamicTextBoxes
{
    public partial class Form1 : Form
    {
        public static string value;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sq");
            comboBox1.Items.Add("Pow");
            comboBox1.Items.Add("Min");
            comboBox1.Items.Add("Max");
            comboBox1.Items.Add("Abs");

            comboBox1.Items.Add("Length");
            comboBox1.Items.Add("ToUpper");
            comboBox1.Items.Add("Substring");
            comboBox1.Items.Add("Replace");
            comboBox1.Items.Add("CountChars");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = comboBox1.Text;
            FormFunction f = new FormFunction();
            f.ShowDialog();
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //value = comboBox1.Text;
        }
    }
}
