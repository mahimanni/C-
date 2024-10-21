using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace School
{
    public partial class FormMenu : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        SqlDataReader dr;

        public static string category, searchCategory;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void newStudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.ShowDialog();
            //this.Close();
        }

        private void newTeacherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher fs = new FormTeacher();
            fs.ShowDialog();
            //this.Close();
        }

        private void newStaffEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStaff fs = new FormStaff();
            fs.ShowDialog();
            //this.Close();
        }

        private void searchStudentCourseWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "student";
            searchCategory = "course";

            FormSearch fs = new FormSearch();
            fs.ShowDialog();
            //this.Close();
        }

        private void searchStudentNameWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "student";
            searchCategory = "name";

            FormSearch fs = new FormSearch();
            fs.ShowDialog();
        }

        private void searchTeacherCourseWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "teacher";
            searchCategory = "course";

            FormSearchTeacher ft = new FormSearchTeacher();
            ft.ShowDialog();
        }

        private void searchTeacherNameWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "teacher";
            searchCategory = "name";

            FormSearchTeacher ft = new FormSearchTeacher();
            ft.ShowDialog();
        }

        private void searchStaffJobWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "staff";
            searchCategory = "job";

            FormSearchStaff fss = new FormSearchStaff();
            fss.ShowDialog();
        }

        private void searchStaffNameWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "staff";
            searchCategory = "name";

            FormSearchStaff fss = new FormSearchStaff();
            fss.ShowDialog();
        }
    }
}
