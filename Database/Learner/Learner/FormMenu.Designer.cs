namespace Learner
{
    partial class FormMenu
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
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem1 = new ToolStripMenuItem();
            searchStudentCourseWiseToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherNameWiseToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherCourseWiseToolStripMenuItem = new ToolStripMenuItem();
            searchStaffToolStripMenuItem = new ToolStripMenuItem();
            searchStaffNameWiseToolStripMenuItem = new ToolStripMenuItem();
            searchStaffCourseWiseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem, searchTeacherToolStripMenuItem, searchStaffToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem1, searchStudentCourseWiseToolStripMenuItem });
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(151, 29);
            searchStudentToolStripMenuItem.Text = "Search Student ";
            // 
            // searchStudentToolStripMenuItem1
            // 
            searchStudentToolStripMenuItem1.Name = "searchStudentToolStripMenuItem1";
            searchStudentToolStripMenuItem1.Size = new Size(335, 34);
            searchStudentToolStripMenuItem1.Text = "Search Student Name Wise";
            searchStudentToolStripMenuItem1.Click += searchStudentToolStripMenuItem1_Click;
            // 
            // searchStudentCourseWiseToolStripMenuItem
            // 
            searchStudentCourseWiseToolStripMenuItem.Name = "searchStudentCourseWiseToolStripMenuItem";
            searchStudentCourseWiseToolStripMenuItem.Size = new Size(335, 34);
            searchStudentCourseWiseToolStripMenuItem.Text = "Search Student Course Wise";
            searchStudentCourseWiseToolStripMenuItem.Click += searchStudentCourseWiseToolStripMenuItem_Click;
            // 
            // searchTeacherToolStripMenuItem
            // 
            searchTeacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchTeacherNameWiseToolStripMenuItem, searchTeacherCourseWiseToolStripMenuItem });
            searchTeacherToolStripMenuItem.Name = "searchTeacherToolStripMenuItem";
            searchTeacherToolStripMenuItem.Size = new Size(143, 29);
            searchTeacherToolStripMenuItem.Text = "Search Teacher";
            // 
            // searchTeacherNameWiseToolStripMenuItem
            // 
            searchTeacherNameWiseToolStripMenuItem.Name = "searchTeacherNameWiseToolStripMenuItem";
            searchTeacherNameWiseToolStripMenuItem.Size = new Size(332, 34);
            searchTeacherNameWiseToolStripMenuItem.Text = "Search Teacher Name Wise";
            searchTeacherNameWiseToolStripMenuItem.Click += searchTeacherNameWiseToolStripMenuItem_Click;
            // 
            // searchTeacherCourseWiseToolStripMenuItem
            // 
            searchTeacherCourseWiseToolStripMenuItem.Name = "searchTeacherCourseWiseToolStripMenuItem";
            searchTeacherCourseWiseToolStripMenuItem.Size = new Size(332, 34);
            searchTeacherCourseWiseToolStripMenuItem.Text = "Search Teacher Course Wise";
            searchTeacherCourseWiseToolStripMenuItem.Click += searchTeacherCourseWiseToolStripMenuItem_Click;
            // 
            // searchStaffToolStripMenuItem
            // 
            searchStaffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStaffNameWiseToolStripMenuItem, searchStaffCourseWiseToolStripMenuItem });
            searchStaffToolStripMenuItem.Name = "searchStaffToolStripMenuItem";
            searchStaffToolStripMenuItem.Size = new Size(121, 29);
            searchStaffToolStripMenuItem.Text = "Search Staff";
            // 
            // searchStaffNameWiseToolStripMenuItem
            // 
            searchStaffNameWiseToolStripMenuItem.Name = "searchStaffNameWiseToolStripMenuItem";
            searchStaffNameWiseToolStripMenuItem.Size = new Size(302, 34);
            searchStaffNameWiseToolStripMenuItem.Text = "Search Staff Name Wise";
            searchStaffNameWiseToolStripMenuItem.Click += searchStaffNameWiseToolStripMenuItem_Click;
            // 
            // searchStaffCourseWiseToolStripMenuItem
            // 
            searchStaffCourseWiseToolStripMenuItem.Name = "searchStaffCourseWiseToolStripMenuItem";
            searchStaffCourseWiseToolStripMenuItem.Size = new Size(302, 34);
            searchStaffCourseWiseToolStripMenuItem.Text = "Search Staff Job Wise";
            searchStaffCourseWiseToolStripMenuItem.Click += searchStaffCourseWiseToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem1;
        private ToolStripMenuItem searchStudentCourseWiseToolStripMenuItem;
        private ToolStripMenuItem searchTeacherToolStripMenuItem;
        private ToolStripMenuItem searchTeacherNameWiseToolStripMenuItem;
        private ToolStripMenuItem searchTeacherCourseWiseToolStripMenuItem;
        private ToolStripMenuItem searchStaffToolStripMenuItem;
        private ToolStripMenuItem searchStaffNameWiseToolStripMenuItem;
        private ToolStripMenuItem searchStaffCourseWiseToolStripMenuItem;
    }
}