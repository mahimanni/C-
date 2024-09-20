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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = comboBox1.Text;
            FormFunction f = new FormFunction();
            f.ShowDialog();
            this.Close();
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //value = comboBox1.Text;
        }
    }
}
