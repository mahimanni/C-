namespace School
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
            addRecordToolStripMenuItem = new ToolStripMenuItem();
            newStudentRecordToolStripMenuItem = new ToolStripMenuItem();
            newTeacherEntryToolStripMenuItem = new ToolStripMenuItem();
            newStaffEntryToolStripMenuItem = new ToolStripMenuItem();
            searchRecordToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            searchStudentCourseWiseToolStripMenuItem = new ToolStripMenuItem();
            searchStudentNameWiseToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherCourseWiseToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherNameWiseToolStripMenuItem = new ToolStripMenuItem();
            searchStaffToolStripMenuItem = new ToolStripMenuItem();
            searchStaffJobWiseToolStripMenuItem = new ToolStripMenuItem();
            searchStaffNameWiseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addRecordToolStripMenuItem, searchRecordToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addRecordToolStripMenuItem
            // 
            addRecordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newStudentRecordToolStripMenuItem, newTeacherEntryToolStripMenuItem, newStaffEntryToolStripMenuItem });
            addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            addRecordToolStripMenuItem.Size = new Size(122, 29);
            addRecordToolStripMenuItem.Text = "Add Record";
            // 
            // newStudentRecordToolStripMenuItem
            // 
            newStudentRecordToolStripMenuItem.Name = "newStudentRecordToolStripMenuItem";
            newStudentRecordToolStripMenuItem.Size = new Size(260, 34);
            newStudentRecordToolStripMenuItem.Text = "New Student Entry";
            newStudentRecordToolStripMenuItem.Click += newStudentRecordToolStripMenuItem_Click;
            // 
            // newTeacherEntryToolStripMenuItem
            // 
            newTeacherEntryToolStripMenuItem.Name = "newTeacherEntryToolStripMenuItem";
            newTeacherEntryToolStripMenuItem.Size = new Size(260, 34);
            newTeacherEntryToolStripMenuItem.Text = "New Teacher Entry";
            newTeacherEntryToolStripMenuItem.Click += newTeacherEntryToolStripMenuItem_Click;
            // 
            // newStaffEntryToolStripMenuItem
            // 
            newStaffEntryToolStripMenuItem.Name = "newStaffEntryToolStripMenuItem";
            newStaffEntryToolStripMenuItem.Size = new Size(260, 34);
            newStaffEntryToolStripMenuItem.Text = "New Staff Entry";
            newStaffEntryToolStripMenuItem.Click += newStaffEntryToolStripMenuItem_Click;
            // 
            // searchRecordToolStripMenuItem
            // 
            searchRecordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem, searchTeacherToolStripMenuItem, searchStaffToolStripMenuItem });
            searchRecordToolStripMenuItem.Name = "searchRecordToolStripMenuItem";
            searchRecordToolStripMenuItem.Size = new Size(140, 29);
            searchRecordToolStripMenuItem.Text = "Search Record";
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentCourseWiseToolStripMenuItem, searchStudentNameWiseToolStripMenuItem });
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(270, 34);
            searchStudentToolStripMenuItem.Text = "Search Student";
            // 
            // searchStudentCourseWiseToolStripMenuItem
            // 
            searchStudentCourseWiseToolStripMenuItem.Name = "searchStudentCourseWiseToolStripMenuItem";
            searchStudentCourseWiseToolStripMenuItem.Size = new Size(340, 34);
            searchStudentCourseWiseToolStripMenuItem.Text = "Search  Student Course Wise";
            searchStudentCourseWiseToolStripMenuItem.Click += searchStudentCourseWiseToolStripMenuItem_Click;
            // 
            // searchStudentNameWiseToolStripMenuItem
            // 
            searchStudentNameWiseToolStripMenuItem.Name = "searchStudentNameWiseToolStripMenuItem";
            searchStudentNameWiseToolStripMenuItem.Size = new Size(340, 34);
            searchStudentNameWiseToolStripMenuItem.Text = "Search Student Name Wise";
            searchStudentNameWiseToolStripMenuItem.Click += searchStudentNameWiseToolStripMenuItem_Click;
            // 
            // searchTeacherToolStripMenuItem
            // 
            searchTeacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchTeacherCourseWiseToolStripMenuItem, searchTeacherNameWiseToolStripMenuItem });
            searchTeacherToolStripMenuItem.Name = "searchTeacherToolStripMenuItem";
            searchTeacherToolStripMenuItem.Size = new Size(270, 34);
            searchTeacherToolStripMenuItem.Text = "Search Teacher";
            // 
            // searchTeacherCourseWiseToolStripMenuItem
            // 
            searchTeacherCourseWiseToolStripMenuItem.Name = "searchTeacherCourseWiseToolStripMenuItem";
            searchTeacherCourseWiseToolStripMenuItem.Size = new Size(332, 34);
            searchTeacherCourseWiseToolStripMenuItem.Text = "Search Teacher Course Wise";
            searchTeacherCourseWiseToolStripMenuItem.Click += searchTeacherCourseWiseToolStripMenuItem_Click;
            // 
            // searchTeacherNameWiseToolStripMenuItem
            // 
            searchTeacherNameWiseToolStripMenuItem.Name = "searchTeacherNameWiseToolStripMenuItem";
            searchTeacherNameWiseToolStripMenuItem.Size = new Size(332, 34);
            searchTeacherNameWiseToolStripMenuItem.Text = "Search Teacher Name Wise";
            searchTeacherNameWiseToolStripMenuItem.Click += searchTeacherNameWiseToolStripMenuItem_Click;
            // 
            // searchStaffToolStripMenuItem
            // 
            searchStaffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStaffJobWiseToolStripMenuItem, searchStaffNameWiseToolStripMenuItem });
            searchStaffToolStripMenuItem.Name = "searchStaffToolStripMenuItem";
            searchStaffToolStripMenuItem.Size = new Size(270, 34);
            searchStaffToolStripMenuItem.Text = "Search Staff";
            // 
            // searchStaffJobWiseToolStripMenuItem
            // 
            searchStaffJobWiseToolStripMenuItem.Name = "searchStaffJobWiseToolStripMenuItem";
            searchStaffJobWiseToolStripMenuItem.Size = new Size(302, 34);
            searchStaffJobWiseToolStripMenuItem.Text = "Search Staff Job Wise";
            searchStaffJobWiseToolStripMenuItem.Click += searchStaffJobWiseToolStripMenuItem_Click;
            // 
            // searchStaffNameWiseToolStripMenuItem
            // 
            searchStaffNameWiseToolStripMenuItem.Name = "searchStaffNameWiseToolStripMenuItem";
            searchStaffNameWiseToolStripMenuItem.Size = new Size(302, 34);
            searchStaffNameWiseToolStripMenuItem.Text = "Search Staff Name Wise";
            searchStaffNameWiseToolStripMenuItem.Click += searchStaffNameWiseToolStripMenuItem_Click;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addRecordToolStripMenuItem;
        private ToolStripMenuItem newStudentRecordToolStripMenuItem;
        private ToolStripMenuItem newTeacherEntryToolStripMenuItem;
        private ToolStripMenuItem newStaffEntryToolStripMenuItem;
        private ToolStripMenuItem searchRecordToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem searchStudentCourseWiseToolStripMenuItem;
        private ToolStripMenuItem searchStudentNameWiseToolStripMenuItem;
        private ToolStripMenuItem searchTeacherToolStripMenuItem;
        private ToolStripMenuItem searchTeacherCourseWiseToolStripMenuItem;
        private ToolStripMenuItem searchTeacherNameWiseToolStripMenuItem;
        private ToolStripMenuItem searchStaffToolStripMenuItem;
        private ToolStripMenuItem searchStaffJobWiseToolStripMenuItem;
        private ToolStripMenuItem searchStaffNameWiseToolStripMenuItem;
    }
}