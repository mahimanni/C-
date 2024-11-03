namespace InventoryMngtSystem
{
    partial class FormSupplier
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
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(52, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 403);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button6
            // 
            button6.Location = new Point(15, 309);
            button6.Name = "button6";
            button6.Size = new Size(139, 34);
            button6.TabIndex = 1;
            button6.Text = "Orders";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(15, 254);
            button5.Name = "button5";
            button5.Size = new Size(139, 36);
            button5.TabIndex = 5;
            button5.Text = "Product";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(15, 198);
            button4.Name = "button4";
            button4.Size = new Size(139, 36);
            button4.TabIndex = 4;
            button4.Text = "Inventory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(15, 145);
            button3.Name = "button3";
            button3.Size = new Size(139, 36);
            button3.TabIndex = 3;
            button3.Text = "Supplier";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 92);
            button2.Name = "button2";
            button2.Size = new Size(139, 36);
            button2.TabIndex = 2;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(15, 41);
            button1.Name = "button1";
            button1.Size = new Size(139, 36);
            button1.TabIndex = 1;
            button1.Text = "Employee";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(groupBox1);
            Name = "FormSupplier";
            Text = "FormSupplier";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}