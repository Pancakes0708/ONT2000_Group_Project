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
    public partial class frmProjectTask : Form
    {

        MainMenuClass m = new MainMenuClass();
        ProjectTaskClass pt = new ProjectTaskClass();

        public frmProjectTask()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Loads all Project Tasks data into the grid when the form is opened
        private void frmProjectTask_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProjectTask.DataSource = pt.GetActiveProjectTasks();
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

        private void projectGroupDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.ProjectGroupForm();
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

        // Adds a new Project Task to the database
        private void btnProTaskAdd_Click(object sender, EventArgs e)
        {
            if (btnProTaskAdd.Text == "Enable Add")
            {
                btnProTaskAdd.Text = "Add";
                txtProjectTaskID.Clear();
                txtProjectID.Clear();
                dteTaskStartDate.Value = DateTime.Today;
                dteTaskEndDate.Value = DateTime.Today;
                dteTaskCompleted.Value = DateTime.Today;
            }
            else
            {
                int x = pt.AddProjectTask(txtProjectID.Text, dteTaskStartDate.Value, dteTaskEndDate.Value);

                if(x > 0)
                {
                    dgvProjectTask.DataSource = pt.GetActiveProjectTasks();
                    btnProTaskAdd.Text = "Enable Add";
                    MessageBox.Show("Project task added.");
                }
            }
        }

        // Updates the selected Project Task's information
        private void btnProTaskUpdate_Click(object sender, EventArgs e)
        {
            int x = pt.UpdateProjectTask(int.Parse(txtProjectTaskID.Text), txtProjectID.Text, dteTaskStartDate.Value,
                dteTaskEndDate.Value, dteTaskCompleted.Value);

            if (x > 0)
            {
                dgvProjectTask.DataSource = pt.GetActiveProjectTasks();
                MessageBox.Show("Task information updated.");
            }
        }

        // Sets the selected Project Task's status to inactive
        private void btnProTaskDelete_Click(object sender, EventArgs e)
        {
            int x = pt.DeleteProjectTask(int.Parse(txtProjectTaskID.Text));

            if(x > 0)
            {
                dgvProjectTask.DataSource = pt.GetActiveProjectTasks();
                MessageBox.Show("Task deleted.");
            }
        }

        // Clears all the TextBoxes and DateTimePickers
        private void btnProTaskClear_Click(object sender, EventArgs e)
        {
            txtProjectTaskID.Clear();
            txtProjectID.Clear();
            dteTaskStartDate.Value = DateTime.Today;
            dteTaskEndDate.Value = DateTime.Today;
            dteTaskCompleted.Value = DateTime.Today;
        }
    }
}
