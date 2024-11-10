namespace InventoryMngtSystem
{
    partial class ShowCustomer
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
            dataGridViewCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(47, 48);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new Size(1062, 560);
            dataGridViewCustomer.TabIndex = 0;
            // 
            // ShowCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(dataGridViewCustomer);
            Name = "ShowCustomer";
            Text = "ShowCustomer";
            Load += ShowCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCustomer;
    }
}