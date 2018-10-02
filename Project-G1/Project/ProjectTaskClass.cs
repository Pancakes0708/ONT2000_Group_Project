using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class ProjectTaskClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        private int taskID;
        private string projID;
        private DateTime startDate;
        private DateTime dueDate;
        private DateTime completedDate;

        public int TaskID
        {
            get { return taskID; }
            set { taskID = value; }
        }

        public string ProjectID
        {
            get { return projID; }
            set { projID = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public DateTime CompletedDate
        {
            get { return completedDate; }
            set { completedDate = value; }
        }

        // Returns a table with all the Project Tasks data
        public DataTable GetActiveProjectTasks()
        {
            return dl.GetActiveProjectTasks();
        }

        // Adds a new Project Task to the database 
        public int AddProjectTask(string projID, DateTime startDate, DateTime dueDate)
        {
            return dl.AddProjectTask(projID, startDate, dueDate);
        }

        // Updates the selected Project Task's information
        public int UpdateProjectTask(int taskID, string projID, DateTime startDate, DateTime dueDate, DateTime completedDate)
        {
            return dl.UpdateProjectTask(taskID, projID, startDate, dueDate, completedDate);
        }

        // Sets the selected Project Task's status to inactive
        public int DeleteProjectTask(int taskID)
        {
            return dl.DeleteProjectTask(taskID);
        }
    }
}
