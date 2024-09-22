namespace ListBoxBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adding items in the ListBox
            listBox1.Items.Add("Mango");
            listBox1.Items.Add("Apple");
            listBox1.Items.Add("Kiwi");

            ListBox  listBox2= new ListBox();
            listBox2.Location = new Point(300, 300);
            listBox2.Size = new Size(220, 150);
            //listBox2.AutoSize = true;
            listBox2.BackColor = Color.LightBlue;
            listBox2.ForeColor= Color.DarkBlue;
            listBox2.BorderStyle = BorderStyle.None;//Fixed3D
            //listBox2.Height = 120;
            //listBox2.Width = 200;
            listBox2.Font = new Font("Times New Roman",18);

            //listBox2.Text = "Enter your number:";
            listBox2.TabStop = true;

            listBox2.Items.Add(123);
            listBox2.Items.Add(456);

            listBox2.Name = "listBox2";
            this.Controls.Add(listBox2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying selected listbox elt in textbox
            textBox1.Text = listBox1.Text;
            //printing on label for some specific text in textbox
            String x = textBox1.Text;
            if (x == "Mango")
            {
                label1.Text = "Favorite";
            }
            else
            {
                label1.Text = x;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //removing item written in textbox from the listbox
            listBox1.Items.Remove(textBox1.Text);

            //removing all items from the listbox
            //listBox1.Items.Clear();
        }
    }
}
