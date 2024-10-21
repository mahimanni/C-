namespace RichTextBoxBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();//Creating a label
            label1.Location = new Point(300, 100);
            label1.Text = "Greetings";
            this.Controls.Add(label1);

            RichTextBox box = new RichTextBox();//Creating a RichTextBox control
            box.Location = new Point(300, 150);//setting location:
            //get or set the coordinates of the upper-left corner of the RichTextBox control relative to the upper-left corner of its form
            box.BackColor = Color.Aqua;//setting background color
            box.ForeColor = Color.DarkBlue;
            box.Text = "Welcome users:)";//setting text
            box.AutoSize= true;//get or set a value that indicates whether the control resizes based on its contents.
            box.BorderStyle = BorderStyle.FixedSingle;//border style for the control
            box.Font = new Font("Times New Roman", 18);
            /*box.Height = 100;
            box.Width = 250;*/
            box.Name = "box";//get or set the name of the control
            box.TabStop = false;//used to get or set a value that shows whether the user can press the TAB key to provide the focus to the NumericUpDown
            box.Size = new Size(250, 100);//width,height
            box.Visible = true;//get or set a value indicating whether the control and all its child controls are displayed
            //box.ZoomFactor = 2;// used to get or set the current zoom level of the RichTextBox
            box.ScrollBars = RichTextBoxScrollBars.Vertical;//get or set the type of scroll bars to display in the RichTextBox control
            //box.ShowSelectionMargin = true;//get or set a value indicating whether a selection margin is displayed in the RichTextBox
            //box.SelectionTabs = new TabControl[]{50, 100, 150};//get or set the absolute tab stop positions in a RichTextBox control
            //box.SelectedText = "Hello";//to get or set the selected text within the RichTextBox
            box.Multiline = true;//to get or set a value indicating whether this is a multiline RichTextBox control

            this.Controls.Add(box);//adding this RichTextBox in the form

        }
    }
}
