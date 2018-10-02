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
    public partial class frmStudent : Form
    {

        MainMenuClass m = new MainMenuClass();
        StudentClass stu = new StudentClass();
        DataTable dtStudent = new DataTable();

        string studentID;
        string firstName;
        string lastName;
        string cellNo;

        int dgvIndex = 0;

        public frmStudent()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supervisorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.SupervisorForm();
            this.Close();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            dtStudent = stu.GetAllStudents();
            dgvStudent.DataSource = dtStudent;
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

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            if (btnStuAdd.Text == "Enable Add")
            {
                btnStuAdd.Text = "Add";
                txtStudentID.Clear();
                txtStuFirstName.Clear();
                txtStuSurname.Clear();
                txtStuCellNo.Clear();
                txtStudentID.ReadOnly = false;
            }
            else
            {
                studentID = txtStudentID.Text;
                firstName = txtStuFirstName.Text;
                lastName = txtStuSurname.Text;
                cellNo = txtStuCellNo.Text;

                stu.AddStudent(studentID, firstName, lastName, cellNo);
                dtStudent = stu.GetAllStudents();
                dgvStudent.DataSource = dtStudent;

                btnStuAdd.Text = "Enable Add";
                txtStudentID.ReadOnly = true;
                MessageBox.Show("Student Added Successfully!");
            }

        }

        private void btnStuUpdate_Click(object sender, EventArgs e)
        {
            studentID = txtStudentID.Text;
            firstName = txtStuFirstName.Text;
            lastName = txtStuSurname.Text;
            cellNo = txtStuCellNo.Text;

            stu.UpdateStudent(studentID, firstName, lastName, cellNo);
            dtStudent = stu.GetAllStudents();
            dgvStudent.DataSource = dtStudent;
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                txtStudentID.Text = dgvStudent.SelectedRows[0].Cells["StudentID"].Value.ToString();
                txtStuFirstName.Text = dgvStudent.SelectedRows[0].Cells["FirstName"].Value.ToString();
                txtStuSurname.Text = dgvStudent.SelectedRows[0].Cells["LastName"].Value.ToString();
                txtStuCellNo.Text = dgvStudent.SelectedRows[0].Cells["CellNo"].Value.ToString();
                dgvIndex = dgvStudent.SelectedRows[0].Index;
            }
        }

        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            studentID = txtStudentID.Text;
            txtStudentID.Clear();
            txtStuFirstName.Clear();
            txtStuSurname.Clear();
            txtStuCellNo.Clear();

            stu.DeleteStudent(studentID);
            dtStudent = stu.GetAllStudents();
            dgvStudent.DataSource = dtStudent;
        }
    }
}
