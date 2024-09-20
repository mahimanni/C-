namespace TextShiftComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for adding selected item from comboBox1 to comboBox2 (>)
            comboBox2.Items.Add(comboBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //for adding selected item from comboBox2 to comboBox1 (<)
            comboBox1.Items.Add(comboBox2.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //for adding all items from comboBox1 to comboBox2
            string value;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                value = comboBox1.GetItemText(comboBox1.Items[i]);
                comboBox2.Items.Add(value);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //for adding all items from comboBox2 to comboBox1
            string value;
            for(int i = 0; i < comboBox2.Items.Count; i++)
            {
                value = comboBox2.GetItemText(comboBox2.Items[i]);
                comboBox1.Items.Add(value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("npgc");
            comboBox1.Items.Add("bbd");
            comboBox1.Items.Add("lu");

            comboBox2.Items.Add("srmu");
            comboBox2.Items.Add("rmlu");
        }
    }
}
