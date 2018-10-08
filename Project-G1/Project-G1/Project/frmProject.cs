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
    public partial class Project : Form
    {

        MainMenuClass m = new MainMenuClass();
        ProjectClass p = new ProjectClass();

        public Project()
        {
            InitializeComponent();
        }

        // Loads Project data into the grid when the form is opened
        private void Project_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProject.DataSource = p.GetActiveProjects();
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show("SQL Exception: " + sqlError, "Error");
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        // Adds a new Project to the database
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            if(btnProAdd.Text == "Enable Add")
            {
                btnProAdd.Text = "Add";
                txtProjectID.Clear();
                txtProTitle.Clear();
                txtProDesc.Clear();
                dteProStartDate.Value = DateTime.Now;
                dteProDueDate.Value = DateTime.Now;
                txtProOwner.Clear();
                txtProjectID.ReadOnly = false;
            }
            else
            {
                int x = p.AddProject(txtProjectID.Text, txtProTitle.Text, txtProDesc.Text, dteProStartDate.Value,
                    dteProDueDate.Value, txtProOwner.Text, txtProSupervisor.Text);

                if(x > 0)
                {
                    dgvProject.DataSource = p.GetActiveProjects();
                    btnProAdd.Text = "Enable Add";
                    txtProjectID.ReadOnly = true;
                    MessageBox.Show("Project added.");
                }
            }
        }

        // Updates the selected Project's information
        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            int x = p.UpdateProject(txtProjectID.Text, txtProTitle.Text, txtProDesc.Text, dteProStartDate.Value,
                    dteProDueDate.Value, txtProOwner.Text, txtProSupervisor.Text);

            if(x > 0)
            {
                dgvProject.DataSource = p.GetActiveProjects();
                MessageBox.Show("Project information updated.");
            }
        }

        // Sets the selected Project's status to inactive
        private void btnProDelete_Click(object sender, EventArgs e)
        {
            int x = p.DeleteProject(txtProjectID.Text);

            if(x > 0)
            {
                dgvProject.DataSource = p.GetActiveProjects();
                MessageBox.Show("Project deleted.");
            }
        }

        // Clears all TextBoxes and DateTimePickers
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectID.Clear();
            txtProTitle.Clear();
            txtProDesc.Clear();
            dteProStartDate.Value = DateTime.Now;
            dteProDueDate.Value = DateTime.Now;
            txtProOwner.Clear();
        }
    }
}
