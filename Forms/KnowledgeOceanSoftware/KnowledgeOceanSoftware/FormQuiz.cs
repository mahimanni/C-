using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace KnowledgeOceanSoftware
{
    public partial class FormQuiz : Form
    {
        string catg = Form1.category;
        string subj = Form1.subject;
        public static int score = 0;
        System.Windows.Forms.Timer timer;

        GroupBox box = new GroupBox();

        Label ques = new Label();
        RadioButton ans1 = new RadioButton();
        RadioButton ans2 = new RadioButton();
        RadioButton ans3 = new RadioButton();
        RadioButton ans4 = new RadioButton();

        string[] correctAnsEng = { "sun", "5", "Africa", "Pacific Ocean", "50" };
        //int correctAnsNo = 0;
        List<string> correctAnsEngUser= new List<string>();
        List<int> repeated = new List<int>();

        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {Form1.name}";
            label2.Text = $"Category of the user : {catg}";
            label3.Text = $"Subject selected: {subj}";


            /*box.Location = new Point(200, 200);
            box.Size = new Size(400, 150);
            box.Text = "Question";
            box.Name = "box";
            this.Controls.Add(box);*/

            ques.Location = new Point(200, 200);
            ques.Text = "Question Label";
            ques.Size = new Size(500, 50);
            this.Controls.Add(ques);

            ans1.Location = new Point(250, 250);
            ans1.Size = new Size(150, 60);
            ans1.Text = "Option1";
            //ans1.BackColor = Color.Purple;
            this.Controls.Add(ans1);

            ans2.Location = new Point(250, 320);
            ans2.Size = new Size(150, 60);
            ans2.Text = "Option2";
            //ans2.BackColor = Color.Purple;
            this.Controls.Add(ans2);

            ans3.Location = new Point(400, 250);
            ans3.Size = new Size(150, 60);
            ans3.Text = "Option3";
            //ans3.BackColor = Color.Purple;
            this.Controls.Add(ans3);

            ans4.Location = new Point(400, 320);
            ans4.Size = new Size(150, 60);
            ans4.Text = "Option4";
            //ans4.BackColor = Color.Purple;
            this.Controls.Add(ans4);

            if (catg == "Primary")
            {
                if (subj == "English")
                {
                    english();
                }
                else if (subj == "Hindi")
                {
                    hindi();
                }
                else if (subj == "Maths")
                {
                    maths();
                }
                else
                {
                    label4.Text = "No such subject offered in this category";
                }
            }
            else if (catg == "Primary Senior")
            {
                if (subj == "Science")
                {
                    science();
                }
                else if (subj == "MT")
                {
                    mt();
                }
                else if (subj == "GK")
                {
                    gk();
                }
                else
                {
                    label4.Text = "No such subject offered in this category";
                }
            }
            else if (catg == "Secondary")
            {
                if (subj == "Physics")
                {
                    physics();
                }
                else if (subj == "Chemistry")
                {
                    chemistry();
                }
                else if (subj == "Biology")
                {
                    biology();
                }
                else
                {
                    label4.Text = "No such subject offered in this category";
                }
            }
            else if (catg == "Secondary Senior")
            {
                if (subj == "Database")
                {
                    db();
                }
                else if (subj == "Programming")
                {
                    programming();
                }
                else if (subj == "Operating System")
                {
                    os();
                }
                else
                {
                    label4.Text = "No such subject offered in this category";
                }
            }
            else if (catg == "Senior")
            {
                if (subj == "Machine Learning")
                {
                    ml();
                }
                else if (subj == "Artificial Intelligence")
                {
                    ai();
                }
                else if (subj == "Deep Learning")
                {
                    dl();
                }
                else
                {
                    label4.Text = "No such subject offered in this category";
                }
            }
            else
            {
                label4.Text = "No such category exists";
            }
        }

        //for primary
        public void english()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
            /*ques.Text = "Which word is a noun in this sentence: 'The sun is bright' ?";
            ans1.Text = "sun";
            ans2.Text = "bright";
            ans3.Text = "The";
            ans4.Text = "is";*/
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] quesEng = { "Which word is a noun in this sentence: 'The sun is bright' ?", "No of vowels in english alphabets", "In which continent is the Sahara Desert located?", "What is the largest ocean on Earth?", "How many states make up the United States of America?" };
            string[,] allans = { { "sun", "bright", "the", "is" }, { "6", "5", "4", "3" }, { "Asia", "America", "Africa", "Antarctica" }, { "Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean" }, { "40", "20", "60", "50" } };
            //string[] correctAnsEng = { "sun", "5", "Africa", "Pacific Ocean", "50" };
            int r;

            r = rnd.Next(0, 5); // Generates a random integer between 0 and 4
            if (!repeated.Contains(r))
            {
                ques.Text = quesEng[r];
                ans1.Text = allans[r, 0];
                ans2.Text = allans[r, 1];
                ans3.Text = allans[r, 2];
                ans4.Text = allans[r, 3];
                repeated.Add(r);

                checkSelectedRadiobutton();
            }
            if (repeated.Count == 3)
            {
                timer.Stop();
                calcScore();
                FormResult res = new FormResult();
                res.ShowDialog();
                this.Close();
            }
        }
        private void checkSelectedRadiobutton()
        {
            if (ans1.Checked == true)
                correctAnsEngUser.Add(ans1.Text);
            else if (ans2.Checked == true)
                correctAnsEngUser.Add(ans2.Text);
            else if (ans3.Checked == true)
                correctAnsEngUser.Add(ans3.Text);
            else //if (ans4.Checked == true)
                correctAnsEngUser.Add(ans4.Text);
        }
        private void calcScore()
        {
            label5.Text = correctAnsEngUser[0];
            label6.Text = correctAnsEngUser[1];
            label7.Text = correctAnsEngUser[2];
            //label8.Text = correctAnsEngUser[3];
            for (int i = 0; i < correctAnsEng.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < correctAnsEngUser.Count; j++)
                {
                    if (correctAnsEngUser[j] == correctAnsEng[i])
                    {
                        score += 3;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    score -= 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkSelectedRadiobutton();
        }
        public void maths()
        {
            ques.Text = "What is 2+2 ?";
            ans1.Text = "4";
            ans2.Text = "1";
            ans3.Text = "5";
            ans4.Text = "8";
        }
        public void hindi()
        {
            ques.Text = "Which is lipi of hindi ?";
            ans1.Text = "Devnagiri";
            ans2.Text = "Urdu";
            ans3.Text = "Farsi";
            ans4.Text = "English";
        }

        //for primary senior
        public void science()
        {
            ques.Text = "Process by which plants make food?";
            ans1.Text = "circulation";
            ans2.Text = "photosynthesis";
            ans3.Text = "cooking";
            ans4.Text = "respiration";
        }
        public void mt()
        {
            ques.Text = "Which word is not a good habit ?";
            ans1.Text = "smoking";
            ans2.Text = "bathing";
            ans3.Text = "helping others";
            ans4.Text = "kindness";
        }
        public void gk()
        {
            ques.Text = "Which is the capital of  Assam?";
            ans1.Text = "dispur";
            ans2.Text = "chattisgarh";
            ans3.Text = "lucknow";
            ans4.Text = "delhi";
        }

        //for secondary
        public void physics()
        {
            ques.Text = "What is force ?";
            ans1.Text = "mass*acceleration";
            ans2.Text = "pressure*area";
            ans3.Text = "both";
            ans4.Text = "none";
        }
        public void chemistry()
        {
            ques.Text = "Which is known as salt?";
            ans1.Text = "NaCL";
            ans2.Text = "HCL";
            ans3.Text = "O2";
            ans4.Text = "H2O";
        }
        public void biology()
        {
            ques.Text = "What is the chemical formula for water ?";
            ans1.Text = "NaCL";
            ans2.Text = "HCL";
            ans3.Text = "O2";
            ans4.Text = "H2O";
        }

        //for secondary senior
        public void db()
        {
            ques.Text = "What is trigger ?";
            ans1.Text = "special procedure";
            ans2.Text = "cursor";
            ans3.Text = "lock";
            ans4.Text = "procedure";
        }
        public void programming()
        {
            ques.Text = "Not a programming language ?";
            ans1.Text = "java";
            ans2.Text = "HCL";
            ans3.Text = "python";
            ans4.Text = "cobol";
        }
        public void os()
        {
            ques.Text = "Full form of fcfs?";
            ans1.Text = "First come";
            ans2.Text = "Last come";
            ans3.Text = "First come first serve";
            ans4.Text = "Middle come";
        }

        //for senior
        public void ml()
        {
            ques.Text = "What is ml?";
            ans1.Text = "Machine Learning";
            ans2.Text = "HCL";
            ans3.Text = "O2";
            ans4.Text = "H2O";
        }
        public void ai()
        {
            ques.Text = "What is ai?";
            ans1.Text = "NaCL";
            ans2.Text = "Aritificial Intelligence";
            ans3.Text = "O2";
            ans4.Text = "H2O";
        }
        public void dl()
        {
            ques.Text = "What is dl ?";
            ans1.Text = "NaCL";
            ans2.Text = "HCL";
            ans3.Text = "O2";
            ans4.Text = "Deep Learning";
        }
    }
}
