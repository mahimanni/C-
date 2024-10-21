using Microsoft.VisualBasic.ApplicationServices;

namespace KnowledgeOceanSoftware
{
    public partial class Form1 : Form
    {
        /*"C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s1.jpg"
        "C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s2.jpg"
        "C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s3.jpg"
        "C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s4.jpg"
        "C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s5.jpg"
        */
        int i = 2;
        int j = 5;
        int flag = 0;

        public static string name, category = "none", subject;
        string text;
        int textNo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // adding the age options
            for (int k = 5; k <= 30; k++)
            {
                comboBox1.Items.Add(k.ToString());
            }
        }

        //for displaying pictures with < > button on the login window page
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = @"C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s2";
            pictureBox1.ImageLocation = @$"C:\Users\manni\source\repos\C#\Forms\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s2";
            pictureBox1.Load();
        }

        private void button1_Click(object sender, EventArgs e)// > to move the image forward
        {
            if (i > 5)
            {
                i = 1;
            }
            if (i == 2 && flag == 0)
            {
                j = i - 1;
            }
            else
            {
                j = i;
            }
            //pictureBox1.ImageLocation = @$"C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s{i}.jpg";
            pictureBox1.ImageLocation = @$"C:\Users\manni\source\repos\C#\Forms\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s{i}.jpg";
            pictureBox1.Load();
            i += 1;
            flag = 1;
        }

        private void button2_Click(object sender, EventArgs e)// < to move the image backward
        {
            if (j < 1)
            {
                j = 5;
            }
            //pictureBox1.ImageLocation = @$"C:\Users\NPGC LAB 4\source\repos\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s{j}.jpg"
            pictureBox1.ImageLocation = @$"C:\Users\manni\source\repos\C#\Forms\KnowledgeOceanSoftware\KnowledgeOceanSoftware\assests\s{j}.jpg";
            pictureBox1.Load();
            j -= 1;
        }


        // for finding out the category acc to range of age and then adding options of the subj acc to that category
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            text = comboBox1.Text;
            textNo = int.Parse(text);
            if (textNo >= 5 && textNo <= 10)
            {
                category = "Primary";
                comboBox2.Items.Add("English");
                comboBox2.Items.Add("Hindi");
                comboBox2.Items.Add("Maths");
            }
            else if (textNo >= 11 && textNo <= 15)
            {
                comboBox2.Items.Clear();
                category = "Primary Senior";
                comboBox2.Items.Add("Science");
                comboBox2.Items.Add("MT");
                comboBox2.Items.Add("GK");
            }
            else if (textNo >= 16 && textNo <= 20)
            {
                comboBox2.Items.Clear();
                category = "Secondary";
                comboBox2.Items.Add("Physics");
                comboBox2.Items.Add("Chemistry");
                comboBox2.Items.Add("Biology");
            }
            else if (textNo >= 21 && textNo <= 25)
            {
                comboBox2.Items.Clear();
                category = "Secondary Senior";
                comboBox2.Items.Add("Database");
                comboBox2.Items.Add("Programming");
                comboBox2.Items.Add("Operating System");
            }
            else if (textNo >= 26 && textNo <= 30)
            {
                comboBox2.Items.Clear();
                category = "Senior";
                comboBox2.Items.Add("Machine Learning");
                comboBox2.Items.Add("Artificial Intelligence");
                comboBox2.Items.Add("Deep Learning");
            }
            else
            {
                comboBox2.Items.Clear();
                category = "Invalid";
                comboBox2.Items.Add("No option available");
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;// for taking the name of the user
            subject = comboBox2.Text;// for taking the selected subject
            label6.Text = subject;
            //creating new form for the quizes section which will be handled acc to the category and the subject selected in that category
            FormQuiz f = new FormQuiz();
            f.ShowDialog();
            f.Close();
        }

    }
}
