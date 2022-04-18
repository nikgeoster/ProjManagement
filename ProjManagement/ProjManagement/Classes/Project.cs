namespace ProjManagement.Classes  
{
    public class Project{
        public Project(int ProjectId)
        {
            //constructor
        }
       public List<Models.Task> GetTasks(int ProjectId)
        {
            //Get all tasks of a particular Project
            List<Models.Task> taskList = new List<Models.Task>();
            return taskList;
        }
        public double GetEffort(int ProjectId){
            return 100;
        }
    }
}