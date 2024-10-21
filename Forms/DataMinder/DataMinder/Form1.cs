namespace DataMinder
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //adding timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label3.Text = $"Loading {progressBar1.Value} %";
            }
            else if (progressBar1.Value == 100)
            {
                timer.Stop();
                FormLogin log = new FormLogin();
                log.ShowDialog();
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
