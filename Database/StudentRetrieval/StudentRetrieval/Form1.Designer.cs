namespace StudentRetrieval
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(289, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 432);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Details";
            // 
            // button5
            // 
            button5.Location = new Point(141, 311);
            button5.Name = "button5";
            button5.Size = new Size(88, 34);
            button5.TabIndex = 8;
            button5.Text = "UPLOAD";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(141, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 216);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Photo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 164);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 112);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(289, 460);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 106);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controls";
            // 
            // button4
            // 
            button4.Location = new Point(297, 49);
            button4.Name = "button4";
            button4.Size = new Size(86, 34);
            button4.TabIndex = 3;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(198, 49);
            button3.Name = "button3";
            button3.Size = new Size(93, 34);
            button3.TabIndex = 2;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 49);
            button2.Name = "button2";
            button2.Size = new Size(85, 34);
            button2.TabIndex = 1;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 49);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 0;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(248, 25);
            label5.TabIndex = 3;
            label5.Text = "Select Id to display the details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}
