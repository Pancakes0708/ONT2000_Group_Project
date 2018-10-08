using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class SupervisorClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string SupervisorID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CellNo { get; set; }
        public string SupervisorStatus { get; set; }

        public DataTable GetSupervisors()
        {
            return dl.GetSupervisors();
        }

        public void AddSupervisor(string SupervisorID, string FirstName, string Surname, string CellNo)
        {
            dl.AddSupervisor(SupervisorID, FirstName, Surname, CellNo);
        }

        public void UpdateSupervisor(string SupervisorID, string FirstName, string Surname, string CellNo)
        {
            dl.UpdateSupervisor(SupervisorID, FirstName, Surname, CellNo);
        }

        public void DeleteSupervisor(string supervisorID)
        {
            dl.DeleteSupervisor(supervisorID);
        }

        public DataTable GetDeletedSupervisors()
        {
            return dl.GetDeletedSupervisors();
        }

        public void RecoverSupervisor(string SupervisorID)
        {
            dl.RecoverSupervisor(SupervisorID);
        }
    }
}
