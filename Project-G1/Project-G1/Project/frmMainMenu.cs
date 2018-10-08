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
    public partial class frmMainMenu : Form
    {

        MainMenuClass m = new MainMenuClass();

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStuDetails_Click(object sender, EventArgs e)
        {
            m.StudentForm();
        }

        private void btnSuDetails_Click(object sender, EventArgs e)
        {
            m.SupervisorForm();
        }

        private void btnProDetails_Click(object sender, EventArgs e)
        {
            m.ProjectForm();
        }

        private void btnProGroupDetails_Click(object sender, EventArgs e)
        {
            m.ProjectGroupForm();
        }

        private void btnProTaskDetails_Click(object sender, EventArgs e)
        {
            m.ProjectTaskForm();
        }

        private void btnAssDetails_Click(object sender, EventArgs e)
        {
            m.AssignmentForm();
        }

        private void btnAssTaskDetails_Click(object sender, EventArgs e)
        {
            m.AssignmentTaskForm();
        }

        private void btnBuddyRating_Click(object sender, EventArgs e)
        {
            m.BuddyRatingForm();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            m.RecoveryForm();
        }
    }
}
