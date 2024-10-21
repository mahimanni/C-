namespace BasicsDiff2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                label1.Text = $"{progressBar1.Value} %";
                if (progressBar1.Value >= 100)
                {
                    progressBar1.Value = 0;
                }
            }
        }
    }
}
