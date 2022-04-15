using ProjManagement.Models.Task;

namespace ProjManagement.Classes  
{
    public class Project{
        public Project(int ProjectId)
        {
            //constructor
        }
       public bool GetTasks(int ProjectId)
        {
            //Get all tasks of a particular Project
            List<Models.Task> taskList = new List<Models.Task>();
            return taskList;
        }
        public decimal GetEffort(int ProjectId){
            return 100;
        }
    }
}