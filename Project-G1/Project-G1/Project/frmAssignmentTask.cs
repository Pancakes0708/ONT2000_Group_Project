using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmAssignmentTask : Form
    {

        MainMenuClass m = new MainMenuClass();

        public frmAssignmentTask()
        {
            InitializeComponent();
        }


        private void frmAssignmentTask_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            m.StudentForm();
            this.Close();
        }

        private void supervisorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.SupervisorForm();
            this.Close();
        }

        private void projectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.ProjectForm();
            this.Close();
        }

        private void projectGroupDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.ProjectGroupForm();
            this.Close();
        }

        private void projectTaskDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.ProjectTaskForm();
            this.Close();
        }

        private void assignmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.AssignmentForm();
            this.Close();
        }

        private void buddyRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.BuddyRatingForm();
            this.Close();
        }
    }
}
