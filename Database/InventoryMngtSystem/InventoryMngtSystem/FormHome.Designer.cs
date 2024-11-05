namespace InventoryMngtSystem
{
    partial class FormHome
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
            label3 = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 541);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 11;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(457, 495);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(197, 34);
            progressBar1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(282, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("YouYuan", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(457, 129);
            label2.Name = "label2";
            label2.Size = new Size(262, 36);
            label2.TabIndex = 8;
            label2.Text = "RMs Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 78);
            label1.Name = "label1";
            label1.Size = new Size(508, 33);
            label1.TabIndex = 7;
            label1.Text = "Inventory Management Software";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}