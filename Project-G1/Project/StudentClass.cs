using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class StudentClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellNo { get; set; }

        public DataTable GetAllStudents()
        {
            return dl.GetAllStudents();
        }

        public void AddStudent(string StudentID, string FirstName, string LastName, string CellNo)
        {
            dl.AddStudent(StudentID, FirstName, LastName, CellNo);
        }

        public void UpdateStudent(string StudentID, string FirstName, string LastName, string CellNo)
        {
            dl.UpdateStudent(StudentID, FirstName, LastName, CellNo);
        }

        public void DeleteStudent(string StudentID)
        {
            dl.DeleteStudent(StudentID);
        }

        public DataTable GetDeletedStudents()
        {
            return dl.GetDeletedStudents();
        }

        public void RecoverStudent(string StudentID)
        {
            dl.RecoverStudent(StudentID);
        }
    }
}
