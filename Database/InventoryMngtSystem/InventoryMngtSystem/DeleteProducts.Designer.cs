namespace InventoryMngtSystem
{
    partial class DeleteProducts
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
            label2 = new Label();
            comboBox4 = new ComboBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 168);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Product Id";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(460, 165);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(150, 33);
            comboBox4.TabIndex = 66;
            // 
            // button7
            // 
            button7.Location = new Point(443, 240);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 67;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // DeleteProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(button7);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Name = "DeleteProducts";
            Text = "DeleteProducts";
            Load += DeleteProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox4;
        private Button button7;
    }
}