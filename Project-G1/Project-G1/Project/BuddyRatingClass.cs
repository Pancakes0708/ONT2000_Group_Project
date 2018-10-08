using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class BuddyRatingClass
    {
        private DataAccessLayer dl = new DataAccessLayer();
        private int buddyID;
        private string projectID;
        private string studentID;
        private string evaluatorStudentID;
        private int mark;

        public int BuddyID { get; set; }
        public string ProjectID { get; set; }
        public string StudentID { get; set; }
        public string EvaluatorStudentID { get; set; }
        public int Mark { get; set; }

        public DataTable GetAllBuddyRatings()
        {
            return dl.GetAllBuddyRatings();
        }

        public int InsertBuddyRating(string projectID, string studentID, string evaluatorStudentID, int mark)
        {
            return dl.InsertBuddyRating(projectID, studentID, evaluatorStudentID, mark);
        }

        public int UpdateBuddyRating(int buddyID, string projectID, string studentID, string evaluatorStudentID, int mark)
        {
            return dl.UpdateBuddyRating(buddyID, projectID, studentID, evaluatorStudentID, mark);
        }
    }
}
