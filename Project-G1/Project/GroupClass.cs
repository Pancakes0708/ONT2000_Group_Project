using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class GroupClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        private string groupID;
        private string projID;
        private string supID;
        private int numberOfMembers;
        private int finalMark;
        
        public string GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string ProjectID
        {
            get { return projID; }
            set { projID = value; }
        }

        public string SupervisorID
        {
            get { return supID; }
            set { supID = value; }
        }

        public int NumberOfMembers
        {
            get { return numberOfMembers; }
            set { numberOfMembers = value; }
        }

        public int FinalMark
        {
            get { return finalMark; }
            set { numberOfMembers = value; }
        }

        // Returns a table with all the Groups
        public DataTable GetActiveGroups()
        {
            return dl.GetActiveGroups();
        }

        // Adds a new Group to the database
        public int AddGroup(string projID, string supID, int members)
        {
            return dl.AddGroup(projID, supID, members);
        }

        // Updates the selected Group's information
        public int UpdateGroup(int groupID, string projID, string supID, int members, int mark)
        {
            return dl.UpdateGroup(groupID, projID, supID, members, mark);
        }

        // Sets the selected Group's status to inactive
        public int DeleteGroup(int groupID)
        {
            return dl.DeleteGroup(groupID);
        }

        public DataTable GetDeletedProjectGroups()
        {
            return dl.GetDeletedProjectGroups();
        }

        public void RecoverProjectGroup(string ProjectGroupID)
        {
            dl.RecoverProjectGroup(ProjectGroupID);
        }
    }
}
