namespace Learner
{
    partial class FormHomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 26);
            label1.Name = "label1";
            label1.Size = new Size(449, 33);
            label1.TabIndex = 0;
            label1.Text = "Learning Platform Software";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("YouYuan", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(246, 77);
            label2.Name = "label2";
            label2.Size = new Size(224, 36);
            label2.TabIndex = 1;
            label2.Text = "Learnsphere";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(71, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(246, 443);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(197, 34);
            progressBar1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 489);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // FormHomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHomeScreen";
            Text = "FormHomeScreen";
            Load += FormHomeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label3;
    }
}