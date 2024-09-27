namespace MenuStripBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gallery of products(clothes, grocies)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParent1 mf = new MDIParent1();
            mf.ShowDialog();
            this.Close();
        }
    }
}
