using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class AssignmentTaskClass
    {
        private DataAccessLayer dl = new DataAccessLayer();
        private int assignmentTaskID;
        private int projectTaskID;
        private string studentID;
        private string assignmentRole;
        private DateTime dateAssigned;
        private int assignmentMark;
        private string comment;
        private string assignmentStatus;

        public int AssignmentTaskID { get; set; }
        public int ProjectTaskID { get; set; }
        public string StudentID { get; set; }
        public string AssignmentRole { get; set; }
        public DateTime DateAssigned { get; set; }
        public int AssignmentMark { get; set; }
        public string Comment { get; set; }
        public string AssignmentStatus { get; set; }

        public int DeleteTaskAssignment(int assignmentTaskID)
        {
            return dl.DeleteTaskAssignment(assignmentTaskID);
        }

        public int RecoverTaskAssignment(int assignmentTaskID)
        {
            return dl.RecoverTaskAssignment(assignmentTaskID);
        }

        public DataTable GetActiveTaskAssignments()
        {
            return dl.GetActiveTaskAssignments();
        }

        public DataTable GetDeletedTaskAssignments()
        {
            return dl.GetDeletedTaskAssignments();
        }

        public int InsertTaskAssignment(int projectTaskID, string studentID, string assignmentRole, DateTime dateAssigned)
        {
            return dl.InsertTaskAssignment(projectTaskID, studentID, assignmentRole, dateAssigned);
        }

        public int UpdateTaskAssignment(int assignmentTaskID, int projectTaskID, string studentID, string assignmentRole, DateTime dateAssigned, int assignmentMark, string comment)
        {
            return dl.UpdateTaskAssignment(assignmentTaskID, projectTaskID, studentID, assignmentRole, dateAssigned, assignmentMark, comment);
        }
    }
}
