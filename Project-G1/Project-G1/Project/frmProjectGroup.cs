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

namespace Project
{
    public partial class frmProjectGroup : Form
    {

        MainMenuClass m = new MainMenuClass();
        GroupClass g = new GroupClass();

        public frmProjectGroup()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Loads Group data into the grid when the form is opened
        private void frmProjectGroup_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProjectGroup.DataSource = g.GetActiveGroups();
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show("SQL Exception: " + sqlError, "Error");
            }
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void assignmentTaskDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.AssignmentTaskForm();
            this.Close();
        }

        private void buddyRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.BuddyRatingForm();
            this.Close();
        }

        // Updates the selected Group's information
        private void btnGroupUpdate_Click(object sender, EventArgs e)
        {
            int x = g.UpdateGroup(int.Parse(txtGroupID.Text), txtProjectID.Text, txtSupervisorID.Text, 
                int.Parse(txtNoOfMembers.Text), int.Parse(txtFinalMark.Text));

            if(x > 0)
            {
                dgvProjectGroup.DataSource = g.GetActiveGroups();
                MessageBox.Show("Group information updated");
            }
        }

        // Sets the selected Group's status to inactive
        private void btnGroupDelete_Click(object sender, EventArgs e)
        {
            int x = g.DeleteGroup(int.Parse(txtGroupID.Text));

            if(x > 0)
            {
                dgvProjectGroup.DataSource = g.GetActiveGroups();
                MessageBox.Show("Group deleted");
            }
        }

        // Clears data from all TextBoxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGroupID.Clear();
            txtProjectID.Clear();
            txtSupervisorID.Clear();
            txtNoOfMembers.Clear();
            txtFinalMark.Clear();
        }

        // Adds a new Group to the database
        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            if (btnGroupAdd.Text == "Enable Add")
            {
                btnGroupAdd.Text = "Add";
                txtGroupID.Clear();
                txtProjectID.Clear();
                txtSupervisorID.Clear();
                txtNoOfMembers.Clear();
                txtFinalMark.Clear();
            }
            else
            {
                int x = g.AddGroup(txtProjectID.Text, txtSupervisorID.Text, int.Parse(txtNoOfMembers.Text));

                if (x > 0)
                {
                    dgvProjectGroup.DataSource = g.GetActiveGroups();
                    btnGroupAdd.Text = "Enable Add";
                    MessageBox.Show("Group added.");
                }
            }
        }
    }
}
