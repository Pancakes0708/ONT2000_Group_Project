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
    public partial class frmRecovery : Form
    {
        StudentClass stu = new StudentClass();
        SupervisorClass sup = new SupervisorClass();
        ProjectTaskClass ptc = new ProjectTaskClass();
        ProjectClass pc = new ProjectClass();
        GroupClass gc = new GroupClass();
        //buddyrating
        //assignmenttask
        //assignment

        DataTable dtDeleted = new DataTable();
        int dgvIndex = 0;
        string itemID;
        int value;

        public frmRecovery()
        {
            InitializeComponent();
        }

        private void frmRecovery_Load(object sender, EventArgs e)
        {
            cmbTables.Items.Add("Student");
            cmbTables.Items.Add("Supervisor");
            cmbTables.Items.Add("Project-Task");
            cmbTables.Items.Add("Project-Group");
            cmbTables.Items.Add("Project");
            cmbTables.Items.Add("Buddy-Rating");
            cmbTables.Items.Add("Assignment-Task");
            cmbTables.Items.Add("Assignment");
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Testing...
            //string strName = cmbTables.Text;
            //MessageBox.Show(strName);
            //Testing...
            switch (cmbTables.SelectedIndex)
            {
                case 0:
                    dtDeleted = stu.GetDeletedStudents();
                    dgvRecovery.DataSource = dtDeleted;
                    value = 0;
                    break;
                case 1:
                    dtDeleted = sup.GetDeletedSupervisors();
                    dgvRecovery.DataSource = dtDeleted;
                    value = 1;
                    break;
                case 2:
                    dtDeleted = ptc.GetDeletedProjectTasks();
                    dgvRecovery.DataSource = dtDeleted;
                    value = 2;
                    break;
                case 3:
                    dtDeleted = gc.GetDeletedProjectGroups();
                    dgvRecovery.DataSource = dtDeleted;
                    value = 3;
                    break;
                case 4:
                    dtDeleted = pc.GetDeletedProjects();
                    dgvRecovery.DataSource = dtDeleted;
                    value = 4;
                    break;
                case 5:
                    //buddy rating
                    break;
                case 6:
                    //assignment task
                    break;
                case 7:
                    //assignment
                    break;
                default:
                    break;

            }
        }

        private void dgvRecovery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRecovery.SelectedRows.Count > 0)
            {
                txtID.Text = dgvRecovery.SelectedRows[0].Cells[0].Value.ToString();
                dgvIndex = dgvRecovery.SelectedRows[0].Index;
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (dgvIndex > 0)
            {
                itemID = txtID.Text;
                if (value == 0)
                {
                    stu.RecoverStudent(itemID);
                    dtDeleted = stu.GetDeletedStudents();
                    dgvRecovery.DataSource = dtDeleted;
                }
                else if (value == 1)
                {
                    sup.RecoverSupervisor(itemID);
                    dtDeleted = sup.GetDeletedSupervisors();
                    dgvRecovery.DataSource = dtDeleted;
                }
                else if (value == 2)
                {
                    ptc.RecoverProjectTask(itemID);
                    dtDeleted = ptc.GetDeletedProjectTasks();
                    dgvRecovery.DataSource = dtDeleted;
                }
                else if (value == 3)
                {
                    gc.RecoverProjectGroup(itemID);
                    dtDeleted = gc.GetDeletedProjectGroups();
                    dgvRecovery.DataSource = dtDeleted;
                }
                else if(value == 4)
                {
                    pc.RecoverProject(itemID);
                    dtDeleted = pc.GetDeletedProjects();
                    dgvRecovery.DataSource = dtDeleted;
                }
                else if(value == 5)
                {
                    //buddy rating
                }
                else if (value == 6)
                {
                    //assignment task
                }
                else if (value == 7)
                {
                    //assignment
                }
            }
            else
            {
                MessageBox.Show("No selected row!");
            }
        }
    }
}
