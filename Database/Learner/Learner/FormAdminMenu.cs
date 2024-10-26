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
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void addNewStudentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.ShowDialog();
        }

        private void addNewTeacherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher ft = new FormTeacher();
            ft.ShowDialog();
        }

        private void addNewStaffEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStaff fs = new FormStaff();
            fs.ShowDialog();
        }
    }
}
