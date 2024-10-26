using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner
{
    public partial class FormMenu : Form
    {
        public static string category, searchCategory;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            category = "student";
            searchCategory = "name";

            FormSearchStudent fs = new FormSearchStudent();
            fs.ShowDialog();
            this.Close();
        }

        private void searchStudentCourseWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "student";
            searchCategory = "course";

            FormSearchStudent fs = new FormSearchStudent();
            fs.ShowDialog();
            this.Close();
        }

        private void searchTeacherNameWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "teacher";
            searchCategory = "name";

            FormSearchTeacher ft = new FormSearchTeacher();
            ft.ShowDialog();
        }

        private void searchTeacherCourseWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "teacher";
            searchCategory = "course";

            FormSearchTeacher ft = new FormSearchTeacher();
            ft.ShowDialog();
            this.Close();
        }

        private void searchStaffNameWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "staff";
            searchCategory = "name";

            FormSearchStaff fss = new FormSearchStaff();
            fss.ShowDialog();
            this.Close();
        }

        private void searchStaffCourseWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category = "staff";
            searchCategory = "job";

            FormSearchStaff fss = new FormSearchStaff();
            fss.ShowDialog();
            this.Close();
        }
    }
}
