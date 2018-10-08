using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class AssignmentClass
    {
        private DataAccessLayer dl = new DataAccessLayer();
        private int assignmentID;
        private string projectID;
        private string studentID;
        private DateTime dateAssigned;
        private string roleOnProject;
        private int studentProjectMark;
        private int studentBuddyMark;
        private string comment;
        private string assignmentStatus;

        public int AssignmentID{ get; set; }
        public string ProjectID { get; set; }
        public string StudentID { get; set; }
        public DateTime DateAssigned { get; set; }
        public string RoleOnProject { get; set; }
        public int StudentProjectMark { get; set; }
        public int StudentBuddyMark { get; set; }
        public string Comment { get; set; }
        public string AssignmentStatus { get; set; }

        public int DeleteAssignment(int assignmentID)
        {
            return dl.DeleteAssignment(assignmentID);
        }

        public int RecoverAssignment(int assignmentID)
        {
            return dl.RecoverAssignment(assignmentID);
        }

        public DataTable GetActiveAssignments()
        {
            return dl.GetActiveAssignments();
        }

        public DataTable GetDeletedAssignments()
        {
            return dl.GetDeletedAssignments();
        }

        public int InsertAssignment(string projectID, string studentID, DateTime dateAssigned, string roleOnProject)
        {
            return dl.InsertAssignment(projectID, studentID, dateAssigned, roleOnProject);
        }

        public int UpdateAssignment(int assignmentID, string projectID, string studentID, DateTime dateAssigned, string roleOnProject, int studentProjectMark, int studentBuddyMark, string comment)
        {
            return dl.UpdateAssignment(assignmentID, projectID, studentID, dateAssigned, roleOnProject, studentProjectMark, studentBuddyMark, comment);
        }
    }
}
