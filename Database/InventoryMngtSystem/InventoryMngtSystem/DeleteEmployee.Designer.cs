namespace InventoryMngtSystem
{
    partial class DeleteEmployee
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
            button7 = new Button();
            comboBox4 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(519, 274);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 73;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(536, 199);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(150, 33);
            comboBox4.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 202);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 71;
            label2.Text = "Employee Id";
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(button7);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private ComboBox comboBox4;
        private Label label2;
    }
}