using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class ProjectClass
    {
        private DataAccessLayer dl = new DataAccessLayer();
        private string id;
        private string title;
        private string desc;
        private DateTime startDate;
        private DateTime dueDate;
        private string owner;
        private string supervisor;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return desc; }
            set { desc = value; }
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

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        // Returns a table with all the Projects
        public DataTable GetActiveProjects()
        {
            return dl.GetActiveProjects();
        }

        // Adds a new Project to the database
        public int AddProject(string id, string title, string desc, DateTime startDate, DateTime dueDate, string owner, string supervisor)
        {
            return dl.AddProject(id, title, desc, startDate, dueDate, owner, supervisor);
        }

        // Updates the selected Project's information
        public int UpdateProject(string id, string title, string desc, DateTime startDate, DateTime dueDate, string owner, string supervisor)
        {
            return dl.UpdateProject(id, title, desc, startDate, dueDate, owner, supervisor);
        }

        // Sets the selected Project's status to inactive
        public int DeleteProject(string id)
        {
            return dl.DeleteProject(id);
        }
    }
}
