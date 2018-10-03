using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class DataAccessLayer
    {
        private string connectionString;
        SqlConnection dbConn; //= new SqlConnection("Data Source = localhost; Initital Catalog  = ONT2000_Project_Database; Integrated Security = SSPI");
        SqlCommand dbCmd = new SqlCommand();
        SqlDataAdapter dbAdapter = new SqlDataAdapter();

        public DataAccessLayer()
        {
            connectionString = "Data Source = localhost; Initial Catalog  = ONT2000_Project_Database; Integrated Security = SSPI";
            dbConn = new SqlConnection(connectionString);
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        // Returns all active Groups
        public DataTable GetActiveGroups()
        {
            dbCmd = new SqlCommand("sp_GetActiveGroups", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        // Adds a new Group to the database
        public int AddGroup(string projID, string supID, int members)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertGroup " + projID + "', '" + supID + "', " + members + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Updates the selected Group's information
        public int UpdateGroup(int groupID, string projID, string supID, int members, int mark)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertGroup " + groupID + "', '" + projID + "', '" + supID + "', " + members + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Sets the selected Group's status to inactive
        public int DeleteGroup(int groupID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteGroup " + groupID + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Returns all active Projects
        public DataTable GetActiveProjects()
        {
            dbCmd = new SqlCommand("sp_GetActiveProjects", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        // Adds a new Project to the database
        public int AddProject(string id, string title, string desc, DateTime startDate, DateTime dueDate, string owner, string supervisor)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertProject " + id + "', '" + title + "', " + desc + "', '" + startDate + 
                "', '" + dueDate + "', '" + owner + "', '" + supervisor + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Updates the selected Project's information
        public int UpdateProject(string id, string title, string desc, DateTime startDate, DateTime dueDate, string owner, string supervisor)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateGroup " + id + "', '" + title + "', " + desc + "', '" + startDate +
                "', '" + dueDate + "', '" + owner + "', '" + supervisor + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Sets the selected Project's status to inactive
        public int DeleteProject(string id)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteProject " + id + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Returns all active Project Tasks
        public DataTable GetActiveProjectTasks()
        {
            dbCmd = new SqlCommand("sp_GetActiveProjectTasks", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        // Adds a new Project Task to the database
        public int AddProjectTask(string projID, DateTime startDate, DateTime dueDate)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertProjectTask " + projID + "', '" + startDate + "', " + dueDate + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Updates the selected Project Task's information
        public int UpdateProjectTask(int taskID, string projID, DateTime startDate, DateTime dueDate, DateTime completedDate)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateProjectTask " + taskID + "', '" + projID + "', '" + startDate + "', " + dueDate + 
                "', '" + completedDate +  "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        // Sets the selected Project Task's status to inactive
        public int DeleteProjectTask(int taskID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteProjectTask " + taskID + "'", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            return dbCmd.ExecuteNonQuery();
        }

        //====================================================================STUDENT METHODS====================================================================
        //Get Student's information
        public DataTable GetAllStudents()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetActiveStudents", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtStudents = new DataTable();
            dbAdapter.Fill(dtStudents);
            return dtStudents;
        }

        //Add A Student
        public int AddStudent(string studentID, string firstName, string surname, string cellNo)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlInsert = "sp_InsertStudent '" + studentID + "', '" + firstName + "', '" + surname + "','" + cellNo + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //Update A Student
        public int UpdateStudent(string studentID, string firstName, string surname, string cellNo)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlUpdate = "sp_UpdateStudent '" + studentID + "', '" + firstName + "', '" + surname + "','" + cellNo + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //Delete A Student
        public int DeleteStudent(string studentID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlDelete = "sp_DeleteStudent '" + studentID + "'";
            dbCmd = new SqlCommand(sqlDelete, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //====================================================================SUPERVISOR METHODS====================================================================
        //Get Supervisor's information
        public DataTable GetSupervisors()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetActiveSupervisors", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtSup = new DataTable();
            dbAdapter.Fill(dtSup);
            return dtSup;
        }

        //Add A Supervisor
        public int AddSupervisor(string supervisorID, string firstName, string surname, string cellNo)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlInsert = "sp_InsertSupervisor '" + supervisorID + "','" + firstName + "','" + surname + "','" + cellNo + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //Update A Supervisor
        public int UpdateSupervisor(string supervisorID, string firstName, string surname, string cellNo)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlUpdate = "sp_UpdateSupervisor '" + supervisorID + "', '" + firstName + "', '" + surname + "','" + cellNo + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //Delete A Supervisor
        public int DeleteSupervisor(string supervisorID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlDelete = "sp_DeleteSupervisor '" + supervisorID + "'";
            dbCmd = new SqlCommand(sqlDelete, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //====================================================================RECOVER METHODS====================================================================
        //Recovery for Students - display
        public DataTable GetDeletedStudents()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetDeletedStudents", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtStudents = new DataTable();
            dbAdapter.Fill(dtStudents);
            return dtStudents;
        }
        //Recovery for Students - recover
        public int RecoverStudent(string studentID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlRecover = "sp_RecoverStudent '" + studentID + "'";
            dbCmd = new SqlCommand(sqlRecover, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        //Recovery for Supervisors - display
        public DataTable GetDeletedSupervisors()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetDeletedSupervisors", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtSupervisors = new DataTable();
            dbAdapter.Fill(dtSupervisors);
            return dtSupervisors;
        }
        //Recovery for Supervisors - recover
        public int RecoverSupervisor(string supervisorID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlRecover = "sp_RecoverSupervisor '" + supervisorID + "'";
            dbCmd = new SqlCommand(sqlRecover, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        //Recovery for Project-Task - display
        public DataTable GetDeletedProjectTasks()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetDeletedProjectTasks", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtProjectTasks = new DataTable();
            dbAdapter.Fill(dtProjectTasks);
            return dtProjectTasks;
        }
        //Recovery for Project-Task - recover
        public int RecoverProjectTask(string projectTaskID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlRecover = "sp_RecoverProjectTask '" + projectTaskID + "'";
            dbCmd = new SqlCommand(sqlRecover, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        //Recovery for Project-Group - display
        public DataTable GetDeletedProjectGroups()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetDeletedProjectGroups", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtProjectGroups = new DataTable();
            dbAdapter.Fill(dtProjectGroups);
            return dtProjectGroups;
        }
        //Recovery for Project-Group - recover
        public int RecoverProjectGroup(string projectGroupID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlRecover = "sp_RecoverProjectGroup '" + projectGroupID + "'";
            dbCmd = new SqlCommand(sqlRecover, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        //Recovery for Project - display
        public DataTable GetDeletedProjects()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbCmd = new SqlCommand("sp_GetDeletedProjects", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            DataTable dtProjects = new DataTable();
            dbAdapter.Fill(dtProjects);
            return dtProjects;
        }
        //Recovery for Project - recover
        public int RecoverProject(string projectID)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sqlRecover = "sp_RecoverProject '" + projectID + "'";
            dbCmd = new SqlCommand(sqlRecover, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
    }
}
