namespace Learner
{
    partial class FormAdminMenu
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            addRecordsToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentEntryToolStripMenuItem = new ToolStripMenuItem();
            addNewTeacherEntryToolStripMenuItem = new ToolStripMenuItem();
            addNewStaffEntryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { addRecordsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // addRecordsToolStripMenuItem
            // 
            addRecordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentEntryToolStripMenuItem, addNewTeacherEntryToolStripMenuItem, addNewStaffEntryToolStripMenuItem });
            addRecordsToolStripMenuItem.Name = "addRecordsToolStripMenuItem";
            addRecordsToolStripMenuItem.Size = new Size(130, 29);
            addRecordsToolStripMenuItem.Text = "Add Records";
            // 
            // addNewStudentEntryToolStripMenuItem
            // 
            addNewStudentEntryToolStripMenuItem.Name = "addNewStudentEntryToolStripMenuItem";
            addNewStudentEntryToolStripMenuItem.Size = new Size(299, 34);
            addNewStudentEntryToolStripMenuItem.Text = "Add New Student Entry";
            addNewStudentEntryToolStripMenuItem.Click += addNewStudentEntryToolStripMenuItem_Click;
            // 
            // addNewTeacherEntryToolStripMenuItem
            // 
            addNewTeacherEntryToolStripMenuItem.Name = "addNewTeacherEntryToolStripMenuItem";
            addNewTeacherEntryToolStripMenuItem.Size = new Size(299, 34);
            addNewTeacherEntryToolStripMenuItem.Text = "Add New Teacher Entry";
            addNewTeacherEntryToolStripMenuItem.Click += addNewTeacherEntryToolStripMenuItem_Click;
            // 
            // addNewStaffEntryToolStripMenuItem
            // 
            addNewStaffEntryToolStripMenuItem.Name = "addNewStaffEntryToolStripMenuItem";
            addNewStaffEntryToolStripMenuItem.Size = new Size(299, 34);
            addNewStaffEntryToolStripMenuItem.Text = "Add New Staff Entry";
            addNewStaffEntryToolStripMenuItem.Click += addNewStaffEntryToolStripMenuItem_Click;
            // 
            // FormAdminMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "FormAdminMenu";
            Text = "FormAdminMenu";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addRecordsToolStripMenuItem;
        private ToolStripMenuItem addNewStudentEntryToolStripMenuItem;
        private ToolStripMenuItem addNewTeacherEntryToolStripMenuItem;
        private ToolStripMenuItem addNewStaffEntryToolStripMenuItem;
    }
}