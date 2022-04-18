namespace ProjManagement.Classes
{
    public class Tasks{
        public Tasks(int TaskId)
        {
            //constructor
        }
        public Models.Dependency GetDependency(int ProjectId)
        {
            return new Models.Dependency();
        }
    }
}