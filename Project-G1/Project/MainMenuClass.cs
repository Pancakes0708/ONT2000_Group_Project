using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class MainMenuClass
    {
        //SWITCH FORM METHODS
        public void StudentForm()
        {
            frmStudent StudentForm = new frmStudent();
            StudentForm.Show();
        }
        public void SupervisorForm()
        {
            frmSupervisor SupervisorForm = new frmSupervisor();
            SupervisorForm.Show();
        }
        public void ProjectForm()
        {
            //Was renamed to frmProject, Fix(y/n)?
            Project ProjectForm = new Project();
            ProjectForm.Show();
        }
        public void ProjectGroupForm()
        {
            frmProjectGroup ProjectGroupForm = new frmProjectGroup();
            ProjectGroupForm.Show();
        }
        public void ProjectTaskForm()
        {
            frmProjectTask ProjectTaskForm = new frmProjectTask();
            ProjectTaskForm.Show();
        }
        public void AssignmentForm()
        {
            frmAssignment AssignmentForm = new frmAssignment();
            AssignmentForm.Show();
        }
        public void AssignmentTaskForm()
        {
            frmAssignmentTask AssignmentTaskForm = new frmAssignmentTask();
            AssignmentTaskForm.Show();
        }
        public void BuddyRatingForm()
        {
            frmBuddyRating BuddyRatingForm = new frmBuddyRating();
            BuddyRatingForm.Show();
        }
        /*
        public void MainMenuForm()
        {
            frmMainMenu MainMenuForm = new frmMainMenu();
            MainMenuForm.Show();
        }
        */
    }
}
