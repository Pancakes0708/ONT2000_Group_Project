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
    public partial class frmSupervisor : Form
    {

        MainMenuClass m = new MainMenuClass();
        SupervisorClass sup = new SupervisorClass();
        DataTable dtSup = new DataTable();

        string supervisorID;
        string name;
        string surname;
        string cellNo;

        int dgvIndex = 0;

        public frmSupervisor()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupervisor_Load(object sender, EventArgs e)
        {
            dtSup = sup.GetSupervisors();
            dgvSupervisor.DataSource = dtSup;
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.StudentForm();
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

        private void btnSuAdd_Click(object sender, EventArgs e)
        {
            if (btnSuAdd.Text == "Enable Add")
            {
                btnSuAdd.Text = "Add";
                txtSupervisorID.Clear();
                txtSuFirstName.Clear();
                txtSuSurname.Clear();
                txtSuCellNo.Clear();
                txtSupervisorID.ReadOnly = false;
            }
            else
            {
                supervisorID = txtSupervisorID.Text;
                name = txtSuFirstName.Text;
                surname = txtSuSurname.Text;
                cellNo = txtSuCellNo.Text;

                sup.AddSupervisor(supervisorID, name, surname, cellNo);
                dtSup = sup.GetSupervisors();
                dgvSupervisor.DataSource = dtSup;

                btnSuAdd.Text = "Enable Add";
                txtSupervisorID.ReadOnly = true;
                MessageBox.Show("Supervisor Added Successfully!");
            }
        }

        private void btnSuUpdate_Click(object sender, EventArgs e)
        {
            supervisorID = txtSupervisorID.Text;
            name = txtSuFirstName.Text;
            surname = txtSuSurname.Text;
            cellNo = txtSuCellNo.Text;

            sup.UpdateSupervisor(supervisorID, name, surname, cellNo);

            dtSup = sup.GetSupervisors();
            dgvSupervisor.DataSource = dtSup;
        }

        private void dgvSupervisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupervisor.SelectedRows.Count > 0)
            {
                txtSupervisorID.Text = dgvSupervisor.SelectedRows[0].Cells["StaffID"].Value.ToString();
                txtSuFirstName.Text = dgvSupervisor.SelectedRows[0].Cells["FirstName"].Value.ToString();
                txtSuSurname.Text = dgvSupervisor.SelectedRows[0].Cells["LastName"].Value.ToString();
                txtSuCellNo.Text = dgvSupervisor.SelectedRows[0].Cells["CellNo"].Value.ToString();
                dgvIndex = dgvSupervisor.SelectedRows[0].Index;
            }
        }

        private void btnSuDelete_Click(object sender, EventArgs e)
        {
            supervisorID = txtSupervisorID.Text;
            txtSupervisorID.Clear();
            txtSuFirstName.Clear();
            txtSuSurname.Clear();
            txtSuCellNo.Clear();

            sup.DeleteSupervisor(supervisorID);
            dtSup = sup.GetSupervisors();
            dgvSupervisor.DataSource = dtSup;
        }
    }
}
