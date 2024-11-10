namespace InventoryMngtSystem
{
    partial class ShowSupplier
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
            dataGridViewSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSupplier
            // 
            dataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplier.Location = new Point(69, 59);
            dataGridViewSupplier.Name = "dataGridViewSupplier";
            dataGridViewSupplier.RowHeadersWidth = 62;
            dataGridViewSupplier.Size = new Size(1041, 527);
            dataGridViewSupplier.TabIndex = 1;
            // 
            // ShowSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(dataGridViewSupplier);
            Name = "ShowSupplier";
            Text = "ShowSupplier";
            Load += ShowSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSupplier;
    }
}