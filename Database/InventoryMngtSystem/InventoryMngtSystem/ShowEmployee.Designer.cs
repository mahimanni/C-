namespace InventoryMngtSystem
{
    partial class ShowEmployee
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
            dataGridViewEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(69, 59);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 62;
            dataGridViewEmployee.Size = new Size(1041, 527);
            dataGridViewEmployee.TabIndex = 1;
            // 
            // ShowEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(dataGridViewEmployee);
            Name = "ShowEmployee";
            Text = "ShowEmployee";
            Load += ShowEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmployee;
    }
}